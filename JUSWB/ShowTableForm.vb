Imports System.Data.SQLite
Imports System.Runtime.InteropServices

Public Class ShowTableForm
    Dim form As MainMenu
    Private _BUTTON As String
    Dim SELECTEDID As String
    Private _DT As DataTable

    Public Sub New(ByVal formParent As MainMenu)

        ' This call is required by the designer.
        InitializeComponent()
        form = formParent

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Property DT() As DataTable
        Get
            Return _DT
        End Get
        Set(ByVal value As DataTable)
            _DT = value
        End Set
    End Property
    Public Property BUTTON() As String
        Get
            Return _BUTTON
        End Get
        Set(ByVal value As String)
            _BUTTON = value

        End Set
    End Property
    Private Sub DataGridViewTable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseClick
        Dim i As Integer
        With DataGridViewTable
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                SELECTEDID = .Rows(i).Cells("ID").Value.ToString
                btn_select.Enabled = True
            End If
        End With
    End Sub

    Private Sub DataGridViewTable_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        DataGridViewTable.Rows(e.RowIndex).HeaderCell.Value = CStr(e.RowIndex + 1)
        DataGridViewTable.Rows(e.RowIndex).HeaderCell.Style.BackColor = Color.FromArgb(25, 25, 25)
        DataGridViewTable.Rows(e.RowIndex).HeaderCell.Style.ForeColor = Color.White
        DataGridViewTable.DefaultCellStyle.Font = New Font("Lato", 12.0F, GraphicsUnit.Pixel)
        DataGridViewTable.Columns(e.ColumnIndex).HeaderCell.Style.BackColor = Color.FromArgb(25, 25, 25)
        DataGridViewTable.Columns(e.ColumnIndex).HeaderCell.Style.ForeColor = Color.White
    End Sub


    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        If BUTTON = "VEHICLE" Then
            form.ComboBox_vehicle.SelectedValue = SELECTEDID
            Me.Close()
            Return
        End If
        If BUTTON = "TRANSPORTER" Then
            form.ComboBox_transporter.SelectedValue = SELECTEDID
            Me.Close()
            Return
        End If
        If BUTTON = "CUSTOMER" Then
            form.ComboBox_customer.SelectedValue = SELECTEDID
            Me.Close()
            Return
        End If
        If BUTTON = "PRODUCT" Then
            form.ComboBox_product.SelectedValue = SELECTEDID
            Me.Close()
            Return
        End If

    End Sub

    Private Sub ShowTableForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridViewTable.DataSource = DT
        btn_select.Enabled = False
        ComboBox_field.SelectedItem = "ID"
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim SQLiteCon As New SQLiteConnection(form.DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If ComboBox_field.SelectedItem = "" Or tb_Search.Text = "" Then
            MessageBox.Show("Field and Search cannot be blank", "Failed")
            Exit Sub
        End If
        If BUTTON = "VEHICLE" Then
            Try
                Dim Command As New SQLiteCommand("select id, vehicle_number, transporter_id from vehicle where " & ComboBox_field.SelectedItem & " like'%" & tb_Search.Text & "%'", SQLiteCon)
                Dim adapter As New SQLiteDataAdapter(Command)

                Dim DS As New DataTable()
                adapter.Fill(DS)
                DataGridViewTable.DataSource = DS

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

End Class