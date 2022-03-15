Public Class MainForm

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MainMenu.Show()'
        Dim fMainMenu = New MainMenu()
        fMainMenu.TopLevel = False
        fMainMenu.TopMost = True
        MainPanel.Controls.Add(fMainMenu)
        fMainMenu.Show()
    End Sub
End Class