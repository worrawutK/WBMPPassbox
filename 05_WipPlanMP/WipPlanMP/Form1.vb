Imports System.IO
'Imports Microsoft.Office.Interop.Excel
Public Class Form1
    Dim ShowGridview As New DataTable
    Dim dateSelect As Date
    Dim datePlan As Date
    ' Dim DataUPdate As DataSet1.WBMPPassboxSettingDataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateSelect = Now 'AddMonths(-1)
        datePlan = Now
        For i = 0 To 5
            ComboLastYearPlan.Items.Add(dateSelect.ToString("yyyy") + 1 - i)
            ComboYearPlan.Items.Add(datePlan.ToString("yyyy") + i)
            ComboUpdateYear.Items.Add(dateSelect.ToString("yyyy") + 1 - i)



        Next
        For j = 0 To 11
            ComboUpdateMonth.Items.Add(Now.AddMonths(+j).ToString("MMMM"))
            ComboLastMonthPlan.Items.Add(Now.AddMonths(+j).ToString("MMMM"))
            ComboMonthPlan.Items.Add(Now.AddMonths(+j).ToString("MMMM"))
        Next
        ComboLastMonthPlan.Text = dateSelect.ToString("MMMM")
        ComboLastYearPlan.Text = dateSelect.ToString("yyyy")

        ComboMonthPlan.Text = datePlan.ToString("MMMM")
        ComboYearPlan.Text = datePlan.ToString("yyyy")

        ComboUpdateMonth.Text = dateSelect.ToString("MMMM")
        ComboUpdateYear.Text = dateSelect.ToString("yyyy")

        SelectPlanData()
        '  Dim dater As Date = Date.Now
        'Dim count As Integer

        'Dim dattt As Date = CDate(ComboBox1.Text & ComboBox2.Text)
        'dattt.Month.ToString()
        'dattt.Day.ToString()


        'TODO: This line of code loads data into the 'DataSet1.WBMPPassboxSetting' table. You can move, or remove it, as needed.
        'Dim dater As Date = Date.Now
        ''Dim count As Integer
        'ShowGridview.Columns.Add("Package")
        ''  ShowGridview.Columns(0).s
        'ShowGridview.Columns.Add("InputPlan")

        ''Dim countRows As New DataTable
        ''countRows.Columns.Add("COUNT")


        ''Dim roww As DataRow = countRows.NewRow
        ''roww("COUNT") = DataSet1.WBMPPassboxSetting.Count
        ''countRows.Rows.Add(roww)

        'DataGridView1.DataSource = ShowGridview 'daT
        'Label1.Text = DataSet1.WBMPPassboxSetting.Count
        ''   DataGridView3.DataSource = countRows
        '' dgvTotal.DataSource = daT
        '   DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectData As Date = CDate(ComboMonthPlan.Text & ComboYearPlan.Text)
        'If Now > selectData Then
        '    MsgBox("กรุณาตรวจสอบเดือน") 'บันทึกย้อนหลัง
        '    Exit Sub
        'End If
        'Me.WBMPPassboxSettingTableAdapter.Fill(Me.DataSet1.WBMPPassboxSetting, selectData.Year, selectData.Month)
        'If DataSet1.WBMPPassboxSetting.Count > 0 Then
        '    For Each data As DataSet1.WBMPPassboxSettingRow In DataSet1.WBMPPassboxSetting
        '        data.Package =
        '    Next

        'End If


        Dim SPPassboxSettingQuery As New DataSet1TableAdapters.WBMPPassboxSettingTableAdapter
        Dim DataSettingDetail As DataSet1.WBMPPassboxSettingDataTable = New DataSet1.WBMPPassboxSettingDataTable
        ' DataUPdate = DataSettingDetail

        For Each rowShow As DataRow In ShowGridview.Rows
            Dim Detail As DataSet1.WBMPPassboxSettingRow = DataSettingDetail.NewRow

            Detail.Package = rowShow("Package")
            Detail.InputPlan = rowShow("InputPlan")

            Detail.CreateTime = CDate(ComboMonthPlan.Text & ComboYearPlan.Text)



            DataSettingDetail.Rows.Add(Detail)
        Next
        Try
            SPPassboxSettingQuery.Update(DataSettingDetail)

        Catch ex As Exception
            MsgBox("มีข้อมูลใน " & selectData.ToString("MMMM-yyyy") & " นี้แล้ว") 'ข้อมูลซ้ำกัน
        End Try
        'DataGridView2.DataSource = DataSettingDetail
        Me.WBMPPassboxSettingTableAdapter.Fill(Me.DataSet1.WBMPPassboxSetting, selectData.Year, selectData.Month)
        DataGridView2.DataSource = DataSet1.WBMPPassboxSetting
        '  Dim NRFormat As String = "MMMM yyyy"
        '  DataGridView2.Columns("CreateTime").DefaultCellStyle.Format = NRFormat
        DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub


    Private Sub SelectPlanData()
        Try
            ShowGridview.Columns.Add("Package")
            '  ShowGridview.Columns(0).s
            ShowGridview.Columns.Add("InputPlan")
        Catch ex As Exception

        End Try
        ShowGridview.Clear()
        'Dim countRows As New DataTable
        'countRows.Columns.Add("COUNT")
        '  MsgBox("xx")

        Dim selectData As Date = CDate(ComboLastMonthPlan.Text & ComboLastYearPlan.Text)

        Me.WBMPPassboxSettingTableAdapter.Fill(Me.DataSet1.WBMPPassboxSetting, selectData.Year, selectData.Month)
        For Each data As DataSet1.WBMPPassboxSettingRow In DataSet1.WBMPPassboxSetting
            Dim rowShow As DataRow = ShowGridview.NewRow
            rowShow("Package") = data.Package
            rowShow("InputPlan") = data.InputPlan
            ShowGridview.Rows.Add(rowShow)
            'count += 1
            'data.Number = CStr(count)

        Next



        'Dim roww As DataRow = countRows.NewRow
        'roww("COUNT") = DataSet1.WBMPPassboxSetting.Count
        'countRows.Rows.Add(roww)

        DataGridView1.DataSource = ShowGridview 'daT
        Label1.Text = DataSet1.WBMPPassboxSetting.Count
        '   DataGridView3.DataSource = countRows
        ' dgvTotal.DataSource = daT
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SelectPlanData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application 'Microsoft.Office.Interop.Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")


            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next
            Dim savefile As New SaveFileDialog
            ' Dim resp As MsgBoxResult
            Dim fileName As String = "WIP PLAN"
            '  resp = MessageBox.Show("ส่งออก เอ้ก", "ส่งเอกสาร", MessageBoxButtons.YesNo)
            '   If resp = MsgBoxResult.Yes Then
            savefile.Filter = "Excel file |*.xlsx"
            savefile.Title = "save an Excel File"
            savefile.FileName = "WIP PLAN"
            ' If savefile.FileName <> "" Then

            ' End If
            If savefile.ShowDialog() = DialogResult.OK Then

                fileName = savefile.FileName
                Try
                    xlWorkSheet.DisplayAlerts = False
                Catch ex As Exception

                End Try

                xlWorkSheet.SaveAs(fileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
            End If

            ' End If


            '  MsgBox("You can find the file D:\vbexcel.xlsx")
        Catch ex As Exception

        End Try


    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectData As Date = CDate(ComboUpdateMonth.Text & ComboUpdateYear.Text)
        ' Me.WBMPPassboxSettingTableAdapter.Fill(Me.DataSet1.WBMPPassboxSetting, selectData.Year, selectData.Month)
        Me.WBMPPassboxSettingTableAdapter.Fill(Me.DataSet1.WBMPPassboxSetting, selectData.Year, selectData.Month)
        DataGridView2.DataSource = DataSet1.WBMPPassboxSetting
        DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Try
            WBMPPassboxSettingTableAdapter.Update(DataSet1.WBMPPassboxSetting)
        Catch ex As Exception
            MsgBox("s")
        End Try
    End Sub

    Private Sub DataGridView2_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView2.UserDeletedRow
        ''Exit Sub
        'delete
        Try
            WBMPPassboxSettingTableAdapter.Update(DataSet1.WBMPPassboxSetting)
        Catch ex As Exception
            MsgBox("s")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.DialogResult = DialogResult.OK

    End Sub
End Class
