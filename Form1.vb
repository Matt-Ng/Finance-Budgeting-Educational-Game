Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the layout of title screen
        TextBox1.Hide()
        TextBox2.Hide()
        Button5.Hide()
        Button6.Hide()
        Dim dollar As String
        For count As Integer = 1 To 41
            dollar = dollar & StrDup(35, "$") & vbCrLf
            TextBox3.Text = dollar
            TextBox4.Text = dollar
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' if the button is clicked, instructions will show
        Me.Hide()
        Form2.Show()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Will display the opening to the game and provide background
        Hide1()
        money = 500
        hard = True
        TextBox1.Text = "Welcome!"
        TextBox2.Text = "You are a Restaurant Chef making 12 dollars an hour." & vbCrLf & "You work 20 hours per week" & vbCrLf & "You will be paid $240 per level, and rent is 100 per week" & vbCrLf & "You will be given $500" & vbCrLf & "Make the most out of the money." & vbCrLf & "Good Luck."
    End Sub

    Sub Hide1()
        ' subroutine used to hide the objects to go to the opening screen
        TextBox1.Show()
        TextBox2.Show()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Show()
        Button6.Show()
        TextBox3.Hide()
        TextBox4.Hide()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' when you go back to title screen, objects have to be shown and hided
        TextBox1.Hide()
        TextBox2.Hide()
        Button5.Hide()
        Button6.Hide()
        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Show()
        Button3.Show()
        Button4.Show()
        TextBox3.Show()
        TextBox4.Show()
        hard = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' sends you to the game
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' sends you to high scores
        Me.Hide()
        Form12.Show()
    End Sub
End Class
