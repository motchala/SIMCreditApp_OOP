﻿Imports System.Runtime.CompilerServices

Public Class Promo_LimitedOffer
    Private Sub Promo_LimitedOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Back
        Promo.Show()
        Me.Hide()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
                Login.currentActivePromo = "Limited 10"

                Login.currentRewardBal += 0.1
                MainMenu.RefreshData()
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                Login.currentActivePromo = "Limited 20"

                Login.currentRewardBal += 0.2
                MainMenu.RefreshData()
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '50
        If Login.currentLoadBal < 50 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 50
                Login.currentActivePromo = "Limited 50"

                Login.currentRewardBal += 0.3
                MainMenu.RefreshData()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '99
        If Login.currentLoadBal < 99 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 99
                Login.currentActivePromo = "Limited 99"

                Login.currentRewardBal += 0.4
                MainMenu.RefreshData()
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '120
        If Login.currentLoadBal < 120 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 120
                Login.currentActivePromo = "Limited 120"

                Login.currentRewardBal += 0.5
                MainMenu.RefreshData()
            End If
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '150
        If Login.currentLoadBal < 150 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentLoadBal -= 150
                Login.currentActivePromo = "Limited 150"

                Login.currentRewardBal += 0.6
                MainMenu.RefreshData()
            End If
        End If

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        'Main Menu
        MainMenu.RefreshData()
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        'Buy Load
        Loadf.Show()
        Me.Hide()
    End Sub
End Class