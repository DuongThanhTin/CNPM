Imports QLPhongKhamDAL
Imports QLPhongKhamDTO
Imports Utility

Public Class BenhNhanBUS
    Private bnDAL As BenhNhanDAL
    Public Sub New()
        bnDAL = New BenhNhanDAL()
    End Sub
    Public Sub New(connectionString As String)
        bnDAL = New BenhNhanDAL(connectionString)
    End Sub
    Public Function isValueName(bn As BenhNhanDTO) As Boolean
        If (bn.HoTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(bn As BenhNhanDTO) As Result
        ' Data
        Dim thamso As ThamSoDTO
        thamso = New ThamSoDTO()
        Dim thsDAL = New ThamSoDAL()
        Dim result = thsDAL.SelectQuyDinh(thamso)
        If (result.FlagResult = False) Then
            Return result
        End If ' Xét Đk 
        'Dim age = DateTime.Now.Year - dg.NgaySinh.Year
        'If (age > thamso.TuoiToiDa Or age < thamso.TuoiToiThieu) Then
        '    'result.ApplicationMessage = "tuoi khong hop le"
        '    Return New Result(False)
        'End If

        ' insert to DataBase
        Return bnDAL.insert(bn)
    End Function

    'Test
    Public Function buildMSBN(ByRef nextMsBN As String) As Result
        Return bnDAL.buildMSDG(nextMsBN)
    End Function
End Class
