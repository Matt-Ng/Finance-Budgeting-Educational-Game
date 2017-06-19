Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Level " & Day
        If Day = 1 Then
            ' checks for location on game board and will change the level accordingly
            If stance = 1 Then
                Label2.Text = "Walk to car"
                Button5.Text = "Thanks!"
                TextBox1.Text = "On the way to your car, you walk down the apartment stairs, and on the way to the parking lot, you find $25"
                money += 25
                Form4.TextBox1.Text = money
                hidebuttons()
            End If
            If stance = 2 Then
                Label2.Text = "Commute to work"
                hidebuttons()
                Button5.Text = "Thanks..."
                TextBox1.Text = "On the way to work, your car fuel tank was almost empty. The gas bill comes out to be $25 dollars, and you use the money found on the floor."
                money -= 25
                Form4.TextBox1.Text = money
            End If
            If stance = 3 Then
                Label2.Text = "At Work"
                Button5.Text = "Back"
                TextBox1.Text = "While at work, you realize you have a toothache, meaning you have a cavity... The Dentist quotes $150 for the fillings of two teeth"
                Button1.Text = "Pay the money"
                Button2.Text = "Pay the money with a payday loan (20% interest)"
                Button3.Text = "Suck it up and not pay the money"
                Button4.Hide()
                Button5.Hide()
            End If
            If stance = 4 Then
                Label2.Text = "Commute Home"
                Button5.Text = "Back"
                TextBox1.Text = "As you get home, you realize that your Toyota Corolla is about to need an oil change. You have a few options"
                Button1.Text = "Change the oil yourself"
                Button2.Text = "Pay a mechanic to change the oil"
                Button3.Text = "Don't change the oil"
                Button4.Hide()
                Button5.Hide()
            End If
            If stance = 5 Then
                Label2.Text = "Rest of day"
                Button5.Text = "Back"
                TextBox1.Text = "While walking off the road, you see a very large man drop a $20 bill. What do you do?"
                Button1.Text = "Keep the money"
                Button2.Text = "Give the money back"
                Button3.Hide()
                Button4.Hide()
                Button5.Hide()
            End If
        End If
    End Sub
    Sub hidebuttons()
        ' sub to hide the buttons when player makes a decision
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' uses if statements provide the effect the player's decision has on the game
        If Day = 1 Then
            If stance = 3 Then
                money -= 150
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "You paid $150"
            End If
            If stance = 4 Then
                money -= 45
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "Great decision on going DIY. You can save lots of money on doing things yourself, and an oil change is relatively simple to do. However, the oil and the filter were not free and costed $45"
            End If
            If stance = 5 Then
                money -= 20
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "Bad decision. The large man looked back and noticed that you are holding his $20 bill. He rips the bill off you hand and forces another $20 out of your pocket. You just lost $20. Make the moral decision next time."
            End If
        End If
        If Day = 2 Then
            If stance = 1 Then
                money -= 110
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "Good job! You are now more comfortable working your job, and you did not sacrifice your job!"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' uses if statements provide the effect the player's decision has on the game
        If Day = 1 Then
            If stance = 3 Then
                Debt += 150
                Form4.TextBox4.Text = Debt
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "Bob's payday loan has provided you with $150 with 20% interest!"
                paydayloanweek = True
            End If
            If stance = 4 Then
                money -= 90
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "It probably was in you best interest to go DIY for an oil change, since it cost you $90 for the oil change, rather than $45 if you did it yourself."
            End If
            If stance = 5 Then
                money += 50
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "Nice job! The big man thanks you for giving back his money. As a token of gratitude, he gives you the $20 plus another $30, making you basically $50 richer! Remember to do the moral action!"
            End If
        End If
        If Day = 2 Then
            If stance = 1 Then
                weekWatcheshealth = True
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "You sacrificed your health to save some money. You job performance will be poorer due to the pain."
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' uses if statements provide the effect the player's decision has on the game
        If Day = 1 Then
            If stance = 3 Then
                paydayloanweek = True
                hidebuttons()
                Button5.Show()
            End If
            If stance = 4 Then
                Form4.TextBox1.Text = money
                hidebuttons()
                Button5.Show()
                TextBox1.Text = "Bad move. The car may not last for much longer, unfortunate considering you don't have enough money for another reliable car. Your corolla may be reliable, but it's not indestructible."
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' closes the part and sends you back to the level
        Me.Close()
        Form4.Show()
    End Sub
End Class