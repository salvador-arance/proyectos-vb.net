Public Class Persona
    Private _Nombre As String
    Private _NumDescendientes As Byte
    Private _FechaNacimiento As Date

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property NumDescendientes As Byte
        Get
            Return _NumDescendientes
        End Get
        Set(value As Byte)
            _NumDescendientes = value
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
End Class
