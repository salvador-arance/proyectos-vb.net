Public Class Persona
    Private _Nombre As String
    Private _Apellido1 As String
    Private _Apellido2 As String
    Private _Telefono As String
    Private _FechaAlta As Date
    Private _SueldoBase As Single

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return _Apellido1
        End Get
        Set(value As String)
            _Apellido1 = value
        End Set
    End Property

    Public Property Apellido2 As String
        Get
            Return _Apellido2
        End Get
        Set(value As String)
            _Apellido2 = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(value As Date)
            _FechaAlta = value
        End Set
    End Property

    Public Property SueldoBase As Single
        Get
            Return _SueldoBase
        End Get
        Set(value As Single)
            _SueldoBase = value
        End Set
    End Property

    Public ReadOnly Property NombreCompleto As String
        Get
            If String.IsNullOrWhiteSpace(_Nombre) AndAlso String.IsNullOrWhiteSpace(_Apellido1) AndAlso String.IsNullOrWhiteSpace(_Apellido2) Then
                Return ""
            End If

            If (Not (String.IsNullOrWhiteSpace(_Nombre))) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Apellido1 & ", " & _Apellido2 & ", " & _Nombre
            End If

            If (Not (String.IsNullOrWhiteSpace(_Nombre))) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Apellido1 & ", " & _Nombre
            End If

            If (Not (String.IsNullOrWhiteSpace(_Nombre))) AndAlso (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Nombre
            End If

            If (Not (String.IsNullOrWhiteSpace(_Nombre))) AndAlso (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Apellido2 & ", " & _Nombre
            End If

            If ((String.IsNullOrWhiteSpace(_Nombre))) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Apellido1 & ", " & _Apellido2
            End If

            If ((String.IsNullOrWhiteSpace(_Nombre))) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Apellido1
            End If

            If ((String.IsNullOrWhiteSpace(_Nombre))) AndAlso (String.IsNullOrWhiteSpace(_Apellido1)) AndAlso Not (String.IsNullOrWhiteSpace(_Apellido2)) Then
                Return _Apellido2
            End If

        End Get

    End Property

    Public ReadOnly Property Trienios As Integer
        Get

            Dim años As Integer = Today.Year - _FechaAlta.Year

            If (_FechaAlta.Month > Today.Month OrElse (_FechaAlta.Month = Today.Month AndAlso _FechaAlta.Day > Today.Day)) Then
                años -= 1
            End If

            Return años \ 3
        End Get
    End Property

    Public ReadOnly Property SueldoCompleto As Single
        Get
            Return _SueldoBase + (Trienios * 50)
        End Get
    End Property

    Public Sub AumentoSueldo(modSueldo As Integer)
        SueldoBase += (SueldoBase * (modSueldo / 100))
    End Sub

End Class
