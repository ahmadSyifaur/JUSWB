
Public Class SecuritySubform

    Private Sub SecuritySubform_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_administrator_level.Text = My.Settings.level_Administration
        tb_SettingsManagement_level.Text = My.Settings.level_SettingsManagement

        tb_transactionList_level.Text = My.Settings.level_Administration_TransactionList
        tb_transporter_level.Text = My.Settings.level_Administration_Transporter
        tb_product_level.Text = My.Settings.level_Administration_Product
        tb_vehicle_level.Text = My.Settings.level_Administration_Vehicle
        tb_operator_level.Text = My.Settings.level_Administration_Operator
        tb_customer_level.Text = My.Settings.level_Administration_Customer

        tb_generalSettings_level.Text = My.Settings.level_SettingsManagement_General
        tb_application_level.Text = My.Settings.level_SettingsManagement_Application
        tb_reports_level.Text = My.Settings.level_SettingsManagement_Reports
        tb_security_level.Text = My.Settings.level_SettingsManagement_Security
        tb_database_level.Text = My.Settings.level_SettingsManagement_Database

        tb_transaction_create_level.Text = My.Settings.level_Administration_TransactionList_Create
        tb_transaction_edit_level.Text = My.Settings.level_Administration_TransactionList_Edit
        tb_transaction_delete_level.Text = My.Settings.level_Administration_TransactionList_Delete
        tb_transaction_backup_level.Text = My.Settings.level_Administration_TransactionList_Backup
        tb_transaction_restore_level.Text = My.Settings.level_Administration_TransactionList_Restore

        tb_database_backup_level.Text = My.Settings.level_SettingsManagement_Database_Backup
        tb_database_restore_level.Text = My.Settings.level_SettingsManagement_Database_Restore
    End Sub

    Public Function Save()

        My.Settings.level_Administration = tb_administrator_level.Text
        My.Settings.level_SettingsManagement = tb_SettingsManagement_level.Text

        My.Settings.level_Administration_TransactionList = tb_transactionList_level.Text
        My.Settings.level_Administration_Transporter = tb_transporter_level.Text
        My.Settings.level_Administration_Product = tb_product_level.Text
        My.Settings.level_Administration_Vehicle = tb_vehicle_level.Text
        My.Settings.level_Administration_Operator = tb_operator_level.Text
        My.Settings.level_Administration_Customer = tb_customer_level.Text

        My.Settings.level_SettingsManagement_General = tb_generalSettings_level.Text
        My.Settings.level_SettingsManagement_Application = tb_application_level.Text
        My.Settings.level_SettingsManagement_Reports = tb_reports_level.Text
        My.Settings.level_SettingsManagement_Security = tb_security_level.Text
        My.Settings.level_SettingsManagement_Database = tb_database_level.Text

        My.Settings.level_Administration_TransactionList_Create = tb_transaction_create_level.Text
        My.Settings.level_Administration_TransactionList_Edit = tb_transaction_edit_level.Text
        My.Settings.level_Administration_TransactionList_Delete = tb_transaction_delete_level.Text
        My.Settings.level_Administration_TransactionList_Backup = tb_transaction_backup_level.Text
        My.Settings.level_Administration_TransactionList_Restore = tb_transaction_restore_level.Text

        My.Settings.level_SettingsManagement_Database_Backup = tb_database_backup_level.Text
        My.Settings.level_SettingsManagement_Database_Restore = tb_database_restore_level.Text

        My.Settings.Save()
    End Function

    'GENERAL
    'Administration
    Private Sub btn_administration_level_plus_Click(sender As Object, e As EventArgs) Handles btn_administration_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_administrator_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_administrator_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_administration_level_min_Click(sender As Object, e As EventArgs) Handles btn_administration_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_administrator_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_administrator_level.Text = levelValue.ToString()
        End If
    End Sub
    'Settings And Management
    Private Sub btn_settings_level_plus_Click(sender As Object, e As EventArgs) Handles btn_settings_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_SettingsManagement_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_SettingsManagement_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_settings_level_min_Click(sender As Object, e As EventArgs) Handles btn_settings_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_SettingsManagement_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_SettingsManagement_level.Text = levelValue.ToString()
        End If
    End Sub

    'ADMINISTRATION
    'TransactionList
    Private Sub btn_transactionList_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transactionList_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transactionList_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_transactionList_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transactionList_level_min_Click(sender As Object, e As EventArgs) Handles btn_transactionList_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transactionList_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transactionList_level.Text = levelValue.ToString()
        End If
    End Sub
    'Transporter
    Private Sub btn_transporter_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transporter_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transporter_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_transporter_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transporter_level_min_Click(sender As Object, e As EventArgs) Handles btn_transporter_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transporter_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transporter_level.Text = levelValue.ToString()
        End If
    End Sub
    'Product
    Private Sub btn_product_level_plus_Click(sender As Object, e As EventArgs) Handles btn_product_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_product_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_product_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_product_level_min_Click(sender As Object, e As EventArgs) Handles btn_product_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_product_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_product_level.Text = levelValue.ToString()
        End If
    End Sub
    'Vehicle
    Private Sub btn_vehicle_level_plus_Click(sender As Object, e As EventArgs) Handles btn_vehicle_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_vehicle_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_vehicle_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_vehicle_level_min_Click(sender As Object, e As EventArgs) Handles btn_vehicle_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_vehicle_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_vehicle_level.Text = levelValue.ToString()
        End If
    End Sub
    'Operator
    Private Sub btn_operator_level_plus_Click(sender As Object, e As EventArgs) Handles btn_operator_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_operator_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_operator_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_operator_level_min_Click(sender As Object, e As EventArgs) Handles btn_operator_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_operator_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_operator_level.Text = levelValue.ToString()
        End If
    End Sub
    'Customer
    Private Sub btn_customer_level_plus_Click(sender As Object, e As EventArgs) Handles btn_customer_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_customer_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_customer_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_customer_level_min_Click(sender As Object, e As EventArgs) Handles btn_customer_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_customer_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_customer_level.Text = levelValue.ToString()
        End If
    End Sub

    'SETTINGS MANAGEMENT
    'General Settings
    Private Sub btn_generalSettings_level_plus_Click(sender As Object, e As EventArgs) Handles btn_generalSettings_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_generalSettings_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_generalSettings_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_generalSettings_level_min_Click(sender As Object, e As EventArgs) Handles btn_generalSettings_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_generalSettings_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_generalSettings_level.Text = levelValue.ToString()
        End If
    End Sub
    'Application
    Private Sub btn_application_level_plus_Click(sender As Object, e As EventArgs) Handles btn_application_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_application_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_application_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_application_level_min_Click(sender As Object, e As EventArgs) Handles btn_application_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_application_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_application_level.Text = levelValue.ToString()
        End If
    End Sub
    'Reports
    Private Sub btn_reports_level_plus_Click(sender As Object, e As EventArgs) Handles btn_reports_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_reports_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_reports_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_reports_level_min_Click(sender As Object, e As EventArgs) Handles btn_reports_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_reports_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_reports_level.Text = levelValue.ToString()
        End If
    End Sub
    'Security
    Private Sub btn_security_level_plus_Click(sender As Object, e As EventArgs) Handles btn_security_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_security_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_security_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_security_level_min_Click(sender As Object, e As EventArgs) Handles btn_security_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_security_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_security_level.Text = levelValue.ToString()
        End If
    End Sub
    'Database
    Private Sub btn_database_level_plus_Click(sender As Object, e As EventArgs) Handles btn_database_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_database_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_database_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_database_level_min_Click(sender As Object, e As EventArgs) Handles btn_database_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_database_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_database_level.Text = levelValue.ToString()
        End If
    End Sub

    'Transaction List
    'Create
    Private Sub btn_transactionList_create_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transactionList_create_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_create_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_transaction_create_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transactionList_create_level_min_Click(sender As Object, e As EventArgs) Handles btn_transactionList_create_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_create_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transaction_create_level.Text = levelValue.ToString()
        End If
    End Sub
    'Edit
    Private Sub btn_transactionList_edit_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transactionList_edit_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_edit_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_transaction_edit_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transactionList_edit_level_min_Click(sender As Object, e As EventArgs) Handles btn_transactionList_edit_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_edit_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transaction_edit_level.Text = levelValue.ToString()
        End If
    End Sub
    'Delete
    Private Sub btn_transactionList_delete_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transactionList_delete_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_delete_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_transaction_delete_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transactionList_delete_level_min_Click(sender As Object, e As EventArgs) Handles btn_transactionList_delete_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_delete_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transaction_delete_level.Text = levelValue.ToString()
        End If
    End Sub
    'Backup
    Private Sub btn_transactionList_backup_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transactionList_backup_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_backup_level.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_transaction_backup_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transactionList_backup_level_min_Click(sender As Object, e As EventArgs) Handles btn_transactionList_backup_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_backup_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transaction_backup_level.Text = levelValue.ToString()
        End If
    End Sub
    'Restore
    Private Sub btn_transactionList_restore_level_min_Click(sender As Object, e As EventArgs) Handles btn_transactionList_restore_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_restore_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transaction_restore_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_transactionList_restore_level_plus_Click(sender As Object, e As EventArgs) Handles btn_transactionList_restore_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_transaction_restore_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_transaction_restore_level.Text = levelValue.ToString()
        End If
    End Sub

    'DATABASE
    'Backup
    Private Sub btn_database_backup_level_plus_Click(sender As Object, e As EventArgs) Handles btn_database_backup_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_database_backup_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_database_backup_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_database_backup_level_min_Click(sender As Object, e As EventArgs) Handles btn_database_backup_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_database_backup_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_database_backup_level.Text = levelValue.ToString()
        End If
    End Sub
    'Restore
    Private Sub btn_database_restore_level_plus_Click(sender As Object, e As EventArgs) Handles btn_database_restore_level_plus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_database_restore_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_database_restore_level.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_database_restore_level_min_Click(sender As Object, e As EventArgs) Handles btn_database_restore_level_min.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_database_restore_level.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_database_restore_level.Text = levelValue.ToString()
        End If
    End Sub

End Class