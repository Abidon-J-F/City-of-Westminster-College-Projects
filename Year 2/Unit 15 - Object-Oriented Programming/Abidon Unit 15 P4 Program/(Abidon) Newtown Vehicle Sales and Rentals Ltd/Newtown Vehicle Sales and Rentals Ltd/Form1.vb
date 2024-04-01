Public Class Form1
    Dim g As System.Drawing.Graphics

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Please confirm that you want to Quit the Newtown Vehicle Sales and Rentals Ltd", "Quit System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnBicycleHire_Click(sender As Object, e As EventArgs) Handles btnBicycleHire.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnCarHire_Click(sender As Object, e As EventArgs) Handles btnCarHire.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Process.Start("C:\Users\150165\Desktop\Newtown and Vehicle Sales and Rentals Ltd Help.docx")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Graphics.CreateGraphics()
    End Sub

    Private Sub Graphics_Paint(sender As Object, e As PaintEventArgs) Handles Graphics.Paint
        g.FillRectangle(Brushes.Black, New Rectangle(New Point(12, 12), New Size(120, 45)))
        Dim strstring As String = "NVSR"
        g.DrawString(strstring, New Font("Arial", 28, FontStyle.Bold), New SolidBrush(Color.Red), New Point(12, 12))
    End Sub
End Class
