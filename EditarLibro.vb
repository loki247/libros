Public Class EditarLibro
    Public idLibro As Integer
    Private Sub EditarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        tipoLibroCombo.DisplayMember = "desc_tipo_libro"

        Dim libroService As LibroService = New LibroService()
        Dim libro = libroService.getLibro(idLibro)

        tipoLibroCombo.SelectedValue = libro.Tables(0).Rows(0)("id_tipo_libro").ToString()
        tituloText.Text = libro.Tables(0).Rows(0)("titulo").ToString()

        If String.IsNullOrEmpty(libro.Tables(0).Rows(0)("tomo").ToString()) Or libro.Tables(0).Rows(0)("tomo").ToString() = "0" Then
            tomoText.Text = ""
        Else
            tomoText.Text = libro.Tables(0).Rows(0)("tomo").ToString()
        End If

        autorCombo.SelectedValue = libro.Tables(0).Rows(0)("id_autor").ToString()
        isbnText.Text = libro.Tables(0).Rows(0)("isbn").ToString()
        editorialCombo.SelectedValue = libro.Tables(0).Rows(0)("id_editorial").ToString()

        If String.IsNullOrEmpty(libro.Tables(0).Rows(0)("anho_publicacion").ToString()) Or libro.Tables(0).Rows(0)("anho_publicacion").ToString() = "0" Then
            anhoPublicacionText.Text = ""
        Else
            anhoPublicacionText.Text = libro.Tables(0).Rows(0)("anho_publicacion").ToString()
        End If
    End Sub

    Private Sub EditarLibro_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Inicio.Refresh()
        Inicio.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim libro As New Libro()
        libro.setIdLibro(idLibro)
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

        If (LibroValidator.validarRegistrarLibro(libro) = True) Then
            If libroService.EditarLibro(libro) = 1 Then
                MsgBox("Libro Editado")
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