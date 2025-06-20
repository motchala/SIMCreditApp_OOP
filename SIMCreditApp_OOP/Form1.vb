Public Class Form1

    Private Sub BuyLoadBtn(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim loadForm As New LoadForm()
        loadForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BuyPromosBtn(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub RewardsBtn(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HomeLbl(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Backbtn(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
