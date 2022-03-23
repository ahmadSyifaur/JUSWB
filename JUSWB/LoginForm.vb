Imports System.Data.SQLite
Imports FontAwesome.Sharp
Public Class LoginForm
    Private connectionString As String = String.Empty
    'Public Shared ACCESS_USERNAME As String = String.Empty
    'Public Shared ACCESS_LEVEL As Integer = 16
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

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Application.Exit()
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If isUserValid(tb_username.Text.Trim, tb_password.Text.Trim) Then
            MessageBox.Show("Good User, Access granted!", "Success")
            MainForm.Show()
            Me.Close()
        ElseIf tb_username.Text = My.Settings.FullAccess_User And tb_password.Text = My.Settings.FullAccess_Pass Then
            MessageBox.Show("Full Access User, Access Granted!", "Success")
            MainForm.USERNAME = My.Settings.FullAccess_User
            MainForm.ACCESS_VALUE = My.Settings.FullAccess_level
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

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        connectionString = "Data Source=" & Application.StartupPath & "\juswbdatabase.db;"
    End Sub

    Private Function isUserValid(username As String, password As String) As Boolean
        Dim isValidUser As Boolean = False
        Dim userInfo As DataRow = Nothing
        Dim sql As String = "SELECT * FROM operator WHERE username = @username"

        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            userInfo = dt.Rows(0)
                            If DecryptData(userInfo("password")).Equals(password) Then
                                isValidUser = True
                                MainForm.USERNAME = userInfo("username")
                                MainForm.ACCESS_VALUE = userInfo("access_level")
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return isValidUser
    End Function


End Class
