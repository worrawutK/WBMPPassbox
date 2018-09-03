<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlPassBox
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
        Me.pnlBox = New System.Windows.Forms.Panel()
        Me.lbInputDate = New System.Windows.Forms.Label()
        Me.lbShipmentDate = New System.Windows.Forms.Label()
        Me.lbLotNoData = New System.Windows.Forms.Label()
        Me.lbOutday = New System.Windows.Forms.Label()
        Me.lblLotNo = New System.Windows.Forms.Label()
        Me.lbOutdaytxt = New System.Windows.Forms.Label()
        Me.btText = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.WbmpPassboxTableAdapter1 = New PassBoxCellCon.DBxDataSetTableAdapters.WBMPPassboxTableAdapter()
        Me.pnlBox.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlBox.Location = New System.Drawing.Point(20, 73)
        Me.pnlBox.Name = "pnlBox"
        Me.pnlBox.Size = New System.Drawing.Size(559, 213)
        Me.pnlBox.TabIndex = 391
        '
        'lbInputDate
        '
        Me.lbInputDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbInputDate.BackColor = System.Drawing.Color.Transparent
        Me.lbInputDate.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbInputDate.Location = New System.Drawing.Point(3, 179)
        Me.lbInputDate.Name = "lbInputDate"
        Me.lbInputDate.Size = New System.Drawing.Size(283, 19)
        Me.lbInputDate.TabIndex = 365
        Me.lbInputDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbShipmentDate
        '
        Me.lbShipmentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbShipmentDate.BackColor = System.Drawing.Color.Transparent
        Me.lbShipmentDate.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbShipmentDate.Location = New System.Drawing.Point(269, 179)
        Me.lbShipmentDate.Name = "lbShipmentDate"
        Me.lbShipmentDate.Size = New System.Drawing.Size(283, 19)
        Me.lbShipmentDate.TabIndex = 365
        Me.lbShipmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLotNoData
        '
        Me.lbLotNoData.AutoSize = True
        Me.lbLotNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLotNoData.Location = New System.Drawing.Point(204, 25)
        Me.lbLotNoData.Name = "lbLotNoData"
        Me.lbLotNoData.Size = New System.Drawing.Size(40, 55)
        Me.lbLotNoData.TabIndex = 363
        Me.lbLotNoData.Text = "-"
        '
        'lbOutday
        '
        Me.lbOutday.AutoSize = True
        Me.lbOutday.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutday.Location = New System.Drawing.Point(204, 110)
        Me.lbOutday.Name = "lbOutday"
        Me.lbOutday.Size = New System.Drawing.Size(40, 55)
        Me.lbOutday.TabIndex = 364
        Me.lbOutday.Text = "-"
        '
        'lblLotNo
        '
        Me.lblLotNo.AutoSize = True
        Me.lblLotNo.BackColor = System.Drawing.Color.Transparent
        Me.lblLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblLotNo.Location = New System.Drawing.Point(3, 25)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(215, 55)
        Me.lblLotNo.TabIndex = 361
        Me.lblLotNo.Text = "LOT NO."
        '
        'lbOutdaytxt
        '
        Me.lbOutdaytxt.AutoSize = True
        Me.lbOutdaytxt.BackColor = System.Drawing.Color.Transparent
        Me.lbOutdaytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbOutdaytxt.Location = New System.Drawing.Point(3, 110)
        Me.lbOutdaytxt.Name = "lbOutdaytxt"
        Me.lbOutdaytxt.Size = New System.Drawing.Size(138, 55)
        Me.lbOutdaytxt.TabIndex = 362
        Me.lbOutdaytxt.Text = "PKG."
        '
        'btText
        '
        Me.btText.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btText.Location = New System.Drawing.Point(20, 13)
        Me.btText.Name = "btText"
        Me.btText.Size = New System.Drawing.Size(75, 54)
        Me.btText.TabIndex = 390
        Me.btText.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.Transparent
        Me.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnInput.FlatAppearance.BorderSize = 4
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Location = New System.Drawing.Point(1, 1)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(600, 300)
        Me.btnInput.TabIndex = 389
        Me.btnInput.TabStop = False
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'lbTime
        '
        Me.lbTime.BackColor = System.Drawing.SystemColors.Control
        Me.lbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTime.Location = New System.Drawing.Point(132, 12)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(447, 55)
        Me.lbTime.TabIndex = 392
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WbmpPassboxTableAdapter1
        '
        Me.WbmpPassboxTableAdapter1.ClearBeforeFill = True
        '
        'UserControlPassBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.pnlBox)
        Me.Controls.Add(Me.btText)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "UserControlPassBox"
        Me.Size = New System.Drawing.Size(604, 304)
        Me.pnlBox.ResumeLayout(False)
        Me.pnlBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBox As System.Windows.Forms.Panel
    Friend WithEvents lbLotNoData As System.Windows.Forms.Label
    Friend WithEvents lbOutday As System.Windows.Forms.Label
    Friend WithEvents lblLotNo As System.Windows.Forms.Label
    Friend WithEvents lbOutdaytxt As System.Windows.Forms.Label
    Friend WithEvents btText As System.Windows.Forms.Button
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents WbmpPassboxTableAdapter1 As PassBoxCellCon.DBxDataSetTableAdapters.WBMPPassboxTableAdapter
    Friend WithEvents lbShipmentDate As System.Windows.Forms.Label
    Friend WithEvents lbInputDate As System.Windows.Forms.Label
    Friend WithEvents lbTime As Label
End Class
