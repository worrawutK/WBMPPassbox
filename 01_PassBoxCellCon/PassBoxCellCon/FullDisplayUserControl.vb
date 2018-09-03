Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.ComponentModel
Public Class FullDisplayUserControl
    Dim Version As String = "V1.02"
    Dim IPAddress As String
    Public lbPKGFull As New Collection
    Public lbLotNoFull As New Collection
    Public lbShipmentDateFull As New Collection
    Public lbInputDateFull As New Collection
    Public UserControl_Collection As New Collection
    Dim CheckData As Integer = 0
    Dim SumData As Integer = 0



    ' SQL service broker
    Private Const statusMessage As String =
     "{0} changes have occurred."
    Private changeCount As Integer = 0
    Private connection As SqlConnection = Nothing
    Private command1 As SqlCommand = Nothing
    Private dataToWatch1 As DataSet = Nothing
    Private Const tableName1 As String = "DailyProcessOperationRate"
    Private changeCount1 As Integer = 0


    ' Dim WithEvents m_UserControl As UserControlPassBox
    Private Sub FullDisplayUserControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MCNo = MonitorPassBoxMP.ReadTextBoxNum()
        'msg_error("error")
        'msg_Ok("Ok")
        'msg_Ok1("Ok1")

        StratService()

        Me.WindowState = FormWindowState.Maximized
        If OPID <> "" Then
            lbID.Text = OPID
            btIN.Visible = False
            btOut.Visible = True
        Else
            btIN.Visible = True
            btOut.Visible = False
        End If
        '  lbVersion.Text = Version
        Address.Text = "IP:" & System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList(1).ToString() & " " & Version
        IPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList(1).ToString()
        ' Address.Text = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()

        UpdateIPaddress()

        'UserControlPassBox1.btText.Text = "1"
        'UserControlPassBox2.btText.Text = "2"
        'UserControlPassBox3.btText.Text = "3"
        'UserControlPassBox4.btText.Text = "4"
        'UserControlPassBox5.btText.Text = "5"
        'UserControlPassBox6.btText.Text = "6"
        'UserControlPassBox7.btText.Text = "7"
        'UserControlPassBox8.btText.Text = "8"
        'UserControlPassBox9.btText.Text = "9"

        lbPKGFull.Add(UserControlPassBox1.lbOutday)
        lbPKGFull.Add(UserControlPassBox2.lbOutday)
        lbPKGFull.Add(UserControlPassBox3.lbOutday)
        lbPKGFull.Add(UserControlPassBox4.lbOutday)
        lbPKGFull.Add(UserControlPassBox5.lbOutday)
        lbPKGFull.Add(UserControlPassBox6.lbOutday)
        lbPKGFull.Add(UserControlPassBox7.lbOutday)
        lbPKGFull.Add(UserControlPassBox8.lbOutday)
        lbPKGFull.Add(UserControlPassBox9.lbOutday)

        lbInputDateFull.Add(UserControlPassBox1.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox2.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox3.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox4.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox5.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox6.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox7.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox8.lbInputDate)
        lbInputDateFull.Add(UserControlPassBox9.lbInputDate)

        lbShipmentDateFull.Add(UserControlPassBox1.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox2.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox3.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox4.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox5.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox6.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox7.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox8.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlPassBox9.lbShipmentDate)

        lbLotNoFull.Add(UserControlPassBox1.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox2.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox3.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox4.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox5.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox6.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox7.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox8.lbLotNoData)
        lbLotNoFull.Add(UserControlPassBox9.lbLotNoData)

        UserControl_Collection.Add(UserControlPassBox1.btnInput)
        UserControl_Collection.Add(UserControlPassBox2.btnInput)
        UserControl_Collection.Add(UserControlPassBox3.btnInput)
        UserControl_Collection.Add(UserControlPassBox4.btnInput)
        UserControl_Collection.Add(UserControlPassBox5.btnInput)
        UserControl_Collection.Add(UserControlPassBox6.btnInput)
        UserControl_Collection.Add(UserControlPassBox7.btnInput)
        UserControl_Collection.Add(UserControlPassBox8.btnInput)
        UserControl_Collection.Add(UserControlPassBox9.btnInput)

        '   MonitorPassBoxMP.Hide()
        '  Tick1()
        '  StratService()

    End Sub
    Private Sub UpdateIPaddress()
        'update ip address
        MonitorPassBoxMP.WbMachineSettingTableAdapter1.Fill(MonitorPassBoxMP.DBxDataSet1.WBMachineSetting, MCNo)
        For Each Data As DBxDataSet.WBMachineSettingRow In MonitorPassBoxMP.DBxDataSet1.WBMachineSetting
            Data.SelfConIP = IPAddress
        Next
        MonitorPassBoxMP.WbMachineSettingTableAdapter1.Update(MonitorPassBoxMP.DBxDataSet1.WBMachineSetting)

    End Sub
    Public Sub Tick1()
        Dim dateSt As DateTime = Date.Now
        Debug.Print((Date.Now - dateSt).ToString & "_1")
        Try

            lbNameBox.Text = MCNo
            If CheckData <> SumData Then
                CheckData = SumData
                For i = 1 To 9
                    lbPKGFull(i).Text = "-"
                    lbLotNoFull(i).Text = "-"
                    UserControl_Collection(i).BackColor = SystemColors.Control
                    lbShipmentDateFull(i).Text = "-"
                    lbInputDateFull(i).Text = "-"
                Next
            End If
            'For i = 1 To 9
            '    lbPKGFull(i).Text = ""
            '    lbLotNoFull(i).Text = ""
            '    UserControl(i).BackColor = SystemColors.Control
            '    lbShipmentDateFull(i).Text = ""
            'Next
            SumData = 0
            MonitorPassBoxMP.WbmpPassboxShowTableAdapter1.Fill(MonitorPassBoxMP.DBxDataSet1.WBMPPassboxShow, MCNo)
            For Each Data As DBxDataSet.WBMPPassboxShowRow In MonitorPassBoxMP.DBxDataSet1.WBMPPassboxShow
                'For i = 1 To 9 Step 1
                '    If Data.Channel_Number = "Channel" & i Then

                '        lbPKGFull(i).Text = Data.Package_Name
                '        lbLotNoFull(i).Text = Data.Lot_No
                '        UserControl(i).BackColor = Color.LawnGreen
                '    End If
                'Next
                Dim numChannel As Integer = 0
                Select Case Data.ChannelNumber
                    Case "Channel1"
                        numChannel = 1
                    Case "Channel2"
                        numChannel = 2
                    Case "Channel3"
                        numChannel = 3
                    Case "Channel4"
                        numChannel = 4
                    Case "Channel5"
                        numChannel = 5
                    Case "Channel6"
                        numChannel = 6
                    Case "Channel7"
                        numChannel = 7
                    Case "Channel8"
                        numChannel = 8
                    Case "Channel9"
                        numChannel = 9
                End Select
                SumData = SumData + 1
                If Data.IsPackageNull Then
                    lbPKGFull(numChannel).Text = "-"
                Else
                    lbPKGFull(numChannel).Text = Data.Package
                End If

                lbLotNoFull(numChannel).Text = Data.LotNo
                '   UserControl_Collection(numChannel).BackColor = Color.LawnGreen

                MonitorPassBoxMP.LoT2_TABLETableAdapter1.Fill(MonitorPassBoxMP.DBxDataSet1.LOT2_TABLE, Data.LotNo)
                For Each DataDay As DBxDataSet.LOT2_TABLERow In MonitorPassBoxMP.DBxDataSet1.LOT2_TABLE

                    lbShipmentDateFull(numChannel).Text = "SHIPMENT DATE :" & DataDay.OUT_DAY
                    lbInputDateFull(numChannel).Text = "INPUT DATE :" & DataDay.IN_DAY
                Next
            Next



        Catch ex As Exception

        End Try
        Debug.Print((Date.Now - dateSt).ToString & "_2")
    End Sub
    Dim StartTime As Boolean = False
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'Dim dateSt As DateTime = Date.Now

        If StartTime = False Then

            Tick1()

            StartTime = True
            QueryTime()

        End If

        WBEndTime()

        'ตั้งเวลาปิดเครื่อง
        'Dim Restart As TimeSpan = New TimeSpan(20, 0, 0)
        'Dim TimeNow As TimeSpan = New TimeSpan(Date.Now.TimeOfDay.Hours, Date.Now.TimeOfDay.Minutes, Date.Now.TimeOfDay.Seconds)
        'If TimeNow.Hours >= 20 And TimeNow.Minutes >= 0 And TimeNow.Seconds >= 30 Then
        '    Restart = New TimeSpan(44, 0, 0)
        'End If
        'Dim TimeRestart As TimeSpan = Restart - TimeNow

        'Label1.Text = "Restart Time " & TimeRestart.ToString

        'If TimeRestart.TotalMinutes <= 30 Then
        '    Label1.ForeColor = Color.Red
        'Else
        '    Label1.ForeColor = Color.Green
        'End If
        'If Restart = TimeNow Then
        '    ' MsgBox("Restart")
        '    Process.Start(My.Application.Info.DirectoryPath & "\restart")
        '    MonitorPassBoxMP.Close()
        'End If
        ' Tick1()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        Dim mbr As MsgBoxResult
        mbr = MsgBox("ท่านต้องการจะปิดโปรแกรมหรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Logout")
        If (mbr = MsgBoxResult.Ok) Then
            UpdateIPaddress()
            Me.Close()
            MonitorPassBoxMP.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If lbID.Text = "" Then
            MsgBox("กรุณา Login")
            Exit Sub
        End If
        '  Me.Hide()
        ' MonitorPassBoxMP.WBMPPassboxTableAdapter.FillGridView(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox, MCNo)
        Dim frm As MonitorPassBoxMP = New MonitorPassBoxMP
        If frm.ShowDialog = DialogResult.OK Then

        Else
            Me.Close()
        End If
        '   MonitorPassBoxMP.Show()


    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        MonitorPassBoxMP.Hide()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Login_Click(sender As System.Object, e As System.EventArgs) Handles btIN.Click
        MonitorPassBoxMP.Hide()
        Dim frmlogin As New FormLoin
        If frmlogin.ShowDialog() = DialogResult.OK Then
            If OPID <> "" Then
                lbID.Text = OPID
                btIN.Visible = False
                btOut.Visible = True
            End If
        End If
    End Sub

    Private Sub btOut_Click(sender As System.Object, e As System.EventArgs) Handles btOut.Click

        OPID = ""
        lbID.Text = OPID
        btIN.Visible = True
        btOut.Visible = False
    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        'Dim DateNow As Date = Date.Now
        Dim Restart As TimeSpan = New TimeSpan(20, 0, 0)
        Dim TimeNow As TimeSpan = New TimeSpan(Date.Now.TimeOfDay.Hours, Date.Now.TimeOfDay.Minutes, Date.Now.TimeOfDay.Seconds)
        Dim TimeRestart As TimeSpan = Restart - TimeNow
        Label1.Text = "Restart Time :" & TimeRestart.ToString()
        If TimeRestart.TotalMinutes <= 30 Then
            Label1.ForeColor = Color.Red
        Else
            Label1.ForeColor = Color.Green
        End If
        If Restart = TimeNow Then
            ' MsgBox("Restart")
            Process.Start(My.Application.Info.DirectoryPath & "\restart")
            MonitorPassBoxMP.Close()
        End If
        'Date.Now.TimeOfDay.Hours.ToString("00") & ":" & Date.Now.TimeOfDay.Minutes.ToString("00") & ":" & Date.Now.TimeOfDay.Seconds.ToString("00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' '    Tick1()
        'StratService()
        'QueryTime()
        ' '  Timer1.Enabled = True

    End Sub
    Dim tempArray As List(Of List(Of String))()

    Private Sub QueryTime()
        Dim dateSt As DateTime = Date.Now
        Debug.Print((Date.Now - dateSt).ToString & "_11")
        tempArray = New List(Of List(Of String))(0) {}
        Dim LotNo As List(Of String) = New List(Of String)

        For Each user As Control In Panel1.Controls
            If TypeOf user Is UserControl = True Then
                Dim UserControl As UserControlPassBox = user
                LotNo.Add(UserControl.lbLotNoData.Text)
            End If

        Next


        Dim listPKG As List(Of String) = New List(Of String)
        Dim dataset As DataSet = New DBxDataSet
        Dim _PriorityPKG As DBxDataSet.PassBoxPriorityDataTable = New DBxDataSet.PassBoxPriorityDataTable
        Dim TableAdapter_PriorityPKG As New DBxDataSetTableAdapters.PassBoxPriorityTableAdapter
        TableAdapter_PriorityPKG.Fill(_PriorityPKG, LotNo(0), LotNo(1), LotNo(2), LotNo(3), LotNo(4), LotNo(5), LotNo(6), LotNo(7), LotNo(8))
        For Each row As DBxDataSet.PassBoxPriorityRow In _PriorityPKG

            If row.IsPackageNull = False AndAlso listPKG.Contains(row.Package) = False Then
                listPKG.Add(row.Package)
            End If
        Next

        tempArray(0) = New List(Of List(Of String))()
        For I = 0 To listPKG.Count - 1
            tempArray(0).Add(New List(Of String)())
        Next

        For Each row As DBxDataSet.PassBoxPriorityRow In _PriorityPKG
            For I = 0 To listPKG.Count - 1
                If row.IsPackageNull = False AndAlso listPKG(I) = row.Package Then
                    ' _Group1.Add(data.LotNo)

                    ' tempArray(0)(I).Add(row.LotNo & "," & row.EndTime)
                    Try
                        tempArray(0)(I).Add(row.LotNo & "," & row.EndTime)
                    Catch ex As Exception
                        tempArray(0)(I).Add(row.LotNo & "," & Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        MsgBox(row.LotNo & ":No EndTime WB")
                    End Try
                End If

            Next
        Next
        Debug.Print((Date.Now - dateSt).ToString & "_22")
    End Sub
    Private Sub WBEndTime()

        For Each user As Control In Panel1.Controls
            If TypeOf user Is UserControl = True Then
                Dim UserControl As UserControlPassBox = user
                For i = 0 To tempArray(0).Count - 1
                    For j = 0 To tempArray(0)(i).Count - 1
                        If tempArray(0)(i)(j).Split(",")(0) = UserControl.lbLotNoData.Text Then
                            Dim Time As TimeSpan = DateTime.Now - CDate(tempArray(0)(i)(j).Split(",")(1))
                            Dim color As Drawing.Color = Drawing.Color.Transparent
                            If Time.TotalHours < 6 Then
                                color = Drawing.Color.LawnGreen
                            ElseIf Time.TotalHours >= 6 And Time.TotalHours < 12 Then
                                color = Drawing.Color.Yellow
                            ElseIf Time.TotalHours >= 12 Then
                                color = Drawing.Color.Orange
                            End If
                            UserControl.PriorityNumber(j + 1, color, Math.Floor(Time.TotalHours).ToString("0#") & ":" & Time.Minutes.ToString("0#") & ":" & Time.Seconds.ToString("0#"))
                        Else
                            If UserControl.lbTime.Text = "" And UserControl.lbLotNoData.Text <> "-" Then
                                UserControl.PriorityNumber("", Drawing.Color.LawnGreen, "")
                            ElseIf UserControl.lbLotNoData.Text = "-" Then
                                UserControl.PriorityNumber("", Drawing.Color.Transparent, "")
                            End If

                        End If
                    Next
                Next

            End If
        Next

    End Sub


    Private Sub StratService()
        '   Me.Label2.Text = String.Format(statusMessage, changeCount)

        ' Remove any existing dependency connection, then create a new one.
        SqlDependency.Stop(GetConnectionString())
        SqlDependency.Start(GetConnectionString())

        If connection Is Nothing Then
            connection = New SqlConnection(GetConnectionString())
        End If

        If command1 Is Nothing Then
            ' GetSQL is a local procedure that returns
            ' a paramaterized SQL string. You might want
            ' to use a stored procedure in your application.
            command1 = New SqlCommand(GetSQLTest(), connection)
        End If


        If dataToWatch1 Is Nothing Then
            dataToWatch1 = New DataSet()
        End If


        GetData1(True)
    End Sub
    Private Function GetConnectionString() As String
        ' To avoid storing the connection string in your code,
        ' you can retrive it from a configuration file.
        'Return "Data Source=CLIENT-205\SQLEXPRESS;Initial Catalog=DBTest;Integrated Security=False;User ID=sa;Password=1234"
        '172.16.0.102;Initial Catalog=DBx;User ID=dbxuser
        ' Return "Data Source=172.16.0.102;Initial Catalog=DBx;User ID=sa;Password=5dcda45fc424*"
        Return "Data Source=172.16.0.102;Initial Catalog=DBx;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
        ' Return "Data Source=172.16.0.102;Initial Catalog=DBxDW;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
    End Function
    Private Function GetSQLTest() As String
        '****** WARNING *****
        'http://www.codeproject.com/Articles/12335/Using-SqlDependency-for-data-change-events

        ' Return "SELECT RohmDate,ProcessName,OPRate,LoadTime FROM dbo.DailyProcessOperationRate"
        '  Return "SELECT LotNo,PackageID,ProcessBefore ,MCNoProcessBefore FROM WIP.WBWIP" ' LotStartTime >=  DATEADD(HOUR, -1, getdate()) order by LotStartTime desc
        Dim frm As MonitorPassBoxMP = New MonitorPassBoxMP
        Dim MCno As String = frm.ReadTextBoxNum()
        Return "SELECT MCNo, LotNo, LotStartTime, OPNoIn, OPNoOut, LotEndTime, ChannelNumber, NetVersion, SelfConVersion, Remark FROM dbo.WBMPPassbox where  LotEndTime is null and MCNo='" & MCno & "'" 'MCNo='MP-PB-99' DATEADD(HOUR, -1, getdate())  order by LotStartTime desc
    End Function

    Private Sub GetData1(Start As Boolean)
        ' Empty the dataset so that there is only
        ' one batch worth of data displayed.
        dataToWatch1.Clear()

        ' Make sure the command object does not already have
        ' a notification object associated with it.
        command1.Notification = Nothing

        ' Create and bind the SqlDependency object
        ' to the command object.
        Dim dependency1 As New SqlDependency(command1)
        AddHandler dependency1.OnChange, AddressOf dependency1_OnChange

        Using adapter As New SqlDataAdapter(command1)
            adapter.Fill(dataToWatch1, tableName1)
            '    Me.DataGridView2.DataSource = dataToWatch1
            '    Me.DataGridView2.DataMember = tableName1
            If Start = False Then
                Tick1()
                QueryTime()
            End If
        End Using
        ' Query




    End Sub
    'Private Sub Query()

    'End Sub
    Private Sub dependency1_OnChange(ByVal sender As Object, ByVal e As SqlNotificationEventArgs)

        ' This event will occur on a thread pool thread.
        ' It is illegal to update the UI from a worker thread
        ' The following code checks to see if it is safe
        ' update the UI.
        Dim i As ISynchronizeInvoke = CType(Me, ISynchronizeInvoke)

        ' If InvokeRequired returns True, the code
        ' is executing on a worker thread.
        If i.InvokeRequired Then
            ' Create a delegate to perform the thread switch
            Dim tempDelegate As New OnChangeEventHandler(AddressOf dependency1_OnChange)

            Dim args() As Object = {sender, e}

            ' Marshal the data from the worker thread
            ' to the UI thread.
            i.BeginInvoke(tempDelegate, args)

            Return
        End If

        ' Remove the handler since it's only good
        ' for a single notification
        Dim dependency1 As SqlDependency = CType(sender, SqlDependency)

        RemoveHandler dependency1.OnChange, AddressOf dependency1_OnChange


        '  changeCount1 += 1
        '   Me.Label2.Text = String.Format(statusMessage, changeCount1)


        'With Me.ListBox2.Items
        '    .Clear()
        '    .Add("Info:   " & e.Info.ToString())
        '    .Add("Source: " & e.Source.ToString())
        '    .Add("Type:   " & e.Type.ToString())
        'End With
        If e.Type <> SqlNotificationType.Change Then
            Exit Sub
        End If

        ' Reload the dataset that's bound to the grid.
        GetData1(False)
    End Sub


End Class