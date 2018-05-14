Public Class FrmMainGUI
    Private Sub ThêmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmToolStripMenuItem.Click
        Dim frmBN As FrmThemBenhNhanGUI = New FrmThemBenhNhanGUI()
        frmBN.MdiParent = Me
        frmBN.Show()
    End Sub
End Class
