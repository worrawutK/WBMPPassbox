Imports System.IO
Imports System.Net
Imports System.Environment
Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.ComponentModel
Public Class MonitorPassBoxMP


    Public lbPKG As New Collection
    Public lbLotNo As New Collection
    Public lbShipmentDate As New Collection
    Public UserControl As New Collection
    'Dim LoadPageActivated = "1"
    Dim CheckData As Integer = 0
    Dim SumData As Integer = 0
    Private Sub MonitorPassBoxMP_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        'If LoadPageActivated = "1" Then

        '    Me.Hide()
        '    LoadPageActivated = "0"

        'End If

    End Sub

    Private Sub FullDisplayUserControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WBMPPassboxTableAdapter.FillGridView(DBxDataSet1.WBMPPassbox, MCNo)
        StratService()
        Me.WindowState = FormWindowState.Maximized

        lbBoxName.Text = ReadTextBoxNum()
        MCNo = ReadTextBoxNum()

        Address.Text = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList(1).ToString()
        'Address.Text = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList(0).ToString()
        UpdateIPaddress()

        UserControlMonitorPassBoxMP1.btText.Text = "1"
        UserControlMonitorPassBoxMP2.btText.Text = "2"
        UserControlMonitorPassBoxMP3.btText.Text = "3"
        UserControlMonitorPassBoxMP4.btText.Text = "4"
        UserControlMonitorPassBoxMP5.btText.Text = "5"
        UserControlMonitorPassBoxMP6.btText.Text = "6"
        UserControlMonitorPassBoxMP7.btText.Text = "7"
        UserControlMonitorPassBoxMP8.btText.Text = "8"
        UserControlMonitorPassBoxMP9.btText.Text = "9"


        lbPKG.Add(UserControlMonitorPassBoxMP1.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP2.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP3.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP4.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP5.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP6.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP7.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP8.lbPKG)
        lbPKG.Add(UserControlMonitorPassBoxMP9.lbPKG)

        lbShipmentDate.Add(UserControlMonitorPassBoxMP1.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP2.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP3.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP4.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP5.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP6.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP7.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP8.lbShipmentDate)
        lbShipmentDate.Add(UserControlMonitorPassBoxMP9.lbShipmentDate)


        lbLotNo.Add(UserControlMonitorPassBoxMP1.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP2.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP3.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP4.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP5.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP6.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP7.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP8.lbLotNoData)
        lbLotNo.Add(UserControlMonitorPassBoxMP9.lbLotNoData)

        UserControl.Add(UserControlMonitorPassBoxMP1.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP2.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP3.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP4.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP5.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP6.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP7.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP8.btnInput)
        UserControl.Add(UserControlMonitorPassBoxMP9.btnInput)

        'If LoadPage = "1" Then
        '    Dim frmfull As New FullDisplayUserControl
        '    frmfull.Show()
        '    LoadPage = "0"
        '    'Me.Hide()
        'End If
        Tick()
        Timer1.Start()
    End Sub
    Dim StartTime As Boolean = False
    Dim Hidefrm As Boolean = False
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ' Tick()
        If StartTime = False Then
            Tick()
            StartTime = True
            QueryTime()
            'If Hidefrm = False Then
            '    Hidefrm = True
            '    Me.Hide()
            'End If

        End If
        Try
            WBEndTime()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Timer1.Stop()
        End Try

    End Sub

    Private Sub Tick()
        Try

            If CheckData <> SumData Then
                CheckData = SumData
                For i = 1 To 9
                    lbPKG(i).Text = "-"
                    lbLotNo(i).Text = "-"
                    UserControl(i).BackColor = SystemColors.Control
                    lbShipmentDate(i).Text = "-"
                Next
            End If
            SumData = 0
            Me.WbmpPassboxShowTableAdapter1.Fill(DBxDataSet1.WBMPPassboxShow, MCNo)
            For Each Data As DBxDataSet.WBMPPassboxShowRow In DBxDataSet1.WBMPPassboxShow

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
                    lbPKG(numChannel).Text = "-"
                Else
                    lbPKG(numChannel).Text = Data.Package
                End If

                lbLotNo(numChannel).Text = Data.LotNo
                UserControl(numChannel).BackColor = Color.LawnGreen


                Me.LoT2_TABLETableAdapter1.Fill(DBxDataSet1.LOT2_TABLE, Data.LotNo)
                For Each DataDay As DBxDataSet.LOT2_TABLERow In DBxDataSet1.LOT2_TABLE
                    lbShipmentDate(numChannel).Text = "SHIPMENT DATE :" & DataDay.OUT_DAY

                Next


            Next

        Catch ex As Exception

        End Try
    End Sub


    Private Sub UpdateIPaddress()
        'update ip address
        WbMachineSettingTableAdapter1.Fill(DBxDataSet1.WBMachineSetting, MCNo)
        For Each Data As DBxDataSet.WBMachineSettingRow In DBxDataSet1.WBMachineSetting
            Data.SelfConIP = Address.Text
        Next
        WbMachineSettingTableAdapter1.Update(DBxDataSet1.WBMachineSetting)

    End Sub

    Public Function ReadTextBoxNum() As String
        Using PathBoxNum As New StreamReader(My.Application.Info.DirectoryPath & "\BoxNumber.txt")

            Return PathBoxNum.ReadLine()
        End Using
    End Function
    Private Sub AndonToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AndonToolStripMenuItem.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/andontmn", AppWinStyle.NormalFocus) 'Web andon for manual M/C
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub WorkRecordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WorkRecordToolStripMenuItem.Click
        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/ERECORD/", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub APCSStaffToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles APCSStaffToolStripMenuItem.Click
        Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv.thematrix.net/ApcsStaff", AppWinStyle.NormalFocus)
    End Sub
    Private Sub SendToBackToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SendToBackToolStripMenuItem.Click
        Me.SendToBack()
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        Dim mbr As MsgBoxResult
        mbr = MsgBox("ท่านต้องการจะปิดโปรแกรมหรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Logout")
        If (mbr = MsgBoxResult.Ok) Then
            UpdateIPaddress()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Timer1.Stop()
        'Dim frm2 As New FullDisplayUserControl
        'Me.Hide()
        'frm2.Show()
        Me.DialogResult = DialogResult.OK
    End Sub
    Sub SaveTextBoxNum(ByVal BoxNum As String)
        Using PathText As New StreamWriter(My.Application.Info.DirectoryPath & "\BoxNumber.txt", False)
            PathText.Write(BoxNum)
        End Using
    End Sub
    Private Sub ToolBOX1_Click(sender As System.Object, e As System.EventArgs) Handles ToolBOX1.Click, ToolBOX7.Click, ToolBOX6.Click, ToolBOX5.Click, ToolBOX4.Click, ToolBOX3.Click, ToolBOX2.Click
        '  Dim Btn As Button = CType(sender, Button)
        For i = 1 To 9 Step 1
            lbPKG(i).Text = "-"
            lbLotNo(i).Text = "-"
            lbShipmentDate(i).Text = "-"
            UserControl(i).BackColor = Color.Transparent
      
        Next
        lbBoxName.Text = sender.text
        MCNo = sender.text
        SaveTextBoxNum(sender.text)
        Me.Close()
        'StratService()
        'StartTime = False
        'WBMPPassboxTableAdapter.FillGridView(DBxDataSet1.WBMPPassbox, MCNo)
    End Sub

    Private Sub MonitorPassBoxMP_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim myPen As Pen
        myPen = New Pen(Color.RoyalBlue, 17)
        e.Graphics.DrawLine(myPen, 0, 10, Me.Width, 10)
        myPen = New Pen(Color.MidnightBlue, 1)
        e.Graphics.DrawLine(myPen, 0, 19, Me.Width, 19)
        myPen = New Pen(Color.PowderBlue, 25)
        e.Graphics.DrawLine(myPen, 0, 110, Me.Width, 110)
        myPen = New Pen(Color.CadetBlue, 1)
        e.Graphics.DrawLine(myPen, 1, 122, Me.Width, 122)
    End Sub


    Dim tempArray As List(Of List(Of String))()

    Private Sub QueryTime()

        tempArray = New List(Of List(Of String))(0) {}
        Dim LotNo As List(Of String) = New List(Of String)

        For Each user As Control In Panel1.Controls
            If TypeOf user Is UserControl = True Then
                Dim UserControl As UserControlMonitorPassBoxMP = user
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
                    Try
                        tempArray(0)(I).Add(row.LotNo & "," & row.EndTime)
                    Catch ex As Exception
                        tempArray(0)(I).Add(row.LotNo & "," & Format(Now, "yyyy-MM-dd HH:mm:ss"))
                        MsgBox(row.LotNo & ":No EndTime WB")
                    End Try





                End If

            Next
        Next
    End Sub
    Private Sub WBEndTime()

        For Each user As Control In Panel1.Controls
            If TypeOf user Is UserControl = True Then
                Dim UserControl As UserControlMonitorPassBoxMP = user
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
    ' SQL service broker
    Private Const statusMessage As String =
     "{0} changes have occurred."
    Private changeCount As Integer = 0
    Private connection As SqlConnection = Nothing
    Private command1 As SqlCommand = Nothing
    Private dataToWatch1 As DataSet = Nothing
    Private Const tableName1 As String = "DailyProcessOperationRate"
    Private changeCount1 As Integer = 0
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
        Return "SELECT MCNo, LotNo, LotStartTime, OPNoIn, OPNoOut, LotEndTime, ChannelNumber, NetVersion, SelfConVersion, Remark FROM dbo.WBMPPassbox where  LotEndTime is null and MCNo='" & MCno & "' " 'MCNo='MP-PB-99' DATEADD(HOUR, -1, getdate())  order by LotStartTime desc
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
                Tick()
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
