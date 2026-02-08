Module Module1
    Sub Main()
        'Declaration of Array with 10 String Elements
        Dim QueueArray(0 To 9) As String
        Dim HeadPointer As Integer = 0
        Dim TailPointer As Integer = 0
        Dim NumberOfItems As Integer = 0
        Dim x As Integer = 0
        For x = 0 To 9
            QueueArray(x) = ""
        Next
        'Input 11 Elements | Enqueue x1 | Output Appropriate Message | Dequeue x2
        Dim statement As String = ""
        For x = 0 To 10
            Console.Write("Enter a String or Character to add in QueueArray... ")
            statement = Console.ReadLine()
            Console.WriteLine("Statement Added : " & Enqueue(QueueArray, HeadPointer, TailPointer, NumberOfItems, statement))
        Next
        Console.WriteLine(Dequeue(QueueArray, HeadPointer, TailPointer, NumberOfItems))
        Console.WriteLine(Dequeue(QueueArray, HeadPointer, TailPointer, NumberOfItems))
        For x = 0 To 9
            Console.WriteLine(QueueArray(x))
        Next
        Console.ReadKey()
    End Sub
    'Return True on Item Addition and Vice Versa
    Function Enqueue(ByRef QueueArray As Array, ByRef HeadPointer As Integer, ByRef TailPointer As Integer, ByVal NumberItems As Integer, ByVal DataToAdd As String) As Boolean
        If NumberItems = 10 Then
            Return False
        End If
        QueueArray(TailPointer) = DataToAdd
        If TailPointer >= 9 Then
            TailPointer = 0
        Else
            TailPointer = TailPointer + 1
        End If
        NumberItems = NumberItems + 1
        Return True
    End Function
    'Returns False or Next Data Item in Queue
    Function Dequeue(ByRef QueueArray As Array, ByRef HeadPointer As Integer, ByRef TailPointer As Integer, ByVal NumberItems As Integer) As String
        Dim CurrentHeadPointer As Integer
        If NumberItems = 0 Then
            Return "FALSE"
        End If
        CurrentHeadPointer = HeadPointer
        If HeadPointer >= 9 Then
            HeadPointer = 0
        Else
            HeadPointer = HeadPointer + 1
        End If
        NumberItems = NumberItems - 1
        Return QueueArray(CurrentHeadPointer)
    End Function
End Module
