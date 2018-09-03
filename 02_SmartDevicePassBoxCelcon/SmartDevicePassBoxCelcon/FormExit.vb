Public Class FormExit
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbLogout.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If tbLogout.Text.Length = 6 Then
                LoOut()
            Else
                tbLogout.Text = ""
                MsgBox("No Password")
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
    Private Sub btLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLogout.Click
        LoOut()
    End Sub
    Private Sub LoOut()
        Dim Pass As String = Format(Now, "yyMMdd") 'Date.Now.Year.ToString & Date.Now.Month.ToString("00") & Date.Now.Day.ToString("00")
        If tbLogout.Text = Pass Then
            ' MsgBox("ok")
            ExitProgram = "Exit"
            Me.DialogResult = DialogResult.OK
        Else
            tbLogout.Text = ""
            MsgBox("No Password")
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Private Sub FormExit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbLogout.Focus()
    End Sub
End Class