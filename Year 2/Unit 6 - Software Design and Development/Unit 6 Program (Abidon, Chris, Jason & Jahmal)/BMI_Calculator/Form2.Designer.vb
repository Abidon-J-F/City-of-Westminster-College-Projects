<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnBMR = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnMHR = New System.Windows.Forms.Button()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblTotalBMRMale = New System.Windows.Forms.Label()
        Me.lblMaleBMR = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResetBMR = New System.Windows.Forms.Button()
        Me.btnCheckBMR = New System.Windows.Forms.Button()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblTotalBMRFemale = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBMR
        '
        Me.btnBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBMR.Location = New System.Drawing.Point(927, 413)
        Me.btnBMR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBMR.Name = "btnBMR"
        Me.btnBMR.Size = New System.Drawing.Size(124, 49)
        Me.btnBMR.TabIndex = 17
        Me.btnBMR.Text = "BMR"
        Me.btnBMR.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBMI.Location = New System.Drawing.Point(927, 310)
        Me.btnBMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(124, 49)
        Me.btnBMI.TabIndex = 18
        Me.btnBMI.Text = "BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnMHR
        '
        Me.btnMHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnMHR.Location = New System.Drawing.Point(927, 214)
        Me.btnMHR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMHR.Name = "btnMHR"
        Me.btnMHR.Size = New System.Drawing.Size(124, 49)
        Me.btnMHR.TabIndex = 19
        Me.btnMHR.Text = "MHR"
        Me.btnMHR.UseVisualStyleBackColor = True
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(391, 240)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(249, 42)
        Me.txtHeight.TabIndex = 15
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(391, 329)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(249, 38)
        Me.txtWeight.TabIndex = 16
        '
        'lblTotalBMRMale
        '
        Me.lblTotalBMRMale.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalBMRMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBMRMale.Location = New System.Drawing.Point(321, 549)
        Me.lblTotalBMRMale.Name = "lblTotalBMRMale"
        Me.lblTotalBMRMale.Size = New System.Drawing.Size(170, 50)
        Me.lblTotalBMRMale.TabIndex = 10
        '
        'lblMaleBMR
        '
        Me.lblMaleBMR.AutoSize = True
        Me.lblMaleBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaleBMR.Location = New System.Drawing.Point(141, 540)
        Me.lblMaleBMR.Name = "lblMaleBMR"
        Me.lblMaleBMR.Size = New System.Drawing.Size(123, 29)
        Me.lblMaleBMR.TabIndex = 11
        Me.lblMaleBMR.Text = "Your BMR"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(168, 338)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(203, 29)
        Me.lblHeight.TabIndex = 12
        Me.lblHeight.Text = "Enter your Weight"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(168, 253)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(198, 29)
        Me.lblWeight.TabIndex = 13
        Me.lblWeight.Text = "Enter your Height"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(264, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(497, 58)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Text = "Basal Metabolic Rate"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(707, 629)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 39)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit BMR"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnResetBMR
        '
        Me.btnResetBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBMR.Location = New System.Drawing.Point(417, 629)
        Me.btnResetBMR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResetBMR.Name = "btnResetBMR"
        Me.btnResetBMR.Size = New System.Drawing.Size(166, 39)
        Me.btnResetBMR.TabIndex = 8
        Me.btnResetBMR.Text = "Reset BMR"
        Me.btnResetBMR.UseVisualStyleBackColor = True
        '
        'btnCheckBMR
        '
        Me.btnCheckBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckBMR.Location = New System.Drawing.Point(146, 629)
        Me.btnCheckBMR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCheckBMR.Name = "btnCheckBMR"
        Me.btnCheckBMR.Size = New System.Drawing.Size(156, 39)
        Me.btnCheckBMR.TabIndex = 9
        Me.btnCheckBMR.Text = "Check BMR"
        Me.btnCheckBMR.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMale.Location = New System.Drawing.Point(350, 160)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(76, 29)
        Me.rdbMale.TabIndex = 20
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFemale.Location = New System.Drawing.Point(520, 160)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(98, 29)
        Me.rdbFemale.TabIndex = 20
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(198, 415)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(56, 29)
        Me.lblAge.TabIndex = 11
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(391, 406)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(249, 38)
        Me.txtAge.TabIndex = 16
        '
        'lblTotalBMRFemale
        '
        Me.lblTotalBMRFemale.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalBMRFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBMRFemale.Location = New System.Drawing.Point(591, 549)
        Me.lblTotalBMRFemale.Name = "lblTotalBMRFemale"
        Me.lblTotalBMRFemale.Size = New System.Drawing.Size(170, 50)
        Me.lblTotalBMRFemale.TabIndex = 10
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.Location = New System.Drawing.Point(345, 502)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(125, 29)
        Me.lblMale.TabIndex = 11
        Me.lblMale.Text = "Male BMR"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.Location = New System.Drawing.Point(591, 502)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(154, 29)
        Me.lblFemale.TabIndex = 11
        Me.lblFemale.Text = "Female BMR"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 679)
        Me.Controls.Add(Me.rdbFemale)
        Me.Controls.Add(Me.rdbMale)
        Me.Controls.Add(Me.btnBMR)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnMHR)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblTotalBMRFemale)
        Me.Controls.Add(Me.lblTotalBMRMale)
        Me.Controls.Add(Me.lblFemale)
        Me.Controls.Add(Me.lblMale)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblMaleBMR)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetBMR)
        Me.Controls.Add(Me.btnCheckBMR)
        Me.Name = "Form2"
        Me.Text = "BMR Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBMR As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnMHR As Button
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblTotalBMRMale As Label
    Friend WithEvents lblMaleBMR As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResetBMR As Button
    Friend WithEvents btnCheckBMR As Button
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblTotalBMRFemale As Label
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
End Class
