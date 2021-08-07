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
            Dim query = "SELECT id, nombre, puesto, edad FROM trabajadores"
            Dim comando = New MySqlCommand(query, myCon)
            Dim reader = comando.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Dim n = dgTrabajadores.Rows.Add()
                    dgTrabajadores.Rows(n).Cells(0).Value = reader.GetString(0).ToString
                    dgTrabajadores.Rows(n).Cells(1).Value = reader.GetString(1).ToString
                    dgTrabajadores.Rows(n).Cells(2).Value = reader.GetString(2).ToString
                    dgTrabajadores.Rows(n).Cells(3).Value = reader.GetString(3).ToString
                End While
            Else
                Console.WriteLine("No hay trabajadores")
            End If
        Catch ex As Exception
            lblResultado.Text = "error de conexion " & ex.ToString
        End Try

    End Sub
End Class
