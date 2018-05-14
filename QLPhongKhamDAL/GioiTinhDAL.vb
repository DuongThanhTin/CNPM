Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPhongKhamDTO
Imports Utility

Public Class GioiTinhDAL
    Private connectionString As String

    Public Sub New()

        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listLoaigt As List(Of GioiTinhDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [maloaigioitinh],[tenloaigioitinh]"
        query &= "FROM [GioiTinh]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
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
                        listLoaigt.Clear()
                        While reader.Read()
                            listLoaigt.Add(New GioiTinhDTO(reader("maloaigioitinh"), reader("tenloaigioitinh")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả Loai gioi tinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
