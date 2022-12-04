<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datosAlumnos = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDirección = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDui = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datosAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnGenerar)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 157)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Codigo"
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGenerar.Location = New System.Drawing.Point(411, 51)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(317, 49)
        Me.BtnGenerar.TabIndex = 1
        Me.BtnGenerar.Text = "Generar Codigo"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(26, 62)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(273, 38)
        Me.TxtCodigo.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAgregar.Location = New System.Drawing.Point(1045, 101)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(309, 53)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar Alumno"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.datosAlumnos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtEdad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtApellido)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtGenero)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDirección)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtDui)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(2058, 932)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Alumno"
        '
        'datosAlumnos
        '
        Me.datosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.datosAlumnos.Location = New System.Drawing.Point(-34, 391)
        Me.datosAlumnos.Name = "datosAlumnos"
        Me.datosAlumnos.RowHeadersWidth = 102
        Me.datosAlumnos.RowTemplate.Height = 40
        Me.datosAlumnos.Size = New System.Drawing.Size(1355, 398)
        Me.datosAlumnos.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(875, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Edad"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(1041, 221)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(139, 38)
        Me.TxtEdad.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(875, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(1041, 149)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(267, 38)
        Me.TxtCorreo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Apellido"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(226, 148)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(267, 38)
        Me.TxtApellido.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Genero"
        '
        'TxtGenero
        '
        Me.TxtGenero.Location = New System.Drawing.Point(227, 221)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(133, 38)
        Me.TxtGenero.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección"
        '
        'TxtDirección
        '
        Me.TxtDirección.Location = New System.Drawing.Point(227, 297)
        Me.TxtDirección.Name = "TxtDirección"
        Me.TxtDirección.Size = New System.Drawing.Size(1037, 38)
        Me.TxtDirección.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(875, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DUI"
        '
        'TxtDui
        '
        Me.TxtDui.Location = New System.Drawing.Point(1041, 78)
        Me.TxtDui.Name = "TxtDui"
        Me.TxtDui.Size = New System.Drawing.Size(267, 38)
        Me.TxtDui.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(226, 75)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(267, 38)
        Me.TxtNombre.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Location = New System.Drawing.Point(448, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(559, 50)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = " INGRESO DE DATOS ESTUDIANTES"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Codigo"
        Me.Column8.MinimumWidth = 12
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 250
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 12
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.MinimumWidth = 12
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Genero"
        Me.Column3.MinimumWidth = 12
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.MinimumWidth = 12
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "DUI"
        Me.Column5.MinimumWidth = 12
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 250
        '
        'Column6
        '
        Me.Column6.HeaderText = "Correo"
        Me.Column6.MinimumWidth = 12
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 250
        '
        'Column7
        '
        Me.Column7.HeaderText = "Edad"
        Me.Column7.MinimumWidth = 12
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1446, 1096)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Registro de Alumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datosAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents datosAlumnos As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDirección As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDui As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
