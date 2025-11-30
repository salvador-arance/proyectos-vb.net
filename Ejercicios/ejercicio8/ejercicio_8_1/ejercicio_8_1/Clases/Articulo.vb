Public Class Articulo
    Private _Cantidad As Integer
    Private _Nombre As String
    Private _Precio As Single
    Private _Pago As Single

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property Precio
        Get
            Return _Precio
        End Get
        Set(value)
            _Precio = value
        End Set
    End Property

    Public Function Pagar()

        _Pago = _Precio * _Cantidad
        Return _Pago

    End Function

End Class
