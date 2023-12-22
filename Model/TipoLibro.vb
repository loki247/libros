Public Class TipoLibro
    Dim table As String = "libros.tipo_libro"

    Dim idTipoLibro As Integer
    Dim descTipoLibro As String

    Public Property idTipoLibroProp As Integer
        Get
            Return idTipoLibro
        End Get

        Set(ByVal value As Integer)
            idTipoLibro = value
        End Set
    End Property

    Public Property descTipoLibroProp As Integer
        Get
            Return descTipoLibro
        End Get

        Set(ByVal value As Integer)
            descTipoLibro = value
        End Set
    End Property
End Class
