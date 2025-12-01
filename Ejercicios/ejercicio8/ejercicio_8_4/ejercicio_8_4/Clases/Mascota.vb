Public Class Mascota
    Private _Nombre As String
    Private _FechaNacimiento As Date
    Private _Raza As String
    Private _TipoMascota As String
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

    Public Property Raza As String
        Get
            Return _Raza
        End Get
        Set(value As String)
            _Raza = value
        End Set
    End Property

    Public Property TipoMascota As String
        Get
            Return _TipoMascota
        End Get
        Set(value As String)
            _TipoMascota = value
        End Set
    End Property

End Class
