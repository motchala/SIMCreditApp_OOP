Public Class Rewards
    Dim result As MsgBoxResult

    Private Sub Reward_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub



    Private Sub btn_Back(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Close()
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub



    Private Sub btnReward_1(sender As Object, e As EventArgs) Handles Button2.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReward_2(sender As Object, e As EventArgs) Handles Button3.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnReward_3(sender As Object, e As EventArgs) Handles Button4.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReward_4(sender As Object, e As EventArgs) Handles Button7.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReward_5(sender As Object, e As EventArgs) Handles Button6.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReward_6(sender As Object, e As EventArgs) Handles Button5.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        result = MsgBox("Proceed with the transaction?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirm Transaction")
        If result = MsgBoxResult.Yes Then
            TransactionDetails.Show()
        ElseIf result = MsgBoxResult.No Then
            MessageBox.Show("Transaction cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    ' This ensures the entire application exits when the Rewards form is closed
    Private Sub Rewards_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
