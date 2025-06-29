Public Class SignUp

    Public Shared fName As String
    Public Shared age As Int32
    Public Shared email As String
    Public Shared pNumber As String
    Public Shared password As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Sign Up
        If ifName.Text.Trim() = "" Or iAge.Text.Trim() = "" Or iEmail.Text.Trim() = "" Or iNumber.Text.Trim() = "" Or iPass.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not Int32.TryParse(iAge.Text, SignUp.age) Then
            MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        fName = ifName.Text
        email = iEmail.Text
        pNumber = iNumber.Text
        password = iPass.Text

        MessageBox.Show("Account registered successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub
End Class
