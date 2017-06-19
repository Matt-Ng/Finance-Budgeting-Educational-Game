Public Class Form8
    ' declare variables for use in textbox1
    Dim goodorbad As String
    Dim paydaydetect As String
    Dim lotterydetect As String
    Dim watchdetect As String
    Dim diff As Integer
    Dim last As String = ""
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' will show that the level is finished
        Label1.Text = "Level " & Day & " Finished!"
        TextBox5.Text = Debt
        Debt = Debt * 1.2
        TextBox6.Text = Debt
        money = money - 200 + 240
        TextBox2.Text = moneystart
        TextBox3.Text = money
        diff = money - moneystart
        TextBox4.Text = money - moneystart
        'if player makes more than start of level good job, else bad job
        If diff >= 0 Then
            goodorbad = "Great Level!" & vbCrLf & "You made it throughout the level and didn't lose money from the start of the level! You made " & diff & " more than the start of the level!"
        ElseIf diff < 0 Then
            goodorbad = "Bad Level" & vbCrLf & "You did not make it throughout the level without losing money from the start of the level! You lost " & diff * -1 & " less than the start of the level! At this rate, you will go bankrupt in " & Math.Round(money / diff * -1, 2) & " Weeks!"
        End If
        ' detects if you do lottery, payday loan, or sacrifice your health for money
        If lotterytickweek = True Then
            lotterydetect = "You bought a lottery ticket! That is not a good financial decision! Did you know that you have a better chance at dating a millionaire (1 to 215) than winning the lottery, so you might as well do that!"
        Else
            lotterydetect = "Great job! You didn't buy a lottery ticket!"
        End If
        If paydayloanweek = True Then
            paydaydetect = "You bought a payday loan??? Really bad Decision! The interest on these loans will keep you poor!"
        Else
            paydaydetect = "Horray! You didn't get a payday loan! Don't do it in the future!"
        End If
        If weekWatcheshealth = True Then
            watchdetect = "You neglected your health to save money. That can be more expensive later, and just is a bad decision overall!"
        Else
            watchdetect = "Awesome! You took care of your health! It may be expensive in the short term, but remember, it's worth it!"
        End If
        If Day = 2 Then
            last = "This level will be your last level! Make it count!"
        End If
        ' prints the comments down
        TextBox1.Text = goodorbad & vbCrLf & vbCrLf & vbCrLf & "Extra Comments" & vbCrLf & lotterydetect & vbCrLf & paydaydetect & vbCrLf & watchdetect
        diff = 0
        lotterytickweek = False
        paydayloanweek = False
        weekWatcheshealth = False
        stance = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' decides to end game if level 3 but if level 1 or 2 dont end the game
        Select Case Day
            Case 1 To 2
                Me.Close()
                Form4.Show()
                last = ""
                Day += 1
            Case 3
                Me.Close()
                Form11.Show()
                Day += 1
        End Select
    End Sub
End Class