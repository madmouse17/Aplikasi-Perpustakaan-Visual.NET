Imports System.Data.Odbc
Public Class Pengembalian_buku
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=sewa1"
        con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tbkembali values('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox6.Text & "')"
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
        Dim sql As String = "update tbkembali set id='" & ComboBox1.Text & "',kd_member='" & TextBox1.Text & "',kd_buku='" & TextBox2.Text & "',jumlah='" & TextBox3.Text & "',tgl_pinjam='" & DateTimePicker1.Text & "',tgl_pengembalian='" & DateTimePicker2.Text & "',denda='" & TextBox6.Text & "' where id='" & ComboBox1.Text & "'"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbkembali order by id asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Sub pinjam()
        cmd = New OdbcCommand("select id from sewa", con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("id"))
        Loop
    End Sub
    Private Sub Pengembalian_buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        pinjam()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from sewa where id='" & ComboBox1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox1.Text = dr.Item("kd_member")
            TextBox2.Text = dr.Item("kd_buku")
            TextBox3.Text = dr.Item("jumlah")
            DateTimePicker1.Value = dr.Item("tgl_kembali")

        Else
            MsgBox("ID Pinjam tidak ada")
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim awal As Date = Convert.ToDateTime(DateTimePicker1.Value)
        Dim akhir As Date = Convert.ToDateTime(DateTimePicker2.Value)
        Dim hitung As TimeSpan = akhir.Subtract(awal)
        TextBox4.Text = FormatNumber(hitung.TotalDays, 0)
        If TextBox4.Text <= 0 Then
            TextBox4.Text = "0"
        End If
        Dim kembali As Integer
        Dim denda As Integer
        Dim buku As Integer
        buku = CInt(TextBox3.Text)
        kembali = CInt(TextBox4.Text)
        denda = kembali * buku * 5000
        TextBox6.Text = "" & denda

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
        tampil()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        ComboBox1.Text = "--pilih--"
        ComboBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tampil()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex

        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridView1.Rows(index)

        ComboBox1.Text = selectedrow.Cells(0).Value.ToString()
        TextBox1.Text = selectedrow.Cells(1).Value.ToString()
        TextBox2.Text = selectedrow.Cells(2).Value.ToString()
        TextBox3.Text = selectedrow.Cells(3).Value.ToString()
        DateTimePicker1.Text = selectedrow.Cells(4).Value.ToString()
        DateTimePicker2.Text = selectedrow.Cells(5).Value.ToString()
        TextBox6.Text = selectedrow.Cells(6).Value.ToString()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        edit()
        tampil()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class