Public Class alumno

    'Declaración de propiedades'

    Private codigo As String
    Private nombre As String
    Private apellido As String
    Private genero As String
    Private dirección As String
    Private dui As String
    Private edad As String
    Private correo As String

    'Indica si los datos esta completo'
    Private datoscompletos As Boolean

    'metodos de codigo'

    Public Property codigoAlumno() As String

        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property
    'metodos de clase'

    Public Property nombreAlumno() As String

        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    'metodos de apellido'
    Public Property apellidoAlumno() As String

        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
    'metodos de genero'
    Public Property generoAlumno() As String

        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    'metodos de dirección'
    Public Property direcciónAlumno() As String

        Get
            Return dirección
        End Get
        Set(value As String)
            dirección = value
        End Set
    End Property

    'metodos de DUI'
    Public Property duiAlumno() As String

        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property
    'metodos de Edad'
    Public Property edadAlumno() As String

        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property
    'metodos de correo'
    Public Property correoAlumno() As String

        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datoscompletos
        End Get
    End Property

    'Constructor de la clase'

    Public Sub New()
        datoscompletos = False

    End Sub

    Public Sub datosAlumnos(ByVal codigoA As String,
                                ByVal nombreA As String,
                                ByVal apellidoA As String,
                                ByVal generoA As String,
                                ByVal direcciónA As String,
                                ByVal duiA As String,
                                ByVal edadA As String,
                                ByVal correoA As String)

        datoscompletos = False

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo")
        Else
            codigo = codigoA
        End If
        If nombreA.Length = 0 Then
            MsgBox("Debe ingresar nombre")
        Else
            nombre = nombreA
        End If
        If apellidoA.Length = 0 Then
            MsgBox("Debe ingresar apellido")
        Else
            apellido = apellidoA
        End If
        If generoA.Length = 0 Then
            MsgBox("Debe ingresar genero")
        Else
            genero = generoA
        End If
        If direcciónA.Length = 0 Then
            MsgBox("Debe ingresar dirreción")
        Else
            dirección = direcciónA
        End If
        If duiA.Length = 0 Then
            MsgBox("Debe ingresar DUI")
        Else
            dui = duiA
        End If
        If edadA.Length = 0 Then
            MsgBox("Debe ingresar edad")
        Else
            edad = edadA
        End If
        If correoA.Length = 0 Then
            MsgBox("Debe ingresar correo")
        Else
            correo = correoA
        End If

    End Sub

    Public Function generarCodigo(ByVal nombre As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2

    End Function

End Class
