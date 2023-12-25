Public Class Autor
    Dim idAutor As Integer
    Dim nomAutor As String

    Public Function setIdAutor(idAutorVal As Integer)
        idAutor = idAutorVal
    End Function

    Public Function getIdAutor()
        Return idAutor
    End Function

    Public Function setNomAutor(nomAutorVal As String)
        nomAutor = nomAutorVal
    End Function

    Public Function getNomAutor()
        Return nomAutor
    End Function
End Class
