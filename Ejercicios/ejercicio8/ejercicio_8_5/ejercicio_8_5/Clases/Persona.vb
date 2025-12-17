Public Class Persona
    Private _Nombre As String
    Private _FechaNacimiento As Date
    Private _Mascotas() As Mascota

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
        End Set
    End Property

    Public Property Mascotas As Mascota()
        Get
            Return _Mascotas
        End Get
        Set(value As Mascota())
            _Mascotas = value
        End Set
    End Property
End Class
