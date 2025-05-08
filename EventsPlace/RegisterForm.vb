Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class RegisterForm
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(LoginForm, Me)
        LoginForm.txtb_UserName.Clear()
        LoginForm.txtb_Password.Clear()
    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        If txtb_UserName.Text = "" OrElse txtb_Password.Text = "" OrElse txtb_ReEnter.Text = "" Then
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If txtb_UserName.Text.Contains(" ") Or txtb_Password.Text.Contains(" ") Then
            MsgBox("Username or Password cannot contain spaces.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If txtb_Password.Text <> txtb_ReEnter.Text Then
            MsgBox("Passwords do not match.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If UsernameExists(txtb_UserName.Text) Then
            MsgBox("User already exists. Please use another name.", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Try
            RegisterAccount()
            LoginForm.txtb_UserName.Clear()
            LoginForm.txtb_Password.Clear()
            FastFadeToForm(LoginForm, Me)

        Catch ex As Exception
            MsgBox("Error during registration: " & ex.Message, MsgBoxStyle.Critical, "")
        Finally
            con.Close()
        End Try
    End Sub

End Class