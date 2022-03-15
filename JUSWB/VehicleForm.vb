Public Class VehicleForm
    Private Sub VehicleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.PanelInput.Hide()
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs)
        PanelInput.Show()
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        PanelInput.Hide()
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs)
        PanelInput.Show()
        lbl_inputTitle.Text = "UPDATE RECORD"
    End Sub

    Private Sub comboBox_tareUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_tareUnit.SelectedIndexChanged, comboBox_transporterCode.SelectedIndexChanged

    End Sub
End Class