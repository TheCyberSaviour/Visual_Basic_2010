Module Module1
    Sub Main()
        Dim instring As String
        Console.WriteLine("Please Enter a Sentence to COUNT Vowels and Consonants:- ")
        instring = Console.ReadLine()
        Dim outstring As String
        outstring = CountVowels(instring)
        Console.WriteLine()
        Console.WriteLine(outstring)
        Console.ReadKey()
    End Sub
    Function CountVowels(ByVal InString As String) As String
        Dim countA, countE, countI, countO, countU, OtherCount As Integer
        Dim mychar As Char
        Dim outstring As String
        For x = 1 To Len(InString)
            mychar = Mid(InString, x, 1)
            If mychar = "A" Then
                countA = countA + 1
            ElseIf mychar = "E" Then
                countE = countE + 1
            ElseIf mychar = "I" Then
                countI = countI + 1
            ElseIf mychar = "O" Then
                countO = countO + 1
            ElseIf mychar = "U" Then
                countU = countU + 1
            ElseIf mychar = "a" Then
                countA = countA + 1
            ElseIf mychar = "e" Then
                countE = countE + 1
            ElseIf mychar = "i" Then
                countI = countI + 1
            ElseIf mychar = "o" Then
                countO = countO + 1
            ElseIf mychar = "u" Then
                countU = countU + 1
            ElseIf mychar = "" Then
                OtherCount = OtherCount - 1 'To Eliminate Spaces
            Else : OtherCount = OtherCount + 1
            End If
        Next
        outstring = (" A/a :" & countA & " E/e :" & countE & " I/i :" & countI & " O/o :" & countO & " U/u :" & countU & " Consonants :" & OtherCount)
        Return outstring
    End Function
End Module
