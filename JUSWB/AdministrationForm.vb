Public Class AdministrationForm
    Public subForm As New Form()

    Private Sub AdministrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_username.Text = MainForm.username
    End Sub

    Private Sub btn_transporter_Click(sender As Object, e As EventArgs) Handles btn_transporter.Click
        subForm.Dispose()
        subForm = TransporterForm
        subForm.TopLevel = False
        subForm.TopMost = True
        Content.Controls.Add(subForm)
        subForm.Show()

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        subForm.Dispose()
        subForm = ProductForm
        subForm.TopLevel = False
        subForm.TopMost = True
        Content.Controls.Add(subForm)
        subForm.Show()
    End Sub

    Private Sub btn_vehicle_Click(sender As Object, e As EventArgs) Handles btn_vehicle.Click
        subForm.Dispose()
        subForm = VehicleForm
        subForm.TopLevel = False
        subForm.TopMost = True
        Content.Controls.Add(subForm)
        subForm.Show()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        subForm.Dispose()
        subForm = CustomerForm
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

End Class