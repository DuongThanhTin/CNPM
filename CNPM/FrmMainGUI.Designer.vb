<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainGUI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchKhámBệnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.QuarToolStripMenuItem, Me.LậpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'QuarToolStripMenuItem
        '
        Me.QuarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmToolStripMenuItem})
        Me.QuarToolStripMenuItem.Name = "QuarToolStripMenuItem"
        Me.QuarToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.QuarToolStripMenuItem.Text = "Quản Lý Bệnh Nhân"
        '
        'ThêmToolStripMenuItem
        '
        Me.ThêmToolStripMenuItem.Name = "ThêmToolStripMenuItem"
        Me.ThêmToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ThêmToolStripMenuItem.Text = "Thêm Bệnh Nhân"
        '
        'LậpToolStripMenuItem
        '
        Me.LậpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DanhSáchKhámBệnhToolStripMenuItem})
        Me.LậpToolStripMenuItem.Name = "LậpToolStripMenuItem"
        Me.LậpToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.LậpToolStripMenuItem.Text = "Những Thông Tin Cần Thiết"
        '
        'DanhSáchKhámBệnhToolStripMenuItem
        '
        Me.DanhSáchKhámBệnhToolStripMenuItem.Name = "DanhSáchKhámBệnhToolStripMenuItem"
        Me.DanhSáchKhámBệnhToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.DanhSáchKhámBệnhToolStripMenuItem.Text = "Danh Sách Khám Bệnh"
        '
        'FrmMainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 953)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMainGUI"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSáchKhámBệnhToolStripMenuItem As ToolStripMenuItem
End Class
