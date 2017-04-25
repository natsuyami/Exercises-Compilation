Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Boolean
        Dim inputVal As String

        inputVal = TextBox1.Text
        result = inputVal.Contains("a")

        If result = True Then
            TextBox2.Text = "contains letter a"
        Else
            TextBox2.Text = "not contains a"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim inputVal As String
        Dim result As Boolean

        inputVal = TextBox1.Text
        result = inputVal.Equals("shiranui")

        If result = True Then
            TextBox2.Text = "username account"
        Else
            TextBox2.Text = "not username"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inputVal As String
        Dim result As Boolean

        inputVal = TextBox1.Text
        result = inputVal.StartsWith("shi")

        If result = True Then
            TextBox2.Text = "accepted"
        Else
            TextBox2.Text = "not sure"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim inputVal As String
        Dim result As Boolean

        inputVal = TextBox1.Text
        result = inputVal.EndsWith("nui")

        If result = True Then
            TextBox2.Text = "accepted"
        Else
            TextBox2.Text = "not sure"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim inputVal As String
        Dim result As Integer

        inputVal = TextBox1.Text
        result = inputVal.Length()

        TextBox2.Text = "String Length is " & result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim inputVal As String
        Dim result As Integer

        inputVal = TextBox1.Text
        result = inputVal.LastIndexOf("i")

        If result <= 0 Then
            TextBox2.Text = "no searched value for i"
        Else
            TextBox2.Text = "last show of letter i is " & result
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim inputVal As String
        Dim result As Integer

        inputVal = TextBox1.Text
        result = inputVal.IndexOf("s")

        If result <= 0 Then
            TextBox2.Text = "no searched value for s"
        Else
            TextBox2.Text = "last show of letter s is " & result
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.ToLower()

        TextBox2.Text = "Lowercase word: " & result
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.ToUpper()

        TextBox2.Text = "Uppercase word: " & result
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.Trim()

        If inputVal = result Then
            TextBox2.Text = "Nothing to Trim"
        Else
            TextBox2.Text = result
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.Substring(2)

        TextBox2.Text = result
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.Remove(0, 3)

        TextBox2.Text = result
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.Replace("shira", "rya")

        TextBox2.Text = result
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim inputVal As String
        Dim result As String

        inputVal = TextBox1.Text
        result = inputVal.Insert(6, "Insert")

        TextBox2.Text = result
    End Sub
End Class