Public Class Loadf
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Buy Promo
        MainMenu.RefreshData()
        Promo.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Login.inputLoadAmount = TextBox2.Text

        Dim loadAmount As Integer

        If Not Integer.TryParse(TextBox2.Text, loadAmount) Then
            MessageBox.Show("Please enter a valid number.")
            Return
        End If

        If loadAmount < 10 Or loadAmount > 1000 Then
            MessageBox.Show("Please input amount between 10 - 1000 pesos")
            Return
        End If

        Login.inputLoadAmount = loadAmount

        If Login.pNumber = Login.acc1_pNumber Then
            Login.acc1_loadBal += loadAmount
            Login.currentLoadBal = Login.acc1_loadBal

        ElseIf Login.pNumber = Login.acc2_pNumber Then
            Login.acc2_loadBal += loadAmount
            Login.currentLoadBal = Login.acc2_loadBal

        ElseIf Login.pNumber = Login.acc3_pNumber Then
            Login.acc3_loadBal += loadAmount
            Login.currentLoadBal = Login.acc3_loadBal

        ElseIf Login.pNumber = Login.acc4_pNumber Then
            Login.acc4_loadBal += loadAmount
            Login.currentLoadBal = Login.acc4_loadBal

        Else
            MessageBox.Show("Phone number not recognized.")
            Return
        End If

        MessageBox.Show("New Balance: " & Login.currentLoadBal.ToString())





    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        ' Main Menu
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
        ' 30
        TextBox2.Text = 30

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 50
        TextBox2.Text = 50

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' 100
        TextBox2.Text = 100

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' 200
        TextBox2.Text = 200

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' 500
        TextBox2.Text = 500

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' 1000
        TextBox2.Text = 1000

    End Sub
End Class