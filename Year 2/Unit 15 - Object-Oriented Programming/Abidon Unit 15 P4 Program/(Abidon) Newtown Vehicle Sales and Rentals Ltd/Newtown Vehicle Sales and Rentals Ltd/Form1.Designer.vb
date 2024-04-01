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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBicycleHire = New System.Windows.Forms.Button()
        Me.btnCarHire = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Graphics = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTitle.Location = New System.Drawing.Point(238, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(622, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Newtown Vehicle Sales and Rentals Ltd"
        '
        'btnBicycleHire
        '
        Me.btnBicycleHire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBicycleHire.Location = New System.Drawing.Point(245, 323)
        Me.btnBicycleHire.Name = "btnBicycleHire"
        Me.btnBicycleHire.Size = New System.Drawing.Size(196, 85)
        Me.btnBicycleHire.TabIndex = 3
        Me.btnBicycleHire.Text = "Bicycle Hire Link"
        Me.btnBicycleHire.UseVisualStyleBackColor = True
        '
        'btnCarHire
        '
        Me.btnCarHire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCarHire.Location = New System.Drawing.Point(472, 323)
        Me.btnCarHire.Name = "btnCarHire"
        Me.btnCarHire.Size = New System.Drawing.Size(196, 85)
        Me.btnCarHire.TabIndex = 3
        Me.btnCarHire.Text = "Car Hire Link"
        Me.btnCarHire.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnHelp.Location = New System.Drawing.Point(12, 323)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(196, 85)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "NEED HELP?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnQuit.Location = New System.Drawing.Point(701, 323)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(196, 85)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit Program"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(357, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select One"
        '
        'Graphics
        '
        Me.Graphics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Graphics.Location = New System.Drawing.Point(12, 12)
        Me.Graphics.Name = "Graphics"
        Me.Graphics.Size = New System.Drawing.Size(220, 146)
        Me.Graphics.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 457)
        Me.Controls.Add(Me.Graphics)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCarHire)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBicycleHire)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.Text = "Newtown Vehicle Sales and Rentals Ltd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBicycleHire As Button
    Friend WithEvents btnCarHire As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Graphics As Panel
End Class
