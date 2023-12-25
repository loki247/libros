Public Class TipoLibro
    Dim idTipoLibro As Integer
    Dim descTipoLibro As String

    Public Function setIdTipoLibro(idTipoLibroVal As Integer)
        idTipoLibro = idTipoLibroVal
    End Function

    Public Function getIdTipoLibro()
        Return idTipoLibro
    End Function

    Public Function setDescTipoLibro(descTipoLibroVal As String)
        descTipoLibro = descTipoLibroVal
    End Function

    Public Function getDescTipoLibro()
        Return descTipoLibro
    End Function
End Class
