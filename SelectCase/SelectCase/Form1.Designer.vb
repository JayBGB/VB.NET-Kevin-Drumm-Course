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
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.btnTemperature = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(111, 98)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(294, 22)
        Me.txtTemperature.TabIndex = 0
        '
        'btnTemperature
        '
        Me.btnTemperature.Location = New System.Drawing.Point(135, 141)
        Me.btnTemperature.Name = "btnTemperature"
        Me.btnTemperature.Size = New System.Drawing.Size(244, 81)
        Me.btnTemperature.TabIndex = 1
        Me.btnTemperature.Text = "Check temperature"
        Me.btnTemperature.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTemperature)
        Me.Controls.Add(Me.txtTemperature)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnTemperature As Button
End Class
