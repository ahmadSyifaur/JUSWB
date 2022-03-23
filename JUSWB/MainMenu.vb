Public Class MainMenu

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_SettingsManagement Then
            Me.Close()
            Dim fSetting = New SettingForm
            fSetting.TopLevel = False
            fSetting.TopMost = True
            MainForm.MainPanel.Controls.Add(fSetting)
            fSetting.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_Administration Then
            Me.Close()
            Dim fAdmin = New AdministrationForm
            fAdmin.TopLevel = False
            fAdmin.TopMost = True
            MainForm.MainPanel.Controls.Add(fAdmin)
            fAdmin.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_username.Text = MainForm.USERNAME.ToString
        level.Text = MainForm.ACCESS_VALUE.ToString

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        MainForm.Hide()
    End Sub
End Class