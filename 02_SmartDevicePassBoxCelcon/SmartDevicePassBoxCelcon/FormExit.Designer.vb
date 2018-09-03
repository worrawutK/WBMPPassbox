<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormExit
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
        Me.tbLogout = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btLogout = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tbLogout
        '
        Me.tbLogout.Location = New System.Drawing.Point(95, 11)
        Me.tbLogout.Name = "tbLogout"
        Me.tbLogout.Size = New System.Drawing.Size(100, 23)
        Me.tbLogout.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.Text = "Password :"
        '
        'btLogout
        '
        Me.btLogout.Location = New System.Drawing.Point(95, 40)
        Me.btLogout.Name = "btLogout"
        Me.btLogout.Size = New System.Drawing.Size(67, 20)
        Me.btLogout.TabIndex = 3
        Me.btLogout.Text = "OK"
        '
        'FormExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(238, 76)
        Me.ControlBox = False
        Me.Controls.Add(Me.btLogout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLogout)
        Me.Location = New System.Drawing.Point(120, 160)
        Me.Name = "FormExit"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbLogout As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btLogout As System.Windows.Forms.Button
End Class
