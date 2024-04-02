Public Class Form1

   
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        customerAccount.setname(txtname.Text)
        customerAccount.setAddress(txtAddress.Text)
        customerAccount.setAccountNo(nudAccountNo.Value)
        customerAccount.setBalance(0)
        If IsNumeric(txtOverdraftLimit.Text) Then
            customerAccount.setlimit(txtOverdraftLimit.Text)
            If customerAccount.getname <> "" Then
                If customerAccount.getAddress <> "" Then
                    If customerAccount.getAccountNo > 0 Then
                        btnDeposit.Enabled = True
                        btnWithdraw.Enabled = True
                        btnDisplay.Enabled = True
                        txtTransaction.Enabled = True
                    End If
                End If
                
            End If
        End If





    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Me.Hide()
        Form2.Show()
    End Sub

    
End Class
