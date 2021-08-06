Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            Dim server = "localhost"
            Dim usuario = "root"
            Dim pass = "123456"
            Dim db = "empleados"
            Dim cadena = "server=" & server & ";Uid=" & usuario & ";pwd=" & pass & ";database=" & db & ";SslMode=none;"
            Dim myCon = New MySqlConnection(cadena)
            myCon.Open()
            lblResultado.Text = "Conexion es exitosa"
        Catch ex As Exception
            lblResultado.Text = "error de conexion " & ex.ToString
        End Try

    End Sub
End Class
