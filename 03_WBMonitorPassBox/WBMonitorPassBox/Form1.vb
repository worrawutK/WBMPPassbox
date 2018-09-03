Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports System.ComponentModel
Public Class Form1
    Public CountBox As New Collection
    Public Progress As New Collection
    Public MachineTxet As New Collection
    Public Usercon As New Collection
    Public WIPProgress As New Collection
    Public ControlWIP As New Collection
    Dim sum As Integer
    Dim test As Integer
    Dim Machine() As String = {"MP-PB-01", "MP-PB-02", "MP-PB-03", "MP-PB-04", "MP-PB-05", "MP-PB-06", "MP-PB-07"}
    Dim Count As Integer
    Dim Total As Integer


    Private changeCount As Integer = 0
    Private Const tableName As String = "WBMPPassbox"
    Private Const statusMessage As String = _
      "{0} changes have occurred."
    Private connection As SqlConnection = Nothing
    Private command As SqlCommand = Nothing
    Private dataToWatch As DataSet = Nothing

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Tick1()
    End Sub
    Private Sub Tick1()
        bttotal.Focus()
        ControlWIP(1).WIPMP(PLAN.Overflow)
        ControlWIP(2).WIPMP(PLAN.Lack)
        Total = 0
        For i = 0 To 6
            Count = 0
            WbmpPassboxTableAdapter1.Fill(DataSet11.WBMPPassbox, Machine(i))
            For Each Data As DataSet1.WBMPPassboxRow In DataSet11.WBMPPassbox
                Count += 1
            Next
            MachineTxet(i + 1).Text = "PB" & (i + 1)
            CountBox(i + 1).Text = Count
            '  Progress(i + 1).Value = Count
            ' For j = 1 To Count
            Usercon(i + 1).ProgressBar(Count)

            ' Next
            Total += Count
        Next
        sum = (63 - Total)

        sum -= test
        If sum <= 0 Then
            sum = 0
        End If
        bttotal.Text = sum
        ' bttotal.Text = "ว่าง " & vbCrLf & (63 - Total) & " / 63 "
    End Sub
 

    'Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    '    SqlDependency.Stop(GetConnectionString())
    '    If connection IsNot Nothing Then
    '        connection.Close()
    '    End If
    'End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = CanRequestNotifications()

        '  Me.WindowState = FormWindowState.Maximized
        '  Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '  Me.WindowState = FormWindowState.Maximized
        Usercon.Add(UserControlPassBox1)
        Usercon.Add(UserControlPassBox2)
        Usercon.Add(UserControlPassBox3)
        Usercon.Add(UserControlPassBox4)
        Usercon.Add(UserControlPassBox5)
        Usercon.Add(UserControlPassBox6)
        Usercon.Add(UserControlPassBox7)

        CountBox.Add(UserControlPassBox1.CountBox1)
        CountBox.Add(UserControlPassBox2.CountBox1)
        CountBox.Add(UserControlPassBox3.CountBox1)
        CountBox.Add(UserControlPassBox4.CountBox1)
        CountBox.Add(UserControlPassBox5.CountBox1)
        CountBox.Add(UserControlPassBox6.CountBox1)
        CountBox.Add(UserControlPassBox7.CountBox1)

        MachineTxet.Add(UserControlPassBox1.btMP01)
        MachineTxet.Add(UserControlPassBox2.btMP01)
        MachineTxet.Add(UserControlPassBox3.btMP01)
        MachineTxet.Add(UserControlPassBox4.btMP01)
        MachineTxet.Add(UserControlPassBox5.btMP01)
        MachineTxet.Add(UserControlPassBox6.btMP01)
        MachineTxet.Add(UserControlPassBox7.btMP01)
        '   Loadsql()

        ControlWIP.Add(UserControlWIP1)
        ControlWIP.Add(UserControlWIP2)
        ' Panel1.BackColor = Color.White
        '  ControlWIP.Add(UserControlWIP3)
        '  ControlWIP.Add(UserControlWIP4)
        Tick1()
    End Sub
    Private Function CanRequestNotifications() As Boolean
        ' In order to use the callback feature of the
        ' SqlDependency, the application must have
        ' the SqlClientPermission permission.
        Try

            Dim perm As New SqlClientPermission(PermissionState.Unrestricted)
            perm.Demand()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    'Private Function GetConnectionString() As String
    '    ' To avoid storing the connection string in your code,
    '    ' you can retrive it from a configuration file.
    '    'Return "Data Source=CLIENT-205\SQLEXPRESS;Initial Catalog=DBTest;Integrated Security=False;User ID=sa;Password=1234"
    '    Return "Data Source=172.16.0.102;Initial Catalog=DBxDW;Persist Security Info=True;User ID=sa;Password=5dcda45fc424*"
    'End Function

    'Private Function GetSQL() As String
    '    '****** WARNING *****
    '    'http://www.codeproject.com/Articles/12335/Using-SqlDependency-for-data-change-events
    '    'If the query is not correct, an event will immediately be sent with:
    '    'EX: if statement is not include "dbo" the error will be notified
    '    'Return "SELECT ID,Name,Class,HP,SP,LVL,EXP,EXP_MAX FROM Charactor"
    '    Return "SELECT [MCNo],[LotNo],[LotStartTime],[OPNoIn],[OPNoOut],[LotEndTime],[ChannelNumber],[NetVersion],[SelfConVersion],[Remark] FROM [dbo].[WBMPPassbox] where LotEndTime is null and MCNo='MP-PB-02'"
    '    ' Return "SELECT RohmDate,ProcessName,OPRate,LoadTime FROM dbo.DailyProcessOperationRate"
    'End Function
    'Private Sub dependency_OnChange(ByVal sender As Object, ByVal e As SqlNotificationEventArgs)

    '    ' This event will occur on a thread pool thread.
    '    ' It is illegal to update the UI from a worker thread
    '    ' The following code checks to see if it is safe
    '    ' update the UI.
    '    Dim i As ISynchronizeInvoke = CType(Me, ISynchronizeInvoke)

    '    ' If InvokeRequired returns True, the code
    '    ' is executing on a worker thread.
    '    If i.InvokeRequired Then
    '        ' Create a delegate to perform the thread switch
    '        Dim tempDelegate As New OnChangeEventHandler(AddressOf dependency_OnChange)

    '        Dim args() As Object = {sender, e}

    '        ' Marshal the data from the worker thread
    '        ' to the UI thread.
    '        i.BeginInvoke(tempDelegate, args)

    '        Return
    '    End If

    '    ' Remove the handler since it's only good
    '    ' for a single notification
    '    Dim dependency As SqlDependency = CType(sender, SqlDependency)

    '    RemoveHandler dependency.OnChange, AddressOf dependency_OnChange

    '    ' At this point, the code is executing on the
    '    ' UI thread, so it is safe to update the UI.
    '    changeCount += 1
    '    Me.Label1.Text = String.Format(statusMessage, changeCount)

    '    ' Add information from the event arguments to the list box
    '    ' for debugging purposes only.
    '    'With Me.ListBox1.Items
    '    '    .Clear()
    '    '    .Add("Info:   " & e.Info.ToString())
    '    '    .Add("Source: " & e.Source.ToString())
    '    '    .Add("Type:   " & e.Type.ToString())
    '    'End With


    '    If e.Type <> SqlNotificationType.Change Then
    '        Exit Sub
    '    End If

    '    ' Reload the dataset that's bound to the grid.
    '    GetData()
    'End Sub
    'Private Sub GetData()
    '    Tick1()
    '    ' Empty the dataset so that there is only
    '    ' one batch worth of data displayed.
    '    dataToWatch.Clear()
    '    '  dataToWatch1.Clear()
    '    ' Make sure the command object does not already have
    '    ' a notification object associated with it.
    '    command.Notification = Nothing
    '    'command1.Notification = Nothing
    '    ' Create and bind the SqlDependency object
    '    ' to the command object.
    '    Dim dependency As New SqlDependency(command)
    '    AddHandler dependency.OnChange, AddressOf dependency_OnChange

    '    'Dim dependency1 As New SqlDependency(command1)
    '    'AddHandler dependency1.OnChange, AddressOf dependency1_OnChange


    '    Using adapter As New SqlDataAdapter(command)
    '        adapter.Fill(dataToWatch, tableName)
    '        'Me.DataGridView1.DataSource = dataToWatch
    '        'Me.DataGridView1.DataMember = tableName
    '    End Using


    '    'Using adapter1 As New SqlDataAdapter(command1)
    '    '    adapter1.Fill(dataToWatch1, tableName1)

    '    '    Me.DataGridView2.DataSource = dataToWatch1
    '    '    Me.DataGridView2.DataMember = tableName1
    '    'End Using


    'End Sub
    'Private Sub Loadsql()
    '    changeCount = 0
    '    Me.Label1.Text = String.Format(statusMessage, changeCount)

    '    ' Remove any existing dependency connection, then create a new one.
    '    SqlDependency.Stop(GetConnectionString())
    '    SqlDependency.Start(GetConnectionString())

    '    If connection Is Nothing Then
    '        connection = New SqlConnection(GetConnectionString())
    '    End If

    '    If command Is Nothing Then
    '        ' GetSQL is a local procedure that returns
    '        ' a paramaterized SQL string. You might want
    '        ' to use a stored procedure in your application.
    '        command = New SqlCommand(GetSQL(), connection)
    '    End If
    '    'If command1 Is Nothing Then
    '    '    ' GetSQL is a local procedure that returns
    '    '    ' a paramaterized SQL string. You might want
    '    '    ' to use a stored procedure in your application.
    '    '    command1 = New SqlCommand(GetSQLTest(), connection)
    '    'End If

    '    If dataToWatch Is Nothing Then
    '        dataToWatch = New DataSet()
    '    End If

    '    'If dataToWatch1 Is Nothing Then
    '    '    dataToWatch1 = New DataSet()
    '    'End If

    '    GetData()
    '    '   GetData1()
    'End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        '    Dim pack As String() = {"HRP5", "HRP7", "HSON8", "HSON8-HF"}
        ' For i = 1 To 4

        'ControlWIP(1).WIPMP(PLAN.Overflow)
        'ControlWIP(2).WIPMP(PLAN.Lack)
        '    Next

        ' WIPMP("HRP5")
        'Dim frm As New LogOut
        'If frm.ShowDialog() = DialogResult.OK Then

        'End If
    End Sub

    Private Sub OvalShape3_Click(sender As System.Object, e As System.EventArgs) Handles LEDRED.Click

    End Sub
    Dim tick As Integer
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick

        If tick = 0 Then
            If sum = My.Settings.RED Then
                LEDRED.BackColor = Color.Red
                bttotal.ForeColor = Color.Red
                ' RectangleShape1.BorderColor = Color.Red
            ElseIf sum > My.Settings.RED And sum < My.Settings.YELLOW Then
                LEDGold.BackColor = Color.Yellow
                bttotal.ForeColor = Color.Yellow
                '   RectangleShape1.BorderColor = Color.Yellow
            ElseIf sum >= My.Settings.YELLOW And sum <= My.Settings.GREEN Then
                LEDLime.BackColor = Color.Lime
                bttotal.ForeColor = Color.Lime
                '   RectangleShape1.BorderColor = Color.Lime
            End If
            tick = 1
        Else
            LEDRED.BackColor = Color.White
            LEDGold.BackColor = Color.White
            LEDLime.BackColor = Color.White
            tick = 0
        End If


    End Sub

    Private Sub bttotal_Click(sender As System.Object, e As System.EventArgs) Handles bttotal.Click
        'test += 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Loadsql()
        Tick1()
    End Sub


    Private Sub box1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles box1.Paint, box2.Paint, box3.Paint, box4.Paint, box5.Paint, box6.Paint, box7.Paint
        Dim val As String
        val = sender.name
        If val = "box1" Or val = "box2" Then
            Dim fontObj As Font
            fontObj = New System.Drawing.Font("Calibri", 12, FontStyle.Bold)
            e.Graphics.TranslateTransform(sender.width - 15, 1)
            e.Graphics.RotateTransform(90)
            e.Graphics.DrawString("POWER GROUP", fontObj, Brushes.White, 0, 0)
        End If
        If val = "box3" Or val = "box4" Then
            Dim fontObj As Font
            fontObj = New System.Drawing.Font("Calibri", 12, FontStyle.Bold)
            e.Graphics.TranslateTransform(sender.width - 15, 1)
            e.Graphics.RotateTransform(90)
            e.Graphics.DrawString("SMALL GROUP", fontObj, Brushes.White, 0, 0)
        End If
        If val = "box5" Then
            Dim fontObj As Font
            fontObj = New System.Drawing.Font("Calibri", 12, FontStyle.Bold)
            e.Graphics.TranslateTransform(sender.width - 15, 1)
            e.Graphics.RotateTransform(90)
            e.Graphics.DrawString("QFP GROUP", fontObj, Brushes.White, 0, 0)
        End If
        If val = "box6" Then
            Dim fontObj As Font
            fontObj = New System.Drawing.Font("Calibri", 12, FontStyle.Bold)
            e.Graphics.TranslateTransform(sender.width - 15, 1)
            e.Graphics.RotateTransform(90)
            e.Graphics.DrawString("SSOP GROUP", fontObj, Brushes.White, 0, 0)
        End If
        If val = "box7" Then
            Dim fontObj As Font
            fontObj = New System.Drawing.Font("Calibri", 12, FontStyle.Bold)
            e.Graphics.TranslateTransform(sender.width - 15, 1)
            e.Graphics.RotateTransform(90)
            e.Graphics.DrawString("MAP GROUP", fontObj, Brushes.White, 0, 0)
        End If

    End Sub
End Class
