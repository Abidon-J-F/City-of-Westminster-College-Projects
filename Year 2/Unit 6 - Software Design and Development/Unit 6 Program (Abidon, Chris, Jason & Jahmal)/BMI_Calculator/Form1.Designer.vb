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
        Me.btnCheckBMI = New System.Windows.Forms.Button()
        Me.btnResetBMI = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblTotalBMI = New System.Windows.Forms.Label()
        Me.btnBMR = New System.Windows.Forms.Button()
        Me.btnBMI = New System.Windows.Forms.Button()
        Me.btnMHR = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheckBMI
        '
        Me.btnCheckBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckBMI.Location = New System.Drawing.Point(12, 606)
        Me.btnCheckBMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCheckBMI.Name = "btnCheckBMI"
        Me.btnCheckBMI.Size = New System.Drawing.Size(195, 59)
        Me.btnCheckBMI.TabIndex = 0
        Me.btnCheckBMI.Text = "Check BMI"
        Me.btnCheckBMI.UseVisualStyleBackColor = True
        '
        'btnResetBMI
        '
        Me.btnResetBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBMI.Location = New System.Drawing.Point(281, 606)
        Me.btnResetBMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResetBMI.Name = "btnResetBMI"
        Me.btnResetBMI.Size = New System.Drawing.Size(205, 59)
        Me.btnResetBMI.TabIndex = 0
        Me.btnResetBMI.Text = "Reset BMI"
        Me.btnResetBMI.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(568, 606)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(175, 59)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit BMI"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(400, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(408, 58)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Body Mass Index"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(89, 252)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(203, 29)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Enter your Weight"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(89, 354)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(198, 29)
        Me.lblHeight.TabIndex = 1
        Me.lblHeight.Text = "Enter your Height"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMI.Location = New System.Drawing.Point(89, 460)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(112, 29)
        Me.lblBMI.TabIndex = 1
        Me.lblBMI.Text = "Your BMI"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(312, 234)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtWeight.Multiline = True
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(249, 63)
        Me.txtWeight.TabIndex = 2
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(312, 334)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHeight.Multiline = True
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(249, 63)
        Me.txtHeight.TabIndex = 2
        '
        'lblTotalBMI
        '
        Me.lblTotalBMI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBMI.Location = New System.Drawing.Point(307, 438)
        Me.lblTotalBMI.Name = "lblTotalBMI"
        Me.lblTotalBMI.Size = New System.Drawing.Size(255, 71)
        Me.lblTotalBMI.TabIndex = 1
        '
        'btnBMR
        '
        Me.btnBMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBMR.Location = New System.Drawing.Point(1243, 430)
        Me.btnBMR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBMR.Name = "btnBMR"
        Me.btnBMR.Size = New System.Drawing.Size(124, 49)
        Me.btnBMR.TabIndex = 3
        Me.btnBMR.Text = "BMR"
        Me.btnBMR.UseVisualStyleBackColor = True
        '
        'btnBMI
        '
        Me.btnBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBMI.Location = New System.Drawing.Point(1243, 327)
        Me.btnBMI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBMI.Name = "btnBMI"
        Me.btnBMI.Size = New System.Drawing.Size(124, 49)
        Me.btnBMI.TabIndex = 4
        Me.btnBMI.Text = "BMI"
        Me.btnBMI.UseVisualStyleBackColor = True
        '
        'btnMHR
        '
        Me.btnMHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnMHR.Location = New System.Drawing.Point(1243, 231)
        Me.btnMHR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMHR.Name = "btnMHR"
        Me.btnMHR.Size = New System.Drawing.Size(124, 49)
        Me.btnMHR.TabIndex = 5
        Me.btnMHR.Text = "MHR"
        Me.btnMHR.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BMI_Calculator.My.Resources.Resources.BMI_Table__2_
        Me.PictureBox1.Location = New System.Drawing.Point(661, 114)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(527, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 699)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBMR)
        Me.Controls.Add(Me.btnBMI)
        Me.Controls.Add(Me.btnMHR)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblTotalBMI)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetBMI)
        Me.Controls.Add(Me.btnCheckBMI)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "BMI Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheckBMI As Button
    Friend WithEvents btnResetBMI As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblTotalBMI As Label
    Friend WithEvents btnBMR As Button
    Friend WithEvents btnBMI As Button
    Friend WithEvents btnMHR As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
