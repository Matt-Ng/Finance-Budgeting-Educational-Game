Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' when form is loaded shows text from the payday loan seller, Bob
        TextBox1.Text = "Howdy Yall'! Welcome to Bob's payday loans! You need money? I'll get you on track! Just don't forget to pay me back!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' will add money and debt, and then bring player back to game
        money += TextBox2.Text
        Debt += TextBox2.Text
        Me.Hide()
        Form4.Show()
        Form4.TextBox1.Text = money
        Form4.TextBox4.Text = Debt
    End Sub
End Class