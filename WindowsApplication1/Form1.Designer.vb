<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(546, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 80)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "攝氏"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(546, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 71)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "華氏"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("新細明體", 60.0!)
        Me.txt1.Location = New System.Drawing.Point(155, 115)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(208, 103)
        Me.txt1.TabIndex = 3
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.lb1.Location = New System.Drawing.Point(415, 160)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(0, 27)
        Me.lb1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 576)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "溫度單位互轉"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents lb1 As System.Windows.Forms.Label

End Class
