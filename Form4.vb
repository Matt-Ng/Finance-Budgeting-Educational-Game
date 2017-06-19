Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' just prints out the stats at start of level, like what level youre on, how much money you have, and records the amount of money you have at the start of the level
        Label12.Text = "Level " & Day

        TextBox2.Text = 240

        TextBox1.Text = money

        moneystart = money
        TextBox5.Text = potentialcosts

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' brings you to payday loans
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' brings you to lottery
        Form5.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' the option to sell your things for 100 can only be done once so it gets hidden after it gets clicked
        money += 100
        TextBox1.Text = money
        Label13.Hide()
        Button4.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' will take you to the form that lets you pay loans
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' moves character based on where it is on the game screen
        ' uses timers to animate the character, and then updates the position using the stance variable
        If stance = 0 Then
            Timer1.Start()
            stance += 1

        ElseIf stance = 1 Then
            Timer2.Start()
            stance += 1

        ElseIf stance = 2 Then
            Timer3.Start()
            stance += 1

        ElseIf stance = 3 Then
            Timer4.Start()
            stance += 1

        ElseIf stance = 4 Then
            Timer5.Start()
            stance += 1

        ElseIf stance = 5 Then
            Timer6.Start()
            stance += 1
        End If



    End Sub
    'for the timers to determine a position
    Dim x As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' will move to the right then stop
        ' x is updated by 1 every 10 ms
        x += 1
        ' will add the x to the position, changing the picturebox, or the character
        PictureBox1.Location = New Point(PictureBox1.Location.X + x, PictureBox1.Location.Y)
        ' stops timer once picturebox is on the correct position
        If PictureBox1.Location.X >= 575 Then
            levelstart()
            Timer1.Stop()
        End If
        ' all timers will have same general logic
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' moves right, then up
        x += 1
        PictureBox1.Location = New Point(PictureBox1.Location.X + x, PictureBox1.Location.Y)

        If PictureBox1.Location.X >= 1076 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X - x, PictureBox1.Location.Y - x)
        End If

        If PictureBox1.Location.Y <= 425 Then
            levelstart()
            Timer2.Stop()
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ' moves left

        x += 1

        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - x)


        If PictureBox1.Location.Y <= 307 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X - x, PictureBox1.Location.Y + x)
        End If
        If PictureBox1.Location.X <= 575 Then
            levelstart()
            Timer3.Stop()
        End If

    End Sub
    Sub levelstart()
        ' sub routine to save lines of code whenever the next level button is triggered
        x = 0
        Me.Hide()
        ' will use different forms based on level, or using the day variable
        If Day = 2 Then
            If Day = 2 Then
                Form9.Show()
            End If
        ElseIf Day = 1 Then
            Form7.Show()
        ElseIf Day = 3 Then
            Form10.Show()
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ' moves left then up
        x += 1
        PictureBox1.Location = New Point(PictureBox1.Location.X - x, PictureBox1.Location.Y)

        If PictureBox1.Location.X <= 83 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X + x, PictureBox1.Location.Y - x)
        End If

        If PictureBox1.Location.Y <= 219 Then
            levelstart()
            Timer4.Stop()
        End If

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ' moves right
        x += 1
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - x)

        If PictureBox1.Location.Y <= 110 Then
            PictureBox1.Location = New Point(PictureBox1.Location.X + x, PictureBox1.Location.Y + x)
        End If
        If PictureBox1.Location.X >= 575 Then
            levelstart()
            Timer5.Stop()
        End If
    End Sub


    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        ' moves right then shows the end of level stats
        x += 1
        PictureBox1.Location = New Point(PictureBox1.Location.X + x, PictureBox1.Location.Y)

        If PictureBox1.Location.X >= 1014 Then
            levelstart()
            Form7.Hide()
            Form8.Show()
            Me.Close()
            Timer6.Stop()
        End If
    End Sub
End Class