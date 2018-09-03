Imports System.Data.SqlClient
Imports System
Imports Bt
Imports Bt.SysLib


Public Class FormMaster
    ' Public lbLot As New Collection
    Dim buzzerCheck As Integer = 0

    Private Sub Bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btWORKINGSLIP.Click, btScanOPID.Click, btScanBox.Click, Button2.Click
        ' Buzzer(8)
        '   TimeMM = 0
        tbQR.Focus()

    End Sub


    Private Sub FormMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim strIPAddress As String = System.Net.Dns.GetHostByName(strHostName).AddressList(1).ToString() 'ต้องต่อ wifi
        lbIP.Text = "IP :" & strIPAddress
        tbQR.Focus()
        UserControl11.btNumber.Text = "1"
        UserControl12.btNumber.Text = "2"
        UserControl13.btNumber.Text = "3"
        UserControl14.btNumber.Text = "4"
        UserControl15.btNumber.Text = "5"
        UserControl16.btNumber.Text = "6"
        UserControl17.btNumber.Text = "7"
        UserControl18.btNumber.Text = "8"
        UserControl19.btNumber.Text = "9"
      
        QurySql()


    End Sub
    Private Sub tbQR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbQR.KeyPress
        If OPID <> "" And MachineName <> "" Then
            If tbQR.Text.Length = 0 Then
                '  tbQR.Text = ""
                Dim checkBT As String = ""
                'If e.KeyChar = Convert.ToChar(48) Then 'กด 0 
                '    e.Handled = True
                '    Exit Sub
                'End If

                Select Case e.KeyChar
                    Case Convert.ToChar(49) '1
                        checkBT = "Channel1"
                    Case Convert.ToChar(50) '2
                        checkBT = "Channel2"
                    Case Convert.ToChar(51) '3
                        checkBT = "Channel3"
                    Case Convert.ToChar(52) '4
                        checkBT = "Channel4"
                    Case Convert.ToChar(53) '5
                        checkBT = "Channel5"
                    Case Convert.ToChar(54) '6
                        checkBT = "Channel6"
                    Case Convert.ToChar(55) '7
                        checkBT = "Channel7"
                    Case Convert.ToChar(56) '8
                        checkBT = "Channel8"
                    Case Convert.ToChar(57) '9
                        checkBT = "Channel9"
                End Select

                If checkBT <> "" Then
                    Channel = checkBT
                    control = "Manual"
                    ClearText()
                    QurySql()
                    'delete
                    sql = "SELECT MCNo, LotNo, LotStartTime, OPNoIn, OPNoOut, LotEndTime, ChannelNumber, NetVersion, SelfConVersion, Remark FROM [DBx].[dbo].[WBMPPassbox] WHERE (MCNo = '" & MachineName & "') AND (LotEndTime IS NULL);"
                    Dim data As SqlDataReader = cmd_excuteScalar()

                    While data.Read
                        If data("ChannelNumber").ToString = checkBT Then
                            del = "Delete"

                        End If

                    End While
                    conn.Close()
                    'control = "Manual"

                    If del = "Delete" Then

                        del = ""
                        QurySql()
                        If MsgBox(MsgDelete, MsgBoxStyle.YesNoCancel, "Delete") = MsgBoxResult.Yes Then
                            DeleteChannel(checkBT)

                        End If
                        control = "Auto"
                    Else
                        '--------

                    End If
                    e.Handled = True
                End If

            End If

        End If

        If e.KeyChar = Convert.ToChar(13) Then
            Try
                If tbQR.Text.Length = 252 Then
                    If OPID = "" Then
                        ' MsgBox("Please Scan OPID")
                        MsgBox(MsgScanOPID)
                        tbQR.Text = ""
                        Exit Sub
                    End If
                    If MachineName = "" Then
                        'MsgBox("Please Scan Box")
                        MsgBox(MsgScanBox)
                        tbQR.Text = ""
                        Exit Sub
                    End If

                    If Channel = "" Then
                        ' MsgBox("Box Full")
                        Buzzer(1)
                        MsgBox(MsgBoxFull)

                        tbQR.Text = ""
                        Exit Sub
                    End If
                    QRCode = tbQR.Text
                    '---------------
                    sql = "SELECT WBMPPassbox.LotNo, TransactionData.Package, TransactionData.Device, WBMPPassbox.LotStartTime, WBMPPassbox.OPNoIn,WBMPPassbox.OPNoOut, WBMPPassbox.LotEndTime, WBMPPassbox.ChannelNumber, WBMPPassbox.Remark FROM TransactionData INNER JOIN WBMPPassbox ON TransactionData.LotNo = WBMPPassbox.LotNo WHERE (WBMPPassbox.MCNo = '" & MachineName & "')AND(WBMPPassbox.LotEndTime IS NULL);"
                    Dim data As SqlDataReader = cmd_excuteScalar()
                    '  Dim count As Integer = -1
                    While data.Read
                        'If Trim(QRCode.Substring(30, 10)).ToUpper=
                        Select Case data("LotNo").ToString
                            Case Trim(QRCode.Substring(30, 10)).ToUpper
                                '   MsgBox("LotNo. นี้ถูกใช้ไปแล้ว")
                                MsgBox(MsgLotNo)
                                tbQR.Text = ""
                                conn.Close()
                                Exit Sub
                        End Select

                    End While
                    conn.Close()
                    '----------------
                    sql = "insert into [DBx].[dbo].[WBMPPassbox] (MCNo, LotNo, LotStartTime, ChannelNumber,OPNoIn)values('" & MachineName & "','" & Trim(QRCode.Substring(30, 10)).ToUpper & "','" & Date.Now.ToString & "','" & Channel & "','" & OPID & "');"
                    cmd_ExecuteNonQuery()
                    TimeMM = SetTimeOut
                    TimeSS = 0
                ElseIf tbQR.Text.Length = 6 Then
                    If OPID <> tbQR.Text Then
                        OPID = tbQR.Text
                        lbOPID.Text = OPID
                        TimeMM = SetTimeOut
                        TimeSS = 0
                        lbLoseTime.Text = "45:00"
                        MsgBox("เปลี่ยนผู้ใช้เรียบร้อย")
                    Else
                        OPID = ""
                        MachineName = ""
                        lbOPID.Text = "-"
                        tbQR.Text = ""
                        lbMachine.Text = "-"
                        Channel = ""
                        ClearText()
                        TimerTimeOut.Enabled = False
                        TimeMM = SetTimeOut
                        TimeSS = 0
                        lbLoseTime.Text = "45:00"
                        MsgBox("ออกจากระบบเรียบร้อย")

                        'Dim mbr As MsgBoxResult
                        'mbr = MsgBox("ออกจากระบบหรือไม่", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Logout")
                        'If (mbr = MsgBoxResult.Yes) Then

                        'ElseIf (mbr = MsgBoxResult.No) Then

                        'End If


                        TimerOPID.Enabled = True
                    End If
                    OPID = tbQR.Text
                    Timer1.Enabled = True

                ElseIf tbQR.Text.Length = 8 Then
                    If OPID = "" Then
                        MsgBox(MsgScanOPID)
                        tbQR.Text = ""
                        Exit Sub
                    End If
                    ClearText()
                    MachineName = tbQR.Text
                Else
                    ' MsgBox(tbQR.Text)
                    MsgBox(MsgScanAgain)
                    ClearText()
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            'ClearText()
            tbQR.Text = ""
            control = "Auto"
            QurySql()
        End If
    End Sub
    Private Sub DeleteChannel(ByVal channeldel As String)

        sql = "DELETE FROM [DBx].[dbo].[WBMPPassbox] WHERE (MCNo = '" & MachineName & "') AND ChannelNumber='" & channeldel & "' AND (LotEndTime IS NULL);"
        cmd_ExecuteNonQuery()
        control = "Auto"
        ' MsgBox("delete" & Channel.ToString & delchannel.ToString)
        conn.Close()
        channeldel = ""
        ClearText()
        QurySql()
    End Sub
    Private Sub ClearText()
        'bt control
        'UserControl11.btQR01.Text = ""
        'UserControl12.btQR01.Text = ""
        'UserControl13.btQR01.Text = ""
        'UserControl14.btQR01.Text = ""
        'UserControl15.btQR01.Text = ""
        'UserControl16.btQR01.Text = ""
        'UserControl17.btQR01.Text = ""
        'UserControl18.btQR01.Text = ""
        'UserControl19.btQR01.Text = ""

        UserControl11.btQR01.BackColor = SystemColors.Control
        UserControl12.btQR01.BackColor = SystemColors.Control
        UserControl13.btQR01.BackColor = SystemColors.Control
        UserControl14.btQR01.BackColor = SystemColors.Control
        UserControl15.btQR01.BackColor = SystemColors.Control
        UserControl16.btQR01.BackColor = SystemColors.Control
        UserControl17.btQR01.BackColor = SystemColors.Control
        UserControl18.btQR01.BackColor = SystemColors.Control
        UserControl19.btQR01.BackColor = SystemColors.Control
        'bt number
        UserControl11.btNumber.BackColor = SystemColors.Control
        UserControl12.btNumber.BackColor = SystemColors.Control
        UserControl13.btNumber.BackColor = SystemColors.Control
        UserControl14.btNumber.BackColor = SystemColors.Control
        UserControl15.btNumber.BackColor = SystemColors.Control
        UserControl16.btNumber.BackColor = SystemColors.Control
        UserControl17.btNumber.BackColor = SystemColors.Control
        UserControl18.btNumber.BackColor = SystemColors.Control
        UserControl19.btNumber.BackColor = SystemColors.Control
        'LotNo
        UserControl11.btLotNo.Text = ""
        UserControl12.btLotNo.Text = ""
        UserControl13.btLotNo.Text = ""
        UserControl14.btLotNo.Text = ""
        UserControl15.btLotNo.Text = ""
        UserControl16.btLotNo.Text = ""
        UserControl17.btLotNo.Text = ""
        UserControl18.btLotNo.Text = ""
        UserControl19.btLotNo.Text = ""
        UserControl11.btLotNo.BackColor = SystemColors.Control
        UserControl12.btLotNo.BackColor = SystemColors.Control
        UserControl13.btLotNo.BackColor = SystemColors.Control
        UserControl14.btLotNo.BackColor = SystemColors.Control
        UserControl15.btLotNo.BackColor = SystemColors.Control
        UserControl16.btLotNo.BackColor = SystemColors.Control
        UserControl17.btLotNo.BackColor = SystemColors.Control
        UserControl18.btLotNo.BackColor = SystemColors.Control
        UserControl19.btLotNo.BackColor = SystemColors.Control
        'PKG
        UserControl11.btPKG.Text = ""
        UserControl12.btPKG.Text = ""
        UserControl13.btPKG.Text = ""
        UserControl14.btPKG.Text = ""
        UserControl15.btPKG.Text = ""
        UserControl16.btPKG.Text = ""
        UserControl17.btPKG.Text = ""
        UserControl18.btPKG.Text = ""
        UserControl19.btPKG.Text = ""
        UserControl11.btPKG.BackColor = SystemColors.Control
        UserControl12.btPKG.BackColor = SystemColors.Control
        UserControl13.btPKG.BackColor = SystemColors.Control
        UserControl14.btPKG.BackColor = SystemColors.Control
        UserControl15.btPKG.BackColor = SystemColors.Control
        UserControl16.btPKG.BackColor = SystemColors.Control
        UserControl17.btPKG.BackColor = SystemColors.Control
        UserControl18.btPKG.BackColor = SystemColors.Control
        UserControl19.btPKG.BackColor = SystemColors.Control
    End Sub
    Private Sub QurySql()
        Try


            Try
                If OPID <> "" Then
                    lbOPID.Text = OPID
                    lbOPID.ForeColor = Color.LawnGreen
                End If
                If MachineName <> "" Then
                    lbMachine.Text = Trim(MachineName.Substring(3, 5)).ToUpper
                    lbMachine.ForeColor = Color.LawnGreen
                End If

            Catch ex As Exception

            End Try

            tbQR.Focus()
            If OPID = "" Then
                btScanOPID.BackColor = Color.Gold
                btScanBox.BackColor = SystemColors.Control
                btWORKINGSLIP.BackColor = SystemColors.Control
            ElseIf MachineName = "" Then
                btScanOPID.BackColor = Color.LawnGreen
                btScanBox.BackColor = Color.Gold
                btWORKINGSLIP.BackColor = SystemColors.Control
            Else
                btScanOPID.BackColor = Color.LawnGreen
                btScanBox.BackColor = Color.LawnGreen
                btWORKINGSLIP.BackColor = Color.Gold
            End If

            If Checkcount <> count Then
                Checkcount = count
                ClearText()
            End If
            ' ClearText()
            count = 0
            sql = "SELECT WBMPPassbox.LotNo, TransactionData.Package, TransactionData.Device, WBMPPassbox.LotStartTime, WBMPPassbox.OPNoIn, WBMPPassbox.OPNoOut, WBMPPassbox.LotEndTime, WBMPPassbox.ChannelNumber, WBMPPassbox.Remark FROM TransactionData INNER JOIN WBMPPassbox ON TransactionData.LotNo = WBMPPassbox.LotNo WHERE (WBMPPassbox.MCNo ='" & MachineName & "')AND(WBMPPassbox.LotEndTime IS NULL);"
            Dim data As SqlDataReader = cmd_excuteScalar()

            While data.Read
                count = count + 1
                Select Case data("ChannelNumber").ToString
                    Case "Channel1"
                        'UserControl11.btQR01.Text = data("LotNo").ToString
                        UserControl11.btLotNo.Text = data("LotNo").ToString
                        UserControl11.btPKG.Text = data("Package").ToString
                        UserControl11.btLotNo.BackColor = Color.LawnGreen
                        UserControl11.btPKG.BackColor = Color.LawnGreen

                        UserControl11.btQR01.BackColor = Color.LawnGreen
                        UserControl11.btNumber.BackColor = Color.LawnGreen
                    Case "Channel2"
                        'UserControl12.btQR01.Text = data("LotNo").ToString
                        UserControl12.btLotNo.Text = data("LotNo").ToString
                        UserControl12.btPKG.Text = data("Package").ToString
                        UserControl12.btLotNo.BackColor = Color.LawnGreen
                        UserControl12.btPKG.BackColor = Color.LawnGreen

                        UserControl12.btQR01.BackColor = Color.LawnGreen
                        UserControl12.btNumber.BackColor = Color.LawnGreen
                    Case "Channel3"
                        'UserControl13.btQR01.Text = data("LotNo").ToString
                        UserControl13.btLotNo.Text = data("LotNo").ToString
                        UserControl13.btPKG.Text = data("Package").ToString
                        UserControl13.btLotNo.BackColor = Color.LawnGreen
                        UserControl13.btPKG.BackColor = Color.LawnGreen

                        UserControl13.btQR01.BackColor = Color.LawnGreen
                        UserControl13.btNumber.BackColor = Color.LawnGreen
                    Case "Channel4"
                        '  UserControl14.btQR01.Text = data("LotNo").ToString
                        UserControl14.btLotNo.Text = data("LotNo").ToString
                        UserControl14.btPKG.Text = data("Package").ToString
                        UserControl14.btLotNo.BackColor = Color.LawnGreen
                        UserControl14.btPKG.BackColor = Color.LawnGreen

                        UserControl14.btQR01.BackColor = Color.LawnGreen
                        UserControl14.btNumber.BackColor = Color.LawnGreen
                    Case "Channel5"
                        ' UserControl15.btQR01.Text = data("LotNo").ToString
                        UserControl15.btLotNo.Text = data("LotNo").ToString
                        UserControl15.btPKG.Text = data("Package").ToString
                        UserControl15.btLotNo.BackColor = Color.LawnGreen
                        UserControl15.btPKG.BackColor = Color.LawnGreen

                        UserControl15.btQR01.BackColor = Color.LawnGreen
                        UserControl15.btNumber.BackColor = Color.LawnGreen
                    Case "Channel6"
                        '  UserControl16.btQR01.Text = data("LotNo").ToString
                        UserControl16.btLotNo.Text = data("LotNo").ToString
                        UserControl16.btPKG.Text = data("Package").ToString
                        UserControl16.btLotNo.BackColor = Color.LawnGreen
                        UserControl16.btPKG.BackColor = Color.LawnGreen

                        UserControl16.btQR01.BackColor = Color.LawnGreen
                        UserControl16.btNumber.BackColor = Color.LawnGreen
                    Case "Channel7"
                        ' UserControl17.btQR01.Text = data("LotNo").ToString
                        UserControl17.btLotNo.Text = data("LotNo").ToString
                        UserControl17.btPKG.Text = data("Package").ToString
                        UserControl17.btLotNo.BackColor = Color.LawnGreen
                        UserControl17.btPKG.BackColor = Color.LawnGreen

                        UserControl17.btQR01.BackColor = Color.LawnGreen
                        UserControl17.btNumber.BackColor = Color.LawnGreen
                    Case "Channel8"
                        ' UserControl18.btQR01.Text = data("LotNo").ToString
                        UserControl18.btLotNo.Text = data("LotNo").ToString
                        UserControl18.btPKG.Text = data("Package").ToString
                        UserControl18.btLotNo.BackColor = Color.LawnGreen
                        UserControl18.btPKG.BackColor = Color.LawnGreen

                        UserControl18.btQR01.BackColor = Color.LawnGreen
                        UserControl18.btNumber.BackColor = Color.LawnGreen
                    Case "Channel9"
                        ' UserControl19.btQR01.Text = data("LotNo").ToString
                        UserControl19.btLotNo.Text = data("LotNo").ToString
                        UserControl19.btPKG.Text = data("Package").ToString
                        UserControl19.btLotNo.BackColor = Color.LawnGreen
                        UserControl19.btPKG.BackColor = Color.LawnGreen

                        UserControl19.btQR01.BackColor = Color.LawnGreen
                        UserControl19.btNumber.BackColor = Color.LawnGreen
                End Select

            End While


            If count = 9 Then
                btWORKINGSLIP.BackColor = Color.Red
            End If
            '    btWORKINGSLIP.Text = count.ToString
            conn.Close()
            If control = "Manual" Then

            Else
                If OPID <> "" And MachineName <> "" Then
                    If UserControl11.btLotNo.Text = "" Then
                        Channel = "Channel1"
                        '  UserControl11.btLotNo.BackColor = Color.Gold
                    ElseIf UserControl12.btLotNo.Text = "" Then
                        Channel = "Channel2"
                        ' UserControl12.btQR01.BackColor = Color.Gold
                    ElseIf UserControl13.btLotNo.Text = "" Then
                        Channel = "Channel3"
                        '  btQR03.BackColor = Color.Gold
                    ElseIf UserControl14.btLotNo.Text = "" Then
                        Channel = "Channel4"
                        '  btQR04.BackColor = Color.Gold
                    ElseIf UserControl15.btLotNo.Text = "" Then
                        Channel = "Channel5"
                        '  btQR05.BackColor = Color.Gold
                    ElseIf UserControl16.btLotNo.Text = "" Then
                        Channel = "Channel6"
                        '  btQR06.BackColor = Color.Gold
                    ElseIf UserControl17.btLotNo.Text = "" Then
                        Channel = "Channel7"
                        '  btQR07.BackColor = Color.Gold
                    ElseIf UserControl18.btLotNo.Text = "" Then
                        Channel = "Channel8"
                        '   btQR08.BackColor = Color.Gold
                    ElseIf UserControl19.btLotNo.Text = "" Then
                        Channel = "Channel9"
                        '   btQR09.BackColor = Color.Gold
                    Else
                        Channel = ""
                    End If
                End If
            End If

            Select Case Channel
                Case "Channel1"
                    UserControl11.btQR01.BackColor = Color.Gold
                    UserControl11.btNumber.BackColor = Color.Gold

                    UserControl11.btLotNo.BackColor = Color.Gold
                    UserControl11.btPKG.BackColor = Color.Gold
                Case "Channel2"
                    UserControl12.btQR01.BackColor = Color.Gold
                    UserControl12.btNumber.BackColor = Color.Gold

                    UserControl12.btLotNo.BackColor = Color.Gold
                    UserControl12.btPKG.BackColor = Color.Gold
                Case "Channel3"
                    UserControl13.btQR01.BackColor = Color.Gold
                    UserControl13.btNumber.BackColor = Color.Gold

                    UserControl13.btLotNo.BackColor = Color.Gold
                    UserControl13.btPKG.BackColor = Color.Gold
                Case "Channel4"
                    UserControl14.btQR01.BackColor = Color.Gold
                    UserControl14.btNumber.BackColor = Color.Gold

                    UserControl14.btLotNo.BackColor = Color.Gold
                    UserControl14.btPKG.BackColor = Color.Gold
                Case "Channel5"
                    UserControl15.btQR01.BackColor = Color.Gold
                    UserControl15.btNumber.BackColor = Color.Gold

                    UserControl15.btLotNo.BackColor = Color.Gold
                    UserControl15.btPKG.BackColor = Color.Gold
                Case "Channel6"
                    UserControl16.btQR01.BackColor = Color.Gold
                    UserControl16.btNumber.BackColor = Color.Gold

                    UserControl16.btLotNo.BackColor = Color.Gold
                    UserControl16.btPKG.BackColor = Color.Gold
                Case "Channel7"
                    UserControl17.btQR01.BackColor = Color.Gold
                    UserControl17.btNumber.BackColor = Color.Gold

                    UserControl17.btLotNo.BackColor = Color.Gold
                    UserControl17.btPKG.BackColor = Color.Gold
                Case "Channel8"
                    UserControl18.btQR01.BackColor = Color.Gold
                    UserControl18.btNumber.BackColor = Color.Gold

                    UserControl18.btLotNo.BackColor = Color.Gold
                    UserControl18.btPKG.BackColor = Color.Gold
                Case "Channel9"
                    UserControl19.btQR01.BackColor = Color.Gold
                    UserControl19.btNumber.BackColor = Color.Gold

                    UserControl19.btLotNo.BackColor = Color.Gold
                    UserControl19.btPKG.BackColor = Color.Gold
            End Select

        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Private Sub Buzzer(ByVal count As Integer)
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        'Buzzer
        Dim stBuzzerSet As New LibDef.BT_BUZZER_PARAM()
        ' Buzzer control structure (Set)
        ' Set to repeat "500 ms on, 500 ms off" 3 times
        stBuzzerSet.dwOn = 500
        ' Rumble time [ms] (1 to 5000)
        stBuzzerSet.dwOff = 500
        ' Stop time [ms] (0 to 5000)
        stBuzzerSet.dwCount = count
        ' Rumble count [times] (0 to 100)
        stBuzzerSet.bTone = 16
        ' Musical scale (1 to 16)
        stBuzzerSet.bVolume = 3
        ' Buzzer volume (1 to 3)

        ' Vibrator
        Dim stVibSet As New LibDef.BT_VIBRATOR_PARAM()
        stVibSet.dwOn = 500
        ' Rumble time [ms] (1 to 5000)
        stVibSet.dwOff = 500
        ' Stop time [ms] (0 to 5000)
        stVibSet.dwCount = count
        ' Rumble count [times] (0 to 100)
        Try
            ' btBuzzer Rumble
            ret = Device.btBuzzer(1, stBuzzerSet)
            ret = Device.btVibrator(1, stVibSet)
            If ret <> LibDef.BT_OK Then
                disp = "btBuzzer error ret[" & ret & "]"
                MessageBox.Show(disp, "Error")
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        QurySql()
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        'Dim mainlevelGet As UInt32 = 0
        'ret = Device.btGetMainBatteryLevel(mainlevelGet)
        'If mainlevelGet <= 1 Then
        '    If buzzerCheck = 0 Then
        '        Buzzer(8)
        '        buzzerCheck = 1
        '    End If
        'End If

    End Sub

    Private Sub pbxLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxLogo.Click
        ' Me.Close()
        'Dim frm As New FormExit
        'If frm.ShowDialog() = DialogResult.OK Then
        '    If ExitProgram = "Exit" Then
        '        Me.Close()
        '    End If
        'End If
        Dim mbr As MsgBoxResult
        mbr = MsgBox("ท่านต้องการจะปิดโปรแกรมหรือไม่", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, "Logout")
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerOPID.Tick
        TimerOPID.Enabled = False
        Dim frm As New PopUpOPID
        If frm.ShowDialog() = DialogResult.OK Then
            QurySql()
            TimerBoxName.Enabled = True
        End If
    End Sub

    Private Sub TimerBoxName_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBoxName.Tick
        TimerBoxName.Enabled = False
        Dim frm As New PopUpBox
        If frm.ShowDialog() = DialogResult.OK Then
            QurySql()
            TimeMM = SetTimeOut
            TimerTimeOut.Enabled = True
        End If
    End Sub
    '  Dim RHH As Integer
    Private Sub TimerLoseTime_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimeOut.Tick
        'TimeSS += 1
        'If TimeSS = 60 Then
        '    TimeMM += 1
        '    TimeSS = 0
        'End If
        ''If RMM = 60 Then
        ''    '  RHH += 1
        ''    RMM = 0
        ''End If
        'If TimeMM = 30 Then
        '    '  RHH += 1
        '    TimeMM = 0
        '    OPID = ""
        '    TimerOPID.Enabled = True
        'End If
        'If TimeMM >= 25 Then
        '    lbLoseTime.ForeColor = Color.Red
        'Else
        '    lbLoseTime.ForeColor = Color.Black
        'End If
        If TimeSS = 0 Then
            TimeMM -= 1
            TimeSS = 60
        End If
        TimeSS -= 1
        If TimeMM <= setTimeOutSignal Then
            lbLoseTime.ForeColor = Color.Red
            If buzzerCheck = 0 Then
                Buzzer(3)
                buzzerCheck = 1
            End If
        Else
            buzzerCheck = 0
            lbLoseTime.ForeColor = Color.White
        End If
        If TimeMM = 0 And TimeSS = 0 Then
            TimerOPID.Enabled = True
            TimerTimeOut.Enabled = False
        End If
        lbLoseTime.Text = TimeMM.ToString("00") & ":" & TimeSS.ToString("00")
        '  lbLoseTime.Text = TimeMM.ToString("00") & ":" & TimeSS.ToString("00") 'RHH.ToString("00") & ":" &


    End Sub

  
  
End Class
