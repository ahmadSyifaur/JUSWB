Public Class MainForm
    Public Shared username As String
    Private Sub btn_login_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MainMenu.Show()'
        Dim fMainMenu = New MainMenu()
        username = LoginForm1.tb_username.Text
        fMainMenu.TopLevel = False
        fMainMenu.TopMost = True
        MainPanel.Controls.Add(fMainMenu)
        fMainMenu.Show()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class