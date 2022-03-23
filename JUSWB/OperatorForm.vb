Imports System.Data.SQLite
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class OperatorForm
    Dim DB_Path As String
    Dim TableName As String = "operator"
    Dim username As String
    Dim rowSelected As Boolean
    Dim todaysdate As String = Now
    Dim IDOp, nameOp, codeOp, usernameOp, passwordOp, level_accessOp, activeOp, updatedByOp, updatedAtOp, createdAtOp As String
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Sub OperatorForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.PanelInput.Visible = False
        tb_accessLevel.Enabled = False
        tb_accessLevel.Text = "0"
        username = MainForm.USERNAME

        tb_search.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.tb_search.Handle, &H1501, 0, "Search...")


        DB_Path = "Data Source=" & Application.StartupPath & "\juswbdatabase.db;"
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        btn_resetPassword.Enabled = False

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
            LoadDB("SELECT * FROM " & TableName & " order by id", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns("operator_code").HeaderText = "Operator Code"
            DataGridViewTable.Columns("name").HeaderText = "Name"
            DataGridViewTable.Columns("username").HeaderText = "Username"
            DataGridViewTable.Columns("password").Visible = False
            DataGridViewTable.Columns("access_level").HeaderText = "Level"
            DataGridViewTable.Columns("active").HeaderText = "Active"
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

    Private Sub btn_AccessLevelPlus_Click(sender As Object, e As EventArgs) Handles btn_AccessLevelPlus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_accessLevel.Text)
        If levelValue >= 10 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue += 1
            tb_accessLevel.Text = levelValue.ToString()
        End If
    End Sub
    Private Sub btn_AccessLevelMinus_Click(sender As Object, e As EventArgs) Handles btn_AccessLevelMinus.Click
        Dim levelValue As Integer = Convert.ToInt32(tb_accessLevel.Text)
        If levelValue <= 0 Then
            MessageBox.Show("Access Level 0-10", "Failed")
        Else
            levelValue -= 1
            tb_accessLevel.Text = levelValue.ToString()
        End If
    End Sub

    'Header Control
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        tb_password.Visible = False
        tb_ConfirmPassword.Visible = False
        lbl_password.Visible = False
        lbl_confirm_password.Visible = False

        tb_OperatorCode.Visible = True
        tb_OperatorName.Visible = True
        tb_username.Visible = True
        lbl_usename.Visible = True
        lbl_accessLevel.Visible = True
        lbl_operatorName.Visible = True
        lbl_operatorCode.Visible = True
        Panel_accessLevel.Visible = True
        checkbox_active.Visible = True

        PanelInput.Visible = True
        tb_OperatorCode.Text = codeOp
        tb_OperatorName.Text = nameOp
        tb_username.Text = usernameOp

        tb_accessLevel.Text = level_accessOp
        If activeOp = "1" Then
            checkbox_active.Checked = True
        ElseIf activeOp = "0" Then
            checkbox_active.Checked = False
        End If
        lbl_inputTitle.Text = "UPDATE RECORD"
        btn_save.Text = "Update"
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        tb_password.Visible = True
        tb_ConfirmPassword.Visible = True
        lbl_password.Visible = True
        lbl_confirm_password.Visible = True
        tb_OperatorCode.Visible = True
        tb_OperatorName.Visible = True
        tb_username.Visible = True
        lbl_usename.Visible = True
        lbl_accessLevel.Visible = True
        lbl_operatorName.Visible = True
        lbl_operatorCode.Visible = True
        Panel_accessLevel.Visible = True
        checkbox_active.Visible = True

        PanelInput.Visible = True
        tb_OperatorCode.Clear()
        tb_OperatorName.Clear()
        tb_username.Clear()
        tb_ConfirmPassword.Clear()
        tb_password.Clear()

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

        If MsgBox("Delete record " & nameOp & "?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

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
                    ExecuteNonQuery("delete from " & TableName & " where ID='" & IDOp & "'", SQLiteCon)
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
    Private Sub btn_resetPassword_Click(sender As Object, e As EventArgs) Handles btn_resetPassword.Click
        tb_password.Visible = True
        tb_ConfirmPassword.Visible = True
        lbl_password.Visible = True
        lbl_confirm_password.Visible = True

        PanelInput.Visible = True
        tb_OperatorCode.Visible = False
        tb_OperatorName.Visible = False
        tb_username.Visible = False
        lbl_usename.Visible = False
        lbl_accessLevel.Visible = False
        lbl_operatorName.Visible = False
        lbl_operatorCode.Visible = False
        Panel_accessLevel.Visible = False
        checkbox_active.Visible = False
        tb_password.Clear()
        tb_ConfirmPassword.Clear()


        lbl_inputTitle.Text = "RESET PASSWORD"
        btn_save.Text = "Reset"
    End Sub

    'Grid Data View Config & Style
    Private Sub DataGridViewTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseClick
        Dim i As Integer
        With DataGridViewTable
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                rowSelected = True
                'IDTrans = .Rows(i).Cells("ID").Value.ToString
                IDOp = .Rows(i).Cells("id").Value.ToString
                codeOp = .Rows(i).Cells("operator_code").Value.ToString
                nameOp = .Rows(i).Cells("name").Value.ToString
                usernameOp = .Rows(i).Cells("username").Value.ToString
                passwordOp = DecryptData(.Rows(i).Cells("password").Value.ToString)
                activeOp = .Rows(i).Cells("active").Value.ToString
                level_accessOp = .Rows(i).Cells("access_level").Value.ToString

                updatedByOp = .Rows(i).Cells("updated_by").Value.ToString
                updatedAtOp = .Rows(i).Cells("updated_at").Value.ToString
                createdAtOp = .Rows(i).Cells("created_at").Value.ToString
                'btn_edit.Enabled = True
                'btn_delete.Enabled = True
                btn_delete.Enabled = True
                btn_edit.Enabled = True
                btn_resetPassword.Enabled = True
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
    Private Sub PanelTable_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelTable.MouseClick, Panel1.MouseClick, PanelControl.MouseClick, PanelFooter.MouseClick, PanelHeader.MouseClick
        DataGridViewTable.ClearSelection()
        btn_delete.Enabled = False
        btn_edit.Enabled = False
        PanelInput.Visible = False
        btn_resetPassword.Enabled = False
    End Sub

    'Input Control
    Private Sub update_Record(sender As Object, e As EventArgs)
        If tb_OperatorCode.Text = "" Then
            MessageBox.Show("Operator Code has not been filled, please fill in Operator Code", "Failed")
            Return
        End If
        If tb_OperatorName.Text = "" Then
            MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
            Return
        End If
        If tb_username.Text = "" Then
            MessageBox.Show("Username has not been filled, please fill in Username", "Failed")
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
                    operator_code = '" & tb_OperatorCode.Text & "',
                    name = '" & tb_OperatorName.Text & "',
                    username = '" & tb_username.Text & "',
                    access_level = '" & tb_accessLevel.Text & "',
                    active = '" & activeOp & "',
                    updated_by = '" & username & "',
                    updated_at = '" & todaysdate & "'
                WHERE ID = '" & IDOp & "'
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
    Private Sub resetPassword(sender As Object, e As EventArgs)
        If tb_password.Text <> tb_ConfirmPassword.Text Then
            MessageBox.Show("Password is not same!", "Failed")
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
                    password = '" & EncryptData(tb_password.Text) & "',
                    updated_by = '" & username & "',
                    updated_at = '" & todaysdate & "'
                WHERE ID = '" & IDOp & "'
            ", SQLiteCon)
            MsgBox("Reset password successfully")
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
        If tb_OperatorCode.Text = "" Then
            MessageBox.Show("Operator Code has not been filled, please fill in Operator Code", "Failed")
            Return
        End If
        If tb_OperatorName.Text = "" Then
            MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
            Return
        End If
        If tb_username.Text = "" Then
            MessageBox.Show("Username has not been filled, please fill in Username", "Failed")
            Return
        End If
        If tb_password.Text <> tb_ConfirmPassword.Text Then
            MessageBox.Show("Password is not same!", "Failed")
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
                    (operator_code,
                    name,
                    username,
                    password,
                    access_level,
                    active,
                    updated_by,
                    created_at,
                    updated_at)
                VALUES ('" & tb_OperatorCode.Text & "',
                '" & tb_OperatorName.Text & "',
                '" & tb_username.Text & "',
                '" & EncryptData(tb_password.Text) & "',
                '" & tb_accessLevel.Text & "',
                '" & activeOp & "',
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
        'tb_password.Text = DecryptData(tb_ConfirmPassword.Text)
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim btn As Button = CType(sender, Button)
        If btn.Text = "Save" Then
            save_Record(sender, e)
        ElseIf btn.Text = "Update" Then
            update_Record(sender, e)
        ElseIf btn.Text = "Reset" Then
            resetPassword(sender, e)
        End If
        'tb_ConfirmPassword.Text = EncryptData(tb_password.Text)
        'tb_password.Text = String.Empty
    End Sub

    'Sub to read the database
    Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
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
            LoadDB("SELECT * FROM " & TableName & " order by id", TableDB, SQLiteCon)
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns("operator_code").HeaderText = "Operator Code"
            DataGridViewTable.Columns("name").HeaderText = "Name"
            DataGridViewTable.Columns("username").HeaderText = "Username"
            DataGridViewTable.Columns("password").Visible = False
            DataGridViewTable.Columns("access_level").HeaderText = "Level"
            DataGridViewTable.Columns("active").HeaderText = "Active"
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

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchQuery As String = ""
        If tb_search.Text = Nothing Then
            btn_refresh_Click(sender, e)
        Else
            tb_search.CharacterCasing = CharacterCasing.Upper
            If checkbox_byName.Checked = True Then
                If tb_search.Text = Nothing Then
                    btn_refresh_Click(sender, e)
                Else
                    searchQuery = "Select * FROM vehicle_view WHERE vehicle_number like'" & tb_search.Text & "%'"
                End If
            End If

            If checkbox_byCode.Checked = True Then
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
    Private Sub checkbox_byCode_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_byCode.CheckedChanged
        If checkbox_byCode.Checked = True Then
            checkbox_byName.Checked = False
        End If
        If checkbox_byCode.Checked = False Then
            checkbox_byName.Checked = True
        End If
    End Sub
    Private Sub checkbox_byName_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_byName.CheckedChanged
        If checkbox_byName.Checked = True Then
            checkbox_byCode.Checked = False
        End If
        If checkbox_byName.Checked = False Then
            checkbox_byCode.Checked = True
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

    'Button Style & Hover
    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_export.MouseEnter,
            btn_import.MouseEnter, btn_pdf.MouseEnter, btn_print.MouseEnter, btn_delete.MouseEnter,
            btn_edit.MouseEnter, btn_add.MouseEnter, btn_search.MouseEnter, btn_refresh.MouseEnter, btn_resetPassword.MouseEnter

        Dim btn As IconButton = CType(sender, IconButton)
        btn.ForeColor = Color.FromArgb(0, 162, 233)
        btn.IconColor = Color.FromArgb(0, 162, 233)
    End Sub
    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_export.MouseLeave,
            btn_import.MouseLeave, btn_pdf.MouseLeave, btn_print.MouseLeave, btn_delete.MouseLeave,
            btn_edit.MouseLeave, btn_add.MouseLeave, btn_search.MouseLeave, btn_refresh.MouseLeave, btn_resetPassword.MouseLeave

        Dim btn As IconButton = CType(sender, IconButton)
        btn.ForeColor = Color.Silver
        btn.IconColor = Color.Silver
    End Sub
    Private Sub btn_EnabledStyle(sender As Object, e As EventArgs) Handles btn_edit.EnabledChanged, btn_delete.EnabledChanged

        Dim btn As IconButton = CType(sender, IconButton)
        btn.ForeColor = If(sender.enabled = False, Color.Black, Color.Silver)
        btn.IconColor = If(sender.enabled = False, Color.FromArgb(0, 162, 233), Color.Silver)
    End Sub

    Private Sub checkbox_active_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_active.CheckedChanged
        If checkbox_active.Checked = True Then
            activeOp = "1"
        ElseIf checkbox_active.Checked = False Then
            activeOp = "0"
        End If
    End Sub
End Class