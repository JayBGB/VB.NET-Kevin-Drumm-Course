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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(37, 160)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(325, 68)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(120, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(242, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(34, 15)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(34, 56)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(80, 17)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(120, 55)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(242, 22)
        Me.txtLastName.TabIndex = 4
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(120, 98)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(242, 22)
        Me.txtGender.TabIndex = 5
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(34, 97)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(60, 17)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender:"
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 16
        Me.lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Tinker", "Tailor", "Soldier", "Sailor"})
        Me.lstOccupation.Location = New System.Drawing.Point(391, 32)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(240, 196)
        Me.lstOccupation.TabIndex = 7
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(388, 9)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(84, 17)
        Me.lblOccupation.TabIndex = 8
        Me.lblOccupation.Text = "Occupation:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 258)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
End Class
