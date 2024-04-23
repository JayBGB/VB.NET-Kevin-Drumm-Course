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
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.txtN3 = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Location = New System.Drawing.Point(295, 92)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(68, 13)
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "Number one:"
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Location = New System.Drawing.Point(295, 172)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(67, 13)
        Me.lblN2.TabIndex = 1
        Me.lblN2.Text = "Number two:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(317, 248)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(45, 13)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "My age:"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(369, 89)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(137, 20)
        Me.txtN1.TabIndex = 3
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(369, 169)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(137, 20)
        Me.txtN2.TabIndex = 4
        '
        'txtN3
        '
        Me.txtN3.Location = New System.Drawing.Point(369, 245)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(137, 20)
        Me.txtN3.TabIndex = 5
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(266, 349)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(268, 30)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtN3)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.lblN1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblN1 As Label
    Friend WithEvents lblN2 As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents txtN3 As TextBox
    Friend WithEvents btnAccept As Button
End Class
