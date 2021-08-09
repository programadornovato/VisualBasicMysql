<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.dgTrabajadores = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusNombre = New System.Windows.Forms.TextBox()
        Me.txtBusPuesto = New System.Windows.Forms.TextBox()
        Me.txtBusEdad = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInNombre = New System.Windows.Forms.TextBox()
        Me.txtInPuesto = New System.Windows.Forms.TextBox()
        Me.txtInEdad = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(32, 664)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(333, 32)
        Me.lblResultado.TabIndex = 1
        Me.lblResultado.Text = "Conexion a la base de datos"
        '
        'dgTrabajadores
        '
        Me.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombre, Me.colPuesto, Me.colEdad})
        Me.dgTrabajadores.Location = New System.Drawing.Point(32, 416)
        Me.dgTrabajadores.Name = "dgTrabajadores"
        Me.dgTrabajadores.RowTemplate.Height = 25
        Me.dgTrabajadores.Size = New System.Drawing.Size(556, 245)
        Me.dgTrabajadores.TabIndex = 2
        '
        'colId
        '
        Me.colId.HeaderText = "id"
        Me.colId.Name = "colId"
        Me.colId.Visible = False
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Width = 200
        '
        'colPuesto
        '
        Me.colPuesto.HeaderText = "Puesto"
        Me.colPuesto.Name = "colPuesto"
        Me.colPuesto.Width = 200
        '
        'colEdad
        '
        Me.colEdad.HeaderText = "Edad"
        Me.colEdad.Name = "colEdad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Puesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(436, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'txtBusNombre
        '
        Me.txtBusNombre.Location = New System.Drawing.Point(32, 359)
        Me.txtBusNombre.Name = "txtBusNombre"
        Me.txtBusNombre.Size = New System.Drawing.Size(152, 39)
        Me.txtBusNombre.TabIndex = 5
        '
        'txtBusPuesto
        '
        Me.txtBusPuesto.Location = New System.Drawing.Point(231, 359)
        Me.txtBusPuesto.Name = "txtBusPuesto"
        Me.txtBusPuesto.Size = New System.Drawing.Size(152, 39)
        Me.txtBusPuesto.TabIndex = 5
        '
        'txtBusEdad
        '
        Me.txtBusEdad.Location = New System.Drawing.Point(436, 359)
        Me.txtBusEdad.Name = "txtBusEdad"
        Me.txtBusEdad.Size = New System.Drawing.Size(152, 39)
        Me.txtBusEdad.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(650, 359)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 39)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Puesto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 32)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Edad"
        '
        'txtInNombre
        '
        Me.txtInNombre.Location = New System.Drawing.Point(171, 22)
        Me.txtInNombre.Name = "txtInNombre"
        Me.txtInNombre.Size = New System.Drawing.Size(417, 39)
        Me.txtInNombre.TabIndex = 0
        '
        'txtInPuesto
        '
        Me.txtInPuesto.Location = New System.Drawing.Point(171, 102)
        Me.txtInPuesto.Name = "txtInPuesto"
        Me.txtInPuesto.Size = New System.Drawing.Size(417, 39)
        Me.txtInPuesto.TabIndex = 1
        '
        'txtInEdad
        '
        Me.txtInEdad.Location = New System.Drawing.Point(171, 175)
        Me.txtInEdad.Name = "txtInEdad"
        Me.txtInEdad.Size = New System.Drawing.Size(417, 39)
        Me.txtInEdad.TabIndex = 2
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(436, 229)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(146, 46)
        Me.btnInsertar.TabIndex = 3
        Me.btnInsertar.Text = "Guardar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(242, 229)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(141, 46)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 752)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusEdad)
        Me.Controls.Add(Me.txtBusPuesto)
        Me.Controls.Add(Me.txtInEdad)
        Me.Controls.Add(Me.txtInPuesto)
        Me.Controls.Add(Me.txtInNombre)
        Me.Controls.Add(Me.txtBusNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgTrabajadores)
        Me.Controls.Add(Me.lblResultado)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResultado As Label
    Friend WithEvents dgTrabajadores As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colPuesto As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusNombre As TextBox
    Friend WithEvents txtBusPuesto As TextBox
    Friend WithEvents txtBusEdad As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInNombre As TextBox
    Friend WithEvents txtInPuesto As TextBox
    Friend WithEvents txtInEdad As TextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEditar As Button
End Class
