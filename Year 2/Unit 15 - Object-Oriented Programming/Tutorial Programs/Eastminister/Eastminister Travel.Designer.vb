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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCAddress = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblWeeks = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.nudPeople = New System.Windows.Forms.NumericUpDown()
        Me.nudWeeks = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTName = New System.Windows.Forms.Label()
        CType(Me.nudPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWeeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(196, 43)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(183, 28)
        Me.txtName.TabIndex = 0
        '
        'lblCName
        '
        Me.lblCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCName.Location = New System.Drawing.Point(29, 43)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(141, 25)
        Me.lblCName.TabIndex = 1
        Me.lblCName.Text = "Customer Name"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(196, 100)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(183, 28)
        Me.txtAddress.TabIndex = 0
        '
        'lblCAddress
        '
        Me.lblCAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCAddress.Location = New System.Drawing.Point(29, 103)
        Me.lblCAddress.Name = "lblCAddress"
        Me.lblCAddress.Size = New System.Drawing.Size(141, 25)
        Me.lblCAddress.TabIndex = 1
        Me.lblCAddress.Text = "Customer Address"
        '
        'lblDestination
        '
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDestination.Location = New System.Drawing.Point(29, 177)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(116, 25)
        Me.lblDestination.TabIndex = 1
        Me.lblDestination.Text = "Destination"
        '
        'lblPeople
        '
        Me.lblPeople.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPeople.Location = New System.Drawing.Point(29, 255)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(89, 25)
        Me.lblPeople.TabIndex = 1
        Me.lblPeople.Text = "People"
        '
        'lblWeeks
        '
        Me.lblWeeks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblWeeks.Location = New System.Drawing.Point(29, 330)
        Me.lblWeeks.Name = "lblWeeks"
        Me.lblWeeks.Size = New System.Drawing.Size(98, 25)
        Me.lblWeeks.TabIndex = 1
        Me.lblWeeks.Text = "Weeks"
        '
        'cboDestination
        '
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Location = New System.Drawing.Point(196, 177)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(183, 21)
        Me.cboDestination.TabIndex = 2
        '
        'nudPeople
        '
        Me.nudPeople.Location = New System.Drawing.Point(196, 255)
        Me.nudPeople.Name = "nudPeople"
        Me.nudPeople.Size = New System.Drawing.Size(120, 20)
        Me.nudPeople.TabIndex = 3
        '
        'nudWeeks
        '
        Me.nudWeeks.Location = New System.Drawing.Point(196, 330)
        Me.nudWeeks.Name = "nudWeeks"
        Me.nudWeeks.Size = New System.Drawing.Size(120, 20)
        Me.nudWeeks.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.Location = New System.Drawing.Point(444, 152)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(149, 46)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(193, 407)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(186, 36)
        Me.lblTotal.TabIndex = 5
        '
        'lblTName
        '
        Me.lblTName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTName.Location = New System.Drawing.Point(39, 407)
        Me.lblTName.Name = "lblTName"
        Me.lblTName.Size = New System.Drawing.Size(79, 36)
        Me.lblTName.TabIndex = 5
        Me.lblTName.Text = "Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(605, 524)
        Me.Controls.Add(Me.lblTName)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.nudWeeks)
        Me.Controls.Add(Me.nudPeople)
        Me.Controls.Add(Me.cboDestination)
        Me.Controls.Add(Me.lblWeeks)
        Me.Controls.Add(Me.lblPeople)
        Me.Controls.Add(Me.lblDestination)
        Me.Controls.Add(Me.lblCAddress)
        Me.Controls.Add(Me.lblCName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Eastminister Travel"
        CType(Me.nudPeople, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWeeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents lblCName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCAddress As Label
    Friend WithEvents lblDestination As Label
    Friend WithEvents lblPeople As Label
    Friend WithEvents lblWeeks As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents nudPeople As NumericUpDown
    Friend WithEvents nudWeeks As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTName As Label
End Class
