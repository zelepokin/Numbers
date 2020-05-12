<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B1 = New System.Windows.Forms.Button()
        Me.LB1 = New System.Windows.Forms.Label()
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.LB2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(37, 59)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(139, 51)
        Me.B1.TabIndex = 0
        Me.B1.Text = "Выполнить"
        Me.B1.UseVisualStyleBackColor = True
        '
        'LB1
        '
        Me.LB1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB1.Location = New System.Drawing.Point(47, 161)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(105, 28)
        Me.LB1.TabIndex = 1
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(275, 75)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(162, 20)
        Me.TB1.TabIndex = 2
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(469, 75)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(189, 20)
        Me.TB2.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 450)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'LB2
        '
        Me.LB2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LB2.Location = New System.Drawing.Point(300, 161)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(105, 28)
        Me.LB2.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.LB2)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents LB1 As Label
    Friend WithEvents TB1 As TextBox
    Friend WithEvents TB2 As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents LB2 As Label
End Class
