Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class RegisterForm
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        If txtb_Username.Text = "" OrElse txtb_Password.Text = "" OrElse txtb_ReEnter.Text = "" Then
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If txtb_Username.Text.Contains(" ") Or txtb_Password.Text.Contains(" ") Then
            MsgBox("Username or Password cannot contain spaces.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If txtb_Password.Text <> txtb_ReEnter.Text Then
            MsgBox("Passwords do not match.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If UsernameExists(txtb_Username.Text) Then
            MsgBox("User already exists. Please use another name.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Try
            openCon()
            cmd.Connection = con
            cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO tbl_accounts (`USERNAME`, `PASSWORD`, `ADMINPERMS`) VALUES (@username, @password, @adminperms)"
            cmd.Parameters.AddWithValue("@username", txtb_Username.Text)
            cmd.Parameters.AddWithValue("@password", txtb_Password.Text)
            cmd.Parameters.AddWithValue("@adminperms", False)
            cmd.ExecuteNonQuery()
            MsgBox("Account successfully registered.", MsgBoxStyle.Information, "")

            con.Close()

            LoginForm.txtb_Username.Clear()
            LoginForm.txtb_Password.Clear()
            FastFadeToForm(LoginForm, Me)

        Catch ex As Exception
            MsgBox("Error during registration: " & ex.Message, MsgBoxStyle.Critical, "")
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub


    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(LoginForm, Me)
        LoginForm.txtb_Username.Clear()
        LoginForm.txtb_Password.Clear()
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class