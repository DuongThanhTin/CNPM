<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmThemBenhNhanGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaSo = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.cbLoaiGT = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoBN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateNgayKB = New System.Windows.Forms.DateTimePicker()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hồ Sơ Bệnh Nhân"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Số Bệnh Nhân:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Họ Tên Bệnh Nhân:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giới Tính:"
        '
        'txtMaSo
        '
        Me.txtMaSo.Location = New System.Drawing.Point(162, 94)
        Me.txtMaSo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSo.Name = "txtMaSo"
        Me.txtMaSo.ReadOnly = True
        Me.txtMaSo.Size = New System.Drawing.Size(215, 22)
        Me.txtMaSo.TabIndex = 8
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(162, 201)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(295, 22)
        Me.txtHoTen.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ngày Sinh:"
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(629, 89)
        Me.dtpNgaySinh.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(265, 22)
        Me.dtpNgaySinh.TabIndex = 14
        Me.dtpNgaySinh.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(532, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Địa Chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(629, 201)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(295, 22)
        Me.txtDiaChi.TabIndex = 16
        '
        'cbLoaiGT
        '
        Me.cbLoaiGT.FormattingEnabled = True
        Me.cbLoaiGT.Location = New System.Drawing.Point(162, 321)
        Me.cbLoaiGT.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLoaiGT.Name = "cbLoaiGT"
        Me.cbLoaiGT.Size = New System.Drawing.Size(233, 24)
        Me.cbLoaiGT.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(532, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Số Bệnh Nhân Đã ĐK Khám:"
        '
        'txtSoBN
        '
        Me.txtSoBN.Location = New System.Drawing.Point(745, 316)
        Me.txtSoBN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoBN.Name = "txtSoBN"
        Me.txtSoBN.ReadOnly = True
        Me.txtSoBN.Size = New System.Drawing.Size(121, 22)
        Me.txtSoBN.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Ngày Khám Bệnh:"
        '
        'dateNgayKB
        '
        Me.dateNgayKB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateNgayKB.Location = New System.Drawing.Point(434, 393)
        Me.dateNgayKB.Margin = New System.Windows.Forms.Padding(4)
        Me.dateNgayKB.Name = "dateNgayKB"
        Me.dateNgayKB.Size = New System.Drawing.Size(265, 22)
        Me.dateNgayKB.TabIndex = 21
        Me.dateNgayKB.Value = New Date(2003, 3, 28, 7, 28, 0, 0)
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(406, 468)
        Me.btnNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(100, 28)
        Me.btnNhap.TabIndex = 22
        Me.btnNhap.Text = "Nhập"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'FrmThemBenhNhanGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 584)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.dateNgayKB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSoBN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbLoaiGT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaSo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmThemBenhNhanGUI"
        Me.Text = "FrmThemBenhNhan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaSo As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents cbLoaiGT As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoBN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dateNgayKB As DateTimePicker
    Friend WithEvents btnNhap As Button
End Class
