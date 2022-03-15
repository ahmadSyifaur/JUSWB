Public Class AdministrationForm
    Public subForm As New Form()
    Private Sub TransporterForm_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        MainForm.Show()
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
        subForm.Hide()
        Me.Hide()
        Dim fMain = MainForm
        Dim fMainMenu = MainMenu
        fMainMenu.TopLevel = False
        fMainMenu.TopMost = True
        fMain.MainPanel.Controls.Add(fMainMenu)
        fMainMenu.Show()
    End Sub
End Class