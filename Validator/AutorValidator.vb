Public Class AutorValidator
    Public Function validarRegistrarAutor(autor As Autor)
        If (autor.getNomAutor() = "") Then
            Return False
        End If

        Return True
    End Function
End Class
