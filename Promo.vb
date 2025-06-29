
Public Class Promo
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Promo Offer
        Promo_PromoOffer.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Limited Offers
        Promo_LimitedOffer.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Buy Load
        Loadf.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        ' Menu
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Back
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Fawk 149
        Dim result As DialogResult = MessageBox.Show("Do you want to subscribed" & vbCrLf & "to Fawk 149?", "Confirm Subscription",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 149!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPromo1_Click(sender As Object, e As EventArgs) Handles btnPromo1.Click
        'Fawk 10
        Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 10?", "Confirm Subscription",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 10!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPromo2_Click(sender As Object, e As EventArgs) Handles btnPromo2.Click
        'Fawk 20
        Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 20?", "Confirm Subscription",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 20!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '10
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '20
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Fawk 99
        Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 99?", "Confirm Subscription",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 99!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '20
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
