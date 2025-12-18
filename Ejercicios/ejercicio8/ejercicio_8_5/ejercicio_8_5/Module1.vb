Module Module1
    Private personas As Persona() = {}
    Private mascota As Mascota
    Private _perMasJoven As Persona
    Private _mascotaMasVieja As Mascota

    Sub Main()
        Dim entrada As String
        Do
            MostrarMensaje("DATOS PERSONA", ConsoleColor.Blue)
            Array.Resize(personas, personas.Length + 1)
            Dim indiceActualPersonas As Integer = personas.Length - 1
            personas(indiceActualPersonas) = New Persona
            personas(indiceActualPersonas).Nombre = PedirTexto("Nombre: ")
            personas(indiceActualPersonas).FechaNacimiento = PedirFechaNacimiento()
            ActualizarPersonaMasJoven(personas(indiceActualPersonas))
            entrada = PedirSioNo("¿Tiene mascota (S/N)?: ")
            If entrada = "S" Then
                Dim nMascotas As Integer = PedirNumero("¿Cuántas mascotas tienes? (>1 y <10): ")
                Array.Resize(personas(indiceActualPersonas).Mascotas, nMascotas)
                For i = 0 To nMascotas - 1
                    personas(indiceActualPersonas).Mascotas(i) = New Mascota
                    MostrarMensaje("DATOS DE SU MASCOTA", ConsoleColor.Blue)
                    personas(indiceActualPersonas).Mascotas(i).Nombre = PedirTexto("Nombre: ")
                    personas(indiceActualPersonas).Mascotas(i).TipoMascota = PedirTexto("Tipo: ")
                    personas(indiceActualPersonas).Mascotas(i).Raza = PedirTexto("Raza: ")
                    personas(indiceActualPersonas).Mascotas(i).FechaNacimiento = PedirFechaNacimiento()
                    ActualizarMascotaMasVieja(personas(indiceActualPersonas).Mascotas(i))
                Next
            End If
            entrada = PedirSioNo("¿Otra persona? (S/N): ")
        Loop While entrada = "S"

        ImprimirDatosPersonas()
        ImprimirDatosPersonaJoven()
        ImprimirDatosMascota()
    End Sub
    Sub MostrarMensaje(mensaje As String, color As ConsoleColor)
        Console.ForegroundColor = color
        If color = ConsoleColor.White Then
            Console.Write(mensaje)
        Else
            Console.WriteLine(mensaje)
        End If
        Console.ResetColor()
    End Sub
    Sub ActualizarPersonaMasJoven(per As Persona)
        If IsNothing(_perMasJoven) OrElse per.FechaNacimiento > _perMasJoven.FechaNacimiento Then
            _perMasJoven = per
        End If
    End Sub
    Sub ActualizarMascotaMasVieja(masc As Mascota)
        If IsNothing(_mascotaMasVieja) OrElse masc.FechaNacimiento < _mascotaMasVieja.FechaNacimiento Then
            _mascotaMasVieja = masc
        End If
    End Sub
    Sub ImprimirDatosPersonas()
        MostrarMensaje("Datos de todas las personas", ConsoleColor.Cyan)
        For i = 0 To personas.Length - 1
            MostrarMensaje($"Nombre Persona {i + 1}: {personas(i).Nombre} {ControlChars.NewLine} Fecha de nacimiento Persona {i + 1}: {personas(i).FechaNacimiento.ToLongDateString}", ConsoleColor.Blue)
            If personas(i).Mascotas Is Nothing Then
                MostrarMensaje("No tiene mascotas", ConsoleColor.Blue)
            Else
                For j = 0 To personas(i).Mascotas.Length - 1
                    MostrarMensaje($"Nombre Mascota {j + 1} Persona {i + 1}: {personas(i).Mascotas(j).Nombre} {vbCrLf} Tipo Mascota {j + 1} Persona {i + 1}: {personas(i).Mascotas(j).TipoMascota} {vbCrLf} Raza Mascota {j + 1} Persona {i + 1}: {personas(i).Mascotas(j).Raza} {vbCrLf} Fecha de Nacimiento Mascota {j + 1} Persona {i + 1}: {personas(i).Mascotas(j).FechaNacimiento.ToLongDateString}", ConsoleColor.Blue)
                Next
            End If
        Next
    End Sub
    Sub ImprimirDatosPersonaJoven()
        MostrarMensaje("Datos de la persona más joven", ConsoleColor.Cyan)
        MostrarMensaje($"Persona más joven: {_perMasJoven.Nombre} {ControlChars.NewLine} Fecha de nacimiento: {_perMasJoven.FechaNacimiento.ToLongDateString}", ConsoleColor.Blue)

        If _perMasJoven.Mascotas Is Nothing Then
            MostrarMensaje("No tiene mascota.", ConsoleColor.Blue)
        Else
            For i = 0 To _perMasJoven.Mascotas().Length - 1
                MostrarMensaje($"Mascota: {_perMasJoven.Mascotas(i).Nombre} {vbCrLf} Tipo: {_perMasJoven.Mascotas(i).TipoMascota} {vbCrLf} Raza: {_perMasJoven.Mascotas(i).Raza} {vbCrLf} Fecha de Nacimiento: {_perMasJoven.Mascotas(i).FechaNacimiento.ToLongDateString}", ConsoleColor.Blue)
            Next

        End If
    End Sub
    Sub ImprimirDatosMascota()
        If Not IsNothing(_mascotaMasVieja) Then
            MostrarMensaje("Datos de la mascota más vieja", ConsoleColor.Cyan)
            MostrarMensaje($"Mascota más vieja: {_mascotaMasVieja.Nombre} {vbCrLf} Tipo: {_mascotaMasVieja.TipoMascota} {vbCrLf} Raza: {_mascotaMasVieja.Raza} {vbCrLf} Fecha de Nacimiento: {_mascotaMasVieja.FechaNacimiento.ToLongDateString} {vbCrLf} Dueño: {BuscarDueño()}", ConsoleColor.Blue)

        Else
            MostrarMensaje("No hay mascotas", ConsoleColor.DarkGray)
        End If
    End Sub
    Function BuscarDueño() As String
        For i = 0 To personas.Length - 1
            If personas(i).Mascotas IsNot Nothing Then
                For j = 0 To personas(i).Mascotas.Length - 1
                    If personas(i).Mascotas(j) Is _mascotaMasVieja Then
                        Return personas(i).Nombre
                    End If
                Next
            End If
        Next
        Return "Desconocido"
    End Function
    Function PedirTexto(mensaje As String) As String
        Dim entrada As String
        Do
            MostrarMensaje(mensaje, ConsoleColor.White)
            entrada = Console.ReadLine()
        Loop While CaracteresValidos(entrada) = False
        Return entrada
    End Function
    Function CaracteresValidos(palabra As String) As Boolean
        Dim tieneNoLetras As Boolean
        If String.IsNullOrWhiteSpace(palabra) Then
            MostrarMensaje("El nombre no puede quedarse en blanco.", ConsoleColor.Red)
            Return False
        Else
            For i = 0 To palabra.Length - 1
                tieneNoLetras = Not (Char.IsLetter(palabra.ElementAt(i)) OrElse Char.IsWhiteSpace(palabra.ElementAt(i)))
                If tieneNoLetras Then
                    Exit For
                End If
            Next
            If tieneNoLetras Then
                MostrarMensaje("El nombre solo puede tener letras o espacios en blanco", ConsoleColor.Red)
                Return False
            Else
                Return True
            End If
        End If
    End Function
    Function PedirFechaNacimiento() As Date
        Dim entrada As String
        Dim fechaAux As Date
        Do
            MostrarMensaje("Fecha de nacimiento: ", ConsoleColor.White)
            entrada = Console.ReadLine()
            If Not Date.TryParse(entrada, fechaAux) OrElse fechaAux > Today Then
                MostrarMensaje("Debes introducir una fecha anterior a la de hoy.", ConsoleColor.Red)
            End If
        Loop While Not Date.TryParse(entrada, fechaAux) OrElse fechaAux > Today
        Return fechaAux
    End Function
    Function PedirSioNo(mensaje As String)
        Dim entrada As String
        Do
            MostrarMensaje(mensaje, ConsoleColor.White)
            entrada = Console.ReadLine().ToUpper
            If Not (entrada = "S" OrElse entrada = "N") Then
                MostrarMensaje("Debe introducir S / N", ConsoleColor.Red)
            End If
        Loop While Not (entrada = "S" OrElse entrada = "N")
        Return entrada
    End Function
    Function PedirNumero(mensaje As String)
        Dim entrada As String
        Dim nMasc As Byte
        Do
            MostrarMensaje(mensaje, ConsoleColor.White)
            entrada = Console.ReadLine
            If Not Byte.TryParse(entrada, nMasc) OrElse nMasc >= 10 Then
                MostrarMensaje("No has introducido un número de mascotas válido", ConsoleColor.Red)
            End If
        Loop While Not Byte.TryParse(entrada, nMasc) OrElse nMasc >= 10
        Return nMasc
    End Function
End Module
