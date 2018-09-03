<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlMonitorPassBoxMP
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
        Me.lbStart1 = New System.Windows.Forms.Label()
        Me.lbEmpNo1 = New System.Windows.Forms.Label()
        Me.lbLotNoData = New System.Windows.Forms.Label()
        Me.lbShipmentDate = New System.Windows.Forms.Label()
        Me.lbPKG = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblEmp1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLotNo = New System.Windows.Forms.Label()
        Me.btChannel = New System.Windows.Forms.Button()
        Me.btText = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.WbmpPassboxTableAdapter1 = New PassBoxCellCon.DBxDataSetTableAdapters.WBMPPassboxTableAdapter()
        Me.lbTime = New System.Windows.Forms.Label()
        Me.pnlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBox
        '
        Me.pnlBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBox.Controls.Add(Me.lbStart1)
        Me.pnlBox.Controls.Add(Me.lbEmpNo1)
        Me.pnlBox.Controls.Add(Me.lbLotNoData)
        Me.pnlBox.Controls.Add(Me.lbShipmentDate)
        Me.pnlBox.Controls.Add(Me.lbPKG)
        Me.pnlBox.Controls.Add(Me.lblDate1)
        Me.pnlBox.Controls.Add(Me.lblEmp1)
        Me.pnlBox.Controls.Add(Me.Label1)
        Me.pnlBox.Controls.Add(Me.lblLotNo)
        Me.pnlBox.Location = New System.Drawing.Point(19, 54)
        Me.pnlBox.Name = "pnlBox"
        Me.pnlBox.Size = New System.Drawing.Size(349, 170)
        Me.pnlBox.TabIndex = 357
        '
        'lbStart1
        '
        Me.lbStart1.AutoSize = True
        Me.lbStart1.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStart1.Location = New System.Drawing.Point(671, 69)
        Me.lbStart1.Name = "lbStart1"
        Me.lbStart1.Size = New System.Drawing.Size(15, 19)
        Me.lbStart1.TabIndex = 93
        Me.lbStart1.Text = "-"
        '
        'lbEmpNo1
        '
        Me.lbEmpNo1.AutoSize = True
        Me.lbEmpNo1.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbEmpNo1.Location = New System.Drawing.Point(671, 39)
        Me.lbEmpNo1.Name = "lbEmpNo1"
        Me.lbEmpNo1.Size = New System.Drawing.Size(15, 19)
        Me.lbEmpNo1.TabIndex = 93
        Me.lbEmpNo1.Text = "-"
        '
        'lbLotNoData
        '
        Me.lbLotNoData.AutoSize = True
        Me.lbLotNoData.Font = New System.Drawing.Font("Leelawadee", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLotNoData.Location = New System.Drawing.Point(81, 47)
        Me.lbLotNoData.Name = "lbLotNoData"
        Me.lbLotNoData.Size = New System.Drawing.Size(32, 41)
        Me.lbLotNoData.TabIndex = 93
        Me.lbLotNoData.Text = "-"
        '
        'lbShipmentDate
        '
        Me.lbShipmentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbShipmentDate.BackColor = System.Drawing.Color.Transparent
        Me.lbShipmentDate.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbShipmentDate.Location = New System.Drawing.Point(37, 147)
        Me.lbShipmentDate.Name = "lbShipmentDate"
        Me.lbShipmentDate.Size = New System.Drawing.Size(293, 19)
        Me.lbShipmentDate.TabIndex = 93
        Me.lbShipmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPKG
        '
        Me.lbPKG.AutoSize = True
        Me.lbPKG.BackColor = System.Drawing.Color.Transparent
        Me.lbPKG.Font = New System.Drawing.Font("Leelawadee", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPKG.Location = New System.Drawing.Point(81, 98)
        Me.lbPKG.Name = "lbPKG"
        Me.lbPKG.Size = New System.Drawing.Size(32, 41)
        Me.lbPKG.TabIndex = 92
        Me.lbPKG.Text = "-"
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.BackColor = System.Drawing.Color.Transparent
        Me.lblDate1.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.Location = New System.Drawing.Point(588, 69)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(66, 19)
        Me.lblDate1.TabIndex = 56
        Me.lblDate1.Text = "Time In"
        '
        'lblEmp1
        '
        Me.lblEmp1.AutoSize = True
        Me.lblEmp1.BackColor = System.Drawing.Color.Transparent
        Me.lblEmp1.Font = New System.Drawing.Font("Leelawadee", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmp1.Location = New System.Drawing.Point(588, 39)
        Me.lblEmp1.Name = "lblEmp1"
        Me.lblEmp1.Size = New System.Drawing.Size(73, 19)
        Me.lblEmp1.TabIndex = 16
        Me.lblEmp1.Text = "EMP No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PKG."
        '
        'lblLotNo
        '
        Me.lblLotNo.AutoSize = True
        Me.lblLotNo.BackColor = System.Drawing.Color.Transparent
        Me.lblLotNo.Font = New System.Drawing.Font("Leelawadee", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotNo.Location = New System.Drawing.Point(2, 8)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(137, 39)
        Me.lblLotNo.TabIndex = 15
        Me.lblLotNo.Text = "LOT NO."
        '
        'btChannel
        '
        Me.btChannel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btChannel.Location = New System.Drawing.Point(19, 230)
        Me.btChannel.Name = "btChannel"
        Me.btChannel.Size = New System.Drawing.Size(349, 52)
        Me.btChannel.TabIndex = 356
        Me.btChannel.Text = "Take-Out"
        Me.btChannel.UseVisualStyleBackColor = True
        '
        'btText
        '
        Me.btText.Font = New System.Drawing.Font("Leelawadee", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btText.Location = New System.Drawing.Point(20, 18)
        Me.btText.Name = "btText"
        Me.btText.Size = New System.Drawing.Size(68, 36)
        Me.btText.TabIndex = 355
        Me.btText.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.Transparent
        Me.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnInput.FlatAppearance.BorderSize = 4
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Location = New System.Drawing.Point(1, 2)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(371, 292)
        Me.btnInput.TabIndex = 354
        Me.btnInput.TabStop = False
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'WbmpPassboxTableAdapter1
        '
        Me.WbmpPassboxTableAdapter1.ClearBeforeFill = True
        '
        'lbTime
        '
        Me.lbTime.Font = New System.Drawing.Font("Leelawadee", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTime.Location = New System.Drawing.Point(163, 10)
        Me.lbTime.Name = "lbTime"
        Me.lbTime.Size = New System.Drawing.Size(188, 41)
        Me.lbTime.TabIndex = 358
        Me.lbTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UserControlMonitorPassBoxMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbTime)
        Me.Controls.Add(Me.pnlBox)
        Me.Controls.Add(Me.btChannel)
        Me.Controls.Add(Me.btText)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "UserControlMonitorPassBoxMP"
        Me.Size = New System.Drawing.Size(371, 292)
        Me.pnlBox.ResumeLayout(False)
        Me.pnlBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBox As System.Windows.Forms.Panel
    Friend WithEvents lbStart1 As System.Windows.Forms.Label
    Friend WithEvents lbEmpNo1 As System.Windows.Forms.Label
    Friend WithEvents lbLotNoData As System.Windows.Forms.Label
    Friend WithEvents lbShipmentDate As System.Windows.Forms.Label
    Friend WithEvents lbPKG As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblEmp1 As System.Windows.Forms.Label
    Friend WithEvents lblLotNo As System.Windows.Forms.Label
    Friend WithEvents btChannel As System.Windows.Forms.Button
    Friend WithEvents btText As System.Windows.Forms.Button
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents WbmpPassboxTableAdapter1 As PassBoxCellCon.DBxDataSetTableAdapters.WBMPPassboxTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbTime As Label
End Class
