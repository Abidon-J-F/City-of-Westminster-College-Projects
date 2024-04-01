<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblItemAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radIceCappuccino = New System.Windows.Forms.RadioButton()
        Me.radIcedLatte = New System.Windows.Forms.RadioButton()
        Me.radLatte = New System.Windows.Forms.RadioButton()
        Me.radEspresso = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTax = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.chkTax)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.lblItemAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear for Next Item"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(38, 156)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(115, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Selection"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblItemAmount
        '
        Me.lblItemAmount.BackColor = System.Drawing.Color.White
        Me.lblItemAmount.Location = New System.Drawing.Point(143, 208)
        Me.lblItemAmount.Name = "lblItemAmount"
        Me.lblItemAmount.Size = New System.Drawing.Size(169, 35)
        Me.lblItemAmount.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(101, 32)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(124, 23)
        Me.txtQuantity.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.radIceCappuccino)
        Me.GroupBox2.Controls.Add(Me.radIcedLatte)
        Me.GroupBox2.Controls.Add(Me.radLatte)
        Me.GroupBox2.Controls.Add(Me.radEspresso)
        Me.GroupBox2.Controls.Add(Me.radCappuccino)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 224)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee Selection"
        '
        'radIceCappuccino
        '
        Me.radIceCappuccino.AutoSize = True
        Me.radIceCappuccino.Location = New System.Drawing.Point(17, 179)
        Me.radIceCappuccino.Name = "radIceCappuccino"
        Me.radIceCappuccino.Size = New System.Drawing.Size(100, 17)
        Me.radIceCappuccino.TabIndex = 1
        Me.radIceCappuccino.TabStop = True
        Me.radIceCappuccino.Text = "Ice Cappuccino"
        Me.radIceCappuccino.UseVisualStyleBackColor = True
        '
        'radIcedLatte
        '
        Me.radIcedLatte.AutoSize = True
        Me.radIcedLatte.Location = New System.Drawing.Point(17, 137)
        Me.radIcedLatte.Name = "radIcedLatte"
        Me.radIcedLatte.Size = New System.Drawing.Size(73, 17)
        Me.radIcedLatte.TabIndex = 1
        Me.radIcedLatte.TabStop = True
        Me.radIcedLatte.Text = "Iced Latte"
        Me.radIcedLatte.UseVisualStyleBackColor = True
        '
        'radLatte
        '
        Me.radLatte.AutoSize = True
        Me.radLatte.Location = New System.Drawing.Point(17, 101)
        Me.radLatte.Name = "radLatte"
        Me.radLatte.Size = New System.Drawing.Size(49, 17)
        Me.radLatte.TabIndex = 1
        Me.radLatte.TabStop = True
        Me.radLatte.Text = "Latte"
        Me.radLatte.UseVisualStyleBackColor = True
        '
        'radEspresso
        '
        Me.radEspresso.AutoSize = True
        Me.radEspresso.Location = New System.Drawing.Point(17, 63)
        Me.radEspresso.Name = "radEspresso"
        Me.radEspresso.Size = New System.Drawing.Size(68, 17)
        Me.radEspresso.TabIndex = 1
        Me.radEspresso.TabStop = True
        Me.radEspresso.Text = "Espresso"
        Me.radEspresso.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(17, 29)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(82, 17)
        Me.radCappuccino.TabIndex = 1
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Cappuccino"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(631, 141)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotal.Location = New System.Drawing.Point(171, 97)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(423, 27)
        Me.lblTotal.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sub Total"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTax.Location = New System.Drawing.Point(171, 55)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(423, 28)
        Me.lblTax.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tax (If Takeout)"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblSubTotal.Location = New System.Drawing.Point(171, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(423, 31)
        Me.lblSubTotal.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Due"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Takeout?"
        '
        'chkTax
        '
        Me.chkTax.AutoSize = True
        Me.chkTax.Location = New System.Drawing.Point(86, 105)
        Me.chkTax.Name = "chkTax"
        Me.chkTax.Size = New System.Drawing.Size(15, 14)
        Me.chkTax.TabIndex = 8
        Me.chkTax.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(676, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Billing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radIceCappuccino As RadioButton
    Friend WithEvents radIcedLatte As RadioButton
    Friend WithEvents radLatte As RadioButton
    Friend WithEvents radEspresso As RadioButton
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblItemAmount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents chkTax As CheckBox
    Friend WithEvents Label6 As Label
End Class
