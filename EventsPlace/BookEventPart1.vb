Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BookEventPart1
    Public day As Integer
    Public month As Integer
    Public year As Integer
    Dim venueTypes As New List(Of String)
    Dim currentPlaceId As New List(Of String)
    Dim currentIndex As Integer = 0


    Private Sub BookEventPart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVenueTypes()
        LoadImageFromDatabase(currentplaceid(currentIndex))
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

    Private Sub lbl_Date_Click(sender As Object, e As EventArgs) Handles lbl_Day.Click
        panel_TimePicker.Visible = False
        Calendar.Location = New Point(192, 134)
        Calendar.Visible = True
        Calendar.BringToFront()
    End Sub

    Private Sub lbl_Month_Click(sender As Object, e As EventArgs) Handles lbl_Month.Click
        panel_TimePicker.Visible = False
        Calendar.Location = New Point(192, 134)
        Calendar.Visible = True
        Calendar.BringToFront()
    End Sub

    Private Sub lbl_Year_Click(sender As Object, e As EventArgs) Handles lbl_Year.Click
        panel_TimePicker.Visible = False
        Calendar.Location = New Point(192, 134)
        Calendar.Visible = True
        Calendar.BringToFront()
    End Sub
    Private Sub Calendar_Selected(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateSelected
        If e.Start.Date < DateTime.Today Then
            MessageBox.Show("You cannot select a past date.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Calendar.Visible = False
            Exit Sub
        End If
        If e.Start.Date = DateTime.Today Then
            MessageBox.Show("You cannot book the same date as today.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Calendar.Visible = False
            Exit Sub
        End If

        lbl_Day.Text = e.Start.ToString("dd")
        day = e.Start.Day
        lbl_Month.Text = e.Start.ToString("MMMM")
        month = e.Start.Month
        lbl_Year.Text = e.Start.ToString("yyyy")
        year = e.Start.Year
        Calendar.Visible = False
    End Sub


    Private Sub lbl_TimeStart_Click(sender As Object, e As EventArgs) Handles lbl_TimeStart.Click
        Calendar.Visible = False
        panel_TimePicker.Location = New Point(lbl_TimeStart.Left + 5, lbl_TimeStart.Bottom)
        panel_TimePicker.Visible = True
        btn_StartSet.Visible = True
        btn_EndSet.Visible = False
    End Sub

    Private Sub btn_StartSet_Click(sender As Object, e As EventArgs) Handles btn_StartSet.Click
        If cmb_StartHour.SelectedItem IsNot Nothing And cmb_StartMinute.SelectedItem IsNot Nothing And cmb_StartAMPM.SelectedItem IsNot Nothing Then
            Dim hour As Integer = Convert.ToInt32(cmb_StartHour.SelectedItem)
            Dim minute As Integer = Convert.ToInt32(cmb_StartMinute.SelectedItem)
            Dim ampm As String = cmb_StartAMPM.SelectedItem.ToString()

            If ampm = "PM" And hour < 12 Then
                hour += 12
            ElseIf ampm = "AM" And hour = 12 Then
                hour = 0
            End If

            Dim selectedTime As New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day, hour, minute, 0)

            lbl_TimeStart.Text = selectedTime.ToString("hh:mm tt")
            panel_TimePicker.Visible = False
        Else
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Sub lbl_TimeEnd_Click(sender As Object, e As EventArgs) Handles lbl_TimeEnd.Click
        Calendar.Visible = False
        panel_TimePicker.Location = New Point(lbl_TimeEnd.Left + 5, lbl_TimeEnd.Bottom)
        btn_StartSet.Visible = False
        btn_EndSet.Visible = True
        panel_TimePicker.BringToFront()
        panel_TimePicker.Visible = True
    End Sub
    Private Sub btn_EndSet_Click(sender As Object, e As EventArgs) Handles btn_EndSet.Click
        If cmb_StartHour.SelectedItem IsNot Nothing And cmb_StartMinute.SelectedItem IsNot Nothing And cmb_StartAMPM.SelectedItem IsNot Nothing Then
            Dim hour As Integer = Convert.ToInt32(cmb_StartHour.SelectedItem)
            Dim minute As Integer = Convert.ToInt32(cmb_StartMinute.SelectedItem)
            Dim ampm As String = cmb_StartAMPM.SelectedItem.ToString()

            If ampm = "PM" And hour < 12 Then
                hour += 12
            ElseIf ampm = "AM" And hour = 12 Then
                hour = 0
            End If

            Dim endTime As New DateTime(Date.Today.Year, Date.Today.Month, Date.Today.Day, hour, minute, 0)

            lbl_TimeEnd.Text = endTime.ToString("hh:mm tt")
            panel_TimePicker.Visible = False
        Else
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Sub BookEventPart1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Calendar.Visible = False
        panel_TimePicker.Visible = False
    End Sub
    Private Sub LoadVenueTypes()
        openCon()
        venueTypes.Clear()
        currentplaceid.Clear()

        ' Load venue types and PLACEIDs
        Dim query As String = "SELECT DISTINCT PLACEID, TYPE FROM tbl_venues"
        Dim cmd As New MySqlCommand(query, con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            currentplaceid.Add(Convert.ToInt32(reader("PLACEID")))
            venueTypes.Add(reader("TYPE").ToString())
        End While
        reader.Close()

        con.Close()

        ' Display the first venue's data
        If venueTypes.Count > 0 Then
            currentIndex = 0
            lbl_VenueType.Text = venueTypes(currentIndex)
            Dim selectedPlaceId As Integer = currentPlaceId(currentIndex)

            LoadImageFromDatabase(selectedPlaceId)
            LoadAndUpdateVenueFeatures(selectedPlaceId)
        Else
            lbl_VenueType.Text = "None"
            pbox_VenuePic.Image = Nothing
        End If
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

    Private Sub btn_Left_Click(sender As Object, e As EventArgs) Handles btn_Left.Click
        If venueTypes.Count = 0 Then Exit Sub

        currentIndex -= 1
        If currentIndex < 0 Then
            currentIndex = venueTypes.Count - 1
        End If

        Dim selectedPlaceId As Integer = currentPlaceId(currentIndex)
        lbl_VenueType.Text = venueTypes(currentIndex)
        LoadImageFromDatabase(currentplaceid(currentIndex))
        LoadAndUpdateVenueFeatures(selectedPlaceId)
    End Sub

    Private Sub btn_Right_Click(sender As Object, e As EventArgs) Handles btn_Right.Click
        If venueTypes.Count = 0 Then Exit Sub

        currentIndex += 1
        If currentIndex >= venueTypes.Count Then
            currentIndex = 0
        End If

        Dim selectedPlaceId As Integer = currentPlaceId(currentIndex)
        lbl_VenueType.Text = venueTypes(currentIndex)
        LoadImageFromDatabase(currentplaceid(currentIndex))
        LoadAndUpdateVenueFeatures(selectedPlaceId)
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        If lbl_Day.Text = "DAY" Or lbl_Month.Text = "MONTH" Or lbl_Year.Text = "YEAR" Then
            MsgBox("Please fill up all the date fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim startTime As DateTime
        Dim endTime As DateTime

        Dim isStartValid As Boolean = DateTime.TryParseExact(lbl_TimeStart.Text, "hh:mm tt", Nothing, Globalization.DateTimeStyles.None, startTime)
        Dim isEndValid As Boolean = DateTime.TryParseExact(lbl_TimeEnd.Text, "hh:mm tt", Nothing, Globalization.DateTimeStyles.None, endTime)

        If Not isStartValid Or Not isEndValid Then
            MsgBox("Please enter valid start and end times.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim monthNumber As Integer = DateTime.ParseExact(lbl_Month.Text, "MMMM", Nothing).Month

        Dim fullStartTime As New DateTime(CInt(lbl_Year.Text), monthNumber, CInt(lbl_Day.Text), startTime.Hour, startTime.Minute, 0)
        Dim fullEndTime As New DateTime(CInt(lbl_Year.Text), monthNumber, CInt(lbl_Day.Text), endTime.Hour, endTime.Minute, 0)

        If fullEndTime < fullStartTime Then
            fullEndTime = fullEndTime.AddDays(1)
        End If

        Dim hoursDifference As Double = (fullEndTime - fullStartTime).TotalHours

        If hoursDifference < 1 Then
            MsgBox("The event must be at least 1 hour long.", MsgBoxStyle.Exclamation, "")
        ElseIf hoursDifference > 12 Then
            MsgBox("The event cannot exceed 12 hours.", MsgBoxStyle.Exclamation, "")
        Else
            MsgBox("All good! Proceeding...", MsgBoxStyle.Information, "")
        End If
    End Sub

End Class