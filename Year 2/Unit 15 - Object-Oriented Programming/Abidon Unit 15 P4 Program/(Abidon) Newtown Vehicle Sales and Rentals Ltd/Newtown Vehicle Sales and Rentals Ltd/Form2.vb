Public Class Form2
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        CustomerHire.setCustomerID(txtCustomerID.Text)
        CustomerHire.setCustomerName(txtCustomerName.Text)
        CustomerHire.setCustomerAddress(txtCustomerAddress.Text)
        CustomerHire.setProofofAddress(chkProofofAddress.Text)
        CustomerHire.setDateofHire(dtpDateofHire.Value)
        CustomerHire.setNumberofDays(nudNumberofDays.Value)
        CustomerHire.setMethodofPayments(chk_MethodofPayments.Text)
        objBicycleHire.setNumberofAdultBikesHired(nudAdultBikes.Value)
        objBicycleHire.setNumberofChildrenBikesHired(nudChildrenBikes.Value)

        If nudNumberofDays.Value = 1 Then
            If nudAdultBikes.Value = 0 Then
                lblBikeTotal.Text = 10 * nudChildrenBikes.Value * 0.8
            ElseIf nudAdultBikes.Value > 0 Then
                If nudChildrenBikes.Value = 0 Then
                    lblBikeTotal.Text = (10 * nudAdultBikes.Value)
                ElseIf nudChildrenBikes.Value > 0 Then
                    lblBikeTotal.Text = (10 * nudAdultBikes.Value) + (10 * nudChildrenBikes.Value * 0.8)
                End If
            End If
        End If

        If nudNumberofDays.Value = 2 Then
            If nudAdultBikes.Value = 0 Then
                lblBikeTotal.Text = 18 * nudChildrenBikes.Value * 0.8
            ElseIf nudAdultBikes.Value > 0 Then
                If nudChildrenBikes.Value = 0 Then
                    lblBikeTotal.Text = (18 * nudAdultBikes.Value)
                ElseIf nudChildrenBikes.Value > 0 Then
                    lblBikeTotal.Text = (18 * nudAdultBikes.Value) + (18 * nudChildrenBikes.Value * 0.8)
                End If
            End If
        End If

        If nudNumberofDays.Value > 2 Then
            lblBikeTotal.Text = (18 + (nudNumberofDays.Value - 2) * 5) * nudAdultBikes.Value + (18 + (nudNumberofDays.Value - 2) * 5) * nudChildrenBikes.Value * 0.8
        End If

        rtReceipt.Text = ""

        rtReceipt.AppendText(vbTab + "   Newtown Vehicle Sales & Rentals Ltd" + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)

        rtReceipt.AppendText(vbTab + "   Customer Details" + Environment.NewLine)
        rtReceipt.AppendText("                                                                               " + Environment.NewLine)
        rtReceipt.AppendText("CustomerID: " + txtCustomerID.Text + Environment.NewLine)
        rtReceipt.AppendText("Customer Name: " + txtCustomerName.Text + Environment.NewLine)
        rtReceipt.AppendText("Customer Address: " + txtCustomerAddress.Text + Environment.NewLine)
        rtReceipt.AppendText("Proof of Address: " + chkProofofAddress.Text + Environment.NewLine)
        rtReceipt.AppendText("Date of Hire: " + dtpDateofHire.Text + Environment.NewLine)
        rtReceipt.AppendText("Number of Days: " + nudNumberofDays.Text + Environment.NewLine)
        rtReceipt.AppendText("Method of Payments: " + chk_MethodofPayments.Text + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)

        rtReceipt.AppendText(vbTab + "   Bicycle Hire Details" + Environment.NewLine)
        rtReceipt.AppendText("                                                                               " + Environment.NewLine)

        rtReceipt.AppendText("Number of Adults Bikes Hired: " + nudAdultBikes.Text + Environment.NewLine)
        rtReceipt.AppendText("Number of Children Bikes Hired: " + nudChildrenBikes.Text + Environment.NewLine)

        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
        rtReceipt.AppendText("Total Cost: £" + lblBikeTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        rtReceipt.Text = ""
        txtCustomerID.Text = ""
        txtCustomerName.Text = ""
        txtCustomerAddress.Text = ""
        dtpDateofHire.Text = ""
        nudNumberofDays.Value = 0
        nudAdultBikes.Value = 0
        nudChildrenBikes.Value = 0
        lblBikeTotal.Text = "0"

        Dim mydnumerator As IEnumerator
        mydnumerator = chkProofofAddress.CheckedIndices.GetEnumerator()
        Dim a As Integer
        While mydnumerator.MoveNext() <> False
            a = CInt(mydnumerator.Current)
            chkProofofAddress.SetItemChecked(a, False)
        End While

        Dim myEnumerator As IEnumerator
        myEnumerator = chk_MethodofPayments.CheckedIndices.GetEnumerator()
        Dim y As Integer
        While myEnumerator.MoveNext() <> False
            y = CInt(myEnumerator.Current)
            chk_MethodofPayments.SetItemChecked(y, False)
        End While
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If rtReceipt.Text = "" Then
            MsgBox("Please Click on the Calculate button")
        Else
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("Microsoft Sans Serif", 16, FontStyle.Regular)
        e.Graphics.DrawString(rtReceipt.Text, font1, Brushes.Black, 100, 100)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Please confirm that you want to Quit the Newtown Vehicle Sales and Rentals Ltd", "Quit System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub
End Class