Public Class Form1
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Confirm you want to exit", "Exit system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnexit_MouseEnter(sender As Object, e As EventArgs) Handles btnexit.MouseEnter
        btnexit.BackColor = Color.Red
    End Sub

    Private Sub btnexit_MouseLeave(sender As Object, e As EventArgs) Handles btnexit.MouseLeave
        btnexit.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub lblSum_MouseEnter(sender As Object, e As EventArgs) Handles lblSum.MouseEnter
        lblSum.BackColor = Color.White
    End Sub

    Private Sub lblSum_MouseLeave(sender As Object, e As EventArgs) Handles lblSum.MouseLeave
        lblSum.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        lblSum.Text = ""
        txtFood.Text = ""
        txtDrinks.Text = ""
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        lblSum.Text = Val(txtFood.Text) + Val(txtDrinks.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
