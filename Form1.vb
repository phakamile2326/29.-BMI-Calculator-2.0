Public Class Form1
    Private Function BMI(Height As Single, Weight As Single) As Double
        BMI = Weight / Height ^ 2
    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim h As Single
        Dim w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        TextBox3.Text = Format(BMI(h, w), "0.00")




    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.BurlyWood
    End Sub
End Class


