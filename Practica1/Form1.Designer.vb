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
        Me.CuadroTexto = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CuadroTexto
        '
        Me.CuadroTexto.Location = New System.Drawing.Point(12, 153)
        Me.CuadroTexto.Name = "CuadroTexto"
        Me.CuadroTexto.Size = New System.Drawing.Size(260, 96)
        Me.CuadroTexto.TabIndex = 0
        Me.CuadroTexto.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(41, 26)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(204, 102)
        Me.Imagen.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(347, 299)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CuadroTexto)
        Me.Name = "Form1"
        Me.Text = "Tamagotchi"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CuadroTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Imagen As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
