Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms
Public Class Form5
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
        Dim sql As String = "insert into sewa values('" & Form4.TextBox7.Text & "','" & Form4.ComboBox1.Text & "','" & Form4.ComboBox2.Text & "','" & Form4.TextBox6.Text & "','" & Form4.DateTimePicker1.Text & "','" & Form4.DateTimePicker2.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id As New ReportParameter("id", Form4.TextBox7.Text)
        Me.ReportViewer1.LocalReport.SetParameters(id)
        Dim member As New ReportParameter("member", Form4.ComboBox1.Text)
        Me.ReportViewer1.LocalReport.SetParameters(member)
        Dim buku As New ReportParameter("buku", Form4.ComboBox2.Text)
        Me.ReportViewer1.LocalReport.SetParameters(buku)
        Dim jumlah As New ReportParameter("jumlah", Form4.TextBox6.Text)
        Me.ReportViewer1.LocalReport.SetParameters(jumlah)
        Dim sewa As New ReportParameter("sewa", Form4.DateTimePicker1.Text)
        Me.ReportViewer1.LocalReport.SetParameters(sewa)
        Dim kembali As New ReportParameter("kembali", Form4.DateTimePicker2.Text)
        Me.ReportViewer1.LocalReport.SetParameters(kembali)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class