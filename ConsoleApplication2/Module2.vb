Module Module2

    Sub Main()
        Dim weight, hight As String
        Console.Write("請輸入身高 :")
        weight = Console.ReadLine()
        Console.Write("請輸入體重 :")
        hight = Console.ReadLine()
        Console.ReadLine()

        Dim BMI = weight / (hight * hight)
        Console.WriteLine("BMI為" & BMI)

    End Sub

End Module
