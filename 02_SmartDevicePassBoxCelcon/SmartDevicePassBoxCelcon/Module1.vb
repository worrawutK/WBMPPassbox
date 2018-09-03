Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Public OPID As String '= "007567"
    Public MachineName As String '= "MP-PB-01"
    Public Channel As String = ""
    Public delchannel As String = ""
    Public MsgScanOPID As String = "กรุณาสแกน OPID" '"Please Scan OPID"
    Public MsgScanAgain As String = "กรุณาสแกนอีกครั้ง"
    Public MsgScanBox As String = "กรุณาสแกนตู้"
    Public MsgBoxFull As String = "ตู้เต็ม กรุณาเลือกตู้ใหม่"
    Public MsgLotNo As String = "LotNo. นี้ถูกใช้ไปแล้ว"
    Public MsgDelete As String = "คุณต้องการจะลบหรือไม่ ?"
    Public count As Integer = 0
    Public Checkcount As Integer = 0
    'lose time
    Public TimeSS As Integer
    Public SetTimeOut As Integer = 45
    Public TimeMM As Integer = SetTimeOut
    Public setTimeOutSignal As Integer = 4
    Public QRCode As String
    Public control As String
    Public del As String
    Public ExitProgram As String
    Friend conn As New SqlConnection("Data Source=172.16.0.102;User ID=dbxuser;Initial Catalog=DBx;")
    Friend cmd As New SqlCommand
    Friend sql As String
    Friend Sub connect_open()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, conn)
        Return cmd.ExecuteReader
    End Function
    Friend Function cmd_ExecuteNonQuery()
        connect_open()
        cmd = New SqlCommand(sql, conn)
        Return cmd.ExecuteNonQuery
    End Function

End Module
