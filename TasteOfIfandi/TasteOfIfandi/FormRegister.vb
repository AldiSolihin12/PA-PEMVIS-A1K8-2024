Imports MySql.Data.MySqlClient
Imports TasteOfIfandi.Rounded

Public Class FormRegister
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        BuatTombolRounded(btnLog, 5)
        BuatTombolRounded(btnReg, 5)
        BuatPanelRounded(Panel1, 5)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        LandingPage.Show()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan password harus diisi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If IsUsernameExists(username) Then
            MessageBox.Show("Username sudah digunakan. Silakan pilih username lain !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If AddUser(username, password) Then
            txtUsername.Text = ""
            txtPassword.Text = ""
            MessageBox.Show("Registrasi berhasil !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Registrasi gagal. Silakan coba lagi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsUsernameExists(username As String) As Boolean
        Using command As MySqlCommand = New MySqlCommand("SELECT COUNT(*) FROM tbuser WHERE username = @username", CONN)
            command.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Function AddUser(username As String, password As String) As Boolean
        Using command As MySqlCommand = New MySqlCommand("INSERT INTO tbuser (username, password, role) VALUES (@username, @password, 'user')", CONN)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        End Using
    End Function
End Class