Public Class Form1

   
    Dim TimeStrat As String
    Dim TimeEnd As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.WBMPPassbox' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet1.WBMPPassbox' table. You can move, or remove it, as needed.
        Me.WbmpPassboxTableAdapter1.Fill(Me.DataSet1.WBMPPassbox)

    End Sub

    Private Sub Search_Click(sender As System.Object, e As System.EventArgs) Handles btSearch.Click
        If rbLotNo.Checked Then
            '  Me.DataTable1TableAdapter.Fill(DataSet1.DataTable1, tbSearch.Text)
            Me.WbmpPassboxTableAdapter1.FillLotNo(DataSet1.WBMPPassbox, tbSearch.Text)
        ElseIf rbPackageName.Checked Then
            Me.WbmpPassboxTableAdapter1.FillPKG(DataSet1.WBMPPassbox, tbSearch.Text)
            '  Me.DataTable1TableAdapter.Fill(DataSet1.DataTable1, tbSearch.Text)
        Else
            MsgBox("กรุณาเลือกการค้นหา")
        End If
        If tbSearch.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลที่ต้องการค้นหา")

            Exit Sub
        End If

        'TextBox1.Text = MonthCalendar1.SelectionRange.Start.Date.ToString() & "-" & MonthCalendar2.SelectionRange.Start.Date.ToString()
        '   Me.Process_HistoryTableAdapter.SearchDateTime(DataSet1.Process_History, TimeStrat, TimeEnd)
    End Sub

 
    Private Sub MonthCalendar1_DateSelected(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected, MonthCalendar2.DateSelected
        'Dim val As String
        'val = sender.name
        TimeStrat = MonthCalendar1.SelectionRange.Start.Year.ToString() & "-" & MonthCalendar1.SelectionRange.Start.Month.ToString() & "-" & MonthCalendar1.SelectionRange.Start.Day.ToString() & " 00:00:00"
        TimeEnd = MonthCalendar2.SelectionRange.Start.Year.ToString() & "-" & MonthCalendar2.SelectionRange.Start.Month.ToString() & "-" & MonthCalendar2.SelectionRange.Start.Day.ToString() & " 23:59:59"

        Me.WbmpPassboxTableAdapter1.FillLotNostart(DataSet1.WBMPPassbox, TimeStrat, TimeEnd)
    End Sub


    Private Sub rbDateTime_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbPackageName.CheckedChanged, rbLotNo.CheckedChanged, rbDateTime.CheckedChanged, rbDataINBox.CheckedChanged
        Dim val As String = sender.name
        '  MsgBox(val)
        rbDateTime.ForeColor = Color.White
        rbPackageName.ForeColor = Color.White
        rbLotNo.ForeColor = Color.White
        rbDataINBox.ForeColor = Color.White
        If val = "rbDateTime" Then
            Panel1.Visible = False
            Panel3.Visible = True
            Panel2.Visible = False
            rbDateTime.ForeColor = Color.LawnGreen

            'Panel1.Controls.Add(MonthCalendar1)
            'Panel1.Controls.Add(MonthCalendar2)
            TimeStrat = MonthCalendar1.SelectionRange.Start.Year.ToString() & "-" & MonthCalendar1.SelectionRange.Start.Month.ToString() & "-" & MonthCalendar1.SelectionRange.Start.Day.ToString() & " 00:00:00"
            TimeEnd = MonthCalendar2.SelectionRange.Start.Year.ToString() & "-" & MonthCalendar2.SelectionRange.Start.Month.ToString() & "-" & MonthCalendar2.SelectionRange.Start.Day.ToString() & " 23:59:59"

            Me.WbmpPassboxTableAdapter1.FillLotNostart(DataSet1.WBMPPassbox, TimeStrat, TimeEnd)
        ElseIf val = "rbPackageName" Or val = "rbLotNo" Then
            Panel1.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False

            '     Me.WBMPPassboxTableAdapter.Fill(DataSet1.WBMPPassbox)
            If val = "rbPackageName" Then
                lbNameSearch.Text = "PKG. :"
                rbPackageName.ForeColor = Color.LawnGreen
            Else
                lbNameSearch.Text = "Lot No :"
                rbLotNo.ForeColor = Color.LawnGreen
            End If
        ElseIf val = "rbDataINBox" Then
            'lbNameSearch.Visible = False
            'tbSearch.Visible = False
            'btSearch.Visible = False
            rbDataINBox.ForeColor = Color.LawnGreen
            Panel3.Visible = False
            Panel1.Visible = False
            Panel2.Visible = True
        End If
        'Label1.Visible = False
        'TextBox1.Visible = False
        'Button1.Visible = False
        'MonthCalendar1.Visible = True
        'MonthCalendar2.Visible = True
        Panel3.Controls.Add(MonthCalendar1)
        Panel3.Controls.Add(MonthCalendar2)
        clear()
    End Sub



 
   


    Private Sub BoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BoxToolStripMenuItem.Click, PB07ToolStripMenuItem.Click, PB06ToolStripMenuItem.Click, PB05ToolStripMenuItem.Click, PB04ToolStripMenuItem.Click, PB03ToolStripMenuItem.Click, PB02ToolStripMenuItem.Click
        clear()
        Dim val As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        ' val.BackColor = Color.Black
        '    MainMenuStrip.BackColor = Color.Black
        val.BackColor = Color.LawnGreen

        Me.WbmpPassboxTableAdapter1.FillDataINBox(DataSet1.WBMPPassbox, "MP-" & val.Text)
    End Sub
    Private Sub clear()
        BoxToolStripMenuItem.BackColor = Color.White
        PB02ToolStripMenuItem.BackColor = Color.White
        PB03ToolStripMenuItem.BackColor = Color.White
        PB04ToolStripMenuItem.BackColor = Color.White
        PB05ToolStripMenuItem.BackColor = Color.White
        PB06ToolStripMenuItem.BackColor = Color.White
        PB07ToolStripMenuItem.BackColor = Color.White
    End Sub
End Class
