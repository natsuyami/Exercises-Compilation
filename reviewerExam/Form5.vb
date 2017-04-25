Public Class Form5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BackColor = Color.Red Then
            BackColor = Color.Green
        ElseIf BackColor = Color.Green Then
            BackColor = Color.Orange
        Else
            BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            Button1.Text = "Stop"
            Timer1.Start()
        Else
            Button1.Text = "Start"
            Timer1.Stop()
        End If

    End Sub
End Class