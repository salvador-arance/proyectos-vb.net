Module Module1

    Sub Main()
        Dim entrada As String
        Dim contador As Integer = 0
        Dim articulosMasCaros As Integer = 0
        Dim primerArticulo As Boolean = True
        Dim articulo As String
        Dim precioArticulo As Decimal = 0
        Dim precioMasCaro As Decimal = 0
        Dim articuloMasCaro As String = ""
        Dim articuloMasBarato As String = ""
        Dim precioMasBarato As Decimal
        Dim precioValido As Boolean
        Dim articuloValido As Boolean
        Dim mismoprecio As Boolean = False
        Dim posX As Integer
        Dim posY As Integer
        Console.Clear()
        Console.WriteLine("     COMPRAS")
        Do
            Do
                Console.Write("Artículo " & (contador + 1) & ": ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                articulo = Console.ReadLine
                Console.ResetColor()
                articuloValido = True
                If IsNumeric(articulo) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + articulo.Length + 1), posY)
                    Console.WriteLine("Has introducido un valor numérico en el artículo")
                    Console.ResetColor()
                    articuloValido = False
                End If
            Loop Until articuloValido
            Do
                Console.Write("Precio: ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine
                Console.ResetColor()
                If Decimal.TryParse(entrada, precioArticulo) AndAlso precioArticulo > 0 Then
                    precioValido = True
                Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.WriteLine("Introduce un número válido.")
                    Console.ResetColor()
                    precioValido = False
                End If
            Loop Until precioValido

            contador += 1

            If primerArticulo Then
                precioMasCaro = precioArticulo
                articuloMasCaro = articulo
                precioMasBarato = precioArticulo
                articuloMasBarato = articulo
                primerArticulo = False
                mismoprecio = False
            ElseIf precioArticulo > precioMasCaro Then
                precioMasCaro = precioArticulo
                articuloMasCaro = articulo
                mismoprecio = False
                articulosMasCaros = 1
            ElseIf precioArticulo = precioMasCaro Then
                articulosMasCaros += 1
                mismoprecio = True
            ElseIf precioArticulo < precioMasBarato Then
                precioMasBarato = precioArticulo
                articuloMasBarato = articulo

            End If

            Do
                Console.Write("¿Otro artículo (S/N)?: ")
                Console.ForegroundColor = ConsoleColor.Blue
                posX = Console.CursorLeft
                posY = Console.CursorTop
                entrada = Console.ReadLine
                Console.ResetColor()
                If Not (entrada.ToUpper = "S" OrElse entrada.ToUpper = "N") Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.SetCursorPosition((posX + entrada.Length + 1), posY)
                    Console.WriteLine("Por favor, introduce S o N")
                    Console.ResetColor()
                End If
            Loop While Not (entrada.ToUpper = "S" OrElse entrada.ToUpper = "N")

        Loop Until entrada.ToUpper = "N"
        Console.ForegroundColor = ConsoleColor.Green
        If mismoprecio Then
            Console.WriteLine("Hay " & articulosMasCaros & " artículos con el mismo precio máximo: " & precioMasCaro)
        Else
            Console.WriteLine("El artículo más caro de los " & contador & " que has introducido es " & articuloMasCaro & " con un precio de " & precioMasCaro & ".")
        End If
        Console.WriteLine("El artículo más barato es " & articuloMasBarato & " con un precio de " & precioMasBarato)
        Console.ResetColor()
    End Sub

End Module
