Module Module1

    Sub Main()
        Dim masNumeros As Boolean
        Dim datoValido As Boolean
        Dim entrada As String
        Dim numBuscado As Integer
        Dim contador As Integer = 0
        Dim arrayEnteros(1) As Integer

        Do
            Do
                Console.Write($"Introduce el número {contador + 1}: ")
                entrada = Console.ReadLine
                datoValido = Integer.TryParse(entrada, arrayEnteros(contador))
                If Not datoValido Then
                    Console.WriteLine("Por favor, introduce un dato válido")
                End If
            Loop While Not datoValido

            Do
                Console.Write("Otro (S/N): ")
                entrada = Console.ReadLine().ToUpper
                datoValido = entrada.Equals("S") OrElse entrada.Equals("N")
            Loop While Not datoValido

            masNumeros = entrada.Equals("S")

            If masNumeros Then
                contador += 1
                Array.Resize(arrayEnteros, contador + 1)
            End If
        Loop While masNumeros

        Console.Clear()

        Do
            Do
                Console.Write("Introduce el número a buscar: ")
                entrada = Console.ReadLine()
                datoValido = Integer.TryParse(entrada, numBuscado)
                If Not datoValido Then
                    Console.WriteLine("Por favor, introduce un dato válido")
                End If
            Loop While Not datoValido

            If arrayEnteros.Contains(numBuscado) Then
                If Array.IndexOf(arrayEnteros, numBuscado) <> Array.LastIndexOf(arrayEnteros, numBuscado) Then

                    Dim posiciones() As Integer = {}
                    Dim k As Integer = 0

                    For i = 0 To arrayEnteros.Length - 1
                        If numBuscado = arrayEnteros(i) Then
                            k += 1
                            Array.Resize(posiciones, k)
                            posiciones(k - 1) = i
                        End If
                    Next

                    Console.Write("El número se encuentra varias veces, en las posiciones ")

                    For i = 0 To posiciones.Length - 1
                        If i < posiciones.Length - 2 Then
                            Console.Write($"{posiciones(i)}, ")
                        ElseIf i = posiciones.Length - 2 Then
                            Console.Write($"{posiciones(i)} y ")
                        ElseIf i = posiciones.Length - 1 Then
                            Console.Write(posiciones(i))
                        End If
                    Next

                    Console.WriteLine()
                Else
                    Console.WriteLine($"El número se encuentra en la posición {Array.IndexOf(arrayEnteros, numBuscado)}")
                End If
            Else
                Console.WriteLine("El número no se encuentra.")
            End If

            Do
                Console.Write("Otro (S/N): ")
                entrada = Console.ReadLine().ToUpper
                datoValido = entrada.Equals("S") OrElse entrada.Equals("N")
            Loop While Not datoValido

            masNumeros = entrada.Equals("S")

        Loop While masNumeros

    End Sub

End Module
