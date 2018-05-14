Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPhongKhamDTO
Imports Utility

Public Class BenhNhanDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMSDG(ByRef nextMsDG As String) As Result
        nextMsDG = String.Empty
        Dim query As String = String.Empty
        query &= " Select Top 1 [masobenhnhan]"
        query &= "From [BenhNhan]"
        query &= "Order By [masobenhnhan] DESC"

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
                    Dim msOnDB As String
                    msOnDB = Nothing

                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("masobenhnhan")
                        End While
                    End If

                    If (msOnDB <> Nothing) Then
                        Dim currentNumber As Integer
                        Integer.TryParse(msOnDB.Remove(0, 2), currentNumber)

                        Dim strNextNumber = (currentNumber + 1).ToString()
                        While (strNextNumber.Count < 5)
                            strNextNumber = "0" + strNextNumber
                        End While
                        nextMsDG = "MSBN" + strNextNumber
                        System.Console.WriteLine(nextMsDG)
                    Else
                        nextMsDG = "MSBN001"
                    End If
                    'nextMsDG = msOnDB + 1
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Bệnh Nhân kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(bn As BenhNhanDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [BenhNhan] ([masobenhnhan]
      ,[hoten]
      ,[maloaigioitinh]
      ,[diachi]
      ,[namsinh]"
        query &= "VALUES (@masobenhnhan,@hoten,@maloaigioitinh,@diachi,@namsinh)"
        'get MSHS
        Dim nextMsbn = "1"
        buildMSDG(nextMsbn)
        bn.MSBN = nextMsbn

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@masobenhnhan", bn.MSBN)
                    .Parameters.AddWithValue("@hoten", bn.HoTen)
                    .Parameters.AddWithValue("@maloaigioitinh", bn.LoaiGioiTinh)
                    .Parameters.AddWithValue("@diachi", bn.DiaChi)
                    .Parameters.AddWithValue("@namsinh", bn.NamSinh)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Bệnh Nhân không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
