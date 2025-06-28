

Public Class Promo_PromoOffer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        'Back
        If NavigationManager.FormHistory.Count > 0 Then
            Dim prevForm As Form = NavigationManager.FormHistory.Pop()
            prevForm.Show()
            Me.Close()
        Else
            MessageBox.Show("No previous form.")
        End If
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


End Class