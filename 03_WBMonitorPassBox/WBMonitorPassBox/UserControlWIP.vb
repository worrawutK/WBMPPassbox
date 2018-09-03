Imports System.Data.SqlClient

'Imports System.Linq
Public Class UserControlWIP

    Dim HASUU As Double 'As List(Of Integer) = New List(Of Integer)
    ' Dim PLAN03 As List(Of Integer) = New List(Of Integer)
    Dim PLAN05 As Double 'As List(Of Integer) = New List(Of Integer)
    Dim PLAN01 As Double
    Dim PLANMAX As Double
    Public Sub WIPMP(ByVal SelectPlan As Integer)
        Try
            PLANMAX = 0
            Dim dtMaxWIP As New DataTable
            dtMaxWIP.Columns.Add("Package")
            dtMaxWIP.Columns.Add("COUNTX")
            dtMaxWIP.Columns.Add("PLAN")
            dtMaxWIP.Columns.Add("Weight")

            Dim dtMinWIP As New DataTable
            dtMinWIP.Columns.Add("Package")
            dtMinWIP.Columns.Add("COUNTX")
            dtMinWIP.Columns.Add("PLAN")
            dtMinWIP.Columns.Add("Weight")
            '   dt.Columns(0).AutoIncrement = True
            Dim daaa As Date = Date.Now
            Dim aaaaa As String = daaa.Year & daaa.Month

            WipplandataTableAdapter1.Fill(DataSet11.WIPPLANDATA, Date.Now.Year, Date.Now.Month)
            For Each Data As DataSet1.WIPPLANDATARow In DataSet11.WIPPLANDATA

                ' HASUU = 0

                HASUU = Data.InputPlan * 1.3
                '  PLAN03 = HASUU / 3
                PLAN05 = HASUU * 0.5

                If PLAN05 < 1 Then
                    '    .ToString("####.00")
                    PLAN05 = 1
                Else
                    PLAN05 = PLAN05.ToString("###0")
                End If

                PLAN01 = HASUU * 0.1

                If PLAN01 < 1 Then
                    '    .ToString("####.00")
                    PLAN01 = 1
                Else
                    PLAN01 = PLAN01.ToString("###0")
                End If

                If SelectPlan = PLAN.Overflow Then
                    CountBox1.Text = "WIP Over Package"
                    If Data.COUNTX > PLAN05 Then
                        PLANMAX += (Data.COUNTX - PLAN05)
                        Dim R As DataRow = dtMaxWIP.NewRow
                        R("Package") = Data.Package
                        R("COUNTX") = Data.COUNTX
                        R("PLAN") = PLAN05
                        R("Weight") = (Data.COUNTX / PLAN05).ToString("###0.00")
                        dtMaxWIP.Rows.Add(R)

                        'count += 1
                        'For Each ctr As Control In GroupBox1.Controls
                        '    '   ctr.BackColor = Color.Red
                        '    If TypeOf ctr Is Label Then
                        '        If ctr.TabIndex = count And 40 >= count Then
                        '            ctr.Text = Data.Package & "(" & (Data.COUNTX).ToString & "/" & PLAN05 & ")"
                        '        End If

                        '    End If
                        'Next
                    End If
                    Label1.BackColor = Color.Orange
                    CountBox1.BackColor = Color.Orange
                    '  CountBox1.Text = PLANMAX
                ElseIf SelectPlan = PLAN.Lack Then
                    CountBox1.Text = "WIP Request Package"
                    If Data.COUNTX < PLAN01 Then 'PLAN01
                        PLANMAX += (PLAN05 - Data.COUNTX)
                        Dim R As DataRow = dtMinWIP.NewRow
                        R("Package") = Data.Package
                        R("COUNTX") = Data.COUNTX
                        R("PLAN") = PLAN01
                        R("Weight") = (PLAN01 / Data.COUNTX).ToString("###0.00")
                        dtMinWIP.Rows.Add(R)
                        '    count += 1
                        '    ' num += Data.COUNTX
                        '    For Each ctr As Control In GroupBox1.Controls
                        '        '   ctr.BackColor = Color.Red
                        '        If TypeOf ctr Is Label Then
                        '            If ctr.TabIndex = count And 40 >= count Then
                        '                ctr.Text = Data.Package & "(" & (Data.COUNTX).ToString & "/" & PLAN01 & ")"
                        '            End If

                        '        End If
                        '    Next

                    End If
                    Label1.BackColor = Color.LawnGreen
                    CountBox1.BackColor = Color.LawnGreen
                    ' CountBox1.Text = PLANMAX
                End If

            Next
            Dim viewMaxWIP As New DataView(dtMaxWIP)
            viewMaxWIP.Sort = "Weight desc,COUNTX desc"
            dtMaxWIP = viewMaxWIP.ToTable


            For Each ctr As Control In GroupBox1.Controls
                '   ctr.BackColor = Color.Red
                If TypeOf ctr Is Label Then

                    ctr.Text = Nothing

                End If
            Next


            Dim count As Integer
            For Each dataMaxWIP As DataRow In dtMaxWIP.Rows
                '  Dim aaa As String = dat("Weight")
                count += 1
                For Each ctr As Control In GroupBox1.Controls
                    '   ctr.BackColor = Color.Red
                    If TypeOf ctr Is Label Then
                        If ctr.TabIndex = count And 40 >= count Then
                            ctr.Text = dataMaxWIP("Package") & " (" & dataMaxWIP("COUNTX").ToString & "/" & dataMaxWIP("PLAN").ToString & ")"
                        End If

                    End If
                Next
                ' CountBox1.Text = PLANMAX
            Next

            Dim viewMinWIP As New DataView(dtMinWIP)
            viewMinWIP.Sort = "Weight desc,COUNTX desc"
            dtMinWIP = viewMinWIP.ToTable
            For Each dataMinWIP As DataRow In dtMinWIP.Rows
                '  Dim aaa As String = dat("Weight")
                count += 1
                For Each ctr As Control In GroupBox1.Controls
                    '   ctr.BackColor = Color.Red
                    If TypeOf ctr Is Label Then

                        If ctr.TabIndex = count And 40 >= count Then
                            ctr.Text = dataMinWIP("Package") & " (" & dataMinWIP("COUNTX").ToString & "/" & dataMinWIP("PLAN").ToString & ")"
                      
                        End If

                    End If
                Next

            Next
            'DataGridView1.DataSource = dtMinWIP
        Catch ex As Exception

        End Try


    End Sub
 

    'Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    '    Dim count As Integer
    '    WbmpPassboxSettingTableAdapter1.Fill(DataSet11.WBMPPassboxSetting, "2016-10-13 00:00:00.000")

    '    For Each Data As DataSet1.WBMPPassboxSettingRow In DataSet11.WBMPPassboxSetting


    '        COUNTWBMPSETTING.Add(Data.Package)

    '        HASUU = Data.InputPlan * 1.3
    '        '  PLAN03 = HASUU / 3
    '        PLAN05 = HASUU * 0.5
    '        '     PLAN01 = HASUU * 0.1

    '        WipmpTableAdapter1.FillPackage(DataSet11.WIPMP, Data.Package)
    '        If DataSet11.WIPMP.Count > PLAN05 Then
    '            WIP05.Add(Data.Package)
    '            WIP055.Add(DataSet11.WIPMP.Count)
    '            count += 1

    '            'For Each ctr As Control In GroupBox1.Controls
    '            '    '   ctr.BackColor = Color.Red
    '            '    If TypeOf ctr Is Label Then
    '            '        If ctr.TabIndex = count And 40 >= count Then
    '            '            ctr.Text = Data.Package & "(" & (DataSet11.WIPMP.Count).ToString & ")"
    '            '        End If

    '            '    End If
    '            'Next

    '        End If
    '        'count += 1
    '    Next
    'End Sub

    'Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
    '    Dim COUNT1 As Integer
    '    For Each COUNT As String In COUNTWBMPSETTING
    '        For Each ctr As Control In GroupBox1.Controls
    '            '   ctr.BackColor = Color.Red
    '            If TypeOf ctr Is Label Then
    '                If ctr.TabIndex = COUNT And 40 >= COUNT1 Then
    '                    COUNT1 += 1
    '                    ctr.Text = WIP05.Item(COUNT1) & "(" & (WIP055.Item(COUNT1)).ToString & ")"
    '                End If

    '            End If
    '        Next
    '    Next
    'End Sub

    'Private Sub CountBox1_Click(sender As System.Object, e As System.EventArgs) Handles CountBox1.Click
    '    'Dim num() As Integer = New Integer() {"5", "3", "4"}
    '    'Array.Sort(num)
    '    'For i = 0 To num.Length - 1
    '    '    MsgBox(num(i))
    '    'Next

    'End Sub
End Class
