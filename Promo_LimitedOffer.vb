Public Class Promo_LimitedOffer
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Back
        Promo.Show()
        Me.Hide()
    End Sub

    Private Sub Promo_LimitedOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '10
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '20
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '50
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '99
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '120
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '150
        Dim result As DialogResult = MessageBox.Show("Do you want to avail" & vbCrLf & "this offer?", "Confirm Purchase",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have successfully" & vbCrLf & "availed the offer!", "Purchase Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class