
Public Class Promo
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Promo Offer
        MainMenu.RefreshData()
        Promo_PromoOffer.Show(Login)
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Limited Offers
        MainMenu.RefreshData()
        Promo_LimitedOffer.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Buy Load
        MainMenu.RefreshData()
        Loadf.Show(Login)
        Me.Hide()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        ' Menu
        MainMenu.RefreshData()
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Back
        MainMenu.RefreshData()
        MainMenu.Show()
        Me.Hide()
    End Sub



    Private Sub btnPromo1_Click(sender As Object, e As EventArgs) Handles btnPromo1.Click
        'Fawk 10
        If Login.currentLoadBal < 10 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 10?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 10!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 10

                Login.currentRewardBal += 0.1
                MainMenu.RefreshData()
            End If

        End If
    End Sub

    Private Sub btnPromo2_Click(sender As Object, e As EventArgs) Handles btnPromo2.Click
        'Fawk 20
        If Login.currentLoadBal < 20 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 20?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 20!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 20

                Login.currentRewardBal += 0.2
                MainMenu.RefreshData()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '10
        If Login.currentLoadBal < 10 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 10

                Login.currentRewardBal += 0.3
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '20
        If Login.currentLoadBal < 20 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 20

                Login.currentRewardBal += 0.4
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Fawk 59
        If Login.currentLoadBal < 59 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 59?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 59!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 59

                Login.currentRewardBal += 0.5
                MainMenu.RefreshData()
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '20
        If Login.currentLoadBal < 20 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 20

                Login.currentRewardBal += 0.6
                MainMenu.RefreshData()
            End If
        End If
    End Sub


    Private Sub Promo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
