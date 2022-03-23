Imports System.Security.Cryptography
Module Module1
    Private tripleDes As New TripleDESCryptoServiceProvider
    Public Function EncryptData(ByVal plainText As String) As String
        'Dim plainTextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plainText)
        'Dim ms As New System.IO.MemoryStream
        'Dim encStream As New CryptoStream(ms, tripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'encStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        'encStream.FlushFinalBlock()

        'Return Convert.ToBase64String(ms.ToArray)
        Return Convert.ToBase64String(New System.Text.UTF32Encoding().GetBytes(plainText))
    End Function
    Public Function DecryptData(ByVal encryptedText As String) As String
        'Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedText)
        'Dim ms As New System.IO.MemoryStream
        'Dim decStream As New CryptoStream(ms, tripleDes.CreateDecryptor(),
        '                                  System.Security.Cryptography.CryptoStreamMode.Write)

        'decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        'decStream.FlushFinalBlock()

        'Return System.Text.Encoding.Unicode.GetString(MS.ToArray)
        Return New System.Text.UTF32Encoding().GetString(Convert.FromBase64String(encryptedText))
    End Function
End Module
