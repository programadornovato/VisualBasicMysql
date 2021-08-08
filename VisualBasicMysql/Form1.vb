Imports MySql.Data.MySqlClient
Public Class Form1
    Private myCon As MySqlConnection
    Private Sub llenarTabla()
        Try
            Dim server = "localhost"
            Dim usuario = "root"
            Dim pass = "123456"
            Dim db = "empleados"
            Dim cadena = "server=" & server & ";Uid=" & usuario & ";pwd=" & pass & ";database=" & db & ";SslMode=none;"
            myCon = New MySqlConnection(cadena)
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
                lblResultado.Text = "No hay trabajadores"
            End If
            reader.Close()
        Catch ex As Exception
            lblResultado.Text = "error de conexion " & ex.ToString
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarTabla()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim where = " where 1=1 "
        If txtBusNombre.Text <> "" Then
            where = where & " and nombre like '%" & txtBusNombre.Text & "%' "
        End If
        If txtBusPuesto.Text <> "" Then
            where = where & " and puesto like '%" & txtBusPuesto.Text & "%' "
        End If
        If txtBusEdad.Text <> "" Then
            where = where & " and edad='" & txtBusEdad.Text & "' "
        End If
        Try
            Dim query = "SELECT id, nombre, puesto, edad FROM trabajadores " & where
            Dim comando = New MySqlCommand(query, myCon)
            Dim reader = comando.ExecuteReader()
            dgTrabajadores.Rows.Clear()
            dgTrabajadores.Refresh()
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
            reader.Close()
        Catch ex As Exception
            lblResultado.Text = ex.ToString
        End Try


    End Sub
End Class
