Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btAddPlan.Click
        Dim frm As New Form1
        If frm.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Query()
    End Sub
    Private Sub Query()
        CountWIPTableAdapter1.Fill(DataSet11.CountWIP)
        Dim WIP As Int16 = 0
        For Each data As DataSet1.CountWIPRow In DataSet11.CountWIP
            WIP += data.WIP
        Next

        Label1.Text = "WIP ALL :" & WIP.ToString
        DataGridView1.DataSource = DataSet11.CountWIP
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex <> "-1" Then
            Dim value As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            CellClick(value)

        End If
    End Sub
    Private Sub CellClick(ByVal Package As String)
        WipmpTableAdapter1.Fill(DataSet11.WIPMP, Package)

        DataGridView2.DataSource = DataSet11.WIPMP
        DataGridView2.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query()
        If My.Settings.Master = False Then
            btAddPlan.Visible = False
        Else
            btAddPlan.Visible = True
        End If
    End Sub
    Private Sub CancelLot(Lot As String)
        WbmpPassboxTableAdapter1.Fill(DataSet11.WBMPPassbox, Lot)
        For Each data As DataSet1.WBMPPassboxRow In DataSet11.WBMPPassbox
            data.Remark = "CANCELWIP"
        Next
        WbmpPassboxTableAdapter1.Update(DataSet11.WBMPPassbox)
    End Sub
    Dim PKG_CANCEL As String
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex <> "-1" Then
            Dim value As String = DataGridView2.Rows(e.RowIndex).Cells(0).Value
            '   CancelLot(value)
            PKG_CANCEL = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            lbLotNo.Text = value
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("ต้องการ Cancel Lot" & lbLotNo.Text & " หรือไม่ ?", "Confirm", MessageBoxButtons.YesNo)

        If lbLotNo.Text.Length = 10 Then
            If result = DialogResult.No Then
                ' MessageBox.Show("No pressed")
            ElseIf result = DialogResult.Yes Then
                CancelLot(lbLotNo.Text)
                Query()
                CellClick(PKG_CANCEL)
                lbLotNo.Text = "กรุณาเลือก lot ที่จะทำการ Cancel"
                MsgBox("Cancel Lot เรียบร้อย")
            End If
        Else
            MsgBox("กรุณาเลือก LotNo ที่ต้องการ Cancel")
            lbLotNo.Text = "กรุณาเลือก lot ที่จะทำการ Cancel"
        End If

    End Sub
End Class