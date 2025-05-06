Imports System.Globalization

Public Class BookingList
    Private EventName As String() = {"Justine's Birthday"}

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

    Private Sub BookingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
        lbl_Day.Text = Date.Today.ToString("dd")
        lbl_Month.Text = Date.Today.ToString("MMMM")
        lbl_Year.Text = Date.Today.ToString("yyyy")

        Dim scrollablePanel As New Panel()
        scrollablePanel.Size = New Size(830, 245)
        scrollablePanel.Location = New Point(103, 205)
        scrollablePanel.AutoScroll = True
        scrollablePanel.BackColor = Color.PapayaWhip
        Me.Controls.Add(scrollablePanel)

        For i As Integer = 0 To EventName.Length - 1
            Dim newButton As New Button()
            newButton.Text = EventName(i) & vbCrLf & "10:00 AM - 12:00 PM"
            newButton.TextAlign = ContentAlignment.MiddleCenter
            newButton.Font = New Font("Century Gothic", 12, FontStyle.Bold)
            newButton.Size = New Size(400, 200)
            newButton.FlatStyle = FlatStyle.Flat
            newButton.ForeColor = Color.White
            newButton.FlatAppearance.BorderSize = 0
            newButton.BackColor = Color.FromArgb(172, 255, 140, 0)

            newButton.Location = New Point(21 + (i * 420), 22)

            scrollablePanel.Controls.Add(newButton)
        Next

    End Sub

    Private Sub lbl_Date_Click(sender As Object, e As EventArgs) Handles lbl_Day.Click
        Calendar.Location = New Point(lbl_Day.Left, lbl_Day.Bottom)
        Calendar.Visible = True
        Calendar.BringToFront()
    End Sub

    Private Sub lbl_Month_Click(sender As Object, e As EventArgs) Handles lbl_Month.Click
        Calendar.Location = New Point(lbl_Month.Left, lbl_Month.Bottom)
        Calendar.Visible = True
        Calendar.BringToFront()
    End Sub

    Private Sub lbl_Year_Click(sender As Object, e As EventArgs) Handles lbl_Year.Click
        Calendar.Location = New Point(lbl_Year.Left, lbl_Year.Bottom)
        Calendar.Visible = True
        Calendar.BringToFront()
    End Sub
    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateSelected
        lbl_Day.Text = e.Start.ToString("dd")
        lbl_Month.Text = e.Start.ToString("MMMM")
        lbl_Year.Text = e.Start.ToString("yyyy")
        Calendar.Visible = False
    End Sub

    Private Sub btn_BookEvent_Click(sender As Object, e As EventArgs) Handles btn_BookEvent.Click
        FastFadeToForm(BookEventPart1, Me)
    End Sub

    Private Sub BookingList_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Calendar.Visible = False
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_Time.Text = DateTime.Now.ToString("hh:mm tt")
        lbl_Second.Text = DateTime.Now.ToString(":ss")
    End Sub
End Class