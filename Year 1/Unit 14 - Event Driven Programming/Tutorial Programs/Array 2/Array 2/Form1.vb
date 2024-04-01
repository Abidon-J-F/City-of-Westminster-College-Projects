Public Class Form1
    Dim q(5) As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F(5) As Double
        q(0) = 2.5
        q(1) = 2.1
        q(2) = 1.9
        q(3) = 1.2
        q(4) = 1.8

        F(0) = q(0) * Val(TextBox1.Text)
        F(1) = q(1) * Val(TextBox2.Text)
        F(2) = q(2) * Val(TextBox3.Text)
        F(3) = q(3) * Val(TextBox4.Text)
        F(4) = q(4) * Val(TextBox5.Text)

        Label1.Text = FormatCurrency(F(0) + F(1) + F(2) + F(3) + F(4))
    End Sub
End Class
