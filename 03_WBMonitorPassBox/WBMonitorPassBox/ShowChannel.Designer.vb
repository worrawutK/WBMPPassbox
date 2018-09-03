<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowChannel
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataSet11 = New WBMonitorPassBox.DataSet1()
        Me.WbmpPassboxTableAdapter1 = New WBMonitorPassBox.DataSet1TableAdapters.WBMPPassboxTableAdapter()
        Me.LoT2_TABLETableAdapter1 = New WBMonitorPassBox.DataSet1TableAdapters.LOT2_TABLETableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbMachine = New System.Windows.Forms.Button()
        Me.UserControlShow7 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow5 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow3 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow6 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow9 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow8 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow4 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow2 = New WBMonitorPassBox.UserControlShow()
        Me.UserControlShow1 = New WBMonitorPassBox.UserControlShow()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WbmpPassboxTableAdapter1
        '
        Me.WbmpPassboxTableAdapter1.ClearBeforeFill = True
        '
        'LoT2_TABLETableAdapter1
        '
        Me.LoT2_TABLETableAdapter1.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(1291, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "กลับหน้าหลัก"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbMachine
        '
        Me.lbMachine.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbMachine.Location = New System.Drawing.Point(29, 12)
        Me.lbMachine.Name = "lbMachine"
        Me.lbMachine.Size = New System.Drawing.Size(291, 58)
        Me.lbMachine.TabIndex = 3
        Me.lbMachine.UseVisualStyleBackColor = False
        '
        'UserControlShow7
        '
        Me.UserControlShow7.Location = New System.Drawing.Point(1054, 620)
        Me.UserControlShow7.Name = "UserControlShow7"
        Me.UserControlShow7.Size = New System.Drawing.Size(514, 269)
        Me.UserControlShow7.TabIndex = 0
        '
        'UserControlShow5
        '
        Me.UserControlShow5.Location = New System.Drawing.Point(542, 348)
        Me.UserControlShow5.Name = "UserControlShow5"
        Me.UserControlShow5.Size = New System.Drawing.Size(509, 270)
        Me.UserControlShow5.TabIndex = 0
        '
        'UserControlShow3
        '
        Me.UserControlShow3.Location = New System.Drawing.Point(29, 75)
        Me.UserControlShow3.Name = "UserControlShow3"
        Me.UserControlShow3.Size = New System.Drawing.Size(514, 271)
        Me.UserControlShow3.TabIndex = 0
        '
        'UserControlShow6
        '
        Me.UserControlShow6.Location = New System.Drawing.Point(29, 348)
        Me.UserControlShow6.Name = "UserControlShow6"
        Me.UserControlShow6.Size = New System.Drawing.Size(514, 270)
        Me.UserControlShow6.TabIndex = 0
        '
        'UserControlShow9
        '
        Me.UserControlShow9.Location = New System.Drawing.Point(29, 620)
        Me.UserControlShow9.Name = "UserControlShow9"
        Me.UserControlShow9.Size = New System.Drawing.Size(514, 270)
        Me.UserControlShow9.TabIndex = 0
        '
        'UserControlShow8
        '
        Me.UserControlShow8.Location = New System.Drawing.Point(542, 620)
        Me.UserControlShow8.Name = "UserControlShow8"
        Me.UserControlShow8.Size = New System.Drawing.Size(507, 270)
        Me.UserControlShow8.TabIndex = 0
        '
        'UserControlShow4
        '
        Me.UserControlShow4.Location = New System.Drawing.Point(1054, 348)
        Me.UserControlShow4.Name = "UserControlShow4"
        Me.UserControlShow4.Size = New System.Drawing.Size(514, 278)
        Me.UserControlShow4.TabIndex = 0
        '
        'UserControlShow2
        '
        Me.UserControlShow2.Location = New System.Drawing.Point(541, 76)
        Me.UserControlShow2.Name = "UserControlShow2"
        Me.UserControlShow2.Size = New System.Drawing.Size(507, 272)
        Me.UserControlShow2.TabIndex = 0
        '
        'UserControlShow1
        '
        Me.UserControlShow1.Location = New System.Drawing.Point(1054, 76)
        Me.UserControlShow1.Name = "UserControlShow1"
        Me.UserControlShow1.Size = New System.Drawing.Size(514, 270)
        Me.UserControlShow1.TabIndex = 0
        '
        'ShowChannel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.lbMachine)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserControlShow7)
        Me.Controls.Add(Me.UserControlShow5)
        Me.Controls.Add(Me.UserControlShow3)
        Me.Controls.Add(Me.UserControlShow6)
        Me.Controls.Add(Me.UserControlShow9)
        Me.Controls.Add(Me.UserControlShow8)
        Me.Controls.Add(Me.UserControlShow4)
        Me.Controls.Add(Me.UserControlShow2)
        Me.Controls.Add(Me.UserControlShow1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShowChannel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShowChannel"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserControlShow1 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow2 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow3 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow4 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow5 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow6 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow7 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow8 As WBMonitorPassBox.UserControlShow
    Friend WithEvents UserControlShow9 As WBMonitorPassBox.UserControlShow
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataSet11 As WBMonitorPassBox.DataSet1
    Friend WithEvents WbmpPassboxTableAdapter1 As WBMonitorPassBox.DataSet1TableAdapters.WBMPPassboxTableAdapter
    Friend WithEvents LoT2_TABLETableAdapter1 As WBMonitorPassBox.DataSet1TableAdapters.LOT2_TABLETableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbMachine As System.Windows.Forms.Button
End Class
