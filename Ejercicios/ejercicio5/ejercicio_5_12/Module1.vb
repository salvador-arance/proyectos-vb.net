Module Module1

    Sub Main()
        Dim entrada As String
        Dim indice As Integer
        Dim l As Integer
        Dim centro As Integer
        Dim palindromo As Boolean

        Do
            Console.Write("Introduce un número o un texto y te diré si es palíndromo: ")
            entrada = Console.ReadLine().ToLower()
            l = entrada.Length - 1
            centro = entrada.Length \ 2
            indice = 0
            palindromo = True

            Do
                If (entrada.Chars(indice) <> entrada.Chars(l - indice) OrElse l = 0) Then
                    palindromo = False
                End If
                indice += 1
            Loop Until indice = centro OrElse palindromo = False

            If palindromo Then
                Console.WriteLine("Sí es")
            Else
                Console.WriteLine("No es")
            End If

            Do
                Console.Write("¿Otro número (S/N)? ")
                entrada = Console.ReadLine().ToUpper()
                If Not (entrada = "N" OrElse entrada = "S") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Por favor, introduce S o N.")
                    Console.ResetColor()
                End If
            Loop While Not (entrada = "N" OrElse entrada = "S")

        Loop Until entrada = "N"


    End Sub

End Module
