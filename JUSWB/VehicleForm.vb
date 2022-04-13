Imports System.Data.SQLite
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class VehicleForm
    Dim DB_Path As String
    Dim TableName As String = "vehicle"
    Dim username As String = MainForm.username
    Dim rowSelected As Boolean
    Dim todaysdate As String = Now
    Dim IDTrans, CodeTrans, vehicle_id, vehicle_number, createdDate, expiredDate, vehicle_tare, vehicle_unit, vehicle_capacity, vehicle_useTare, vehicle_updatedBy, vehicle_updatedAt, vehicle_createdAt As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub VehicleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.PanelInput.Visible = False
        checkbox_byVehicleNumber.Checked = True

        tb_search.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.tb_search.Handle, &H1501, 0, "Search...")


        DB_Path = "Data Source=" & Application.StartupPath & "\juswbdatabase.db;"
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        fillComboBoxTransporter()
        fillComboUnit()
        tb_tare.Enabled = False
        tb_tare.Text = "0"
        comboBox_capacityUnit.SelectedValue = My.Settings.Unit
        comboBox_tareUnit.SelectedValue = My.Settings.Unit
        comboBox_capacityUnit.Enabled = False
        comboBox_tareUnit.Enabled = False

        Dim SQLiteCon As New SQLiteConnection(DB_Path)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("SELECT * FROM vehicle_view order by id", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns("vehicle_number").HeaderText = "Vehicle Number"
            DataGridViewTable.Columns("transporter_id").Visible = False
            DataGridViewTable.Columns("transporter_code").HeaderText = "Transporter Code"
            DataGridViewTable.Columns("created_date").HeaderText = "Created Date"
            DataGridViewTable.Columns("expired_date").HeaderText = "expired Date"
            DataGridViewTable.Columns("tare").HeaderText = "Tare"
            DataGridViewTable.Columns("tare_unit").HeaderText = "Tare Unit"
            DataGridViewTable.Columns("capacity").HeaderText = "Capacity"
            DataGridViewTable.Columns("capacity_unit").HeaderText = "Capacity Unit"
            DataGridViewTable.Columns("use_tare").Visible = False
            DataGridViewTable.Columns("being_weigh").Visible = False
            DataGridViewTable.Columns("updated_by").HeaderText = "Updated By"
            DataGridViewTable.Columns("created_at").HeaderText = "Created At"
            DataGridViewTable.Columns("updated_at").HeaderText = "Last Updated At"
            DataGridViewTable.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lbl_totalRecordValue.Text = TableDB.Rows.Count()
        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub

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
            Dim Command As New SQLiteCommand("SELECT id,transporter_code,name FROM transporter order by id", SQLiteCon)
            Dim adapter As New SQLiteDataAdapter(Command)
            Dim DS As New DataTable()

            adapter.Fill(DS)
            comboBox_transporterCode.DataSource = DS
            dataGridTransporter.DataSource = DS
            comboBox_transporterCode.DisplayMember = "transporter_code"
            comboBox_transporterCode.ValueMember = "id"

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
            comboBox_capacityUnit.DataSource = DS
            comboBox_capacityUnit.DisplayMember = "Unit"
            comboBox_capacityUnit.ValueMember = "code"

            comboBox_tareUnit.DataSource = DS
            comboBox_tareUnit.DisplayMember = "Unit"
            comboBox_tareUnit.ValueMember = "code"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    'Header Control
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        PanelInput.Visible = True
        tb_VehicleNumber.Text = vehicle_number
        comboBox_transporterCode.SelectedValue = IDTrans
        tb_capacity.Text = vehicle_capacity
        tb_tare.Text = vehicle_tare
        If vehicle_useTare = "1" Then
            checkBox_useTare.Checked = True
        ElseIf vehicle_useTare = "0" Then
            checkBox_useTare.Checked = False
        End If

        Dim format() = {"MM/dd/yyyy", "M/d/yyyy", "dd-MM-yyyy"}

        Dim created_date As DateTime = Date.ParseExact(createdDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None)
        Dim expired_date As DateTime = Date.ParseExact(expiredDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None)
        date_createdDate.Value = created_date
        date_expiredDate.Value = expired_date
        comboBox_capacityUnit.SelectedValue = vehicle_unit
        comboBox_tareUnit.SelectedValue = vehicle_unit

        lbl_inputTitle.Text = "UPDATE RECORD"
        btn_save.Text = "Update"
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        PanelInput.Visible = True
        tb_VehicleNumber.Clear()
        comboBox_transporterCode.Text = "- Select -"
        tb_capacity.Clear()
        checkBox_useTare.Checked = False
        Dim created_date As DateTime = Today
        Dim expired_date As DateTime = Today
        date_createdDate.Value = Today
        date_expiredDate.Value = Today
        comboBox_capacityUnit.SelectedValue = My.Settings.Unit
        comboBox_tareUnit.SelectedValue = My.Settings.Unit

        lbl_inputTitle.Text = "ADD RECORD"
        btn_save.Text = "Save"
    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If DataGridViewTable.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Failed")
            Return
        End If

        If DataGridViewTable.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Failed")
            Return
        End If

        If MsgBox("Delete record " & vehicle_number & "?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            If AllCellsSelected(DataGridViewTable) = True Then
                ExecuteNonQuery("DELETE FROM " & TableName & "", SQLiteCon)
                SQLiteCon.Close()
                SQLiteCon.Dispose()
                SQLiteCon = Nothing

                btn_refresh_Click(sender, e)
                Return
            End If

            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                If row.Selected = True Then
                    ExecuteNonQuery("delete from " & TableName & " where ID='" & vehicle_id & "'", SQLiteCon)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btn_refresh_Click(sender, e)
    End Sub

    'Input Control
    Private Sub update_Record(sender As Object, e As EventArgs)
        If tb_VehicleNumber.Text = "" Then
            MessageBox.Show("Vehicle Number has not been filled, please fill in Vehicle Number", "Failed")
            Return
        End If

        If tb_capacity.Text = "" Then
            MessageBox.Show("Capacity has not been filled, please fill in Capacity", "Failed")
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
                UPDATE " & TableName & "
                SET
                    vehicle_number = '" & tb_VehicleNumber.Text & "',
                    transporter_id = '" & comboBox_transporterCode.SelectedValue & "',
                    created_date = '" & date_createdDate.Value & "',
                    expired_date = '" & date_createdDate.Value & "',
                    tare = '" & tb_tare.Text & "',
                    tare_unit = '" & comboBox_tareUnit.SelectedValue & "',
                    capacity = '" & tb_capacity.Text & "',
                    capacity_unit = '" & comboBox_capacityUnit.SelectedValue & "',
                    updated_by = '" & username & "',
                    updated_at = '" & todaysdate & "'
                WHERE ID = '" & vehicle_id & "'
            ", SQLiteCon)
            MsgBox("Update successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btn_refresh_Click(sender, e)
        PanelInput.Hide()
    End Sub
    Private Sub save_Record(sender As Object, e As EventArgs)
        If tb_VehicleNumber.Text = "" Then
            MessageBox.Show("Vehicle Number has not been filled, please fill in Vehicle Number", "Failed")
            Return
        End If

        If tb_capacity.Text = "" Then
            MessageBox.Show("Capacity has not been filled, please fill in Capacity", "Failed")
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
                    (vehicle_number,
                    transporter_id,
                    created_date,
                    expired_date,
                    tare,
                    tare_unit,
                    capacity,
                    capacity_unit,
                    use_tare,
                    updated_by,
                    created_at,
                    updated_at)
                VALUES ('" & tb_VehicleNumber.Text & "',
                '" & comboBox_transporterCode.SelectedValue & "',
                '" & date_createdDate.Value & "',
                '" & date_expiredDate.Value & "',
                '" & tb_tare.Text & "',
                '" & comboBox_tareUnit.SelectedValue & "',
                '" & tb_capacity.Text & "',
                '" & comboBox_capacityUnit.SelectedValue & "',
                '" & vehicle_useTare & "',
                '" & username & "',
                '" & todaysdate & "',
                '" & todaysdate & "')
                ", SQLiteCon)
            MsgBox("Insert Data successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        btn_refresh_Click(sender, e)
        'ButtonClear_Click(sender, e)
        PanelInput.Hide()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        PanelInput.Visible = False
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim btn As Button = CType(sender, Button)
        If btn.Text = "Save" Then
            save_Record(sender, e)
        ElseIf btn.Text = "Update" Then
            update_Record(sender, e)
        End If
    End Sub
    Private Sub dataGridTransporter_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridTransporter.CellMouseClick
        Dim i As Integer
        With dataGridTransporter
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                rowSelected = True
                comboBox_transporterCode.SelectedValue = .Rows(i).Cells("id").Value.ToString
                PanelTransporter.Visible = False
            End If
        End With
    End Sub

    'Sub to read the database
    Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PanelTransporter.Visible = True

    End Sub

    'Table Control
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("SELECT * FROM vehicle_view order by id", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns("vehicle_number").HeaderText = "Vehicle Number"
            DataGridViewTable.Columns("transporter_id").Visible = False
            DataGridViewTable.Columns("transporter_code").HeaderText = "Transporter Code"
            DataGridViewTable.Columns("created_date").HeaderText = "Created Date"
            DataGridViewTable.Columns("expired_date").HeaderText = "expired Date"
            DataGridViewTable.Columns("tare").HeaderText = "Tare"
            DataGridViewTable.Columns("tare_unit").HeaderText = "Tare Unit"
            DataGridViewTable.Columns("capacity").HeaderText = "Capacity"
            DataGridViewTable.Columns("capacity_unit").HeaderText = "Capacity Unit"
            DataGridViewTable.Columns("use_tare").Visible = False
            DataGridViewTable.Columns("being_weigh").Visible = False
            DataGridViewTable.Columns("updated_by").HeaderText = "Updated By"
            DataGridViewTable.Columns("created_at").HeaderText = "Created At"
            DataGridViewTable.Columns("updated_at").HeaderText = "Last Updated At"
            DataGridViewTable.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchQuery As String = ""
        If tb_search.Text = Nothing Then
            btn_refresh_Click(sender, e)
        Else
            tb_search.CharacterCasing = CharacterCasing.Upper
            If checkbox_byVehicleNumber.Checked = True Then
                If tb_search.Text = Nothing Then
                    btn_refresh_Click(sender, e)
                Else
                    searchQuery = "Select * FROM vehicle_view WHERE vehicle_number like'" & tb_search.Text & "%'"
                End If
            End If

            If checkbox_byTransporterCode.Checked = True Then
                If tb_search.Text = Nothing Then
                    btn_refresh_Click(sender, e)
                Else
                    searchQuery = "Select * FROM vehicle_view WHERE transporter_code like'" & tb_search.Text & "%'"
                End If
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

            Dim TableDB As New DataTable

            Try
                LoadDB(searchQuery, TableDB, SQLiteCon)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If TableDB.Rows.Count > 0 Then
                DataGridViewTable.DataSource = Nothing
                DataGridViewTable.DataSource = TableDB
                DataGridViewTable.Columns("transporter_id").Visible = False
                DataGridViewTable.Columns("use_tare").Visible = False
                DataGridViewTable.Columns("being_weigh").Visible = False
            End If
            TableDB.Dispose()
            TableDB = Nothing
            SQLiteCon.Close()
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
        End If
    End Sub
    Private Sub checkbox_byCode_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_byTransporterCode.CheckedChanged
        If checkbox_byTransporterCode.Checked = True Then
            checkbox_byVehicleNumber.Checked = False
        End If
        If checkbox_byTransporterCode.Checked = False Then
            checkbox_byVehicleNumber.Checked = True
        End If
    End Sub
    Private Sub checkbox_byName_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_byVehicleNumber.CheckedChanged
        If checkbox_byVehicleNumber.Checked = True Then
            checkbox_byTransporterCode.Checked = False
        End If
        If checkbox_byVehicleNumber.Checked = False Then
            checkbox_byTransporterCode.Checked = True
        End If
    End Sub

    'Sub to write to the database
    Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub

    'Function to detect datagridview is selected all
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridViewTable.SelectedCells.Count = (DataGridViewTable.RowCount * DataGridViewTable.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    'Grid Data View Config & Style
    Private Sub DataGridViewTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseClick
        Dim i As Integer
        With DataGridViewTable
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                rowSelected = True
                'IDTrans = .Rows(i).Cells("ID").Value.ToString
                IDTrans = .Rows(i).Cells("transporter_id").Value.ToString
                CodeTrans = .Rows(i).Cells("transporter_code").Value.ToString
                vehicle_id = .Rows(i).Cells("ID").Value.ToString
                vehicle_number = .Rows(i).Cells("vehicle_number").Value.ToString
                createdDate = .Rows(i).Cells("created_date").Value.ToString
                expiredDate = .Rows(i).Cells("expired_date").Value.ToString
                vehicle_tare = .Rows(i).Cells("tare").Value.ToString
                vehicle_unit = .Rows(i).Cells("tare_unit").Value.ToString
                vehicle_capacity = .Rows(i).Cells("capacity").Value.ToString
                vehicle_useTare = .Rows(i).Cells("use_tare").Value.ToString
                vehicle_updatedBy = .Rows(i).Cells("updated_by").Value.ToString
                vehicle_updatedAt = .Rows(i).Cells("updated_at").Value.ToString
                vehicle_createdAt = .Rows(i).Cells("created_at").Value.ToString
                btn_edit.Enabled = True
                btn_delete.Enabled = True
            End If
        End With
    End Sub
    Private Sub DataGridViewTable_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewTable.CellFormatting
        DataGridViewTable.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
        DataGridViewTable.Rows(e.RowIndex).HeaderCell.Style.BackColor = Color.FromArgb(25, 25, 25)
        DataGridViewTable.Rows(e.RowIndex).HeaderCell.Style.ForeColor = Color.White
        DataGridViewTable.DefaultCellStyle.Font = New Font("Lato", 12.0F, GraphicsUnit.Pixel)
        DataGridViewTable.Columns(e.ColumnIndex).HeaderCell.Style.BackColor = Color.FromArgb(25, 25, 25)
        DataGridViewTable.Columns(e.ColumnIndex).HeaderCell.Style.ForeColor = Color.White
    End Sub
    Private Sub PanelTable_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelTable.MouseClick
        DataGridViewTable.ClearSelection()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        PanelInput.Visible = False
    End Sub

    'Button Style & Hover
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_export.MouseEnter,
            btn_import.MouseEnter, btn_pdf.MouseEnter, btn_print.MouseEnter, btn_delete.MouseEnter,
            btn_edit.MouseEnter, btn_add.MouseEnter, btn_search.MouseEnter, btn_refresh.MouseEnter

        Dim btn As IconButton = CType(sender, IconButton)
        btn.ForeColor = Color.FromArgb(0, 162, 233)
        btn.IconColor = Color.FromArgb(0, 162, 233)
    End Sub
    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_export.MouseLeave,
            btn_import.MouseLeave, btn_pdf.MouseLeave, btn_print.MouseLeave, btn_delete.MouseLeave,
            btn_edit.MouseLeave, btn_add.MouseLeave, btn_search.MouseLeave, btn_refresh.MouseLeave

        Dim btn As IconButton = CType(sender, IconButton)
        btn.ForeColor = Color.Silver
        btn.IconColor = Color.Silver
    End Sub
    Private Sub btn_EnabledStyle(sender As Object, e As EventArgs) Handles btn_edit.EnabledChanged, btn_delete.EnabledChanged

        Dim btn As IconButton = CType(sender, IconButton)
        btn.ForeColor = If(sender.enabled = False, Color.Black, Color.Silver)
        btn.IconColor = If(sender.enabled = False, Color.FromArgb(0, 162, 233), Color.Silver)
    End Sub

    Private Sub checkBox_useTare_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_useTare.CheckedChanged
        If checkBox_useTare.Checked = True Then
            vehicle_useTare = "1"
            tb_tare.Enabled = True
        ElseIf checkBox_useTare.Checked = False Then
            vehicle_useTare = "0"
            tb_tare.Enabled = False
            tb_tare.Text = "0"
        End If
    End Sub


    '--------------------------------------
End Class