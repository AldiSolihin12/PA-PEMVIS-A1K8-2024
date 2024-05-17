Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FormDetail
    Public Property id As Integer
    Dim id_akun As Integer = CRUD.IdAkun
    Dim bahan As String
    Dim bahan1 As String = ""
    Dim bahan2 As String = ""
    Dim bahan3 As String = ""
    Dim bahan4 As String = ""
    Dim langkah As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        hitungRating()
        tampilkan()
        atur_grid()
        CMD = New MySqlCommand("SELECT * FROM tbresep WHERE id_resep = " & id, CONN)
        CMD.ExecuteNonQuery()
        Using reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.Read() Then
                txtJudul.Text = reader.GetString("judul")
                txtDeskripsi.Text = reader.GetString("deskripsi")
                Dim user As Integer = reader.GetInt32("id_user")
                Dim status As String = reader.GetString("status")

                If user = id_akun OrElse status = "Belum Diverifikasi" OrElse id_akun = -1 Then
                    btnKomen.Visible = False
                End If

                ListBox1.Items.Clear()
                ListBox2.Items.Clear()

                bahan = reader.GetString("bahan")
                isiListbox(bahan, ListBox1)

                langkah = reader.GetString("langkah")
                isiListbox(langkah, ListBox2)

                Dim bahanArray As String() = ListBox1.Items.Cast(Of String)().ToArray()

                If bahanArray.Length >= 7 Then
                    bahan1 = String.Join(vbCrLf, bahanArray.Take(7))
                Else
                    bahan1 = String.Join(vbCrLf, bahanArray)
                End If

                If bahanArray.Length >= 15 Then
                    bahan2 = String.Join(vbCrLf, bahanArray.Skip(7).Take(7))
                ElseIf bahanArray.Length > 7 Then
                    bahan2 = String.Join(vbCrLf, bahanArray.Skip(7))
                End If

                If bahanArray.Length >= 22 Then
                    bahan3 = String.Join(vbCrLf, bahanArray.Skip(15).Take(7))
                ElseIf bahanArray.Length > 15 Then
                    bahan3 = String.Join(vbCrLf, bahanArray.Skip(15))
                End If

                If bahanArray.Length >= 29 Then
                    bahan4 = String.Join(vbCrLf, bahanArray.Skip(22).Take(7))
                ElseIf bahanArray.Length > 22 Then
                    bahan4 = String.Join(vbCrLf, bahanArray.Skip(22))
                End If

                langkah = String.Join(vbCrLf, ListBox2.Items.Cast(Of String)().ToArray())

                Dim imagePath As String = reader.GetString("gambar")
                PictureBox1.Image = Image.FromFile(imagePath)
            End If
        End Using

        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    Sub isiListbox(Teks As String, ListBox As ListBox)
        Dim lines() As String = Teks.Split(New Char() {ControlChars.Lf, ControlChars.Cr}, StringSplitOptions.RemoveEmptyEntries)
        For i As Integer = 0 To lines.Length - 1
            ListBox.Items.Add((i + 1).ToString() & ". " & lines(i))
        Next
    End Sub

    Private Sub btnKembali_Click_1(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        CRUD.IdAkun = id_akun
        If id_akun = 1 Then
            CRUD.IsAdmin = True
            CRUD.Show()
        ElseIf id_akun = -1 Then
            Guest.Show()
        Else
            CRUD.Show()
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New Printing.PaperSize("A4", 827, 1169)
        PrintDocument1.DefaultPageSettings.Landscape = False
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim margin As Integer = 50
        Dim yPos As Integer = margin + 110

        Dim headerFont As New Font("Segoe UI", 22, FontStyle.Bold)
        Dim segoe As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim blackBrush As New SolidBrush(Color.Black)

        e.Graphics.DrawImage(My.Resources.ResepIfandi, e.PageBounds)

        Dim header1Size As SizeF = e.Graphics.MeasureString(txtJudul.Text, headerFont)
        e.Graphics.DrawString(txtJudul.Text, headerFont, blackBrush, (e.PageBounds.Width - header1Size.Width) / 2, yPos)

        Dim bahan1Size As SizeF = e.Graphics.MeasureString(bahan1, segoe)
        Dim bahan2Size As SizeF = e.Graphics.MeasureString(bahan2, segoe)
        Dim bahan3Size As SizeF = e.Graphics.MeasureString(bahan3, segoe)
        Dim bahan4Size As SizeF = e.Graphics.MeasureString(bahan4, segoe)
        Dim x1 As Single = 50
        Dim x2 As Single = x1 + bahan1Size.Width + 20
        Dim x3 As Single = x2 + bahan2Size.Width + 20
        Dim x4 As Single = x3 + bahan3Size.Width + 20

        e.Graphics.DrawString(bahan1, segoe, blackBrush, x1, 330)
        e.Graphics.DrawString(bahan2, segoe, blackBrush, x2, 330)
        e.Graphics.DrawString(bahan3, segoe, blackBrush, x3, 330)
        e.Graphics.DrawString(bahan4, segoe, blackBrush, x4, 330)

        Dim isi2Size As SizeF = e.Graphics.MeasureString(langkah, segoe)
        e.Graphics.DrawString(langkah, segoe, blackBrush, 50, 630)

        headerFont.Dispose()
        segoe.Dispose()
        blackBrush.Dispose()
    End Sub


    Private Sub hitungRating()
        CMD = New MySqlCommand("SELECT AVG(rating) as rata2rating FROM tbkomen where id_resep = @id", CONN)
        CMD.Parameters.AddWithValue("@id", id)
        CMD.ExecuteNonQuery()

        Using reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.Read() Then
                Dim rata2rating As Decimal
                If Not reader.IsDBNull(reader.GetOrdinal("rata2rating")) Then
                    rata2rating = reader.GetDecimal(reader.GetOrdinal("rata2rating"))
                Else
                    rata2rating = 0
                End If

                Dim rata2ratingBULAT As Decimal = Math.Floor(rata2rating)

                Debug.WriteLine("Average rating : " & rata2rating)
                Debug.WriteLine("Average rating DOWN : " & rata2ratingBULAT)

                bintang1.Visible = False
                bintang2.Visible = False
                bintang3.Visible = False
                bintang4.Visible = False
                bintang5.Visible = False
                bintang1OFF.Visible = False
                bintang2OFF.Visible = False
                bintang3OFF.Visible = False
                bintang4OFF.Visible = False
                bintang5OFF.Visible = False

                Select Case rata2ratingBULAT
                    Case 0
                        bintang1OFF.Visible = True
                        bintang2OFF.Visible = True
                        bintang3OFF.Visible = True
                        bintang4OFF.Visible = True
                        bintang5OFF.Visible = True
                    Case 1
                        bintang1.Visible = True
                        bintang2OFF.Visible = True
                        bintang3OFF.Visible = True
                        bintang4OFF.Visible = True
                        bintang5OFF.Visible = True
                    Case 2
                        bintang1.Visible = True
                        bintang2.Visible = True
                        bintang3OFF.Visible = True
                        bintang4OFF.Visible = True
                        bintang5OFF.Visible = True
                    Case 3
                        bintang1.Visible = True
                        bintang2.Visible = True
                        bintang3.Visible = True
                        bintang4OFF.Visible = True
                        bintang5OFF.Visible = True
                    Case 4
                        bintang1.Visible = True
                        bintang2.Visible = True
                        bintang3.Visible = True
                        bintang4.Visible = True
                        bintang5OFF.Visible = True
                    Case 5
                        bintang1.Visible = True
                        bintang2.Visible = True
                        bintang3.Visible = True
                        bintang4.Visible = True
                        bintang5.Visible = True
                End Select
            End If
        End Using
    End Sub

    Sub tampilkan()
        Dim CMD As New MySqlCommand("SELECT tbuser.username, tbkomen.komentar, tbkomen.rating FROM tbkomen INNER JOIN tbuser ON tbkomen.id_user = tbuser.id WHERE tbkomen.id_resep = @id_resep", CONN)
        CMD.Parameters.AddWithValue("@id_resep", id)
        Dim DA As New MySqlDataAdapter(CMD)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkomen")
        DataGridView1.DataSource = DS.Tables("tbkomen")
        DataGridView1.Refresh()
    End Sub

    Sub atur_grid()
        Try
            If DataGridView1.Columns.Count > 0 Then
                DataGridView1.Columns(0).Width = 100
                DataGridView1.Columns(1).Width = 320
                DataGridView1.Columns(2).Width = 150
                DataGridView1.Columns(0).HeaderText = "Username"
                DataGridView1.Columns(1).HeaderText = "Komentar"
                DataGridView1.Columns(2).HeaderText = "Rating"
                DataGridView1.RowTemplate.Height = 20
            Else
                MessageBox.Show("No columns found in DataGridView.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        RefreshStarImages()
    End Sub

    Private Sub ClearStarImages()
        For Each control As Control In DataGridView1.Controls
            If TypeOf control Is PictureBox AndAlso control.Tag IsNot Nothing AndAlso control.Tag.ToString() = "StarImage" Then
                DataGridView1.Controls.Remove(control)
                control.Dispose()
            End If
        Next
    End Sub

    Private Sub RefreshStarImages()
        ClearStarImages()
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cell As DataGridViewCell = row.Cells(2)
            If cell.Value IsNot Nothing AndAlso Not DBNull.Value.Equals(cell.Value) Then 
                Dim rating As Integer = Convert.ToInt32(cell.Value)
                Dim cellBounds As Rectangle = DataGridView1.GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, False)

                Dim starWidth As Integer = 12
                Dim totalWidth As Integer = starWidth * rating
                Dim startX As Integer = cellBounds.Left
                Dim startY As Integer = cellBounds.Top + 5

                For i As Integer = 0 To rating - 1
                    Dim starPictureBox As New PictureBox()
                    starPictureBox.Image = My.Resources.bintang
                    starPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                    starPictureBox.Size = New Size(12, 12)
                    starPictureBox.Location = New Point(startX + i * starWidth + (i + 3), startY)
                    starPictureBox.Tag = "StarImage"
                    DataGridView1.Controls.Add(starPictureBox)
                Next
            End If
        Next
    End Sub


    Private Sub btnKomen_Click(sender As Object, e As EventArgs) Handles btnKomen.Click
        Dim id As Integer = Me.id
        FormKomenRating.id = id
        FormKomenRating.Show()
        Me.Close()
    End Sub
End Class