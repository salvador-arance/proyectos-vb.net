Module Module1

    Sub Main()
        Dim palabras(4) As String
        Dim i As Integer = 0

        Do
            Console.Write("palabra " & i + 1 & ": ")
            palabras(i) = Console.ReadLine
            i += 1
        Loop Until i = palabras.Length

        i = 0

        Do
            Console.WriteLine("palabra " & i + 1 & ": " & palabras(i))
            i += 1
        Loop Until i = palabras.Length


    End Sub

End Module
