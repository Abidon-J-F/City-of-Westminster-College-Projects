<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.txtAGE = New System.Windows.Forms.TextBox()
        Me.lblAGE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnBMR = New System.Windows.Forms.Button()
        Me.lblTextResult = New System.Windows.Forms.Label()
        Me.btncalcMHR = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResetMHR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAGE
        '
        Me.txtAGE.Location = New System.Drawing.Point(280, 175)
        Me.txtAGE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAGE.Multiline = True
        Me.txtAGE.Name = "txtAGE"
        Me.txtAGE.Size = New System.Drawing.Size(263, 46)
        Me.txtAGE.TabIndex = 0
        '
        'lblAGE
        '
        Me.lblAGE.AutoSize = True
        Me.lblAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAGE.Location = New System.Drawing.Point(162, 190)
        Me.lblAGE.Name = "lblAGE"
        Me.lblAGE.Size = New System.Drawing.Size(62, 31)
        Me.lblAGE.TabIndex = 1
        Me.lblAGE.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(414, 48)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Maximum Heart Rate"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(929, 137)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "MHR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBMI.Location = New System.Drawing.Point(929, 233)
        Me.btnBMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(124, 49)
        Me.btnBMI.TabIndex = 2
        Me.btnBMI.Text = "BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnBMR
        '
        Me.btnBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBMR.Location = New System.Drawing.Point(929, 335)
        Me.btnBMR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBMR.Name = "btnBMR"
        Me.btnBMR.Size = New System.Drawing.Size(124, 49)
        Me.btnBMR.TabIndex = 2
        Me.btnBMR.Text = "BMR"
        Me.btnBMR.UseVisualStyleBackColor = True
        '
        'lblTextResult
        '
        Me.lblTextResult.AutoSize = True
        Me.lblTextResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextResult.Location = New System.Drawing.Point(144, 308)
        Me.lblTextResult.Name = "lblTextResult"
        Me.lblTextResult.Size = New System.Drawing.Size(92, 31)
        Me.lblTextResult.TabIndex = 1
        Me.lblTextResult.Text = "Result"
        '
        'btncalcMHR
        '
        Me.btncalcMHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btncalcMHR.Location = New System.Drawing.Point(50, 456)
        Me.btncalcMHR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btncalcMHR.Name = "btncalcMHR"
        Me.btncalcMHR.Size = New System.Drawing.Size(200, 49)
        Me.btncalcMHR.TabIndex = 2
        Me.btncalcMHR.Text = "Calculate MHR"
        Me.btncalcMHR.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(274, 287)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(269, 64)
        Me.lblResult.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(591, 454)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 49)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit MHR"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnResetMHR
        '
        Me.btnResetMHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetMHR.Location = New System.Drawing.Point(325, 457)
        Me.btnResetMHR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResetMHR.Name = "btnResetMHR"
        Me.btnResetMHR.Size = New System.Drawing.Size(189, 46)
        Me.btnResetMHR.TabIndex = 4
        Me.btnResetMHR.Text = "Reset MHR"
        Me.btnResetMHR.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 650)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetMHR)
        Me.Controls.Add(Me.btnBMR)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btncalcMHR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblTextResult)
        Me.Controls.Add(Me.lblAGE)
        Me.Controls.Add(Me.txtAGE)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form4"
        Me.Text = "MHR Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAGE As TextBox
    Friend WithEvents lblAGE As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnBMR As Button
    Friend WithEvents lblTextResult As Label
    Friend WithEvents btncalcMHR As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResetMHR As Button
End Class
