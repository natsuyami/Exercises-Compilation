Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "shiranui" And TextBox2.Text = "123" Then
            Form2.Show()
            Me.Hide()
        Else
            Text = "Failed to Login"
            Label3.Text = "Invalid Input"
            Label3.ForeColor = Color.Red
        End If


    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        If Text = "Failed to Login" Then
            Text = "Failed to Login"
        Else
            Text = "Going Login"
        End If
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        If Text = "Failed to Login" Then
            Text = "Failed to Login"
        Else
            Text = "Login"
        End If
    End Sub
End Class
