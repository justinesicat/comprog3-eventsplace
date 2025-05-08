Public Class BookEventPayment

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub pbox_Home_Click(sender As Object, e As EventArgs) Handles pbox_Home.Click
        FastFadeToForm(HomeCustomerForm, Me)
    End Sub

    Private Sub pbox_Venue_Click(sender As Object, e As EventArgs) Handles pbox_Venue.Click
        FastFadeToForm(ViewVenues, Me)
    End Sub

    Private Sub pbox_Account_Click(sender As Object, e As EventArgs) Handles pbox_Account.Click
        FastFadeToForm(AccountCustomer, Me)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        FastFadeToForm(BookEventPart3, Me)
    End Sub

    Private Sub btn_Pay_Click(sender As Object, e As EventArgs) Handles btn_Pay.Click
        Dim confirmationResult As Boolean

        confirmationResult = MsgBox("You are about to pay, continue?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "")

        If confirmationResult = True Then
            If radio_Card.Checked = True Then
                If EmptyCardCheck() = True Then
                    If ValidateCardHolderName() = True Then
                        If ValidateCardNumber() = True And ValidateExpiryDate() = True And ValidateCVCCVV() = True Then
                            PaymentSuccess()
                            BookingstoMySQL()
                        End If
                    End If
                End If

            End If
            If radio_Cash.Checked = True Then
                If ValidateCash() = True Then
                    PaymentSuccess()
                    BookingstoMySQL()
                End If
            End If
        End If
    End Sub

    Private Sub radio_Cash_CheckedChanged(sender As Object, e As EventArgs) Handles radio_Cash.CheckedChanged
        txtbox_Amount.Enabled = True
        txtbox_CardHolderName.Enabled = False
        txtbox_CardNumber.Enabled = False
        txtbox_ExpiryDate.Enabled = False
        txtbox_CVCCVV.Enabled = False
    End Sub

    Private Sub radio_Card_CheckedChanged(sender As Object, e As EventArgs) Handles radio_Card.CheckedChanged
        txtbox_Amount.Enabled = False
        txtbox_CardHolderName.Enabled = True
        txtbox_CardNumber.Enabled = True
        txtbox_ExpiryDate.Enabled = True
        txtbox_CVCCVV.Enabled = True
    End Sub

    Private Sub txtbox_Amount_TextChanged(sender As Object, e As EventArgs) Handles txtbox_Amount.TextChanged
        Dim amount As Decimal
        Dim change As Decimal

        If txtbox_Amount.Text = "" Then
            txtbox_Change.Text = ""
            Exit Sub
        End If

        If Not Decimal.TryParse(txtbox_Amount.Text.Replace(",", "").Trim(), amount) Then
            txtbox_Change.Text = ""
            Exit Sub
        End If

        change = amount - totalPrice
        txtbox_Change.Text = change.ToString("N2")
    End Sub

    Private Function ValidateCardHolderName() As Boolean
        If txtbox_CardHolderName.Text <> BookEventPart3.lbl_Name.Text Then
            Dim question As MsgBoxResult = MsgBox("The card holder's name is different from the event booker's name. Proceed?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "")
            If question = MsgBoxResult.No Then
                Return False
            Else
                Return True
            End If
        End If

        Return True
    End Function

    Private Function ValidateCardNumber() As Boolean
        Dim cardNumber As String = txtbox_CardNumber.Text.Replace(" ", "").Trim()

        If Not IsNumeric(cardNumber) Then
            MsgBox("Card number must contain digits only.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        If cardNumber.Length < 15 Or cardNumber.Length > 19 Then
            MsgBox("Card number must be between 15 and 19 digits.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        Return True
    End Function

    Private Function ValidateExpiryDate() As Boolean
        Dim expiryDate As DateTime
        Dim dateFormat As String = "MM-dd-yyyy"

        If DateTime.TryParseExact(txtbox_ExpiryDate.Text, dateFormat, Nothing, Nothing, expiryDate) = False Then
            MsgBox("Please enter a valid date in MM-dd-yyyy format.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        If expiryDate < DateTime.Now Then
            MsgBox("The card is already expired.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        Return True
    End Function

    Private Function ValidateCVCCVV() As Boolean
        Dim cvcCvv As String = txtbox_CVCCVV.Text

        If Integer.TryParse(cvcCvv, 0) = False Then
            MsgBox("CVV must contain only digits.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        If cvcCvv.Length <> 3 AndAlso cvcCvv.Length <> 4 Then
            MsgBox("CVV must be 3 or 4 digits long.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        Return True
    End Function

    Private Function EmptyCardCheck() As Boolean
        If txtbox_CardHolderName.Text = "" Or txtbox_CardNumber.Text = "" Or txtbox_ExpiryDate.Text = "" Or txtbox_CVCCVV.Text = "" Then
            MsgBox("Please fill up all fields.", MsgBoxStyle.Exclamation, "")
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidateCash() As Boolean
        Dim cash As Integer
        Dim change As String = txtbox_Change.Text.Replace(",", "")
        Dim intChange As Integer = Integer.TryParse(change, intChange)

        If Not Integer.TryParse(txtbox_Amount.Text.Replace(",", ""), cash) Then
            MsgBox("Cash must contain only digits.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        If change < 0 Then
            MsgBox("You don't have enough cash to pay.", MsgBoxStyle.Exclamation, "")
            Return False
        End If

        Return True
    End Function

    Private Sub PaymentSuccess()
        If radio_Cash.Checked = True Then
            Dim change As Decimal
            If Decimal.TryParse(txtbox_Change.Text.Replace(",", ""), change) Then
                MsgBox("Payment successful! Your change is ₱ " & change.ToString("N2"), MsgBoxStyle.Information, "")
            End If
        End If

        If radio_Card.Checked = True Then
            MsgBox("Your card has been charged ₱ " & totalPrice.ToString("N2") & ".", MsgBoxStyle.Information, "")
        End If
    End Sub

End Class