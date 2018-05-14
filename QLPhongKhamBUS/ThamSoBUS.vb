Imports QLPhongKhamDAL

Public Class ThamSoBUS
    Private qdDAL As ThamSoDAL
    Public Sub New()
        qdDAL = New ThamSoDAL()
    End Sub
    Public Sub New(connectionString As String)
        qdDAL = New ThamSoDAL(connectionString)
    End Sub

End Class
