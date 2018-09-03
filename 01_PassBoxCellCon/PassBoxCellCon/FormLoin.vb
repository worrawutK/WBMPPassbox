Public Class FormLoin
    Private Sub Login(sender As System.Object, e As System.EventArgs) Handles btNum1.Click, btNum9.Click, btNum8.Click, btNum7.Click, btNum6.Click, btNum5.Click, btNum4.Click, btNum3.Click, btNum2.Click, btNum00.Click, btNum0.Click, btBS.Click
        Dim val As String
        val = sender.text
        If val = "BS" Then
            If lbDisplay.Text.Length > 0 Then
                lbDisplay.Text = lbDisplay.Text.Substring(0, lbDisplay.Text.Length - 1)
            End If
        Else
            If Len(lbDisplay.Text) < 6 Then
                If Len(lbDisplay.Text) = 5 And val = "00" Then
                    MsgBox("กรุณา ใส่ รหัสพนักงานจำนวน 6 หลัก")
                Else
                    lbDisplay.Text += val

                End If
            End If
        End If
    End Sub
    Private Sub btENTER_Click(sender As System.Object, e As System.EventArgs) Handles btENTER.Click
        If lbDisplay.Text = "" Then
            MsgBox("กรุณา ใส่ รหัสพนักงาน")
            Exit Sub
        End If
        If Len(lbDisplay.Text) <> 6 Then
            MsgBox("กรุณา ใส่ รหัสพนักงานจำนวน 6 หลัก")
            lbDisplay.Text = ""
            Exit Sub
        End If
     
        OPID = lbDisplay.Text

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Label45_Click(sender As System.Object, e As System.EventArgs) Handles Label45.Click

    End Sub

    Private Sub lbDisplay_Click(sender As System.Object, e As System.EventArgs) Handles lbDisplay.Click

    End Sub
End Class