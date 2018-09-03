Imports System.Data.SqlClient
Public Class UserControl1

    Private Sub btControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQR01.Click, btNumber.Click, btPKG.Click, btLotNo.Click
        Dim val As Button = CType(sender, Button)
        ' MsgBox(val.Parent.Name.ToString)
        ' ClearText()
        'If OPID = "" Then
        '    MsgBox(MsgScanOPID)
        '    FormMaster.tbQR.Focus()
        '    Exit Sub
        'ElseIf MachineName = "" Then
        '    MsgBox(MsgScanBox)
        '    FormMaster.tbQR.Focus()
        '    Exit Sub
        'End If

        If val.Parent.Name.ToString = "UserControl11" Then
            delchannel = "Channel1"
            Channel = "Channel1"
        ElseIf val.Parent.Name.ToString = "UserControl12" Then
            delchannel = "Channel2"
            Channel = "Channel2"
        ElseIf val.Parent.Name.ToString = "UserControl13" Then
            delchannel = "Channel3"
            Channel = "Channel3"
        ElseIf val.Parent.Name.ToString = "UserControl14" Then
            delchannel = "Channel4"
            Channel = "Channel4"
        ElseIf val.Parent.Name.ToString = "UserControl15" Then
            delchannel = "Channel5"
            Channel = "Channel5"
        ElseIf val.Parent.Name.ToString = "UserControl16" Then
            delchannel = "Channel6"
            Channel = "Channel6"
        ElseIf val.Parent.Name.ToString = "UserControl17" Then
            delchannel = "Channel7"
            Channel = "Channel7"
        ElseIf val.Parent.Name.ToString = "UserControl18" Then
            delchannel = "Channel8"
            Channel = "Channel8"
        ElseIf val.Parent.Name.ToString = "UserControl19" Then
            delchannel = "Channel9"
            Channel = "Channel9"
        End If
        Try
            sql = "SELECT MCNo, LotNo, LotStartTime, OPNoIn, OPNoOut, LotEndTime, ChannelNumber, NetVersion, SelfConVersion, Remark FROM [DBx].[dbo].[WBMPPassbox] WHERE (MCNo = '" & MachineName & "') AND (LotEndTime IS NULL);"
            Dim data As SqlDataReader = cmd_excuteScalar()

            While data.Read
                If data("ChannelNumber").ToString = delchannel Then
                    del = "Delete"
                    '  FormMaster.Timer1.Enabled = False
                End If

            End While
            conn.Close()
            control = "Manual"

            If del = "Delete" Then

                del = ""
                QurySql()
                If MsgBox(MsgDelete, MsgBoxStyle.YesNoCancel, "Delete") = MsgBoxResult.Yes Then
                    ' MsgBox("del")
                    DeleteChannel()
                End If
                control = "Auto"
                'FormMaster.Timer1.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ClearText()
        QurySql()
    End Sub
    Private Sub DeleteChannel()
        'delete
        sql = "DELETE FROM [DBx].[dbo].[WBMPPassbox] WHERE (MCNo = '" & MachineName & "') AND ChannelNumber='" & delchannel & "' AND (LotEndTime IS NULL);"
        cmd_ExecuteNonQuery()
        control = "Auto"
        ' MsgBox("delete" & Channel.ToString & delchannel.ToString)
        conn.Close()
        delchannel = ""
    End Sub
    Private Sub ClearText()
        'bt panel
        'FormMaster.UserControl11.btQR01.Text = ""
        'FormMaster.UserControl12.btQR01.Text = ""
        'FormMaster.UserControl13.btQR01.Text = ""
        'FormMaster.UserControl14.btQR01.Text = ""
        'FormMaster.UserControl15.btQR01.Text = ""
        'FormMaster.UserControl16.btQR01.Text = ""
        'FormMaster.UserControl17.btQR01.Text = ""
        'FormMaster.UserControl18.btQR01.Text = ""
        'FormMaster.UserControl19.btQR01.Text = ""
        FormMaster.UserControl11.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl12.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl13.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl14.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl15.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl16.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl17.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl18.btQR01.BackColor = SystemColors.Control
        FormMaster.UserControl19.btQR01.BackColor = SystemColors.Control
        'bt Number
        FormMaster.UserControl11.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl12.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl13.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl14.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl15.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl16.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl17.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl18.btNumber.BackColor = SystemColors.Control
        FormMaster.UserControl19.btNumber.BackColor = SystemColors.Control
        'LotNo
        FormMaster.UserControl11.btLotNo.Text = ""
        FormMaster.UserControl12.btLotNo.Text = ""
        FormMaster.UserControl13.btLotNo.Text = ""
        FormMaster.UserControl14.btLotNo.Text = ""
        FormMaster.UserControl15.btLotNo.Text = ""
        FormMaster.UserControl16.btLotNo.Text = ""
        FormMaster.UserControl17.btLotNo.Text = ""
        FormMaster.UserControl18.btLotNo.Text = ""
        FormMaster.UserControl19.btLotNo.Text = ""
        FormMaster.UserControl11.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl12.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl13.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl14.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl15.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl16.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl17.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl18.btLotNo.BackColor = SystemColors.Control
        FormMaster.UserControl19.btLotNo.BackColor = SystemColors.Control
        'PKG
        FormMaster.UserControl11.btPKG.Text = ""
        FormMaster.UserControl12.btPKG.Text = ""
        FormMaster.UserControl13.btPKG.Text = ""
        FormMaster.UserControl14.btPKG.Text = ""
        FormMaster.UserControl15.btPKG.Text = ""
        FormMaster.UserControl16.btPKG.Text = ""
        FormMaster.UserControl17.btPKG.Text = ""
        FormMaster.UserControl18.btPKG.Text = ""
        FormMaster.UserControl19.btPKG.Text = ""
        FormMaster.UserControl11.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl12.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl13.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl14.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl15.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl16.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl17.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl18.btPKG.BackColor = SystemColors.Control
        FormMaster.UserControl19.btPKG.BackColor = SystemColors.Control





    End Sub
    Private Sub QurySql()
        Try
            Try
                If OPID <> "" Then
                    FormMaster.lbOPID.Text = OPID
                    FormMaster.lbOPID.ForeColor = Color.LawnGreen
                End If
                If MachineName <> "" Then
                    FormMaster.lbMachine.Text = Trim(MachineName.Substring(3, 5)).ToUpper
                    FormMaster.lbMachine.ForeColor = Color.LawnGreen
                End If

            Catch ex As Exception

            End Try
            'FormMaster.lbOPID.Text = "OPID :" & OPID
            'FormMaster.lbMachine.Text = "BOX :" & MachineName

            FormMaster.tbQR.Focus()
            If OPID = "" Then
                FormMaster.btScanOPID.BackColor = Color.Gold
                FormMaster.btScanBox.BackColor = SystemColors.Control
                FormMaster.btWORKINGSLIP.BackColor = SystemColors.Control
            ElseIf MachineName = "" Then
                FormMaster.btScanOPID.BackColor = Color.LawnGreen
                FormMaster.btScanBox.BackColor = Color.Gold
                FormMaster.btWORKINGSLIP.BackColor = SystemColors.Control
            Else
                FormMaster.btScanOPID.BackColor = Color.LawnGreen
                FormMaster.btScanBox.BackColor = Color.LawnGreen
                FormMaster.btWORKINGSLIP.BackColor = Color.Gold
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
                        ' FormMaster.UserControl11.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl11.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl11.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl11.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl11.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl11.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl11.btNumber.BackColor = Color.LawnGreen


                    Case "Channel2"
                        '  FormMaster.UserControl12.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl12.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl12.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl12.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl12.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl12.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl12.btNumber.BackColor = Color.LawnGreen
                      
                    Case "Channel3"
                        '  FormMaster.UserControl13.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl13.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl13.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl13.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl13.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl13.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl13.btNumber.BackColor = Color.LawnGreen
                    Case "Channel4"
                        'FormMaster.UserControl14.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl14.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl14.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl14.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl14.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl14.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl14.btNumber.BackColor = Color.LawnGreen
                    Case "Channel5"
                        ' FormMaster.UserControl15.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl15.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl15.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl15.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl15.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl15.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl15.btNumber.BackColor = Color.LawnGreen
                    Case "Channel6"
                        ' FormMaster.UserControl16.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl16.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl16.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl16.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl16.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl16.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl16.btNumber.BackColor = Color.LawnGreen
                    Case "Channel7"
                        '  FormMaster.UserControl17.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl17.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl17.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl17.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl17.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl17.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl17.btNumber.BackColor = Color.LawnGreen
                    Case "Channel8"
                        'FormMaster.UserControl18.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl18.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl18.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl18.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl18.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl18.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl18.btNumber.BackColor = Color.LawnGreen
                    Case "Channel9"
                        ' FormMaster.UserControl19.btQR01.Text = data("LotNo").ToString
                        FormMaster.UserControl19.btLotNo.Text = data("LotNo").ToString
                        FormMaster.UserControl19.btPKG.Text = data("Package").ToString
                        FormMaster.UserControl19.btLotNo.BackColor = Color.LawnGreen
                        FormMaster.UserControl19.btPKG.BackColor = Color.LawnGreen

                        FormMaster.UserControl19.btQR01.BackColor = Color.LawnGreen
                        FormMaster.UserControl19.btNumber.BackColor = Color.LawnGreen
                End Select

            End While


            If count = 9 Then
                FormMaster.btWORKINGSLIP.BackColor = Color.Red
            End If

            conn.Close()
            If control = "Manual" Then

            Else
                If OPID <> "" And MachineName <> "" Then
                    If FormMaster.UserControl11.btLotNo.Text = "" Then
                        Channel = "Channel1"
                        '  UserControl11.btQR01.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl12.btLotNo.Text = "" Then
                        Channel = "Channel2"
                        '     FormMaster.UserControl12.btQR01.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl13.btLotNo.Text = "" Then
                        Channel = "Channel3"
                        '  btQR03.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl14.btLotNo.Text = "" Then
                        Channel = "Channel4"
                        '  btQR04.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl15.btLotNo.Text = "" Then
                        Channel = "Channel5"
                        '  btQR05.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl16.btLotNo.Text = "" Then
                        Channel = "Channel6"
                        '  btQR06.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl17.btLotNo.Text = "" Then
                        Channel = "Channel7"
                        '  btQR07.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl18.btLotNo.Text = "" Then
                        Channel = "Channel8"
                        '   btQR08.BackColor = Color.Gold
                    ElseIf FormMaster.UserControl19.btLotNo.Text = "" Then
                        Channel = "Channel9"
                        '   btQR09.BackColor = Color.Gold
                    Else
                        Channel = ""
                    End If
                End If
            End If

            Select Case Channel
                Case "Channel1"
                    FormMaster.UserControl11.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl11.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl11.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl11.btPKG.BackColor = Color.Gold
                Case "Channel2"
                    FormMaster.UserControl12.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl12.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl12.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl12.btPKG.BackColor = Color.Gold
                Case "Channel3"
                    FormMaster.UserControl13.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl13.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl13.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl13.btPKG.BackColor = Color.Gold
                Case "Channel4"
                    FormMaster.UserControl14.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl14.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl14.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl14.btPKG.BackColor = Color.Gold
                Case "Channel5"
                    FormMaster.UserControl15.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl15.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl15.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl15.btPKG.BackColor = Color.Gold
                Case "Channel6"
                    FormMaster.UserControl16.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl16.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl16.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl16.btPKG.BackColor = Color.Gold
                Case "Channel7"
                    FormMaster.UserControl17.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl17.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl17.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl17.btPKG.BackColor = Color.Gold
                Case "Channel8"
                    FormMaster.UserControl18.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl18.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl18.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl18.btPKG.BackColor = Color.Gold
                Case "Channel9"
                    FormMaster.UserControl19.btQR01.BackColor = Color.Gold
                    FormMaster.UserControl19.btNumber.BackColor = Color.Gold

                    FormMaster.UserControl19.btLotNo.BackColor = Color.Gold
                    FormMaster.UserControl19.btPKG.BackColor = Color.Gold
            End Select

        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class
