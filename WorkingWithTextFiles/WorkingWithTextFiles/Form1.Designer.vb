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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnArrayToFile = New System.Windows.Forms.Button()
        Me.btnFiletoArray = New System.Windows.Forms.Button()
        Me.btnFiletoFile = New System.Windows.Forms.Button()
        Me.btn2DFuke = New System.Windows.Forms.Button()
        Me.btnFileto2D = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Write"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(12, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Read"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnArrayToFile
        '
        Me.btnArrayToFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnArrayToFile.Location = New System.Drawing.Point(117, 14)
        Me.btnArrayToFile.Name = "btnArrayToFile"
        Me.btnArrayToFile.Size = New System.Drawing.Size(99, 50)
        Me.btnArrayToFile.TabIndex = 2
        Me.btnArrayToFile.Text = "Array to File"
        Me.btnArrayToFile.UseVisualStyleBackColor = False
        '
        'btnFiletoArray
        '
        Me.btnFiletoArray.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFiletoArray.Location = New System.Drawing.Point(117, 70)
        Me.btnFiletoArray.Name = "btnFiletoArray"
        Me.btnFiletoArray.Size = New System.Drawing.Size(99, 50)
        Me.btnFiletoArray.TabIndex = 3
        Me.btnFiletoArray.Text = "File to Array"
        Me.btnFiletoArray.UseVisualStyleBackColor = False
        '
        'btnFiletoFile
        '
        Me.btnFiletoFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFiletoFile.Location = New System.Drawing.Point(222, 14)
        Me.btnFiletoFile.Name = "btnFiletoFile"
        Me.btnFiletoFile.Size = New System.Drawing.Size(99, 50)
        Me.btnFiletoFile.TabIndex = 4
        Me.btnFiletoFile.Text = "File to File"
        Me.btnFiletoFile.UseVisualStyleBackColor = False
        '
        'btn2DFuke
        '
        Me.btn2DFuke.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn2DFuke.Location = New System.Drawing.Point(222, 70)
        Me.btn2DFuke.Name = "btn2DFuke"
        Me.btn2DFuke.Size = New System.Drawing.Size(99, 50)
        Me.btn2DFuke.TabIndex = 5
        Me.btn2DFuke.Text = "2D to File"
        Me.btn2DFuke.UseVisualStyleBackColor = False
        '
        'btnFileto2D
        '
        Me.btnFileto2D.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFileto2D.Location = New System.Drawing.Point(222, 126)
        Me.btnFileto2D.Name = "btnFileto2D"
        Me.btnFileto2D.Size = New System.Drawing.Size(99, 50)
        Me.btnFileto2D.TabIndex = 6
        Me.btnFileto2D.Text = "File to 2D"
        Me.btnFileto2D.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(335, 189)
        Me.Controls.Add(Me.btnFileto2D)
        Me.Controls.Add(Me.btn2DFuke)
        Me.Controls.Add(Me.btnFiletoFile)
        Me.Controls.Add(Me.btnFiletoArray)
        Me.Controls.Add(Me.btnArrayToFile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnArrayToFile As Button
    Friend WithEvents btnFiletoArray As Button
    Friend WithEvents btnFiletoFile As Button
    Friend WithEvents btn2DFuke As Button
    Friend WithEvents btnFileto2D As Button
End Class
