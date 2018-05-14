Public Class ThamSoDTO
    Private iSoLanToiDa As Integer
    ' Private iHanThe As Integer
    Public Property SoLanKhamToiDa() As Integer
        Get
            Return iSoLanToiDa
        End Get
        Set(value As Integer)
            iSoLanToiDa = value
        End Set
    End Property
End Class
