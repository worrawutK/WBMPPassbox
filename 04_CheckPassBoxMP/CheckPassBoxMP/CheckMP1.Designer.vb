<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.lbNameSearch = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.rbDateTime = New System.Windows.Forms.RadioButton()
        Me.rbPackageName = New System.Windows.Forms.RadioButton()
        Me.rbLotNo = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Process_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbDataINBox = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB05ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB06ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PB07ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LotNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotStartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LotEndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNoInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNoOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChannelNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MCNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WBMPPassboxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New CheckPassBoxMP.DataSet1()
        Me.WbmpPassboxTableAdapter1 = New CheckPassBoxMP.DataSet1TableAdapters.WBMPPassboxTableAdapter()
        CType(Me.Process_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.WBMPPassboxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btSearch
        '
        Me.btSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSearch.Location = New System.Drawing.Point(325, 10)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(76, 26)
        Me.btSearch.TabIndex = 0
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'tbSearch
        '
        Me.tbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbSearch.Location = New System.Drawing.Point(150, 10)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(162, 26)
        Me.tbSearch.TabIndex = 1
        '
        'lbNameSearch
        '
        Me.lbNameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbNameSearch.ForeColor = System.Drawing.Color.White
        Me.lbNameSearch.Location = New System.Drawing.Point(15, 11)
        Me.lbNameSearch.Name = "lbNameSearch"
        Me.lbNameSearch.Size = New System.Drawing.Size(129, 20)
        Me.lbNameSearch.TabIndex = 2
        Me.lbNameSearch.Text = "Lot No :"
        Me.lbNameSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MonthCalendar1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 8
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MonthCalendar2.Location = New System.Drawing.Point(266, 0)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 8
        '
        'rbDateTime
        '
        Me.rbDateTime.AutoSize = True
        Me.rbDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbDateTime.ForeColor = System.Drawing.Color.White
        Me.rbDateTime.Location = New System.Drawing.Point(63, 132)
        Me.rbDateTime.Name = "rbDateTime"
        Me.rbDateTime.Size = New System.Drawing.Size(128, 29)
        Me.rbDateTime.TabIndex = 12
        Me.rbDateTime.Text = "Date Time"
        Me.rbDateTime.UseVisualStyleBackColor = True
        '
        'rbPackageName
        '
        Me.rbPackageName.AutoSize = True
        Me.rbPackageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbPackageName.ForeColor = System.Drawing.Color.White
        Me.rbPackageName.Location = New System.Drawing.Point(63, 97)
        Me.rbPackageName.Name = "rbPackageName"
        Me.rbPackageName.Size = New System.Drawing.Size(176, 29)
        Me.rbPackageName.TabIndex = 11
        Me.rbPackageName.Text = "Package Name"
        Me.rbPackageName.UseVisualStyleBackColor = True
        '
        'rbLotNo
        '
        Me.rbLotNo.AutoSize = True
        Me.rbLotNo.Checked = True
        Me.rbLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbLotNo.ForeColor = System.Drawing.Color.LawnGreen
        Me.rbLotNo.Location = New System.Drawing.Point(63, 65)
        Me.rbLotNo.Name = "rbLotNo"
        Me.rbLotNo.Size = New System.Drawing.Size(99, 29)
        Me.rbLotNo.TabIndex = 10
        Me.rbLotNo.TabStop = True
        Me.rbLotNo.Text = "Lot No."
        Me.rbLotNo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(233, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ถึง"
        '
        'Process_HistoryDataGridView
        '
        Me.Process_HistoryDataGridView.AllowUserToDeleteRows = False
        Me.Process_HistoryDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Process_HistoryDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Process_HistoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Process_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Process_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotNoDataGridViewTextBoxColumn, Me.PackageDataGridViewTextBoxColumn, Me.DeviceDataGridViewTextBoxColumn, Me.LotStartTimeDataGridViewTextBoxColumn, Me.LotEndTimeDataGridViewTextBoxColumn, Me.OPNoInDataGridViewTextBoxColumn, Me.OPNoOutDataGridViewTextBoxColumn, Me.ChannelNumberDataGridViewTextBoxColumn, Me.MCNoDataGridViewTextBoxColumn})
        Me.Process_HistoryDataGridView.DataSource = Me.WBMPPassboxBindingSource
        Me.Process_HistoryDataGridView.Location = New System.Drawing.Point(33, 240)
        Me.Process_HistoryDataGridView.Name = "Process_HistoryDataGridView"
        Me.Process_HistoryDataGridView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Process_HistoryDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Process_HistoryDataGridView.Size = New System.Drawing.Size(1009, 395)
        Me.Process_HistoryDataGridView.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.CheckPassBoxMP.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(923, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 92)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(365, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Check Pass Box Cellcon"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ประเภทการค้นหา"
        '
        'rbDataINBox
        '
        Me.rbDataINBox.AutoSize = True
        Me.rbDataINBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbDataINBox.ForeColor = System.Drawing.Color.White
        Me.rbDataINBox.Location = New System.Drawing.Point(63, 163)
        Me.rbDataINBox.Name = "rbDataINBox"
        Me.rbDataINBox.Size = New System.Drawing.Size(198, 29)
        Me.rbDataINBox.TabIndex = 12
        Me.rbDataINBox.Text = "Data IN Pass Box"
        Me.rbDataINBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btSearch)
        Me.Panel1.Controls.Add(Me.lbNameSearch)
        Me.Panel1.Controls.Add(Me.tbSearch)
        Me.Panel1.Location = New System.Drawing.Point(12, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 39)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(279, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 30)
        Me.Panel2.TabIndex = 17
        Me.Panel2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoxToolStripMenuItem, Me.PB02ToolStripMenuItem, Me.PB03ToolStripMenuItem, Me.PB04ToolStripMenuItem, Me.PB05ToolStripMenuItem, Me.PB06ToolStripMenuItem, Me.PB07ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(365, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BoxToolStripMenuItem
        '
        Me.BoxToolStripMenuItem.Name = "BoxToolStripMenuItem"
        Me.BoxToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.BoxToolStripMenuItem.Text = "PB-01"
        '
        'PB02ToolStripMenuItem
        '
        Me.PB02ToolStripMenuItem.Name = "PB02ToolStripMenuItem"
        Me.PB02ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PB02ToolStripMenuItem.Text = "PB-02"
        '
        'PB03ToolStripMenuItem
        '
        Me.PB03ToolStripMenuItem.Name = "PB03ToolStripMenuItem"
        Me.PB03ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PB03ToolStripMenuItem.Text = "PB-03"
        '
        'PB04ToolStripMenuItem
        '
        Me.PB04ToolStripMenuItem.Name = "PB04ToolStripMenuItem"
        Me.PB04ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PB04ToolStripMenuItem.Text = "PB-04"
        '
        'PB05ToolStripMenuItem
        '
        Me.PB05ToolStripMenuItem.Name = "PB05ToolStripMenuItem"
        Me.PB05ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PB05ToolStripMenuItem.Text = "PB-05"
        '
        'PB06ToolStripMenuItem
        '
        Me.PB06ToolStripMenuItem.Name = "PB06ToolStripMenuItem"
        Me.PB06ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PB06ToolStripMenuItem.Text = "PB-06"
        '
        'PB07ToolStripMenuItem
        '
        Me.PB07ToolStripMenuItem.Name = "PB07ToolStripMenuItem"
        Me.PB07ToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PB07ToolStripMenuItem.Text = "PB-07"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.MonthCalendar2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.MonthCalendar1)
        Me.Panel3.Location = New System.Drawing.Point(426, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(493, 181)
        Me.Panel3.TabIndex = 18
        Me.Panel3.Visible = False
        '
        'LotNoDataGridViewTextBoxColumn
        '
        Me.LotNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.HeaderText = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.Name = "LotNoDataGridViewTextBoxColumn"
        Me.LotNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PackageDataGridViewTextBoxColumn
        '
        Me.PackageDataGridViewTextBoxColumn.DataPropertyName = "Package"
        Me.PackageDataGridViewTextBoxColumn.HeaderText = "Package"
        Me.PackageDataGridViewTextBoxColumn.Name = "PackageDataGridViewTextBoxColumn"
        Me.PackageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeviceDataGridViewTextBoxColumn
        '
        Me.DeviceDataGridViewTextBoxColumn.DataPropertyName = "Device"
        Me.DeviceDataGridViewTextBoxColumn.HeaderText = "Device"
        Me.DeviceDataGridViewTextBoxColumn.Name = "DeviceDataGridViewTextBoxColumn"
        Me.DeviceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotStartTimeDataGridViewTextBoxColumn
        '
        Me.LotStartTimeDataGridViewTextBoxColumn.DataPropertyName = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.HeaderText = "LotStartTime"
        Me.LotStartTimeDataGridViewTextBoxColumn.Name = "LotStartTimeDataGridViewTextBoxColumn"
        Me.LotStartTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LotEndTimeDataGridViewTextBoxColumn
        '
        Me.LotEndTimeDataGridViewTextBoxColumn.DataPropertyName = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.HeaderText = "LotEndTime"
        Me.LotEndTimeDataGridViewTextBoxColumn.Name = "LotEndTimeDataGridViewTextBoxColumn"
        Me.LotEndTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OPNoInDataGridViewTextBoxColumn
        '
        Me.OPNoInDataGridViewTextBoxColumn.DataPropertyName = "OPNoIn"
        Me.OPNoInDataGridViewTextBoxColumn.HeaderText = "OPNoIn"
        Me.OPNoInDataGridViewTextBoxColumn.Name = "OPNoInDataGridViewTextBoxColumn"
        Me.OPNoInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OPNoOutDataGridViewTextBoxColumn
        '
        Me.OPNoOutDataGridViewTextBoxColumn.DataPropertyName = "OPNoOut"
        Me.OPNoOutDataGridViewTextBoxColumn.HeaderText = "OPNoOut"
        Me.OPNoOutDataGridViewTextBoxColumn.Name = "OPNoOutDataGridViewTextBoxColumn"
        Me.OPNoOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChannelNumberDataGridViewTextBoxColumn
        '
        Me.ChannelNumberDataGridViewTextBoxColumn.DataPropertyName = "ChannelNumber"
        Me.ChannelNumberDataGridViewTextBoxColumn.HeaderText = "ChannelNumber"
        Me.ChannelNumberDataGridViewTextBoxColumn.Name = "ChannelNumberDataGridViewTextBoxColumn"
        Me.ChannelNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MCNoDataGridViewTextBoxColumn
        '
        Me.MCNoDataGridViewTextBoxColumn.DataPropertyName = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.HeaderText = "MCNo"
        Me.MCNoDataGridViewTextBoxColumn.Name = "MCNoDataGridViewTextBoxColumn"
        Me.MCNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WBMPPassboxBindingSource
        '
        Me.WBMPPassboxBindingSource.DataMember = "WBMPPassbox"
        Me.WBMPPassboxBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WbmpPassboxTableAdapter1
        '
        Me.WbmpPassboxTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1054, 656)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbDataINBox)
        Me.Controls.Add(Me.rbDateTime)
        Me.Controls.Add(Me.rbPackageName)
        Me.Controls.Add(Me.rbLotNo)
        Me.Controls.Add(Me.Process_HistoryDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pass Box Cellcon"
        CType(Me.Process_HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.WBMPPassboxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSearch As System.Windows.Forms.Button
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents lbNameSearch As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents rbDateTime As System.Windows.Forms.RadioButton
    Friend WithEvents rbPackageName As System.Windows.Forms.RadioButton
    Friend WithEvents rbLotNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Process_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbDataINBox As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB03ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB04ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB05ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB06ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PB07ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents WBMPPassboxBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WbmpPassboxTableAdapter1 As DataSet1TableAdapters.WBMPPassboxTableAdapter
    Friend WithEvents LotNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PackageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeviceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotStartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LotEndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNoInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNoOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChannelNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MCNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
