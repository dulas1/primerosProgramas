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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.rbtn2 = New System.Windows.Forms.RadioButton()
        Me.rbtn1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.rbtn2)
        Me.GroupBox1.Controls.Add(Me.rbtn1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qué edad tienes?"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(7, 67)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Aceptar"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'rbtn2
        '
        Me.rbtn2.AutoSize = True
        Me.rbtn2.Location = New System.Drawing.Point(7, 44)
        Me.rbtn2.Name = "rbtn2"
        Me.rbtn2.Size = New System.Drawing.Size(86, 17)
        Me.rbtn2.TabIndex = 1
        Me.rbtn2.TabStop = True
        Me.rbtn2.Text = "menos de 18"
        Me.rbtn2.UseVisualStyleBackColor = True
        '
        'rbtn1
        '
        Me.rbtn1.AutoSize = True
        Me.rbtn1.Location = New System.Drawing.Point(7, 20)
        Me.rbtn1.Name = "rbtn1"
        Me.rbtn1.Size = New System.Drawing.Size(74, 17)
        Me.rbtn1.TabIndex = 0
        Me.rbtn1.TabStop = True
        Me.rbtn1.Text = "mas de 18"
        Me.rbtn1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(140, 132)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn1 As Button
    Friend WithEvents rbtn2 As RadioButton
    Friend WithEvents rbtn1 As RadioButton
End Class
