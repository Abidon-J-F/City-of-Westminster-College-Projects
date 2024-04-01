<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arithmetic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblArithmetic = New System.Windows.Forms.Label()
        Me.lblEnterFirst = New System.Windows.Forms.Label()
        Me.lblEnterSecond = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRemainder = New System.Windows.Forms.Button()
        Me.btnExponentiation = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblArithmetic
        '
        Me.lblArithmetic.AutoSize = True
        Me.lblArithmetic.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArithmetic.Location = New System.Drawing.Point(26, -4)
        Me.lblArithmetic.Name = "lblArithmetic"
        Me.lblArithmetic.Size = New System.Drawing.Size(801, 73)
        Me.lblArithmetic.TabIndex = 0
        Me.lblArithmetic.Text = "Using Arithmetic Operators"
        '
        'lblEnterFirst
        '
        Me.lblEnterFirst.AutoSize = True
        Me.lblEnterFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterFirst.Location = New System.Drawing.Point(25, 108)
        Me.lblEnterFirst.Name = "lblEnterFirst"
        Me.lblEnterFirst.Size = New System.Drawing.Size(243, 31)
        Me.lblEnterFirst.TabIndex = 0
        Me.lblEnterFirst.Text = "Enter First Number"
        '
        'lblEnterSecond
        '
        Me.lblEnterSecond.AutoSize = True
        Me.lblEnterSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterSecond.Location = New System.Drawing.Point(25, 168)
        Me.lblEnterSecond.Name = "lblEnterSecond"
        Me.lblEnterSecond.Size = New System.Drawing.Size(281, 31)
        Me.lblEnterSecond.TabIndex = 0
        Me.lblEnterSecond.Text = "Enter Second Number"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(52, 299)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(105, 31)
        Me.lblAnswer.TabIndex = 0
        Me.lblAnswer.Text = "Answer"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(329, 290)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(112, 40)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "Label1"
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(341, 72)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 38)
        Me.txtFirst.TabIndex = 1
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(341, 149)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 38)
        Me.txtSecond.TabIndex = 1
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.Location = New System.Drawing.Point(562, 66)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(203, 49)
        Me.btnAddition.TabIndex = 2
        Me.btnAddition.Text = "Addition"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'A
        '
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.Location = New System.Drawing.Point(562, 121)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(203, 50)
        Me.btnSubtraction.TabIndex = 2
        Me.btnSubtraction.Text = "Subtraction"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(562, 177)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(203, 51)
        Me.btnDivision.TabIndex = 2
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.Location = New System.Drawing.Point(562, 234)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(203, 51)
        Me.btnMultiplication.TabIndex = 2
        Me.btnMultiplication.Text = "Multiplication"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(562, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(203, 52)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit Systems"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRemainder
        '
        Me.btnRemainder.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemainder.Location = New System.Drawing.Point(562, 291)
        Me.btnRemainder.Name = "btnRemainder"
        Me.btnRemainder.Size = New System.Drawing.Size(203, 51)
        Me.btnRemainder.TabIndex = 2
        Me.btnRemainder.Text = "Remainder"
        Me.btnRemainder.UseVisualStyleBackColor = True
        '
        'btnExponentiation
        '
        Me.btnExponentiation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExponentiation.Location = New System.Drawing.Point(562, 348)
        Me.btnExponentiation.Name = "btnExponentiation"
        Me.btnExponentiation.Size = New System.Drawing.Size(203, 52)
        Me.btnExponentiation.TabIndex = 2
        Me.btnExponentiation.Text = "Exponentiation"
        Me.btnExponentiation.UseVisualStyleBackColor = True
        '
        'Arithmetic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 608)
        Me.Controls.Add(Me.btnExponentiation)
        Me.Controls.Add(Me.btnRemainder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblEnterSecond)
        Me.Controls.Add(Me.lblEnterFirst)
        Me.Controls.Add(Me.lblArithmetic)
        Me.Name = "Arithmetic"
        Me.Text = "Arithmetic Operators"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArithmetic As Label
    Friend WithEvents lblEnterFirst As Label
    Friend WithEvents lblEnterSecond As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents btnAddition As Button
    Friend WithEvents A As ToolTip
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRemainder As Button
    Friend WithEvents btnExponentiation As Button
End Class
