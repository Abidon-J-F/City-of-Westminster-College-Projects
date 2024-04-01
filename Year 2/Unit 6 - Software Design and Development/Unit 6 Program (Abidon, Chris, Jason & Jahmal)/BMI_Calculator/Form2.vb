Public Class Form2
    Dim h As Double
    Dim w As Double
    Dim a As Double

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnMHR_Click(sender As Object, e As EventArgs) Handles btnMHR.Click
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub btnResetBMR_Click(sender As Object, e As EventArgs) Handles btnResetBMR.Click
        lblTotalBMRMale.Text = ""
        lblTotalBMRFemale.Text = ""
        txtHeight.Clear()
        txtWeight.Clear()
        txtAge.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Please confirm that you want to Exit the Program", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnCheckBMR_Click(sender As Object, e As EventArgs) Handles btnCheckBMR.Click
        If rdbMale.Checked = True Then
            w = txtWeight.Text
            h = txtHeight.Text
            a = txtAge.Text
            lblTotalBMRMale.Text = (h * 6.25) + (w * 9.99) - (a * 4.92) + 5

        End If

        If rdbFemale.Checked = True Then
            w = txtWeight.Text
            h = txtHeight.Text
            a = txtAge.Text
            lblTotalBMRFemale.Text = (h * 6.25) + (w * 9.99) - (a * 4.92) - 161
        End If

    End Sub
End Class