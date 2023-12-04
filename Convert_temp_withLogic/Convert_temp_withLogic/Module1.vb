Module Module1
    'This project takes the users Input of fahrenheit and converts it to celsius.

    Sub Main()
        Dim dblF, dblC As Double
        dblF = Get_Data()
        dblC = CalcCelc(dblF)
        DisplayResults(dblF, dblC)
    End Sub

    Function Get_Data() As Double

        Dim dblFGet As Double
        dblFGet = Convert.ToDouble(InputBox("Enter The Fahrenheit: "))
        Return dblFGet
    End Function

    Function CalcCelc(ByVal DoubleFTemp As Double) As Double
        Dim dblCtemp As Double
        dblCtemp = (DoubleFTemp - 32) * (5 / 9)
        Return dblCtemp
    End Function

    Sub DisplayResults(ByVal DoubleF As Double, ByVal DoubleC As Double)
        Console.WriteLine("Fahrenheit: " & DoubleF & " Celsius: " & DoubleC)
    End Sub







End Module
