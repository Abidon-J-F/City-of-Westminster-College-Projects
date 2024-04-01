Public Class Form1
    Dim flag As Boolean = False
    Private Sub Checkers()
        If btnTic1.Text = "X" And btnTic2.Text = "X" And btnTic3.Text = "X" Then
            MsgBox("Player X wins!", MsgBoxStyle.Information)
            lblCountX.Text = lblCountX.Text + 1
        End If
        If btnTic4.Text = "X" And btnTic5.Text = "X" And btnTic6.Text = "X" Then
            MsgBox("Player X wins!", MsgBoxStyle.Information)
            lblCountX.Text = lblCountX.Text + 1
        End If
        If btnTic7.Text = "X" And btnTic8.Text = "X" And btnTic9.Text = "X" Then
            MsgBox("Player X wins!", MsgBoxStyle.Information)
            lblCountX.Text = lblCountX.Text + 1
        End If
        If btnTic1.Text = "0" And btnTic2.Text = "0" And btnTic3.Text = "0" Then
            MsgBox("Player 0 wins!", MsgBoxStyle.Information)
            lblCount0.Text = lblCountX.Text + 1
        End If
        If btnTic4.Text = "0" And btnTic5.Text = "0" And btnTic6.Text = "0" Then
            MsgBox("Player 0 wins!", MsgBoxStyle.Information)
            lblCount0.Text = lblCountX.Text + 1
        End If
        If btnTic7.Text = "0" And btnTic8.Text = "0" And btnTic9.Text = "0" Then
            MsgBox("Player 0 wins!", MsgBoxStyle.Information)
            lblCount0.Text = lblCountX.Text + 1
        End If

    End Sub

    Private Sub btnTic1_Click(sender As Object, e As EventArgs) Handles btnTic1.Click
        If flag = False Then
            btnTic1.Text = "X"
            flag = True
        Else
            btnTic1.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic2_Click(sender As Object, e As EventArgs) Handles btnTic2.Click
        If flag = False Then
            btnTic2.Text = "X"
            flag = True
        Else
            btnTic2.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic3_Click(sender As Object, e As EventArgs) Handles btnTic3.Click
        If flag = False Then
            btnTic3.Text = "X"
            flag = True
        Else
            btnTic3.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic4_Click(sender As Object, e As EventArgs) Handles btnTic4.Click
        If flag = False Then
            btnTic4.Text = "X"
            flag = True
        Else
            btnTic4.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub
    Private Sub btnTic5_Click(sender As Object, e As EventArgs) Handles btnTic5.Click
        If flag = False Then
            btnTic5.Text = "X"
            flag = True
        Else
            btnTic5.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic6_Click(sender As Object, e As EventArgs) Handles btnTic6.Click
        If flag = False Then
            btnTic6.Text = "X"
            flag = True
        Else
            btnTic6.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic7_Click(sender As Object, e As EventArgs) Handles btnTic7.Click
        If flag = False Then
            btnTic7.Text = "X"
            flag = True
        Else
            btnTic7.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic8_Click(sender As Object, e As EventArgs) Handles btnTic8.Click
        If flag = False Then
            btnTic8.Text = "X"
            flag = True
        Else
            btnTic8.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub

    Private Sub btnTic9_Click(sender As Object, e As EventArgs) Handles btnTic9.Click
        If flag = False Then
            btnTic9.Text = "X"
            flag = True
        Else
            btnTic9.Text = "0"
            flag = False
        End If
        Checkers()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btnTic1.Text = ""
        btnTic2.Text = ""
        btnTic3.Text = ""
        btnTic4.Text = ""
        btnTic5.Text = ""
        btnTic6.Text = ""
        btnTic7.Text = ""
        btnTic8.Text = ""
        btnTic9.Text = ""

    End Sub
End Class
