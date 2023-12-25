Public Class RegistrarLibro
    Private Sub RegistrarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.MinimizeBox = False
        MyBase.MaximizeBox = False
        MyBase.Width = 450
        MyBase.Height = 400

        Dim tipoLibroService As TipoLibroService = New TipoLibroService()
        tipoLibroCombo.DataSource = tipoLibroService.getTiposLibro.Tables(0)
        tipoLibroCombo.ValueMember = "id_tipo_libro"
        tipoLibroCombo.DisplayMember = "desc_tipo_libro"

        Dim editorialService As EditorialService = New EditorialService()
        editorialCombo.DataSource = editorialService.getEditoriales.Tables(0)
        editorialCombo.ValueMember = "id_editorial"
        editorialCombo.DisplayMember = "nom_editorial"

        Dim autorService As AutorService = New AutorService()
        autorCombo.DataSource = autorService.getAutores.Tables(0)
        autorCombo.ValueMember = "id_autor"
        autorCombo.DisplayMember = "nom_autor"

        tituloText.Text = ""
        tomoText.Text = ""
        isbnText.Text = ""
        anhoPublicacionText.Text = ""
    End Sub

    Private Sub RegistrarLibro_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Inicio.Refresh()
        Inicio.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim libro As New Libro()
        libro.setIdTipoLibro(tipoLibroCombo.SelectedValue)
        libro.setTitulo(tituloText.Text)

        If tomoText.Text <> "" Then
            libro.setTomo(Convert.ToInt32(tomoText.Text))
        Else
            libro.setTomo(Nothing)
        End If

        libro.setIdAutor(autorCombo.SelectedValue)
        libro.setIsbn(isbnText.Text)
        libro.setIdEditorial(editorialCombo.SelectedValue)

        If anhoPublicacionText.Text <> "" Then
            libro.setAnhoPublicacion(Convert.ToInt32(anhoPublicacionText.Text))
        Else
            libro.setAnhoPublicacion(Nothing)
        End If

        Dim libroService As New LibroService()
        Dim libroValidator As New LibroValidator()

        If (libroValidator.validarRegistrarLibro(libro) = True) Then
            If libroService.registrarLibro(libro) = 1 Then
                MsgBox("Libro Registrado")

                tituloText.Text = ""
                tomoText.Text = ""
                isbnText.Text = ""
                anhoPublicacionText.Text = ""

                MyBase.Hide()
                Inicio.Refresh()
                Inicio.Show()
            Else
                MsgBox("Error")
            End If
        Else
            MsgBox("Faltan Datos")
        End If
    End Sub
End Class