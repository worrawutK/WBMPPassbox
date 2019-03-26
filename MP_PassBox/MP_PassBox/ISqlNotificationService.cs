using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
using System.Threading;

namespace MP_PassBox
{
    public interface ISqlNotificationService
    {
        void OnSqlChangeData(object sender, SqlNotificationEventArgs e);
        //void OnSqlChangeData(DataSet dataSet);
    }
    public class SqlNotificationService
        : ISqlNotificationService
    {

        public event SqlChangeEventHandler SqlChange;
        SqlConnection Connection = null;
        SqlCommand Command = null;
        DataSet dataToWatch = null;
        public string ConString { get; set; }
        //public List<string> CmdText;
        public string CmdText { get; set; }
        public string TableName { get; set; }
        public SqlDependency Dependency { get; set; }
        //public ISynchronizeInvoke EventSyncInvoke { get; set; }
        public SynchronizationContext _SynchronizationContext;
        public SendOrPostCallback _CallbackFunction;
        //IsManyService:true Should do SqlDependency.Stop(ConString) manual fix before new SqlNotificationService
        public bool IsManyService { get; set; }

        public void Start()
        {
            _SynchronizationContext = SynchronizationContext.Current;
            if (ConString == "" || TableName == "" || CmdText == "")
                return;
            switch (IsManyService)
            {
                case true:
                    SqlDependency.Start(ConString);
                    break;
                default:
                    SqlDependency.Stop(ConString);
                    SqlDependency.Start(ConString);
                    break;
            }
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(ConString);
                Command = new SqlCommand(CmdText, Connection);
                if (dataToWatch == null)
                    dataToWatch = new DataSet();


                dataToWatch.Clear();
                Command.Notification = null;
                Dependency = new SqlDependency(Command); //https://stackoverflow.com/questions/20503286/using-sqldependency-with-named-queues
                Dependency.OnChange += Dependency_OnChange;
                using (SqlDataAdapter adapter = new SqlDataAdapter(Command))
                {
                    adapter.Fill(dataToWatch, TableName);
                }
                //OnSqlChangeData(Dependency, null);
                SqlChange?.Invoke(this, new SqlChangeEventArgs()
                {
                    TableDataSet = dataToWatch
                });
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            //fix Cross-thread
            _SynchronizationContext.Post(o => OnSqlChangeData(sender, e), null);
        }

        public void OnSqlChangeData(object sender, SqlNotificationEventArgs e)
        {
            Dependency = (SqlDependency)sender;
            Dependency.OnChange -= Dependency_OnChange;
            if (e.Type != SqlNotificationType.Change)
                return;

            dataToWatch.Clear();
            Command.Notification = null;
            Dependency = new SqlDependency(Command);
            Dependency.OnChange += Dependency_OnChange;
            using (SqlDataAdapter adapter = new SqlDataAdapter(Command))
            {
                adapter.Fill(dataToWatch, TableName);
            }

            SqlChange?.Invoke(this, new SqlChangeEventArgs()
            {
                TableDataSet = dataToWatch
            });
        }
        #region LastFunction
        //private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    try
        //    {

        //        //ISynchronizeInvoke i = (ISynchronizeInvoke)c_MainForm;
        //        if (EventSyncInvoke.InvokeRequired)
        //        {
        //            OnChangeEventHandler tempDelegate = new OnChangeEventHandler(Dependency_OnChange);
        //            object[] args = new[] { sender, e };
        //            EventSyncInvoke.BeginInvoke(tempDelegate, args);
        //            return;
        //        }

        //        Dependency = (SqlDependency)sender;
        //        Dependency.OnChange -= Dependency_OnChange;
        //        if (e.Type != SqlNotificationType.Change)
        //            return;


        //        dataToWatch.Clear();
        //        Command.Notification = null;
        //        Dependency = new SqlDependency(Command);
        //        Dependency.OnChange += Dependency_OnChange;
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(Command))
        //        {
        //            adapter.Fill(dataToWatch, TableName);
        //        }
        //        OnSqlChangeData(dataToWatch);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //public void OnSqlChangeData(DataSet Data)
        //{

        //    SqlChange?.Invoke(this, new SqlChangeEventArgs()
        //    {
        //        TableDataSet = Data
        //    });
        //}
        #endregion

        public class SqlChangeEventArgs
        {
            public DataSet TableDataSet { get; set; }

        }
        public delegate void SqlChangeEventHandler(object sender, SqlChangeEventArgs e);

    }
}

