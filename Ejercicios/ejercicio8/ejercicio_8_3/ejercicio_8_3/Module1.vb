Imports System.Linq.Expressions

Module Module1

    Dim currelantes As Persona() = {}
    Sub Main()
        Dim entrada As String
        Dim opcion As Byte

        Do
            Console.Clear()
            Do
                Console.WriteLine($"MENÚ {vbCrLf} 1. Alta de una nueva persona trabajadora. {vbCrLf} 2. Estadísticas. {vbCrLf} 3. Modificar sueldo de persona. {vbCrLf} 4. Fin")
                Console.Write("Opción [1-4]: ")
                entrada = Console.ReadLine
                If Not Byte.TryParse(entrada, opcion) OrElse (opcion < 1 AndAlso opcion > 4) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce una opción válida.")
                    Console.ResetColor()
                End If
            Loop While Not Byte.TryParse(entrada, opcion) OrElse (opcion < 1 AndAlso opcion > 4)

            Select Case opcion
                Case 1
                    Opcion_1()
                Case 2
                    Opcion_2()
                Case 3
                    Opcion_3()
                Case 4
                    Exit Sub
            End Select
        Loop
    End Sub

    Private Sub Opcion_1()
        Dim currelaAux As Persona
        Dim entrada As String

        currelaAux = New Persona

        Console.Clear()

        Do
            Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine($"Introducir datos de persona número: {currelantes.Length + 1}")

            Console.ResetColor()

            Do
                Console.Write("Nombre de pila ........: ")
                Console.ForegroundColor = ConsoleColor.Blue
                currelaAux.Nombre = Console.ReadLine()
                Console.ResetColor()

                Console.Write("Apellido 1 ............: ")
                Console.ForegroundColor = ConsoleColor.Blue
                currelaAux.Apellido1 = Console.ReadLine()
                Console.ResetColor()

                Console.Write("Apellido 2 ............: ")
                Console.ForegroundColor = ConsoleColor.Blue
                currelaAux.Apellido2 = Console.ReadLine()
                Console.ResetColor()

                Console.Write("Nombre completo .......: ")
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine(currelaAux.NombreCompleto)
                Console.ResetColor()
                If String.IsNullOrEmpty(currelaAux.NombreCompleto) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine($"{ControlChars.Tab} No puedes dejar el nombre completo en blanco, vuelve a teclear datos.")
                    Console.ResetColor()
                End If

            Loop While String.IsNullOrEmpty(currelaAux.NombreCompleto)

            Do
                Console.Write("Teléfono ..............: ")
                Console.ForegroundColor = ConsoleColor.Blue
                entrada = Console.ReadLine()
                If Not (Integer.TryParse(entrada, currelaAux.Telefono) AndAlso entrada.Length = 9) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El teléfono debe ser un número de 9 caracteres")
                    Console.ResetColor()
                End If
            Loop While Not (Integer.TryParse(entrada, currelaAux.Telefono) AndAlso entrada.Length = 9)

            Console.ResetColor()

            Do
                Console.Write("Sueldo base (>0) ......: ")
                Console.ForegroundColor = ConsoleColor.Blue
                entrada = Console.ReadLine()
                If Not (Integer.TryParse(entrada, currelaAux.SueldoBase) AndAlso currelaAux.SueldoBase > 0) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El sueldo debe ser un número positivo.")
                    Console.ResetColor()
                End If
            Loop While Not (Integer.TryParse(entrada, currelaAux.SueldoBase) AndAlso currelaAux.SueldoBase > 0)

            Console.ResetColor()

            Do
                Console.Write("Fecha de alta (>0) ....: ")
                Console.ForegroundColor = ConsoleColor.Blue
                entrada = Console.ReadLine()

                If Not (Date.TryParse(entrada, currelaAux.FechaAlta) AndAlso currelaAux.FechaAlta <= Today) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("No puede ser una fecha superior a la actual.")
                    Console.ResetColor()
                End If
            Loop While Not (Date.TryParse(entrada, currelaAux.FechaAlta) AndAlso currelaAux.FechaAlta <= Today)


            Console.ResetColor()

            If currelaAux.Trienios >= 1 Then
                Console.ForegroundColor = ConsoleColor.Blue
                Console.WriteLine($"{ControlChars.Tab} Por tener {currelaAux.Trienios} trienio/s, el sueldo de {currelaAux.NombreCompleto} será {currelaAux.SueldoCompleto}")
                Console.ResetColor()
            End If

            Do
                Console.Write("Datos correctos(S/N): ")
                entrada = Console.ReadLine().ToUpper
                If entrada <> "N" AndAlso entrada <> "S" Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While entrada <> "N" AndAlso entrada <> "S"

        Loop While entrada.Equals("N")

        Array.Resize(currelantes, currelantes.Length + 1)

        currelantes(currelantes.Length - 1) = New Persona

        currelantes(currelantes.Length - 1).Nombre = currelaAux.Nombre
        currelantes(currelantes.Length - 1).Apellido1 = currelaAux.Apellido1
        currelantes(currelantes.Length - 1).Apellido2 = currelaAux.Apellido2
        currelantes(currelantes.Length - 1).Telefono = currelaAux.Telefono
        currelantes(currelantes.Length - 1).FechaAlta = currelaAux.FechaAlta
        currelantes(currelantes.Length - 1).SueldoBase = currelaAux.SueldoBase
        currelantes(currelantes.Length - 1).ModSueldo = currelaAux.ModSueldo

    End Sub

    Private Sub Opcion_2()
        Console.Clear()
        Dim sueldoMax As Single
        Dim sueldoMin As Single

        If currelantes.Length = 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("No has introducido datos de nadie.")
            Console.ResetColor()
            Console.ReadKey()
            Exit Sub
        End If

        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("Datos de todas las personas introducidas:")
        Console.ResetColor()

        For i = 0 To currelantes.Length - 1
            Console.Write($"{i + 1} {currelantes(i).NombreCompleto} con sueldo {currelantes(i).SueldoCompleto}.")
            If currelantes(i).Trienios > 0 Then
                Console.ForegroundColor = ConsoleColor.Blue
                Console.Write($" Tiene {currelantes(i).Trienios} trienio/s.")
                Console.ResetColor()
            End If
            Console.WriteLine()

            If i = 0 Then
                sueldoMax = currelantes(i).SueldoCompleto
                sueldoMin = currelantes(i).SueldoCompleto
            Else
                If currelantes(i).SueldoCompleto > sueldoMax Then
                    sueldoMax = currelantes(i).SueldoCompleto
                ElseIf currelantes(i).SueldoCompleto < sueldoMin Then
                    sueldoMin = currelantes(i).SueldoCompleto
                End If
            End If
        Next

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine($"Personas con el mayor salario ({sueldoMax}):")
        Console.ResetColor()
        Console.WriteLine()
        For i = 0 To currelantes.Length - 1
            If currelantes(i).SueldoCompleto = sueldoMax Then
                Console.Write($"{i + 1} {currelantes(i).NombreCompleto} con sueldo {currelantes(i).SueldoCompleto}.")
                If currelantes(i).Trienios > 0 Then
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.Write($" Tiene {currelantes(i).Trienios} trienio/s.")
                    Console.ResetColor()
                End If
            End If
        Next

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine($"Personas con el menor salario ({sueldoMin}):")
        Console.ResetColor()
        Console.WriteLine()

        For i = 0 To currelantes.Length - 1
            If currelantes(i).SueldoCompleto = sueldoMin Then
                Console.Write($"{i + 1} {currelantes(i).NombreCompleto} con sueldo {currelantes(i).SueldoCompleto}.")
                If currelantes(i).Trienios > 0 Then
                    Console.ForegroundColor = ConsoleColor.Blue
                    Console.Write($" Tiene {currelantes(i).Trienios} trienio/s.")
                    Console.ResetColor()
                End If
                Console.WriteLine()
            End If
        Next
        Console.ReadKey()
    End Sub

    Private Sub Opcion_3()
        Console.Clear()
        Dim entrada As String
        Dim pos As Integer = -1

        If currelantes.Length = 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write("No has introducido datos de nadie.")
            Console.ResetColor()
            Console.ReadKey()
            Exit Sub
        End If

        Console.WriteLine("Modificar Sueldo")

        Do
            Console.Write("Nombre completo: ")
            entrada = Console.ReadLine

            For i = 0 To currelantes.Length - 1
                If currelantes(i).NombreCompleto.Equals(entrada) Then
                    pos = i
                End If
            Next

            If pos < 0 Then
                Console.WriteLine()
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine($"Lo sentimos, no hay nadie con el nombre {entrada}")
                Console.ResetColor()

                Console.WriteLine("Aquí tienes una lista con los nombres de los empleados")

                Console.WriteLine()
                Console.ForegroundColor = ConsoleColor.Green
                For i = 0 To currelantes.Length - 1
                    Console.WriteLine($"{currelantes(i).NombreCompleto}")
                Next
                Console.ResetColor()
                Console.WriteLine()
            End If

        Loop While pos < 0

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine($"Sueldo base {currelantes(pos).SueldoBase}. Sueldo completo {currelantes(pos).SueldoCompleto}")
        Console.ResetColor()
        Console.WriteLine()

        Do
            Console.Write("Porcentaje de modificación (entre 0 y 100): ")
            entrada = Console.ReadLine

            If Not (Integer.TryParse(entrada, currelantes(pos).ModSueldo) AndAlso (currelantes(pos).ModSueldo >= 0 AndAlso currelantes(pos).ModSueldo <= 100)) Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número entre el 0 y el 100.")
                Console.ResetColor()
            End If
        Loop While Not (Integer.TryParse(entrada, currelantes(pos).ModSueldo) AndAlso (currelantes(pos).ModSueldo >= 0 AndAlso currelantes(pos).ModSueldo <= 100))

        currelantes(pos).AumentoSueldo()

        Console.WriteLine()
        Console.WriteLine("Después del aumento:")

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine($"Sueldo base {currelantes(pos).SueldoBase}. Sueldo completo {currelantes(pos).SueldoCompleto}")
        Console.ResetColor()
        Console.ReadKey()
    End Sub

End Module



