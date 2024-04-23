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
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCountry.Location = New System.Drawing.Point(24, 26)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(252, 25)
        Me.lblCountry.TabIndex = 0
        Me.lblCountry.Text = "What country are you from?"
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(316, 88)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(209, 58)
        Me.btnGreet.TabIndex = 1
        Me.btnGreet.Text = "Greeting"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(316, 29)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(209, 22)
        Me.txtCountry.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.lblCountry)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountry As Label
    Friend WithEvents btnGreet As Button
    Friend WithEvents txtCountry As TextBox
End Class
