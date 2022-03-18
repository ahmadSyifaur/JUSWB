Public Class MainMenu
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click

    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Close()
        Dim fAdmin = New AdministrationForm()
        fAdmin.TopLevel = False
        fAdmin.TopMost = True
        MainForm.MainPanel.Controls.Add(fAdmin)
        fAdmin.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_username.Text = MainForm.username
    End Sub
End Class