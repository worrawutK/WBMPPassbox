Public Class ShowChannel
    Public lbPKGFull As New Collection
    Public lbLotNoFull As New Collection
    Public lbShipmentDateFull As New Collection
    Public lbInputDateFull As New Collection
    Public UserControl As New Collection
    Dim CheckData As Integer = 0
    Dim SumData As Integer = 0
    Public loadfrm As Boolean
    Private Sub ShowChannel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbMachine.Text = MCNo
        UserControlShow1.btText.Text = "1"
        UserControlShow2.btText.Text = "2"
        UserControlShow3.btText.Text = "3"
        UserControlShow4.btText.Text = "4"
        UserControlShow5.btText.Text = "5"
        UserControlShow6.btText.Text = "6"
        UserControlShow7.btText.Text = "7"
        UserControlShow8.btText.Text = "8"
        UserControlShow9.btText.Text = "9"

        lbPKGFull.Add(UserControlShow1.lbOutday)
        lbPKGFull.Add(UserControlShow2.lbOutday)
        lbPKGFull.Add(UserControlShow3.lbOutday)
        lbPKGFull.Add(UserControlShow4.lbOutday)
        lbPKGFull.Add(UserControlShow5.lbOutday)
        lbPKGFull.Add(UserControlShow6.lbOutday)
        lbPKGFull.Add(UserControlShow7.lbOutday)
        lbPKGFull.Add(UserControlShow8.lbOutday)
        lbPKGFull.Add(UserControlShow9.lbOutday)

        lbInputDateFull.Add(UserControlShow1.lbInputDate)
        lbInputDateFull.Add(UserControlShow2.lbInputDate)
        lbInputDateFull.Add(UserControlShow3.lbInputDate)
        lbInputDateFull.Add(UserControlShow4.lbInputDate)
        lbInputDateFull.Add(UserControlShow5.lbInputDate)
        lbInputDateFull.Add(UserControlShow6.lbInputDate)
        lbInputDateFull.Add(UserControlShow7.lbInputDate)
        lbInputDateFull.Add(UserControlShow8.lbInputDate)
        lbInputDateFull.Add(UserControlShow9.lbInputDate)

        lbShipmentDateFull.Add(UserControlShow1.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow2.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow3.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow4.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow5.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow6.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow7.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow8.lbShipmentDate)
        lbShipmentDateFull.Add(UserControlShow9.lbShipmentDate)

        lbLotNoFull.Add(UserControlShow1.lbLotNoData)
        lbLotNoFull.Add(UserControlShow2.lbLotNoData)
        lbLotNoFull.Add(UserControlShow3.lbLotNoData)
        lbLotNoFull.Add(UserControlShow4.lbLotNoData)
        lbLotNoFull.Add(UserControlShow5.lbLotNoData)
        lbLotNoFull.Add(UserControlShow6.lbLotNoData)
        lbLotNoFull.Add(UserControlShow7.lbLotNoData)
        lbLotNoFull.Add(UserControlShow8.lbLotNoData)
        lbLotNoFull.Add(UserControlShow9.lbLotNoData)

        UserControl.Add(UserControlShow1.btnInput)
        UserControl.Add(UserControlShow2.btnInput)
        UserControl.Add(UserControlShow3.btnInput)
        UserControl.Add(UserControlShow4.btnInput)
        UserControl.Add(UserControlShow5.btnInput)
        UserControl.Add(UserControlShow6.btnInput)
        UserControl.Add(UserControlShow7.btnInput)
        UserControl.Add(UserControlShow8.btnInput)
        UserControl.Add(UserControlShow9.btnInput)
        Qry()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If loadfrm = True Then
            Qry()
            loadfrm = False
        End If

    End Sub
    Private Sub Qry()
        Try

            'lbNameBox.Text = MCNo
            If CheckData <> SumData Then
                CheckData = SumData
                For i = 1 To 9
                    lbPKGFull(i).Text = "-"
                    lbLotNoFull(i).Text = "-"
                    UserControl(i).BackColor = SystemColors.Control
                    lbShipmentDateFull(i).Text = "-"
                Next
            End If

            'For i = 1 To 9
            '    lbPKGFull(i).Text = ""
            '    lbLotNoFull(i).Text = ""
            '    UserControl(i).BackColor = SystemColors.Control
            '    lbShipmentDateFull(i).Text = ""
            'Next
            SumData = 0
            WbmpPassboxTableAdapter1.Fill(DataSet11.WBMPPassbox, MCNo)
            For Each Data As DataSet1.WBMPPassboxRow In DataSet11.WBMPPassbox
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

                lbPKGFull(numChannel).Text = Data.Package
                lbLotNoFull(numChannel).Text = Data.LotNo
                UserControl(numChannel).BackColor = Color.LawnGreen

                LoT2_TABLETableAdapter1.Fill(DataSet11.LOT2_TABLE, Data.LotNo)
                For Each DataDay As DataSet1.LOT2_TABLERow In DataSet11.LOT2_TABLE

                    lbShipmentDateFull(numChannel).Text = "SHIPMENT DATE :" & DataDay.OUT_DAY
                    lbInputDateFull(numChannel).Text = "INPUT DATE :" & DataDay.IN_DAY
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class