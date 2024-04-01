Public Class Arithmetic
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblEnterFirst.Click

    End Sub

    Private Sub A_Popup(sender As Object, e As PopupEventArgs) Handles A.Popup

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnExponentiation.Click

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        If IsNumeric(txtFirst.Text) Or IsNumeric(txtSecond.Text) Then

1b1Result.Text = Val(txtFirst.Text) + Val(txtSecond.Text)
                ElseIf
                Message.Show("Enter a vaild number", "Operators", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)txtFirst.Focus()

        End If
    End Sub
End Class
