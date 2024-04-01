Public Class Form1
    Dim ImageNum

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ImageNum = ImageNum + 1
        If ImageNum > 5 Then ImageNum = 1
        Select Case ImageNum
            Case 1
                PictureBox1.Image = My.Resources.micky1
                RadioButton1.Checked = True
            Case 2
                PictureBox1.Image = My.Resources.micky2
                RadioButton2.Checked = True
            Case 3
                PictureBox1.Image = My.Resources.micky3
                RadioButton3.Checked = True
            Case 4
                PictureBox1.Image = My.Resources.micky4
                RadioButton4.Checked = True
            Case 5
                PictureBox1.Image = My.Resources.micky5
                RadioButton5.Checked = True

        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ImageNum = ImageNum - 1
        If ImageNum < 1 Then ImageNum = 5
        Select Case ImageNum
            Case 1
                PictureBox1.Image = My.Resources.micky5
                RadioButton1.Checked = True
            Case 2
                PictureBox1.Image = My.Resources.micky4
                RadioButton2.Checked = True
            Case 3
                PictureBox1.Image = My.Resources.micky3
                RadioButton3.Checked = True
            Case 4
                PictureBox1.Image = My.Resources.micky2
                RadioButton4.Checked = True
            Case 5
                PictureBox1.Image = My.Resources.micky1
                RadioButton5.Checked = True

        End Select
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.micky1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.micky2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.micky3
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources.micky4
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        PictureBox1.Image = My.Resources.micky5
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call Button1_Click(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
