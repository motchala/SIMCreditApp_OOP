Public Class Promo_LimitedOffer
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Back
        If NavigationManager.FormHistory.Count > 0 Then
            Dim prevForm As Form = NavigationManager.FormHistory.Pop()
            prevForm.Show()
            Me.Close()
        Else
            MessageBox.Show("No previous form.")
        End If
    End Sub

    Private Sub Promo_LimitedOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class