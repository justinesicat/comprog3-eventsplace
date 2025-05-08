Public Class BookEventPart2
    Dim calendarOpen As Boolean = False

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
        FastFadeToForm(BookEventPart1, Me)
    End Sub

    Private Sub lbl_BirthdayFill_Click(sender As Object, e As EventArgs) Handles lbl_BirthdayFill.Click
        If calendarOpen = False Then
            calendarOpen = True
            Calendar.Location = New Point(198, 211)
            Calendar.Visible = True
            Calendar.BringToFront()
        Else
            calendarOpen = False
            Calendar.Visible = False
        End If
    End Sub

    Private Sub Calendar_Selected(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateSelected
        If e.Start.Date > DateTime.Today Then
            MsgBox("You can't select future dates.", MsgBoxStyle.Exclamation, "")
            Calendar.Visible = False
            Exit Sub
        End If

        If e.Start.Date = DateTime.Today Then
            MsgBox("You weren't born today.", MsgBoxStyle.Exclamation, "")
            Calendar.Visible = False
            Exit Sub
        End If

        lbl_BirthdayFill.Text = e.Start.ToString("MMMM") & " / " & e.Start.ToString("dd") & " / " & e.Start.ToString("yyyy")
        Dim birthDay As String
        birthDay = e.Start
        Calendar.Visible = False

        Dim age As Integer = CalculateAge(birthday)
        lbl_AgeFill.Text = age
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        If txtbox_Name.Text = "" Or txtbox_Address.Text = "" Then
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If lbl_BirthdayFill.Text = "MM / DD / YYYY" Or lbl_AgeFill.Text = "AGE" Then
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If cmb_Sex.Text = "" Then
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If lbl_AgeFill.Text < 18 Then
            MsgBox("You must be at least 18 years old to book.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        ConfirmationUpdate()
        FastFadeToForm(BookEventPart3, Me)
    End Sub

End Class