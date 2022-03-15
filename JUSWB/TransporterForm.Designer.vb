<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransporterForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.btn_add = New FontAwesome.Sharp.IconButton()
        Me.btn_edit = New FontAwesome.Sharp.IconButton()
        Me.btn_delete = New FontAwesome.Sharp.IconButton()
        Me.btn_print = New FontAwesome.Sharp.IconButton()
        Me.btn_pdf = New FontAwesome.Sharp.IconButton()
        Me.btn_import = New FontAwesome.Sharp.IconButton()
        Me.btn_export = New FontAwesome.Sharp.IconButton()
        Me.PanelTransporter = New System.Windows.Forms.Panel()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelTable = New System.Windows.Forms.Panel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.lbl_totalRecord = New System.Windows.Forms.Label()
        Me.lbl_totalRecordValue = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.btn_refresh = New FontAwesome.Sharp.IconButton()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.checkbox_byCode = New System.Windows.Forms.CheckBox()
        Me.checkbox_byName = New System.Windows.Forms.CheckBox()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.PanelInput = New System.Windows.Forms.Panel()
        Me.tb_telpNo = New System.Windows.Forms.TextBox()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.tb_transporterCode = New System.Windows.Forms.TextBox()
        Me.lbl_telpNo = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_transporterCode = New System.Windows.Forms.Label()
        Me.lbl_inputSubTitle = New System.Windows.Forms.Label()
        Me.lbl_inputTitle = New System.Windows.Forms.Label()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.PanelHeader.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.PanelTransporter.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.PanelTable.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.PanelInput.SuspendLayout()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.PanelControl)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(709, 100)
        Me.PanelHeader.TabIndex = 0
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.PanelControl.Controls.Add(Me.btn_add)
        Me.PanelControl.Controls.Add(Me.btn_edit)
        Me.PanelControl.Controls.Add(Me.btn_delete)
        Me.PanelControl.Controls.Add(Me.btn_print)
        Me.PanelControl.Controls.Add(Me.btn_pdf)
        Me.PanelControl.Controls.Add(Me.btn_import)
        Me.PanelControl.Controls.Add(Me.btn_export)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelControl.Size = New System.Drawing.Size(709, 97)
        Me.PanelControl.TabIndex = 1
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Silver
        Me.btn_add.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btn_add.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_add.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_add.IconSize = 32
        Me.btn_add.Location = New System.Drawing.Point(22, 10)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(144, 75)
        Me.btn_add.TabIndex = 6
        Me.btn_add.Text = "Add Transporter"
        Me.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Silver
        Me.btn_edit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt
        Me.btn_edit.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_edit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_edit.IconSize = 32
        Me.btn_edit.Location = New System.Drawing.Point(178, 10)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 75)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Silver
        Me.btn_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btn_delete.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_delete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_delete.IconSize = 32
        Me.btn_delete.Location = New System.Drawing.Point(266, 10)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 75)
        Me.btn_delete.TabIndex = 6
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Silver
        Me.btn_print.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btn_print.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_print.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_print.IconSize = 32
        Me.btn_print.Location = New System.Drawing.Point(353, 10)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 75)
        Me.btn_print.TabIndex = 6
        Me.btn_print.Text = "Print"
        Me.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_pdf
        '
        Me.btn_pdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pdf.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pdf.ForeColor = System.Drawing.Color.Silver
        Me.btn_pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf
        Me.btn_pdf.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_pdf.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_pdf.IconSize = 32
        Me.btn_pdf.Location = New System.Drawing.Point(439, 10)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(75, 75)
        Me.btn_pdf.TabIndex = 6
        Me.btn_pdf.Text = "To PDF"
        Me.btn_pdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_pdf.UseVisualStyleBackColor = False
        '
        'btn_import
        '
        Me.btn_import.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_import.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_import.ForeColor = System.Drawing.Color.Silver
        Me.btn_import.IconChar = FontAwesome.Sharp.IconChar.FileImport
        Me.btn_import.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_import.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_import.IconSize = 32
        Me.btn_import.Location = New System.Drawing.Point(526, 10)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(75, 75)
        Me.btn_import.TabIndex = 6
        Me.btn_import.Text = "Import"
        Me.btn_import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_import.UseVisualStyleBackColor = False
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.Silver
        Me.btn_export.IconChar = FontAwesome.Sharp.IconChar.FileExport
        Me.btn_export.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_export.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_export.IconSize = 32
        Me.btn_export.Location = New System.Drawing.Point(611, 11)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(75, 75)
        Me.btn_export.TabIndex = 6
        Me.btn_export.Text = "Export"
        Me.btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'PanelTransporter
        '
        Me.PanelTransporter.Controls.Add(Me.PanelContent)
        Me.PanelTransporter.Controls.Add(Me.PanelHeader)
        Me.PanelTransporter.Controls.Add(Me.PanelInput)
        Me.PanelTransporter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTransporter.Location = New System.Drawing.Point(0, 0)
        Me.PanelTransporter.Name = "PanelTransporter"
        Me.PanelTransporter.Size = New System.Drawing.Size(998, 642)
        Me.PanelTransporter.TabIndex = 2
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.PanelContainer)
        Me.PanelContent.Controls.Add(Me.PanelSearch)
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 100)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(709, 542)
        Me.PanelContent.TabIndex = 2
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.PanelTable)
        Me.PanelContainer.Controls.Add(Me.PanelFooter)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 38)
        Me.PanelContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(709, 504)
        Me.PanelContainer.TabIndex = 2
        '
        'PanelTable
        '
        Me.PanelTable.Controls.Add(Me.DataGridViewTable)
        Me.PanelTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTable.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTable.Location = New System.Drawing.Point(0, 0)
        Me.PanelTable.Name = "PanelTable"
        Me.PanelTable.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTable.Size = New System.Drawing.Size(709, 463)
        Me.PanelTable.TabIndex = 2
        '
        'PanelFooter
        '
        Me.PanelFooter.Controls.Add(Me.lbl_totalRecord)
        Me.PanelFooter.Controls.Add(Me.lbl_totalRecordValue)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 463)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(709, 41)
        Me.PanelFooter.TabIndex = 1
        '
        'lbl_totalRecord
        '
        Me.lbl_totalRecord.AutoSize = True
        Me.lbl_totalRecord.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_totalRecord.Location = New System.Drawing.Point(12, 13)
        Me.lbl_totalRecord.Name = "lbl_totalRecord"
        Me.lbl_totalRecord.Size = New System.Drawing.Size(74, 13)
        Me.lbl_totalRecord.TabIndex = 1
        Me.lbl_totalRecord.Text = "Total Record : "
        '
        'lbl_totalRecordValue
        '
        Me.lbl_totalRecordValue.AutoSize = True
        Me.lbl_totalRecordValue.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalRecordValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_totalRecordValue.Location = New System.Drawing.Point(92, 14)
        Me.lbl_totalRecordValue.Name = "lbl_totalRecordValue"
        Me.lbl_totalRecordValue.Size = New System.Drawing.Size(13, 13)
        Me.lbl_totalRecordValue.TabIndex = 1
        Me.lbl_totalRecordValue.Text = "0"
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.PanelSearch.Controls.Add(Me.btn_refresh)
        Me.PanelSearch.Controls.Add(Me.btn_search)
        Me.PanelSearch.Controls.Add(Me.checkbox_byCode)
        Me.PanelSearch.Controls.Add(Me.checkbox_byName)
        Me.PanelSearch.Controls.Add(Me.tb_search)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 0)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(709, 38)
        Me.PanelSearch.TabIndex = 1
        '
        'btn_refresh
        '
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.btn_refresh.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_refresh.IconSize = 25
        Me.btn_refresh.Location = New System.Drawing.Point(459, 4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(90, 32)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btn_search.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.IconSize = 25
        Me.btn_search.Location = New System.Drawing.Point(363, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(90, 32)
        Me.btn_search.TabIndex = 6
        Me.btn_search.Text = "Search"
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'checkbox_byCode
        '
        Me.checkbox_byCode.AutoSize = True
        Me.checkbox_byCode.Dock = System.Windows.Forms.DockStyle.Left
        Me.checkbox_byCode.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_byCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkbox_byCode.Location = New System.Drawing.Point(73, 0)
        Me.checkbox_byCode.Name = "checkbox_byCode"
        Me.checkbox_byCode.Size = New System.Drawing.Size(70, 38)
        Me.checkbox_byCode.TabIndex = 5
        Me.checkbox_byCode.Text = "By Code"
        Me.checkbox_byCode.UseVisualStyleBackColor = True
        '
        'checkbox_byName
        '
        Me.checkbox_byName.AutoSize = True
        Me.checkbox_byName.Dock = System.Windows.Forms.DockStyle.Left
        Me.checkbox_byName.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_byName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkbox_byName.Location = New System.Drawing.Point(0, 0)
        Me.checkbox_byName.Name = "checkbox_byName"
        Me.checkbox_byName.Size = New System.Drawing.Size(73, 38)
        Me.checkbox_byName.TabIndex = 4
        Me.checkbox_byName.Text = "By Name"
        Me.checkbox_byName.UseVisualStyleBackColor = True
        '
        'tb_search
        '
        Me.tb_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_search.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_search.Location = New System.Drawing.Point(153, 9)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(201, 20)
        Me.tb_search.TabIndex = 1
        '
        'PanelInput
        '
        Me.PanelInput.AutoScroll = True
        Me.PanelInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.PanelInput.Controls.Add(Me.tb_telpNo)
        Me.PanelInput.Controls.Add(Me.tb_address)
        Me.PanelInput.Controls.Add(Me.tb_name)
        Me.PanelInput.Controls.Add(Me.btn_cancel)
        Me.PanelInput.Controls.Add(Me.btn_save)
        Me.PanelInput.Controls.Add(Me.tb_transporterCode)
        Me.PanelInput.Controls.Add(Me.lbl_telpNo)
        Me.PanelInput.Controls.Add(Me.lbl_address)
        Me.PanelInput.Controls.Add(Me.lbl_name)
        Me.PanelInput.Controls.Add(Me.lbl_transporterCode)
        Me.PanelInput.Controls.Add(Me.lbl_inputSubTitle)
        Me.PanelInput.Controls.Add(Me.lbl_inputTitle)
        Me.PanelInput.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelInput.Location = New System.Drawing.Point(709, 0)
        Me.PanelInput.Name = "PanelInput"
        Me.PanelInput.Size = New System.Drawing.Size(289, 642)
        Me.PanelInput.TabIndex = 1
        '
        'tb_telpNo
        '
        Me.tb_telpNo.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_telpNo.Location = New System.Drawing.Point(28, 406)
        Me.tb_telpNo.Name = "tb_telpNo"
        Me.tb_telpNo.Size = New System.Drawing.Size(206, 27)
        Me.tb_telpNo.TabIndex = 1
        '
        'tb_address
        '
        Me.tb_address.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.Location = New System.Drawing.Point(28, 237)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_address.Size = New System.Drawing.Size(206, 130)
        Me.tb_address.TabIndex = 1
        '
        'tb_name
        '
        Me.tb_name.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Location = New System.Drawing.Point(28, 170)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(206, 27)
        Me.tb_name.TabIndex = 1
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(64, 463)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 38)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(158, 463)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(76, 38)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'tb_transporterCode
        '
        Me.tb_transporterCode.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_transporterCode.Location = New System.Drawing.Point(28, 106)
        Me.tb_transporterCode.Name = "tb_transporterCode"
        Me.tb_transporterCode.Size = New System.Drawing.Size(206, 27)
        Me.tb_transporterCode.TabIndex = 1
        '
        'lbl_telpNo
        '
        Me.lbl_telpNo.AutoSize = True
        Me.lbl_telpNo.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telpNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_telpNo.Location = New System.Drawing.Point(24, 381)
        Me.lbl_telpNo.Name = "lbl_telpNo"
        Me.lbl_telpNo.Size = New System.Drawing.Size(104, 19)
        Me.lbl_telpNo.TabIndex = 0
        Me.lbl_telpNo.Text = "Telp Number :"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_address.Location = New System.Drawing.Point(24, 212)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(73, 19)
        Me.lbl_address.TabIndex = 0
        Me.lbl_address.Text = "Address :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_name.Location = New System.Drawing.Point(24, 145)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(57, 19)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Name :"
        '
        'lbl_transporterCode
        '
        Me.lbl_transporterCode.AutoSize = True
        Me.lbl_transporterCode.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transporterCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_transporterCode.Location = New System.Drawing.Point(24, 81)
        Me.lbl_transporterCode.Name = "lbl_transporterCode"
        Me.lbl_transporterCode.Size = New System.Drawing.Size(138, 19)
        Me.lbl_transporterCode.TabIndex = 0
        Me.lbl_transporterCode.Text = "Transporter Code :"
        '
        'lbl_inputSubTitle
        '
        Me.lbl_inputSubTitle.AutoSize = True
        Me.lbl_inputSubTitle.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputSubTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_inputSubTitle.Location = New System.Drawing.Point(24, 46)
        Me.lbl_inputSubTitle.Name = "lbl_inputSubTitle"
        Me.lbl_inputSubTitle.Size = New System.Drawing.Size(108, 19)
        Me.lbl_inputSubTitle.TabIndex = 0
        Me.lbl_inputSubTitle.Text = "TRASPORTER"
        '
        'lbl_inputTitle
        '
        Me.lbl_inputTitle.AutoSize = True
        Me.lbl_inputTitle.Font = New System.Drawing.Font("Lato", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_inputTitle.Location = New System.Drawing.Point(24, 23)
        Me.lbl_inputTitle.Name = "lbl_inputTitle"
        Me.lbl_inputTitle.Size = New System.Drawing.Size(142, 23)
        Me.lbl_inputTitle.TabIndex = 0
        Me.lbl_inputTitle.Text = "ADD RECORD"
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.AllowUserToAddRows = False
        Me.DataGridViewTable.AllowUserToDeleteRows = False
        Me.DataGridViewTable.AllowUserToResizeColumns = False
        Me.DataGridViewTable.AllowUserToResizeRows = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.DataGridViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.DataGridViewTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewTable.EnableHeadersVisualStyles = False
        Me.DataGridViewTable.GridColor = System.Drawing.Color.Black
        Me.DataGridViewTable.Location = New System.Drawing.Point(10, 10)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.ReadOnly = True
        Me.DataGridViewTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewTable.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.ShowCellToolTips = False
        Me.DataGridViewTable.ShowEditingIcon = False
        Me.DataGridViewTable.Size = New System.Drawing.Size(689, 309)
        Me.DataGridViewTable.TabIndex = 1
        '
        'TransporterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 642)
        Me.Controls.Add(Me.PanelTransporter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransporterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transporter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelControl.ResumeLayout(False)
        Me.PanelTransporter.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelTable.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        Me.PanelFooter.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.PanelInput.ResumeLayout(False)
        Me.PanelInput.PerformLayout()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelTransporter As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelInput As Panel
    Friend WithEvents lbl_inputTitle As Label
    Friend WithEvents tb_transporterCode As TextBox
    Friend WithEvents tb_telpNo As TextBox
    Friend WithEvents tb_address As TextBox
    Friend WithEvents tb_name As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_telpNo As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_transporterCode As Label
    Friend WithEvents lbl_inputSubTitle As Label
    Friend WithEvents PanelControl As Panel
    Friend WithEvents btn_add As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_edit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_print As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_pdf As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_import As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_export As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents btn_refresh As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents checkbox_byCode As CheckBox
    Friend WithEvents checkbox_byName As CheckBox
    Friend WithEvents tb_search As TextBox
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PanelTable As Panel
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents lbl_totalRecord As Label
    Friend WithEvents lbl_totalRecordValue As Label
    Friend WithEvents DataGridViewTable As DataGridView
End Class
