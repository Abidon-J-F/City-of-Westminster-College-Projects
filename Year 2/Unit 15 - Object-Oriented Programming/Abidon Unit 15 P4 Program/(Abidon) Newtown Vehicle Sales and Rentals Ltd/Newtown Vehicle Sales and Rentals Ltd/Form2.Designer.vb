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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblBicycleHireDetails = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nudChildrenBikes = New System.Windows.Forms.NumericUpDown()
        Me.nudAdultBikes = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumberofAdultBikesHired = New System.Windows.Forms.Label()
        Me.lblNumberofChildrenBikesHired = New System.Windows.Forms.Label()
        Me.lblBikeTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpDateofHire = New System.Windows.Forms.DateTimePicker()
        Me.nudNumberofDays = New System.Windows.Forms.NumericUpDown()
        Me.lblMOP = New System.Windows.Forms.Label()
        Me.lblNumberofDays = New System.Windows.Forms.Label()
        Me.lblDateofHire = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_MethodofPayments = New System.Windows.Forms.CheckedListBox()
        Me.chkProofofAddress = New System.Windows.Forms.CheckedListBox()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblProofofAddress = New System.Windows.Forms.Label()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.rtReceipt = New System.Windows.Forms.RichTextBox()
        Me.lblReceipt = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        CType(Me.nudChildrenBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAdultBikes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberofDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBicycleHireDetails
        '
        Me.lblBicycleHireDetails.AutoSize = True
        Me.lblBicycleHireDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBicycleHireDetails.Location = New System.Drawing.Point(596, 9)
        Me.lblBicycleHireDetails.Name = "lblBicycleHireDetails"
        Me.lblBicycleHireDetails.Size = New System.Drawing.Size(312, 39)
        Me.lblBicycleHireDetails.TabIndex = 0
        Me.lblBicycleHireDetails.Text = "Bicycle Hire Details"
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(21, 633)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(147, 49)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "Go Back"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(431, 633)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(147, 49)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.nudChildrenBikes)
        Me.Panel2.Controls.Add(Me.nudAdultBikes)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblNumberofAdultBikesHired)
        Me.Panel2.Controls.Add(Me.lblNumberofChildrenBikesHired)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(525, 272)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 169)
        Me.Panel2.TabIndex = 21
        '
        'nudChildrenBikes
        '
        Me.nudChildrenBikes.Location = New System.Drawing.Point(320, 123)
        Me.nudChildrenBikes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudChildrenBikes.Name = "nudChildrenBikes"
        Me.nudChildrenBikes.Size = New System.Drawing.Size(121, 22)
        Me.nudChildrenBikes.TabIndex = 4
        '
        'nudAdultBikes
        '
        Me.nudAdultBikes.Location = New System.Drawing.Point(320, 70)
        Me.nudAdultBikes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudAdultBikes.Name = "nudAdultBikes"
        Me.nudAdultBikes.Size = New System.Drawing.Size(121, 22)
        Me.nudAdultBikes.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(164, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bike Hire Class"
        '
        'lblNumberofAdultBikesHired
        '
        Me.lblNumberofAdultBikesHired.AutoSize = True
        Me.lblNumberofAdultBikesHired.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumberofAdultBikesHired.Location = New System.Drawing.Point(5, 71)
        Me.lblNumberofAdultBikesHired.Name = "lblNumberofAdultBikesHired"
        Me.lblNumberofAdultBikesHired.Size = New System.Drawing.Size(223, 20)
        Me.lblNumberofAdultBikesHired.TabIndex = 0
        Me.lblNumberofAdultBikesHired.Text = "Number of Adult Bikes Hired"
        '
        'lblNumberofChildrenBikesHired
        '
        Me.lblNumberofChildrenBikesHired.AutoSize = True
        Me.lblNumberofChildrenBikesHired.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblNumberofChildrenBikesHired.Location = New System.Drawing.Point(7, 122)
        Me.lblNumberofChildrenBikesHired.Name = "lblNumberofChildrenBikesHired"
        Me.lblNumberofChildrenBikesHired.Size = New System.Drawing.Size(247, 20)
        Me.lblNumberofChildrenBikesHired.TabIndex = 0
        Me.lblNumberofChildrenBikesHired.Text = "Number of Children Bikes Hired"
        '
        'lblBikeTotal
        '
        Me.lblBikeTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBikeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBikeTotal.Location = New System.Drawing.Point(477, 558)
        Me.lblBikeTotal.Name = "lblBikeTotal"
        Me.lblBikeTotal.Size = New System.Drawing.Size(503, 53)
        Me.lblBikeTotal.TabIndex = 8
        Me.lblBikeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(203, 575)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(257, 29)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total Bicycle Hire Cost"
        '
        'dtpDateofHire
        '
        Me.dtpDateofHire.Location = New System.Drawing.Point(767, 70)
        Me.dtpDateofHire.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpDateofHire.Name = "dtpDateofHire"
        Me.dtpDateofHire.Size = New System.Drawing.Size(200, 22)
        Me.dtpDateofHire.TabIndex = 5
        '
        'nudNumberofDays
        '
        Me.nudNumberofDays.Location = New System.Drawing.Point(847, 123)
        Me.nudNumberofDays.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nudNumberofDays.Name = "nudNumberofDays"
        Me.nudNumberofDays.Size = New System.Drawing.Size(121, 22)
        Me.nudNumberofDays.TabIndex = 4
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
        Me.Panel1.Location = New System.Drawing.Point(12, 87)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 458)
        Me.Panel1.TabIndex = 22
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
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(639, 633)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(147, 49)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(228, 633)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(147, 49)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'rtReceipt
        '
        Me.rtReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtReceipt.Location = New System.Drawing.Point(1049, 132)
        Me.rtReceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtReceipt.Name = "rtReceipt"
        Me.rtReceipt.Size = New System.Drawing.Size(447, 552)
        Me.rtReceipt.TabIndex = 23
        Me.rtReceipt.Text = ""
        '
        'lblReceipt
        '
        Me.lblReceipt.AutoSize = True
        Me.lblReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblReceipt.Location = New System.Drawing.Point(1245, 87)
        Me.lblReceipt.Name = "lblReceipt"
        Me.lblReceipt.Size = New System.Drawing.Size(116, 36)
        Me.lblReceipt.TabIndex = 0
        Me.lblReceipt.Text = "Receipt"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(835, 633)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(147, 49)
        Me.btnQuit.TabIndex = 24
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
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
        'PrintDocument1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1539, 694)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.rtReceipt)
        Me.Controls.Add(Me.lblBikeTotal)
        Me.Controls.Add(Me.lblReceipt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblBicycleHireDetails)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Bicycle Hire Page"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.nudChildrenBikes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAdultBikes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberofDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBicycleHireDetails As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpDateofHire As DateTimePicker
    Friend WithEvents nudNumberofDays As NumericUpDown
    Friend WithEvents nudChildrenBikes As NumericUpDown
    Friend WithEvents nudAdultBikes As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumberofAdultBikesHired As Label
    Friend WithEvents lblNumberofChildrenBikesHired As Label
    Friend WithEvents lblMOP As Label
    Friend WithEvents lblNumberofDays As Label
    Friend WithEvents lblDateofHire As Label
    Friend WithEvents lblBikeTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblProofofAddress As Label
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents chkProofofAddress As CheckedListBox
    Friend WithEvents chk_MethodofPayments As CheckedListBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents rtReceipt As RichTextBox
    Friend WithEvents lblReceipt As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
