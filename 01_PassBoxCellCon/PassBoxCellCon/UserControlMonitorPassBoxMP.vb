Public Class UserControlMonitorPassBoxMP
    Private Sub Control_Click(sender As System.Object, e As System.EventArgs) Handles btnInput.Click, pnlBox.Click, lbShipmentDate.Click, lbPKG.Click, lbLotNoData.Click, lblLotNo.Click, btText.Click, btChannel.Click, Label1.Click, lbTime.Click

        Dim val As String
        val = sender.name
        Dim lbnum As Integer
        For i = 0 To 9
            If Me.Name = "UserControlMonitorPassBoxMP" & i Then
                val = "Channel" & i
                lbnum = i
                MonitorPassBoxMP.lbPKG(i).Text = "-"
                MonitorPassBoxMP.lbLotNo(i).Text = "-"
                MonitorPassBoxMP.lbShipmentDate(i).Text = "-"
                MonitorPassBoxMP.UserControl(i).BackColor = Color.Transparent
            End If
        Next
        '  Dim count As Integer
        WbmpPassboxTableAdapter1.Fill(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox, MCNo)
        For Each Data As DBxDataSet.WBMPPassboxRow In MonitorPassBoxMP.DBxDataSet1.WBMPPassbox
            If Data.ChannelNumber = val Then
                Data.LotEndTime = Format(Now, "yyyy/MM/dd HH:mm:ss")
                Data.OPNoOut = OPID
            End If
        Next
        WbmpPassboxTableAdapter1.Update(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox)
        Me.WbmpPassboxTableAdapter1.FillGridView(MonitorPassBoxMP.DBxDataSet1.WBMPPassbox, MCNo)
    End Sub
    Public Sub PriorityNumber(Number As String, Color As Drawing.Color, Time As String)
        btText.Text = Number
        btnInput.BackColor = Color
        lbTime.BackColor = Color
        lbTime.Text = Time

    End Sub
End Class
