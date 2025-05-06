Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        con.Close()
    End Sub
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        FastFadeToForm(RegisterForm, Me)
        RegisterForm.txtb_Username.Clear()
        RegisterForm.txtb_Password.Clear()
        RegisterForm.txtb_ReEnter.Clear()
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If txtb_Username.Text IsNot "" And txtb_Password.Text IsNot "" Then
            Try
                If PasswordMatch(txtb_Username.Text, txtb_Password.Text) Then
                    MsgBox("Login successful. Welcome, " & txtb_Username.Text & "!", MsgBoxStyle.Information, "")

                    Try
                        If IsAdmin(txtb_Username.Text) Then
                            username = txtb_Username.Text
                            HomeAdminForm.setUsername(username)
                            AccountAdmin.setUsernamePassword(txtb_Username.Text, txtb_Password.Text)
                            FastFadeToForm(HomeAdminForm, Me)
                        Else
                            username = txtb_Username.Text
                            HomeCustomerForm.setUsername(username)
                            AccountCustomer.setUsernamePassword(txtb_Username.Text, txtb_Password.Text)
                            FastFadeToForm(HomeCustomerForm, Me)
                            Me.Hide()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                Else
                    MsgBox("Invalid credentials.", MsgBoxStyle.Exclamation, "")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Please fill up all the fields.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Sub pbox_viewPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles pbox_viewPassword.MouseDown
        txtb_Password.UseSystemPasswordChar = False
    End Sub
    Private Sub pbox_viewPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles pbox_viewPassword.MouseUp
        txtb_Password.UseSystemPasswordChar = True
    End Sub

End Class