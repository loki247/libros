Imports System.Data.Odbc
Imports prueba.Conector

Public Class EditorialService
    Dim conn = New Conector()

    Public Function getEditoriales()
        Dim conexion As OdbcConnection = conn.conectarBD()
        conexion.Open()
        Dim query As String = "SELECT id_editorial, nom_editorial FROM libros.editorial"
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
End Class
