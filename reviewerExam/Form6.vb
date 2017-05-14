Public Class Form6
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button1.Left < 207 Then
            Button1.Left = Button1.Left + 10
        Else
            Button3.Enabled = False
        End If
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button1.Left > 0 Then
            Button1.Left = Button1.Left - 10
        Else
            Button2.Enabled = False
        End If
        Button3.Enabled = True
    End Sub
End Class