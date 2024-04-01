Public Class Form4
    Dim age As Double
    Const mhr As Double = 220

    Private Sub btncalcMHR_Click(sender As Object, e As EventArgs) Handles btncalcMHR.Click
        Dim mhr As Double

        mhr = (220 - txtAGE.Text)
        lblResult.Text = mhr
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnBMR_Click(sender As Object, e As EventArgs) Handles btnBMR.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Please confirm that you want to Exit the Program", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnResetMHR_Click(sender As Object, e As EventArgs) Handles btnResetMHR.Click
        lblResult.Text = ""
        txtAGE.Clear()
    End Sub
End Class