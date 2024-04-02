Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        customer.customerName = txtName.Text
        customer.customerAddress = txtAddress.Text
        customer.destination = cboDestination.Text
        customer.people = nudPeople.Value
        customer.weeks = nudWeeks.Value
        ' calaulate price
        lblTotal.Text = customer.weeks * customer.people * 400
    End Sub
End Class
