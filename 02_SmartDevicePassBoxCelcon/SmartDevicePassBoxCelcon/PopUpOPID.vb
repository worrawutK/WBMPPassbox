Public Class PopUpOPID

   

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbQROPID.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If tbQROPID.Text.Length = 6 Then
                OPID = tbQROPID.Text
                FormMaster.Timer1.Enabled = True
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox(MsgScanAgain)
            End If
            tbQROPID.Text = ""
            ' Me.Close()
        End If
    End Sub

    Private Sub PopUpOPID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbQROPID.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        tbQROPID.Focus()
    End Sub
End Class