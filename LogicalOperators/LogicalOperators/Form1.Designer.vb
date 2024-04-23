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
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGrade
        '
        Me.btnGrade.BackColor = System.Drawing.Color.LightSalmon
        Me.btnGrade.Location = New System.Drawing.Point(233, 174)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(338, 171)
        Me.btnGrade.TabIndex = 0
        Me.btnGrade.Text = "Get your grade!"
        Me.btnGrade.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(230, 105)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(188, 17)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Enter the examination score:"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(429, 105)
        Me.txtScore.MaxLength = 3
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(141, 22)
        Me.txtScore.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnGrade)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGrade As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents txtScore As TextBox
End Class
