Imports System.Text
Public Class Form1
    Dim id As String
    Private Sub tb_ID_TextChanged(sender As Object, e As EventArgs) Handles tb_ID.TextChanged
        id = tb_ID.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s = Date.Now.ToString(tb_formatString.Text)
        Dim builder As New StringBuilder(s)
        builder.Replace("#", tb_ID.Text)
        lbl_String.Text = builder.ToString
    End Sub
End Class