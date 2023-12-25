<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarLibro
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tituloText = New System.Windows.Forms.TextBox()
        Me.tomoText = New System.Windows.Forms.TextBox()
        Me.isbnText = New System.Windows.Forms.TextBox()
        Me.anhoPublicacionText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tipoLibroCombo = New System.Windows.Forms.ComboBox()
        Me.autorCombo = New System.Windows.Forms.ComboBox()
        Me.editorialCombo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Autor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tomo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de Libro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ISBN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Editorial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Año Publicación"
        '
        'tituloText
        '
        Me.tituloText.Location = New System.Drawing.Point(102, 59)
        Me.tituloText.Name = "tituloText"
        Me.tituloText.Size = New System.Drawing.Size(320, 20)
        Me.tituloText.TabIndex = 8
        '
        'tomoText
        '
        Me.tomoText.Location = New System.Drawing.Point(102, 92)
        Me.tomoText.Name = "tomoText"
        Me.tomoText.Size = New System.Drawing.Size(320, 20)
        Me.tomoText.TabIndex = 9
        '
        'isbnText
        '
        Me.isbnText.Location = New System.Drawing.Point(102, 180)
        Me.isbnText.Name = "isbnText"
        Me.isbnText.Size = New System.Drawing.Size(320, 20)
        Me.isbnText.TabIndex = 11
        '
        'anhoPublicacionText
        '
        Me.anhoPublicacionText.Location = New System.Drawing.Point(102, 268)
        Me.anhoPublicacionText.Name = "anhoPublicacionText"
        Me.anhoPublicacionText.Size = New System.Drawing.Size(320, 20)
        Me.anhoPublicacionText.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Guardar Cambios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tipoLibroCombo
        '
        Me.tipoLibroCombo.FormattingEnabled = True
        Me.tipoLibroCombo.Location = New System.Drawing.Point(102, 16)
        Me.tipoLibroCombo.Name = "tipoLibroCombo"
        Me.tipoLibroCombo.Size = New System.Drawing.Size(161, 21)
        Me.tipoLibroCombo.TabIndex = 15
        '
        'autorCombo
        '
        Me.autorCombo.FormattingEnabled = True
        Me.autorCombo.Location = New System.Drawing.Point(102, 142)
        Me.autorCombo.Name = "autorCombo"
        Me.autorCombo.Size = New System.Drawing.Size(161, 21)
        Me.autorCombo.TabIndex = 16
        '
        'editorialCombo
        '
        Me.editorialCombo.FormattingEnabled = True
        Me.editorialCombo.Location = New System.Drawing.Point(102, 219)
        Me.editorialCombo.Name = "editorialCombo"
        Me.editorialCombo.Size = New System.Drawing.Size(161, 21)
        Me.editorialCombo.TabIndex = 17
        '
        'EditarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.editorialCombo)
        Me.Controls.Add(Me.autorCombo)
        Me.Controls.Add(Me.tipoLibroCombo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.anhoPublicacionText)
        Me.Controls.Add(Me.isbnText)
        Me.Controls.Add(Me.tomoText)
        Me.Controls.Add(Me.tituloText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditarLibro"
        Me.Text = "Editar Libro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tituloText As TextBox
    Friend WithEvents tomoText As TextBox
    Friend WithEvents isbnText As TextBox
    Friend WithEvents anhoPublicacionText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tipoLibroCombo As ComboBox
    Friend WithEvents autorCombo As ComboBox
    Friend WithEvents editorialCombo As ComboBox
End Class
