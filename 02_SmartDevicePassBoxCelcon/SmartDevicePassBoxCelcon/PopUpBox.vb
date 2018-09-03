Public Class PopUpBox

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbQRBoxID.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If tbQRBoxID.Text.Length = 8 Then
                MachineName = tbQRBoxID.Text
                FormMaster.Timer1.Enabled = True
                Me.DialogResult = DialogResult.OK
                ' Me.Close()
            Else
                MsgBox(MsgScanAgain)
            End If
            tbQRBoxID.Text = ""
        End If
    End Sub

    Private Sub PopUpBox_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbQRBoxID.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        tbQRBoxID.Focus()
    End Sub
End Class