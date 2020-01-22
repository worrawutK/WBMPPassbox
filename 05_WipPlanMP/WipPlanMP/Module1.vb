Imports System.Data.SqlClient

Module Module1

    Public Function GetWBMPPassboxSetting(year As Decimal, month As Decimal) As DataTable
        Dim data As DataTable = New DataTable
        Using cmd As SqlCommand = New SqlCommand()
            cmd.Connection = New SqlConnection("Data Source=172.16.0.102;Initial Catalog=DBx;User ID=dbxuser")
            cmd.Connection.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "SELECT Package, InputPlan, CreateTime FROM WBMPPassboxSetting WHERE (YEAR(CreateTime) = @year) AND (MONTH(CreateTime) = @month)"
            cmd.Parameters.Add("@year", SqlDbType.Decimal).Value = year
            cmd.Parameters.Add("@month", SqlDbType.Decimal).Value = month
            Dim result = cmd.ExecuteReader()
            data.Load(result)
        End Using
        Return data
    End Function
    Public Function SetWBMPPassboxSetting(year As Decimal, month As Decimal) As DataTable
        Dim data As DataTable = New DataTable
        Using cmd As SqlCommand = New SqlCommand()
            cmd.Connection = New SqlConnection("Data Source=172.16.0.102;Initial Catalog=DBx;User ID=dbxuser")
            cmd.Connection.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update WBMPPassboxSetting Set "
            cmd.Parameters.Add("@year", SqlDbType.Decimal).Value = year
            cmd.Parameters.Add("@month", SqlDbType.Decimal).Value = month
            Dim result = cmd.ExecuteReader()
            data.Load(result)
        End Using
        Return data
    End Function
End Module
