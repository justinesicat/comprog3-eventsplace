Imports MySql.Data.MySqlClient
Module Module1
    Public con As MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable
    Public userId As Integer
    Public username As String

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

    Public Function UsernameExists(username As String) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT COUNT(*) FROM tbl_accounts WHERE USERNAME = @username", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function PasswordMatch(username As String, password As String) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT ID FROM tbl_accounts WHERE USERNAME = @username AND PASSWORD = @password", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                userId = reader("ID")
                username = username
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

    Public Function IsAdmin(username As String) As Boolean
        Try
            openCon()
            cmd = New MySqlCommand("SELECT ADMINPERMS FROM tbl_accounts WHERE USERNAME = @username", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", username)

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
            EditVenues.VenueTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
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

        Dim featuresString As String = String.Join(",", featureNames)
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
        EditVenues.txtb_Type.Enabled = True
        EditVenues.txtb_Capacity.Enabled = True
        EditVenues.txtb_Price.Enabled = True
    End Sub

    Public Sub DisableEditVenues()
        EditVenues.cbox_AC.Enabled = False
        EditVenues.cbox_SS.Enabled = False
        EditVenues.cbox_Projector.Enabled = False
        EditVenues.cbox_WiFi.Enabled = False
        EditVenues.cbox_Stage.Enabled = False
        EditVenues.cbox_Lightings.Enabled = False
        EditVenues.txtb_Type.Enabled = False
        EditVenues.txtb_Capacity.Enabled = False
        EditVenues.txtb_Price.Enabled = False
    End Sub

    Public Sub UpdateVenueAndFeatures(existingPlaceID As Integer)
        Try
            openCon()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con

            cmd.CommandText = "UPDATE tbl_venues SET TYPE = @type, CAPACITY = @capacity, PRICE = @price WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@type", EditVenues.txtb_Type.Text)
            cmd.Parameters.AddWithValue("@capacity", EditVenues.txtb_Capacity.Text)
            cmd.Parameters.AddWithValue("@price", EditVenues.txtb_Price.Text)
            cmd.Parameters.AddWithValue("@placeid", existingPlaceID)
            cmd.ExecuteNonQuery()

            cmd.CommandText = "DELETE FROM tbl_pf WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@placeid", existingPlaceID)
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
                    cmd.Parameters.AddWithValue("@placeid", existingPlaceID)
                    cmd.Parameters.AddWithValue("@featureid", pair.Value)
                    cmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Venue and features updated successfully!")

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

    Public Sub EVUncheckCB()
        EditVenues.cbox_AC.Checked = False
        EditVenues.cbox_SS.Checked = False
        EditVenues.cbox_Projector.Checked = False
        EditVenues.cbox_WiFi.Checked = False
        EditVenues.cbox_Stage.Checked = False
        EditVenues.cbox_Lightings.Checked = False
    End Sub

    Public Sub DeleteVenue(existingPlaceID As Integer)

        Try
            openCon()
            Dim cmd As New MySqlCommand()
            cmd.Connection = con

            cmd.CommandText = "DELETE FROM tbl_pf WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@placeid", existingPlaceID)
            cmd.ExecuteNonQuery()

            cmd.CommandText = "DELETE FROM tbl_venues WHERE PLACEID = @placeid"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@placeid", existingPlaceID)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Venue is deleted successfully!")

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
End Module
