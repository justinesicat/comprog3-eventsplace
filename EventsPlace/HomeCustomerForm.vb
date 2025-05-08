Imports Microsoft.VisualBasic.ApplicationServices

Public Class HomeCustomerForm
    Dim imageList As New List(Of Image)()
    Dim currentImageIndex As Integer = 0

    Private Sub HomeCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageList.Add(My.Resources.Banner1)
        imageList.Add(My.Resources.Banner2)
        imageList.Add(My.Resources.Banner3)
        imageList.Add(My.Resources.Banner4)
        imageList.Add(My.Resources.Banner5)

        pbox_Display.Image = imageList(currentImageIndex)
    End Sub

    Private Sub pbox_Display_Click(sender As Object, e As EventArgs) Handles pbox_Display.Click
        currentImageIndex += 1
        If currentImageIndex >= imageList.Count Then
            currentImageIndex = 0
        End If

        pbox_Display.Image = imageList(currentImageIndex)
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub setUsername(name As String)
        userName = name
        lbl_Username.Text = "Welcome, " & userName & "!"
    End Sub

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs)
        FastFadeToForm(LoginForm, Me)
        LoginForm.txtb_UserName.Clear()
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