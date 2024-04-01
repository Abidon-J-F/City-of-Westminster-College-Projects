Public Class Form1

    Dim Opera As String
    Dim firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim operators As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 300
        txtDisplay.Width = 220
        Me.Text = "Standard Calculator"
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

    Private Sub ScienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScienToolStripMenuItem.Click
        Me.Width = 550
        txtDisplay.Width = 480
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Width = 300
        txtDisplay.Width = 220
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim i As Integer

        For i = 1 To 12
            ListBox1.Items.Add(i & " x " & TextBox1.Text & " = " & i * TextBox1.Text)
        Next
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConversionToolStripMenuItem.Click
        Me.Width = 865
        txtDisplay.Width = 422
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        txtDisplay.Text = "3.141592653589976323"
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim ilog As Double

        ilog = Double.Parse(txtDisplay.Text)

        ilog = Math.Log10(ilog)
        txtDisplay.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Dim iSqrt As Double

        iSqrt = Double.Parse(txtDisplay.Text)

        iSqrt = Math.Sqrt(iSqrt)
        txtDisplay.Text = System.Convert.ToString(iSqrt)
    End Sub

    Private Sub btnX2_Click(sender As Object, e As EventArgs) Handles btnX2.Click
        Dim a As Double
        a = Convert.ToDouble(txtDisplay) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnSinh_Click(sender As Object, e As EventArgs) Handles btnSinh.Click
        Dim iSinh As Double
        iSinh = Double.Parse(txtDisplay.Text)

        iSinh = Math.Sinh(iSinh)
        txtDisplay.Text = System.Convert.ToString(iSinh)
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        Dim iSin As Double
        iSin = Double.Parse(txtDisplay.Text)

        iSin = Math.Sin(iSin)
        txtDisplay.Text = System.Convert.ToString(iSin)
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnX3_Click(sender As Object, e As EventArgs) Handles btnX3.Click
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnCosh_Click(sender As Object, e As EventArgs) Handles btnCosh.Click
        Dim iCosh As Double
        iCosh = Double.Parse(txtDisplay.Text)

        iCosh = Math.Cosh(iCosh)
        txtDisplay.Text = System.Convert.ToString(iCosh)
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Dim iCos As Double
        iCos = Double.Parse(txtDisplay.Text)

        iCos = Math.Cosh(iCos)
        txtDisplay.Text = System.Convert.ToString(iCos)
    End Sub

    Private Sub btnBin_Click(sender As Object, e As EventArgs) Handles btnBin.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 2)
    End Sub

    Private Sub Btn1x_Click(sender As Object, e As EventArgs) Handles Btn1x.Click
        Dim a As Double
        a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay))
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub btnTanh_Click(sender As Object, e As EventArgs) Handles btnTanh.Click
        Dim iTanh As Double
        iTanh = Double.Parse(txtDisplay.Text)

        iTanh = Math.Cosh(iTanh)
        txtDisplay.Text = System.Convert.ToString(iTanh)
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        Dim iTan As Double
        iTan = Double.Parse(txtDisplay.Text)

        iTan = Math.Cosh(iTan)
        txtDisplay.Text = System.Convert.ToString(iTan)
    End Sub

    Private Sub btnhex_Click(sender As Object, e As EventArgs) Handles btnhex.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 16)
    End Sub

    Private Sub btnInx_Click(sender As Object, e As EventArgs) Handles btnInx.Click
        Dim ilog As Double = Double.Parse(txtDisplay.Text)

        ilog = Math.Log(ilog)
        txtDisplay.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        ' this codes are for + ,- ,*, /, Mod, Exp
        Dim ops As Button = sender
        firstnum = txtDisplay.Text

        txtDisplay.Text = ""
        Opera = ops.Text
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        ' this codes are for + ,- ,*, /, Mod, Exp
        Dim ops As Button = sender

        txtDisplay.Text = ""
        Opera = ops.Text
    End Sub

    Private Sub btnOct_Click(sender As Object, e As EventArgs) Handles btnOct.Click
        Dim a As Integer = Integer.Parse(txtDisplay.Text)
        txtDisplay.Text = System.Convert.ToString(a, 8)
    End Sub

    Private Sub btnperc_Click(sender As Object, e As EventArgs) Handles btnperc.Click
        Dim a As Double
        a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100)
        txtDisplay.Text = System.Convert.ToString(a)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
    End Sub
End Class
