'Calvin Coxen
'RCET0265
'Fall 2020
'Roll The Dice
'https://github.com/CalvinAC/RollTheDice

Option Explicit On
Option Strict On

Module RollTheDice

    Sub Main()

        Dim dieRoll As Integer
        Dim rolls(12) As Integer
        Dim row As Integer
        Console.WriteLine("Press enter to roll two dice 1000 times, Press Q to quit")

        'allows he user to exit the program by pressing Q
        If Console.ReadKey().Key = ConsoleKey.Q Then
            Exit Sub
        End If

        'generates a random number between 2 and 12 1000 times and 
        'displays the amount of rolls per value
        Do
            Console.WriteLine("  2      3       4       5       6       7       8       9       10      11      12") 'use pad left or pad right - TJR

            For i = 1 To 1000
                dieRoll = GetRandomNumber(1, 11)
                rolls(dieRoll) += 1

            Next

            For i = 2 To 12
                Console.Write("|" & rolls(i) & "|" & vbTab)
            Next

            Console.WriteLine(vbNewLine)
            Console.WriteLine("Press enter to roll the dice again or press Q to quit")

            If Console.ReadKey().Key = ConsoleKey.Q Then
                Exit Sub
            End If

            Erase rolls
            ReDim rolls(12)
        Loop
    End Sub

    'Randomizes the numbers between 1 to 12
    Function GetRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Dim number As Single
        Randomize()
        number = CInt(Int(12 * Rnd()) + 1)
        number = ((max - min + 1) * Rnd()) + min
        Return CInt((number))

    End Function


End Module
