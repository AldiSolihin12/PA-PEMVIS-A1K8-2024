Imports MySql.Data.MySqlClient

Public Class FormKomenRating
    Public Property id As Integer
    Dim id_akun As Integer = CRUD.IdAkun

    Private Sub FormKomenRating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        CRUD.IdAkun = id_akun
        If id_akun = 1 Then
            CRUD.IsAdmin = True
        End If
        CRUD.Show()
    End Sub

    Private Sub btnKomen_Click(sender As Object, e As EventArgs) Handles btnKomen.Click
        Dim nilai_rating As Integer

        If RadioButton1.Checked Then
            nilai_rating = 1
        ElseIf RadioButton2.Checked Then
            nilai_rating = 2
        ElseIf RadioButton3.Checked Then
            nilai_rating = 3
        ElseIf RadioButton4.Checked Then
            nilai_rating = 4
        ElseIf RadioButton5.Checked Then
            nilai_rating = 5
        End If

        Dim count As Integer

        Using cmdCheck As New MySqlCommand("SELECT COUNT(*) FROM tbkomen WHERE id_user = @id_akun AND id_resep = @id_resep", CONN)
            cmdCheck.Parameters.AddWithValue("@id_akun", id_akun)
            cmdCheck.Parameters.AddWithValue("@id_resep", id)
            count = Convert.ToInt32(cmdCheck.ExecuteScalar())
        End Using

        If count > 0 Then
            CMD = New MySqlCommand("UPDATE tbkomen SET rating = @rating, komentar = @komen WHERE id_user = @id_akun AND id_resep = @id_resep", CONN)
            CMD.Parameters.AddWithValue("@id_akun", id_akun)
            CMD.Parameters.AddWithValue("@id_resep", id)
            CMD.Parameters.AddWithValue("@rating", nilai_rating)
            CMD.Parameters.AddWithValue("@komen", txtKomen.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Rating berhasil diupdate !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnKembali.PerformClick()
        Else
            CMD = New MySqlCommand("INSERT INTO tbkomen VALUES (NULL, @id_akun, @id_resep, @rating, @komen)", CONN)
            CMD.Parameters.AddWithValue("@id_akun", id_akun)
            CMD.Parameters.AddWithValue("@id_resep", id)
            CMD.Parameters.AddWithValue("@rating", nilai_rating)
            CMD.Parameters.AddWithValue("@komen", txtKomen.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Rating berhasil disimpan !", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnKembali.PerformClick()
        End If
    End Sub
End Class