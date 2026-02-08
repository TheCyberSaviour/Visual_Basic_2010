Module Module1
    'Concate and Caps First Charecter'
    Function caps(ByVal mystring As String) As String
        Dim outstring As String
        Dim char1, char2 As Char
        Dim x As Integer
        outstring = " "
        For x = 1 To Len(mystring)
            char1 = Mid(mystring, x, 1)
            If x = 1 Then
                char1 = UCase(char1)
                outstring = outstring & char1
            ElseIf char1 = " " Then
                char2 = UCase(Mid(mystring, x + 1, 1))
                outstring = outstring & char2
                x = x + 1
            Else : outstring = outstring & char1
            End If
        Next
        Return outstring
    End Function
    Sub Main()
        Dim data As String
        data = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("Caps Data")
        Console.WriteLine()
        Console.Write(caps(data))
        Console.ReadKey()
    End Sub

End Module
