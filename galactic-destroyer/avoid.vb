Public Class avoid
    Inherits PictureBox
    Public Sub New()
        With Me
            .BackgroundImage = My.Resources.AvoidObject1
            .BackgroundImageLayout = ImageLayout.Center
            .Size = New Size(27, 27)
            .Location = New Point(50, 50)
            .BackColor = Color.Transparent
            .Tag = "avoid"
        End With
    End Sub

    Public Sub create()
        Me.Top += 3
    End Sub
End Class