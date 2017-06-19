Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' checks if player has enough money to pay debts, if they do money will be deducted and the debts will be deducted as well
        If money < TextBox2.Text Then
            TextBox1.Text = "Buddy, you don't that kind of money scram until you have enough!"
        ElseIf Debt < TextBox2.Text Then
            TextBox1.Text = "You gave me more money than you have debt! Thanks!"
            money -= TextBox2.Text
            Debt = 0
            Form4.TextBox2.Text = Debt
            Form4.TextBox1.Text = money
        Else
            TextBox1.Text = "Thanks."
            money -= Form4.TextBox2.Text
            Debt -= Form4.TextBox4.Text
            Form4.TextBox1.Text = money
        End If
    End Sub
End Class