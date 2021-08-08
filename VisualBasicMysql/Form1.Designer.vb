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
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(30, 377)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(333, 32)
        Me.lblResultado.TabIndex = 1
        Me.lblResultado.Text = "Conexion a la base de datos"
        '
        'dgTrabajadores
        '
        Me.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombre, Me.colPuesto, Me.colEdad})
        Me.dgTrabajadores.Location = New System.Drawing.Point(30, 129)
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
        Me.Label1.Location = New System.Drawing.Point(30, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Puesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(434, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Edad"
        '
        'txtBusNombre
        '
        Me.txtBusNombre.Location = New System.Drawing.Point(30, 72)
        Me.txtBusNombre.Name = "txtBusNombre"
        Me.txtBusNombre.Size = New System.Drawing.Size(152, 39)
        Me.txtBusNombre.TabIndex = 5
        '
        'txtBusPuesto
        '
        Me.txtBusPuesto.Location = New System.Drawing.Point(229, 72)
        Me.txtBusPuesto.Name = "txtBusPuesto"
        Me.txtBusPuesto.Size = New System.Drawing.Size(152, 39)
        Me.txtBusPuesto.TabIndex = 5
        '
        'txtBusEdad
        '
        Me.txtBusEdad.Location = New System.Drawing.Point(434, 72)
        Me.txtBusEdad.Name = "txtBusEdad"
        Me.txtBusEdad.Size = New System.Drawing.Size(152, 39)
        Me.txtBusEdad.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(648, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 39)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusEdad)
        Me.Controls.Add(Me.txtBusPuesto)
        Me.Controls.Add(Me.txtBusNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
End Class
