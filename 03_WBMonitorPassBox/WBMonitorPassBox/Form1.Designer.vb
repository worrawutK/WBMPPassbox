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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bttotal = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LEDRED = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LEDLime = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LEDGold = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.box1 = New System.Windows.Forms.Label()
        Me.box2 = New System.Windows.Forms.Label()
        Me.box3 = New System.Windows.Forms.Label()
        Me.box4 = New System.Windows.Forms.Label()
        Me.box5 = New System.Windows.Forms.Label()
        Me.box6 = New System.Windows.Forms.Label()
        Me.box7 = New System.Windows.Forms.Label()
        Me.UserControlWIP2 = New WBMonitorPassBox.UserControlWIP()
        Me.UserControlWIP1 = New WBMonitorPassBox.UserControlWIP()
        Me.UserControlPassBox7 = New WBMonitorPassBox.UserControlPassBox()
        Me.UserControlPassBox6 = New WBMonitorPassBox.UserControlPassBox()
        Me.UserControlPassBox5 = New WBMonitorPassBox.UserControlPassBox()
        Me.UserControlPassBox4 = New WBMonitorPassBox.UserControlPassBox()
        Me.UserControlPassBox3 = New WBMonitorPassBox.UserControlPassBox()
        Me.UserControlPassBox2 = New WBMonitorPassBox.UserControlPassBox()
        Me.UserControlPassBox1 = New WBMonitorPassBox.UserControlPassBox()
        Me.DataSet11 = New WBMonitorPassBox.DataSet1()
        Me.WbmpPassboxTableAdapter1 = New WBMonitorPassBox.DataSet1TableAdapters.WBMPPassboxTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(787, 73)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Pass Box Cellcon"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bttotal
        '
        Me.bttotal.BackColor = System.Drawing.Color.Transparent
        Me.bttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bttotal.ForeColor = System.Drawing.Color.Yellow
        Me.bttotal.Location = New System.Drawing.Point(1324, 12)
        Me.bttotal.Name = "bttotal"
        Me.bttotal.Size = New System.Drawing.Size(249, 134)
        Me.bttotal.TabIndex = 5
        Me.bttotal.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LEDRED, Me.LEDLime, Me.LEDGold})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1600, 900)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderColor = System.Drawing.Color.DarkGray
        Me.RectangleShape1.BorderWidth = 8
        Me.RectangleShape1.Location = New System.Drawing.Point(1316, 153)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(260, 715)
        '
        'LEDRED
        '
        Me.LEDRED.BackColor = System.Drawing.Color.White
        Me.LEDRED.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LEDRED.BorderColor = System.Drawing.Color.LightCoral
        Me.LEDRED.BorderWidth = 10
        Me.LEDRED.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LEDRED.Location = New System.Drawing.Point(1334, 168)
        Me.LEDRED.Name = "LEDRED"
        Me.LEDRED.Size = New System.Drawing.Size(224, 215)
        '
        'LEDLime
        '
        Me.LEDLime.BackColor = System.Drawing.Color.White
        Me.LEDLime.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LEDLime.BorderColor = System.Drawing.Color.DarkSeaGreen
        Me.LEDLime.BorderWidth = 10
        Me.LEDLime.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LEDLime.Location = New System.Drawing.Point(1335, 634)
        Me.LEDLime.Name = "LEDLime"
        Me.LEDLime.Size = New System.Drawing.Size(224, 215)
        '
        'LEDGold
        '
        Me.LEDGold.BackColor = System.Drawing.Color.White
        Me.LEDGold.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.LEDGold.BorderColor = System.Drawing.Color.NavajoWhite
        Me.LEDGold.BorderWidth = 10
        Me.LEDGold.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LEDGold.Location = New System.Drawing.Point(1334, 400)
        Me.LEDGold.Name = "LEDGold"
        Me.LEDGold.Size = New System.Drawing.Size(224, 215)
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 600
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 849)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 32)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "* Package ( WIP / WIP PLAN )"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(161, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 80)
        Me.Panel1.TabIndex = 14
        '
        'box1
        '
        Me.box1.BackColor = System.Drawing.Color.Black
        Me.box1.Location = New System.Drawing.Point(1247, 91)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(45, 117)
        Me.box1.TabIndex = 15
        '
        'box2
        '
        Me.box2.BackColor = System.Drawing.Color.Black
        Me.box2.Location = New System.Drawing.Point(1181, 91)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(43, 117)
        Me.box2.TabIndex = 16
        '
        'box3
        '
        Me.box3.BackColor = System.Drawing.Color.Black
        Me.box3.Location = New System.Drawing.Point(1113, 91)
        Me.box3.Name = "box3"
        Me.box3.Size = New System.Drawing.Size(43, 117)
        Me.box3.TabIndex = 15
        '
        'box4
        '
        Me.box4.BackColor = System.Drawing.Color.Black
        Me.box4.Location = New System.Drawing.Point(1047, 91)
        Me.box4.Name = "box4"
        Me.box4.Size = New System.Drawing.Size(43, 117)
        Me.box4.TabIndex = 16
        '
        'box5
        '
        Me.box5.BackColor = System.Drawing.Color.Black
        Me.box5.Location = New System.Drawing.Point(983, 91)
        Me.box5.Name = "box5"
        Me.box5.Size = New System.Drawing.Size(43, 117)
        Me.box5.TabIndex = 15
        '
        'box6
        '
        Me.box6.BackColor = System.Drawing.Color.Black
        Me.box6.Location = New System.Drawing.Point(917, 91)
        Me.box6.Name = "box6"
        Me.box6.Size = New System.Drawing.Size(43, 117)
        Me.box6.TabIndex = 16
        '
        'box7
        '
        Me.box7.BackColor = System.Drawing.Color.Black
        Me.box7.Location = New System.Drawing.Point(852, 91)
        Me.box7.Name = "box7"
        Me.box7.Size = New System.Drawing.Size(43, 117)
        Me.box7.TabIndex = 16
        '
        'UserControlWIP2
        '
        Me.UserControlWIP2.Location = New System.Drawing.Point(425, 86)
        Me.UserControlWIP2.Name = "UserControlWIP2"
        Me.UserControlWIP2.Size = New System.Drawing.Size(408, 745)
        Me.UserControlWIP2.TabIndex = 12
        '
        'UserControlWIP1
        '
        Me.UserControlWIP1.Location = New System.Drawing.Point(12, 86)
        Me.UserControlWIP1.Name = "UserControlWIP1"
        Me.UserControlWIP1.Size = New System.Drawing.Size(407, 745)
        Me.UserControlWIP1.TabIndex = 12
        '
        'UserControlPassBox7
        '
        Me.UserControlPassBox7.BackColor = System.Drawing.Color.DarkGray
        Me.UserControlPassBox7.Location = New System.Drawing.Point(843, 211)
        Me.UserControlPassBox7.Name = "UserControlPassBox7"
        Me.UserControlPassBox7.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox7.TabIndex = 0
        '
        'UserControlPassBox6
        '
        Me.UserControlPassBox6.BackColor = System.Drawing.Color.DarkGray
        Me.UserControlPassBox6.Location = New System.Drawing.Point(909, 211)
        Me.UserControlPassBox6.Name = "UserControlPassBox6"
        Me.UserControlPassBox6.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox6.TabIndex = 0
        '
        'UserControlPassBox5
        '
        Me.UserControlPassBox5.BackColor = System.Drawing.Color.DarkGray
        Me.UserControlPassBox5.Location = New System.Drawing.Point(975, 211)
        Me.UserControlPassBox5.Name = "UserControlPassBox5"
        Me.UserControlPassBox5.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox5.TabIndex = 0
        '
        'UserControlPassBox4
        '
        Me.UserControlPassBox4.BackColor = System.Drawing.Color.DarkGray
        Me.UserControlPassBox4.Location = New System.Drawing.Point(1041, 211)
        Me.UserControlPassBox4.Name = "UserControlPassBox4"
        Me.UserControlPassBox4.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox4.TabIndex = 0
        '
        'UserControlPassBox3
        '
        Me.UserControlPassBox3.BackColor = System.Drawing.Color.DarkGray
        Me.UserControlPassBox3.Location = New System.Drawing.Point(1107, 211)
        Me.UserControlPassBox3.Name = "UserControlPassBox3"
        Me.UserControlPassBox3.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox3.TabIndex = 0
        '
        'UserControlPassBox2
        '
        Me.UserControlPassBox2.BackColor = System.Drawing.Color.DarkGray
        Me.UserControlPassBox2.Location = New System.Drawing.Point(1173, 211)
        Me.UserControlPassBox2.Name = "UserControlPassBox2"
        Me.UserControlPassBox2.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox2.TabIndex = 0
        '
        'UserControlPassBox1
        '
        Me.UserControlPassBox1.BackColor = System.Drawing.Color.SlateGray
        Me.UserControlPassBox1.Location = New System.Drawing.Point(1239, 211)
        Me.UserControlPassBox1.Name = "UserControlPassBox1"
        Me.UserControlPassBox1.Size = New System.Drawing.Size(60, 684)
        Me.UserControlPassBox1.TabIndex = 0
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.box1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserControlWIP2)
        Me.Controls.Add(Me.UserControlWIP1)
        Me.Controls.Add(Me.bttotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserControlPassBox7)
        Me.Controls.Add(Me.UserControlPassBox6)
        Me.Controls.Add(Me.UserControlPassBox5)
        Me.Controls.Add(Me.UserControlPassBox4)
        Me.Controls.Add(Me.UserControlPassBox3)
        Me.Controls.Add(Me.UserControlPassBox2)
        Me.Controls.Add(Me.UserControlPassBox1)
        Me.Controls.Add(Me.box7)
        Me.Controls.Add(Me.box6)
        Me.Controls.Add(Me.box5)
        Me.Controls.Add(Me.box4)
        Me.Controls.Add(Me.box3)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataSet11 As WBMonitorPassBox.DataSet1
    Friend WithEvents WbmpPassboxTableAdapter1 As WBMonitorPassBox.DataSet1TableAdapters.WBMPPassboxTableAdapter
    Friend WithEvents UserControlPassBox1 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents UserControlPassBox2 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents UserControlPassBox3 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents UserControlPassBox4 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents UserControlPassBox5 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents UserControlPassBox6 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents UserControlPassBox7 As WBMonitorPassBox.UserControlPassBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bttotal As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LEDRED As PowerPacks.OvalShape
    Private WithEvents LEDLime As PowerPacks.OvalShape
    Private WithEvents LEDGold As PowerPacks.OvalShape
    Private WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents UserControlWIP1 As WBMonitorPassBox.UserControlWIP
    Friend WithEvents UserControlWIP2 As WBMonitorPassBox.UserControlWIP
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents box1 As System.Windows.Forms.Label
    Friend WithEvents box2 As System.Windows.Forms.Label
    Friend WithEvents box3 As System.Windows.Forms.Label
    Friend WithEvents box4 As System.Windows.Forms.Label
    Friend WithEvents box5 As System.Windows.Forms.Label
    Friend WithEvents box6 As System.Windows.Forms.Label
    Friend WithEvents box7 As System.Windows.Forms.Label
End Class
