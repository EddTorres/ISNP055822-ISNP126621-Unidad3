Public Class Alumno
    'declaraciones de propiedades 
    Private Codigo As String
    Private Nombre As String
    Private Apellido As String
    Private Sexo As String
    Private Direccion As String
    Private Edad As Integer
    Private Correo As String
    Private ID As String


    'indica si los datos ingresados estan completos 
    Private datosCompletos As String

    'metodos para propiedades
    'Metodo para nombre alumno 
    Public Property NombreAlumno() As String
        Get
            Return Nombre

        End Get
        Set(value As String)
            Nombre = value

        End Set
    End Property
    'metodo para apellido de alumno
    Public Property ApellidoAlumno() As String
        Get
            Return Apellido

        End Get
        Set(value As String)
            Apellido = value

        End Set
    End Property
    'metodo para edad alumno
    Public Property EdadAlumno() As Integer
        Get
            Return Edad

        End Get
        Set(value As Integer)
            Edad = value

        End Set
    End Property
    'metodo para sexo de alumno
    Public Property SexoAlumno() As String
        Get
            Return Sexo

        End Get
        Set(value As String)
            Sexo = value

        End Set

    End Property
    Public Property IDAlumno() As String
        Get
            Return ID

        End Get
        Set(value As String)
            ID = value

        End Set
    End Property

    Public Property CorreoAlumno() As String
        Get
            Return Correo

        End Get
        Set(value As String)
            Correo = value

        End Set
    End Property
    'metodo direccion del alumno
    Public Property DireccionAlumno() As String
        Get
            Return Direccion

        End Get
        Set(value As String)
            Direccion = value

        End Set
    End Property
    Public ReadOnly Property datosAceptados() As Boolean
        Get
            Return datosCompletos

        End Get
    End Property

    'metodo
    'constructor de la clase 
    Public Sub New()
        datosCompletos = False
        'determina si los datos aun no han sido ingresados 
    End Sub
    'determina si los datos ingresados son correctos y asigma los atributo de la clase
    Public Sub datosAlumno(ByVal CodigoA As String, ByVal NombreA As String, ByVal ApellidoA As String, ByVal SexoA As String, ByVal DireccionA As String, ByVal EdadA As Integer, ByVal CorreoA As String, ByVal IDA As String)

        If CodigoA.Length = 0 Then
            MsgBox("Debe generar el codigo de Alumno")
            Exit Sub
        Else
            Codigo = CodigoA

        End If

        If NombreA.Length = 0 Then
            MsgBox("Debe escribir el nombre del alumno ")
            Exit Sub
        Else
            Nombre = NombreA

        End If
        If ApellidoA.Length = 0 Then
            MsgBox("Debe Escribir el apellido del alumno")
            Exit Sub
        Else
            Apellido = ApellidoA

        End If
        If EdadA.GetTypeCode = 0 Then
            MsgBox("Debe escribir la edad del alumno ")
            Exit Sub
        Else
            Edad = EdadA

        End If
        If SexoA.Length = 0 Then
            MsgBox("Debe escribir el sexo del alumno")
            Exit Sub
        Else
            Sexo = SexoA

        End If
        If IDA.Length = 0 Then
            MsgBox("Debe escribir el DUI del alumno ")
            Exit Sub
        Else
            ID = IDA

        End If

        If CorreoA.Length = 0 Then
            MsgBox("Debe escribir el correo del alumno ")
            Exit Sub
        Else
            Correo = CorreoA

        End If
        If SexoA = "F" Or SexoA = "M" Then
        Else
            MsgBox("Debe Escribir F para femenino o M para masculino")
            Exit Sub
        End If
        If DireccionA.Length = 0 Then
            MsgBox("Debe Escribir la direccion del alumno")
            Exit Sub
        Else
            Direccion = DireccionA
            datosCompletos = True
                                                

        End If

    End Sub

    Public Function generarCodigo(ByVal Nombre As String)
        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(Nombre, 1))
        valor2 = Right(Nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2

    End Function


End Class
