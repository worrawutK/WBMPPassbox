<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PopUpOPID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUpOPID))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tbQROPID = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(365, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'tbQROPID
        '
        Me.tbQROPID.BackColor = System.Drawing.SystemColors.Control
        Me.tbQROPID.Font = New System.Drawing.Font("Tahoma", 1.0!, System.Drawing.FontStyle.Regular)
        Me.tbQROPID.Location = New System.Drawing.Point(6, 15)
        Me.tbQROPID.Name = "tbQROPID"
        Me.tbQROPID.Size = New System.Drawing.Size(1, 8)
        Me.tbQROPID.TabIndex = 1
        '
        'PopUpOPID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(367, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbQROPID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Location = New System.Drawing.Point(42, 160)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpOPID"
        Me.Text = "กรุณาสแกน OPID"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbQROPID As System.Windows.Forms.TextBox
End Class
