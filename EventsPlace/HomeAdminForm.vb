Public Class HomeAdminForm
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub setUsername(name As String)
        username = name
        lbl_Username.Text = "Welcome, " & username & "!"
    End Sub

    Private Sub btn_EditVenues_Click(sender As Object, e As EventArgs) Handles btn_EditVenues.Click
        FastFadeToForm(EditVenues, Me)
    End Sub

    Private Sub btn_ViewReservations_Click(sender As Object, e As EventArgs) Handles btn_ViewReservations.Click
        'FastFadeToForm(ViewReservations,Me)
    End Sub

    Private Sub pbox_EditVenues_Click(sender As Object, e As EventArgs) Handles pbox_EditVenues.Click
        FastFadeToForm(EditVenues, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountAdmin, Me)
    End Sub
End Class