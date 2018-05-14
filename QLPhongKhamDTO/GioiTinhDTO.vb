Public Class GioiTinhDTO
    Private strMaLoaiGT As String
    Private strTenLoaiGT As String
    Public Sub New()

    End Sub
    Public Sub New(strMaLoaiGT As String, strTenLoaiGT As String)
        Me.strMaLoaiGT = strMaLoaiGT
        Me.strTenLoaiGT = strTenLoaiGT
    End Sub

    Public Property maloaigioitinh() As String
        Get
            Return strMaLoaiGT
        End Get
        Set(value As String)
            strMaLoaiGT = value
        End Set
    End Property
    Public Property tenloaigioitinh() As String
        Get
            Return strTenLoaiGT
        End Get
        Set(value As String)
            strTenLoaiGT = value
        End Set
    End Property
End Class
