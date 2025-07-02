Public Class MainMenu

    Private Sub MainMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RefreshData()
    End Sub


    Public Sub RefreshData()
        Label8.Text = Login.currentName
        Label9.Text = Login.currentPhoneNumber
        Label10.Text = "₱ " + Login.currentLoadBal.ToString
        Label11.Text = Login.currentActivePromo
        Label12.Text = Login.currentRewardBal

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Load
        Loadf.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Promo
        Promo.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Reward
        Reward.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Log Out

        Login.TextBox1.ResetText()
        Login.TextBox2.ResetText()

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class