Public Class Form1
    Dim mcSubTotal1 As Double
    Dim mcSubTotal2 As Double
    Dim mcSubTotal3 As Double
    Dim mcSubTotal4 As Double
    Dim mcSubTotal5 As Double
    Dim mcTotal As Double
    Const cCHROME_PRICE As Double = 4
    Const cCOPPER_PRICE As Double = 3
    Const cPLASTIC_PRICE As Double = 2
    Const cLABOUR_PRICE As Double = 40
    Const cTRAVEL_PRICE As Double = 1
    Dim Opera As String
    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim operators As String
    Public Property KeyAscii As Integer

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim a As DialogResult
        a = MessageBox.Show("Please confirm that you want to Quit the Bespoke Program", "Quit system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim ChromePrice As Double
        Dim CopperPrice As Double
        Dim PlasticPrice As Double
        Dim LabourPrice As Double
        Dim TravelPrice As Double
        Dim ChromeQuantity As Double
        Dim CopperQuantity As Double
        Dim PlasticQuantity As Double
        Dim LabourHours As Double
        Dim TravelMiles As Double
        Dim Total1 As Double
        Dim Total2 As Double
        Dim Total3 As Double
        Dim Total4 As Double
        Dim Total5 As Double
        Dim SubTotal1 As Double
        Dim SubTotal2 As Double
        Dim SubTotal3 As Double
        Dim SubTotal4 As Double
        Dim SubTotal5 As Double

        If chkChromePipes.Checked = True Then
            ChromePrice = cCHROME_PRICE
        End If
        If chkCopperPipes.Checked = True Then
            CopperPrice = cCOPPER_PRICE
        End If
        If chkPlasticPipes.Checked = True Then
            PlasticPrice = cPLASTIC_PRICE
        End If
        If chkLabour.Checked = True Then
            LabourPrice = cLABOUR_PRICE
        End If
        If chkTravel.Checked = True Then
            TravelPrice = cTRAVEL_PRICE
        End If

        If IsNumeric(txtCHPQuantity.Text) Then
            ChromeQuantity = Val(txtCHPQuantity.Text)
            Total1 = cCHROME_PRICE * ChromeQuantity
        End If
        If IsNumeric(txtCHPQuantity.Text) Then
            ChromeQuantity = Val(txtCHPQuantity.Text)
            SubTotal1 = cCHROME_PRICE * ChromeQuantity
        End If
        If IsNumeric(txtCOPQuantity.Text) Then
            CopperQuantity = Val(txtCOPQuantity.Text)
            Total2 = cCOPPER_PRICE * CopperQuantity
        End If
        If IsNumeric(txtCOPQuantity.Text) Then
            CopperQuantity = Val(txtCOPQuantity.Text)
            SubTotal2 = cCOPPER_PRICE * CopperQuantity
        End If
        If IsNumeric(txtPPQuantity.Text) Then
            PlasticQuantity = Val(txtPPQuantity.Text)
            Total3 = cPLASTIC_PRICE * PlasticQuantity
        End If
        If IsNumeric(txtPPQuantity.Text) Then
            PlasticQuantity = Val(txtPPQuantity.Text)
            SubTotal3 = cPLASTIC_PRICE * PlasticQuantity
        End If
        If IsNumeric(txtLHours.Text) Then
            LabourHours = Val(txtLHours.Text)
            Total4 = cLABOUR_PRICE * LabourHours
        End If
        If IsNumeric(txtLHours.Text) Then
            LabourHours = Val(txtLHours.Text)
            SubTotal4 = cLABOUR_PRICE * LabourHours
        End If
        If IsNumeric(txtTMiles.Text) Then
            TravelMiles = Val(txtTMiles.Text)
            Total5 = cTRAVEL_PRICE * TravelMiles
        End If
        If IsNumeric(txtTMiles.Text) Then
            TravelMiles = Val(txtTMiles.Text)
            SubTotal5 = cTRAVEL_PRICE * TravelMiles
        End If
        mcSubTotal1 = SubTotal1
        mcSubTotal2 = SubTotal2
        mcSubTotal3 = SubTotal3
        mcSubTotal4 = SubTotal4
        mcSubTotal5 = SubTotal5
        txtChromePipesTotal.Text = FormatCurrency$(mcSubTotal1)
        txtCopperPipesTotal.Text = FormatCurrency$(mcSubTotal2)
        txtPlasticPipesTotal.Text = FormatCurrency$(mcSubTotal3)
        txtLabourTotal.Text = FormatCurrency$(mcSubTotal4)
        txtTravelTotal.Text = FormatCurrency$(mcSubTotal5)
        mcTotal = Total1 + Total2 + Total3 + Total4 + Total5
        txtTotal.Text = FormatCurrency(mcTotal)
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each txt In {txtDisplay, txtCHPQuantity, txtCOPQuantity, txtPPQuantity, txtTMiles, txtLHours, txtChromePipesTotal, txtCopperPipesTotal, txtLabourTotal, txtTravelTotal, txtPlasticPipesTotal}
            txt.Clear()
            txt.Text = "0"
        Next
        For Each txt In {txtName, txtAddress, txtTelephone, txtCity, txtStateorProvince, txtPostcode}
            txt.Clear()
        Next
        txtTotal.Text = "0"
        For Each chk In {chkChromePipes, chkCopperPipes, chkPlasticPipes, chkLabour, chkTravel}
            chk.Checked = False
        Next
        rtReceipt.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

        For Each txt In {txtCHPQuantity, txtCOPQuantity, txtPPQuantity, txtLHours, txtTMiles}
            txt.Enabled = False
        Next
    End Sub

    Private Sub chkChromePipes_CheckedChanged(sender As Object, e As EventArgs) Handles chkChromePipes.CheckedChanged

        If chkChromePipes.Checked = True Then
            txtCHPQuantity.Enabled = True
            txtCHPQuantity.Text = ""
            txtCHPQuantity.Focus()
        Else
            txtCHPQuantity.Enabled = False
            txtCHPQuantity.Clear()
            txtCHPQuantity.Text = "0"
        End If
    End Sub

    Private Sub ChkCopperPipes_CheckedChanged(sender As Object, e As EventArgs) Handles chkCopperPipes.CheckedChanged

        If chkCopperPipes.Checked = True Then
            txtCOPQuantity.Enabled = True
            txtCOPQuantity.Text = ""
            txtCOPQuantity.Focus()
        Else
            txtCOPQuantity.Enabled = False
            txtCOPQuantity.Clear()
            txtCOPQuantity.Text = "0"
        End If
    End Sub

    Private Sub chkPlasticPipes_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlasticPipes.CheckedChanged

        If chkPlasticPipes.Checked = True Then
            txtPPQuantity.Enabled = True
            txtPPQuantity.Text = ""
            txtPPQuantity.Focus()
        Else
            txtPPQuantity.Enabled = False
            txtPPQuantity.Clear()
            txtPPQuantity.Text = "0"
        End If
    End Sub

    Private Sub chkLabour_CheckedChanged(sender As Object, e As EventArgs) Handles chkLabour.CheckedChanged

        If chkLabour.Checked = True Then
            txtLHours.Enabled = True
            txtLHours.Text = ""
            txtLHours.Focus()
        Else
            txtLHours.Enabled = False
            txtLHours.Clear()
            txtLHours.Text = "0"
        End If
    End Sub

    Private Sub chkTravel_CheckedChanged(sender As Object, e As EventArgs) Handles chkTravel.CheckedChanged

        If chkTravel.Checked = True Then
            txtTMiles.Enabled = True
            txtTMiles.Text = ""
            txtTMiles.Focus()
        Else
            txtTMiles.Enabled = False
            txtTMiles.Clear()
            txtTMiles.Text = "0"
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_MouseEnter(sender As Object, e As EventArgs) Handles btnPrint.MouseEnter
        btnPrint.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnPrint_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        btnPrint.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub btnQuit_MouseLeave(sender As Object, e As EventArgs) Handles btnQuit.MouseLeave, btnQuit.MouseLeave
        btnQuit.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub btnQuit_MouseEnter(sender As Object, e As EventArgs) Handles btnQuit.MouseEnter, btnQuit.MouseEnter
        btnQuit.BackColor = Color.Red
    End Sub

    Private Sub btnCalculate_MouseEnter(sender As Object, e As EventArgs) Handles btnCalculate.MouseEnter
        btnCalculate.BackColor = Color.LimeGreen
    End Sub

    Private Sub btnCalculate_MouseLeave(sender As Object, e As EventArgs) Handles btnCalculate.MouseLeave
        btnCalculate.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub btnReset_MouseEnter(sender As Object, e As EventArgs) Handles btnReset.MouseEnter
        btnReset.BackColor = Color.White
    End Sub

    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        btnReset.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub txtCHPQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtCHPQuantity.TextChanged

    End Sub

    Private Sub txtCHPQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCHPQuantity.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Chrome Pipes should contain numbers only", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtCOPQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtCOPQuantity.TextChanged

    End Sub

    Private Sub txtCOPQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCOPQuantity.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Copper Pipes should contain numbers only", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtPPQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtPPQuantity.TextChanged

    End Sub

    Private Sub txtPPQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPPQuantity.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Plastic Pipes should contain numbers only", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtLHours_TextChanged(sender As Object, e As EventArgs) Handles txtLHours.TextChanged

    End Sub

    Private Sub txtLHours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLHours.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Labour Hours should contain numbers", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtTMiles_TextChanged(sender As Object, e As EventArgs) Handles txtTMiles.TextChanged

    End Sub

    Private Sub txtTMiles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTMiles.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Travel should only contain numbers", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtTelephone.TextChanged

    End Sub

    Private Sub txtTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Telephone No should only contain numbers", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Names should contain letters", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "7"
        Else
            txtDisplay.Text = txtDisplay.Text & "7"

        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "8"
        Else
            txtDisplay.Text = txtDisplay.Text & "8"

        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "9"
        Else
            txtDisplay.Text = txtDisplay.Text & "9"

        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "4"
        Else
            txtDisplay.Text = txtDisplay.Text & "4"

        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "5"
        Else
            txtDisplay.Text = txtDisplay.Text & "5"

        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "6"
        Else
            txtDisplay.Text = txtDisplay.Text & "6"

        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "1"
        Else
            txtDisplay.Text = txtDisplay.Text & "1"

        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "2"
        Else
            txtDisplay.Text = txtDisplay.Text & "2"

        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "3"
        Else
            txtDisplay.Text = txtDisplay.Text & "3"

        End If
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "0"
        Else
            txtDisplay.Text = txtDisplay.Text & "0"

        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        operators = "+"
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        operators = "-"
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        operators = "*"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        firstnum = txtDisplay.Text
        txtDisplay.Text = ""
        operators = "/"
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If InStr(txtDisplay.Text, ".") = 0 Then
            txtDisplay.Text = txtDisplay.Text + "."
        End If
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btnPlusMinus_Click(sender As Object, e As EventArgs) Handles btnPlusMinus.Click
        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)
        Else
            txtDisplay.Text = "-" + txtDisplay.Text
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondnum = txtDisplay.Text
        If operators = "+" Then
            answer = firstnum + secondnum
            txtDisplay.Text = answer

        ElseIf operators = "-" Then
            answer = firstnum - secondnum
            txtDisplay.Text = answer

        ElseIf operators = "*" Then
            answer = firstnum * secondnum
            txtDisplay.Text = answer

        ElseIf operators = "/" Then
            answer = firstnum / secondnum
            txtDisplay.Text = answer

        ElseIf Opera = "Mod" Then
            answer = firstnum Mod secondnum
            txtDisplay.Text = answer

        ElseIf Opera = "Exp" Then
            answer = firstnum ^ secondnum
            txtDisplay.Text = answer
        End If
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        rtReceipt.Clear()

        rtReceipt.AppendText(vbTab + vbTab + vbTab + "   Receipt" + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)

        rtReceipt.AppendText(vbTab + vbTab + vbTab + "   Details" + Environment.NewLine)
        rtReceipt.AppendText("                                                                               " + Environment.NewLine)
        rtReceipt.AppendText("Name: " + txtName.Text + Environment.NewLine)
        rtReceipt.AppendText("Address: " + txtAddress.Text + Environment.NewLine)
        rtReceipt.AppendText("City: " + txtCity.Text + Environment.NewLine)
        rtReceipt.AppendText("State/Province: " + txtStateorProvince.Text + Environment.NewLine)
        rtReceipt.AppendText("Postcode: " + txtPostcode.Text + Environment.NewLine)
        rtReceipt.AppendText("Telephone: " + txtTelephone.Text + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)

        rtReceipt.AppendText("    Elements" + vbTab + vbTab + "        Quantity" + Environment.NewLine)
        rtReceipt.AppendText("                                                                               " + Environment.NewLine)

        rtReceipt.AppendText("Chrome Pipes" + vbTab + vbTab + vbTab + txtCHPQuantity.Text + Environment.NewLine)
        rtReceipt.AppendText("Copper Pipes" + vbTab + vbTab + vbTab + txtCOPQuantity.Text + Environment.NewLine)
        rtReceipt.AppendText("Plastic Pipes" + vbTab + vbTab + vbTab + txtPPQuantity.Text + Environment.NewLine)
        rtReceipt.AppendText("Labour" + vbTab + vbTab + vbTab + vbTab + txtLHours.Text + Environment.NewLine)
        rtReceipt.AppendText("Travel" + vbTab + vbTab + vbTab + vbTab + txtTMiles.Text + Environment.NewLine)

        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
        rtReceipt.AppendText("Chrome Pipes Total Cost " + vbTab + txtChromePipesTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("Copper Pipes Total Cost " + vbTab + txtCopperPipesTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("Plastic Pipes Total Cost " + vbTab + txtPlasticPipesTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("Labour Hours Total Cost " + vbTab + txtLabourTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("Travel Total Cost" + vbTab + vbTab + txtTravelTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
        rtReceipt.AppendText("Total Cost  " + txtTotal.Text + Environment.NewLine)
        rtReceipt.AppendText("-------------------------------------------------------------------------------" + Environment.NewLine)
        rtReceipt.AppendText(lblDate.Text + vbTab + vbTab + vbTab + lblTime.Text)
    End Sub

    Private Sub btnReceipt_MouseEnter(sender As Object, e As EventArgs) Handles btnReceipt.MouseEnter
        btnReceipt.BackColor = Color.DarkGray
    End Sub

    Private Sub btnReceipt_MouseLeave(sender As Object, e As EventArgs) Handles btnReceipt.MouseLeave
        btnReceipt.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub txtCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("City Names should contain letters", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtStateorProvince_TextChanged(sender As Object, e As EventArgs) Handles txtStateorProvince.TextChanged

    End Sub

    Private Sub txtStateorProvince_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStateorProvince.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("State/Province Names should contain letters", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtPostcode_TextChanged(sender As Object, e As EventArgs) Handles txtPostcode.TextChanged

    End Sub

    Private Sub txtPostcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostcode.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 48 To 57, 65 To 90
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Postcode should contain capital letters and numbers", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 13, 44, 48 To 57, 65 To 90, 97 To 122
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("Address should contain letters and numbers", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim font1 As New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
        e.Graphics.DrawString(rtReceipt.Text, Font, Brushes.Black, 100, 100)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

        If e.Node.Name = "Node11" Then
            RichTextBox1.Text = "Open this up to get help if you are confused"
        End If
        If e.Node.Name = "Node12" Then
            RichTextBox1.Text = "To input quantities in your Chrome Pipes. Tick the small box next to the Chrome Pipes text and input your amount in the rectangle textbox that will pop up after you tick the checkbox"
        End If

        If e.Node.Name = "Node13" Then
            RichTextBox1.Text = "To input quantities in your Copper Pipes. Tick the small box next to the Copper Pipes text and input your amount in the rectangle textbox that will pop up after you tick the checkbox"
        End If

        If e.Node.Name = "Node14" Then
            RichTextBox1.Text = "To input quantities in your Plastic Pipes. Tick the small box next to the Plastic Pipes text and input your amount in the rectangle textbox that will pop up after you tick the checkbox"
        End If

        If e.Node.Name = "Node15" Then
            RichTextBox1.Text = "To input quantities in your Labour. Tick the small box next to the Labour text and input your amount in the rectangle textbox that will pop up after you tick the checkbox"
        End If

        If e.Node.Name = "Node16" Then
            RichTextBox1.Text = "To input quantities in your Travel. Tick the small box next to the Travel text and input your amount in the rectangle textbox that will pop up after you tick the checkbox"
        End If
    End Sub
End Class
