Public Class Form1
    Dim mcSubTotal As Double
    Dim mcTotal As Double
    Const cCAPPUCCINO_PRICE = 3
    Const cESPRESSO_PRICE = 3.25
    Const cLATTE_PRICE = 2.85
    Const cICED_PRICE = 4.25
    Const mcTAX_RATE = 0.75

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        With txtQuantity
            .Text = ""
            .Focus()
        End With
        lblItemAmount.Text = ""
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""

        radCappuccino.Checked = False
        radEspresso.Checked = False
        radIcedLatte.Checked = False
        radLatte.Checked = False
        radIceCappuccino.Checked = False
        chkTax.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim cPrice As Double
        Dim iQuantity As Double
        Dim cTax As Double
        Dim cItemAmount As Double


        If radCappuccino.Checked = True Then
            cPrice = cCAPPUCCINO_PRICE
        ElseIf radEspresso.Checked = True Then
            cPrice = cESPRESSO_PRICE
        ElseIf radLatte.Checked = True Then
            cPrice = cLATTE_PRICE
        ElseIf radIcedLatte.Checked = True Then
            cPrice = cICED_PRICE
        ElseIf radIceCappuccino.Checked = True Then
            cPrice = cICED_PRICE
        Else : MsgBox("Please Select a Drink", MsgBoxStyle.Information + )
        End If
    End Sub
End Class
