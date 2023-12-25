Imports System.Data.Odbc
Imports prueba.Conector

Public Class LibroService
    Dim conn = New Conector()

    Public Function getLibros()
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()
        Dim query As String = "SELECT libro.id_libro, tipo_libro.desc_tipo_libro, libro.titulo, libro.tomo, autor.nom_autor, libro.isbn , editorial.nom_editorial
                            FROM libros.libro 
                            LEFT JOIN libros.tipo_libro ON libro.id_tipo_libro = tipo_libro.id_tipo_libro
                            LEFT JOIN libros.autor ON libro.id_autor = autor.id_autor
                            LEFT JOIN libros.editorial ON libro.id_editorial= editorial.id_editorial
                            ORDER BY libro.titulo ASC, libro.tomo ASC"
        Dim command As OdbcCommand = New OdbcCommand(query, conexion)
        Dim adapter As New OdbcDataAdapter()
        Dim dataSet As New DataSet()

        adapter.SelectCommand = command
        adapter.Fill(dataSet)
        adapter.Dispose()
        command.Dispose()

        conexion.Close()

        Return dataSet
    End Function

    Public Function getLibro(idLibro As Integer)
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()
        Dim query As String = "SELECT id_tipo_libro, titulo, tomo, id_autor, isbn, id_editorial, anho_publicacion FROM libros.libro WHERE id_libro = " & idLibro
        Dim command As OdbcCommand = New OdbcCommand(query, conexion)
        Dim adapter As New OdbcDataAdapter()
        Dim dataSet As New DataSet()

        adapter.SelectCommand = command
        adapter.Fill(dataSet)
        adapter.Dispose()
        command.Dispose()

        conexion.Close()

        Return dataSet
    End Function

    Public Function registrarLibro(libro As Libro)
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()

        Dim insertQuery As String = "INSERT INTO libros.libro (id_tipo_libro, titulo, id_autor, isbn, id_editorial, tomo, anho_publicacion) 
                                values (" & libro.getIdTipoLibro() & ", 
                                        '" & libro.getTitulo() & "',
                                        '" & libro.getIdAutor() & "',
                                        '" & libro.getIsbn() & "',
                                        '" & libro.getIdEditorial() & "',
                                        " & libro.getTomo() & ",
                                        " & libro.getAnhoPublicacion() & ")"


        Dim command As OdbcCommand = New OdbcCommand(insertQuery, conexion)

        If command.ExecuteNonQuery() Then
            conexion.Close()
            Return 1
        Else
            conexion.Close()
            Return 0
        End If
    End Function

    Public Function EditarLibro(libro As Libro)
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()

        Dim insertQuery As String = "UPDATE libros.libro SET 
                                        id_tipo_libro = " & libro.getIdTipoLibro() & ", 
                                        titulo = '" & libro.getTitulo() & "',
                                        id_autor = '" & libro.getIdAutor() & "',
                                        isbn = '" & libro.getIsbn() & "',
                                        id_editorial = '" & libro.getIdEditorial() & "',
                                        tomo = " & libro.getTomo() & ",
                                        anho_publicacion = " & libro.getAnhoPublicacion() & "
                                    WHERE id_libro = " & libro.getIdLibro()


        Dim command As OdbcCommand = New OdbcCommand(insertQuery, conexion)

        If command.ExecuteNonQuery() Then
            conexion.Close()
            Return 1
        Else
            conexion.Close()
            Return 0
        End If
    End Function
End Class
