namespace MP_PassBox
{
    partial class UC_PassBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.btn_queue = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Shipment = new System.Windows.Forms.Label();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Package = new System.Windows.Forms.Label();
            this.lbl_LotNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bgPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.btn_queue);
            this.bgPanel.Controls.Add(this.lbl_time);
            this.bgPanel.Controls.Add(this.panel1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(625, 325);
            this.bgPanel.TabIndex = 0;
            this.bgPanel.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // btn_queue
            // 
            this.btn_queue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_queue.Location = new System.Drawing.Point(12, 17);
            this.btn_queue.Name = "btn_queue";
            this.btn_queue.Size = new System.Drawing.Size(51, 30);
            this.btn_queue.TabIndex = 10;
            this.btn_queue.UseVisualStyleBackColor = true;
            this.btn_queue.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(372, 17);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(240, 30);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_time.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Shipment);
            this.panel1.Controls.Add(this.lbl_Input);
            this.panel1.Controls.Add(this.lbl_Package);
            this.panel1.Controls.Add(this.lbl_LotNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 265);
            this.panel1.TabIndex = 8;
            this.panel1.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // lbl_Shipment
            // 
            this.lbl_Shipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shipment.Location = new System.Drawing.Point(199, 96);
            this.lbl_Shipment.Name = "lbl_Shipment";
            this.lbl_Shipment.Size = new System.Drawing.Size(176, 23);
            this.lbl_Shipment.TabIndex = 5;
            this.lbl_Shipment.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // lbl_Input
            // 
            this.lbl_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input.Location = new System.Drawing.Point(4, 96);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(175, 23);
            this.lbl_Input.TabIndex = 4;
            this.lbl_Input.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // lbl_Package
            // 
            this.lbl_Package.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Package.Location = new System.Drawing.Point(121, 52);
            this.lbl_Package.Name = "lbl_Package";
            this.lbl_Package.Size = new System.Drawing.Size(213, 24);
            this.lbl_Package.TabIndex = 3;
            this.lbl_Package.Text = "-";
            this.lbl_Package.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // lbl_LotNo
            // 
            this.lbl_LotNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LotNo.Location = new System.Drawing.Point(121, 12);
            this.lbl_LotNo.Name = "lbl_LotNo";
            this.lbl_LotNo.Size = new System.Drawing.Size(213, 24);
            this.lbl_LotNo.TabIndex = 2;
            this.lbl_LotNo.Text = "-";
            this.lbl_LotNo.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PKG.";
            this.label2.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOT NO.";
            this.label1.Click += new System.EventHandler(this.btn_queue_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_PassBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bgPanel);
            this.Name = "UC_PassBox";
            this.Size = new System.Drawing.Size(625, 325);
            this.bgPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Button btn_queue;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Shipment;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Package;
        private System.Windows.Forms.Label lbl_LotNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
