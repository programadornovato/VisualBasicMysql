Imports MySql.Data.MySqlClient
Public Class Form1
    Private myCon As MySqlConnection
    Private idSel As String
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

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim mensajeError = ""
        If txtInNombre.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar nombre " & vbLf
        End If
        If txtInPuesto.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar puesto" & vbLf
        End If
        If txtInEdad.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar edad" & vbLf
        End If
        If mensajeError = "" Then
            Dim query = "insert into trabajadores " &
                "(nombre                    ,puesto                    ,edad) values " &
                "('" & txtInNombre.Text & "','" & txtInPuesto.Text & "','" & txtInEdad.Text & "');"
            Dim comando = New MySqlCommand(query, myCon)
            Try
                Dim reader = comando.ExecuteReader()
                reader.Close()
                dgTrabajadores.Rows.Clear()
                dgTrabajadores.Refresh()
                llenarTabla()
            Catch ex As Exception
                lblResultado.Text = ex.ToString
            End Try
        Else
            MessageBox.Show(mensajeError)
        End If
        txtInNombre.Text = ""
        txtInPuesto.Text = ""
        txtInEdad.Text = ""
    End Sub

    Private Sub dgTrabajadores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgTrabajadores.CellClick
        Dim sel = e.RowIndex
        txtInNombre.Text = dgTrabajadores.Rows(sel).Cells(1).Value.ToString
        txtInPuesto.Text = dgTrabajadores.Rows(sel).Cells(2).Value.ToString
        txtInEdad.Text = dgTrabajadores.Rows(sel).Cells(3).Value.ToString
        idSel = dgTrabajadores.Rows(sel).Cells(0).Value.ToString
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim mensajeError = ""
        If txtInNombre.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar nombre " & vbLf
        End If
        If txtInPuesto.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar puesto" & vbLf
        End If
        If txtInEdad.Text = "" Then
            mensajeError = mensajeError & "Falta ingresar edad" & vbLf
        End If
        If mensajeError = "" Then
            Dim query = "update trabajadores set " &
                " nombre='" & txtInNombre.Text & "',  " &
                " puesto='" & txtInPuesto.Text & "',  " &
                " edad='" & txtInEdad.Text & "'  " &
                " where id='" & idSel & "'; "
            Dim comando = New MySqlCommand(query, myCon)
            Try
                Dim reader = comando.ExecuteReader()
                reader.Close()
                dgTrabajadores.Rows.Clear()
                dgTrabajadores.Refresh()
                llenarTabla()
            Catch ex As Exception
                lblResultado.Text = ex.ToString
            End Try
        Else
            MessageBox.Show(mensajeError)
        End If
        txtInNombre.Text = ""
        txtInPuesto.Text = ""
        txtInEdad.Text = ""

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        borrar(idSel)
    End Sub
    Sub borrar(id As Integer)
        Dim query = " delete from trabajadores where id='" & id & "'; "
        Dim comando = New MySqlCommand(query, myCon)
        Try
            Dim reader = comando.ExecuteReader()
            reader.Close()
            dgTrabajadores.Rows.Clear()
            dgTrabajadores.Refresh()
            llenarTabla()
        Catch ex As Exception
            lblResultado.Text = ex.ToString
        End Try
        txtInNombre.Text = ""
        txtInPuesto.Text = ""
        txtInEdad.Text = ""
    End Sub
    Private Sub dgTrabajadores_MouseClick(sender As Object, e As MouseEventArgs) Handles dgTrabajadores.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim menu = New System.Windows.Forms.ContextMenuStrip()
            Dim posicion = dgTrabajadores.HitTest(e.X, e.Y).RowIndex
            If posicion > -1 Then
                menu.Items.Add("Borrar").Name = "Borrar" & posicion
                menu.Items.Add("Mostrar").Name = "Mostrar" & posicion
            End If
            menu.Show(dgTrabajadores, e.X, e.Y)
            AddHandler menu.ItemClicked, AddressOf menuClick
        End If
    End Sub

    Private Sub menuClick(sender As Object, e As ToolStripItemClickedEventArgs)
        Dim nombre = e.ClickedItem.Name.ToString
        If nombre.Contains("Borrar") Then
            Dim posicion = nombre.Replace("Borrar", "")
            Dim id = dgTrabajadores.Rows(posicion).Cells(0).Value.ToString
            borrar(id)
        End If
        If nombre.Contains("Mostrar") Then
            Dim posicion = nombre.Replace("Mostrar", "")
            'Dim id = dgTrabajadores.Rows(posicion).Cells(0).Value.ToString
            'borrar(id)
            Dim res = "Id=" & dgTrabajadores.Rows(posicion).Cells(0).Value.ToString & vbLf
            res = res & "Nombre=" & dgTrabajadores.Rows(posicion).Cells(1).Value.ToString & vbLf
            res = res & "Puesto=" & dgTrabajadores.Rows(posicion).Cells(2).Value.ToString & vbLf
            res = res & "Edad=" & dgTrabajadores.Rows(posicion).Cells(3).Value.ToString & vbLf
            MessageBox.Show(res)
        End If
    End Sub
End Class
