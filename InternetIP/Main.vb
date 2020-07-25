Imports System.Net

Public Module Main

    Sub Main()
        Console.WriteLine(GetInternetIP)
    End Sub

    Friend Function GetInternetIP() As String
        Dim W As New WebClient
        Dim ip As String = W.DownloadString("http://checkip.dyndns.org/")

        Dim pStart As Integer = ip.IndexOf("Current IP Address:") + 20
        Dim pEnd As Integer = ip.IndexOf("<", pStart)


        ip = ip.Substring(pStart, pEnd - pStart)

        Return ip
    End Function

End Module
