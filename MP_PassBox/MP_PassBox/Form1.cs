using MP_PassBox.Properties;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO.StreamWriter;

namespace MP_PassBox
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        bool checkLogin;
        private Resize c_Resize = new Resize();

        //DataSetPassBox.WBMPPassboxDataTable dataBackup;
        //DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter backup;

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            checkLogin = false;
            showPassBox();
            lblMC.Text = "-";
            btnView.Enabled = false;
            //cbxMC.Enabled = false;
            SqlNotificationService();
            //cbxMC.SelectedIndex = 0;
            lblMC.Text = Settings.Default.MCNo;
            timer1.Stop();
            c_Resize.FindAllControls(this);
            //XmlSave.SaveData(Settings.Default.MCNo, @"C:\Users\user454\Desktop\Witchaya M\MP_PassBox\MP_PassBox\bin\Debug\MCName.xml");
        }

        private SqlNotificationService service;
        private void SqlNotificationService()
        {
            service = new SqlNotificationService();
            service.ConString = AppSettingHelper.GetConnectionStringValue("MP_PassBox.Properties.Settings.DBxConnectionString"); //"Data Source=10.28.33.11;Initial Catalog=DBx;User ID=sa;Password=p@$$w0rd";
            service.CmdText = "SELECT MCNo,LotNo,LotStartTime,OPNoIn,OPNoOut,LotEndTime,ChannelNumber,NetVersion,SelfConVersion,Remark FROM dbo.WBMPPassbox WHERE MCNo = '" + Settings.Default.MCNo + "' AND LotEndTime IS NULL";
            service.TableName = "WBMPPassbox";
            service.SqlChange += Service_SqlChange;
            service.Start();
        }

        private void Service_SqlChange(object sender, SqlNotificationService.SqlChangeEventArgs e)
        {
                Getdata();
                UpdateDisplay();
        }

        //DataSetPassBox.WBMPPassboxDataTable wBMP;
        //DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter adapter;
        
        DataSetPassBox.DataPassBoxDataTable dataAll;
        DataSetPassBoxTableAdapters.DataPassBoxTableAdapter _data;
        List<ClassPassBox> c_PassBoxList;
        
        private void UpdateDisplay()
        {
            foreach(Control user in panel1.Controls)
            {
                if(user.GetType()==typeof(UC_PassBox))
                {
                    UC_PassBox control = (UC_PassBox)user;
                    bool isPass = false;

                    foreach (ClassPassBox passBox in c_PassBoxList)
                    {
                        if (control.Name == "uc_" + passBox.channel)
                        {
                            control.ShowPassBoxData(passBox);
                            isPass = true;
                            break;
                        }
                    }

                    if (isPass == false)
                    {
                        control.ClearData();
                    }

                }
                
            }

        }

        private void Getdata()
        {
            dataAll = new DataSetPassBox.DataPassBoxDataTable();
            _data = new DataSetPassBoxTableAdapters.DataPassBoxTableAdapter();
            dataAll = _data.GetData(Settings.Default.MCNo);
            c_PassBoxList = new List<ClassPassBox>();

            List<string> pgk = new List<string>();

            foreach (DataSetPassBox.DataPassBoxRow row in dataAll)
            {

                if (!pgk.Contains(row.Package))
                {
                    pgk.Add(row.Package);
                    int count = 0;
                    foreach (DataSetPassBox.DataPassBoxRow row2 in dataAll)
                    {
                        if (row.Package == row2.Package)
                        {
                            count += 1;
                            ClassPassBox c_PassBox = new ClassPassBox();
                            c_PassBox.LotNo = row2.LotNo;
                            //c_PassBox.BgColor = Color.LightBlue;
                            c_PassBox.channel = row2.ChannelNumber;
                            if (!row2.IsIN_DAYNull())
                            {
                               //string year =  row2.LotNo.Substring(0, 2);
                                c_PassBox.In_Date = row2.IN_DAY;
                            }
                            else{c_PassBox.In_Date = "-";}
                            if (!row2.IsOUT_DAYNull()) { c_PassBox.Out_Date = row2.OUT_DAY; }
                            else { c_PassBox.Out_Date = "-"; }

                            c_PassBox.Package = row2.Package;
                            c_PassBox.EndTimeBeforeProcess = row2.EndTimeBeforeProcess;
                            c_PassBox.Queue = count;
                            c_PassBoxList.Add(c_PassBox);
                        }
                    }
                }
               
                //if (!passbox.ContainsKey(row.Package))
                //{
                  
                //    passbox.Add(row.Package, null);
                //}
            }
            
                //wBMP = new DataSetPassBox.WBMPPassboxDataTable();
                //adapter = new DataSetPassBoxTableAdapters.WBMPPassboxTableAdapter();
                //wBMP = adapter.GetDataPassBox();
                //c_PassBoxList = new List<ClassPassBox>();

                //foreach(DataSetPassBox.WBMPPassboxRow row in wBMP)
                //{

                //        ClassPassBox c_PassBox = new ClassPassBox();

                //        c_PassBox.LotNo = row.LotNo;
                //        //c_PassBox.EndTimeBeforeProcess = row.LotStartTime;
                //        c_PassBox.BgColor = Color.LightBlue;

                //        c_PassBox.channel = row.ChannelNumber;
                
                //    DataSetPassBox.LOT2_TABLEDataTable lOT2Table = new DataSetPassBox.LOT2_TABLEDataTable();
                //    DataSetPassBoxTableAdapters.LOT2_TABLETableAdapter lOT2 = new DataSetPassBoxTableAdapters.LOT2_TABLETableAdapter();
                //    lOT2Table = lOT2.GetShipmentDate(row.LotNo);

                //    foreach (DataSetPassBox.LOT2_TABLERow row1 in lOT2Table)
                //    {
                //        c_PassBox.In_Date = row1.IN_DAY;
                //        c_PassBox.Out_Date = row1.OUT_DAY;
                //    }

                //    DataSetPassBox.BeforeProcessEndTimeDataTable beforeProcess = new DataSetPassBox.BeforeProcessEndTimeDataTable();
                //    DataSetPassBoxTableAdapters.BeforeProcessEndTimeTableAdapter package = new DataSetPassBoxTableAdapters.BeforeProcessEndTimeTableAdapter();
                //    beforeProcess = package.GetBeforeProcessEndTime(row.LotNo);

                //    foreach (DataSetPassBox.BeforeProcessEndTimeRow row2 in beforeProcess)
                //    {
                //        c_PassBox.Package = row2.Package;
                //        c_PassBox.EndTimeBeforeProcess = row2.EndTime;
                //    }

                //    c_PassBoxList.Add(c_PassBox);
                //}
                
        }
        
        //private void BackupData()
        //{
            
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (lblMC.ForeColor == Color.Black)
            {
                lblMC.ForeColor = Color.Coral;
            }

            else
            {
                lblMC.ForeColor = Color.Black;
            }
            //Getdata();
            //UpdateDisplay();
        }

        private void ControlQueue()
        {
            //Dictionary<string, List<string>>
        }

        private void cbxMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cbxMC.SelectedIndex==0)
            //{
            //    lblMC.Text = "MC No. -";
            //    lblMC.ForeColor = Color.Black;
            //    timer1.Stop();
                
            //}

            //else
            //{
            //    Settings.Default.MCName = cbxMC.SelectedItem.ToString();
            //    Settings.Default.Save();
                
            //    lblMC.Text = cbxMC.SelectedItem.ToString();
            //    timer1.Start();

            //    Getdata();
            //    UpdateDisplay();

            //    //MessageBox.Show(Settings.Default.MCName);
            //}
            
        }

        Frm_Login f1 = new Frm_Login();
        UC_PassBox f2 = new UC_PassBox();

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            
            if (btn_Login.Text == "Logout")
            {
                MessageBox.Show("ออกจากระบบเรียบร้อยแล้ว");
                lbl_Op.Text = "OP ID : ";
                f1.Hide();
                btn_Login.Text = "Login";
                checkLogin = false;
                btnView.Enabled = false;
                f2.addlogfile("OP ID : " + f1.OpNo + " Logout");
                showPassBox();
            }

            else if ((f1.ShowDialog() == DialogResult.OK) && (btn_Login.Text == "Login"))
            {
                lbl_Op.Text = "OP ID : " + f1.OpNo;
                btn_Login.Text = "Logout";
                //cbxMC.Enabled = true;
                checkLogin = true;
                showPassBox();
                ParameterPB.OP = lbl_Op.Text.Substring(8, 6);
                //op = lbl_Op.Text.Substring(8, 6);
                f2.addlogfile("OP ID : " + f1.OpNo + " Login");
                btnView.Enabled = true;
                
            }
        }

        private void showPassBox()
        {
            if(checkLogin == true)
            {
                uc_Channel1.Enabled = true;
                uc_Channel2.Enabled = true;
                uc_Channel3.Enabled = true;
                uc_Channel4.Enabled = true;
                uc_Channel5.Enabled = true;
                uc_Channel6.Enabled = true;
                uc_Channel7.Enabled = true;
                uc_Channel8.Enabled = true;
                uc_Channel9.Enabled = true;
                lblMC.Text = Settings.Default.MCNo;
                Settings.Default.Save();
                timer1.Start();
            }

            else
            {
                uc_Channel1.Enabled = false;
                uc_Channel2.Enabled = false;
                uc_Channel3.Enabled = false;
                uc_Channel4.Enabled = false;
                uc_Channel5.Enabled = false;
                uc_Channel6.Enabled = false;
                uc_Channel7.Enabled = false;
                uc_Channel8.Enabled = false;
                uc_Channel9.Enabled = false;
                lblMC.ForeColor = Color.Black;
                timer1.Stop();
            }
               
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lbl_Op.Text == "OP ID : ")
            {
                DialogResult dialogResult = MessageBox.Show("ต้องการปิดโปรแกรมหรือไม่", "Close ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("กรุณา Logout ก่อน");
            }
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataHistoryMachine dataHistory = new DataHistoryMachine();
            dataHistory.ShowDialog();
            f2.addlogfile("OP ID : " + f1.OpNo + " ViewHistory");
        }

        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            c_Resize.ResizeAllControls(this);
        }

        //public void addlogfile(string m)
        //{
        //    string logfile = System.Environment.CurrentDirectory + @"\Log\ErrorLog.log";
        //    using (StreamWriter outfile = new StreamWriter(logfile, true))
        //    {
        //        outfile.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " : " + m);
        //    }
        //}

        //private void CommunicatedLog(string strData)
        //{
        //    string PathComLog = Path.Combine(System.Environment.CurrentDirectory + @"\Log\DataLog1.log");
        //    string PathComLogMove = Path.Combine(System.Environment.CurrentDirectory + @"\Log\DataLog2.log");
        //    string tmpTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        //    using (StreamWriter sw = new StreamWriter(PathComLog, true))
        //    {
        //        sw.WriteLine(tmpTime + " " + strData);
        //    }

        //    int CountData;
        //    using (StreamReader sr = new StreamReader(PathComLog))
        //    {
        //        CountData = System.Convert.ToInt32(sr.ReadToEnd().Length);
        //    }

        //    if(CountData > 5000000)
        //    {
        //        File.Copy(PathComLog, PathComLogMove, true);
        //        File.Delete(PathComLog);
        //    }
        //}

    }
}
