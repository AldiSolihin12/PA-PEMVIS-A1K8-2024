Imports MySql.Data.MySqlClient

Public Class Guest
    Private LastClickedButton As Button = Nothing

    Private Sub Guest_Load(sender As Object, e As EventArgs) Handles Me.Load
        koneksi()
        tampilkan()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        LandingPage.Show()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Me.Close()
        FormRegister.Show()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Sub tampilkan()
        ClearFlowLayoutPanel()
        CMD = New MySqlCommand("SELECT tbuser.username, tbresep.judul, tbresep.id_resep, tbresep.gambar, tbresep.status, tbuser.id, AVG(tbkomen.rating) AS avg_rating " &
                      "FROM tbresep " &
                      "INNER JOIN tbuser ON tbresep.id_user = tbuser.id " &
                      "LEFT JOIN tbkomen ON tbresep.id_resep = tbkomen.id_resep " &
                      "WHERE tbresep.status = 'Terverifikasi' " &
                      "GROUP BY tbresep.id_resep, tbuser.username, tbresep.judul, tbresep.gambar, tbresep.status, tbuser.id ", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim id As Integer = RD.GetInt32("id_resep")
            Dim id_user As Integer = RD.GetInt32("id")
            Dim nama_user As String = RD.GetString("username")
            Dim judul As String = RD.GetString("judul")
            Dim pathGambar As String = RD.GetString("gambar")
            Dim avgRating As Double

            If RD.IsDBNull(RD.GetOrdinal("avg_rating")) Then
                avgRating = 0
            Else
                avgRating = Math.Round(RD.GetDouble("avg_rating"), 1)
            End If

            AddCard(id, id_user, judul, nama_user, avgRating, pathGambar)
        End While
        RD.Close()
    End Sub

    Private Sub AddCard(id As Integer, id_user As Integer, judul As String, nama_user As String, avgRating As Double, pathGambar As String)
        Dim cardButton As New Button With {
            .Width = 200,
            .Height = 340,
            .Tag = New Tuple(Of Integer, Integer)(id, id_user),
            .BackColor = Color.White,
            .Margin = New Padding(5),
            .FlatStyle = FlatStyle.Flat,
            .Cursor = Cursors.Hand
        }

        cardButton.FlatAppearance.BorderSize = 0

        Dim tableLayout As New TableLayoutPanel With {
            .Dock = DockStyle.Fill,
            .RowCount = 4,
            .ColumnCount = 1
        }

        tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 67.0F))
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 8.0F))
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 15.0F))

        Dim pictureBox As New PictureBox With {
            .Dock = DockStyle.Fill,
            .SizeMode = PictureBoxSizeMode.Zoom,
            .Image = Image.FromFile(pathGambar),
            .Margin = New Padding(5)
        }

        Dim ratingPanel As New Panel With {
            .BackColor = Color.Black,
            .Size = New Size(194, 26)
        }

        Dim appDirectory As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        Dim parentDirectory As String = System.IO.Directory.GetParent(System.IO.Directory.GetParent(appDirectory).FullName).FullName
        Dim btg As String

        If avgRating = 0 Then
            btg = System.IO.Path.Combine(parentDirectory, "Resources", "bintangOFF.png")
        Else
            btg = System.IO.Path.Combine(parentDirectory, "Resources", "bintang.png")
        End If

        btg = btg.Replace("\", "/")

        Dim starImage As New PictureBox With {
            .Image = Image.FromFile(btg),
            .SizeMode = PictureBoxSizeMode.Zoom,
            .Margin = New Padding(0),
            .Width = 18,
            .Height = 18,
            .Location = New Point(6, 3)
        }

        Dim avgRatingLabel As New Label With {
            .Text = avgRating.ToString(),
            .AutoSize = True,
            .Margin = New Padding(0),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 13, FontStyle.Bold),
            .Location = New Point(26, 0)
        }

        ratingPanel.Controls.Add(starImage)
        ratingPanel.Controls.Add(avgRatingLabel)

        Dim Nama As New Label With {
            .Text = nama_user,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 13, FontStyle.Bold),
            .TextAlign = ContentAlignment.MiddleCenter
        }

        Dim label As New Label With {
            .Text = judul,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10, FontStyle.Regular),
            .TextAlign = ContentAlignment.MiddleCenter
        }

        tableLayout.Controls.Add(ratingPanel, 0, 0)
        tableLayout.Controls.Add(pictureBox, 0, 1)
        tableLayout.Controls.Add(Nama, 0, 2)
        tableLayout.Controls.Add(label, 0, 3)

        cardButton.Controls.Add(tableLayout)
        FlowLayoutPanel1.Controls.Add(cardButton)

        AddHandler cardButton.Click, AddressOf Card_Click
        AddHandler pictureBox.Click, AddressOf Card_Click
        AddHandler label.Click, AddressOf Card_Click
        AddHandler ratingPanel.Click, AddressOf Card_Click
        AddHandler Nama.Click, AddressOf Card_Click

        AddHandler pictureBox.DoubleClick, AddressOf btnDetail_Click
        AddHandler label.DoubleClick, AddressOf btnDetail_Click
        AddHandler ratingPanel.DoubleClick, AddressOf btnDetail_Click
        AddHandler Nama.DoubleClick, AddressOf btnDetail_Click
    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs)
        Dim control As Control = CType(sender, Control)
        Dim cardButton As Button = GetParentButton(control)

        If LastClickedButton IsNot Nothing Then
            LastClickedButton.BackColor = Color.White
        End If

        LastClickedButton = cardButton

        cardButton.BackColor = Color.LightGray
        If cardButton Is Nothing Then
            Return
        End If

        Dim idData As Tuple(Of Integer, Integer) = CType(cardButton.Tag, Tuple(Of Integer, Integer))
        Dim id As Integer = idData.Item1
        Dim id_user As Integer = idData.Item2

        btnDetail.Tag = id.ToString()
    End Sub

    Private Function GetParentButton(control As Control) As Button
        While control IsNot Nothing AndAlso Not TypeOf control Is Button
            control = control.Parent
        End While
        Return CType(control, Button)
    End Function

    Private Sub ClearFlowLayoutPanel()
        While FlowLayoutPanel1.Controls.Count > 0
            Dim control = FlowLayoutPanel1.Controls(0)
            FlowLayoutPanel1.Controls.Remove(control)
            control.Dispose()
        End While
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text <> "" Then
            ClearFlowLayoutPanel()
            CMD = New MySqlCommand("SELECT tbuser.username, tbresep.judul, tbresep.id_resep, tbresep.gambar, tbresep.status, tbuser.id, AVG(tbkomen.rating) AS avg_rating " &
                      "FROM tbresep " &
                      "INNER JOIN tbuser ON tbresep.id_user = tbuser.id " &
                      "LEFT JOIN tbkomen ON tbresep.id_resep = tbkomen.id_resep " &
                      "WHERE tbresep.judul LIKE '%" + txtCari.Text + "%'" &
                      "GROUP BY tbresep.id_resep, tbuser.username, tbresep.judul, tbresep.gambar, tbresep.status, tbuser.id", CONN)

            RD = CMD.ExecuteReader()
            While RD.Read()
                Dim id As Integer = RD.GetInt32("id_resep")
                Dim id_user As Integer = RD.GetInt32("id")
                Dim nama_user As String = RD.GetString("username")
                Dim judul As String = RD.GetString("judul")
                Dim pathGambar As String = RD.GetString("gambar")
                Dim avgRating As Double

                If RD.IsDBNull(RD.GetOrdinal("avg_rating")) Then
                    avgRating = 0
                Else
                    avgRating = Math.Round(RD.GetDouble("avg_rating"), 1)
                End If

                AddCard(id, id_user, judul, nama_user, avgRating, pathGambar)
            End While
            RD.Close()
            btnDetail.Tag = Nothing
            If LabelUtama.Text <> "LIST RESEP" Then
                LabelUtama.Text = "LIST RESEP"
                btnList.BackColor = Color.FromArgb(200, 200, 200)
                btnTopResep.BackColor = Color.FromArgb(240, 240, 240)
            End If
        Else
            tampilkan()
        End If
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        If btnDetail.Tag IsNot Nothing AndAlso Integer.TryParse(btnDetail.Tag.ToString(), Nothing) Then
            Dim id As Integer = Integer.Parse(btnDetail.Tag.ToString())
            FormDetail.id = id
            FormDetail.Show()
            Me.Close()
        Else
            MessageBox.Show("Tidak ada data yang dipilih untuk dilihat !")
        End If
    End Sub

    Private Sub btnTopResep_Click(sender As Object, e As EventArgs) Handles btnTopResep.Click
        txtCari.Clear()
        ClearFlowLayoutPanel()

        Dim query As String = "SELECT tbuser.username, tbresep.judul, tbresep.id_resep, tbresep.gambar, tbresep.status, tbuser.id, AVG(tbkomen.rating) AS avg_rating " &
                              "FROM tbresep " &
                              "INNER JOIN tbuser ON tbresep.id_user = tbuser.id " &
                              "INNER JOIN tbkomen ON tbresep.id_resep = tbkomen.id_resep " &
                              "WHERE tbresep.status = 'Terverifikasi' " &
                              "GROUP BY tbresep.id_resep, tbuser.username, tbresep.judul, tbresep.gambar, tbresep.status, tbuser.id " &
                              "ORDER BY avg_rating DESC"

        CMD = New MySqlCommand(query, CONN)

        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim id As Integer = RD.GetInt32("id_resep")
            Dim id_user As Integer = RD.GetInt32("id")
            Dim nama_user As String = RD.GetString("username")
            Dim judul As String = RD.GetString("judul")
            Dim pathGambar As String = RD.GetString("gambar")
            Dim avgRating As Double = Math.Round(RD.GetDouble("avg_rating"), 1)
            AddCard(id, id_user, judul, nama_user, avgRating, pathGambar)
        End While
        RD.Close()

        LabelUtama.Text = "TOP RESEP"
        btnList.BackColor = Color.FromArgb(240, 240, 240)
        btnTopResep.BackColor = Color.FromArgb(200, 200, 200)
        btnDetail.Tag = Nothing
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        txtCari.Clear()
        LabelUtama.Text = "LIST RESEP"
        btnList.BackColor = Color.FromArgb(200, 200, 200)
        btnTopResep.BackColor = Color.FromArgb(240, 240, 240)
        btnDetail.Tag = Nothing
        tampilkan()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        MessageBox.Show("Anda harus login terlebih dahulu untuk mengupload resep !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class