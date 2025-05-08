Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ViewVenues
    Dim doubleClickEnabled As Boolean = True
    Dim placeid

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeCustomerForm, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountCustomer, Me)
    End Sub

    Private Sub pbox_Booking_Click(sender As Object, e As EventArgs) Handles pbox_Booking.Click
        FastFadeToForm(BookingList, Me)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(HomeCustomerForm, Me)
    End Sub

    Private Sub EditVenues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EVloadTable()
        VenueTable.Columns("CAPACITY").Visible = False
        VenueTable.Columns("PRICE").Visible = False
        VenueTable.Columns("FEATURES").Visible = False

        pbox_VenuePic.Image = Nothing
        lbl_NoImage.Visible = True
    End Sub

    Private Sub VenueTable_DoubleClick(sender As Object, e As EventArgs) Handles VenueTable.DoubleClick
        If Not doubleClickEnabled Then
            Exit Sub
        End If

        lbl_VenueType.Text = VenueTable("TYPE", VenueTable.CurrentRow.Index).Value
        txtb_Type.Text = VenueTable("TYPE", VenueTable.CurrentRow.Index).Value
        txtb_Capacity.Text = VenueTable("CAPACITY", VenueTable.CurrentRow.Index).Value
        txtb_Price.Text = VenueTable("PRICE", VenueTable.CurrentRow.Index).Value
        placeId = VenueTable("PLACEID", VenueTable.CurrentRow.Index).Value

        Dim features As String = VenueTable.CurrentRow.Cells("FEATURES").Value.ToString()
        UpdateFeatureCheckboxesViewVenues(features)

        LoadImageFromDatabase()
    End Sub

    Private Sub LoadImageFromDatabase()
        openCon()
        Dim cmd As New MySqlCommand("SELECT image FROM tbl_venues WHERE PLACEID = @placeid", con)
        cmd.Parameters.AddWithValue("@placeid", placeId)

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class