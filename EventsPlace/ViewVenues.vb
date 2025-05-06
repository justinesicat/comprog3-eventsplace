Public Class ViewVenues
    Private Sub ViewVenues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeCustomerForm, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountCustomer, Me)
    End Sub

    Private Sub pbox_Booking_Click(sender As Object, e As EventArgs) Handles pbox_Booking.Click
        FastFadeToForm(BookingList, Me)
    End Sub
End Class