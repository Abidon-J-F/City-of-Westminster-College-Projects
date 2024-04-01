<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Me.IbIMessage = New System.Windows.Forms.Label()
        Me.btnCWCMessage = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IbIMessage
        '
        Me.IbIMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IbIMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IbIMessage.Location = New System.Drawing.Point(12, 9)
        Me.IbIMessage.Name = "IbIMessage"
        Me.IbIMessage.Size = New System.Drawing.Size(575, 87)
        Me.IbIMessage.TabIndex = 0
        '
        'btnCWCMessage
        '
        Me.btnCWCMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCWCMessage.Location = New System.Drawing.Point(12, 128)
        Me.btnCWCMessage.Name = "btnCWCMessage"
        Me.btnCWCMessage.Size = New System.Drawing.Size(189, 49)
        Me.btnCWCMessage.TabIndex = 1
        Me.btnCWCMessage.Text = "Message"
        Me.btnCWCMessage.UseVisualStyleBackColor = True
        '
        'btnCourse
        '
        Me.btnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.Location = New System.Drawing.Point(207, 128)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(189, 49)
        Me.btnCourse.TabIndex = 2
        Me.btnCourse.Text = "btCourse"
        Me.btnCourse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(403, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(189, 49)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(386, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Welcome to Programming Lesson"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.btnCWCMessage)
        Me.Controls.Add(Me.IbIMessage)
        Me.Name = "frmMessage"
        Me.Text = "Change a Message"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IbIMessage As Label
    Friend WithEvents btnCWCMessage As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class
