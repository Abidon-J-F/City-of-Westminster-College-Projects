Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Person.personAddress.setNumber(txtNumber.Text)
        Person.personAddress.setPostCode(txtPostCode.Text)
        Person.personAddress.setStreet(txtStreet.Text)
        Person.setSurname(txtSurname.Text)
        Person.setForename(txtForename.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

End Class


