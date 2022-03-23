Public Class AdministrationForm
    Public subForm As New Form()

    Private Sub AdministrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbl_username.Text = MainForm.username
    End Sub

    Private Sub btn_transporter_Click(sender As Object, e As EventArgs) Handles btn_transporter.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_Administration_Transporter Then
            subForm.Dispose()
            subForm = TransporterForm
            subForm.TopLevel = False
            subForm.TopMost = True
            Content.Controls.Add(subForm)
            subForm.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_Administration_Product Then
            subForm.Dispose()
            subForm = ProductForm
            subForm.TopLevel = False
            subForm.TopMost = True
            Content.Controls.Add(subForm)
            subForm.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_vehicle_Click(sender As Object, e As EventArgs) Handles btn_vehicle.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_Administration_Vehicle Then
            subForm.Dispose()
            subForm = VehicleForm
            subForm.TopLevel = False
            subForm.TopMost = True
            Content.Controls.Add(subForm)
            subForm.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_Administration_Customer Then
            subForm.Dispose()
            subForm = CustomerForm
            subForm.TopLevel = False
            subForm.TopMost = True
            Content.Controls.Add(subForm)
            subForm.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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

    Private Sub btn_operator_Click(sender As Object, e As EventArgs) Handles btn_operator.Click
        If MainForm.ACCESS_VALUE >= My.Settings.level_Administration_Operator Then
            subForm.Dispose()
            subForm = OperatorForm
            subForm.TopLevel = False
            subForm.TopMost = True
            Content.Controls.Add(subForm)
            subForm.Show()
        Else
            MessageBox.Show("Sorry, You do not have permission!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class