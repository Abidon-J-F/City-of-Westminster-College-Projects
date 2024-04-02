Public Class Form2

    
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        teacher.setName(txtName.Text)
        teacher.setAddress(txtAddress.Text)
        teacher.setDepartment(txtDepartment.text)
    End Sub
End Class