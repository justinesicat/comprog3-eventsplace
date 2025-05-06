Imports Microsoft.VisualBasic.ApplicationServices

Public Class HomeCustomerForm
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

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs)
        FastFadeToForm(LoginForm, Me)
        LoginForm.txtb_Username.Clear()
        LoginForm.txtb_Password.Clear()
    End Sub

    Private Sub btn_ViewVenues_Click(sender As Object, e As EventArgs) Handles btn_ViewVenues.Click
        FastFadeToForm(ViewVenues, Me)
    End Sub

    Private Sub btn_MyBookings_Click(sender As Object, e As EventArgs) Handles btn_Bookings.Click
        FastFadeToForm(BookingList, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountCustomer, Me)
    End Sub

    Private Sub pbox_Venue_Click(sender As Object, e As EventArgs) Handles pbox_Venue.Click
        FastFadeToForm(ViewVenues, Me)
    End Sub

    Private Sub pbox_Booking_Click(sender As Object, e As EventArgs) Handles pbox_Booking.Click
        FastFadeToForm(BookingList, Me)
    End Sub

    Private Sub lbl_Username_Click(sender As Object, e As EventArgs) Handles lbl_Username.Click

    End Sub
End Class