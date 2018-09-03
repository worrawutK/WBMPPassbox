Module Module1
    Public para As New ClassPassBox
    Friend Sub msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub
    Friend Sub msg_Ok(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub
    Friend Sub msg_Ok1(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKCancel, title)
    End Sub
    Public MCNo As String = "MP-PB-01"
    Public OPID As String
    Public LoadPage As String = "1"
   

End Module
