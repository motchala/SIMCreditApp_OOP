Public Class SignUp

    Public Shared fName As String
    Public Shared age As Int32
    Public Shared email As String
    Public Shared pNumber As String
    Public Shared password As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Sign Up
        If ifName.Text.Trim() = "" Or iAge.Text.Trim() = "" Or iNumber.Text.Trim() = "" Or iPass.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not Int32.TryParse(iAge.Text, SignUp.age) Then
            MessageBox.Show("Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Save input to shared SignUp variables
        fName = ifName.Text
        age = Convert.ToInt32(iAge.Text)
        pNumber = iNumber.Text
        password = iPass.Text

        ' Assign values to acc4 slot
        Login.acc4_fName = fName
        Login.acc4_age = age
        Login.acc4_pNumber = pNumber
        Login.acc4_pass = password
        Login.acc4_loadBal = 0
        Login.acc4_rewardBal = 0
        Login.acc4_promo = "No Active Promo"

        MessageBox.Show("Account registered successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
