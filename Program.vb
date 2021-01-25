Imports System.IO
Public Class Program
    Public Shared Sub Main()

        AUTO()
    End Sub

    Public Shared Sub AUTO()
        For I As UInteger = 1 To 90
            Dim prt As New TreviFountain(I)
            Console.WriteLine("[" + I.ToString.PadLeft(2, "0") + "]--->" + (prt.GetProbability() * 100).ToString + "%")


            File.AppendAllLines(AppDomain.CurrentDomain.BaseDirectory + "Probability.txt", New String() {"[" + I.ToString.PadLeft(2, "0") + "]--->" + (prt.GetProbability() * 100).ToString + "%"})

        Next

        Console.ReadKey()
    End Sub
    Public Shared Sub NOAUTO()
        Console.WriteLine("#------------miHoYo Co.,Ltd------------#")
        Console.WriteLine("# [ProductName] Genshin Impact         #")
        Console.WriteLine("# [Probability] Random(Function Define)#")
        Console.WriteLine("#--------------------------------------#")

        Console.WriteLine()
        Console.WriteLine()
reuse:
        Console.WriteLine("------------------------------------------------------------")
retryp:
        Console.Write("Please enter the total number of draws since the last five-star character appeared ( 90 >= counts > 0 ) :")
        Dim usertotal As UInteger = 0
        Try
            usertotal = UInteger.Parse(Console.ReadLine)
            If (usertotal <= 0) Or (usertotal > 90) Then
                Console.WriteLine("__________Num Error! Retry!__________")
                GoTo retryp
            End If
        Catch
            Console.WriteLine("__________Num Error! Retry!__________")
            GoTo retryp
        End Try
        Dim prt As New TreviFountain(usertotal)
        Console.WriteLine("Current probability:" + (prt.GetProbability() * 100).ToString + "%")
        Console.WriteLine("Enter the next peak draw:" + (90 - usertotal).ToString)
        Console.WriteLine("------------------------------------------------------------")
        'Console.ReadKey()
        GoTo reuse
        'test()
    End Sub
    Public Shared Sub test()
        'Console.ReadKey()
        Dim NEW_DIC As New ArrayList
        For i As Long = 0 To 10000
            Dim VAL_ As Double = RandomProbability.GetRandom
            Console.WriteLine("[" + i.ToString.PadLeft(5, "0") + "] ---->  " + VAL_.ToString)
            NEW_DIC.Add(VAL_)
        Next
        Dim _1, _2, _3, _4, _5, _6, _7, _8, _9 As Double
        For Each EVERY As Double In NEW_DIC
            If (EVERY > 0) And (EVERY < 0.2) Then
                _1 += 1
            ElseIf (EVERY >= 0.2) And (EVERY < 0.3) Then
                _2 += 1
            ElseIf (EVERY >= 0.3) And (EVERY < 0.4) Then
                _3 += 1
            ElseIf (EVERY >= 0.4) And (EVERY < 0.5) Then
                _4 += 1
            ElseIf (EVERY >= 0.5) And (EVERY < 0.6) Then
                _5 += 1
            ElseIf (EVERY >= 0.6) And (EVERY < 0.7) Then
                _6 += 1
            ElseIf (EVERY >= 0.7) And (EVERY < 0.8) Then
                _7 += 1
            ElseIf (EVERY >= 0.8) And (EVERY < 0.9) Then
                _8 += 1
            ElseIf (EVERY >= 0.9) And (EVERY < 1.0) Then
                _9 += 1
            End If
        Next
        Console.WriteLine("[1]" + _1.ToString)
        Console.WriteLine("[2]" + _2.ToString)
        Console.WriteLine("[3]" + _3.ToString)
        Console.WriteLine("[4]" + _4.ToString)
        Console.WriteLine("[5]" + _5.ToString)
        Console.WriteLine("[6]" + _6.ToString)
        Console.WriteLine("[7]" + _7.ToString)
        Console.WriteLine("[8]" + _8.ToString)
        Console.WriteLine("[9]" + _9.ToString)

        Console.ReadKey()
    End Sub
End Class
