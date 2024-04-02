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
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(48, 27)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(173, 61)
        Me.btnDeposit.TabIndex = 0
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Location = New System.Drawing.Point(48, 94)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(173, 53)
        Me.btnWithdrawal.TabIndex = 0
        Me.btnWithdrawal.Text = "Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(48, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 56)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(48, 241)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 68)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Button1"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(94, 364)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 68)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Button1"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 601)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnWithdrawal)
        Me.Controls.Add(Me.btnDeposit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
