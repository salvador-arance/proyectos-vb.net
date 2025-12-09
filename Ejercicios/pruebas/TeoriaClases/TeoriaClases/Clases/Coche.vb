Public Class Coche
    Private _Matricula As String
    Private _Velocidad As Single
    Public Property Matricula As String
        Get
            Return _Matricula
        End Get
        Set(value As String)
            _Matricula = value
        End Set
    End Property
    Public Sub New() 'El constructor sin parámetros
        _Velocidad = 0
        _Matricula = "0000BBB"
    End Sub
    Public Sub New(mat As String) 'Constructor con parámetros
        Matricula = mat ' _Matricula = mat
        _Velocidad = 0
    End Sub
End Class
