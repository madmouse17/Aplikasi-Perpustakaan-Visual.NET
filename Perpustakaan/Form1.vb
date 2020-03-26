Public Class Form1

    Private Sub DataBukuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBukuToolStripMenuItem.Click
        form2.show()
    End Sub

    Private Sub DataBukuToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBukuToolStripMenuItem1.Click
        Form3.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PenyewaanBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenyewaanBarangToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub PengembalianBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengembalianBarangToolStripMenuItem.Click
        Pengembalian_buku.Show()
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        Laporan.ShowDialog()
    End Sub
End Class
