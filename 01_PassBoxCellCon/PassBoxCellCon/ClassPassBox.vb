Public Class ClassPassBox
    Private _SelectBox As String
    Public Property SelectBox As String
        Get
            Return _SelectBox
        End Get
        Set(ByVal value As String)
            _SelectBox = value
        End Set
    End Property
   
End Class
