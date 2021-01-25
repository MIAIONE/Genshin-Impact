Public Class RandomProbability
    Public Shared Function GetGUIDHash() As Double
        Return Guid.NewGuid.GetHashCode / 10000000000000
    End Function
    Public Shared Function GetTimeStamp() As Double
        Return (New DateTimeOffset(Date.Now).ToUnixTimeMilliseconds)
    End Function
    Public Shared Function GetRndIngeger() As Integer
        Return (New Random(GetGUIDHash).Next(0, 9))
    End Function
    Public Shared Function GetRndDouble() As Double
        Return (New Random(GetGUIDHash).NextDouble)
    End Function
    Public Shared Function GetRandom() As Double
        Dim Ts As Double = GetTimeStamp()
        Dim base As Double = -1
        While (base <= 0) Or (base >= 1) Or (base.ToString.Length <= 17) Or (base.ToString.Length > 18)
            base = (Ts) + 0.1
            base += (GetRndDouble()) * 0.000001 * Rnd()
            base += (GetRndDouble()) + (GetGUIDHash() / 100000000000)
            base -= (GetRndDouble()) * (Rnd() / 100) + (GetRndDouble())
            base -= Rnd() * 10 * (Ts) - 0.1
            base = base / 100000000000
        End While
        Return base
    End Function

End Class
