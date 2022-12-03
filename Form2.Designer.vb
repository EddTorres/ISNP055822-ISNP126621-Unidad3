<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxColor = New System.Windows.Forms.ComboBox()
        Me.txtCombustible = New System.Windows.Forms.TextBox()
        Me.lblCombustible = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datosAlumno = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        CType(Me.datosAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column7
        '
        Me.Column7.HeaderText = "Color"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'cbxColor
        '
        Me.cbxColor.FormattingEnabled = True
        Me.cbxColor.Items.AddRange(New Object() {"Azul", "Rojo", "Verde", "Oro", "Negro", "Naranja"})
        Me.cbxColor.Location = New System.Drawing.Point(197, 214)
        Me.cbxColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxColor.Name = "cbxColor"
        Me.cbxColor.Size = New System.Drawing.Size(136, 24)
        Me.cbxColor.TabIndex = 15
        '
        'txtCombustible
        '
        Me.txtCombustible.Location = New System.Drawing.Point(197, 166)
        Me.txtCombustible.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCombustible.Name = "txtCombustible"
        Me.txtCombustible.Size = New System.Drawing.Size(335, 22)
        Me.txtCombustible.TabIndex = 14
        '
        'lblCombustible
        '
        Me.lblCombustible.AutoSize = True
        Me.lblCombustible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombustible.Location = New System.Drawing.Point(48, 171)
        Me.lblCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(115, 22)
        Me.lblCombustible.TabIndex = 13
        Me.lblCombustible.Text = "Combustible"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(197, 119)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(72, 22)
        Me.txtAño.TabIndex = 12
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(48, 124)
        Me.lblAño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(43, 22)
        Me.lblAño.TabIndex = 11
        Me.lblAño.Text = "Año"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(48, 218)
        Me.lblColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(56, 22)
        Me.lblColor.TabIndex = 8
        Me.lblColor.Text = "Color"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(48, 91)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(71, 22)
        Me.lblModelo.TabIndex = 6
        Me.lblModelo.Text = "Modelo"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Año"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Modelo"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Marca"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'datosAlumno
        '
        Me.datosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosAlumno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column7})
        Me.datosAlumno.Location = New System.Drawing.Point(111, 438)
        Me.datosAlumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datosAlumno.Name = "datosAlumno"
        Me.datosAlumno.RowHeadersWidth = 51
        Me.datosAlumno.RowTemplate.Height = 24
        Me.datosAlumno.Size = New System.Drawing.Size(893, 150)
        Me.datosAlumno.TabIndex = 4
        '
        'Column6
        '
        Me.Column6.HeaderText = "Combustible"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(48, 44)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(63, 22)
        Me.lblMarca.TabIndex = 5
        Me.lblMarca.Text = "Marca"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(251, 319)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 37)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(197, 86)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(335, 22)
        Me.txtModelo.TabIndex = 1
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(197, 39)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(335, 22)
        Me.txtMarca.TabIndex = 0
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.cbxColor)
        Me.grpDatos.Controls.Add(Me.txtCombustible)
        Me.grpDatos.Controls.Add(Me.lblCombustible)
        Me.grpDatos.Controls.Add(Me.txtAño)
        Me.grpDatos.Controls.Add(Me.lblAño)
        Me.grpDatos.Controls.Add(Me.lblColor)
        Me.grpDatos.Controls.Add(Me.lblModelo)
        Me.grpDatos.Controls.Add(Me.lblMarca)
        Me.grpDatos.Controls.Add(Me.btnAgregar)
        Me.grpDatos.Controls.Add(Me.txtModelo)
        Me.grpDatos.Controls.Add(Me.txtMarca)
        Me.grpDatos.Location = New System.Drawing.Point(111, 37)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(624, 380)
        Me.grpDatos.TabIndex = 3
        Me.grpDatos.TabStop = False
        Me.grpDatos.Text = "Datos de autos"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 729)
        Me.Controls.Add(Me.datosAlumno)
        Me.Controls.Add(Me.grpDatos)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.datosAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents cbxColor As ComboBox
    Friend WithEvents txtCombustible As TextBox
    Friend WithEvents lblCombustible As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents lblAño As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents datosAlumno As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents lblMarca As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents grpDatos As GroupBox
End Class
