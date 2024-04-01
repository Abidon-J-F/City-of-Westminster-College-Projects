Public Class Form1
    Dim myArray(9) As String
    Dim IndexPos As Integer = 0

    Private Sub CheckItem(Index As Integer)
        IndexPos += Index

        If IndexPos < 0 Then
            IndexPos = 9
        ElseIf IndexPos > 9 Then
            IndexPos = 0
        End If

        txtOutput.Text = myArray(IndexPos)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myArray(0) = "Peter"
        myArray(1) = "Parker"
        myArray(2) = "Tony"
        myArray(3) = "Paul"
        myArray(4) = "Musa"
        myArray(5) = "Ali"
        myArray(6) = "Julia"
        myArray(7) = "June"
        myArray(8) = "Casey"
        myArray(9) = "Mary"

        CheckItem(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckItem(-1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckItem(1)
    End Sub
End Class
