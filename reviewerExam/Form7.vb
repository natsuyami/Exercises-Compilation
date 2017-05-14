Public Class Form7
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Button1.Location = New Point(98, 63) Then
            Button1.Left = Button1.Left + 56
            Button1.Top = Button1.Top + 27

        ElseIf Button1.Location = New Point(154, 90) Then
            Button1.Left = Button1.Left - 56
            Button1.Top = Button1.Top + 35

        ElseIf Button1.Location = New Point(98, 125) Then
            Button1.Left = Button1.Left - 57
            Button1.Top = Button1.Top - 30

        ElseIf Button1.Location = New Point(41, 95) Then
            Button1.Left = Button1.Left + 57
            Button1.Top = Button1.Top - 32
        End If

    End Sub
End Class