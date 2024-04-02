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
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtOverdraftLimit = New System.Windows.Forms.TextBox
        Me.nudAccountNo = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Forename = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblBalance = New System.Windows.Forms.Label
        Me.btnWithdraw = New System.Windows.Forms.Button
        Me.btnDeposit = New System.Windows.Forms.Button
        Me.txtTransaction = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnDisplay = New System.Windows.Forms.Button
        CType(Me.nudAccountNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(350, 34)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(108, 20)
        Me.txtname.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(350, 92)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(108, 20)
        Me.txtAddress.TabIndex = 2
        '
        'txtOverdraftLimit
        '
        Me.txtOverdraftLimit.Location = New System.Drawing.Point(350, 161)
        Me.txtOverdraftLimit.Name = "txtOverdraftLimit"
        Me.txtOverdraftLimit.Size = New System.Drawing.Size(108, 20)
        Me.txtOverdraftLimit.TabIndex = 3
        '
        'nudAccountNo
        '
        Me.nudAccountNo.Location = New System.Drawing.Point(350, 242)
        Me.nudAccountNo.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudAccountNo.Name = "nudAccountNo"
        Me.nudAccountNo.Size = New System.Drawing.Size(77, 20)
        Me.nudAccountNo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Address"
        '
        'Forename
        '
        Me.Forename.AutoSize = True
        Me.Forename.Location = New System.Drawing.Point(220, 164)
        Me.Forename.Name = "Forename"
        Me.Forename.Size = New System.Drawing.Size(71, 13)
        Me.Forename.TabIndex = 7
        Me.Forename.Text = "Overdraft limit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Account Number"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(102, 332)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(31, 13)
        Me.lblBalance.TabIndex = 10
        Me.lblBalance.Text = "0000"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Enabled = False
        Me.btnWithdraw.Location = New System.Drawing.Point(716, 332)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(104, 32)
        Me.btnWithdraw.TabIndex = 11
        Me.btnWithdraw.Text = "Withdrawal"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Enabled = False
        Me.btnDeposit.Location = New System.Drawing.Point(532, 332)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(104, 32)
        Me.btnDeposit.TabIndex = 12
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtTransaction
        '
        Me.txtTransaction.Enabled = False
        Me.txtTransaction.Location = New System.Drawing.Point(702, 37)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(108, 20)
        Me.txtTransaction.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(569, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Transaction amount"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(353, 332)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(104, 32)
        Me.btnCreate.TabIndex = 9
        Me.btnCreate.Text = "Create Account"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Enabled = False
        Me.btnDisplay.Location = New System.Drawing.Point(354, 456)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(104, 32)
        Me.btnDisplay.TabIndex = 15
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 560)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Forename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudAccountNo)
        Me.Controls.Add(Me.txtOverdraftLimit)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtname)
        Me.Name = "Form1"
        Me.Text = "Westminster Bank"
        CType(Me.nudAccountNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtOverdraftLimit As System.Windows.Forms.TextBox
    Friend WithEvents nudAccountNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Forename As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents txtTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button

End Class
