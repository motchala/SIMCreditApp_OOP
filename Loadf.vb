Public Class Loadf
    Dim loadAmount As Integer
    Dim rewardPoints As Integer

    ' Manages the adding of reward points in load
    Private Sub AddRewardFromLoad()
        Dim earnedPoints As Double = 0

        ' adds corresponding reward points to the account
        If loadAmount >= 10 AndAlso loadAmount <= 30 Then
            earnedPoints = 1.1
        ElseIf loadAmount > 30 AndAlso loadAmount <= 80 Then
            earnedPoints = 1.6
        ElseIf loadAmount > 80 AndAlso loadAmount <= 150 Then
            earnedPoints = 1.9
        ElseIf loadAmount > 150 AndAlso loadAmount <= 300 Then
            earnedPoints = 2.4
        ElseIf loadAmount > 300 AndAlso loadAmount <= 500 Then
            earnedPoints = 3.8
        ElseIf loadAmount > 500 AndAlso loadAmount <= 1000 Then
            earnedPoints = 5.0
        End If

        If earnedPoints > 0 Then
            If Login.pNumber = Login.acc1_pNumber Then
                Login.acc1_rewardBal += earnedPoints
            ElseIf Login.pNumber = Login.acc2_pNumber Then
                Login.acc2_rewardBal += earnedPoints
            ElseIf Login.pNumber = Login.acc3_pNumber Then
                Login.acc3_rewardBal += earnedPoints
            ElseIf Login.pNumber = Login.acc4_pNumber Then
                Login.acc4_rewardBal += earnedPoints
            End If

            Login.currentRewardBal += earnedPoints
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        MainMenu.RefreshData()
        Promo.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Proceed Button

        Login.inputLoadAmount = TextBox2.Text

        If Not Integer.TryParse(TextBox2.Text, loadAmount) Then
            MessageBox.Show("Please enter a valid number.")
            Return
        End If

        If loadAmount < 10 Or loadAmount > 1000 Then
            MessageBox.Show("Please input amount between 10 - 1000 pesos")
            Return
        End If

        Dim inputPhone As String = TextBox1.Text.Trim()

        If inputPhone = "" Then
            MessageBox.Show("Input a phone number")
            Return
        ElseIf inputPhone <> Login.pNumber Then
            MessageBox.Show("Transaction Success! " & vbCrLf & "Added " + loadAmount.ToString + " Load")
            TextBox2.Text = ""
            TextBox1.Text = ""
            Return
        End If

        Login.inputLoadAmount = loadAmount
        Login.inputPhoneNumber = inputPhone

        If inputPhone = Login.acc1_pNumber Then
            Login.acc1_loadBal += loadAmount
            Login.currentLoadBal = Login.acc1_loadBal

        ElseIf inputPhone = Login.acc2_pNumber Then
            Login.acc2_loadBal += loadAmount
            Login.currentLoadBal = Login.acc2_loadBal

        ElseIf inputPhone = Login.acc3_pNumber Then
            Login.acc3_loadBal += loadAmount
            Login.currentLoadBal = Login.acc3_loadBal

        ElseIf inputPhone = Login.acc4_pNumber Then
            Login.acc4_loadBal += loadAmount
            Login.currentLoadBal = Login.acc4_loadBal

        ElseIf inputPhone = SignUp.pNumber Then
            Login.currentLoadBal += loadAmount

        Else
            MessageBox.Show("Phone number is not recognized in the system.")
            Return
        End If

        AddRewardFromLoad()

        MessageBox.Show(loadAmount.ToString + " Load added successfully!" & vbCrLf & "New Balance: " & Login.currentLoadBal.ToString())
        MainMenu.RefreshData()
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        MainMenu.RefreshData()
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MainMenu.RefreshData()
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = 30
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = 50
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = 100
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = 200
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = 500
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = 1000
    End Sub

    Private Sub Loadf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
    End Sub
End Class
