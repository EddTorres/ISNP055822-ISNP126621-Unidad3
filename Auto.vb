Public Class Auto
    'declaraciones de propiedades 
    Private Marca As String
    Private Modelo As String
    Private Combustible As String
    Private Año As Integer
    Private Color As String


    'indica si los datos ingresados estan completos 
    Private datosCompletos As String

    'metodos para propiedades
    'Metodo para nombre alumno 
    Public Property MarcaAuto() As String
        Get
            Return Marca

        End Get
        Set(value As String)
            Marca = value

        End Set
    End Property
    'metodo para apellido de alumno
    Public Property ModeloAuto() As String
        Get
            Return Modelo

        End Get
        Set(value As String)
            Modelo = value

        End Set
    End Property
    'metodo para edad alumno
    Public Property AñoAuto() As Integer
        Get
            Return Año

        End Get
        Set(value As Integer)
            Año = value

        End Set
    End Property
    'metodo para sexo de alumno

    Public Property CombustibleAuto() As String
        Get
            Return Combustible

        End Get
        Set(value As String)
            Combustible = value

        End Set
    End Property
    'metodo direccion del alumno
    Public Property ColorAuto() As String
        Get
            Return Color

        End Get
        Set(value As String)
            Color = value

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
    Public Sub datosAlumno(ByVal MarcaA As String, ByVal ModeloA As String, ByVal ColorA As String, ByVal AñoA As Integer, ByVal CombustibleA As String)

        If MarcaA.Length = 0 Then
            MsgBox("Debe escribir la marca del auto")
            Exit Sub
        Else
            Marca = MarcaA

        End If
        If ModeloA.Length = 0 Then
            MsgBox("Debe Escribir el modelo del auto")
            Exit Sub
        Else
            Modelo = ModeloA

        End If
        If AñoA.GetTypeCode = 0 Then
            MsgBox("Debe escribir el año del auto ")
            Exit Sub
        Else
            Año = AñoA

        End If

        If CombustibleA.Length = 0 Then
            MsgBox("Debe escribir el tipo de combustible del auto ")
            Exit Sub
        Else
            Combustible = CombustibleA

        End If

        If ColorA.Length = 0 Then
            MsgBox("Debe Escribir el color del auto")
            Exit Sub
        Else
            Color = ColorA

        End If

    End Sub
End Class
