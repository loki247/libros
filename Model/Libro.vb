Public Class Libro
    Dim idLibro As Integer
    Dim idTipoLibro As Integer
    Dim titulo As String
    Dim idAutor As Integer
    Dim isbn As String
    Dim idEditorial As Integer
    Dim tomo As Integer
    Dim anhoPublicacion As Integer

    Public Function setIdLibro(idLibroVal As Integer)
        idLibro = idLibroVal
    End Function

    Public Function getIdLibro()
        Return idLibro
    End Function

    Public Function setIdTipoLibro(idTipoLibroVal As Integer)
        idTipoLibro = idTipoLibroVal
    End Function

    Public Function getIdTipoLibro()
        Return idTipoLibro
    End Function

    Public Function setTitulo(tituloVal As String)
        titulo = tituloVal
    End Function

    Public Function getTitulo()
        Return titulo
    End Function

    Public Function setIdAutor(idAutorVal As Integer)
        idAutor = idAutorVal
    End Function

    Public Function getIdAutor()
        Return idAutor
    End Function

    Public Function setIsbn(isbnVal As String)
        isbn = isbnVal
    End Function

    Public Function getIsbn()
        Return isbn
    End Function

    Public Function setIdEditorial(idEditorialVal As Integer)
        idEditorial = idEditorialVal
    End Function

    Public Function getIdEditorial()
        Return idEditorial
    End Function

    Public Function setTomo(tomoVal As Integer)
        tomo = tomoVal
    End Function

    Public Function getTomo()
        Return tomo
    End Function

    Public Function setAnhoPublicacion(anhoPublicacionVal As Integer)
        anhoPublicacion = anhoPublicacionVal
    End Function

    Public Function getAnhoPublicacion()
        Return anhoPublicacion
    End Function
End Class
