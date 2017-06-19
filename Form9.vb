Public Class Form9
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        Form4.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' provides the scenarios
        If stance = 1 Then
            Button1.Hide()
            Button2.Hide()
            Button5.Hide()
            Button4.Hide()
            Randomize()
            Dim number As Integer
            ' code credit for random http://www.dreamincode.net/forums/topic/150315-random-number-generator/
            Randomize()
            ' random event 50/50 chance to either drop $25 or gain
            number = Int(Rnd() * 2)
            If number = 1 Then
                money += 25
                Form4.TextBox1.Text = money
                TextBox1.Text = "You found $25 off the ground"
            Else
                money -= 25
                Form4.TextBox4.Text = money
                TextBox1.Text = "You dropped $25"
            End If
        End If
        If stance = 2 Then
            hides()
            TextBox1.Text = "While driving on the highway, you got a speeding ticket, costing $100. You have a few options."
            Button1.Text = "Ignore the fee"
            Button2.Text = "Pay the fine"
        End If
        If stance = 3 Then
            hides()
            TextBox1.Text = "While working, you start to feel a pain in your legs and back. You have to go home early to go to the doctors to see what the issue is. The doctor prescribes some medication to treat the problem, which costs $100 since you are uninsured. What do you do?"
            Button1.Text = "Pay for the meds"
            Button2.Text = "Live with the pain"
        End If
        If stance = 4 Then
            hides()
            TextBox1.Text = "Your friend Kane has a warehouse where he needs things moved out for the weekend. He will pay $350 for the weekend."
            Button1.Text = "Take the job"
            Button2.Text = "Decline the job"
        End If
        If stance = 5 Then
            hides()
            TextBox1.Text = "Your brother launches a Kickstarter campaign for his new startup company. There is an hour left of the clock and he needs you to pitch in $100 to the campaign, or else his campaign will not be funded at all. What do you do?"
            Button1.Text = "Give him money"
            Button2.Text = "Decline"
        End If
    End Sub
    Sub hides()
        Button4.Hide()
        Button5.Hide()
        Button3.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' provides the effects for the decisions made by players
        If stance = 2 Then
            TextBox1.Text = "Not the best move, could have implications in the long run."
            potentialcosts += 100
            Button1.Hide()
            Button2.Hide()
            Form4.TextBox5.Text = potentialcosts
            Button3.Show()
        End If
        If stance = 3 Then
            TextBox1.Text = "Good action. Your work performance is greatly improved!"
            money -= 100
            Form4.TextBox1.Text = money
            Button1.Hide()
            Button2.Hide()
            canwork = True
            Button3.Show()
        End If
        If stance = 4 Then
            If canwork = True Then
                TextBox1.Text = "Awesome. You got $350"
                money += 350
                Form4.TextBox1.Text = money
                Button3.Show()
                Button1.Hide()
                Button2.Hide()
            Else
                TextBox1.Text = "You didn't buy the medication, you're unfit to work, you can't go."
                Button3.Show()
                Button1.Hide()
                Button2.Hide()
            End If
        End If
        If stance = 5 Then
            TextBox1.Text = "Your brother thanks you for saving his startup and will give you shares next month."
            money -= 100
            Form4.TextBox1.Text = money
            Button1.Hide()
            Button2.Hide()
            Button3.Show()

        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' provides the effects for the decisions made by players
        If stance = 2 Then
            TextBox1.Text = "Might be expensive in the short term, but cheaper than putting it off."
            money -= 100
            Button1.Hide()
            Button2.Hide()
            Form4.TextBox1.Text = money
            Button3.Show()
        End If
        If stance = 3 Then
            TextBox1.Text = "Bad action. You will suffer a lot from this."
            Button1.Hide()
            weekWatcheshealth = True
            canwork = False
            Button3.Show()
        End If
        If stance = 4 Then
            TextBox1.Text = "You declined the offer."
            Button1.Hide()
            Button2.Hide()
            Button3.Show()
        End If
        If stance = 5 Then
            TextBox1.Text = "Your brother's startup failed. He does not like you anymore and is crying in a corner."
            Button1.Hide()
            Button2.Hide()
            Button3.Show()
        End If
    End Sub

End Class