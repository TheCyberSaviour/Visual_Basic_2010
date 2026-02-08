Module Module1
    'Input 5 Integer Numbers and Output the *Largest Number*, *Sum* and their *Average* Excluding the largest number 
    Sub Main()
        Dim lval As Integer = -10000
        Dim sum As Integer = 0
        Dim num As Integer = 0
        Dim avg As Single = 0.0
        For x = 1 To 5
            Console.WriteLine("Enter a Integer Value : ")
            num = Console.ReadLine()
            If num > lval Then
                lval = num
            End If
            sum = sum + num
        Next
        avg = sum - lval
        avg = avg / 2
        Console.WriteLine("---------------------------")
        Console.WriteLine("Largest Value Entered : " & lval)
        Console.WriteLine("Sum : " & sum)
        Console.WriteLine("Avg : " & avg)
        Console.ReadKey()
    End Sub

End Module
