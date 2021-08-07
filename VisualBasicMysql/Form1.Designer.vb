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
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.dgTrabajadores = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(63, 62)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(152, 44)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(63, 377)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(333, 32)
        Me.lblResultado.TabIndex = 1
        Me.lblResultado.Text = "Conexion a la base de datos"
        '
        'dgTrabajadores
        '
        Me.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombre, Me.colPuesto, Me.colEdad})
        Me.dgTrabajadores.Location = New System.Drawing.Point(63, 129)
        Me.dgTrabajadores.Name = "dgTrabajadores"
        Me.dgTrabajadores.RowTemplate.Height = 25
        Me.dgTrabajadores.Size = New System.Drawing.Size(385, 213)
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
        '
        'colPuesto
        '
        Me.colPuesto.HeaderText = "Puesto"
        Me.colPuesto.Name = "colPuesto"
        '
        'colEdad
        '
        Me.colEdad.HeaderText = "Edad"
        Me.colEdad.Name = "colEdad"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgTrabajadores)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnConectar)
        Me.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents dgTrabajadores As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colPuesto As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
End Class
