<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaster))
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbMachine = New System.Windows.Forms.Label
        Me.lbOPID = New System.Windows.Forms.Label
        Me.tbQR = New System.Windows.Forms.TextBox
        Me.pbxLogo = New System.Windows.Forms.PictureBox
        Me.btScanBox = New System.Windows.Forms.Button
        Me.btWORKINGSLIP = New System.Windows.Forms.Button
        Me.btScanOPID = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.UserControl19 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl18 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl17 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl16 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl15 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl14 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl13 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl12 = New SmartDevicePassBoxCelcon.UserControl1
        Me.UserControl11 = New SmartDevicePassBoxCelcon.UserControl1
        Me.TimerOPID = New System.Windows.Forms.Timer
        Me.TimerBoxName = New System.Windows.Forms.Timer
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbLoseTime = New System.Windows.Forms.Label
        Me.TimerTimeOut = New System.Windows.Forms.Timer
        Me.Button2 = New System.Windows.Forms.Button
        Me.lbIP = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 77)
        Me.Button1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(101, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 27)
        Me.Label1.Text = "Pass Box Cellcon"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbMachine
        '
        Me.lbMachine.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbMachine.ForeColor = System.Drawing.Color.White
        Me.lbMachine.Location = New System.Drawing.Point(114, 561)
        Me.lbMachine.Name = "lbMachine"
        Me.lbMachine.Size = New System.Drawing.Size(106, 29)
        Me.lbMachine.Text = "-"
        '
        'lbOPID
        '
        Me.lbOPID.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbOPID.ForeColor = System.Drawing.Color.White
        Me.lbOPID.Location = New System.Drawing.Point(111, 520)
        Me.lbOPID.Name = "lbOPID"
        Me.lbOPID.Size = New System.Drawing.Size(106, 35)
        Me.lbOPID.Text = "-"
        '
        'tbQR
        '
        Me.tbQR.Font = New System.Drawing.Font("Tahoma", 1.0!, System.Drawing.FontStyle.Regular)
        Me.tbQR.Location = New System.Drawing.Point(361, 565)
        Me.tbQR.Name = "tbQR"
        Me.tbQR.Size = New System.Drawing.Size(1, 8)
        Me.tbQR.TabIndex = 26
        '
        'pbxLogo
        '
        Me.pbxLogo.BackColor = System.Drawing.Color.Black
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(363, 503)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(105, 73)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'btScanBox
        '
        Me.btScanBox.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.btScanBox.Location = New System.Drawing.Point(154, 0)
        Me.btScanBox.Name = "btScanBox"
        Me.btScanBox.Size = New System.Drawing.Size(155, 60)
        Me.btScanBox.TabIndex = 5
        Me.btScanBox.Text = "Scan Box"
        '
        'btWORKINGSLIP
        '
        Me.btWORKINGSLIP.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.btWORKINGSLIP.Location = New System.Drawing.Point(309, 0)
        Me.btWORKINGSLIP.Name = "btWORKINGSLIP"
        Me.btWORKINGSLIP.Size = New System.Drawing.Size(155, 60)
        Me.btWORKINGSLIP.TabIndex = 6
        Me.btWORKINGSLIP.Text = "WORKING SLIP"
        '
        'btScanOPID
        '
        Me.btScanOPID.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.btScanOPID.Location = New System.Drawing.Point(-1, 0)
        Me.btScanOPID.Name = "btScanOPID"
        Me.btScanOPID.Size = New System.Drawing.Size(155, 60)
        Me.btScanOPID.TabIndex = 7
        Me.btScanOPID.Text = "Scan OPID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.UserControl19)
        Me.Panel2.Controls.Add(Me.UserControl18)
        Me.Panel2.Controls.Add(Me.UserControl17)
        Me.Panel2.Controls.Add(Me.UserControl16)
        Me.Panel2.Controls.Add(Me.UserControl15)
        Me.Panel2.Controls.Add(Me.UserControl14)
        Me.Panel2.Controls.Add(Me.UserControl13)
        Me.Panel2.Controls.Add(Me.UserControl12)
        Me.Panel2.Controls.Add(Me.UserControl11)
        Me.Panel2.Controls.Add(Me.btScanOPID)
        Me.Panel2.Controls.Add(Me.btWORKINGSLIP)
        Me.Panel2.Controls.Add(Me.btScanBox)
        Me.Panel2.Location = New System.Drawing.Point(7, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(463, 445)
        '
        'UserControl19
        '
        Me.UserControl19.Location = New System.Drawing.Point(311, 316)
        Me.UserControl19.Name = "UserControl19"
        Me.UserControl19.Size = New System.Drawing.Size(151, 125)
        Me.UserControl19.TabIndex = 17
        '
        'UserControl18
        '
        Me.UserControl18.Location = New System.Drawing.Point(156, 316)
        Me.UserControl18.Name = "UserControl18"
        Me.UserControl18.Size = New System.Drawing.Size(151, 125)
        Me.UserControl18.TabIndex = 17
        '
        'UserControl17
        '
        Me.UserControl17.Location = New System.Drawing.Point(1, 316)
        Me.UserControl17.Name = "UserControl17"
        Me.UserControl17.Size = New System.Drawing.Size(151, 125)
        Me.UserControl17.TabIndex = 17
        '
        'UserControl16
        '
        Me.UserControl16.Location = New System.Drawing.Point(311, 189)
        Me.UserControl16.Name = "UserControl16"
        Me.UserControl16.Size = New System.Drawing.Size(151, 125)
        Me.UserControl16.TabIndex = 17
        '
        'UserControl15
        '
        Me.UserControl15.Location = New System.Drawing.Point(156, 189)
        Me.UserControl15.Name = "UserControl15"
        Me.UserControl15.Size = New System.Drawing.Size(151, 125)
        Me.UserControl15.TabIndex = 17
        '
        'UserControl14
        '
        Me.UserControl14.Location = New System.Drawing.Point(1, 189)
        Me.UserControl14.Name = "UserControl14"
        Me.UserControl14.Size = New System.Drawing.Size(151, 125)
        Me.UserControl14.TabIndex = 17
        '
        'UserControl13
        '
        Me.UserControl13.Location = New System.Drawing.Point(311, 62)
        Me.UserControl13.Name = "UserControl13"
        Me.UserControl13.Size = New System.Drawing.Size(151, 125)
        Me.UserControl13.TabIndex = 17
        '
        'UserControl12
        '
        Me.UserControl12.Location = New System.Drawing.Point(156, 62)
        Me.UserControl12.Name = "UserControl12"
        Me.UserControl12.Size = New System.Drawing.Size(151, 125)
        Me.UserControl12.TabIndex = 17
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(1, 62)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(151, 125)
        Me.UserControl11.TabIndex = 17
        '
        'TimerOPID
        '
        Me.TimerOPID.Enabled = True
        Me.TimerOPID.Interval = 1000
        '
        'TimerBoxName
        '
        Me.TimerBoxName.Interval = 500
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 29)
        Me.Label3.Text = "Box ID :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 518)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 38)
        Me.Label2.Text = "OP ID :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(221, 521)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 35)
        Me.Label4.Text = "Time Out"
        '
        'lbLoseTime
        '
        Me.lbLoseTime.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.lbLoseTime.ForeColor = System.Drawing.Color.White
        Me.lbLoseTime.Location = New System.Drawing.Point(234, 561)
        Me.lbLoseTime.Name = "lbLoseTime"
        Me.lbLoseTime.Size = New System.Drawing.Size(95, 35)
        Me.lbLoseTime.Text = "00:00"
        Me.lbLoseTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerTimeOut
        '
        Me.TimerTimeOut.Interval = 1000
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(478, 58)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Pass Box Cellcon"
        '
        'lbIP
        '
        Me.lbIP.BackColor = System.Drawing.Color.Black
        Me.lbIP.ForeColor = System.Drawing.Color.White
        Me.lbIP.Location = New System.Drawing.Point(359, 577)
        Me.lbIP.Name = "lbIP"
        Me.lbIP.Size = New System.Drawing.Size(114, 20)
        Me.lbIP.Text = "IP :"
        '
        'FormMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.lbIP)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbMachine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbLoseTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbOPID)
        Me.Controls.Add(Me.tbQR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMaster"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMachine As System.Windows.Forms.Label
    Friend WithEvents lbOPID As System.Windows.Forms.Label
    Friend WithEvents tbQR As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btScanBox As System.Windows.Forms.Button
    Friend WithEvents btWORKINGSLIP As System.Windows.Forms.Button
    Friend WithEvents btScanOPID As System.Windows.Forms.Button
    Friend WithEvents UserControl11 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UserControl19 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl18 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl17 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl16 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl15 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl14 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl13 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents UserControl12 As SmartDevicePassBoxCelcon.UserControl1
    Friend WithEvents TimerOPID As System.Windows.Forms.Timer
    Friend WithEvents TimerBoxName As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbLoseTime As System.Windows.Forms.Label
    Friend WithEvents TimerTimeOut As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbIP As System.Windows.Forms.Label

End Class
