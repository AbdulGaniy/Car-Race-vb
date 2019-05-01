Public Class Form1
    Dim road(8) As PictureBox
    Dim cars(3) As PictureBox

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                PictureBox9.Left -= 5
            Case Keys.Right
                PictureBox9.Left += 5
            Case Keys.Down
                PictureBox9.Top += 5
            Case Keys.Up
                PictureBox9.Top -= 5
            Case Keys.Escape
                Application.Exit()
            Case Keys.F1
                Application.Restart()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        road(1) = PictureBox1
        road(2) = PictureBox2
        road(3) = PictureBox3
        road(4) = PictureBox4
        road(5) = PictureBox5
        road(6) = PictureBox6
        road(7) = PictureBox7
        road(8) = PictureBox8
        cars(1) = PictureBox10
        cars(2) = PictureBox11
        cars(3) = PictureBox12
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For x = 1 To 8
            road(x).Top += 10
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For y = 1 To 3
            cars(y).Top += 20
            If cars(y).Top >= Me.Height Then
                cars(y).Top = -(Rnd() * 100)
            End If
            If PictureBox9.Bounds.IntersectsWith(cars(y).Bounds) Then
                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                MsgBox("Your Score Is " + Label1.Text)
                MsgBox("game over, press F1 to restart, ESC to exit")

            End If
        Next
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label1.Text = Label1.Text + 0.1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Button1.Enabled = False
        Button1.Visible = False

    End Sub
End Class
