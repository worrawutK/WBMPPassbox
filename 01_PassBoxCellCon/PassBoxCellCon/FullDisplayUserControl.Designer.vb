<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FullDisplayUserControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FullDisplayUserControl))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label42 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btOut = New System.Windows.Forms.Button()
        Me.btIN = New System.Windows.Forms.Button()
        Me.Address = New System.Windows.Forms.Label()
        Me.lbNameBox = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserControlPassBox3 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox6 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox2 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox5 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox9 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox8 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox7 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox4 = New PassBoxCellCon.UserControlPassBox()
        Me.UserControlPassBox1 = New PassBoxCellCon.UserControlPassBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!)
        Me.Label42.Location = New System.Drawing.Point(13, 9)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(690, 75)
        Me.Label42.TabIndex = 392
        Me.Label42.Text = "PASS BOX CELLCON"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.PassBoxCellCon.My.Resources.Resources.Minimize_Box_Blue
        Me.PictureBox3.Location = New System.Drawing.Point(1689, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(102, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 396
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1555, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 395
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1797, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 393
        Me.PictureBox1.TabStop = False
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbID.Location = New System.Drawing.Point(1101, 23)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(257, 60)
        Me.lbID.TabIndex = 398
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(898, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 60)
        Me.Label2.TabIndex = 398
        Me.Label2.Text = "OP ID :"
        '
        'btOut
        '
        Me.btOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btOut.Location = New System.Drawing.Point(1385, 5)
        Me.btOut.Name = "btOut"
        Me.btOut.Size = New System.Drawing.Size(146, 89)
        Me.btOut.TabIndex = 399
        Me.btOut.Text = "Logout"
        Me.btOut.UseVisualStyleBackColor = True
        '
        'btIN
        '
        Me.btIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btIN.Location = New System.Drawing.Point(1385, 5)
        Me.btIN.Name = "btIN"
        Me.btIN.Size = New System.Drawing.Size(146, 89)
        Me.btIN.TabIndex = 399
        Me.btIN.Text = "Login"
        Me.btIN.UseVisualStyleBackColor = True
        '
        'Address
        '
        Me.Address.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Address.Location = New System.Drawing.Point(1734, 1053)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(174, 20)
        Me.Address.TabIndex = 400
        Me.Address.Text = "IpAddress"
        Me.Address.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbNameBox
        '
        Me.lbNameBox.AutoSize = True
        Me.lbNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbNameBox.Location = New System.Drawing.Point(30, 1031)
        Me.lbNameBox.Name = "lbNameBox"
        Me.lbNameBox.Size = New System.Drawing.Size(120, 39)
        Me.lbNameBox.TabIndex = 401
        Me.lbNameBox.Text = "Box ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 1032)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 39)
        Me.Label1.TabIndex = 403
        Me.Label1.Text = "Restart Time 00:00 น."
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(1606, 1032)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 43)
        Me.Button1.TabIndex = 404
        Me.Button1.Text = "Update Data"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UserControlPassBox3)
        Me.Panel1.Controls.Add(Me.UserControlPassBox6)
        Me.Panel1.Controls.Add(Me.UserControlPassBox2)
        Me.Panel1.Controls.Add(Me.UserControlPassBox5)
        Me.Panel1.Controls.Add(Me.UserControlPassBox9)
        Me.Panel1.Controls.Add(Me.UserControlPassBox8)
        Me.Panel1.Controls.Add(Me.UserControlPassBox7)
        Me.Panel1.Controls.Add(Me.UserControlPassBox4)
        Me.Panel1.Controls.Add(Me.UserControlPassBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1896, 951)
        Me.Panel1.TabIndex = 405
        '
        'UserControlPassBox3
        '
        Me.UserControlPassBox3.Location = New System.Drawing.Point(15, 21)
        Me.UserControlPassBox3.Name = "UserControlPassBox3"
        Me.UserControlPassBox3.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox3.TabIndex = 1
        '
        'UserControlPassBox6
        '
        Me.UserControlPassBox6.Location = New System.Drawing.Point(15, 331)
        Me.UserControlPassBox6.Name = "UserControlPassBox6"
        Me.UserControlPassBox6.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox6.TabIndex = 1
        '
        'UserControlPassBox2
        '
        Me.UserControlPassBox2.Location = New System.Drawing.Point(651, 21)
        Me.UserControlPassBox2.Name = "UserControlPassBox2"
        Me.UserControlPassBox2.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox2.TabIndex = 1
        '
        'UserControlPassBox5
        '
        Me.UserControlPassBox5.Location = New System.Drawing.Point(651, 331)
        Me.UserControlPassBox5.Name = "UserControlPassBox5"
        Me.UserControlPassBox5.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox5.TabIndex = 1
        '
        'UserControlPassBox9
        '
        Me.UserControlPassBox9.Location = New System.Drawing.Point(15, 646)
        Me.UserControlPassBox9.Name = "UserControlPassBox9"
        Me.UserControlPassBox9.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox9.TabIndex = 1
        '
        'UserControlPassBox8
        '
        Me.UserControlPassBox8.Location = New System.Drawing.Point(651, 647)
        Me.UserControlPassBox8.Name = "UserControlPassBox8"
        Me.UserControlPassBox8.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox8.TabIndex = 1
        '
        'UserControlPassBox7
        '
        Me.UserControlPassBox7.Location = New System.Drawing.Point(1289, 647)
        Me.UserControlPassBox7.Name = "UserControlPassBox7"
        Me.UserControlPassBox7.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox7.TabIndex = 394
        '
        'UserControlPassBox4
        '
        Me.UserControlPassBox4.Location = New System.Drawing.Point(1289, 331)
        Me.UserControlPassBox4.Name = "UserControlPassBox4"
        Me.UserControlPassBox4.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox4.TabIndex = 1
        '
        'UserControlPassBox1
        '
        Me.UserControlPassBox1.Location = New System.Drawing.Point(1289, 22)
        Me.UserControlPassBox1.Name = "UserControlPassBox1"
        Me.UserControlPassBox1.Size = New System.Drawing.Size(604, 304)
        Me.UserControlPassBox1.TabIndex = 0
        '
        'FullDisplayUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbNameBox)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.btIN)
        Me.Controls.Add(Me.btOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FullDisplayUserControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FullDisplayUserControl"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserControlPassBox1 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox2 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox3 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox5 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox6 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox8 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox9 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UserControlPassBox7 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents UserControlPassBox4 As PassBoxCellCon.UserControlPassBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btOut As System.Windows.Forms.Button
    Friend WithEvents btIN As System.Windows.Forms.Button
    Friend WithEvents Address As System.Windows.Forms.Label
    Friend WithEvents lbNameBox As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
