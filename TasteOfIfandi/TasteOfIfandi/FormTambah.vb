Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormTambah
    Dim appDirectory As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Dim parentDirectory As String = System.IO.Directory.GetParent(System.IO.Directory.GetParent(appDirectory).FullName).FullName
    Dim gambar As String = parentDirectory & "/Resources/Upload/"

    Dim id_akun As Integer = CRUD.IdAkun
    Private Waktu As DateTime

    Sub Kosong()
        txtJudul.Clear()
        txtDeskripsi.Clear()
        txtBahan.Clear()
        txtLangkah.Clear()
        txtJudul.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        gambar = gambar.Replace("\", "/")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtJudul.Text = Nothing OrElse txtDeskripsi.Text = Nothing OrElse txtBahan.Text = Nothing OrElse txtLangkah.Text = Nothing OrElse PictureBox1.Image Is Nothing Then
            MessageBox.Show("Harap lengkapi seluruh data !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Waktu = DateTime.Now
            Dim imageFormat As Imaging.ImageFormat = PictureBox1.Image.RawFormat
            Dim fileExtension As String = Ekstensi(imageFormat)
            Dim filePath As String = Path.Combine(gambar, Waktu.ToString("dd-MM-yyyy_HH-mm-ss") & "_" & txtJudul.Text & fileExtension)
            PictureBox1.Image.Save(filePath)

            CMD = New MySqlCommand("insert into tbresep values ('NULL', '" & id_akun & "', @judul, @deskripsi, @bahan, @langkah, @filePath, 'Belum Diverifikasi')", CONN)
            CMD.Parameters.AddWithValue("@judul", txtJudul.Text)
            CMD.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
            CMD.Parameters.AddWithValue("@bahan", txtBahan.Text)
            CMD.Parameters.AddWithValue("@langkah", txtLangkah.Text)
            CMD.Parameters.AddWithValue("@filePath", filePath)

            CMD.ExecuteNonQuery()
            Kosong()
            MessageBox.Show("Data berhasil disimpan !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnKembali.PerformClick()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImagePath As String = openFileDialog.FileName
            PictureBox1.Image = Image.FromFile(selectedImagePath)
        End If
    End Sub

    Private Function Ekstensi(imageFormat As Imaging.ImageFormat) As String
        Select Case imageFormat.Guid
            Case Imaging.ImageFormat.Jpeg.Guid
                Return ".jpg"
            Case Imaging.ImageFormat.Png.Guid
                Return ".png"
            Case Imaging.ImageFormat.Bmp.Guid
                Return ".bmp"
            Case Else
                Return ".jpeg"
        End Select
    End Function

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        CRUD.IdAkun = id_akun
        If id_akun = 1 Then
            CRUD.IsAdmin = True
        End If
        CRUD.Show()
    End Sub
End Class