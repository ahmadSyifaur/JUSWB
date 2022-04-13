Imports System.Security.Cryptography
Module Module1
    Private tripleDes As New TripleDESCryptoServiceProvider
    Public Function EncryptData(ByVal plainText As String) As String
        Return Convert.ToBase64String(New System.Text.UTF32Encoding().GetBytes(plainText))
    End Function
    Public Function DecryptData(ByVal encryptedText As String) As String
        Return New System.Text.UTF32Encoding().GetString(Convert.FromBase64String(encryptedText))
    End Function

    Public Function AutoID() As String


    End Function

End Module