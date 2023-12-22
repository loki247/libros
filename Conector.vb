Imports System.Data.Odbc

Public Class Conector
    Public Function conectarBD() As OdbcConnection
        Dim connectionString As String = "Dsn=LIBROS;database=libros;server=localhost;port=54358;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1;pwd=123asd"
        Dim conn As New OdbcConnection(connectionString)

        Return conn
    End Function
End Class
