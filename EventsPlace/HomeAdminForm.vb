Public Class HomeAdminForm
    Dim imageList As New List(Of Image)()
    Dim currentImageIndex As Integer = 0

    Private Sub HomeAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageList.Add(My.Resources.Banner1)
        imageList.Add(My.Resources.Banner2)
        imageList.Add(My.Resources.Banner3)
        imageList.Add(My.Resources.Banner4)
        imageList.Add(My.Resources.Banner5)

        pbox_Display.Image = imageList(currentImageIndex)
    End Sub

    Private Sub pbox_Display_Click(sender As Object, e As EventArgs) Handles pbox_Display.Click
        currentImageIndex += 1
        If currentImageIndex >= imageList.Count Then
            currentImageIndex = 0
        End If

        pbox_Display.Image = imageList(currentImageIndex)
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub setUsername(name As String)
        userName = name
        lbl_Username.Text = "Welcome, " & userName & "!"
    End Sub

    Private Sub btn_EditVenues_Click(sender As Object, e As EventArgs) Handles btn_EditVenues.Click
        FastFadeToForm(EditVenues, Me)
    End Sub

    Private Sub pbox_EditVenues_Click(sender As Object, e As EventArgs) Handles pbox_EditVenues.Click
        FastFadeToForm(EditVenues, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountAdmin, Me)
    End Sub

    Private Sub pbox_BookingApproval_Click(sender As Object, e As EventArgs) Handles pbox_BookingApproval.Click
        FastFadeToForm(BookingApproval, Me)
    End Sub

    Private Sub btn_BookingApproval_Click(sender As Object, e As EventArgs) Handles btn_BookingApproval.Click
        FastFadeToForm(BookingApproval, Me)
    End Sub
End Class