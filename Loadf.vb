Public Class Loadf
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Buy Promo
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
            Login.loadPurchased = Login.acc1_loadBal
            MessageBox.Show("New Balance: " & Login.acc1_loadBal.ToString())

        ElseIf Login.pNumber = Login.acc2_pNumber Then
            Login.acc2_loadBal += loadAmount
            Login.loadPurchased = Login.acc2_loadBal
            MessageBox.Show("New Balance: " & Login.acc2_loadBal.ToString())

        ElseIf Login.pNumber = Login.acc3_pNumber Then
            Login.acc3_loadBal += loadAmount
            Login.loadPurchased = Login.acc3_loadBal
            MessageBox.Show("New Balance: " & Login.acc3_loadBal.ToString())

        ElseIf Login.pNumber = Login.acc4_pNumber Then
            Login.acc4_loadBal += loadAmount
            Login.loadPurchased = Login.acc4_loadBal
            MessageBox.Show("New Balance: " & Login.acc4_loadBal.ToString())

        Else
            MessageBox.Show("Phone number not recognized.")
        End If





        'If Login.pNumber = Login.acc1_pNumber Then

        '    If Login.inputLoadAmount < 10 Or Login.inputLoadAmount > 1000 Then
        '        MessageBox.Show("Please input amount between 10 - 1000 pesos")
        '    ElseIf Login.inputLoadAmount >= 10 Or Login.inputLoadAmount <= 1000 Then
        '        Login.loadPurchased += Login.inputLoadAmount + Login.acc2_loadBal
        '        MessageBox.Show(Login.loadP)
        '    Else
        '        MessageBox.Show("Invalid Input")
        '    End If

        'End If

    End Sub
End Class