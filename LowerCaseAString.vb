Module Module1

    Sub Main()
        Dim mystring, outstring, finalstring As String
        Dim mymsmg As String
        Dim mychar1, mychar2 As Char
        Dim x As Integer
        mystring = "MuhammAd HaSSan ShaiKh"
        outstring = ""
        mymsmg = ""
        mychar1 = ""
        mychar2 = ""
        For x = 1 To Len(mystring)

            mychar1 = Mid(mystring, x, 1)
            mychar2 = LCase(mychar1)
            outstring = outstring & mychar2
        Next

        Console.WriteLine(outstring)

        Console.ReadKey()

    End Sub

End Module
