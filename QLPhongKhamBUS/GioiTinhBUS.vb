Imports QLPhongKhamDAL
Imports QLPhongKhamDTO
Imports Utility

Public Class GioiTinhBUS
    Private loaiGTDAL As GioiTinhDAL
    Public Sub New()
        loaiGTDAL = New GioiTinhDAL()

    End Sub
    Public Sub New(connectionString As String)
        loaiGTDAL = New GioiTinhDAL(connectionString)
    End Sub
    'Public Function isValidName(loai As LoaiDocGiaDTO) As Boolean
    '    If (loai.TenLoai.Length < 1) Then
    '        Return False
    '    End If
    '    Return True
    'End Function

    Public Function selectALL(ByRef listLoaiGT As List(Of GioiTinhDTO)) As Result
        Return loaiGTDAL.selectALL(listLoaiGT)
    End Function
End Class
