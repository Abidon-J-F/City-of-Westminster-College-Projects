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
        Me.lblNumber = New System.Windows.Forms.Label
        Me.lblStreet = New System.Windows.Forms.Label
        Me.lblPostCode = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblForename = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(298, 113)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Label1"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(298, 156)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(39, 13)
        Me.lblStreet.TabIndex = 1
        Me.lblStreet.Text = "Label1"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(298, 201)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(39, 13)
        Me.lblPostCode.TabIndex = 2
        Me.lblPostCode.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Street"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Post Code"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Forename"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Surname"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(298, 14)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(39, 13)
        Me.lblSurname.TabIndex = 14
        Me.lblSurname.Text = "Label1"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(298, 63)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(39, 13)
        Me.lblForename.TabIndex = 15
        Me.lblForename.Text = "Label1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 262)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPostCode)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblPostCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
End Class
