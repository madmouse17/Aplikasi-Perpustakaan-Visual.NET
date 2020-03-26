<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataBUku = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Master = New System.Windows.Forms.MenuStrip()
        Me.PenyewaanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Master.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataBUku
        '
        Me.DataBUku.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataBukuToolStripMenuItem1, Me.ToolStripMenuItem2, Me.KeluarToolStripMenuItem})
        Me.DataBUku.Name = "DataBUku"
        Me.DataBUku.Size = New System.Drawing.Size(55, 20)
        Me.DataBUku.Text = "Master"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DataBukuToolStripMenuItem.Text = "Data Member"
        '
        'DataBukuToolStripMenuItem1
        '
        Me.DataBukuToolStripMenuItem1.Name = "DataBukuToolStripMenuItem1"
        Me.DataBukuToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.DataBukuToolStripMenuItem1.Text = "Data Buku"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem2.Text = "--------------------"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Master
        '
        Me.Master.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBUku, Me.PenyewaanBarangToolStripMenuItem, Me.PengembalianBarangToolStripMenuItem, Me.LAPORANToolStripMenuItem})
        Me.Master.Location = New System.Drawing.Point(0, 0)
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(524, 24)
        Me.Master.TabIndex = 0
        Me.Master.Text = "Master"
        '
        'PenyewaanBarangToolStripMenuItem
        '
        Me.PenyewaanBarangToolStripMenuItem.Name = "PenyewaanBarangToolStripMenuItem"
        Me.PenyewaanBarangToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.PenyewaanBarangToolStripMenuItem.Text = "Penyewaan Barang"
        '
        'PengembalianBarangToolStripMenuItem
        '
        Me.PengembalianBarangToolStripMenuItem.Name = "PengembalianBarangToolStripMenuItem"
        Me.PengembalianBarangToolStripMenuItem.Size = New System.Drawing.Size(135, 20)
        Me.PengembalianBarangToolStripMenuItem.Text = "Pengembalian Barang"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Perpustakaan.My.Resources.Resources.Perpustakaan
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(524, 468)
        Me.Controls.Add(Me.Master)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Master
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN MENU"
        Me.Master.ResumeLayout(False)
        Me.Master.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataBUku As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Master As System.Windows.Forms.MenuStrip
    Friend WithEvents DataBukuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenyewaanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
