Imports System.Globalization

Module Module1

    Sub Main()
        Dim numeroPersonas As Integer
        Dim entrada As String
        Dim datoValido As Boolean
        Dim nombrePersonaConMasEdad As String
        Dim posPersonaConMasEdad As Integer

        Do
            Console.Write("Número de personas: ")
            entrada = Console.ReadLine
            datoValido = Integer.TryParse(entrada, numeroPersonas) AndAlso numeroPersonas > 0
            If Not datoValido Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Introduce un número de personas válido.")
                Console.ResetColor()
            End If
        Loop While Not datoValido

        Dim personas(numeroPersonas - 1) As Persona

        Console.Clear()

        For i = 0 To numeroPersonas - 1
            personas(i) = New Persona
            Console.Write($"Nombre Persona {i + 1}: ")
            personas(i).Nombre = Console.ReadLine

            Do
                Console.Write($"Número de Descendientes Persona {i + 1}: ")
                entrada = Console.ReadLine
                datoValido = Byte.TryParse(entrada, personas(i).NumDescendientes) AndAlso personas(i).NumDescendientes >= 0 AndAlso personas(i).NumDescendientes <= 20
                If Not datoValido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número de descendientes válido.")
                    Console.ResetColor()
                End If
            Loop While Not datoValido

            Do
                Console.Write($"Fecha de nacimiento Persona {i + 1}: ")
                entrada = Console.ReadLine
                datoValido = Date.TryParse(entrada, personas(i).FechaNacimiento) AndAlso personas(i).FechaNacimiento <= Today
                If Not datoValido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce una fecha de nacimiento válida.")
                    Console.ResetColor()
                End If
            Loop While Not datoValido

            Console.Clear()
        Next

        For i = 0 To numeroPersonas - 1
            Console.WriteLine($"{personas(i).Nombre} {personas(i).NumDescendientes} {personas(i).FechaNacimiento.ToShortDateString}")
        Next


        For i = 0 To numeroPersonas - 1
            If i = 0 Then
                nombrePersonaConMasEdad = personas(i).Nombre
                posPersonaConMasEdad = i
            Else
                If personas(i).FechaNacimiento < personas(posPersonaConMasEdad).FechaNacimiento Then
                    nombrePersonaConMasEdad = personas(i).Nombre
                    posPersonaConMasEdad = i
                End If
            End If
        Next

    End Sub

End Module
