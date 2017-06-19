Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' if money is more than game start, player wins, also subtracts the debt
        If money - Debt > 500 Then
            Label1.Text = "You Win!!!"
            Label2.Text = "Congrats! Your final score was " & money - Debt & " See if you can do better?"
        Else
            Label1.Text = "You Lose"
            Label2.Text = "You Final Score was " & money - Debt & " You did not end off with over $500!"
        End If
        ' sends score to high score with array
        If money > highscores(1) Then
            highscores(1) = money - Debt
        ElseIf money > highscores(2) Then
            highscores(2) = money = Debt
        ElseIf money > highscores(3) Then
            highscores(3) = money - Debt
        ElseIf money > highscores(4) Then
            highscores(4) = money - Debt
        ElseIf money > highscores(5) Then
            highscores(5) = money - Debt
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' sends player back to home screen
        Me.Close()
        Form1.Show()
    End Sub


End Class