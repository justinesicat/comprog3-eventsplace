Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BookEventPart1
    Dim venueTypes As New List(Of String)
    Dim currentPlaceId As New List(Of String)
    Public selectedVenue As String
    Public selectedPlaceId As Integer
    Public featuresList As String
    Public day As Integer
    Public month As Integer
    Public year As Integer
    Public startDate As Date
    Public formatstartDate As Date
    Dim calendarOpen As Boolean = False
    Dim currentIndex As Integer = 0

    Private Sub BookEventPart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If venueTypes.Count = 0 Then
            LoadVenueTypes()

            If venueTypes.Count > 0 Then
                LoadImageFromDatabase(currentPlaceId(currentIndex))
                currentIndex = 0
                UpdateVenueSelection()
            Else
                lbl_VenueType.Text = "None"
                pbox_VenuePic.Image = Nothing
            End If
        End If
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

    Private Sub pbox_Venue_Click(sender As Object, e As EventArgs) Handles pbox_Venue.Click
        FastFadeToForm(ViewVenues, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountCustomer, Me)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(BookingList, Me)
    End Sub

    Private Sub lbl_Day_Click(sender As Object, e As EventArgs) Handles lbl_Day.Click
        If calendarOpen = False Then
            calendarOpen = True
            Calendar.Location = New Point(208, pbox_Month.Bottom)
            Calendar.Visible = True
            Calendar.BringToFront()
        Else
            calendarOpen = False
            Calendar.Visible = False
        End If
    End Sub

    Private Sub lbl_Month_Click(sender As Object, e As EventArgs) Handles lbl_Month.Click
        If calendarOpen = False Then
            calendarOpen = True
            Calendar.Location = New Point(208, pbox_Month.Bottom)
            Calendar.Visible = True
            Calendar.BringToFront()
        Else
            calendarOpen = False
            Calendar.Visible = False
        End If
    End Sub

    Private Sub lbl_Year_Click(sender As Object, e As EventArgs) Handles lbl_Year.Click
        If calendarOpen = False Then
            calendarOpen = True
            Calendar.Location = New Point(208, pbox_Month.Bottom)
            Calendar.Visible = True
            Calendar.BringToFront()
        Else
            calendarOpen = False
            Calendar.Visible = False
        End If
    End Sub

    Private Sub Calendar_Selected(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateSelected
        If e.Start.Date < DateTime.Today Then
            MsgBox("You cannot select a past date.", MsgBoxStyle.Exclamation, "")
            Calendar.Visible = False
            Exit Sub
        End If
        If e.Start.Date = DateTime.Today Then
            MsgBox("You cannot book the same date as today.", MsgBoxStyle.Exclamation, "")
            Calendar.Visible = False
            Exit Sub
        End If

        startDate = e.Start
        formatstartDate = startDate
        lbl_Day.Text = e.Start.ToString("dd")
        day = e.Start.Day
        lbl_Month.Text = e.Start.ToString("MMMM")
        month = e.Start.Month
        lbl_Year.Text = e.Start.ToString("yyyy")
        year = e.Start.Year
        Calendar.Visible = False
    End Sub

    Private Sub BookEventPart1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Calendar.Visible = False
    End Sub

    Private Sub LoadVenueTypes()
        openCon()
        venueTypes.Clear()
        currentPlaceId.Clear()

        Dim query As String = "SELECT DISTINCT PLACEID, TYPE FROM tbl_venues"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            currentPlaceId.Add(Convert.ToInt32(reader("PLACEID")))
            venueTypes.Add(reader("TYPE").ToString())
        End While
        reader.Close()
        con.Close()
    End Sub

    Private Sub LoadImageFromDatabase(placeid As Integer)
        openCon()
        Dim cmd As New MySqlCommand("SELECT image FROM tbl_venues WHERE PLACEID = @placeid", con)
        cmd.Parameters.AddWithValue("@placeid", placeid)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            If Not IsDBNull(reader("image")) Then
                Dim imgBytes As Byte() = CType(reader("image"), Byte())
                If imgBytes.Length > 0 Then
                    Dim ms As New MemoryStream(imgBytes)
                    pbox_VenuePic.Image = Image.FromStream(ms)
                    lbl_NoImage.Visible = False
                Else
                    pbox_VenuePic.Image = Nothing
                    lbl_NoImage.Visible = True
                End If
            Else
                pbox_VenuePic.Image = Nothing
                lbl_NoImage.Visible = True
            End If
        Else
            MsgBox("Venue not found.", MsgBoxStyle.Exclamation, "")
        End If
        reader.Close()
        con.Close()
    End Sub

    Private Sub UpdateVenueSelection()
        If currentIndex >= 0 AndAlso currentIndex < venueTypes.Count Then
            selectedVenue = venueTypes(currentIndex)
            selectedPlaceId = currentPlaceId(currentIndex)

            lbl_VenueType.Text = selectedVenue
            LoadImageFromDatabase(selectedPlaceId)
            LoadAndUpdateVenueFeatures(selectedPlaceId)
            GetVenueCapacity(selectedPlaceId)
            GetVenuePrice(selectedPlaceId)
        End If
    End Sub

    Private Sub btn_Left_Click(sender As Object, e As EventArgs) Handles btn_Left.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            UpdateVenueSelection()
        End If
    End Sub

    Private Sub btn_Right_Click(sender As Object, e As EventArgs) Handles btn_Right.Click
        If currentIndex < venueTypes.Count - 1 Then
            currentIndex += 1
            UpdateVenueSelection()
        End If
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        If lbl_Day.Text = "DAY" Or lbl_Month.Text = "MONTH" Or lbl_Year.Text = "YEAR" Then
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If txtbox_NoOfDays.Text = "" Or txtbox_NoOfGuests.Text = "" Then
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If Integer.TryParse(txtbox_NoOfDays.Text, 0) = False Or Val(txtbox_NoOfDays.Text) < 1 Then
            MsgBox("Only positive integers on the number of days are allowed.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If Integer.TryParse(txtbox_NoOfGuests.Text, 0) = False Or Val(txtbox_NoOfGuests.Text) < 1 Then
            MsgBox("Only positive integers on the number of guests are allowed.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim monthNumber As Integer = DateTime.ParseExact(lbl_Month.Text, "MMMM", Nothing).Month

        FastFadeToForm(BookEventPart2, Me)
    End Sub
End Class