<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(104, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "帳號"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(104, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "密碼"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "登入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(484, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 55)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "離開"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(346, 82)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(100, 22)
        Me.txtusername.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(346, 170)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 22)
        Me.txtpassword.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 448)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "登入"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox

End Class
