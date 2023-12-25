Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getTiposLibro()
        getLibros()
    End Sub

    Private Sub Inicio_ReLoad(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        getTiposLibro()
        getLibros()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Function getTiposLibro()
        Dim tiposLibro As TipoLibroService = New TipoLibroService()

        ComboBox1.DataSource = tiposLibro.getTiposLibro.Tables(0)
        ComboBox1.ValueMember = "id_tipo_libro"
        ComboBox1.DisplayMember = "desc_tipo_libro"
    End Function

    Private Function getLibros()
        Dim libros As LibroService = New LibroService()

        DataGridView1.DataSource = libros.getLibros.Tables(0)

        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Id"
            .Columns(1).HeaderCell.Value = "Tipo"
            .Columns(2).HeaderCell.Value = "Título"
            .Columns(3).HeaderCell.Value = "Tomo"
            .Columns(4).HeaderCell.Value = "Editorial"
            .Columns(5).HeaderCell.Value = "Autor"
            .Columns(6).HeaderCell.Value = "ISBN"
        End With

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically

        DataGridView1.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Columns(0).Visible = False

        resultadosLabel.Text = "Se encontraron " & DataGridView1.RowCount & " resultados"
    End Function

    Private Sub RegistrarLibroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RegistrarLibroToolStripMenuItem1.Click
        RegistrarLibro.Show()
        MyBase.Hide()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim idLibro As Integer = DataGridView1.CurrentRow.Cells(0).Value

        Dim editarLibroForm As New EditarLibro() With {.idLibro = idLibro}
        editarLibroForm.Show()
        MyBase.Hide()
    End Sub

    Private Sub RegistrarAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAutorToolStripMenuItem.Click
        RegistrarAutor.Show()
        MyBase.Hide()
    End Sub
End Class