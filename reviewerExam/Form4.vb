Public Class Form4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Button1.BackColor = Color.Red Then
            Button1.BackColor = Color.Green
        ElseIf Button1.BackColor = Color.Green Then
            Button1.BackColor = Color.Orange
        Else
            Button1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Button2.BackColor = Color.Orange Then
            Button2.BackColor = Color.Green
        ElseIf Button2.BackColor = Color.Green Then
            Button2.BackColor = Color.Red
        Else
            Button2.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Button3.Text = "Stop" Then
            Timer1.Stop()
            Timer2.Stop()
            Button3.Text = "Start"

            If Button1.BackColor = Button2.BackColor Then
                MessageBox.Show("Winner")
            Else
                MessageBox.Show("Try Again")
            End If
        Else
            Timer1.Start()
            Timer2.Start()
            Button3.Text = "Stop"
        End If
    End Sub
End Class