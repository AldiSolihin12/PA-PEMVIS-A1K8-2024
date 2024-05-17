Imports TasteOfIfandi.Rounded

Public Class LandingPage
    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        BuatTombolRounded(btnGuest, 5)
        BuatPanelRounded(Panel2, 70)
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Me.Hide()
        FormRegister.Show()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Me.Hide()
        Guest.Show()
    End Sub
End Class
