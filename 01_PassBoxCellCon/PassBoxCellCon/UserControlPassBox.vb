Public Class UserControlPassBox
    ' Event UserControlClick()

    Private Sub Control_Click(sender As System.Object, e As System.EventArgs) Handles btnInput.Click, pnlBox.Click, lbOutday.Click, lbOutdaytxt.Click, lbLotNoData.Click, lblLotNo.Click, btText.Click, lbTime.Click

        If OPID = "" Then
            MsgBox("กรุณา Loging")
            Exit Sub
        End If
        Dim val As String
        val = sender.name
        Dim lbnum As Integer
        val = "Channel" & Me.Name.Replace("UserControlPassBox", "")
        'For i = 0 To 9
        '    If Me.Name = "UserControlPassBox" & i Then
        '        val = "Channel" & i
        '        lbnum = i
        '        MonitorPassBoxMP.lbPKG(i).Text = "-"
        '        MonitorPassBoxMP.lbLotNo(i).Text = "-"
        '        MonitorPassBoxMP.lbShipmentDate(i).Text = "-"
        '        MonitorPassBoxMP.UserControl(i).BackColor = Color.Transparent

        '        lbOutday.Text = "-"
        '        lbLotNoData.Text = "-"
        '        lbShipmentDate.Text = "-"
        '        lbInputDate.Text = "-"
        '        btnInput.BackColor = Color.Transparent
        '    End If
        'Next
        WbmpPassboxTableAdapter1.Fill(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox, MCNo)
        For Each Data As DBxDataSet.WBMPPassboxRow In MonitorPassBoxMP.DBxDataSet1.WBMPPassbox
            If Data.ChannelNumber = val Then
                Data.LotEndTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                Data.OPNoOut = OPID
            End If
        Next
        WbmpPassboxTableAdapter1.Update(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox)
        Me.WbmpPassboxTableAdapter1.FillGridView(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox, MCNo)
        '  FullDisplayUserControl.Tick1()
    End Sub
    Public Sub PriorityNumber(Number As String, Color As Drawing.Color, Time As String)
        btText.Text = Number
        btnInput.BackColor = Color
        lbTime.BackColor = Color
        lbTime.Text = Time

    End Sub


End Class
