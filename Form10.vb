Public Class Form10
    Dim number As Integer

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' provides scenarios
        If stance = 1 Then
            TextBox1.Text = "You are a little stressed out and your friend John invites you to go to the Kanye West concert. It costs $75."
            Button1.Text = "Pay the $75 and go to the concert"
            Button2.Text = "Decline the offer"
            Button3.Text = "Attempt to sneak in"
            Button4.Hide()
            Button5.Hide()
        End If
        If stance = 2 Then
            TextBox1.Text = "While at work, your coworkers decide to buy lottery tickets for fun. They ask you to buy one as well"
            Button1.Text = "Decline"
            Button2.Text = "Buy the ticket"
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
        End If
        If stance = 3 Then
            TextBox1.Text = "You have been getting a little chubby lately and found that the Planet Fitness nearby sells a membership for $10 per month"
            Button1.Text = "Don't go to the gym"
            Button2.Text = "Go to the gym"
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
        End If
        If stance = 4 Then
            TextBox1.Text = "You friend Kane has another job for $100, it requires heavy lifting, meaning you need some muscle to do so."
            Button1.Text = "Accept"
            Button2.Text = "Decline"
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
        End If
        If stance = 5 Then
            TextBox1.Text = "You want to get into running, but you must buy running shoes"
            Button1.Text = "Buy $75 Asics"
            Button2.Text = "Go to Walmart and get $15 shoes"
            Button3.Text = "Don't go running"
            Button4.Hide()
            Button5.Hide()


        End If
    End Sub
    Sub hidebuttons()
        ' when the decision is made, just hide the specified buttons
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' effects for decisions
        If stance = 1 Then
            TextBox1.Text = "You had a great time and are now less stressed. Sometimes you just need a break, even though it costs money."
            money -= 75
            Form4.TextBox1.Text = money
            hidebuttons()
        End If
        If stance = 2 Then
            TextBox1.Text = "Good job! Don't give into peer pressure and don't buy lottery tickets!"
            hidebuttons()
        End If
        If stance = 3 Then
            TextBox1.Text = "Bad decision. You sacrificed your health for $10 a month"
            hidebuttons()
            weekWatcheshealth = True
            canwork = False
        End If
        If stance = 4 Then
            If canwork = True Then
                TextBox1.Text = "Great, you got fit enough from the gym to be able to do the job fine. You got $100!"
                money += 100
                Form4.TextBox1.Text = money
                hidebuttons()
            Else
                TextBox1.Text = "You didn't go to gym, you weren't fit enough to lift so you got an injury. It cost you $100 for the ambulance and cast, meaning you break even."
                hidebuttons()
            End If
        End If
        If stance = 5 Then
            TextBox1.Text = "You bought the Asics and had a great time running!"
            hidebuttons()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' provides the effects for the decisions made by players
        If stance = 1 Then
            TextBox1.Text = "Sometimes you just need a break. Consider doing more activities to lower your stress level."
            hidebuttons()
        End If
        If stance = 2 Then
            Form5.Show()
            lotterytickweek = True
            hidebuttons()
        End If
        If stance = 3 Then
            TextBox1.Text = "Good decision! You will have better work performance, better mental health, and you will be less chubby!"
            hidebuttons()
            money -= 10
            Form4.TextBox1.Text = money
            canwork = True
        End If
        If stance = 4 Then
            TextBox1.Text = "I guess you didn't need the money?"
            hidebuttons()
        End If
        If stance = 5 Then
            TextBox1.Text = "You bought the walmart shoes and after running 1 km, your feet turned sore. Remember, you get what you pay for."
            weekWatcheshealth = True
            hidebuttons()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' provides the effects for the decisions made by players
        If stance = 1 Then
            Dim number As Integer
            ' code credit for random http://www.dreamincode.net/forums/topic/150315-random-number-generator/
            Randomize()
            number = Int(Rnd() * 2)
            If number <= 1 Then
                TextBox1.Text = "You got caught by security and have to now pay $200. Don't do crimes to save some money."
                money -= 200
                Form4.TextBox1.Text = money
                hidebuttons()
            ElseIf number >= 2 Then
                TextBox1.Text = "You got lucky. You weren't caught. Sometimes you just need a break, you had a great time and are now less stressed."
                hidebuttons()
            End If
        End If
        If stance = 5 Then
            TextBox1.Text = "Running could have made you fitter, have better mental health, and provided you with a new hobby. You traded that away because you didn't want to buy running shoes"
            weekWatcheshealth = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' closes level sends player back to game
        Me.Close()
        Form4.Show()
    End Sub
End Class