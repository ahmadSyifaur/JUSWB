Public Class LoginForm1
    Dim Username As String
    Dim Password As String
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    'Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
    '    Me.Close()
    'End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If tb_username.Text = My.Settings.FullAccess_User And tb_password.Text = My.Settings.FullAccess_Pass Then
            MainForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Login Failed, Please check your Username or Password!", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If tb_password.PasswordChar = "•" Then
            tb_password.PasswordChar = Nothing
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Else
            tb_password.PasswordChar = "•"
            IconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub
End Class
