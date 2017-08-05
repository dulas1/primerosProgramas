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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(24, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(160, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Agregar Numeros"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(24, 41)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(160, 23)
        Me.btn2.TabIndex = 2
        Me.btn2.Text = "Mostrar"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.Location = New System.Drawing.Point(13, 97)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(182, 82)
        Me.lb1.TabIndex = 3
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(24, 71)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(160, 23)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Ordenar"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 197)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lb1 As ListBox
    Friend WithEvents btn3 As Button
End Class
