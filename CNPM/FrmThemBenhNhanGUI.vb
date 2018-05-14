
Imports QLPhongKhamBUS
Imports QLPhongKhamDTO
Imports Utility

Public Class FrmThemBenhNhanGUI
    Private bnBus As BenhNhanBUS
    Private gtBus As GioiTinhBUS
    Private thsBus As ThamSoBUS

    Private Sub FrmThemBenhNhanGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bnBus = New BenhNhanBUS()
        gtBus = New GioiTinhBUS()
        Dim result As Result
        thsBus = New ThamSoBUS()


        ' Load Danh Sach Benh Nhan
        Dim listLoaiGioiTinh = New List(Of GioiTinhDTO)
        result = gtBus.selectALL(listLoaiGioiTinh)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Đọc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbLoaiGT.DataSource = New BindingSource(listLoaiGioiTinh, String.Empty)
        cbLoaiGT.DisplayMember = "tenloaigioitinh"
        cbLoaiGT.ValueMember = "maloaigioitinh"

        'Load Danh sách Người Lập Thẻ
        'nltBus = New NguoiLapTheBUS()


        'Dim listNTL = New List(Of NguoiLapTheDTO)
        'result = nltBus.selectALL1(listNTL)
        ''If (result.FlagResult = False) Then
        ''    MessageBox.Show("Lấy danh sách Đọc Giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''    System.Console.WriteLine(result.SystemMessage)
        ''    Me.Close()
        ''    Return
        ''End If
        'cbNLT.DataSource = New BindingSource(listNTL, String.Empty)
        'cbNLT.DisplayMember = "tennguoilapthe"
        'cbNLT.ValueMember = "manguoilapthe111"


        ' Set Mã bn
        Dim nextMabn As String
        result = bnBus.buildMSBN(nextMabn)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã đọc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtMaSo.Text = nextMabn
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim benhnhan As BenhNhanDTO
        benhnhan = New BenhNhanDTO()

        'Data
        benhnhan.MSBN = txtMaSo.Text
        benhnhan.HoTen = txtHoTen.Text
        benhnhan.DiaChi = txtDiaChi.Text
        ''docgia.maloaidocgia111 = cbLoaiDG.SelectedValue
        Dim t = CType(cbLoaiGT.SelectedItem, GioiTinhDTO)
        benhnhan.LoaiGioiTinh = t.maloaigioitinh
        benhnhan.NamSinh = dtpNgaySinh.Value

        'Bus
        If (bnBus.isValueName(benhnhan) = False) Then
            MessageBox.Show("Họ Tên không đúng")
            txtHoTen.Focus()
        End If

        'Insert
        Dim result As Result
        result = bnBus.insert(benhnhan)
        If (result.FlagResult = True) Then
            MessageBox.Show("Thêm Đọc Giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextMsdg = "1"
            result = bnBus.buildMSBN(nextMsdg)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã Benh Nhan không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtMaSo.Text = nextMsdg
            txtDiaChi.Text = String.Empty
            txtHoTen.Text = String.Empty
            '  cbLoaiDG.Text = String.Empty

        Else
            MessageBox.Show("Thêm Beenh Nhan không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class