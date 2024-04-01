Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Label4.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        End If

        If RadioButton2.Checked Then
            Label4.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If

        If RadioButton4.Checked Then
            Label4.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        End If

        If RadioButton3.Checked Then
            Label4.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        End If
    End Sub
End Class
