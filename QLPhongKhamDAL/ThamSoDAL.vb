Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPhongKhamDTO
Imports Utility

Public Class ThamSoDAL
    Private connectionString As String

    Public Sub New()

        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function SelectQuyDinh(ths As ThamSoDTO) As Result
        ths.SoLanKhamToiDa = 40
        ' Lay Tham So se reader.Read() se khac voi List
        Dim query As String = String.Empty
        query &= " SELECT [solankhamtoida]"
        query &= " FROM [ThamSo]"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            ths.SoLanKhamToiDa = reader("solankhamtoida")

                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy quy định the không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
