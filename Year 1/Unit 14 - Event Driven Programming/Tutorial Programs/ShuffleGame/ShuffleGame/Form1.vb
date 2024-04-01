Public Class Form1
    Public Count As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Shuffle()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '2,5
        EmptySpotChecker(Button1, Button2)
        EmptySpotChecker(Button1, Button5)

        SolutionChecker()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '1,3,6
        EmptySpotChecker(Button2, Button1)
        EmptySpotChecker(Button2, Button3)
        EmptySpotChecker(Button2, Button6)

        SolutionChecker()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '2,7,4
        EmptySpotChecker(Button3, Button2)
        EmptySpotChecker(Button3, Button7)
        EmptySpotChecker(Button3, Button4)

        SolutionChecker()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '3,8
        EmptySpotChecker(Button4, Button3)
        EmptySpotChecker(Button4, Button8)

        SolutionChecker()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '1,6,9
        EmptySpotChecker(Button5, Button1)
        EmptySpotChecker(Button5, Button6)
        EmptySpotChecker(Button5, Button9)

        SolutionChecker()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        '2,5,10,7
        EmptySpotChecker(Button6, Button2)
        EmptySpotChecker(Button6, Button5)
        EmptySpotChecker(Button6, Button10)
        EmptySpotChecker(Button6, Button7)
        SolutionChecker()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        '3,6,11,8
        EmptySpotChecker(Button7, Button3)
        EmptySpotChecker(Button7, Button6)
        EmptySpotChecker(Button7, Button11)
        EmptySpotChecker(Button7, Button8)

        SolutionChecker()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        '4,7,12
        EmptySpotChecker(Button8, Button4)
        EmptySpotChecker(Button8, Button7)
        EmptySpotChecker(Button8, Button12)

        SolutionChecker()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        '5,10,13
        EmptySpotChecker(Button9, Button5)
        EmptySpotChecker(Button9, Button10)
        EmptySpotChecker(Button9, Button13)

        SolutionChecker()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        '6,9,11,14
        EmptySpotChecker(Button10, Button6)
        EmptySpotChecker(Button10, Button9)
        EmptySpotChecker(Button10, Button11)
        EmptySpotChecker(Button10, Button14)

        SolutionChecker()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        '7,10,15,12
        EmptySpotChecker(Button11, Button7)
        EmptySpotChecker(Button11, Button10)
        EmptySpotChecker(Button11, Button15)
        EmptySpotChecker(Button11, Button12)

        SolutionChecker()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        '8,11,16
        EmptySpotChecker(Button12, Button8)
        EmptySpotChecker(Button12, Button11)
        EmptySpotChecker(Button12, Button16)

        SolutionChecker()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        '9,14
        EmptySpotChecker(Button13, Button9)
        EmptySpotChecker(Button13, Button14)

        SolutionChecker()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        '13,10,15
        EmptySpotChecker(Button14, Button13)
        EmptySpotChecker(Button14, Button10)
        EmptySpotChecker(Button14, Button15)

        SolutionChecker()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        '14,11,16
        EmptySpotChecker(Button15, Button14)
        EmptySpotChecker(Button15, Button11)

        EmptySpotChecker(Button15, Button16)

        SolutionChecker()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        '12,15
        EmptySpotChecker(Button16, Button12)
        EmptySpotChecker(Button16, Button15)

        SolutionChecker()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click

        Me.Close()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim info = MsgBox("Please confirm you want to Exit the Game", vbYesNo + MsgBoxStyle.Question)
        If (info = MsgBoxResult.No) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Shuffle()
    End Sub
End Class
