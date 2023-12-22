Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tipoLibro As TipoLibroService = New TipoLibroService()

        Console.WriteLine(tipoLibro.getTiposLibro.FieldCount)

        'For i As Integer = 0 To tipoLibro.getTiposLibro.FieldCount
        ComboBox1.Items.Add(tipoLibro.getTiposLibro.getString(0))
        'Next
    End Sub
End Class