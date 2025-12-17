

Module Module1
    Private persona As Persona
    Private mascota As Mascota
    Private _perMasJoven As Persona
    Private _mascotaMasVieja As Mascota

    Sub Main()
        Dim entrada As String
        Do
            MostrarMensaje("DATOS PERSONA", ConsoleColor.Blue)
            persona = New Persona
            persona.Nombre = PedirTexto("Nombre: ")
            persona.FechaNacimiento = PedirFechaNacimiento()
            ActualizarPersonaMasJoven(persona)
            entrada = PedirSioNo("¿Tiene mascota (S/N)?: ")
            If entrada = "S" Then
                mascota = New Mascota
                MostrarMensaje("DATOS DE SU MASCOTA", ConsoleColor.Blue)
                mascota.Nombre = PedirTexto("Nombre: ")
                mascota.TipoMascota = PedirTexto("Tipo: ")
                mascota.Raza = PedirTexto("Raza: ")
                mascota.FechaNacimiento = PedirFechaNacimiento()
                ActualizarMascotaMasVieja(mascota)
                persona.SuMascota = mascota
                mascota.Dueño = persona
            End If
            entrada = PedirSioNo("¿Otra persona? (S/N): ")
        Loop While entrada = "S"

        MostrarMensaje("Datos de la persona más joven", ConsoleColor.Cyan)
        MostrarMensaje($"Persona más joven: {_perMasJoven.Nombre} {ControlChars.NewLine} Fecha de nacimiento: {_perMasJoven.FechaNacimiento.ToLongDateString}", ConsoleColor.Blue)

        If IsNothing(_perMasJoven.SuMascota) Then ' If _perMasJoven.SuMascota Is Nothing Then
            MostrarMensaje("No tiene mascota.", ConsoleColor.Gray)
        Else
            MostrarMensaje($"Mascota: {_perMasJoven.SuMascota}", ConsoleColor.Blue)
        End If

        If Not IsNothing(_mascotaMasVieja) Then
            MostrarMensaje("Datos de la mascota más vieja", ConsoleColor.Cyan)
            MostrarMensaje($"Mascota más vieja: {_mascotaMasVieja.Nombre} {vbCrLf} Tipo: {_mascotaMasVieja.TipoMascota} {vbCrLf} Raza: {_mascotaMasVieja.Raza} {vbCrLf} Fecha de Nacimiento: {_mascotaMasVieja.FechaNacimiento.ToLongDateString} {vbCrLf} Dueño: {_mascotaMasVieja.Dueño.Nombre}", ConsoleColor.Blue)
        Else
            MostrarMensaje("No hay mascotas", ConsoleColor.DarkGray)
        End If
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
End Module