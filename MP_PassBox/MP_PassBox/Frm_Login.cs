using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_PassBox
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        public String OpNo { get; set; }
        
        private void txtOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    if (IsNumeric(txtOp.Text) == false)
            //    {
            //        MessageBox.Show("");

            //        txtOp.Text = "";
            //    }

            //    else
            //    {
            //        OpNo = txtOp.Text;
            //        this.DialogResult = DialogResult.OK;
            //    }

            //}
        }

        //public bool IsNumeric(string value)
        //{
        //    //return value.All(char.IsNumber);
        //}

        private void button9_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn7.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn6.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOp.Text = txtOp.Text + btn9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if  (txtOp.Text.Length != 6)
            {
                MessageBox.Show("ใส่รหัสพนักงานไม่ถูกต้อง");

                txtOp.Text = "";
            }
            
            else
            {
                OpNo = txtOp.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOp.Text = "";
        }
    }
}

