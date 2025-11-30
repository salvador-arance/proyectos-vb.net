Imports System

Module Program
    Sub Main()
        Dim x, y, z As Integer

        x = 0
        y = 1

        Do
            Console.WriteLine(x)
            z = x + y
            x = y
            y = z
        Loop While x < 256
    End Sub
End Module
