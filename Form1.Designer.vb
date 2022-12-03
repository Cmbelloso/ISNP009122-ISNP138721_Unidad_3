<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDui = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDirección = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(26, 62)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(273, 38)
        Me.TxtCodigo.TabIndex = 0
        '
        'BtnGenerar
        '
        Me.BtnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGenerar.Location = New System.Drawing.Point(411, 58)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(308, 42)
        Me.BtnGenerar.TabIndex = 1
        Me.BtnGenerar.Text = "Generar Codigo"
        Me.BtnGenerar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAgregar.Location = New System.Drawing.Point(1046, 112)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(308, 42)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar Alumno"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
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
        Me.GroupBox2.Size = New System.Drawing.Size(1409, 637)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Alumno"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(226, 75)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(267, 38)
        Me.TxtNombre.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(681, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DUI"
        '
        'TxtDui
        '
        Me.TxtDui.Location = New System.Drawing.Point(847, 78)
        Me.TxtDui.Name = "TxtDui"
        Me.TxtDui.Size = New System.Drawing.Size(267, 38)
        Me.TxtDui.TabIndex = 2
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
        Me.TxtDirección.Size = New System.Drawing.Size(641, 38)
        Me.TxtDirección.TabIndex = 4
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(681, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 32)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Correo"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(847, 149)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(267, 38)
        Me.TxtCorreo.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(681, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 32)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Edad"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(847, 221)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(139, 38)
        Me.TxtEdad.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 375)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 102
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.Size = New System.Drawing.Size(1308, 261)
        Me.DataGridView1.TabIndex = 14
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1467, 884)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
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
End Class
