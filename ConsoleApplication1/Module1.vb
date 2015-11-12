Module Module1

    Sub Main()
        Dim keyword, ans, count, min, max As Integer
        count = 0
        min = 0
        max = 1000
        Dim a As New Random()
        ans = a.Next(1, 1000)
        Console.WriteLine("猜數字")
        Console.WriteLine()
        Do
            Console.Write("數字範圍  {0}< ? < {1} :", min, max)
            keyword = Val(Console.ReadLine())
            count += 1
            If keyword >= 1 And keyword < 1000 Then
                If keyword = ans Then
                    Console.WriteLine("完全正確!", ans)
                    Exit Do
                ElseIf keyword > ans Then
                    max = keyword
                    Console.Write("太大了!")
                ElseIf keyword < ans Then
                    min = keyword
                    Console.Write("太小了!")

                End If
                Console.WriteLine("你猜了 {0} 次", count)
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入數1-1000內的數字!")

            End If
        Loop While True
        Console.Read()
    End Sub

End Module
