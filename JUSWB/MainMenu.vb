Imports System.Data.SQLite
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class MainMenu
    Public Property DB_Path As String
    Dim TableName As String = "transaction"
    Dim username As String = MainForm.USERNAME
    Dim rowSelected As Boolean
    Dim todaysdate As String = Now
    Dim first_weight, second_weight, netto As Integer
    Dim transaction_id, transporter_id, vehicle_id, customer_id, product_id, remark, driver_name, first_dateTime, first_weight_unit, second_dateTime, second_weight_unit, first_operator, second_operator, transaction_updatedAt, transaction_createdAt As String

    'BUTTON SHOW
    Private Sub btn_showVehicle_Click(sender As Object, e As EventArgs) Handles btn_showVehicle.Click
        Dim show = New ShowTableForm(Me)
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id, vehicle_number, transporter_id FROM vehicle order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)

            Dim DS As New DataTable()
            adapter.Fill(DS)
            'show.DataGridViewTable.DataSource = DS

            Dim name(DS.Columns.Count) As String
            Dim i As Integer = 0
            For Each column As DataColumn In DS.Columns
                show.ComboBox_field.Items.Add(column.ColumnName)
                i += 1
            Next

            show.DT = DS
            show.BUTTON = "VEHICLE"
            show.ShowDialog(Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub btn_showTransporter_Click(sender As Object, e As EventArgs) Handles btn_showTransporter.Click
        Dim show = New ShowTableForm(Me)
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id, transporter_code, name FROM transporter order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)

            Dim DS As New DataTable()
            adapter.Fill(DS)
            'show.DataGridViewTable.DataSource = DS

            Dim name(DS.Columns.Count) As String
            Dim i As Integer = 0
            For Each column As DataColumn In DS.Columns
                Show.ComboBox_field.Items.Add(column.ColumnName)
                i += 1
            Next

            Show.DT = DS
            Show.BUTTON = "TRANSPORTER"
            Show.ShowDialog(Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub btn_showCustomer_Click(sender As Object, e As EventArgs) Handles btn_showCustomer.Click
        Dim show = New ShowTableForm(Me)
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id, customer_code, name FROM customer order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)

            Dim DS As New DataTable()
            adapter.Fill(DS)
            'show.DataGridViewTable.DataSource = DS

            Dim name(DS.Columns.Count) As String
            Dim i As Integer = 0
            For Each column As DataColumn In DS.Columns
                Show.ComboBox_field.Items.Add(column.ColumnName)
                i += 1
            Next

            Show.DT = DS
            Show.BUTTON = "CUSTOMER"
            Show.ShowDialog(Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub btn_showProduct_Click(sender As Object, e As EventArgs) Handles btn_showProduct.Click
        Dim show = New ShowTableForm(Me)
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id, product_code, name FROM product order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)

            Dim DS As New DataTable()
            adapter.Fill(DS)
            'show.DataGridViewTable.DataSource = DS

            Dim name(DS.Columns.Count) As String
            Dim i As Integer = 0
            For Each column As DataColumn In DS.Columns
                Show.ComboBox_field.Items.Add(column.ColumnName)
                i += 1
            Next

            Show.DT = DS
            Show.BUTTON = "PRODUCT"
            Show.ShowDialog(Me)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

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

        DB_Path = "Data Source=" & Application.StartupPath & "\juswbdatabase.db;"
        fillComboBoxTransporter()
        fillComboBoxVehicle()
        fillComboBoxProduct()
        fillComboBoxCustomer()
        fillComboUnit()
        ComboBox_1unit.SelectedValue = My.Settings.Unit
        ComboBox_2unit.SelectedValue = My.Settings.Unit

        Group_2ndWeigh.Enabled = False


    End Sub

    'Fill ComboBox
    Private Sub fillComboBoxTransporter()
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id,transporter_code FROM transporter order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)
            Dim DS As New DataTable()

            adapter.Fill(DS)
            ComboBox_transporter.DataSource = DS
            ComboBox_transporter.DisplayMember = "transporter_code"
            ComboBox_transporter.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub fillComboUnit()
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT * FROM units order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)
            Dim DS As New DataTable()

            adapter.Fill(DS)
            ComboBox_1unit.DataSource = DS
            ComboBox_1unit.DisplayMember = "Unit"
            ComboBox_1unit.ValueMember = "code"

            ComboBox_2unit.DataSource = DS
            ComboBox_2unit.DisplayMember = "Unit"
            ComboBox_2unit.ValueMember = "code"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub fillComboBoxVehicle()
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id,vehicle_number FROM vehicle order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)
            Dim DS As New DataTable()

            adapter.Fill(DS)
            ComboBox_vehicle.DataSource = DS
            ComboBox_vehicle.DisplayMember = "vehicle_number"
            ComboBox_vehicle.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub fillComboBoxCustomer()
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id,customer_code FROM customer order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)
            Dim DS As New DataTable()

            adapter.Fill(DS)
            ComboBox_customer.DataSource = DS
            ComboBox_customer.DisplayMember = "customer_code"
            ComboBox_customer.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub
    Private Sub fillComboBoxProduct()
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim Command As New SQLiteCommand("SELECT id,product_code FROM product order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)
            Dim DS As New DataTable()

            adapter.Fill(DS)
            ComboBox_product.DataSource = DS
            ComboBox_product.DisplayMember = "product_code"
            ComboBox_product.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    'Sub to write to the database
    Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        MainForm.Hide()
    End Sub

    Private Sub save_Record(sender As Object, e As EventArgs)
        If ComboBox_customer.Text = "" Then
            MessageBox.Show("Customer has not been filled, please fill in Customer Code", "Failed")
            Return
        End If
        If ComboBox_vehicle.Text = "" Then
            MessageBox.Show("Vehicle has not been filled, please fill in Vehicle Code", "Failed")
            Return
        End If
        If ComboBox_transporter.Text = "" Then
            MessageBox.Show("Transporter has not been filled, please fill in Transporter Code", "Failed")
            Return
        End If
        If ComboBox_product.Text = "" Then
            MessageBox.Show("Product has not been filled, please fill in Product Code", "Failed")
            Return
        End If
        If tb_driverName.Text = "" Then
            MessageBox.Show("Driver name has not been filled, please fill in Driver Name", "Failed")
            Return
        End If

        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            ExecuteNonQuery("
                INSERT INTO " & TableName & " 
                    (RecNo,
                    vehicle_id,
                    customer_id,
                    product_id,
                    transporter_id,
                    remark,
                    driver_name,
                    weigh_1,
                    weigh_unit_1,
                    datetime_1,
                    created_at,
                    updated_at,
                    operator1,
                    updated_by)
                VALUES ('" & tb_Ticket.Text & "',
                '" & ComboBox_vehicle.SelectedValue & "',
                '" & ComboBox_customer.SelectedValue & "',
                '" & ComboBox_product.SelectedValue & "',
                '" & ComboBox_transporter.SelectedValue & "',
                '" & tb_remark & "',
                '" & tb_driverName & "',
                '" & tb_weight1 & "',
                '" & ComboBox_1unit & "',
                '" & tb_date1 & "',
                '" & todaysdate & "',
                '" & todaysdate & "',
                '" & username & "')
                ", SQLiteCon)
            MsgBox("Insert Data successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        'btn_refresh_Click(sender, e)
        'ButtonClear_Click(sender, e)
        'PanelInput.Hide()
    End Sub

End Class