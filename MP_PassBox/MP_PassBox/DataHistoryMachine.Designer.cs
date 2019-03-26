namespace MP_PassBox
{
    partial class DataHistoryMachine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSetPassBox = new MP_PassBox.DataSetPassBox();
            this.dataSetPassBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotstartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPNoIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPNoOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChannelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPassBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LotNo,
            this.MCNo,
            this.LotstartTime,
            this.OPNoIn,
            this.LotEndTime,
            this.OPNoOut,
            this.ChannelNumber});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSetPassBox
            // 
            this.dataSetPassBox.DataSetName = "DataSetPassBox";
            this.dataSetPassBox.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetPassBoxBindingSource
            // 
            this.dataSetPassBoxBindingSource.DataSource = this.dataSetPassBox;
            this.dataSetPassBoxBindingSource.Position = 0;
            // 
            // LotNo
            // 
            this.LotNo.DataPropertyName = "LotNo";
            this.LotNo.HeaderText = "LotNo.";
            this.LotNo.Name = "LotNo";
            // 
            // MCNo
            // 
            this.MCNo.DataPropertyName = "MCNo";
            this.MCNo.HeaderText = "MCNo";
            this.MCNo.Name = "MCNo";
            this.MCNo.Visible = false;
            // 
            // LotstartTime
            // 
            this.LotstartTime.DataPropertyName = "LotStartTime";
            this.LotstartTime.HeaderText = "Time_StartLot";
            this.LotstartTime.Name = "LotstartTime";
            // 
            // OPNoIn
            // 
            this.OPNoIn.DataPropertyName = "OPNoIn";
            this.OPNoIn.HeaderText = "OPNo_InLot";
            this.OPNoIn.Name = "OPNoIn";
            // 
            // LotEndTime
            // 
            this.LotEndTime.DataPropertyName = "LotEndTime";
            this.LotEndTime.HeaderText = "Time_EndLot";
            this.LotEndTime.Name = "LotEndTime";
            // 
            // OPNoOut
            // 
            this.OPNoOut.DataPropertyName = "OPNoOut";
            this.OPNoOut.HeaderText = "OPNo_OutLot";
            this.OPNoOut.Name = "OPNoOut";
            // 
            // ChannelNumber
            // 
            this.ChannelNumber.DataPropertyName = "ChannelNumber";
            this.ChannelNumber.HeaderText = "Channel";
            this.ChannelNumber.Name = "ChannelNumber";
            // 
            // DataHistoryMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 348);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataHistoryMachine";
            this.Text = "DataHistoryMachine";
            this.Load += new System.EventHandler(this.DataHistoryMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPassBoxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSetPassBoxBindingSource;
        private DataSetPassBox dataSetPassBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotstartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPNoIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPNoOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChannelNumber;
    }
}