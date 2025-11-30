Public Class Perro 'Aquí creo la clase pública perro.
    Private _Raza As String 'Aquí declaro una variable privada asociada a la propiedad raza de la clase perro.
    Private _Nombre As String
    Private _FechaNacimiento As Date

    Public Property Raza As String 'Aquí defino la propiedad raza de la clase perro.
        Get ' Aquí devolvemos el valor de la raza
            Return _Raza
        End Get
        Set(value As String) 'Permite cambiar el valor de la variable _Raza por el valor que trae la variable value.
            _Raza = value
        End Set
    End Property

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
End Class
