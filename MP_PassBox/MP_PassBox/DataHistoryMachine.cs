using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_PassBox
{
    public partial class DataHistoryMachine : Form
    {
        public DataHistoryMachine()
        {
            InitializeComponent();
        }

        DataSetPassBox.WBMPPassboxDataTable dataTable;
        DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter adapter;

        private void DataHistoryMachine_Load(object sender, EventArgs e)
        {
            dataTable = new DataSetPassBox.WBMPPassboxDataTable();
            adapter = new DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter();
            dataTable = adapter.GetHistoryData(Properties.Settings.Default.MCNo);
            dataGridView1.DataSource = dataTable;

        }
    }
}
