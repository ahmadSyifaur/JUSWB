Public Class MainMenu
    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click

    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Hide()
        Dim fAdmin = New AdministrationForm()
        fAdmin.TopLevel = False
        fAdmin.TopMost = True
        MainForm.MainPanel.Controls.Add(fAdmin)
        fAdmin.Show()
    End Sub
End Class