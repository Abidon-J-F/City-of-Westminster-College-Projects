Public Class Form1
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        customerAccount.setname(txtname.Text)
        'write code for address, overdraft limit
        customerAccount.setAddress(txtAddress.Text)
        If IsNumeric(txtOverdraftLimit.Text) Then
            customerAccount.setlimit(txtOverdraftLimit.Text)
        End If




        customerAccount.setBalance(0)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
