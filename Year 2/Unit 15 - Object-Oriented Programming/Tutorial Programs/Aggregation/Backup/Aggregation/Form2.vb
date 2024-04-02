Public Class Form2

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblNumber.Text = Person.personAddress.getDetails(1)
        lblStreet.Text = Person.personAddress.getDetails(2)
        lblPostCode.Text = Person.personAddress.getDetails(3)
    End Sub

   
End Class