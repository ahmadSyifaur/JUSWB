Public Class SecurityForm
    Dim subForm As New SecuritySubform
    Private Sub SecurityForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        subForm.TopLevel = False
        subForm.TopMost = True
        PanelContent.Controls.Add(subForm)
        subForm.Show()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        subForm.Save()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        subForm.TopLevel = False
        subForm.TopMost = True
        PanelContent.Controls.Add(subForm)
        subForm.Show()
    End Sub
End Class