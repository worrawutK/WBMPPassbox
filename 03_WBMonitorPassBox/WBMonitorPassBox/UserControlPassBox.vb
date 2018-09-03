Public Class UserControlPassBox
    Private Sub Control_Click(sender As System.Object, e As System.EventArgs) Handles btMP01.Click

        Dim val As String
        val = sender.name
        For i = 0 To 7
            If Me.Name = "UserControlPassBox" & i Then
                MCNo = "MP-PB-0" & i
            End If
        Next
        Dim frm As New ShowChannel
        frm.loadfrm = True
        If frm.ShowDialog() = DialogResult.OK Then
            '   MsgBox("ok")
        End If
    End Sub
    Dim ACounter As Integer
    Public Sub ProgressBar(ByVal Count As Integer)


        If ACounter <> Count Then

        End If
        ACounter = Count
        If ACounter = 0 Then
            For Each ctr As Control In GroupBox1.Controls
                If TypeOf ctr Is Label Then
                    If ctr.TabIndex = 10 Then
                        ctr.BackColor = Color.SteelBlue
                    Else
                        ctr.BackColor = Color.Lavender
                    End If

                End If
            Next
        Else

            For Each ctr As Control In GroupBox1.Controls
                '   ctr.BackColor = Color.Red
                If TypeOf ctr Is Label Then
                    If ctr.TabIndex <= ACounter Then
                        ctr.BackColor = Color.Blue
                        If ACounter >= 9 Then
                            CountBox1.BackColor = Color.Red
                            '  Panel1.BackColor = Color.Red
                        ElseIf ACounter >= 7 And ACounter < 9 Then
                            CountBox1.BackColor = Color.Yellow
                            '  Panel1.BackColor = Color.Yellow
                        Else
                            CountBox1.BackColor = Color.LawnGreen
                            ' Panel1.BackColor = Color.LawnGreen
                        End If
                        Panel1.BackColor = Color.Silver
                        ' ACounter -= 1
                    Else
                        If ctr.TabIndex = 10 Then
                            ctr.BackColor = Color.SteelBlue
                        Else
                            ctr.BackColor = Color.Lavender
                        End If

                    End If
                End If
            Next
        End If

    End Sub

    Private Sub Progress6_Click(sender As System.Object, e As System.EventArgs) Handles Progress6.Click

    End Sub


   
End Class
