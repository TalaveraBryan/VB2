Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BMI As Double
        Dim meter As Double
        Dim weight As Double
        Dim height As Double
        weight = TextBox1.Text
        height = TextBox2.Text


        meter = height / 100
        BMI = weight / (meter * meter)

        TextBox3.Text = Math.Round(BMI, 2)

        If BMI < 15 Then
            TextBox4.Text = "Very severely underweight"

        ElseIf BMI >= 15 And BMI <= 16 Then
            TextBox4.Text = "Severely underweight"
        ElseIf BMI >= 15 And BMI <= 25 Then
            TextBox4.Text = "Underweight"
        ElseIf BMI >= 25 And BMI <= 30 Then
            TextBox4.Text = "Normal (Healthy Weight)"
        ElseIf BMI >= 30 And BMI <= 35 Then
            TextBox4.Text = "Overweight"
        ElseIf BMI >= 30 And BMI <= 35 Then
            TextBox4.Text = "Moderately Obese"
        ElseIf BMI >= 35 And BMI <= 40 Then
            TextBox4.Text = "Severely Obese"
        ElseIf BMI > 40 Then
            TextBox4.Text = "Very Severely Obese"


        End If
    End Sub



    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus

        If TextBox1.Text = "KG" Then
            TextBox1.Clear()
            TextBox1.ForeColor = Color.Black
        End If

    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "CM" Then
            TextBox2.Clear()
            TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "KG"
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "CM"
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each i As TextBox In Me.Controls.OfType(Of TextBox)()
            i.Clear()
        Next
        TextBox1.Text = "KG"
        TextBox1.ForeColor = Color.Gray
        TextBox2.Text = "CM"
        TextBox2.ForeColor = Color.Gray

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
