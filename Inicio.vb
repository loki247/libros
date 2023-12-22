Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tipoLibro As TipoLibroService = New TipoLibroService()

        ComboBox1.DataSource = tipoLibro.getTiposLibro.Tables(0)
        ComboBox1.ValueMember = "id_tipo_libro"
        ComboBox1.DisplayMember = "desc_tipo_libro"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Console.WriteLine(ComboBox1.SelectedValue)
    End Sub
End Class