Imports MySql.Data.MySqlClient
Imports System.IO

Public Class EditVenues
    Dim doubleClickEnabled As Boolean = True
    Dim placeid

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountAdmin, Me)
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeAdminForm, Me)
    End Sub

    Private Sub EditVenues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EVloadTable()
        VenueTable.Columns("PLACEID").Visible = False
        VenueTable.Columns("FEATURES").Visible = False

        btn_Cancel.Visible = False
        btn_Cancel.Enabled = False
        btn_Edit.Enabled = False
        btn_New.Enabled = True
        btn_New.Visible = True
        btn_Save.Enabled = False
        btn_Delete.Enabled = False
        btn_SaveEdit.Enabled = False
        btn_SaveEdit.Visible = False
        btn_UploadImage.Enabled = False
        pbox_VenuePic.Image = Nothing
        lbl_NoImage.Visible = True
    End Sub

    Private Sub VenueTable_DoubleClick(sender As Object, e As EventArgs) Handles VenueTable.DoubleClick
        If Not doubleClickEnabled Then
            Exit Sub
        End If

        txtb_Type.Text = VenueTable("TYPE", VenueTable.CurrentRow.Index).Value
        txtb_Capacity.Text = VenueTable("CAPACITY", VenueTable.CurrentRow.Index).Value
        txtb_Price.Text = VenueTable("PRICE", VenueTable.CurrentRow.Index).Value
        placeid = VenueTable("PLACEID", VenueTable.CurrentRow.Index).Value

        Dim features As String = VenueTable.CurrentRow.Cells("FEATURES").Value.ToString()
        UpdateFeatureCheckboxesAdmin(features)

        LoadImageFromDatabase()

        btn_Edit.Enabled = True
        btn_Delete.Enabled = True
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(HomeAdminForm, Me)
    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click
        doubleClickEnabled = False
        txtb_Type.Clear()
        txtb_Capacity.Clear()
        txtb_Price.Clear()

        EnableEditVenues()

        btn_Edit.Enabled = False
        btn_Save.Enabled = True
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        btn_Cancel.Visible = True
        btn_New.Visible = False
        btn_New.Enabled = False
        btn_UploadImage.Enabled = True
        pbox_VenuePic.Image = Nothing
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        doubleClickEnabled = True
        txtb_Type.Clear()
        txtb_Capacity.Clear()
        txtb_Price.Clear()

        EVUncheckCB()
        DisableEditVenues()
        btn_Cancel.Visible = False
        btn_Cancel.Enabled = False
        btn_Edit.Enabled = False
        btn_New.Enabled = True
        btn_New.Visible = True
        btn_SaveEdit.Enabled = False
        btn_SaveEdit.Visible = False
        btn_Save.Visible = True
        btn_Save.Enabled = False
        btn_Delete.Enabled = False
        btn_UploadImage.Enabled = False
        pbox_VenuePic.Image = Nothing
        lbl_NoImage.Visible = True
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        doubleClickEnabled = True
        If txtb_Type.Text IsNot "" And txtb_Capacity.Text IsNot "" And txtb_Price.Text IsNot "" Then
            If Integer.TryParse(txtb_Capacity.Text, 0) Then
                If Integer.TryParse(txtb_Price.Text, 0) Then
                    EVCBCheck()
                    If EVCBCheck() = True Then
                        openCon()
                        Try
                            cmd.Connection = con
                            cmd.CommandText = "INSERT INTO tbl_venues (TYPE, CAPACITY, PRICE) VALUES (@type, @capacity, @price)"
                            cmd.Parameters.AddWithValue("@type", txtb_Type.Text)
                            cmd.Parameters.AddWithValue("@capacity", txtb_Capacity.Text)
                            cmd.Parameters.AddWithValue("@price", txtb_Price.Text)
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "SELECT LAST_INSERT_ID()"
                            cmd.Parameters.Clear()
                            Dim newPlaceID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                            InsertFeatures(newPlaceID)
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try

                        cmd.ExecuteNonQuery()
                        SaveImageToDatabase()
                        MsgBox("Successfully Added Venue!")
                        con.Close()
                        txtb_Type.Clear()
                        txtb_Capacity.Clear()
                        txtb_Price.Clear()
                        EVloadTable()

                        DisableEditVenues()
                        EVUncheckCB()
                        btn_Cancel.Visible = False
                        btn_Cancel.Enabled = False
                        btn_Edit.Enabled = False
                        btn_New.Enabled = True
                        btn_New.Visible = True
                        btn_Save.Enabled = False
                        btn_Delete.Enabled = False
                        btn_UploadImage.Enabled = False
                        pbox_VenuePic.Image = Nothing
                        lbl_NoImage.Visible = True
                    Else
                        MsgBox("Please check at least one feature.", MsgBoxStyle.Exclamation, "")
                    End If
                Else
                    MsgBox("The price entered is not an integer.", MsgBoxStyle.Exclamation, "")
                End If
            Else
                MsgBox("The capacity entered is not an integer.", MsgBoxStyle.Exclamation, "")
            End If
        Else
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
        End If

    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        doubleClickEnabled = False
        txtb_Type.Text = VenueTable("TYPE", VenueTable.CurrentRow.Index).Value
        txtb_Capacity.Text = VenueTable("CAPACITY", VenueTable.CurrentRow.Index).Value
        txtb_Price.Text = VenueTable("PRICE", VenueTable.CurrentRow.Index).Value

        Dim features As String = VenueTable.CurrentRow.Cells("FEATURES").Value.ToString()
        UpdateFeatureCheckboxesAdmin(features)

        LoadImageFromDatabase()

        EnableEditVenues()
        btn_Edit.Enabled = False
        btn_Save.Enabled = False
        btn_Save.Visible = False
        btn_SaveEdit.Enabled = True
        btn_SaveEdit.Visible = True
        btn_Delete.Enabled = False
        btn_Cancel.Enabled = True
        btn_Cancel.Visible = True
        btn_New.Visible = False
        btn_New.Enabled = False
        btn_UploadImage.Enabled = True
    End Sub

    Private Sub btn_SaveEdit_Click(sender As Object, e As EventArgs) Handles btn_SaveEdit.Click
        doubleClickEnabled = True
        If txtb_Type.Text IsNot "" And txtb_Capacity.Text IsNot "" And txtb_Price.Text IsNot "" Then
            If Integer.TryParse(txtb_Capacity.Text, 0) Then
                If Integer.TryParse(txtb_Price.Text, 0) Then
                    EVCBCheck()
                    If EVCBCheck() = True Then
                        openCon()

                        Dim selectedPlaceID As Integer = VenueTable("PLACEID", VenueTable.CurrentRow.Index).Value
                        UpdateVenueAndFeatures(selectedPlaceID)
                        SaveImageToDatabase()

                        txtb_Type.Clear()
                        txtb_Capacity.Clear()
                        txtb_Price.Clear()
                        EVloadTable()

                        DisableEditVenues()
                        EVUncheckCB()
                        btn_Cancel.Visible = False
                        btn_Cancel.Enabled = False
                        btn_Edit.Enabled = False
                        btn_New.Enabled = True
                        btn_New.Visible = True
                        btn_Save.Enabled = False
                        btn_Save.Visible = True
                        btn_SaveEdit.Enabled = False
                        btn_SaveEdit.Visible = False
                        btn_Delete.Enabled = False
                        btn_UploadImage.Enabled = False
                        pbox_VenuePic.Image = Nothing
                        lbl_NoImage.Visible = True
                    Else
                        MsgBox("Please check at least one feature.", MsgBoxStyle.Exclamation, "")
                    End If
                Else
                    MsgBox("The price entered is not an integer.", MsgBoxStyle.Exclamation, "")
                End If
            Else
                MsgBox("The capacity entered is not an integer.", MsgBoxStyle.Exclamation, "")
            End If
        Else
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        Dim response
        response = MsgBox("Are you sure you want to delete this?", MsgBoxStyle.YesNo, "")
        If response = vbYes Then
            openCon()

            Dim selectedPlaceID As Integer = VenueTable("PLACEID", VenueTable.CurrentRow.Index).Value
            DeleteVenue(selectedPlaceID)

            txtb_Type.Clear()
            txtb_Capacity.Clear()
            txtb_Price.Clear()
            EVloadTable()

            DisableEditVenues()
            EVUncheckCB()
            btn_Cancel.Visible = False
            btn_Cancel.Enabled = False
            btn_Edit.Enabled = False
            btn_New.Enabled = True
            btn_New.Visible = True
            btn_Save.Enabled = False
            btn_Save.Visible = True
            btn_SaveEdit.Enabled = False
            btn_SaveEdit.Visible = False
            btn_Delete.Enabled = False
            btn_UploadImage.Enabled = False
            pbox_VenuePic.Image = Nothing
            lbl_NoImage.Visible = True
        End If
    End Sub

    Private Sub SaveImageToDatabase()
        If pbox_VenuePic.Image Is Nothing Then
            Return
        End If

        Try
            Dim ms As New MemoryStream()
            pbox_VenuePic.Image.Save(ms, pbox_VenuePic.Image.RawFormat)
            Dim imgBytes As Byte() = ms.ToArray()

            openCon()

            Dim cmd As New MySqlCommand("UPDATE tbl_venues SET image = @image WHERE placeid = @placeid", con)
            cmd.Parameters.AddWithValue("@image", imgBytes)
            cmd.Parameters.AddWithValue("@placeid", placeid)

            cmd.ExecuteNonQuery()

            btn_UploadImage.Enabled = False

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadImageFromDatabase()
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

    Private Sub btn_UploadImage_Click(sender As Object, e As EventArgs) Handles btn_UploadImage.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            pbox_VenuePic.Image = Image.FromFile(ofd.FileName)
            pbox_VenuePic.SizeMode = PictureBoxSizeMode.Zoom
            lbl_NoImage.Visible = False
            btn_UploadImage.Enabled = True
        End If
    End Sub

    Private Sub btn_SaveImage_Click(sender As Object, e As EventArgs)
        SaveImageToDatabase()
    End Sub

End Class