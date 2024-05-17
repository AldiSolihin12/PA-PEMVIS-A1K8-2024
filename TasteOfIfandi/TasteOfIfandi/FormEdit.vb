Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormEdit
    Public Property id As Integer
    Dim id_akun As Integer = CRUD.IdAkun
    Dim appDirectory As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Dim parentDirectory As String = System.IO.Directory.GetParent(System.IO.Directory.GetParent(appDirectory).FullName).FullName
    Dim gambar As String = parentDirectory & "/Resources/Upload/"
    Dim txtGambar As String
    Private Waktu As DateTime
    Dim judul As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        CMD = New MySqlCommand("SELECT * FROM tbresep WHERE id_resep = " & id, CONN)
        CMD.ExecuteNonQuery()
        Using reader As MySqlDataReader = CMD.ExecuteReader()
            If reader.Read() Then
                txtJudul.Text = reader.GetString("judul")
                judul = txtJudul.Text
                txtDeskripsi.Text = reader.GetString("deskripsi")
                txtBahan.Text = reader.GetString("bahan")
                txtLangkah.Text = reader.GetString("langkah")
                txtGambar = reader.GetString("gambar")
                PictureBox1.Image = Image.FromFile(txtGambar)
            End If
        End Using

        gambar = gambar.Replace("\", "/")
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtJudul.Text = Nothing OrElse txtDeskripsi.Text = Nothing OrElse txtBahan.Text = Nothing OrElse txtLangkah.Text = Nothing OrElse PictureBox1.Image Is Nothing Then
            MessageBox.Show("Harap lengkapi seluruh data !", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Waktu = DateTime.Now
            Dim imageFormat As Imaging.ImageFormat = PictureBox1.Image.RawFormat
            Dim fileExtension As String = Ekstensi(imageFormat)
            Dim filePath As String = Path.Combine(gambar, Waktu.ToString("dd-MM-yyyy_HH-mm-ss") & "_" & txtJudul.Text & fileExtension)
            PictureBox1.Image.Save(filePath)

            CMD = New MySqlCommand("UPDATE tbresep SET judul = '" & txtJudul.Text & "', deskripsi = '" & txtDeskripsi.Text & "', bahan = '" & txtBahan.Text & "', langkah = '" & txtLangkah.Text & "', gambar = '" & filePath & "' WHERE id_resep = '" & id & "'", CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnKembali.PerformClick()
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

    Private Sub btnKembali_Click_1(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        CRUD.IdAkun = id_akun
        If id_akun = 1 Then
            CRUD.IsAdmin = True
        End If
        CRUD.Show()
    End Sub
End Class