using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;

namespace MP_PassBox
{
    public partial class UC_PassBox : UserControl
    {
        public UC_PassBox()
        {
            InitializeComponent();
        }

        DateTime? timeInput;
        
        public void ShowPassBoxData(ClassPassBox passBox)
        {
            btn_queue.Text = passBox.Queue.ToString();
            lbl_LotNo.Text = passBox.LotNo;
            lbl_Package.Text = passBox.Package;
            lbl_Input.Text = "INPUT DATE : " + passBox.In_Date;
            lbl_Shipment.Text = "SHIPMENT DATE : " + passBox.Out_Date;
            
            bgPanel.BackColor = passBox.BgColor;
            timeInput = passBox.EndTimeBeforeProcess;
            timer1.Start();
        }

        public void ClearData()
        {
            btn_queue.Text = "";
            lbl_LotNo.Text = "";
            lbl_Package.Text = "";
            lbl_Input.Text = "INPUT DATE : ";
            lbl_Shipment.Text = "SHIPMENT DATE : ";
            bgPanel.BackColor = Color.White;
            
            lbl_time.Text = "00:00:00";
            timer1.Stop();

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeInput != null)
            {
                TimeSpan? dTime = DateTime.Now - timeInput;
                lbl_time.Text = Math.Floor(dTime.Value.TotalHours).ToString("00") + ":" + dTime.Value.Minutes.ToString("00") + ":" + dTime.Value.Seconds.ToString("00");

                if(dTime.Value.TotalHours < 6)
                {
                    bgPanel.BackColor = Color.LightGreen;
                }
                else if (dTime.Value.TotalHours >= 6 && dTime.Value.TotalHours < 12)
                {
                    bgPanel.BackColor = Color.Yellow;
                }
                else if (dTime.Value.TotalHours >= 12)
                {
                    bgPanel.BackColor = Color.LightCoral;
                }

            }
            else
            {
                lbl_time.Text = "00:00:00";
                timer1.Stop();
            }
            
        }

        DataSetPassBox.WBMPPassboxDataTable wBMP;
        DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter adapter;
        
        private void btn_queue_Click(object sender, EventArgs e)
        {
            if (lbl_LotNo.Text != "")
            {
                
            wBMP = new DataSetPassBox.WBMPPassboxDataTable();
            adapter = new DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter();
            wBMP = adapter.GetDataPassBox(Properties.Settings.Default.MCNo);
            //List<ClassPassBox> history = new List<ClassPassBox>();

            foreach (DataSetPassBox.WBMPPassboxRow row in wBMP)
            {

                if (this.Name == "uc_" + row.ChannelNumber)

                {
                    Frm_Main f2 = new Frm_Main();
                    row.LotEndTime = DateTime.Now;
                    row.OPNoOut = ParameterPB.OP;
                    adapter.Update(wBMP);
                    
                    ClassPassBox historyData = new ClassPassBox();
                    
                    historyData.LotNo = "LotNo : " + lbl_LotNo.Text;
                    historyData.Package = "Package : " + lbl_Package.Text;
                    historyData.In_Date = lbl_Input.Text;
                    //historyData.Out_Date = "EndTime : " + row.LotEndTime;
                    historyData.channel = "Channel : " + row.ChannelNumber;
                    //XmlSave.SaveData(historyData, @"C:\Users\user454\Desktop\Witchaya M\MP_PassBox\MP_PassBox\bin\Debug\HistoryPassBox.xml");
                     
                    addlogfile("(Queue Out) " + "OP In : " + row.OPNoIn + ", " + historyData.LotNo + ", " + historyData.Package + ", " + historyData.In_Date + ", " + historyData.channel + ", " + "Time in " + row.ChannelNumber + " : " + lbl_time.Text );
                    ClearData();
                    break;
                }
                
            }
        }

            else
            {
                Frm_message f1 = new Frm_message();

                if (f1.ShowDialog() == DialogResult.OK)
                {
                    wBMP = new DataSetPassBox.WBMPPassboxDataTable();
                    adapter = new DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter();
                    wBMP = adapter.GetDataBackup(Properties.Settings.Default.MCNo, this.Name.Substring(3, 8));
    
                    foreach (DataSetPassBox.WBMPPassboxRow row1 in wBMP)
                    {

                        if (this.Name == "uc_" + row1.ChannelNumber)

                        {
                            row1.SetLotEndTimeNull();
                            adapter.Update(wBMP);

                            ClassPassBox BackupData = new ClassPassBox();

                            BackupData.LotNo = "LotNo : " + row1.LotNo;
                            //BackupData.Package = "Package : " + lbl_Package.Text;
                            //BackupData.In_Date = "Input Date : ";
                            //BackupData.Out_Date = lbl_Shipment.Text;
                            BackupData.channel = "Channel : " + row1.ChannelNumber;
                            addlogfile("(BackupData) " + "OP Out : " + row1.OPNoOut + ", "+ BackupData.LotNo + ", " + BackupData.channel);
                           
                            break;
                        }

                    }

                }

            }
            
        }

        public void addlogfile(string m)
        {
            string logfile = System.Environment.CurrentDirectory + @"\Log\history.log";
            string logfileBackup = System.Environment.CurrentDirectory + @"\Log\historyBackup.log";

            string folderLog = System.Environment.CurrentDirectory + @"\Log";

            bool exists = System.IO.Directory.Exists(folderLog);

            if (!exists)
                System.IO.Directory.CreateDirectory(folderLog);

            using (StreamWriter outfile = new StreamWriter(logfile, true))
            {
                outfile.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " >> " + m );
            }
            StreamReader sr = File.OpenText(logfile);
            if (sr.BaseStream.Length > 5000000)
            {
                sr.Close();
                if(File.Exists(logfileBackup))
                {
                    File.Delete(logfileBackup);
                }
                File.Copy(logfile, logfileBackup, true);
                File.Delete(logfile);
            }

            sr.Close();
        }

    }
}
