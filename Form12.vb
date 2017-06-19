Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' displays high scores
        Dim tempstring As String
        ' prints contents of arrays
        For count As Integer = 1 To 5
            tempstring = tempstring & highscores(count) & vbCrLf
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' goes back to home screen
        Me.Close()
        Form1.Show()
    End Sub
End Class