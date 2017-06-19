Public Class Form5

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' the timer will alternate the colours
        Label3.Visible = Not Label3.Visible
        Static rand As New Random()
        'credits
        ' https://social.msdn.microsoft.com/Forums/vstudio/en-US/5a9389fb-e5de-40d6-b1ca-bc1b89489112/what-is-the-coding-to-blink-labeltext-in-vb-2008?forum=vbgeneral
        ' http://www.vbforums.com/showthread.php?710379-Change-background-color-using-a-timer
        Me.BackColor = Color.FromArgb(rand.Next(255), rand.Next(256), rand.Next(256))

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' calls the timer to alternate colours
        Label4.Hide()
        Label5.Hide()
        Button2.Hide()
        Timer1.Interval = 300
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' checks if the lottery number is correct, and will reward three million to player if it is guessed right
        If TextBox1.Text = "364896" Then
            money += 3000000
            Form4.TextBox1.Text = money
            Showsandhide()
        Else
            money -= 5
            Showsandhide()
            Label4.Show()
            Form4.TextBox1.Text = money
        End If
    End Sub
    Sub Showsandhide()
        'used to bring button to send player back to game
        TextBox1.Hide()
        Button1.Hide()
        Button2.Show()
        Label1.Hide()
        Label2.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' sends the player back to game
        Me.Close()
        Form4.Show()
    End Sub
End Class