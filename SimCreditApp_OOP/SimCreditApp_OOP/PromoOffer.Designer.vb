<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoOffer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPromo5 = New System.Windows.Forms.Button()
        Me.btnPromo6 = New System.Windows.Forms.Button()
        Me.btnPromo7 = New System.Windows.Forms.Button()
        Me.btnPromo8 = New System.Windows.Forms.Button()
        Me.btnPromo9 = New System.Windows.Forms.Button()
        Me.btnPromo1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPromo5
        '
        Me.btnPromo5.Location = New System.Drawing.Point(346, 154)
        Me.btnPromo5.Name = "btnPromo5"
        Me.btnPromo5.Size = New System.Drawing.Size(109, 143)
        Me.btnPromo5.TabIndex = 5
        Me.btnPromo5.Text = "FAWK 149"
        Me.btnPromo5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPromo5.UseVisualStyleBackColor = True
        '
        'btnPromo6
        '
        Me.btnPromo6.Location = New System.Drawing.Point(178, 193)
        Me.btnPromo6.Name = "btnPromo6"
        Me.btnPromo6.Size = New System.Drawing.Size(96, 80)
        Me.btnPromo6.TabIndex = 6
        Me.btnPromo6.Text = "FAWK 249"
        Me.btnPromo6.UseVisualStyleBackColor = True
        '
        'btnPromo7
        '
        Me.btnPromo7.Location = New System.Drawing.Point(146, 83)
        Me.btnPromo7.Name = "btnPromo7"
        Me.btnPromo7.Size = New System.Drawing.Size(96, 80)
        Me.btnPromo7.TabIndex = 7
        Me.btnPromo7.Text = "FAWK 349"
        Me.btnPromo7.UseVisualStyleBackColor = True
        '
        'btnPromo8
        '
        Me.btnPromo8.Location = New System.Drawing.Point(534, 109)
        Me.btnPromo8.Name = "btnPromo8"
        Me.btnPromo8.Size = New System.Drawing.Size(109, 143)
        Me.btnPromo8.TabIndex = 8
        Me.btnPromo8.Text = "FAWK 629"
        Me.btnPromo8.UseVisualStyleBackColor = True
        '
        'btnPromo9
        '
        Me.btnPromo9.Location = New System.Drawing.Point(224, 299)
        Me.btnPromo9.Name = "btnPromo9"
        Me.btnPromo9.Size = New System.Drawing.Size(96, 80)
        Me.btnPromo9.TabIndex = 9
        Me.btnPromo9.Text = "FAWK  1119"
        Me.btnPromo9.UseVisualStyleBackColor = True
        '
        'btnPromo1
        '
        Me.btnPromo1.BackColor = System.Drawing.Color.PowderBlue
        Me.btnPromo1.Location = New System.Drawing.Point(109, 372)
        Me.btnPromo1.Name = "btnPromo1"
        Me.btnPromo1.Size = New System.Drawing.Size(109, 143)
        Me.btnPromo1.TabIndex = 10
        Me.btnPromo1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAWK 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "400MB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 day validity"
        Me.btnPromo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPromo1.UseVisualStyleBackColor = False
        '
        'PromoOffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 803)
        Me.Controls.Add(Me.btnPromo1)
        Me.Controls.Add(Me.btnPromo9)
        Me.Controls.Add(Me.btnPromo8)
        Me.Controls.Add(Me.btnPromo7)
        Me.Controls.Add(Me.btnPromo6)
        Me.Controls.Add(Me.btnPromo5)
        Me.Name = "PromoOffer"
        Me.Text = "PromoOffer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPromo5 As Button
    Friend WithEvents btnPromo6 As Button
    Friend WithEvents btnPromo7 As Button
    Friend WithEvents btnPromo8 As Button
    Friend WithEvents btnPromo9 As Button
    Friend WithEvents btnPromo1 As Button
End Class
