Public Class Form3
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

        objCarHire.setCarModel(cbxCarModel.SelectedValue)
        objCarHire.setCarRegistration(txtCarRegistration.Text)
        objCarHire.setAdditionalInsurance(cbxAdditionalInsurance.SelectedValue)

        If cbxCarModel.Text = "Opel Astra Estate" Then
            If nudNumberofDays.Value <= 5 Then
                lblCarTotal.Text = 20 * nudNumberofDays.Value
            Else
                lblCarTotal.Text = 100 + (20 * nudNumberofDays.Value - 100) * 0.7
            End If
        End If

        If cbxCarModel.Text = "Jaguar XF" Then
            If nudNumberofDays.Value <= 5 Then
                lblCarTotal.Text = 70 * nudNumberofDays.Value
            Else
                lblCarTotal.Text = 350 + (70 * nudNumberofDays.Value - 350) * 0.7
            End If
        End If

        If cbxCarModel.Text = "Skoda Octavia" Then
            If nudNumberofDays.Value <= 5 Then
                lblCarTotal.Text = 18 * nudNumberofDays.Value
            Else
                lblCarTotal.Text = 90 + (18 * nudNumberofDays.Value - 90) * 0.7
            End If
        End If

        If cbxCarModel.Text = "VW Golf" Then
            If nudNumberofDays.Value <= 5 Then
                lblCarTotal.Text = 20 * nudNumberofDays.Value
            Else
                lblCarTotal.Text = 100 + (20 * nudNumberofDays.Value - 100) * 0.7
            End If
        End If

        If cbxCarModel.Text = "Ford Focus" Then
            If nudNumberofDays.Value <= 5 Then
                lblCarTotal.Text = 19 * nudNumberofDays.Value
            Else
                lblCarTotal.Text = 95 + (19 * nudNumberofDays.Value - 95) * 0.7
            End If
        End If

        If cbxCarModel.Text = "Fiat 500" Then
            If nudNumberofDays.Value <= 5 Then
                lblCarTotal.Text = 12 * nudNumberofDays.Value
            Else
                lblCarTotal.Text = 60 + (12 * nudNumberofDays.Value - 60) * 0.7
            End If
        End If

        If cbxAdditionalInsurance.Text = "Yes" Then
            lblCarTotal.Text = lblCarTotal.Text * 0.4 + lblCarTotal.Text
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

        rtReceipt.AppendText(vbTab + "   Car Hire Details" + Environment.NewLine)
        rtReceipt.AppendText("                                                                               " + Environment.NewLine)

        rtReceipt.AppendText("Car Model: " + cbxCarModel.Text + Environment.NewLine)
        rtReceipt.AppendText("Car Registration: " + txtCarRegistration.Text + Environment.NewLine)
        rtReceipt.AppendText("Additional Insurance: " + cbxAdditionalInsurance.Text + Environment.NewLine)

        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
        rtReceipt.AppendText("Total Cost: £" + lblCarTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
    End Sub

    Private Sub cbxCarModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCarModel.SelectedIndexChanged
        If cbxCarModel.Text = "Opel Astra Estate" Then
            txtCarRegistration.Text = "OA77EUC"
        End If

        If cbxCarModel.Text = "Jaguar XF" Then
            txtCarRegistration.Text = "XF68JEW"
        End If

        If cbxCarModel.Text = "Skoda Octavia" Then
            txtCarRegistration.Text = "SO26ALP"
        End If

        If cbxCarModel.Text = "VW Golf" Then
            txtCarRegistration.Text = "VW09GQT"
        End If

        If cbxCarModel.Text = "Ford Focus" Then
            txtCarRegistration.Text = "FF65SYM"
        End If

        If cbxCarModel.Text = "Fiat 500" Then
            txtCarRegistration.Text = "FT57IHC"
        End If
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        rtReceipt.Text = ""
        txtCustomerID.Text = ""
        txtCustomerName.Text = ""
        txtCustomerAddress.Text = ""
        dtpDateofHire.Text = ""
        nudNumberofDays.Value = 0
        cbxCarModel.Text = ""
        cbxAdditionalInsurance.Text = ""
        txtCarRegistration.Text = ""
        lblCarTotal.Text = "0"

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
End Class