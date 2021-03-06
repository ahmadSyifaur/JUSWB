Imports System.Data.SQLite
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class ProductForm
    Dim DB_Path As String
    Dim TableName As String = "product"
    Dim username As String = "wawing"
    Dim rowSelected As Boolean
    Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
    Dim IDProd, NameProd, CodeProd, TypeProd, UnitProd, SizeProd, updated_byTrans, updated_atTrans, created_atTrans As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'MainMenu.Show()'
        Me.PanelInput.Hide()

        checkbox_byName.Checked = True

        tb_search.CharacterCasing = CharacterCasing.Normal
        SendMessage(Me.tb_search.Handle, &H1501, 0, "Search...")


        DB_Path = "Data Source=" & Application.StartupPath & "\juswbdatabase.db;"
        btn_delete.Enabled = False
        btn_edit.Enabled = False

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
            DataGridViewTable.Columns("product_code").HeaderText = "Product Code"
            DataGridViewTable.Columns("name").HeaderText = "Name"
            DataGridViewTable.Columns("type").HeaderText = "Type"
            DataGridViewTable.Columns("size").HeaderText = "Size"
            DataGridViewTable.Columns("unit").HeaderText = "Unit"
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
    'Header Control
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        PanelInput.Show()
        tb_productCode.Text = CodeProd
        tb_name.Text = NameProd
        If TypeProd = "1" Then
            comboBox_Type.SelectedItem = "Bulk"
        ElseIf typeProd = "2" Then
            comboBox_Type.SelectedItem = "Bag"
        End If

        tb_size.Text = SizeProd

        If UnitProd = "1" Then
            comboBox_unit.SelectedItem = "Lbs"
        ElseIf UnitProd = "2" Then
            comboBox_unit.SelectedItem = "Kg"
        End If

        lbl_inputTitle.Text = "UPDATE RECORD"
        btn_save.Text = "Update"
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        PanelInput.Show()
        tb_productCode.Clear()
        tb_name.Clear()
        comboBox_Type.SelectedItem = "- Select Type -"
        tb_size.Clear()
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

        If MsgBox("Delete record " & NameProd & "?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

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
                    ExecuteNonQuery("delete from " & TableName & " where ID='" & IDProd & "'", SQLiteCon)
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
    Private Sub save_Record(sender As Object, e As EventArgs)
        If tb_productCode.Text = "" Then
            MessageBox.Show("Product code has not been filled, please fill in Product Code", "Failed")
            Return
        End If

        If tb_name.Text = "" Then
            MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
            Return
        End If

        If comboBox_Type.Text = "- Select Type -" Then
            MessageBox.Show("Type has not been selected, please select in Type", "Failed")
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
                    (product_code,
                    name,
                    type,
                    size,
                    unit,
                    updated_by,
                    created_at,
                    updated_at)
                VALUES ('" & tb_productCode.Text & "',
                '" & tb_name.Text & "',
                '" & TypeProd & "',
                '" & tb_size.Text & "',
                '" & UnitProd & "',
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
    Private Sub update_Record(sender As Object, e As EventArgs)
        If tb_productCode.Text = "" Then
            MessageBox.Show("Product code has not been filled, please fill in Product Code", "Failed")
            Return
        End If

        If tb_name.Text = "" Then
            MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
            Return
        End If

        If comboBox_Type.Text = "- Select Type -" Then
            MessageBox.Show("Type has not been selected, please select in Type", "Failed")
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
                    name = '" & tb_name.Text & "',
                    product_code = '" & tb_productCode.Text & "',
                    type = '" & TypeProd & "',
                    size = '" & tb_size.Text & "',
                    unit = '" & UnitProd & "',
                    updated_by = '" & username & "',
                    updated_at = '" & todaysdate & "'
                WHERE ID = '" & IDProd & "'
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
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim btn As Button = CType(sender, Button)
        If btn.Text = "Save" Then
            save_Record(sender, e)
        ElseIf btn.Text = "Update" Then
            update_Record(sender, e)
        End If
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        PanelInput.Hide()
    End Sub
    Private Sub tb_size_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_size.KeyPress
        'code to only allow numeric input on the mobile phone textbox
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
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
            DataGridViewTable.Columns("product_code").HeaderText = "Product Code"
            DataGridViewTable.Columns("name").HeaderText = "Name"
            DataGridViewTable.Columns("type").HeaderText = "Type"
            DataGridViewTable.Columns("size").HeaderText = "Size"
            DataGridViewTable.Columns("unit").HeaderText = "Unit"
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
            If checkbox_byName.Checked = True Then
                If tb_search.Text = Nothing Then
                    searchQuery = "select*from " & TableName & " order by name"
                Else
                    searchQuery = "select*from " & TableName & " where Name like'" & tb_search.Text & "%'"
                End If
            End If

            If checkbox_byCode.Checked = True Then
                If tb_search.Text = Nothing Then
                    searchQuery = "select*from " & TableName & " order by name"
                Else
                    searchQuery = "select*from " & TableName & " where transporter_code like'" & tb_search.Text & "%'"
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

    Private Sub tb_size_EnabledChanged(sender As Object, e As EventArgs) Handles tb_size.EnabledChanged
        Dim txt_size As TextBox = CType(sender, TextBox)
        txt_size.BackColor = If(sender.enabled = False, Color.Silver, Color.White)
    End Sub

    'Grid Data View Config & Style
    Private Sub DataGridViewTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseClick
        Dim i As Integer
        With DataGridViewTable
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                rowSelected = True
                IDProd = .Rows(i).Cells("ID").Value.ToString
                CodeProd = .Rows(i).Cells("product_code").Value.ToString
                NameProd = .Rows(i).Cells("name").Value.ToString
                TypeProd = .Rows(i).Cells("type").Value.ToString
                SizeProd = .Rows(i).Cells("size").Value.ToString
                UnitProd = .Rows(i).Cells("unit").Value.ToString
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
        PanelInput.Hide()
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
        btn.IconColor = If(sender.enabled = False, Color.Red, Color.Silver)
    End Sub

    Private Sub comboBox_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_Type.SelectedIndexChanged
        Dim selectText As String
        selectText = comboBox_Type.SelectedItem.ToString
        If selectText = "Bulk" Then
            TypeProd = "1"
            tb_size.Enabled = False
            tb_size.Text = "0"
        ElseIf selectText = "Bag" Then
            TypeProd = "2"
            tb_size.Enabled = True
        End If
    End Sub

    Private Sub comboBox_unit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_unit.SelectedIndexChanged
        Dim selectText As String
        selectText = comboBox_unit.SelectedItem.ToString
        If selectText = "Lbs" Then
            UnitProd = "1"
        ElseIf selectText = "Kg" Then
            UnitProd = "2"
        End If
    End Sub
    '--------------------------------------

End Class