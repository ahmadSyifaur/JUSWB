Public Class SettingForm
    Public subForm As New Form()

    Private Sub AdministrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_username.Text = MainForm.USERNAME
    End Sub

    Private Sub btn_general_Click(sender As Object, e As EventArgs) Handles btn_general.Click
        subForm.Dispose()
        subForm = TransporterForm
        subForm.TopLevel = False
        subForm.TopMost = True
        Content.Controls.Add(subForm)
        subForm.Show()

    End Sub

    Private Sub btn_application_Click(sender As Object, e As EventArgs) Handles btn_application.Click
        subForm.Dispose()
        subForm = ProductForm
        subForm.TopLevel = False
        subForm.TopMost = True
        Content.Controls.Add(subForm)
        subForm.Show()
    End Sub

    Private Sub btn_backToMain_Click(sender As Object, e As EventArgs) Handles btn_backToMain.Click
        subForm.Close()
        Me.Close()
        Dim fMain = MainForm
        Dim fMainMenu = MainMenu
        fMainMenu.TopLevel = False
        fMainMenu.TopMost = True
        fMain.MainPanel.Controls.Add(fMainMenu)
        fMainMenu.Show()
    End Sub

    Private Sub btn_security_Click(sender As Object, e As EventArgs) Handles btn_security.Click
        subForm.Dispose()
        subForm = SecurityForm
        subForm.TopLevel = False
        subForm.TopMost = True
        Content.Controls.Add(subForm)
        subForm.Show()
    End Sub
End Class