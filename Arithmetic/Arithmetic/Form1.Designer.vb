<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(186, 69)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(225, 22)
        Me.txtNumber1.TabIndex = 0
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(186, 113)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(225, 22)
        Me.txtNumber2.TabIndex = 1
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(106, 69)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(74, 17)
        Me.lblNumber1.TabIndex = 2
        Me.lblNumber1.Text = "Number 1:"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Location = New System.Drawing.Point(106, 116)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(74, 17)
        Me.lblNumber2.TabIndex = 3
        Me.lblNumber2.Text = "Number 2:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(216, 153)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(161, 54)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 264)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents btnCalculate As Button
End Class
