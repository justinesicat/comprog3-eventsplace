Imports MySql.Data.MySqlClient
Module MainModule
    Public con As MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Public userId As Integer
    Public userName As String
    Public servicePrice As Integer
    Public selectedServices As New List(Of String)
    Public selectedServiceIDs As New List(Of Integer)

    Public venue As String
    Public capacity As Integer
    Public pricePerDay As Decimal
    Public totalGuestsPriceWithDays As Decimal

    Public placeId As Integer
    Public dateBooked As Date
    Public timeBooked As DateTime
    Public fullName As String
    Public address As String
    Public birthDay As Date
    Public age As String
    Public sex As String
    Public features As String
    Public dateStart As Date
    Public dateEnd As Date
    Public dayMultiplier As Integer
    Public totalEventDatePrice As Decimal
    Public numOfGuests As Integer
    Public numOfExceedingGuests As Integer
    Public ExceedingGuestsPrice As Integer
    Public services As String
    Public totalServicePriceWithDays As Decimal
    Public totalPrice As Decimal
    Public selectedBookingId As String

    Public Sub FastFadeToForm(targetForm As Form, currentForm As Form)
        currentForm.Hide()

        targetForm.Opacity = 0
        targetForm.StartPosition = FormStartPosition.CenterScreen
        targetForm.Show()

        Dim fadeInTimer As New Timer()
        fadeInTimer.Interval = 10

        AddHandler fadeInTimer.Tick,
        Sub(sender, e)
            targetForm.Opacity += 0.05
            If targetForm.Opacity >= 1 Then
                targetForm.Opacity = 1
                fadeInTimer.Stop()
            End If
        End Sub

        fadeInTimer.Start()
    End Sub

    Sub openCon()
        con = New MySqlConnection()
        con.ConnectionString = "server=127.0.0.1;user=root;password=jmjp;database=eventsplace"
        con.Open()
    End Sub

    Public Function UsernameExists(userName As String) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM tbl_accounts WHERE USERNAME = @username", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", userName)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Sub RegisterAccount()
        Try
            openCon()

            cmd.Connection = con
            cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO tbl_accounts (`USERNAME`, `PASSWORD`, `ADMINPERMS`) VALUES (@username, @password, @adminperms)"
            cmd.Parameters.AddWithValue("@username", RegisterForm.txtb_UserName.Text)
            cmd.Parameters.AddWithValue("@password", RegisterForm.txtb_Password.Text)
            cmd.Parameters.AddWithValue("@adminperms", False)
            cmd.ExecuteNonQuery()
            MsgBox("Account successfully registered.", MsgBoxStyle.Information, "")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function PasswordMatch(userName As String, password As String) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT ID FROM tbl_accounts WHERE USERNAME = @username AND PASSWORD = @password", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", userName)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                userId = reader("ID")
                userName = userName
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function IsAdmin(userName As String) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT ADMINPERMS FROM tbl_accounts WHERE USERNAME = @username", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", userName)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Return Convert.ToBoolean(reader("ADMINPERMS"))
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Return False
    End Function

    Public Sub EVloadTable()
        Try
            openCon()
            cmd = New MySqlCommand()
            cmd.Connection = con
            cmd.CommandText = "
            SELECT v.PLACEID, v.TYPE, v.CAPACITY, v.PRICE,
                   GROUP_CONCAT(f.FEATURENAME ORDER BY f.FEATUREID SEPARATOR ', ') AS FEATURES
            FROM tbl_venues v
            JOIN tbl_pf pf ON v.PLACEID = pf.PLACEID
            JOIN tbl_venuefeatures f ON pf.FEATUREID = f.FEATUREID
            GROUP BY v.PLACEID, v.TYPE, v.CAPACITY, v.PRICE;"
            adapter.SelectCommand = cmd
            table.Clear()
            adapter.Fill(table)
            EditVenues.VenueTable.DataSource = table
            ViewVenues.VenueTable.DataSource = table
            EditVenues.VenueTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            ViewVenues.VenueTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public FeatureMap As New Dictionary(Of Integer, String) From {
    {1, "Air Conditioning"},
    {2, "Sound System"},
    {3, "Projector"},
    {4, "Wi-Fi"},
    {5, "Stage"},
    {6, "Lightings"}
    }

    Public Sub UpdateFeatureCheckboxesAdmin(ByVal features As String)
        Dim featureList = features.Split(","c).Select(Function(f) f.Trim()).ToList()

        EditVenues.cbox_AC.Checked = featureList.Contains("Air Conditioning")
        EditVenues.cbox_SS.Checked = featureList.Contains("Sound System")
        EditVenues.cbox_Projector.Checked = featureList.Contains("Projector")
        EditVenues.cbox_WiFi.Checked = featureList.Contains("Wi-Fi")
        EditVenues.cbox_Stage.Checked = featureList.Contains("Stage")
        EditVenues.cbox_Lightings.Checked = featureList.Contains("Lightings")
    End Sub

    Public Sub UpdateFeatureCheckboxesCustomer(ByVal features As String)
        Dim featureList = features.Split(","c).Select(Function(f) f.Trim()).ToList()

        BookEventPart1.cbox_AC.Checked = featureList.Contains("Air Conditioning")
        BookEventPart1.cbox_SS.Checked = featureList.Contains("Sound System")
        BookEventPart1.cbox_Projector.Checked = featureList.Contains("Projector")
        BookEventPart1.cbox_WiFi.Checked = featureList.Contains("Wi-Fi")
        BookEventPart1.cbox_Stage.Checked = featureList.Contains("Stage")
        BookEventPart1.cbox_Lightings.Checked = featureList.Contains("Lightings")
    End Sub

    Public Sub UpdateFeatureCheckboxesViewVenues(ByVal features As String)
        Dim featureList = features.Split(","c).Select(Function(f) f.Trim()).ToList()

        ViewVenues.cbox_AC.Checked = featureList.Contains("Air Conditioning")
        ViewVenues.cbox_SS.Checked = featureList.Contains("Sound System")
        ViewVenues.cbox_Projector.Checked = featureList.Contains("Projector")
        ViewVenues.cbox_WiFi.Checked = featureList.Contains("Wi-Fi")
        ViewVenues.cbox_Stage.Checked = featureList.Contains("Stage")
        ViewVenues.cbox_Lightings.Checked = featureList.Contains("Lightings")
    End Sub

    Public Sub LoadAndUpdateVenueFeatures(placeId As Integer)
        openCon()
        Dim query As String = "SELECT FEATUREID FROM tbl_pf WHERE PLACEID = @placeid"
        Dim cmd As New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@placeid", placeId)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim featureNames As New List(Of String)

        While reader.Read()
            Dim id As Integer = Convert.ToInt32(reader("FEATUREID"))
            If FeatureMap.ContainsKey(id) Then
                featureNames.Add(FeatureMap(id))
            End If
        End While

        reader.Close()
        con.Close()

        Dim featuresString As String = String.Join(", ", featureNames)
        BookEventPart1.featureslist = featuresString
        UpdateFeatureCheckboxesCustomer(featuresString)
    End Sub

    Public Sub InsertFeatures(placeId As Integer)
        Try
            openCon()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con

            Dim features As New Dictionary(Of CheckBox, Integer) From {
            {EditVenues.cbox_AC, 1},
            {EditVenues.cbox_SS, 2},
            {EditVenues.cbox_Projector, 3},
            {EditVenues.cbox_WiFi, 4},
            {EditVenues.cbox_Stage, 5},
            {EditVenues.cbox_Lightings, 6}
        }

            For Each pair In features
                If pair.Key.Checked Then
                    cmd.CommandText = "INSERT INTO tbl_pf (PLACEID, FEATUREID) VALUES (@placeid, @featureid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@placeid", placeId)
                    cmd.Parameters.AddWithValue("@featureid", pair.Value)
                    cmd.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub EnableEditVenues()
        EditVenues.cbox_AC.Enabled = True
        EditVenues.cbox_SS.Enabled = True
        EditVenues.cbox_Projector.Enabled = True
        EditVenues.cbox_WiFi.Enabled = True
        EditVenues.cbox_Stage.Enabled = True
        EditVenues.cbox_Lightings.Enabled = True
        EditVenues.txtbox_Type.Enabled = True
        EditVenues.txtbox_Capacity.Enabled = True
        EditVenues.txtbox_Price.Enabled = True
    End Sub

    Public Sub DisableEditVenues()
        EditVenues.cbox_AC.Enabled = False
        EditVenues.cbox_SS.Enabled = False
        EditVenues.cbox_Projector.Enabled = False
        EditVenues.cbox_WiFi.Enabled = False
        EditVenues.cbox_Stage.Enabled = False
        EditVenues.cbox_Lightings.Enabled = False
        EditVenues.txtbox_Type.Enabled = False
        EditVenues.txtbox_Capacity.Enabled = False
        EditVenues.txtbox_Price.Enabled = False
    End Sub

    Public Sub UpdateVenueAndFeatures(existingPlaceId As Integer)
        Try
            openCon()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE tbl_venues SET TYPE = @type, CAPACITY = @capacity, PRICE = @price WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@type", EditVenues.txtbox_Type.Text)
            cmd.Parameters.AddWithValue("@capacity", EditVenues.txtbox_Capacity.Text)
            cmd.Parameters.AddWithValue("@price", EditVenues.txtbox_Price.Text)
            cmd.Parameters.AddWithValue("@placeid", existingPlaceId)
            cmd.ExecuteNonQuery()

            cmd.CommandText = "DELETE FROM tbl_pf WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@placeid", existingPlaceId)
            cmd.ExecuteNonQuery()

            Dim features As New Dictionary(Of CheckBox, Integer) From {
                {EditVenues.cbox_AC, 1},
                {EditVenues.cbox_SS, 2},
                {EditVenues.cbox_Projector, 3},
                {EditVenues.cbox_WiFi, 4},
                {EditVenues.cbox_Stage, 5},
                {EditVenues.cbox_Lightings, 6}
        }

            For Each pair In features
                If pair.Key.Checked Then
                    cmd.CommandText = "INSERT INTO tbl_pf (PLACEID, FEATUREID) VALUES (@placeid, @featureid)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@placeid", existingPlaceId)
                    cmd.Parameters.AddWithValue("@featureid", pair.Value)
                    cmd.ExecuteNonQuery()
                End If
            Next

            MsgBox("Venue and features updated successfully!", MsgBoxStyle.Information, "")

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function EVCBCheck()
        If EditVenues.cbox_AC.Checked = False And EditVenues.cbox_SS.Checked = False And EditVenues.cbox_WiFi.Checked = False And EditVenues.cbox_AC.Checked = False And EditVenues.cbox_Stage.Checked = False And EditVenues.cbox_Lightings.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub BECBCheck()
        selectedServices.Clear()
        selectedServiceIDs.Clear()

        If BookEventPart1.cbox_Catering.Checked Then
            selectedServices.Add("Catering")
            selectedServiceIDs.Add(1)
        End If
        If BookEventPart1.cbox_Photography.Checked Then
            selectedServices.Add("Photography")
            selectedServiceIDs.Add(2)
        End If
        If BookEventPart1.cbox_Singer.Checked Then
            selectedServices.Add("Singer")
            selectedServiceIDs.Add(3)
        End If
        If BookEventPart1.cbox_Dancer.Checked Then
            selectedServices.Add("Dancer")
            selectedServiceIDs.Add(4)
        End If
        If BookEventPart1.cbox_Videoke.Checked Then
            selectedServices.Add("Videoke")
            selectedServiceIDs.Add(5)
        End If
        If BookEventPart1.cbox_Clown.Checked Then
            selectedServices.Add("Clown")
            selectedServiceIDs.Add(6)
        End If
    End Sub

    Private Sub ComputeTotalServicePrice()
        Dim totalPrice As Decimal = 0

        If selectedServices.Count = 0 Then
            servicePrice = 0
            Exit Sub
        End If

        openCon()

        For Each serviceName As String In selectedServices
            Dim query As String = "SELECT SERVICEPRICE FROM tbl_services WHERE SERVICENAME = @service"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@service", serviceName)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                totalPrice += Convert.ToDecimal(result)
            End If
        Next

        con.Close()

        servicePrice = totalPrice
    End Sub

    Public Sub EVUncheckCB()
        EditVenues.cbox_AC.Checked = False
        EditVenues.cbox_SS.Checked = False
        EditVenues.cbox_Projector.Checked = False
        EditVenues.cbox_WiFi.Checked = False
        EditVenues.cbox_Stage.Checked = False
        EditVenues.cbox_Lightings.Checked = False
    End Sub

    Public Sub DeleteVenue(existingPlaceId As Integer)
        Try
            openCon()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM tbl_pf WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@placeid", existingPlaceId)
            cmd.ExecuteNonQuery()

            cmd.CommandText = "DELETE FROM tbl_venues WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@placeid", existingPlaceId)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Venue is deleted successfully!")

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    Public Function CalculateAge(birthDate As Date) As Integer
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        If (birthDate > today.AddYears(-age)) Then
            age -= 1
        End If

        Return age
    End Function

    Public Function GetVenueCapacity(placeId As Integer) As Integer
        Dim capacity As Integer = 0

        Try
            openCon()

            Dim query As String = "SELECT CAPACITY FROM tbl_venues WHERE PLACEID = @placeid"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@placeid", placeId)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                capacity = Convert.ToInt32(result)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try

        BookEventPart1.lbl_MaxCapacity.Text = "max capacity: " & capacity & " pax"

        Return capacity
    End Function

    Public Function CalculateDateofEvent() As Date

        If Date.TryParse(BookEventPart1.startDate, dateStart) Then
            dateEnd = dateStart.AddDays(dayMultiplier - 1)
        Else
            MsgBox("Invalid number of days." & dateStart, MsgBoxStyle.Exclamation, "")
            Return Date.MinValue
        End If

        Return dateEnd
    End Function

    Public Function GetVenuePrice(placeId As Integer)
        Dim venueprice As Integer = 0

        Try
            openCon()

            Dim query As String = "SELECT PRICE FROM tbl_venues WHERE PLACEID = @placeid"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@placeid", placeId)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                venueprice = Convert.ToInt32(result)
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try

        BookEventPart1.lbl_PricePerDay.Text = "price per day: ₱ " & venueprice.ToString("N2")

        Return venueprice
    End Function

    Public Function CalculateExceedingGuests()
        Dim placeId As Integer = BookEventPart1.selectedPlaceId
        Dim capacity As Integer = GetVenueCapacity(placeid)
        Dim numOfGuests As Integer
        Dim numOfExceedingGuests As Integer

        Integer.TryParse(BookEventPart1.txtbox_NoOfGuests.Text, numOfGuests)
        numOfExceedingGuests = numOfGuests - capacity
        If numOfExceedingGuests <= 0 Then
            Return 0
        Else
            Return numOfExceedingGuests
        End If
    End Function

    Public Sub ConfirmationUpdate()
        placeId = BookEventPart1.selectedPlaceId
        dateBooked = Date.Today.ToString("MM-dd-yyyy")
        timeBooked = Date.Now.ToString("HH:mm:ss")
        fullName = BookEventPart2.txtbox_Name.Text
        address = BookEventPart2.txtbox_Address.Text
        birthDay = BookEventPart2.lbl_BirthdayFill.Text
        age = BookEventPart2.lbl_AgeFill.Text
        sex = BookEventPart2.cmb_Sex.Text
        features = BookEventPart1.featuresList
        venue = BookEventPart1.selectedVenue
        capacity = GetVenueCapacity(placeId)
        pricePerDay = GetVenuePrice(placeId)

        BookEventPart3.lbl_Name.Text = fullName
        BookEventPart3.lbl_VenuePlaceID.Text = "(" & placeId & ") " & venue
        BookEventPart3.lbl_Features.Text = features

        Integer.TryParse(BookEventPart1.txtbox_NoOfDays.Text, dayMultiplier)
        BookEventPart3.lbl_EDMultiplier.Text = "* " & dayMultiplier & " day / s"

        totalEventDatePrice = pricePerDay * dayMultiplier
        BookEventPart3.lbl_EventDatePrice.Text = "₱ " & totalEventDatePrice.ToString("N2")

        BECBCheck()
        BookEventPart3.lbl_Services.Text = String.Join(", ", selectedServices)

        ComputeTotalServicePrice()
        totalServicePriceWithDays = servicePrice * dayMultiplier
        BookEventPart3.lbl_ServicesPrice.Text = "₱ " & totalServicePriceWithDays.ToString("N2")

        If BookEventPart1.startDate = CalculateDateofEvent() Then
            BookEventPart3.lbl_EventDate.Text = BookEventPart1.formatstartDate.ToString("MM-dd-yyyy")
        Else
            BookEventPart3.lbl_EventDate.Text = BookEventPart1.formatstartDate.ToString("MM-dd-yyyy") & " ~ " & CalculateDateofEvent().ToString("MM-dd-yyyy")
        End If

        CalculateExceedingGuests()
        Integer.TryParse(BookEventPart1.txtbox_NoOfGuests.Text, numOfGuests)
        BookEventPart3.lbl_NoOfGuests.Text = numOfGuests - CalculateExceedingGuests() & " pax"
        BookEventPart3.lbl_ExceedingGuests.Text = "+ " & CalculateExceedingGuests() & " pax"
        ExceedingGuestsPrice = CalculateExceedingGuests() * 100
        totalGuestsPriceWithDays = ExceedingGuestsPrice * dayMultiplier
        BookEventPart3.lbl_ExceedGuestsPrice.Text = "₱ " & totalGuestsPriceWithDays.ToString("N2")

        totalPrice = totalEventDatePrice + totalServicePriceWithDays + totalGuestsPriceWithDays
        BookEventPart3.lbl_TotalPrice.Text = "₱ " & totalPrice.ToString("N2")
    End Sub

    Public Sub BookingstoMySQL()
        openCon()
        Dim cmd As New MySqlCommand("INSERT INTO tbl_bookings (
        USERID, PLACEID, DATEBOOKED, TIMEBOOKED, NAME, ADDRESS, BIRTHDAY, AGE, SEX, VENUE, FEATURES, 
        DATESTART, DATEEND, NUMBEROFDAYS, EVENTDATEPRICE, NUMOFGUESTS, NUMOFEXCEEDINGGUESTS, EXCEEDINGGUESTPRICE, 
        SERVICES, SERVICESPRICE, TOTALPRICE, APPROVESTATUS) 
        VALUES (
        @userid, @placeid, @datebooked, @timebooked, @name, @address, @birthday, @age, @sex, @venue, @features, 
        @datestart, @dateend, @numberofdays, @eventdateprice, @numofguests, @numofexceedingguests, @exceedingguestprice, 
        @services, @servicesprice, @totalprice, @approvestatus)", con)

        cmd.Parameters.AddWithValue("@userid", userId)
        cmd.Parameters.AddWithValue("@placeid", placeId)
        cmd.Parameters.AddWithValue("@datebooked", dateBooked)
        cmd.Parameters.AddWithValue("@timebooked", timeBooked)
        cmd.Parameters.AddWithValue("@name", fullName)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@birthday", birthDay)
        cmd.Parameters.AddWithValue("@age", age)
        cmd.Parameters.AddWithValue("@sex", sex)
        cmd.Parameters.AddWithValue("@venue", venue)
        cmd.Parameters.AddWithValue("@features", features)
        cmd.Parameters.AddWithValue("@datestart", dateStart)
        cmd.Parameters.AddWithValue("@dateend", dateEnd)
        cmd.Parameters.AddWithValue("@numberofdays", dayMultiplier)
        cmd.Parameters.AddWithValue("@eventdateprice", totalEventDatePrice)
        cmd.Parameters.AddWithValue("@numofguests", numOfGuests)
        cmd.Parameters.AddWithValue("@numofexceedingguests", numOfExceedingGuests)
        cmd.Parameters.AddWithValue("@exceedingguestprice", totalGuestsPriceWithDays)
        cmd.Parameters.AddWithValue("@services", String.Join(", ", selectedServices))
        cmd.Parameters.AddWithValue("@servicesprice", totalServicePriceWithDays)
        cmd.Parameters.AddWithValue("@totalprice", totalPrice)
        cmd.Parameters.AddWithValue("@approvestatus", "PENDING")

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Booking saved successfully.", MsgBoxStyle.Information, "")
            LoadBookings()
            FastFadeToForm(BookingList, BookEventPayment)
            BookEventClear()
        Catch ex As MySqlException
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub BookEventClear()
        BookEventPart1.Close()
        BookEventPart2.Close()
        BookEventPart3.Close()
        BookEventPayment.Close()
    End Sub

    Public Sub LoadBookings()
        openCon()

        Try
            Dim cmd As New MySqlCommand("
            SELECT b.BOOKINGID, b.VENUE, b.DATESTART, b.DATEEND, b.APPROVESTATUS 
            FROM tbl_bookings b
            WHERE b.USERID = @userid 
            ORDER BY b.DATEBOOKED DESC", con)

            cmd.Parameters.AddWithValue("@userid", userId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim i As Integer = 0
            BookingList.scrollablePanel.Controls.Clear()

            While reader.Read()
                Dim bookingId As String = reader("BOOKINGID").ToString()
                Dim venueName As String = reader("VENUE").ToString()
                Dim dateStart As DateTime = Convert.ToDateTime(reader("DATESTART")).Date
                Dim dateEnd As DateTime = Convert.ToDateTime(reader("DATEEND")).Date
                Dim approveStatus As String = reader("APPROVESTATUS").ToString().Trim().ToUpper()
                Dim timebooked As String

                If dateStart = dateEnd Then
                    timebooked = dateStart.ToString("MM-dd-yyyy")
                Else
                    timebooked = dateStart.ToString("MM-dd-yyyy") & " to " & dateEnd.ToString("MM-dd-yyyy")
                End If
                Dim statusText As String = "APPROVAL STATUS: " & approveStatus

                Dim newButton As New Button()
                newButton.Text = venueName & vbCrLf & timeBooked & vbCrLf & statusText
                newButton.TextAlign = ContentAlignment.MiddleCenter
                newButton.Font = New Font("Century Gothic", 12, FontStyle.Bold)
                newButton.Size = New Size(400, 200)
                newButton.FlatStyle = FlatStyle.Flat
                newButton.ForeColor = Color.White
                newButton.FlatAppearance.BorderSize = 0

                newButton.Tag = bookingId

                If approveStatus = "APPROVED" Then
                    newButton.BackColor = Color.FromArgb(172, 0, 255, 0)
                ElseIf approveStatus = "REJECTED" Then
                    newButton.BackColor = Color.FromArgb(172, 255, 0, 0)
                Else
                    newButton.BackColor = Color.FromArgb(172, 255, 165, 0)
                End If

                AddHandler newButton.Click, AddressOf BookingButton_Click

                newButton.Location = New Point(21 + (i * 420), 22)
                BookingList.scrollablePanel.Controls.Add(newButton)
                i += 1
            End While

            reader.Close()

            If i = 0 Then
                Dim emptyLabel As New Label()
                emptyLabel.Text = "No bookings found."
                emptyLabel.Font = New Font("Century Gothic", 16, FontStyle.Bold)
                emptyLabel.ForeColor = Color.Gray
                emptyLabel.AutoSize = True
                emptyLabel.Location = New Point(275, BookingList.scrollablePanel.Height \ 2 - 20)
                emptyLabel.Anchor = AnchorStyles.None
                BookingList.scrollablePanel.Controls.Add(emptyLabel)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BookingButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        selectedBookingId = btn.Tag.ToString()

        FastFadeToForm(ViewBookingDetails, BookingList)
        ViewSelectedBooking()
    End Sub

    Public Sub LogOut(currentForm As Form)
        Dim formsToClose As New List(Of Form)

        For Each frm As Form In Application.OpenForms
            If Not TypeOf frm Is LoginForm Then
                formsToClose.Add(frm)
            End If
        Next

        For Each frm As Form In formsToClose
            frm.Close()
        Next
    End Sub

    Public Sub ViewSelectedBooking()
        openCon()

        Dim cmd As New MySqlCommand("SELECT * FROM tbl_bookings WHERE BOOKINGID = @bookingid", con)
        cmd.Parameters.AddWithValue("@bookingid", selectedBookingId)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim placeId As Integer = Convert.ToInt32(reader("PLACEID"))
            Dim dateBooked As Date = Convert.ToDateTime(reader("DATEBOOKED"))
            Dim timeBooked As String = reader("TIMEBOOKED").ToString()
            Dim fullname As String = reader("NAME").ToString()
            Dim address As String = reader("ADDRESS").ToString()
            Dim birthday As Date = Convert.ToDateTime(reader("BIRTHDAY"))
            Dim age As Integer = Convert.ToInt32(reader("AGE"))
            Dim sex As String = reader("SEX").ToString()
            Dim venue As String = reader("VENUE").ToString()
            Dim features As String = reader("FEATURES").ToString()
            Dim dateStart As Date = Convert.ToDateTime(reader("DATESTART"))
            Dim dateEnd As Date = Convert.ToDateTime(reader("DATEEND"))
            Dim numberOfDays As Integer = Convert.ToInt32(reader("NUMBEROFDAYS"))
            Dim eventDatePrice As Decimal = Convert.ToDecimal(reader("EVENTDATEPRICE"))
            Dim numOfGuests As Integer = Convert.ToInt32(reader("NUMOFGUESTS"))
            Dim numOfExceedingGuests As Integer = Convert.ToInt32(reader("NUMOFEXCEEDINGGUESTS"))
            Dim exceedingGuestPrice As Decimal = Convert.ToDecimal(reader("EXCEEDINGGUESTPRICE"))
            Dim services As String = reader("SERVICES").ToString()
            Dim servicesPrice As Decimal = Convert.ToDecimal(reader("SERVICESPRICE"))
            Dim totalPrice As Decimal = reader("TOTALPRICE")
            Dim approveStatus As String = reader("APPROVESTATUS").ToString()

            ViewBookingDetails.lbl_Name.Text = fullname
            ViewBookingDetails.lbl_VenuePlaceID.Text = "(" & placeId & ") " & venue
            ViewBookingDetails.lbl_Features.Text = features
            ViewBookingDetails.lbl_EDMultiplier.Text = "* " & numberOfDays & " day / s"
            ViewBookingDetails.lbl_EventDatePrice.Text = "₱ " & eventDatePrice.ToString("N2")
            ViewBookingDetails.lbl_Services.Text = services
            ViewBookingDetails.lbl_ServicesPrice.Text = "₱ " & servicesPrice.ToString("N2")

            If dateStart = dateEnd Then
                ViewBookingDetails.lbl_EventDate.Text = dateStart.ToString("MM-dd-yyyy")
            Else
                ViewBookingDetails.lbl_EventDate.Text = dateStart.ToString("MM-dd-yyyy") & " ~ " & dateEnd.ToString("MM-dd-yyyy")
            End If

            ViewBookingDetails.lbl_NoOfGuests.Text = numOfGuests - numOfExceedingGuests & " pax"
            ViewBookingDetails.lbl_ExceedingGuests.Text = "+ " & numOfExceedingGuests & " pax"
            ExceedingGuestsPrice = exceedingGuestPrice
            totalGuestsPriceWithDays = exceedingGuestPrice * numberOfDays
            ViewBookingDetails.lbl_ExceedGuestsPrice.Text = "₱ " & totalGuestsPriceWithDays.ToString("N2")
            ViewBookingDetails.lbl_TotalPrice.Text = "₱ " & totalPrice.ToString("N2")

            If approveStatus = "APPROVED" Then
                MsgBox("The booking has been successfully approved.", MsgBoxStyle.Information, "")
            ElseIf approveStatus = "REJECTED" Then
                MsgBox("Booking rejected. A refund will be processed.", MsgBoxStyle.Information, "")
            End If
        Else
            MsgBox("Booking not found.", MsgBoxStyle.Exclamation, "")
        End If

        reader.Close()
        con.Close()
    End Sub

    Public Sub LoadBookingApproval()
        openCon()

        Try
            Dim cmd As New MySqlCommand("
            SELECT b.BOOKINGID, b.VENUE, b.DATESTART, b.DATEEND, b.APPROVESTATUS 
            FROM tbl_bookings b
            ORDER BY b.DATEBOOKED DESC", con)

            cmd.Parameters.AddWithValue("@userid", userId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim i As Integer = 0
            BookingApproval.scrollablePanel.Controls.Clear()

            While reader.Read()
                Dim bookingId As String = reader("BOOKINGID").ToString()
                Dim venueName As String = reader("VENUE").ToString()
                Dim dateStart As DateTime = Convert.ToDateTime(reader("DATESTART")).Date
                Dim dateEnd As DateTime = Convert.ToDateTime(reader("DATEEND")).Date
                Dim approveStatus As String = reader("APPROVESTATUS").ToString().Trim().ToUpper()
                Dim timebooked As String

                If dateStart = dateEnd Then
                    timebooked = dateStart.ToString("MM-dd-yyyy")
                Else
                    timebooked = dateStart.ToString("MM-dd-yyyy") & " to " & dateEnd.ToString("MM-dd-yyyy")
                End If
                Dim statusText As String = "APPROVAL STATUS: " & approveStatus

                Dim newButton As New Button()
                newButton.Text = venueName & vbCrLf & timebooked & vbCrLf & statusText
                newButton.TextAlign = ContentAlignment.MiddleCenter
                newButton.Font = New Font("Century Gothic", 12, FontStyle.Bold)
                newButton.Size = New Size(400, 200)
                newButton.FlatStyle = FlatStyle.Flat
                newButton.ForeColor = Color.White
                newButton.FlatAppearance.BorderSize = 0

                newButton.Tag = bookingId

                If approveStatus = "APPROVED" Then
                    newButton.BackColor = Color.FromArgb(172, 0, 255, 0)
                ElseIf approveStatus = "REJECTED" Then
                    newButton.BackColor = Color.FromArgb(172, 255, 0, 0)
                Else
                    newButton.BackColor = Color.FromArgb(172, 255, 165, 0)
                End If

                AddHandler newButton.Click, AddressOf ApprovalButton_Click

                newButton.Location = New Point(21 + (i * 420), 22)
                BookingApproval.scrollablePanel.Controls.Add(newButton)
                i += 1
            End While

            reader.Close()

            If i = 0 Then
                Dim emptyLabel As New Label()
                emptyLabel.Text = "No bookings found."
                emptyLabel.Font = New Font("Century Gothic", 16, FontStyle.Bold)
                emptyLabel.ForeColor = Color.Gray
                emptyLabel.AutoSize = True
                emptyLabel.Location = New Point(275, BookingList.scrollablePanel.Height \ 2 - 20)
                emptyLabel.Anchor = AnchorStyles.None
                BookingApproval.scrollablePanel.Controls.Add(emptyLabel)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ApprovalButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        selectedBookingId = btn.Tag.ToString()

        FastFadeToForm(BookingApprovalDetails, BookingApproval)
        ViewSelectedBookingApproval()
    End Sub

    Public Sub ViewSelectedBookingApproval()
        openCon()

        Dim cmd As New MySqlCommand("SELECT * FROM tbl_bookings WHERE BOOKINGID = @bookingid", con)
        cmd.Parameters.AddWithValue("@bookingid", selectedBookingId)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim placeId As Integer = Convert.ToInt32(reader("PLACEID"))
            Dim dateBooked As Date = Convert.ToDateTime(reader("DATEBOOKED"))
            Dim timeBooked As String = reader("TIMEBOOKED").ToString()
            Dim fullname As String = reader("NAME").ToString()
            Dim address As String = reader("ADDRESS").ToString()
            Dim birthday As Date = Convert.ToDateTime(reader("BIRTHDAY"))
            Dim age As Integer = Convert.ToInt32(reader("AGE"))
            Dim sex As String = reader("SEX").ToString()
            Dim venue As String = reader("VENUE").ToString()
            Dim features As String = reader("FEATURES").ToString()
            Dim dateStart As Date = Convert.ToDateTime(reader("DATESTART"))
            Dim dateEnd As Date = Convert.ToDateTime(reader("DATEEND"))
            Dim numberOfDays As Integer = Convert.ToInt32(reader("NUMBEROFDAYS"))
            Dim eventDatePrice As Decimal = Convert.ToDecimal(reader("EVENTDATEPRICE"))
            Dim numOfGuests As Integer = Convert.ToInt32(reader("NUMOFGUESTS"))
            Dim numOfExceedingGuests As Integer = Convert.ToInt32(reader("NUMOFEXCEEDINGGUESTS"))
            Dim exceedingGuestPrice As Decimal = Convert.ToDecimal(reader("EXCEEDINGGUESTPRICE"))
            Dim services As String = reader("SERVICES").ToString()
            Dim servicesPrice As Decimal = Convert.ToDecimal(reader("SERVICESPRICE"))
            Dim totalPrice As Decimal = reader("TOTALPRICE")
            Dim approveStatus As String = reader("APPROVESTATUS").ToString()

            BookingApprovalDetails.lbl_Name.Text = fullname
            BookingApprovalDetails.lbl_VenuePlaceID.Text = "(" & placeId & ") " & venue
            BookingApprovalDetails.lbl_Features.Text = features
            BookingApprovalDetails.lbl_EDMultiplier.Text = "* " & numberOfDays & " day / s"
            BookingApprovalDetails.lbl_EventDatePrice.Text = "₱ " & eventDatePrice.ToString("N2")
            BookingApprovalDetails.lbl_Services.Text = services
            BookingApprovalDetails.lbl_ServicesPrice.Text = "₱ " & servicesPrice.ToString("N2")

            If dateStart = dateEnd Then
                BookingApprovalDetails.lbl_EventDate.Text = dateStart.ToString("MM-dd-yyyy")
            Else
                BookingApprovalDetails.lbl_EventDate.Text = dateStart.ToString("MM-dd-yyyy") & " ~ " & dateEnd.ToString("MM-dd-yyyy")
            End If

            BookingApprovalDetails.lbl_NoOfGuests.Text = numOfGuests - numOfExceedingGuests & " pax"
            BookingApprovalDetails.lbl_ExceedingGuests.Text = "+ " & numOfExceedingGuests & " pax"
            ExceedingGuestsPrice = exceedingGuestPrice
            totalGuestsPriceWithDays = exceedingGuestPrice * numberOfDays
            BookingApprovalDetails.lbl_ExceedGuestsPrice.Text = "₱ " & totalGuestsPriceWithDays.ToString("N2")
            BookingApprovalDetails.lbl_TotalPrice.Text = "₱ " & totalPrice.ToString("N2")
        Else
            MsgBox("Booking not found.", MsgBoxStyle.Exclamation, "")
        End If

        reader.Close()
        con.Close()
    End Sub

    Public Sub ApproveBooking()
        Try
            openCon()
            Dim cmd As New MySqlCommand("UPDATE tbl_bookings SET APPROVESTATUS = 'APPROVED' WHERE BOOKINGID = @bookingId", con)
            cmd.Parameters.AddWithValue("@bookingId", selectedBookingId)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Booking approved successfully!", MsgBoxStyle.Information, "")
                LoadBookingApproval()
            Else
                MsgBox("No booking found to approve.", MsgBoxStyle.Exclamation, "")
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub RejectBooking()
        Try
            openCon()
            Dim cmd As New MySqlCommand("UPDATE tbl_bookings SET APPROVESTATUS = 'REJECTED' WHERE BOOKINGID = @bookingId", con)
            cmd.Parameters.AddWithValue("@bookingId", selectedBookingId)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MsgBox("Booking rejected successfully!", MsgBoxStyle.Information, "")
                LoadBookingApproval()
            Else
                MsgBox("No booking found to reject.", MsgBoxStyle.Exclamation, "")
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            con.Close()
        End Try
    End Sub

End Module
