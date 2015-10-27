Public Class target
    Inherits PictureBox
    Public Sub New()
        With Me
            .Image = My.Resources.TargetObject1
            .Size = New Size(14, 28)
        End With
    End Sub
End Class