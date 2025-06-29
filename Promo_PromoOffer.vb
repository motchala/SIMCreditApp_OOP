﻿

Public Class Promo_PromoOffer

    Private Sub Promo_PromoOffer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        MainMenu.RefreshData()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'Back
        Promo.Show()
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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.RefreshData()

        For Each ctrl As Control In Me.Controls
            If Not (TypeOf ctrl Is VScrollBar Or ctrl Is Panel7) Then
                ctrl.Tag = ctrl.Top
            End If
        Next

        VScrollBar1.Width = 0
        VScrollBar1.BackColor = Me.BackColor
        VScrollBar1.Minimum = 0

        Dim maxBottom As Integer = 0
        For Each ctrl As Control In Me.Controls
            If Not TypeOf ctrl Is VScrollBar Then
                Dim ctrlBottom As Integer = CInt(ctrl.Tag) + ctrl.Height
                If ctrlBottom > maxBottom Then maxBottom = ctrlBottom
            End If
        Next

        Dim extraPadding As Integer = 55
        Dim scrollRange As Integer = (maxBottom + extraPadding) - Me.ClientSize.Height

        VScrollBar1.LargeChange = Me.ClientSize.Height
        VScrollBar1.Maximum = scrollRange + VScrollBar1.LargeChange - 1
        VScrollBar1.SmallChange = 20

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim scrollVal As Integer = Math.Min(VScrollBar1.Value, VScrollBar1.Maximum - VScrollBar1.LargeChange)

        For Each ctrl As Control In Me.Controls
            If Not (TypeOf ctrl Is VScrollBar Or ctrl Is Panel7) Then
                ctrl.Top = CInt(ctrl.Tag) - scrollVal
            End If
        Next
    End Sub

    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        MyBase.OnMouseWheel(e)

        Dim newValue As Integer = VScrollBar1.Value - (e.Delta \ 3)
        newValue = Math.Max(VScrollBar1.Minimum, Math.Min(VScrollBar1.Maximum - VScrollBar1.LargeChange, newValue))

        VScrollBar1.Value = newValue

        For Each ctrl As Control In Me.Controls
            If Not (TypeOf ctrl Is VScrollBar Or ctrl Is Panel7) Then
                ctrl.Top = CInt(ctrl.Tag) - newValue
            End If
        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                Login.currentActivePromo = "Fawk 10"

                Login.currentRewardBal += 0.1
                MainMenu.RefreshData()

            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                Login.currentActivePromo = "Fawk 20"

                Login.currentRewardBal += 0.2
                MainMenu.RefreshData()

            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Fawk 59
        If Login.currentLoadBal < 55 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 59?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 59!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 55
                Login.currentActivePromo = "Fawk 59"

                Login.currentRewardBal += 0.3
                MainMenu.RefreshData()

            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Fawk 99
        If Login.currentLoadBal < 90 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 99?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 99!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 90
                Login.currentActivePromo = "Fawk 99"

                Login.currentRewardBal += 0.4
                MainMenu.RefreshData()

            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Fawk 149
        If Login.currentLoadBal < 135 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 149?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 149!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 135
                Login.currentActivePromo = "Fawk 149"

                Login.currentRewardBal += 0.5
                MainMenu.RefreshData()

            End If

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Fawk 249
        If Login.currentLoadBal < 225 Then
            MessageBox.Show("Insufficient Balance")

        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to subscribe" & vbCrLf & "to Fawk 249?", "Confirm Subscription",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "subscribed to Fawk 249!", "Subscribed Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 225
                Login.currentActivePromo = "Fawk 249"

                Login.currentRewardBal += 0.6
                MainMenu.RefreshData()

            End If

        End If
    End Sub

End Class