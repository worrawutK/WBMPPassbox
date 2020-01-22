<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ComboMonthPlan = New System.Windows.Forms.ComboBox()
        Me.ComboYearPlan = New System.Windows.Forms.ComboBox()
        Me.ComboLastMonthPlan = New System.Windows.Forms.ComboBox()
        Me.ComboLastYearPlan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboUpdateMonth = New System.Windows.Forms.ComboBox()
        Me.ComboUpdateYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WBMPPassboxSettingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WipPlanMP.DataSet1()
        Me.WBMPPassboxSettingTableAdapter = New WipPlanMP.DataSet1TableAdapters.WBMPPassboxSettingTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.WBMPPassboxSettingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(295, 499)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(161, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 499)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(87, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 52)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save Plan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(777, 119)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(373, 499)
        Me.DataGridView2.TabIndex = 3
        '
        'ComboMonthPlan
        '
        Me.ComboMonthPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboMonthPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboMonthPlan.FormattingEnabled = True
        Me.ComboMonthPlan.Location = New System.Drawing.Point(73, 74)
        Me.ComboMonthPlan.Name = "ComboMonthPlan"
        Me.ComboMonthPlan.Size = New System.Drawing.Size(121, 21)
        Me.ComboMonthPlan.TabIndex = 5
        '
        'ComboYearPlan
        '
        Me.ComboYearPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboYearPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboYearPlan.FormattingEnabled = True
        Me.ComboYearPlan.Location = New System.Drawing.Point(73, 125)
        Me.ComboYearPlan.Name = "ComboYearPlan"
        Me.ComboYearPlan.Size = New System.Drawing.Size(121, 21)
        Me.ComboYearPlan.TabIndex = 5
        '
        'ComboLastMonthPlan
        '
        Me.ComboLastMonthPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboLastMonthPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboLastMonthPlan.FormattingEnabled = True
        Me.ComboLastMonthPlan.Location = New System.Drawing.Point(158, 76)
        Me.ComboLastMonthPlan.Name = "ComboLastMonthPlan"
        Me.ComboLastMonthPlan.Size = New System.Drawing.Size(121, 21)
        Me.ComboLastMonthPlan.TabIndex = 5
        '
        'ComboLastYearPlan
        '
        Me.ComboLastYearPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboLastYearPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboLastYearPlan.FormattingEnabled = True
        Me.ComboLastYearPlan.Location = New System.Drawing.Point(294, 76)
        Me.ComboLastYearPlan.Name = "ComboLastYearPlan"
        Me.ComboLastYearPlan.Size = New System.Drawing.Size(121, 21)
        Me.ComboLastYearPlan.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Select"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(375, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ADD WIP PLAN"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ComboMonthPlan)
        Me.Panel4.Controls.Add(Me.ComboYearPlan)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(484, 122)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(271, 342)
        Me.Panel4.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(200, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 42)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = ">>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 42)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ">>"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1064, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Select"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboUpdateMonth
        '
        Me.ComboUpdateMonth.FormattingEnabled = True
        Me.ComboUpdateMonth.Location = New System.Drawing.Point(789, 76)
        Me.ComboUpdateMonth.Name = "ComboUpdateMonth"
        Me.ComboUpdateMonth.Size = New System.Drawing.Size(121, 21)
        Me.ComboUpdateMonth.TabIndex = 10
        '
        'ComboUpdateYear
        '
        Me.ComboUpdateYear.FormattingEnabled = True
        Me.ComboUpdateYear.Location = New System.Drawing.Point(928, 76)
        Me.ComboUpdateYear.Name = "ComboUpdateYear"
        Me.ComboUpdateYear.Size = New System.Drawing.Size(121, 21)
        Me.ComboUpdateYear.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(227, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SELECT WIP PLAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(884, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "EDIT WIP PLAN"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(17, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 43)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ComboUpdateYear)
        Me.Panel2.Controls.Add(Me.ComboLastYearPlan)
        Me.Panel2.Controls.Add(Me.ComboUpdateMonth)
        Me.Panel2.Controls.Add(Me.ComboLastMonthPlan)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(17, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1331, 621)
        Me.Panel2.TabIndex = 13
        '
        'WBMPPassboxSettingBindingSource
        '
        Me.WBMPPassboxSettingBindingSource.DataMember = "WBMPPassboxSetting"
        Me.WBMPPassboxSettingBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WBMPPassboxSettingTableAdapter
        '
        Me.WBMPPassboxSettingTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1360, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan MP"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.WBMPPassboxSettingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents WBMPPassboxSettingBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WBMPPassboxSettingTableAdapter As DataSet1TableAdapters.WBMPPassboxSettingTableAdapter
    Friend WithEvents ComboMonthPlan As ComboBox
    Friend WithEvents ComboYearPlan As ComboBox
    Friend WithEvents ComboLastMonthPlan As ComboBox
    Friend WithEvents ComboLastYearPlan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboUpdateMonth As ComboBox
    Friend WithEvents ComboUpdateYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
End Class
