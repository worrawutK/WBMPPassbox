<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btNumber = New System.Windows.Forms.Button
        Me.btQR01 = New System.Windows.Forms.Button
        Me.btLotNo = New System.Windows.Forms.Button
        Me.btPKG = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btNumber
        '
        Me.btNumber.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular)
        Me.btNumber.Location = New System.Drawing.Point(0, 0)
        Me.btNumber.Name = "btNumber"
        Me.btNumber.Size = New System.Drawing.Size(50, 26)
        Me.btNumber.TabIndex = 12
        '
        'btQR01
        '
        Me.btQR01.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.btQR01.Location = New System.Drawing.Point(0, 0)
        Me.btQR01.Name = "btQR01"
        Me.btQR01.Size = New System.Drawing.Size(151, 125)
        Me.btQR01.TabIndex = 10
        '
        'btLotNo
        '
        Me.btLotNo.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btLotNo.Location = New System.Drawing.Point(0, 25)
        Me.btLotNo.Name = "btLotNo"
        Me.btLotNo.Size = New System.Drawing.Size(151, 50)
        Me.btLotNo.TabIndex = 13
        Me.btLotNo.Tag = ""
        '
        'btPKG
        '
        Me.btPKG.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.btPKG.Location = New System.Drawing.Point(0, 74)
        Me.btPKG.Name = "btPKG"
        Me.btPKG.Size = New System.Drawing.Size(151, 50)
        Me.btPKG.TabIndex = 13
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.btPKG)
        Me.Controls.Add(Me.btLotNo)
        Me.Controls.Add(Me.btNumber)
        Me.Controls.Add(Me.btQR01)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(151, 125)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btNumber As System.Windows.Forms.Button
    Friend WithEvents btQR01 As System.Windows.Forms.Button
    Friend WithEvents btLotNo As System.Windows.Forms.Button
    Friend WithEvents btPKG As System.Windows.Forms.Button

End Class
