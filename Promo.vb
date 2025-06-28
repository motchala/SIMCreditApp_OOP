
Public Class Promo
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Promo Offer
        NavigationManager.FormHistory.Push(Me)
        Dim newForm As New Promo_PromoOffer()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Limited Offers
        NavigationManager.FormHistory.Push(Me)
        Dim newForm1 As New Promo_LimitedOffer()
        newForm1.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Buy Load
        NavigationManager.FormHistory.Push(Me)
        Dim newForm3 As New Load()
        newForm3.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        ' Menu
        NavigationManager.FormHistory.Push(Me)
        Dim newForm4 As New mainMenu()
        newForm4.Show()
        Me.Hide()
    End Sub

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

    Private Sub Promo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
