Imports System.Data.Odbc

Public Class AutorService
    Dim conn = New Conector()

    Public Function getAutores()
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()
        Dim query As String = "SELECT id_autor, nom_autor FROM libros.autor"
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

    Public Function registrarAutor(autor As Autor)
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()

        Dim insertQuery As String = "INSERT INTO libros.autor (nom_autor) VALUES ('" & autor.getNomAutor() & "')"


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
