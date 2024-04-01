<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.rtReceipt = New System.Windows.Forms.RichTextBox()
        Me.lblCarTotal = New System.Windows.Forms.Label()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.lblCartext = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_MethodofPayments = New System.Windows.Forms.CheckedListBox()
        Me.chkProofofAddress = New System.Windows.Forms.CheckedListBox()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.dtpDateofHire = New System.Windows.Forms.DateTimePicker()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.nudNumberofDays = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxAdditionalInsurance = New System.Windows.Forms.ComboBox()
        Me.cbxCarModel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCarModel = New System.Windows.Forms.Label()
        Me.lblAdditionalinsurance = New System.Windows.Forms.Label()
        Me.lblCarRegistration = New System.Windows.Forms.Label()
        Me.txtCarRegistration = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblProofofAddress = New System.Windows.Forms.Label()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.lblMOP = New System.Windows.Forms.Label()
        Me.lblNumberofDays = New System.Windows.Forms.Label()
        Me.lblDateofHire = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblBicycleHireDetails = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.nudNumberofDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(849, 658)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(147, 49)
        Me.btnQuit.TabIndex = 36
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'rtReceipt
        '
        Me.rtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtReceipt.Location = New System.Drawing.Point(1063, 158)
        Me.rtReceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtReceipt.Name = "rtReceipt"
        Me.rtReceipt.Size = New System.Drawing.Size(447, 552)
        Me.rtReceipt.TabIndex = 35
        Me.rtReceipt.Text = ""
        '
        'lblCarTotal
        '
        Me.lblCarTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCarTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarTotal.Location = New System.Drawing.Point(492, 583)
        Me.lblCarTotal.Name = "lblCarTotal"
        Me.lblCarTotal.Size = New System.Drawing.Size(503, 53)
        Me.lblCarTotal.TabIndex = 33
        Me.lblCarTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblReceipt.Location = New System.Drawing.Point(1259, 113)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(116, 36)
        Me.lblReceipt.TabIndex = 25
        Me.lblReceipt.Text = "Receipt"
        '
        'lblCartext
        '
        Me.lblCartext.AutoSize = True
        Me.lblCartext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartext.Location = New System.Drawing.Point(217, 601)
        Me.lblCartext.Name = "lblCartext"
        Me.lblCartext.Size = New System.Drawing.Size(218, 29)
        Me.lblCartext.TabIndex = 27
        Me.lblCartext.Text = "Total Car Hire Cost"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chk_MethodofPayments)
        Me.Panel1.Controls.Add(Me.chkProofofAddress)
        Me.Panel1.Controls.Add(Me.lblCustomerDetails)
        Me.Panel1.Controls.Add(Me.dtpDateofHire)
        Me.Panel1.Controls.Add(Me.txtCustomerAddress)
        Me.Panel1.Controls.Add(Me.nudNumberofDays)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblCustomerID)
        Me.Panel1.Controls.Add(Me.txtCustomerName)
        Me.Panel1.Controls.Add(Me.txtCustomerID)
        Me.Panel1.Controls.Add(Me.lblCustomerName)
        Me.Panel1.Controls.Add(Me.lblProofofAddress)
        Me.Panel1.Controls.Add(Me.lblCustomerAddress)
        Me.Panel1.Controls.Add(Me.lblMOP)
        Me.Panel1.Controls.Add(Me.lblNumberofDays)
        Me.Panel1.Controls.Add(Me.lblDateofHire)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(27, 113)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 458)
        Me.Panel1.TabIndex = 34
        '
        'chk_MethodofPayments
        '
        Me.chk_MethodofPayments.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.chk_MethodofPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_MethodofPayments.FormattingEnabled = True
        Me.chk_MethodofPayments.Items.AddRange(New Object() {"Cash", "Card"})
        Me.chk_MethodofPayments.Location = New System.Drawing.Point(835, 187)
        Me.chk_MethodofPayments.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chk_MethodofPayments.Name = "chk_MethodofPayments"
        Me.chk_MethodofPayments.Size = New System.Drawing.Size(156, 67)
        Me.chk_MethodofPayments.TabIndex = 4
        '
        'chkProofofAddress
        '
        Me.chkProofofAddress.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.chkProofofAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProofofAddress.FormattingEnabled = True
        Me.chkProofofAddress.Items.AddRange(New Object() {"Bank Card", "Driving Licence", "Passport"})
        Me.chkProofofAddress.Location = New System.Drawing.Point(176, 327)
        Me.chkProofofAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkProofofAddress.Name = "chkProofofAddress"
        Me.chkProofofAddress.Size = New System.Drawing.Size(296, 109)
        Me.chkProofofAddress.TabIndex = 4
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblCustomerDetails.Location = New System.Drawing.Point(435, 17)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(141, 24)
        Me.lblCustomerDetails.TabIndex = 0
        Me.lblCustomerDetails.Text = "Customer Class"
        '
        'dtpDateofHire
        '
        Me.dtpDateofHire.Location = New System.Drawing.Point(767, 70)
        Me.dtpDateofHire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDateofHire.Name = "dtpDateofHire"
        Me.dtpDateofHire.Size = New System.Drawing.Size(200, 22)
        Me.dtpDateofHire.TabIndex = 5
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtCustomerAddress.Location = New System.Drawing.Point(176, 178)
        Me.txtCustomerAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerAddress.Multiline = True
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(296, 127)
        Me.txtCustomerAddress.TabIndex = 3
        '
        'nudNumberofDays
        '
        Me.nudNumberofDays.Location = New System.Drawing.Point(847, 123)
        Me.nudNumberofDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudNumberofDays.Name = "nudNumberofDays"
        Me.nudNumberofDays.Size = New System.Drawing.Size(121, 22)
        Me.nudNumberofDays.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbxAdditionalInsurance)
        Me.Panel2.Controls.Add(Me.cbxCarModel)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblCarModel)
        Me.Panel2.Controls.Add(Me.lblAdditionalinsurance)
        Me.Panel2.Controls.Add(Me.lblCarRegistration)
        Me.Panel2.Controls.Add(Me.txtCarRegistration)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(525, 272)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 169)
        Me.Panel2.TabIndex = 21
        '
        'cbxAdditionalInsurance
        '
        Me.cbxAdditionalInsurance.FormattingEnabled = True
        Me.cbxAdditionalInsurance.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbxAdditionalInsurance.Location = New System.Drawing.Point(199, 124)
        Me.cbxAdditionalInsurance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxAdditionalInsurance.Name = "cbxAdditionalInsurance"
        Me.cbxAdditionalInsurance.Size = New System.Drawing.Size(272, 24)
        Me.cbxAdditionalInsurance.TabIndex = 1
        '
        'cbxCarModel
        '
        Me.cbxCarModel.FormattingEnabled = True
        Me.cbxCarModel.Items.AddRange(New Object() {"Opel Astra Estate", "Jaguar XF", "Skoda Octavia", "VW Golf", "Ford Focus", "Fiat 500"})
        Me.cbxCarModel.Location = New System.Drawing.Point(199, 50)
        Me.cbxCarModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxCarModel.Name = "cbxCarModel"
        Me.cbxCarModel.Size = New System.Drawing.Size(272, 24)
        Me.cbxCarModel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(171, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Hire Class"
        '
        'lblCarModel
        '
        Me.lblCarModel.AutoSize = True
        Me.lblCarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCarModel.Location = New System.Drawing.Point(22, 54)
        Me.lblCarModel.Name = "lblCarModel"
        Me.lblCarModel.Size = New System.Drawing.Size(86, 20)
        Me.lblCarModel.TabIndex = 0
        Me.lblCarModel.Text = "Car Model"
        '
        'lblAdditionalinsurance
        '
        Me.lblAdditionalinsurance.AutoSize = True
        Me.lblAdditionalinsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAdditionalinsurance.Location = New System.Drawing.Point(22, 128)
        Me.lblAdditionalinsurance.Name = "lblAdditionalinsurance"
        Me.lblAdditionalinsurance.Size = New System.Drawing.Size(160, 20)
        Me.lblAdditionalinsurance.TabIndex = 0
        Me.lblAdditionalinsurance.Text = "Additional Insurance"
        '
        'lblCarRegistration
        '
        Me.lblCarRegistration.AutoSize = True
        Me.lblCarRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCarRegistration.Location = New System.Drawing.Point(22, 91)
        Me.lblCarRegistration.Name = "lblCarRegistration"
        Me.lblCarRegistration.Size = New System.Drawing.Size(131, 20)
        Me.lblCarRegistration.TabIndex = 0
        Me.lblCarRegistration.Text = "Car Registration"
        '
        'txtCarRegistration
        '
        Me.txtCarRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.txtCarRegistration.Location = New System.Drawing.Point(199, 91)
        Me.txtCarRegistration.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCarRegistration.Multiline = True
        Me.txtCarRegistration.Name = "txtCarRegistration"
        Me.txtCarRegistration.Size = New System.Drawing.Size(272, 24)
        Me.txtCarRegistration.TabIndex = 3
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCustomerID.Location = New System.Drawing.Point(11, 87)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(104, 20)
        Me.lblCustomerID.TabIndex = 0
        Me.lblCustomerID.Text = "Customer ID"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtCustomerName.Location = New System.Drawing.Point(173, 122)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerName.Multiline = True
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(297, 41)
        Me.txtCustomerName.TabIndex = 3
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtCustomerID.Location = New System.Drawing.Point(173, 71)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerID.Multiline = True
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(297, 35)
        Me.txtCustomerID.TabIndex = 3
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCustomerName.Location = New System.Drawing.Point(5, 143)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(131, 20)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblProofofAddress
        '
        Me.lblProofofAddress.AutoSize = True
        Me.lblProofofAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblProofofAddress.Location = New System.Drawing.Point(5, 354)
        Me.lblProofofAddress.Name = "lblProofofAddress"
        Me.lblProofofAddress.Size = New System.Drawing.Size(135, 20)
        Me.lblProofofAddress.TabIndex = 0
        Me.lblProofofAddress.Text = "Proof of Address"
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCustomerAddress.Location = New System.Drawing.Point(5, 207)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(149, 20)
        Me.lblCustomerAddress.TabIndex = 0
        Me.lblCustomerAddress.Text = "Customer Address"
        '
        'lblMOP
        '
        Me.lblMOP.AutoSize = True
        Me.lblMOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMOP.Location = New System.Drawing.Point(523, 207)
        Me.lblMOP.Name = "lblMOP"
        Me.lblMOP.Size = New System.Drawing.Size(279, 20)
        Me.lblMOP.TabIndex = 0
        Me.lblMOP.Text = "Method of Payments (Cash or Card)"
        '
        'lblNumberofDays
        '
        Me.lblNumberofDays.AutoSize = True
        Me.lblNumberofDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumberofDays.Location = New System.Drawing.Point(525, 126)
        Me.lblNumberofDays.Name = "lblNumberofDays"
        Me.lblNumberofDays.Size = New System.Drawing.Size(131, 20)
        Me.lblNumberofDays.TabIndex = 0
        Me.lblNumberofDays.Text = "Number of Days"
        '
        'lblDateofHire
        '
        Me.lblDateofHire.AutoSize = True
        Me.lblDateofHire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDateofHire.Location = New System.Drawing.Point(525, 71)
        Me.lblDateofHire.Name = "lblDateofHire"
        Me.lblDateofHire.Size = New System.Drawing.Size(101, 20)
        Me.lblDateofHire.TabIndex = 0
        Me.lblDateofHire.Text = "Date of Hire"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(240, 658)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(147, 49)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(646, 658)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(147, 49)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(449, 658)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 49)
        Me.btnCalculate.TabIndex = 31
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(36, 658)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(147, 49)
        Me.btnPrevious.TabIndex = 32
        Me.btnPrevious.Text = "Go Back"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblBicycleHireDetails
        '
        Me.lblBicycleHireDetails.AutoSize = True
        Me.lblBicycleHireDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBicycleHireDetails.Location = New System.Drawing.Point(611, 34)
        Me.lblBicycleHireDetails.Name = "lblBicycleHireDetails"
        Me.lblBicycleHireDetails.Size = New System.Drawing.Size(258, 39)
        Me.lblBicycleHireDetails.TabIndex = 26
        Me.lblBicycleHireDetails.Text = "Car Hire Details"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1537, 745)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.rtReceipt)
        Me.Controls.Add(Me.lblCarTotal)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.lblCartext)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblBicycleHireDetails)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.Text = "Car Hire Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudNumberofDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents rtReceipt As RichTextBox
    Friend WithEvents lblCarTotal As Label
    Friend WithEvents lblReceipt As Label
    Friend WithEvents lblCartext As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chk_MethodofPayments As CheckedListBox
    Friend WithEvents chkProofofAddress As CheckedListBox
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents dtpDateofHire As DateTimePicker
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents nudNumberofDays As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCarModel As Label
    Friend WithEvents lblCarRegistration As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblProofofAddress As Label
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents lblMOP As Label
    Friend WithEvents lblNumberofDays As Label
    Friend WithEvents lblDateofHire As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblBicycleHireDetails As Label
    Friend WithEvents cbxAdditionalInsurance As ComboBox
    Friend WithEvents cbxCarModel As ComboBox
    Friend WithEvents lblAdditionalinsurance As Label
    Friend WithEvents txtCarRegistration As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
