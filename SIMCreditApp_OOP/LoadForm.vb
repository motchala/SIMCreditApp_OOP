Public Class LoadForm
    Private Sub LoadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub MobileNumberTxt(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub BtnLoad30_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PurchaseLoad(29)
    End Sub

    Private Sub BtnLoad50_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PurchaseLoad(48)
    End Sub

    Private Sub BtnLoad100_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PurchaseLoad(97)
    End Sub

    Private Sub BtnLoad200_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PurchaseLoad(188)
    End Sub

    Private Sub BtnLoad500_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PurchaseLoad(450)
    End Sub

    Private Sub BtnLoad1000_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PurchaseLoad(900)
    End Sub

    Private Sub TxtBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub BtnProceedSubmit_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim amount As Decimal
        If Not Decimal.TryParse(TextBox2.Text.Trim(), amount) Then
            MessageBox.Show("Please enter a valid load amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        PurchaseLoad(amount)
    End Sub

    Private Sub PurchaseLoad(amount As Decimal)
        Dim mobileNumber As String = TextBox1.Text.Trim()
        If mobileNumber = "" OrElse mobileNumber.Length <> 11 OrElse Not mobileNumber.StartsWith("09") Then
            MessageBox.Show("Please enter a valid 11-digit mobile number starting with '09'.", "Invalid Mobile", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If amount < 5 OrElse amount > 100 Then
            MessageBox.Show("Load amount must be 5 - 1000.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Send " & amount.ToString("0.00") & "load to" & mobileNumber & "?", "ConfirmPurchase", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Form2.CurrentBalance -= amount
            MessageBox.Show(" " & amount.ToString("0.00") & " load sent to " & mobileNumber, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox2.Text = ""

            Form2.UpdateBalanceLabel()

        Else
            MessageBox.Show("Transaction cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

End Class