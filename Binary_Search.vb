Module Module1
    Dim Nums = {22, 25, 31, 32, 37, 39, 42, 47, 75, 101}
    Sub Main()
        'Binary Search
        Dim lower = 0, upper = 9, middle = 0, val = 0
        Dim found As Boolean = False
        Console.WriteLine("Enter a Number to Search in Nums(Array)")
        val = Console.ReadLine()
        While upper >= lower And found = False
            middle = upper + lower / 2
            If Nums(middle) = val Then
                found = True
            ElseIf val > Nums(middle) Then
                lower = middle + 1
            ElseIf val < Nums(middle) Then
                upper = middle - 1
            End If
        End While
        If found = True Then
            Console.WriteLine("Value Found")
        Else
            Console.WriteLine("Value NOT Found")
        End If
        Console.ReadKey()
    End Sub

End Module
