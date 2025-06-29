Public Class Loadf
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Buy Promo
        Promo.Show()
        Me.Hide()
    End Sub
End Class