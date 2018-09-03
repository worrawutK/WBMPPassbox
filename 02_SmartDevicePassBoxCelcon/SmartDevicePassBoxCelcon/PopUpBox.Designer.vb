<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PopUpBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUpBox))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.tbQRBoxID = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 365)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'tbQRBoxID
        '
        Me.tbQRBoxID.Font = New System.Drawing.Font("Tahoma", 1.0!, System.Drawing.FontStyle.Regular)
        Me.tbQRBoxID.Location = New System.Drawing.Point(4, 273)
        Me.tbQRBoxID.Name = "tbQRBoxID"
        Me.tbQRBoxID.Size = New System.Drawing.Size(1, 8)
        Me.tbQRBoxID.TabIndex = 1
        '
        'PopUpBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(254, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbQRBoxID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Location = New System.Drawing.Point(120, 100)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PopUpBox"
        Me.Text = "กรุณาสแกน Pass Box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbQRBoxID As System.Windows.Forms.TextBox
End Class
