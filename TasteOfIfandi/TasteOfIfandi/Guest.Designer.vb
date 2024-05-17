<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnTopResep = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.LabelUtama = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(190, 213)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(767, 339)
        Me.FlowLayoutPanel1.TabIndex = 33
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.btnList)
        Me.Panel2.Controls.Add(Me.btnTopResep)
        Me.Panel2.Location = New System.Drawing.Point(-4, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 549)
        Me.Panel2.TabIndex = 24
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
        Me.btnList.TabIndex = 4
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
        Me.btnTopResep.Location = New System.Drawing.Point(3, 75)
        Me.btnTopResep.Name = "btnTopResep"
        Me.btnTopResep.Size = New System.Drawing.Size(158, 51)
        Me.btnTopResep.TabIndex = 5
        Me.btnTopResep.Text = "Top Resep"
        Me.btnTopResep.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnReg)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLog)
        Me.Panel1.Location = New System.Drawing.Point(-4, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 83)
        Me.Panel1.TabIndex = 23
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.Black
        Me.btnReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReg.FlatAppearance.BorderSize = 0
        Me.btnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReg.ForeColor = System.Drawing.Color.White
        Me.btnReg.Location = New System.Drawing.Point(753, 3)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(114, 80)
        Me.btnReg.TabIndex = 2
        Me.btnReg.Text = "REGISTER"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnLog
        '
        Me.btnLog.BackColor = System.Drawing.Color.Black
        Me.btnLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLog.FlatAppearance.BorderSize = 0
        Me.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Location = New System.Drawing.Point(867, 3)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(114, 80)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "LOGIN"
        Me.btnLog.UseVisualStyleBackColor = False
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Black
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Location = New System.Drawing.Point(847, 567)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(110, 38)
        Me.btnKembali.TabIndex = 9
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'LabelUtama
        '
        Me.LabelUtama.AutoSize = True
        Me.LabelUtama.BackColor = System.Drawing.Color.Transparent
        Me.LabelUtama.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.LabelUtama.ForeColor = System.Drawing.Color.Black
        Me.LabelUtama.Location = New System.Drawing.Point(181, 105)
        Me.LabelUtama.Name = "LabelUtama"
        Me.LabelUtama.Size = New System.Drawing.Size(215, 51)
        Me.LabelUtama.TabIndex = 22
        Me.LabelUtama.Text = "LIST RESEP"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(244, 175)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(292, 20)
        Me.txtCari.TabIndex = 6
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetail.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDetail.ForeColor = System.Drawing.Color.Black
        Me.btnDetail.Location = New System.Drawing.Point(186, 569)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(110, 38)
        Me.btnDetail.TabIndex = 7
        Me.btnDetail.Text = "Lihat Detail"
        Me.btnDetail.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(186, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cari"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(302, 569)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(110, 38)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(977, 628)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.LabelUtama)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambah)
        Me.Name = "Guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guest"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnTopResep As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents LabelUtama As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button
End Class
