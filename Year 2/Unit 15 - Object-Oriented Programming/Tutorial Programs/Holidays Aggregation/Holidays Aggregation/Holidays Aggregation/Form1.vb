Public Class Form1
    Dim HappyHoliday As New HolidayClass
    Dim skiHoliday As New WinterHoliday
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HappyHoliday.Customer.setSurname(txtSurname.text)
        'invokes setSurname of Customer object held inside HappyHoliday
    End Sub
End Class
