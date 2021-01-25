Public Class TreviFountain
    Private TotalCount As UInteger
    Public Sub New(cts As UInteger)
        TotalCount = cts
    End Sub

    Public Function GetProbability() As Double
        If (TotalCount <= 73) Then
            Return LowProbability()
        ElseIf (TotalCount > 73) And (TotalCount < 90) Then
            Return HighProbability()
        Else
            Return TotalProbability()
        End If
    End Function
    Private Function LowProbability() As Double
        Dim Rnds As Double = RandomProbability.GetRandom
        If Rnds >= 0.5 Then
            Return Math.Abs(0.006 - Rnds * 0.128 + (TotalCount / 100000))
        Else
            Return Math.Abs(0.006 + Rnds * 0.128 + (TotalCount / 100000))
        End If
    End Function

    Private Function HighProbability() As Double
        Return 0.006 + 0.053 * (TotalCount - 73)
    End Function

    Private Function TotalProbability() As Double
        Return 1
    End Function
End Class
