'Calvin Coxen
'RCET0265
'Fall 2020
'Roll The Die


Option Explicit On
Option Strict On


Module RollTheDice

    Sub Main()
        Dim dieRoll As Integer
        Dim rolls(12) As Integer
        Dim row As Integer

        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If

        Do
            Console.WriteLine("Roll Of The Die")


            For i = 1 To 1000
                dieRoll = GetRandomNumber(1, 11)
                rolls(dieRoll) += 1

            Next

            For i = 2 To 12
                Console.Write(rolls(i) & "|" & vbTab)
            Next

            Console.ReadLine()
            Console.Clear()

            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If

            Erase rolls
            ReDim rolls(12)

        Loop
    End Sub

    Function GetRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim number As Single
        Randomize()
        number = CInt(Int(12 * Rnd()) + 1)
        number = ((max - min + 1) * Rnd()) + min
        Return CInt((number))

    End Function


End Module
