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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(581, 350)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(205, 87)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnVariables
        '
        Me.btnVariables.Location = New System.Drawing.Point(370, 350)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(205, 86)
        Me.btnVariables.TabIndex = 1
        Me.btnVariables.Text = "Variable Demonstration"
        Me.btnVariables.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(159, 352)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(205, 86)
        Me.btnDataTypes.TabIndex = 2
        Me.btnDataTypes.Text = "Data Types"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btnDataTypes As Button
End Class
