Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim acc1_fName As String = "Frederick Rosales"
    Dim acc1_age As Int16 = 21
    Dim acc1_email As String = "iamfrederickr@gmail.com"
    Dim acc1_pNumber As String = "09662668443"
    Dim acc1_pass As String = "1234"

    Dim acc2_fName As String = "Aiello Lastrella"
    Dim acc2_age As Int16 = 20
    Dim acc2_email As String = "lastrella@gmail.com"
    Dim acc2_pNumber As String = "09396590005"
    Dim acc2_pass As String = "123"

    Dim acc3_fName As String = "Wendelyn Salazar"
    Dim acc3_age As Int16 = 19
    Dim acc3_email As String = "wanda@gmail.com"
    Dim acc3_pNumber As String = "09112233445"
    Dim acc3_pass As String = "12345"

    Dim acc4_fName As String = "Kaye Mallonga"
    Dim acc4_age As Int16 = 19
    Dim acc4_email As String = "kayeM@gmail.com"
    Dim acc4_pNumber As String = "09987654321"
    Dim acc4_pass As String = "4321"



    ' getter lang 'to 
    Dim fName As String
    Dim age As Int32
    Dim email As String
    Dim pNumber As String
    Dim pass As String






    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        pNumber = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        pass = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text.Trim() = "" Or TextBox2.Text.Trim() = "" Then
            MessageBox.Show("Please enter both phone number and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf pNumber = acc1_pNumber And pass = acc1_pass Or
            pNumber = acc2_pNumber And pass = acc2_pass Or
            pNumber = acc3_pNumber And pass = acc3_pass Or
            pNumber = acc4_pNumber And pass = acc4_pass Or
            pNumber = SignUp.pNumber And pass = SignUp.password Then

            Promo.Show()
            Me.Hide()

        Else
            MessageBox.Show("Incorrect Login credentials.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Dim newForm As New signUp_Form()
        SignUp.Show()
        Me.Hide()
    End Sub


End Class
