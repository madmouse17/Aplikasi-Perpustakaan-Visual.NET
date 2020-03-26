Imports System.Data.Odbc
Public Class Form2
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Dim Gender As String
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=member"
        con.Open()
    End Sub
    Sub simpan()
        koneksi()
        If RadioButton1.Checked = True Then
            Gender = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            Gender = RadioButton2.Text
        End If
        Dim sql As String = "insert into dbmember values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & Gender & "','" & TextBox3.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub edit()
        koneksi()
        If RadioButton1.Checked = True Then
            Gender = "Pria"
        ElseIf RadioButton2.Checked = True Then
            Gender = "Wanita"
        End If
        Dim update As String = "update dbmember set kd_member='" & TextBox1.Text & "', nama='" & TextBox2.Text & "',j_kelamin='" & Gender & "',alamat='" & TextBox3.Text & "' where kd_member='" & TextBox1.Text & "'"
        cmd = New OdbcCommand(update, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Mengedit data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Mengedit data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from dbmember order by kd_member asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        simpan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Member yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan kd_member=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from dbmember where kd_member='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        edit()
        tampil()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex

        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridView1.Rows(index)

        TextBox1.Text = selectedrow.Cells(0).Value.ToString()
        TextBox2.Text = selectedrow.Cells(1).Value.ToString()
        If selectedrow.Cells(2).Value.ToString = "L" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        TextBox3.Text = selectedrow.Cells(3).Value.ToString()

    End Sub
End Class