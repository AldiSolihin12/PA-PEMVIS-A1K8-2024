Imports MySql.Data.MySqlClient
Imports TasteOfIfandi.Rounded

Public Class FormLogin
    Private _idakun As Integer

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        BuatTombolRounded(btnLog, 5)
        BuatTombolRounded(btnReg, 5)
        BuatPanelRounded(Panel1, 5)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        LandingPage.Show()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Me.Close()
        FormRegister.Show()
    End Sub

    Public Property IdAkun() As Integer
        Get
            Return _idakun
        End Get
        Set(ByVal value As Integer)
            _idakun = value
        End Set
    End Property

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan password harus diisi !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim result As Tuple(Of Integer, String) = CheckLogin(username, password)
        If result IsNot Nothing Then
            Dim id_akun As Integer = result.Item1
            Dim role As String = result.Item2
            If role = "admin" Then
                MessageBox.Show("Login berhasil sebagai Admin !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CRUD.IsAdmin = True
                CRUD.IdAkun = id_akun
                CRUD.Show()
                Me.Close()
            Else
                MessageBox.Show("Login berhasil !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CRUD.IsAdmin = False
                CRUD.IdAkun = id_akun
                CRUD.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Username atau password salah. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CheckLogin(username As String, password As String) As Tuple(Of Integer, String)
        Using command As MySqlCommand = New MySqlCommand("SELECT id, role FROM tbuser WHERE username = @username AND password = @password", CONN)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", password)
            Dim role As String = Convert.ToString(command.ExecuteScalar())
            Using reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim idakun As Integer = reader.GetInt32("id")
                    Dim role_akun As String = reader.GetString("role")
                    Return New Tuple(Of Integer, String)(idakun, role_akun)
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
End Class