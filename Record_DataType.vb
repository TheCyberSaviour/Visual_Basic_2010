Module Module1
    Structure weather
        Dim city As String
        Dim temp As Integer
        Dim humid As Integer
        Dim raining As Boolean
    End Structure
    Sub Main()
        Dim wtrec(2) As weather
        Dim i As Integer
        Dim high_temp_city As String = ""
        For i = 0 To 2
            Console.WriteLine("Enter City...")
            wtrec(i).city = Console.ReadLine()

            Console.WriteLine("Enter Temperature...")
            wtrec(i).temp = Console.ReadLine()

            Console.WriteLine("Enter Humidity...")
            wtrec(i).humid = Console.ReadLine()

            Console.WriteLine("Raining or Not Raining...(True/False)")
            wtrec(i).raining = Console.ReadLine()
        Next
        For i = 0 To 2
            If wtrec(i).temp >= 30 Then
                high_temp_city = wtrec(i).city
                Console.WriteLine("City with temperature equal to or more than 30 degree celsius, " & high_temp_city)
            End If
        Next
        Console.ReadKey()
    End Sub
End Module
