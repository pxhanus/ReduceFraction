'Patricia Hanus
'151117
'ReduceFraction
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnReduce_Click(sender As Object, e As EventArgs) Handles btnReduce.Click
        Dim numerator As Integer = Val(Me.txtNumerator.Text)
        Dim denominator As Integer = Val(Me.txtDenominator.Text)
        Dim reduceNum As Integer
        Dim reduceDenom As Integer
        Dim temp As Integer = Val(Me.txtDenominator.Text)

        Call Reduce(numerator, denominator, reduceNum, reduceDenom, temp)

        Me.lblReduced.Text = numerator & "/" & denominator & " is reduced to " & reduceNum & "/" & reduceDenom
    End Sub
    '********************************************************************************************
    'Reduce
    'Finds greatest common denominator
    '
    'post: returns reduced numerator and denominator
    '********************************************************************************************
    Sub Reduce(ByVal numerator As Integer, ByVal demoninator As Integer, ByRef reduceNum As Integer, _
               ByRef reduceDenom As Integer, ByRef temp As Integer)

        Do Until (numerator Mod temp) = 0 And (demoninator Mod temp) = 0
            temp -= 1
        Loop

        reduceNum = numerator / temp
        reduceDenom = demoninator / temp

    End Sub
End Class