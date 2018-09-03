<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlShow
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btText = New System.Windows.Forms.Button()
        Me.pnlBox = New System.Windows.Forms.Panel()
        Me.lbShipmentDate = New System.Windows.Forms.Label()
        Me.lbLotNoData = New System.Windows.Forms.Label()
        Me.lbOutday = New System.Windows.Forms.Label()
        Me.lblLotNo = New System.Windows.Forms.Label()
        Me.lbOutdaytxt = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lbInputDate = New System.Windows.Forms.Label()
        Me.pnlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'btText
        '
        Me.btText.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btText.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btText.Location = New System.Drawing.Point(20, 12)
        Me.btText.Name = "btText"
        Me.btText.Size = New System.Drawing.Size(75, 54)
        Me.btText.TabIndex = 396
        Me.btText.UseVisualStyleBackColor = False
        '
        'pnlBox
        '
        Me.pnlBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBox.Controls.Add(Me.lbInputDate)
        Me.pnlBox.Controls.Add(Me.lbShipmentDate)
        Me.pnlBox.Controls.Add(Me.lbLotNoData)
        Me.pnlBox.Controls.Add(Me.lbOutday)
        Me.pnlBox.Controls.Add(Me.lblLotNo)
        Me.pnlBox.Controls.Add(Me.lbOutdaytxt)
        Me.pnlBox.Location = New System.Drawing.Point(20, 72)
        Me.pnlBox.Name = "pnlBox"
        Me.pnlBox.Size = New System.Drawing.Size(444, 180)
        Me.pnlBox.TabIndex = 397
        '
        'lbShipmentDate
        '
        Me.lbShipmentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbShipmentDate.BackColor = System.Drawing.Color.Transparent
        Me.lbShipmentDate.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbShipmentDate.Location = New System.Drawing.Point(229, 147)
        Me.lbShipmentDate.Name = "lbShipmentDate"
        Me.lbShipmentDate.Size = New System.Drawing.Size(199, 19)
        Me.lbShipmentDate.TabIndex = 365
        Me.lbShipmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLotNoData
        '
        Me.lbLotNoData.AutoSize = True
        Me.lbLotNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotNoData.Location = New System.Drawing.Point(147, 12)
        Me.lbLotNoData.Name = "lbLotNoData"
        Me.lbLotNoData.Size = New System.Drawing.Size(29, 39)
        Me.lbLotNoData.TabIndex = 363
        Me.lbLotNoData.Text = "-"
        '
        'lbOutday
        '
        Me.lbOutday.AutoSize = True
        Me.lbOutday.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutday.Location = New System.Drawing.Point(147, 84)
        Me.lbOutday.Name = "lbOutday"
        Me.lbOutday.Size = New System.Drawing.Size(29, 39)
        Me.lbOutday.TabIndex = 364
        Me.lbOutday.Text = "-"
        '
        'lblLotNo
        '
        Me.lblLotNo.AutoSize = True
        Me.lblLotNo.BackColor = System.Drawing.Color.Transparent
        Me.lblLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLotNo.Location = New System.Drawing.Point(3, 12)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(155, 39)
        Me.lblLotNo.TabIndex = 361
        Me.lblLotNo.Text = "LOT NO."
        '
        'lbOutdaytxt
        '
        Me.lbOutdaytxt.AutoSize = True
        Me.lbOutdaytxt.BackColor = System.Drawing.Color.Transparent
        Me.lbOutdaytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutdaytxt.Location = New System.Drawing.Point(3, 84)
        Me.lbOutdaytxt.Name = "lbOutdaytxt"
        Me.lbOutdaytxt.Size = New System.Drawing.Size(100, 39)
        Me.lbOutdaytxt.TabIndex = 362
        Me.lbOutdaytxt.Text = "PKG."
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnInput.FlatAppearance.BorderSize = 4
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Location = New System.Drawing.Point(1, 0)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(506, 268)
        Me.btnInput.TabIndex = 395
        Me.btnInput.TabStop = False
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'lbInputDate
        '
        Me.lbInputDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbInputDate.BackColor = System.Drawing.Color.Transparent
        Me.lbInputDate.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbInputDate.Location = New System.Drawing.Point(6, 147)
        Me.lbInputDate.Name = "lbInputDate"
        Me.lbInputDate.Size = New System.Drawing.Size(199, 19)
        Me.lbInputDate.TabIndex = 365
        Me.lbInputDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserControlShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btText)
        Me.Controls.Add(Me.pnlBox)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "UserControlShow"
        Me.Size = New System.Drawing.Size(510, 269)
        Me.pnlBox.ResumeLayout(False)
        Me.pnlBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btText As System.Windows.Forms.Button
    Friend WithEvents pnlBox As System.Windows.Forms.Panel
    Friend WithEvents lbShipmentDate As System.Windows.Forms.Label
    Friend WithEvents lbLotNoData As System.Windows.Forms.Label
    Friend WithEvents lbOutday As System.Windows.Forms.Label
    Friend WithEvents lblLotNo As System.Windows.Forms.Label
    Friend WithEvents lbOutdaytxt As System.Windows.Forms.Label
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents lbInputDate As System.Windows.Forms.Label

End Class
