Public Class LibroValidator
    Public Function validarRegistrarLibro(libro As Libro)
        If (libro.getIdTipoLibro() = 0) Then
            Return False
        End If

        If (libro.getTitulo() = "") Then
            Console.WriteLine(libro.getTitulo())
            Return False
        End If

        Return True
    End Function
End Class
