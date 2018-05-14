Imports QLPhongKhamDTO

Public Class BenhNhanDTO
    Private strMSBN As String
    Private strHoTen As String
    Private dateNamSinh As DateTime
    Private strDiaChi As String
    Private strMaLoaiGioiTinh As String
    Public Sub New()

    End Sub
    Public Sub New(strMSBN As String, strMaLoaiGioiTinh As String, strHoten As String, strDiaChi As String, dateNamSinh As DateTime)
        Me.strMSBN = strMSBN
        Me.strMaLoaiGioiTinh = strMaLoaiGioiTinh
        Me.strHoTen = strHoten
        Me.strDiaChi = strDiaChi
        Me.dateNamSinh = dateNamSinh
    End Sub
    Property MSBN() As String
        Get
            Return strMSBN
        End Get
        Set(ByVal Value As String)
            strMSBN = Value
        End Set
    End Property
    Property LoaiGioiTinh() As String
        Get
            Return strMaLoaiGioiTinh
        End Get
        Set(ByVal Value As String)
            strMaLoaiGioiTinh = Value
        End Set
    End Property
    Property HoTen() As String
        Get
            Return strHoTen
        End Get
        Set(ByVal Value As String)
            strHoTen = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property
    Property NamSinh() As DateTime
        Get
            Return dateNamSinh

        End Get
        Set(ByVal Value As DateTime)
            dateNamSinh = Value
        End Set
    End Property
End Class
