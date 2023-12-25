Public Class RegistrarAutor
    Private Sub RegistrarAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombreAutorText.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim autor As New Autor()
        autor.setNomAutor(nombreAutorText.Text)

        Dim autorService As New AutorService()
        Dim autorValodator As New AutorValidator()

        If (autorValodator.validarRegistrarAutor(autor) = True) Then
            If autorService.registrarAutor(autor) = 1 Then
                MsgBox("Autor Registrado")

                nombreAutorText.Text = ""

                MyBase.Hide()
                Inicio.Refresh()
                Inicio.Show()
            Else
                MsgBox("Error")
            End If
        Else
            MsgBox("Faltan Datos")
        End If
    End Sub
End Class