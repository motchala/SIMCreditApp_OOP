Public Class signIn_Form

    Dim setNumber As String = "09396590005"
    Dim setPin As String = "1234"
    Dim phoneNumber As String
    Dim Pin As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        phoneNumber = TextBox1.Text

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Pin = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If phoneNumber <> setNumber Or Pin <> setPin Then
            MessageBox.Show("Credentials didn't match.")
        ElseIf phoneNumber = setNumber And Pin = setPin Then
            mainMenu.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim newForm As New signUp_Form()
        newForm.Show()
        Me.Hide()
    End Sub
End Class
