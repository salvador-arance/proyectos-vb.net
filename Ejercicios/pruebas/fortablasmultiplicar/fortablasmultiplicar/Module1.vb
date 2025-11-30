Module Module1

    Sub Main()
        Dim entrada As String
        Dim numero As Decimal
        Dim resultado As Decimal
        Dim tabla As String

        Do
            Do
                Console.Write("Introduce el número: ")
                entrada = Console.ReadLine

                If Not Decimal.TryParse(entrada, numero) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce un número válido")
                    Console.ResetColor()
                End If
            Loop While Not Decimal.TryParse(entrada, numero)

            tabla = ""

            For i = 0 To 10 Step 1
                resultado = numero * i
                If i < 10 Then
                    tabla &= $"{numero} x {i} = {resultado} {vbCrLf}"
                Else
                    tabla &= $"{numero} x {i} = {resultado}"
                End If
            Next

            Console.WriteLine(tabla)

            Do
                Console.Write("Quieres otra? (S/N): ")
                entrada = Console.ReadLine.ToLower

                If Not (entrada = "s" OrElse entrada = "n") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine("Introduce S o N")
                    Console.ResetColor()
                End If
            Loop While Not (entrada = "s" OrElse entrada = "n")

        Loop While Not entrada = "n"
    End Sub

End Module
