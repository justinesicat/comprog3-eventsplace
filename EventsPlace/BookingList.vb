Imports System.Globalization

Public Class BookingList
    Public scrollablePanel As New Panel()

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeCustomerForm, Me)
    End Sub
    Private Sub pbox_Venue_Click(sender As Object, e As EventArgs) Handles pbox_Venue.Click
        FastFadeToForm(ViewVenues, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountCustomer, Me)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(HomeCustomerForm, Me)
    End Sub

    Private Sub BookingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
        lbl_Month.Text = Date.Today.ToString("MMMM")
        lbl_Day.Text = Date.Today.ToString("dd")
        lbl_Year.Text = Date.Today.ToString("yyyy")

        scrollablePanel.Size = New Size(830, 245)
        scrollablePanel.Location = New Point(103, 205)
        scrollablePanel.AutoScroll = True
        scrollablePanel.BackColor = Color.PapayaWhip
        Me.Controls.Add(scrollablePanel)

        LoadBookings()
    End Sub

    Private Sub btn_BookEvent_Click(sender As Object, e As EventArgs) Handles btn_BookEvent.Click
        FastFadeToForm(BookEventPart1, Me)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_Time.Text = DateTime.Now.ToString("hh:mm tt")
        lbl_Second.Text = DateTime.Now.ToString(":ss")
    End Sub

End Class