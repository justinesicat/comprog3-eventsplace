Public Class AccountAdmin
    Public username As String
    Public password As String

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_EditVenues_Click(sender As Object, e As EventArgs) Handles pbox_EditVenues.Click
        FastFadeToForm(EditVenues, Me)
    End Sub

    Public Sub setUsernamePassword(name As String, pass As String)
        username = name
        password = pass
        txtb_Username.Text = name
        txtb_Password.Text = pass
    End Sub

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs) Handles btn_LogOut.Click
        Dim result As DialogResult = MsgBox("Are you sure you want to log out?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "")

        If result = DialogResult.Yes Then
            FastFadeToForm(LoginForm, Me)
            LogOut(Me)
            LoginForm.txtb_UserName.Clear()
            LoginForm.txtb_Password.Clear()
        End If
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeAdminForm, Me)
    End Sub

    Private Sub pbox_BookingApproval_Click(sender As Object, e As EventArgs) Handles pbox_BookingApproval.Click
        FastFadeToForm(BookingApproval, Me)
    End Sub

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        btn_LogOut.Visible = False
        btn_Save.Visible = True
        btn_Cancel.Visible = True
        btn_Edit.Visible = False
        txtb_Username.Enabled = True
        txtb_Password.Enabled = True
    End Sub
    Private Sub ResetEditMode()
        btn_LogOut.Visible = True
        btn_Save.Visible = False
        btn_Cancel.Visible = False
        btn_Edit.Visible = True
        txtb_Username.Enabled = False
        txtb_Password.Enabled = False
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        ResetEditMode()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txtb_Username.Text = username AndAlso txtb_Password.Text = password Then
            MsgBox("No changes were made.", MsgBoxStyle.Information, "")
            ResetEditMode()
            Exit Sub
        End If

        If txtb_Username.Text = "" OrElse txtb_Password.Text = "" Then
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
            txtb_Username.Text = username
            txtb_Password.Text = password
            Exit Sub
        End If

        If txtb_Username.Text.Contains(" ") Or txtb_Password.Text.Contains(" ") Then
            MsgBox("Username or Password cannot contain spaces.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If UsernameExists(txtb_Username.Text) AndAlso txtb_Username.Text IsNot username Then
            MsgBox("Username already exists. Please use another.", MsgBoxStyle.Exclamation, "")
            txtb_Username.Text = username
            txtb_Password.Text = password
            Exit Sub
        End If

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "UPDATE tbl_accounts SET `USERNAME` = @username, `PASSWORD` = @password WHERE `ID` = @id"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", txtb_Username.Text)
            cmd.Parameters.AddWithValue("@password", txtb_Password.Text)
            cmd.Parameters.AddWithValue("@id", userId)
            cmd.ExecuteNonQuery()
            MsgBox("Account successfully updated.", MsgBoxStyle.Information, "")

            setUsernamePassword(txtb_Username.Text, txtb_Password.Text)
            HomeCustomerForm.setUsername(txtb_Username.Text)

            ResetEditMode()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "")
        Finally
            con.Close()
        End Try
    End Sub

End Class