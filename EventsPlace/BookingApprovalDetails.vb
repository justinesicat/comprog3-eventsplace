Public Class BookingApprovalDetails
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeAdminForm, Me)
    End Sub

    Private Sub pbox_EditVenues_Click(sender As Object, e As EventArgs) Handles pbox_EditVenues.Click
        FastFadeToForm(EditVenues, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountAdmin, Me)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(BookingApproval, Me)
    End Sub

    Private Sub btn_Approve_Click(sender As Object, e As EventArgs) Handles btn_Approve.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to approve this booking?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "")

        If response = MsgBoxResult.Yes Then
            ApproveBooking()
            FastFadeToForm(BookingApproval, Me)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As MsgBoxResult
        response = MsgBox("Are you sure you want to reject this booking? This action will process a refund for the booker.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "")

        If response = MsgBoxResult.Yes Then
            RejectBooking()
            FastFadeToForm(BookingApproval, Me)
        End If
    End Sub
End Class