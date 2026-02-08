Module Module1

    Sub Main()
        Dim Names(0 To 9)
        Dim name As String = ""

        FileOpen(1, "C:\Users\mhass\OneDrive\Documents\VisualBasic Programs\VB_Filing\Names.txt", OpenMode.Output)

        For x = 0 To 9
            Console.WriteLine("What's your name beautiful person (0_0)")
            name = Console.ReadLine()
            If name = "" Then
                Names(x) = "HACKER"
                WriteLine(1, Names(x))
            Else
                Names(x) = name
                WriteLine(1, Names(x))
            End If
        Next
        FileClose(1)
        Console.WriteLine("FILE CREATED")
        Console.ReadKey()
    End Sub

End Module
