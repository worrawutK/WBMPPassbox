namespace MP_PassBox
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnView = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.uc_Channel1 = new MP_PassBox.UC_PassBox();
            this.uc_Channel2 = new MP_PassBox.UC_PassBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lblMC = new System.Windows.Forms.Label();
            this.lbl_Op = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uc_Channel3 = new MP_PassBox.UC_PassBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.uc_Channel6 = new MP_PassBox.UC_PassBox();
            this.uc_Channel4 = new MP_PassBox.UC_PassBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uc_Channel5 = new MP_PassBox.UC_PassBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::MP_PassBox.Properties.Resources.search_document_512;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Location = new System.Drawing.Point(1712, 10);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(55, 55);
            this.btnView.TabIndex = 28;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::MP_PassBox.Properties.Resources.iii;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Location = new System.Drawing.Point(1773, 10);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 55);
            this.btnMin.TabIndex = 26;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // uc_Channel1
            // 
            this.uc_Channel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_Channel1.Location = new System.Drawing.Point(4, 338);
            this.uc_Channel1.Name = "uc_Channel1";
            this.uc_Channel1.Size = new System.Drawing.Size(925, 325);
            this.uc_Channel1.TabIndex = 9;
            // 
            // uc_Channel2
            // 
            this.uc_Channel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_Channel2.Location = new System.Drawing.Point(952, 9);
            this.uc_Channel2.Name = "uc_Channel2";
            this.uc_Channel2.Size = new System.Drawing.Size(925, 325);
            this.uc_Channel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1075, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 53);
            this.label2.TabIndex = 24;
            this.label2.Text = "M/C No : ";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(915, 15);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 54);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lblMC
            // 
            this.lblMC.Font = new System.Drawing.Font("Bodoni MT", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC.ForeColor = System.Drawing.Color.Black;
            this.lblMC.Location = new System.Drawing.Point(1288, 17);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(467, 56);
            this.lblMC.TabIndex = 23;
            // 
            // lbl_Op
            // 
            this.lbl_Op.AllowDrop = true;
            this.lbl_Op.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Op.Location = new System.Drawing.Point(619, 29);
            this.lbl_Op.Name = "lbl_Op";
            this.lbl_Op.Size = new System.Drawing.Size(302, 31);
            this.lbl_Op.TabIndex = 20;
            this.lbl_Op.Text = "OP ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "\" PASSBOX CELLCON \"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 120);
            this.label3.TabIndex = 27;
            this.label3.Text = "_____________________________\r\n\r\n\r\n";
            // 
            // uc_Channel3
            // 
            this.uc_Channel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_Channel3.Location = new System.Drawing.Point(4, 9);
            this.uc_Channel3.Name = "uc_Channel3";
            this.uc_Channel3.Size = new System.Drawing.Size(925, 325);
            this.uc_Channel3.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::MP_PassBox.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(1834, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 25;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uc_Channel6
            // 
            this.uc_Channel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_Channel6.Location = new System.Drawing.Point(952, 338);
            this.uc_Channel6.Name = "uc_Channel6";
            this.uc_Channel6.Size = new System.Drawing.Size(925, 325);
            this.uc_Channel6.TabIndex = 3;
            // 
            // uc_Channel4
            // 
            this.uc_Channel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_Channel4.Location = new System.Drawing.Point(952, 669);
            this.uc_Channel4.Name = "uc_Channel4";
            this.uc_Channel4.Size = new System.Drawing.Size(925, 325);
            this.uc_Channel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uc_Channel1);
            this.panel1.Controls.Add(this.uc_Channel2);
            this.panel1.Controls.Add(this.uc_Channel3);
            this.panel1.Controls.Add(this.uc_Channel6);
            this.panel1.Controls.Add(this.uc_Channel4);
            this.panel1.Controls.Add(this.uc_Channel5);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 999);
            this.panel1.TabIndex = 22;
            // 
            // uc_Channel5
            // 
            this.uc_Channel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc_Channel5.Location = new System.Drawing.Point(4, 669);
            this.uc_Channel5.Name = "uc_Channel5";
            this.uc_Channel5.Size = new System.Drawing.Size(925, 325);
            this.uc_Channel5.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 750;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.lbl_Op);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnMin;
        private UC_PassBox uc_Channel1;
        private UC_PassBox uc_Channel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label lbl_Op;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private UC_PassBox uc_Channel3;
        private System.Windows.Forms.Button btnClose;
        private UC_PassBox uc_Channel6;
        private UC_PassBox uc_Channel4;
        private System.Windows.Forms.Panel panel1;
        private UC_PassBox uc_Channel5;
        private System.Windows.Forms.Timer timer1;
    }
}