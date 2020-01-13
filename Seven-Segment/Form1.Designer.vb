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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.monitor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button A"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(308, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 150)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button B"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(308, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 150)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button C"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(152, 341)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 50)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button D"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(96, 241)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 150)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button E"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(96, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 150)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button F"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(152, 205)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(150, 50)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Button G"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'monitor
        '
        Me.monitor.AutoSize = True
        Me.monitor.Font = New System.Drawing.Font("Bahnschrift SemiLight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitor.Location = New System.Drawing.Point(382, 9)
        Me.monitor.Name = "monitor"
        Me.monitor.Size = New System.Drawing.Size(42, 48)
        Me.monitor.TabIndex = 7
        Me.monitor.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 493)
        Me.Controls.Add(Me.monitor)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Seven Segment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents monitor As Label
End Class
