﻿Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim acc1_fName As String = "Frederick Rosales"
    Dim acc1_age As Int16 = 21
    Dim acc1_email As String = "iamfrederickr@gmail.com"
    Public Shared acc1_pNumber As String = "09662668443"
    Dim acc1_pass As String = "1234"
    Public Shared acc1_loadBal As Int32 = 70
    Public Shared acc1_rewardBal As Double = 2.6


    Dim acc2_fName As String = "Aiello Lastrella"
    Dim acc2_age As Int16 = 20
    Dim acc2_email As String = "lastrella@gmail.com"
    Public Shared acc2_pNumber As String = "09396590005"
    Dim acc2_pass As String = "123"
    Public Shared acc2_loadBal As Int32 = 44
    Public Shared acc2_rewardBal As Double = 1.3

    Dim acc3_fName As String = "Wendelyn Salazar"
    Dim acc3_age As Int16 = 19
    Dim acc3_email As String = "wanda@gmail.com"
    Public Shared acc3_pNumber As String = "09112233445"
    Dim acc3_pass As String = "12345"
    Public Shared acc3_loadBal As Int32 = 72
    Public Shared acc3_rewardBal As Double = 0.9

    Dim acc4_fName As String = "Kaye Mallonga"
    Dim acc4_age As Int16 = 19
    Dim acc4_email As String = "kayeM@gmail.com"
    Public Shared acc4_pNumber As String = "09987654321"
    Dim acc4_pass As String = "4321"
    Public Shared acc4_loadBal As Int32 = 130
    Public Shared acc4_rewardBal As Double = 4.1



    ' getter lang 'to 
    Dim fName As String
    Dim age As Int32
    Dim email As String
    Public Shared pNumber As String
    Public Shared pass As String


    ' Load Forms Variables
    Public Shared inputLoadAmount As Int32
    Public Shared loadPurchased As Int32






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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Exit Button
        Application.Exit()
    End Sub
End Class
