Module Module1
    Dim tp As Integer
    Dim Stack(0 To 9) As String
    Sub Main()
        tp = 0
        Dim MenuChoice As Integer = 999
        While MenuChoice <> 0
            Console.WriteLine("Press 1 to PUSH to STACK")
            Console.WriteLine("Press 2 to POP from STACK")
            Console.WriteLine("Press 3 Traverse STACK")
            Console.WriteLine("Press 0 to EXIT this module.")
            MenuChoice = Console.ReadLine()
            Select Case MenuChoice
                Case 1 : Push()
                Case 2 : Pop()
                Case 3 : Traverse()
                Case 0
                Case Else : Console.WriteLine("Wrong choice. Please try again.")
            End Select
        End While
    End Sub
    Sub Pop()
        If tp < 1 Then
            Console.WriteLine("Underflow")
            Exit Sub
        End If
        tp = tp - 1
        Console.WriteLine(Stack(tp))
    End Sub
    Sub Push()
        Dim newVal As String
        Console.WriteLine("Enter new Value: ")
        newVal = Console.ReadLine()
        If tp > 9 Then
            Console.WriteLine("Overflow")
            Exit Sub
        End If
        Stack(tp) = newVal
        tp = tp + 1
    End Sub
    Sub Traverse()
        For count = 9 To 0 Step -1
            Console.WriteLine(Stack(count))
        Next
    End Sub
End Module