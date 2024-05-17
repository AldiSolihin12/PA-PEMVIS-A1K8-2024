<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetail))
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnKomen = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtDeskripsi = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bintang1OFF = New System.Windows.Forms.PictureBox()
        Me.bintang2OFF = New System.Windows.Forms.PictureBox()
        Me.bintang3OFF = New System.Windows.Forms.PictureBox()
        Me.bintang4OFF = New System.Windows.Forms.PictureBox()
        Me.bintang5OFF = New System.Windows.Forms.PictureBox()
        Me.bintang5 = New System.Windows.Forms.PictureBox()
        Me.bintang4 = New System.Windows.Forms.PictureBox()
        Me.bintang3 = New System.Windows.Forms.PictureBox()
        Me.bintang2 = New System.Windows.Forms.PictureBox()
        Me.bintang1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang1OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang2OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang3OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang4OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang5OFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bintang1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Black
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(547, 8)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(110, 38)
        Me.btnKembali.TabIndex = 37
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.btnKomen)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Controls.Add(Me.btnKembali)
        Me.Panel2.Location = New System.Drawing.Point(1, 701)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(669, 56)
        Me.Panel2.TabIndex = 74
        '
        'btnKomen
        '
        Me.btnKomen.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnKomen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKomen.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKomen.ForeColor = System.Drawing.Color.Black
        Me.btnKomen.Location = New System.Drawing.Point(279, 8)
        Me.btnKomen.Name = "btnKomen"
        Me.btnKomen.Size = New System.Drawing.Size(128, 38)
        Me.btnKomen.TabIndex = 35
        Me.btnKomen.Text = "Beri Penilaian"
        Me.btnKomen.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.Black
        Me.btnSimpan.Location = New System.Drawing.Point(413, 8)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(128, 38)
        Me.btnSimpan.TabIndex = 36
        Me.btnSimpan.Text = "Download Resep"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.AutoSize = True
        Me.txtDeskripsi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtDeskripsi.Location = New System.Drawing.Point(287, 191)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(83, 19)
        Me.txtDeskripsi.TabIndex = 68
        Me.txtDeskripsi.Text = "Ini Deskripsi"
        '
        'txtJudul
        '
        Me.txtJudul.AutoSize = True
        Me.txtJudul.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtJudul.Location = New System.Drawing.Point(287, 160)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(70, 21)
        Me.txtJudul.TabIndex = 67
        Me.txtJudul.Text = "Ini Judul"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(287, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Langkah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(287, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 21)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Bahan"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(291, 254)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(346, 82)
        Me.ListBox1.TabIndex = 75
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(291, 371)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(346, 82)
        Me.ListBox2.TabIndex = 76
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 105)
        Me.Panel1.TabIndex = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TasteOfIfandi.My.Resources.Resources.ifandi
        Me.PictureBox2.Location = New System.Drawing.Point(11, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'bintang1OFF
        '
        Me.bintang1OFF.Image = Global.TasteOfIfandi.My.Resources.Resources.bintangOFF
        Me.bintang1OFF.Location = New System.Drawing.Point(291, 120)
        Me.bintang1OFF.Name = "bintang1OFF"
        Me.bintang1OFF.Size = New System.Drawing.Size(36, 37)
        Me.bintang1OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang1OFF.TabIndex = 96
        Me.bintang1OFF.TabStop = False
        Me.bintang1OFF.Visible = False
        '
        'bintang2OFF
        '
        Me.bintang2OFF.Image = Global.TasteOfIfandi.My.Resources.Resources.bintangOFF
        Me.bintang2OFF.Location = New System.Drawing.Point(333, 120)
        Me.bintang2OFF.Name = "bintang2OFF"
        Me.bintang2OFF.Size = New System.Drawing.Size(36, 37)
        Me.bintang2OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang2OFF.TabIndex = 95
        Me.bintang2OFF.TabStop = False
        Me.bintang2OFF.Visible = False
        '
        'bintang3OFF
        '
        Me.bintang3OFF.Image = Global.TasteOfIfandi.My.Resources.Resources.bintangOFF
        Me.bintang3OFF.Location = New System.Drawing.Point(375, 120)
        Me.bintang3OFF.Name = "bintang3OFF"
        Me.bintang3OFF.Size = New System.Drawing.Size(36, 37)
        Me.bintang3OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang3OFF.TabIndex = 94
        Me.bintang3OFF.TabStop = False
        Me.bintang3OFF.Visible = False
        '
        'bintang4OFF
        '
        Me.bintang4OFF.Image = Global.TasteOfIfandi.My.Resources.Resources.bintangOFF
        Me.bintang4OFF.Location = New System.Drawing.Point(417, 120)
        Me.bintang4OFF.Name = "bintang4OFF"
        Me.bintang4OFF.Size = New System.Drawing.Size(36, 37)
        Me.bintang4OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang4OFF.TabIndex = 93
        Me.bintang4OFF.TabStop = False
        Me.bintang4OFF.Visible = False
        '
        'bintang5OFF
        '
        Me.bintang5OFF.Image = Global.TasteOfIfandi.My.Resources.Resources.bintangOFF
        Me.bintang5OFF.Location = New System.Drawing.Point(459, 120)
        Me.bintang5OFF.Name = "bintang5OFF"
        Me.bintang5OFF.Size = New System.Drawing.Size(36, 37)
        Me.bintang5OFF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang5OFF.TabIndex = 92
        Me.bintang5OFF.TabStop = False
        Me.bintang5OFF.Visible = False
        '
        'bintang5
        '
        Me.bintang5.Image = Global.TasteOfIfandi.My.Resources.Resources.bintang
        Me.bintang5.Location = New System.Drawing.Point(459, 120)
        Me.bintang5.Name = "bintang5"
        Me.bintang5.Size = New System.Drawing.Size(36, 37)
        Me.bintang5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang5.TabIndex = 91
        Me.bintang5.TabStop = False
        Me.bintang5.Visible = False
        '
        'bintang4
        '
        Me.bintang4.Image = Global.TasteOfIfandi.My.Resources.Resources.bintang
        Me.bintang4.Location = New System.Drawing.Point(417, 120)
        Me.bintang4.Name = "bintang4"
        Me.bintang4.Size = New System.Drawing.Size(36, 37)
        Me.bintang4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang4.TabIndex = 90
        Me.bintang4.TabStop = False
        Me.bintang4.Visible = False
        '
        'bintang3
        '
        Me.bintang3.Image = Global.TasteOfIfandi.My.Resources.Resources.bintang
        Me.bintang3.Location = New System.Drawing.Point(375, 120)
        Me.bintang3.Name = "bintang3"
        Me.bintang3.Size = New System.Drawing.Size(36, 37)
        Me.bintang3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang3.TabIndex = 89
        Me.bintang3.TabStop = False
        Me.bintang3.Visible = False
        '
        'bintang2
        '
        Me.bintang2.Image = Global.TasteOfIfandi.My.Resources.Resources.bintang
        Me.bintang2.Location = New System.Drawing.Point(333, 120)
        Me.bintang2.Name = "bintang2"
        Me.bintang2.Size = New System.Drawing.Size(36, 37)
        Me.bintang2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang2.TabIndex = 88
        Me.bintang2.TabStop = False
        Me.bintang2.Visible = False
        '
        'bintang1
        '
        Me.bintang1.Image = Global.TasteOfIfandi.My.Resources.Resources.bintang
        Me.bintang1.Location = New System.Drawing.Point(291, 120)
        Me.bintang1.Name = "bintang1"
        Me.bintang1.Size = New System.Drawing.Size(36, 37)
        Me.bintang1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bintang1.TabIndex = 87
        Me.bintang1.TabStop = False
        Me.bintang1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(26, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 320)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 475)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(611, 195)
        Me.DataGridView1.TabIndex = 97
        '
        'FormDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(670, 759)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bintang1OFF)
        Me.Controls.Add(Me.bintang2OFF)
        Me.Controls.Add(Me.bintang3OFF)
        Me.Controls.Add(Me.bintang4OFF)
        Me.Controls.Add(Me.bintang5OFF)
        Me.Controls.Add(Me.bintang5)
        Me.Controls.Add(Me.bintang4)
        Me.Controls.Add(Me.bintang3)
        Me.Controls.Add(Me.bintang2)
        Me.Controls.Add(Me.bintang1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtDeskripsi)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDetail"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang1OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang2OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang3OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang4OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang5OFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bintang1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtDeskripsi As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents bintang1OFF As System.Windows.Forms.PictureBox
    Friend WithEvents bintang2OFF As System.Windows.Forms.PictureBox
    Friend WithEvents bintang3OFF As System.Windows.Forms.PictureBox
    Friend WithEvents bintang4OFF As System.Windows.Forms.PictureBox
    Friend WithEvents bintang5OFF As System.Windows.Forms.PictureBox
    Friend WithEvents bintang5 As System.Windows.Forms.PictureBox
    Friend WithEvents bintang4 As System.Windows.Forms.PictureBox
    Friend WithEvents bintang3 As System.Windows.Forms.PictureBox
    Friend WithEvents bintang2 As System.Windows.Forms.PictureBox
    Friend WithEvents bintang1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnKomen As System.Windows.Forms.Button
End Class
