Public Class Reward


    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Reward_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Telco Offers
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel1.Visible = False
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Panel1.Visible = True
    End Sub

    ' Vouchers
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel2.Visible = False
    End Sub
    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Panel2.Visible = True
    End Sub

    Private Sub btnPromo1_Click(sender As Object, e As EventArgs) Handles btnPromo1.Click
        ' ML10
        If Login.currentRewardBal < 1.0 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 1.0
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub btnPromo2_Click(sender As Object, e As EventArgs) Handles btnPromo2.Click
        ' FB20
        If Login.currentRewardBal < 2.0 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 2.0
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' STREAM
        If Login.currentRewardBal < 3.0 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 3.0
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' IQIYI
        If Login.currentRewardBal < 3.0 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 3.0
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Bilibili
        If Login.currentRewardBal < 3.8 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 3.8
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Crunchyroll
        If Login.currentRewardBal < 5.0 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 5.0
                MainMenu.RefreshData()
            End If
        End If
    End Sub



    ' VOUCHERS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Starbucks
        If Login.currentRewardBal < 1.5 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 1.5
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Jamba Juice
        If Login.currentRewardBal < 1.8 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 1.8
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' J.Co
        If Login.currentRewardBal < 3.9 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 3.9
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ' Potato Corner
        If Login.currentRewardBal < 5.6 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 5.6
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ' UniSilver
        If Login.currentRewardBal < 9.0 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 9.0
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' SM Voucher
        If Login.currentRewardBal < 7.5 Then
            MessageBox.Show("Insufficient Balance")
        Else
            Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Login.currentRewardBal -= 7.5
                MainMenu.RefreshData()
            End If
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        ' Load 
        Loadf.Show()
        Me.Hide()
    End Sub
End Class