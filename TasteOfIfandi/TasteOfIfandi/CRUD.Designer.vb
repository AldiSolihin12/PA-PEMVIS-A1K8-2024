<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUD
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
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.LabelUtama = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPending = New System.Windows.Forms.Button()
        Me.btnVerif = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnTopResep = New System.Windows.Forms.Button()
        Me.btnResepSy = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTerima = New System.Windows.Forms.Button()
        Me.btnTolak = New System.Windows.Forms.Button()
        Me.txtNama = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetail.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDetail.ForeColor = System.Drawing.Color.Black
        Me.btnDetail.Location = New System.Drawing.Point(184, 568)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(110, 38)
        Me.btnDetail.TabIndex = 17
        Me.btnDetail.Text = "Lihat Detail"
        Me.btnDetail.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(184, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cari"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.ForeColor = System.Drawing.Color.Black
        Me.btnHapus.Location = New System.Drawing.Point(532, 568)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(110, 38)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        Me.btnHapus.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(416, 568)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(110, 38)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        Me.btnEdit.Visible = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(242, 174)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(292, 20)
        Me.txtCari.TabIndex = 13
        '
        'LabelUtama
        '
        Me.LabelUtama.AutoSize = True
        Me.LabelUtama.BackColor = System.Drawing.Color.Transparent
        Me.LabelUtama.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.LabelUtama.ForeColor = System.Drawing.Color.Black
        Me.LabelUtama.Location = New System.Drawing.Point(179, 104)
        Me.LabelUtama.Name = "LabelUtama"
        Me.LabelUtama.Size = New System.Drawing.Size(215, 51)
        Me.LabelUtama.TabIndex = 4
        Me.LabelUtama.Text = "LIST RESEP"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(300, 568)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(110, 38)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Black
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(845, 566)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 38)
        Me.btnLogout.TabIndex = 18
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.btnPending)
        Me.Panel2.Controls.Add(Me.btnVerif)
        Me.Panel2.Controls.Add(Me.btnList)
        Me.Panel2.Controls.Add(Me.btnTopResep)
        Me.Panel2.Controls.Add(Me.btnResepSy)
        Me.Panel2.Location = New System.Drawing.Point(-6, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 549)
        Me.Panel2.TabIndex = 13
        '
        'btnPending
        '
        Me.btnPending.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnPending.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPending.FlatAppearance.BorderSize = 0
        Me.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPending.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPending.ForeColor = System.Drawing.Color.Black
        Me.btnPending.Location = New System.Drawing.Point(3, 177)
        Me.btnPending.Name = "btnPending"
        Me.btnPending.Size = New System.Drawing.Size(158, 51)
        Me.btnPending.TabIndex = 25
        Me.btnPending.Text = "Pending Resep"
        Me.btnPending.UseVisualStyleBackColor = False
        Me.btnPending.Visible = False
        '
        'btnVerif
        '
        Me.btnVerif.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnVerif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerif.FlatAppearance.BorderSize = 0
        Me.btnVerif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerif.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnVerif.ForeColor = System.Drawing.Color.Black
        Me.btnVerif.Location = New System.Drawing.Point(3, 177)
        Me.btnVerif.Name = "btnVerif"
        Me.btnVerif.Size = New System.Drawing.Size(158, 51)
        Me.btnVerif.TabIndex = 24
        Me.btnVerif.Text = "Verifikasi"
        Me.btnVerif.UseVisualStyleBackColor = False
        Me.btnVerif.Visible = False
        '
        'btnList
        '
        Me.btnList.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnList.FlatAppearance.BorderSize = 0
        Me.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnList.ForeColor = System.Drawing.Color.Black
        Me.btnList.Location = New System.Drawing.Point(3, 24)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(158, 51)
        Me.btnList.TabIndex = 23
        Me.btnList.Text = "List Resep"
        Me.btnList.UseVisualStyleBackColor = False
        '
        'btnTopResep
        '
        Me.btnTopResep.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnTopResep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTopResep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTopResep.FlatAppearance.BorderSize = 0
        Me.btnTopResep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopResep.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTopResep.ForeColor = System.Drawing.Color.Black
        Me.btnTopResep.Location = New System.Drawing.Point(3, 126)
        Me.btnTopResep.Name = "btnTopResep"
        Me.btnTopResep.Size = New System.Drawing.Size(158, 51)
        Me.btnTopResep.TabIndex = 21
        Me.btnTopResep.Text = "Top Resep"
        Me.btnTopResep.UseVisualStyleBackColor = False
        '
        'btnResepSy
        '
        Me.btnResepSy.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnResepSy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResepSy.FlatAppearance.BorderSize = 0
        Me.btnResepSy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResepSy.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnResepSy.ForeColor = System.Drawing.Color.Black
        Me.btnResepSy.Location = New System.Drawing.Point(3, 75)
        Me.btnResepSy.Name = "btnResepSy"
        Me.btnResepSy.Size = New System.Drawing.Size(158, 51)
        Me.btnResepSy.TabIndex = 20
        Me.btnResepSy.Text = "Resep Saya"
        Me.btnResepSy.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-6, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 83)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TasteOfIfandi.My.Resources.Resources.ifandi
        Me.PictureBox1.Location = New System.Drawing.Point(14, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(188, 212)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(767, 339)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'btnTerima
        '
        Me.btnTerima.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnTerima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTerima.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTerima.ForeColor = System.Drawing.Color.Black
        Me.btnTerima.Location = New System.Drawing.Point(416, 568)
        Me.btnTerima.Name = "btnTerima"
        Me.btnTerima.Size = New System.Drawing.Size(110, 38)
        Me.btnTerima.TabIndex = 21
        Me.btnTerima.Text = "Terima"
        Me.btnTerima.UseVisualStyleBackColor = False
        Me.btnTerima.Visible = False
        '
        'btnTolak
        '
        Me.btnTolak.BackColor = System.Drawing.Color.Black
        Me.btnTolak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTolak.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTolak.ForeColor = System.Drawing.Color.White
        Me.btnTolak.Location = New System.Drawing.Point(532, 568)
        Me.btnTolak.Name = "btnTolak"
        Me.btnTolak.Size = New System.Drawing.Size(110, 38)
        Me.btnTolak.TabIndex = 14
        Me.btnTolak.Text = "Tolak"
        Me.btnTolak.UseVisualStyleBackColor = False
        Me.btnTolak.Visible = False
        '
        'txtNama
        '
        Me.txtNama.AutoSize = True
        Me.txtNama.BackColor = System.Drawing.Color.Transparent
        Me.txtNama.Font = New System.Drawing.Font("Poppins", 22.0!, System.Drawing.FontStyle.Bold)
        Me.txtNama.ForeColor = System.Drawing.Color.White
        Me.txtNama.Location = New System.Drawing.Point(829, 19)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(118, 53)
        Me.txtNama.TabIndex = 22
        Me.txtNama.Text = "NAMA"
        '
        'CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(977, 628)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LabelUtama)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnTerima)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTolak)
        Me.Name = "CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelUtama As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnTopResep As System.Windows.Forms.Button
    Friend WithEvents btnResepSy As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnVerif As System.Windows.Forms.Button
    Friend WithEvents btnPending As System.Windows.Forms.Button
    Friend WithEvents btnTerima As System.Windows.Forms.Button
    Friend WithEvents btnTolak As System.Windows.Forms.Button
    Friend WithEvents txtNama As System.Windows.Forms.Label
End Class
