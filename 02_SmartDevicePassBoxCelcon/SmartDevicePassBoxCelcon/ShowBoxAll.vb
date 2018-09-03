Imports System.Data.SqlClient
Public Class ShowBoxAll

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-01' and LotEndTime is null;"
        Dim data1 As SqlDataReader = cmd_excuteScalar()
        While data1.Read
            ProgressBar1.Value = CInt(data1("Num"))
            Label1.Text = data1("Num").ToString & "/7"
        End While
        conn.Close()

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-02' and LotEndTime is null;"
        Dim data2 As SqlDataReader = cmd_excuteScalar()
        While data2.Read
            ProgressBar2.Value = CInt(data2("Num"))
            Label2.Text = data2("Num").ToString & "/7"
        End While
        conn.Close()

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-03' and LotEndTime is null;"
        Dim data3 As SqlDataReader = cmd_excuteScalar()
        While data3.Read
            ProgressBar3.Value = CInt(data3("Num"))
            Label3.Text = data3("Num").ToString & "/7"
        End While
        conn.Close()

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-04' and LotEndTime is null;"
        Dim data4 As SqlDataReader = cmd_excuteScalar()
        While data4.Read
            ProgressBar4.Value = CInt(data4("Num"))
            Label4.Text = data4("Num").ToString & "/7"
        End While
        conn.Close()

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-05' and LotEndTime is null;"
        Dim data5 As SqlDataReader = cmd_excuteScalar()
        While data5.Read
            ProgressBar5.Value = CInt(data5("Num"))
            Label5.Text = data5("Num").ToString & "/7"
        End While
        conn.Close()

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-06' and LotEndTime is null;"
        Dim data6 As SqlDataReader = cmd_excuteScalar()
        While data6.Read
            ProgressBar6.Value = CInt(data6("Num"))
            Label6.Text = data6("Num").ToString & "/7"
        End While
        conn.Close()

        sql = "SELECT COUNT( MCNo) as Num FROM WBMPPassbox where MCNo='MP-PB-07' and LotEndTime is null;"
        Dim data7 As SqlDataReader = cmd_excuteScalar()
        While data7.Read
            ProgressBar7.Value = CInt(data7("Num"))
            Label7.Text = data7("Num").ToString & "/9"
        End While
        conn.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP01.Click, MP07.Click, MP06.Click, MP05.Click, MP04.Click, MP03.Click, MP02.Click
        Dim val As Button = CType(sender, Button)
        Dim Name As String = val.Parent.Name.ToString
        Select Case Name
            Case "MP01"
                MachineName = "MP-PB-01"
            Case "MP02"
                MachineName = "MP-PB-02"
            Case "MP03"
                MachineName = "MP-PB-03"
            Case "MP04"
                MachineName = "MP-PB-04"
            Case "MP05"
                MachineName = "MP-PB-05"
            Case "MP06"
                MachineName = "MP-PB-06"
            Case "MP07"
                MachineName = "MP-PB-07"
        End Select

        Timer1.Enabled = True


    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Timer1.Enabled = False
      Me.DialogResult = DialogResult.OK
    End Sub
End Class