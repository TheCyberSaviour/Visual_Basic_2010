Module Module1
    Sub Main()
        Dim digit As Integer
        Console.WriteLine("Enter a Number to make Square...")
        digit = Console.ReadLine()
        Console.WriteLine("---------------------------------------")
        Call Square(digit)
        Console.ReadKey()
    End Sub
    Sub Square(ByVal Num As Integer)
        Dim count As Integer = 0
        Dim mychar As Char = ""
        Dim instring, outstring As String
        Const Filler = "*"
        instring = ""
        mychar = CStr(Num)
        For count = 1 To Num   'For First Line Only
            instring = instring & mychar
        Next
        outstring = mychar
        For count = 1 To Num - 2   'For Second Line and Onwards
            outstring = outstring & Filler
        Next
        outstring = outstring & mychar
        '---------------------------------------'
        Console.WriteLine(instring)   'Output First Line
        For count = 1 To Num - 2   'Output Second Line and Onwards
            Console.WriteLine(outstring)
        Next
        If Num > 1 Then   'Output Last Line if Num > 1
            Console.WriteLine(instring)
        End If
    End Sub
End Module
