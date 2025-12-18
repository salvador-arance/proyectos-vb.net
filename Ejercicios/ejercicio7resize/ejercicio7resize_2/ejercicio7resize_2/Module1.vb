Module Module1

    Sub Main()
        Dim entrada As String
        Dim arrayNombres() As String = {}
        Dim contador As Integer
        Dim nombreValido As Boolean
        Dim masConsultas As Boolean
        contador = 0

        Do

            Do
                Dim int As Integer = arrayNombres.Length
                Array.Resize(arrayNombres, contador + 1)
                Console.Write($"Introduce el {contador + 1}º Nombre <Apellido1, Nombre>: ")
                entrada = Console.ReadLine()
                nombreValido = Not arrayNombres.Contains(entrada) AndAlso entrada.Length > 2 AndAlso Not String.IsNullOrWhiteSpace(entrada)

                If Not nombreValido Then
                    Console.WriteLine("El nombre ya existe, introduzca uno válido.")
                Else
                    arrayNombres(contador) = entrada
                End If

            Loop While Not nombreValido

            Do
                Console.Write("¿Otra persona (S/N)?: ")
                entrada = Console.ReadLine.ToUpper
                If entrada <> "S" AndAlso entrada <> "N" Then
                    Console.WriteLine("Por favor, introduzca S o N.")
                End If
            Loop While entrada <> "S" AndAlso entrada <> "N"

            contador += 1
        Loop While entrada = "S"

        Array.Sort(arrayNombres)
        Console.Clear()

        For i = 0 To arrayNombres.Length - 1
            Console.WriteLine($"{i + 1}: {arrayNombres(i)}")
        Next


        Console.ReadKey()
        Console.Clear()
        Console.WriteLine("Consultas")

        Do
            Console.Write("Introduce un nombre: ")
            entrada = Console.ReadLine

            If arrayNombres.Contains(entrada) Then
                Console.WriteLine($"Sí hay alguien con ese nombre, es el número {Array.IndexOf(arrayNombres, entrada) + 1} de la lista.")
            Else
                Console.WriteLine("El nombre no se encuentra.")
                Console.WriteLine($"Veamos si el nombre se encuentra dentro de algún otro...")

                Dim posiciones() As Integer = {}
                Dim k As Integer = 0

                For i = 0 To arrayNombres.Length - 1
                    If arrayNombres(i).Contains(entrada) Then
                        k += 1
                        Array.Resize(posiciones, k)
                        posiciones(k - 1) = i
                    End If
                Next

                If posiciones.Length > 0 Then

                    Console.WriteLine("El nombre se encuentra: ")
                    For i = 0 To posiciones.Length - 1
                        Console.Write($"En {arrayNombres(posiciones(i))} en la posición {posiciones(i) + 1}.")
                        Console.WriteLine()
                    Next
                Else
                    Console.WriteLine("No hemos conseguido encontrar nada.")
                End If
            End If

            Do
                Console.Write("Otra búsqueda (S/N): ")
                entrada = Console.ReadLine.ToUpper
                If entrada <> "S" AndAlso entrada <> "N" Then
                    Console.WriteLine("Introduce S o N.")
                End If
            Loop While entrada <> "S" AndAlso entrada <> "N"

            masConsultas = entrada.Equals("S")

        Loop While masConsultas
    End Sub

End Module
