Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports prueba.Conector

Public Class TipoLibroService
    Dim conn = New Conector()


    Public Function getTiposLibro()
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()

        Dim query As String = "SELECT id_tipo_libro, desc_tipo_libro FROM libros.tipo_libro"
        Dim command As OdbcCommand = New OdbcCommand(query, conexion)
        Dim reader As OdbcDataReader = command.ExecuteReader()
        reader.Read()

        Return reader
    End Function
End Class

