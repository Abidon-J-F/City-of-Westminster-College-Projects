Public Class Form1
    Dim B(4) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        B(0) = 7
        B(1) = 6
        B(2) = 4
        B(3) = 2
        B(4) = 8
        TextBox1.Text = B(0)
        TextBox2.Text = B(1)
        TextBox3.Text = B(2)
        TextBox4.Text = B(3)
        TextBox5.Text = B(4)
        Label1.Text = B(0) + B(1) + B(2) + B(3) + B(4)
    End Sub
End Class
