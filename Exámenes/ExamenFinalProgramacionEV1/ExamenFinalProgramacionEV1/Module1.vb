Imports System.Linq.Expressions

Module Module1

    Sub Main()
        Dim entrada As String
        Dim numeroEmpleados As Integer
        Dim sueldoMinimo As Integer
        Dim encimaPromedio As Integer = 0
        Dim debajoPromedio As Integer = 0
        Dim valido As Boolean

        Do

            Console.Write("¿Cuántas personas hay en la empresa?: ")
            entrada = Console.ReadLine()
            valido = Integer.TryParse(entrada, numeroEmpleados) AndAlso numeroEmpleados > 0
            If Not valido Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("¡Debe ser un número mayor que 0!")
                Console.ResetColor()
            End If
        Loop While Not valido

        Dim empleados(numeroEmpleados - 1) As String
        Dim sueldos(numeroEmpleados - 1) As Integer

        For i = 0 To empleados.Length - 1

            Console.WriteLine($"Persona nº {i + 1}")
            Do
                Console.Write("Nombre: ")
                empleados(i) = Console.ReadLine
                valido = empleados(i).Length >= 2 AndAlso Not String.IsNullOrWhiteSpace(empleados(i))
                If Not valido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El nombre debe contener como mínimo 2 caracteres.")
                    Console.ResetColor()
                End If
            Loop While Not valido

            Do
                Console.Write("Sueldo: ")
                entrada = Console.ReadLine()
                valido = Integer.TryParse(entrada, sueldos(i)) AndAlso sueldos(i) > 500
                If Not valido Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("El sueldo debe estar por encima de 500 euros.")
                    Console.ResetColor()
                End If
            Loop While Not valido
        Next

        Console.Clear()
        Console.WriteLine("LISTADO DE TODAS LAS PERSONAS CON SUS SUELDOS ACTUALES")
        Console.WriteLine($"Nº {ControlChars.Tab} NOMBRE {ControlChars.Tab} SUELDO")


        For i = 0 To empleados.Length - 1
            If empleados(i).Length <= 5 Then
                Console.WriteLine($"{i + 1} {ControlChars.Tab} {empleados(i)} {ControlChars.Tab} {ControlChars.Tab} {sueldos(i)}")
            Else
                Console.WriteLine($"{i + 1} {ControlChars.Tab} {empleados(i)} {ControlChars.Tab} {sueldos(i)}")
            End If
        Next

        Console.WriteLine()

        Do
            Console.Write("Sueldo mínimo interprofesional (>1000): ")
            entrada = Console.ReadLine()
            valido = Integer.TryParse(entrada, sueldoMinimo) AndAlso sueldoMinimo > 1000
            If Not valido Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("El sueldo debe ser mayor que 1000")
                Console.ResetColor()
            End If
        Loop While Not valido

        Dim contador As Integer = 0

        For i = 0 To sueldos.Length - 1
            If sueldos(i) < sueldoMinimo Then
                contador += 1
            End If
        Next

        Dim subidas(numeroEmpleados - 1) As Integer

        If contador > 0 Then
            Do
                Console.Write($"¿Aumentar el sueldo a SMI a las {contador} personas con menos sueldo? S/N: ")
                entrada = Console.ReadLine.ToUpper
                valido = entrada.Equals("S") OrElse entrada.Equals("N")
            Loop While Not valido

            If entrada.Equals("S") Then

                For i = 0 To sueldos.Length - 1
                    If sueldos(i) < sueldoMinimo Then
                        subidas(i) = sueldoMinimo - sueldos(i)
                        sueldos(i) += subidas(i)
                    Else
                        subidas(i) = 0
                    End If
                Next

                Console.WriteLine()
                Console.WriteLine($"Situación tras la subida a {contador} personas al SMI: ")
                Console.WriteLine($"Nº {ControlChars.Tab} NOMBRE {ControlChars.Tab} SUBIDA {ControlChars.Tab} SUELDO FINAL")

                For i = 0 To empleados.Length - 1
                    If empleados(i).Length <= 5 Then
                        Console.WriteLine($"{i + 1} {ControlChars.Tab} {empleados(i)} {ControlChars.Tab} {ControlChars.Tab} {subidas(i)} {ControlChars.Tab} {ControlChars.Tab} {sueldos(i)}")

                    Else
                        Console.WriteLine($"{i + 1} {ControlChars.Tab} {empleados(i)} {ControlChars.Tab} {subidas(i)} {ControlChars.Tab} {ControlChars.Tab} {sueldos(i)}")
                    End If
                Next

                Console.WriteLine()
            Else
                Console.WriteLine("Se ha decidido no aumentar el sueldo de las personas con uno inferior al SMI.")

            End If
        Else
            Console.WriteLine("No hay personas con un sueldo inferior al SMI.")
        End If


        Console.WriteLine($"El sueldo medio de la empresa es {sueldos.Average}")

        For i = 0 To sueldos.Length - 1
            If sueldos(i) < sueldos.Average Then
                debajoPromedio += 1
            Else
                encimaPromedio += 1
            End If
        Next

        Console.WriteLine($"{encimaPromedio} empleado(s) cobran el sueldo medio o más.")
        Console.WriteLine($"{debajoPromedio} empleado(s) cobran por debajo del sueldo medio.")

    End Sub

End Module
