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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(283, 130)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(81, 20)
        Me.txtNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Street"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(283, 181)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(81, 20)
        Me.txtStreet.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Post Code"
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(283, 260)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(81, 20)
        Me.txtPostCode.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(516, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(516, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Display"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Forename"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(283, 21)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(81, 20)
        Me.txtSurname.TabIndex = 10
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(283, 71)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(81, 20)
        Me.txtForename.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 436)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox

End Class
