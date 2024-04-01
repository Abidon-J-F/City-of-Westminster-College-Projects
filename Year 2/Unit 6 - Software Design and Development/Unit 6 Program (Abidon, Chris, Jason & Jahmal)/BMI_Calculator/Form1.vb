Public Class Form1
    Dim h As Double
    Dim w As Double
    Dim t As Double

    Private Sub btnResetBMI_Click(sender As Object, e As EventArgs) Handles btnResetBMI.Click
        lblTotalBMI.Text = ""
        txtHeight.Clear()
        txtWeight.Clear()
    End Sub

    Private Sub btnCheckBMI_Click(sender As Object, e As EventArgs) Handles btnCheckBMI.Click
        w = txtWeight.Text
        h = txtHeight.Text
        t = w / (h * h)

        lblTotalBMI.Text = String.Format("{0:f}", t)

        If t <= 16 Then
            lblTotalBMI.BackColor = Color.DarkGray
        ElseIf t <= 17 Then
            lblTotalBMI.BackColor = Color.Blue
        ElseIf t <= 18.5 Then
            lblTotalBMI.BackColor = Color.SkyBlue
        ElseIf t <= 25 Then
            lblTotalBMI.BackColor = Color.Green
        ElseIf t <= 30 Then
            lblTotalBMI.BackColor = Color.YellowGreen
        ElseIf t <= 35 Then
            lblTotalBMI.BackColor = Color.Yellow
        ElseIf t <= 40 Then
            lblTotalBMI.BackColor = Color.Orange
        ElseIf t >= 40 Then
            lblTotalBMI.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Please confirm that you want to Exit the Program", "Exit System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnMHR_Click(sender As Object, e As EventArgs) Handles btnMHR.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnBMR_Click(sender As Object, e As EventArgs) Handles btnBMR.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
