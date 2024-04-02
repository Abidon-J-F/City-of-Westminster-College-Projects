Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblName.Text = customerAccount.getname
        lblAddress.Text = customerAccount.getAddress
        lblAccountNo.Text = customerAccount.getAccountNo
        lblBalance.Text = customerAccount.getBalance
        lblLimit.Text = customerAccount.getOverdraftLimit

    End Sub

    
    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class