<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelVehicle = New System.Windows.Forms.Panel()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.PanelTable = New System.Windows.Forms.Panel()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.lbl_totalRecord = New System.Windows.Forms.Label()
        Me.lbl_totalRecordValue = New System.Windows.Forms.Label()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.btn_refresh = New FontAwesome.Sharp.IconButton()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.checkbox_byTransporterCode = New System.Windows.Forms.CheckBox()
        Me.checkbox_byVehicleNumber = New System.Windows.Forms.CheckBox()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.btn_add = New FontAwesome.Sharp.IconButton()
        Me.btn_edit = New FontAwesome.Sharp.IconButton()
        Me.btn_delete = New FontAwesome.Sharp.IconButton()
        Me.btn_print = New FontAwesome.Sharp.IconButton()
        Me.btn_pdf = New FontAwesome.Sharp.IconButton()
        Me.btn_import = New FontAwesome.Sharp.IconButton()
        Me.btn_export = New FontAwesome.Sharp.IconButton()
        Me.PanelInput = New System.Windows.Forms.Panel()
        Me.PanelTransporter = New System.Windows.Forms.Panel()
        Me.dataGridTransporter = New System.Windows.Forms.DataGridView()
        Me.date_expiredDate = New System.Windows.Forms.DateTimePicker()
        Me.date_createdDate = New System.Windows.Forms.DateTimePicker()
        Me.checkBox_useTare = New System.Windows.Forms.CheckBox()
        Me.comboBox_capacityUnit = New System.Windows.Forms.ComboBox()
        Me.tb_capacity = New System.Windows.Forms.TextBox()
        Me.comboBox_transporterCode = New System.Windows.Forms.ComboBox()
        Me.comboBox_tareUnit = New System.Windows.Forms.ComboBox()
        Me.tb_tare = New System.Windows.Forms.TextBox()
        Me.lbl_capacityUnit = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.lbl_tareUnit = New System.Windows.Forms.Label()
        Me.lbl_capacity = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_tare = New System.Windows.Forms.Label()
        Me.lbl_expiredDate = New System.Windows.Forms.Label()
        Me.tb_VehicleNumber = New System.Windows.Forms.TextBox()
        Me.lbl_createdDate = New System.Windows.Forms.Label()
        Me.lbl_transporterCode = New System.Windows.Forms.Label()
        Me.lbl_vehicleNumber = New System.Windows.Forms.Label()
        Me.lbl_inputSubTitle = New System.Windows.Forms.Label()
        Me.lbl_inputTitle = New System.Windows.Forms.Label()
        Me.TransporterFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransporterFormBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelVehicle.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        Me.PanelContainer.SuspendLayout()
        Me.PanelTable.SuspendLayout()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooter.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.PanelInput.SuspendLayout()
        Me.PanelTransporter.SuspendLayout()
        CType(Me.dataGridTransporter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransporterFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransporterFormBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelVehicle
        '
        Me.PanelVehicle.Controls.Add(Me.PanelContent)
        Me.PanelVehicle.Controls.Add(Me.PanelHeader)
        Me.PanelVehicle.Controls.Add(Me.PanelInput)
        Me.PanelVehicle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVehicle.Location = New System.Drawing.Point(0, 0)
        Me.PanelVehicle.Name = "PanelVehicle"
        Me.PanelVehicle.Size = New System.Drawing.Size(998, 642)
        Me.PanelVehicle.TabIndex = 4
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
        Me.PanelContainer.TabIndex = 3
        '
        'PanelTable
        '
        Me.PanelTable.AutoScroll = True
        Me.PanelTable.Controls.Add(Me.DataGridViewTable)
        Me.PanelTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTable.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTable.Location = New System.Drawing.Point(0, 0)
        Me.PanelTable.Name = "PanelTable"
        Me.PanelTable.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelTable.Size = New System.Drawing.Size(709, 463)
        Me.PanelTable.TabIndex = 2
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.AllowUserToAddRows = False
        Me.DataGridViewTable.AllowUserToDeleteRows = False
        Me.DataGridViewTable.AllowUserToResizeColumns = False
        Me.DataGridViewTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.DataGridViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
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
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewTable.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.ShowCellToolTips = False
        Me.DataGridViewTable.ShowEditingIcon = False
        Me.DataGridViewTable.Size = New System.Drawing.Size(689, 309)
        Me.DataGridViewTable.TabIndex = 1
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
        Me.PanelSearch.Controls.Add(Me.checkbox_byTransporterCode)
        Me.PanelSearch.Controls.Add(Me.checkbox_byVehicleNumber)
        Me.PanelSearch.Controls.Add(Me.tb_search)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 0)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(709, 38)
        Me.PanelSearch.TabIndex = 2
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
        Me.btn_refresh.Location = New System.Drawing.Point(571, 4)
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
        Me.btn_search.Location = New System.Drawing.Point(475, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(90, 32)
        Me.btn_search.TabIndex = 6
        Me.btn_search.Text = "Search"
        Me.btn_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'checkbox_byTransporterCode
        '
        Me.checkbox_byTransporterCode.AutoSize = True
        Me.checkbox_byTransporterCode.Dock = System.Windows.Forms.DockStyle.Left
        Me.checkbox_byTransporterCode.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_byTransporterCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkbox_byTransporterCode.Location = New System.Drawing.Point(126, 0)
        Me.checkbox_byTransporterCode.Name = "checkbox_byTransporterCode"
        Me.checkbox_byTransporterCode.Size = New System.Drawing.Size(135, 38)
        Me.checkbox_byTransporterCode.TabIndex = 5
        Me.checkbox_byTransporterCode.Text = "By Transporter Code"
        Me.checkbox_byTransporterCode.UseVisualStyleBackColor = True
        '
        'checkbox_byVehicleNumber
        '
        Me.checkbox_byVehicleNumber.AutoSize = True
        Me.checkbox_byVehicleNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.checkbox_byVehicleNumber.Dock = System.Windows.Forms.DockStyle.Left
        Me.checkbox_byVehicleNumber.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_byVehicleNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkbox_byVehicleNumber.Location = New System.Drawing.Point(0, 0)
        Me.checkbox_byVehicleNumber.Name = "checkbox_byVehicleNumber"
        Me.checkbox_byVehicleNumber.Size = New System.Drawing.Size(126, 38)
        Me.checkbox_byVehicleNumber.TabIndex = 4
        Me.checkbox_byVehicleNumber.Text = "By Vehicle Number"
        Me.checkbox_byVehicleNumber.UseVisualStyleBackColor = True
        '
        'tb_search
        '
        Me.tb_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_search.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tb_search.Location = New System.Drawing.Point(265, 9)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(201, 20)
        Me.tb_search.TabIndex = 1
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
        Me.PanelControl.TabIndex = 0
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
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Add Vehicle"
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
        Me.btn_edit.TabIndex = 8
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
        Me.btn_delete.TabIndex = 9
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
        Me.btn_print.TabIndex = 10
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
        Me.btn_pdf.TabIndex = 11
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
        Me.btn_import.TabIndex = 12
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
        Me.btn_export.TabIndex = 13
        Me.btn_export.Text = "Export"
        Me.btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'PanelInput
        '
        Me.PanelInput.AutoScroll = True
        Me.PanelInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.PanelInput.Controls.Add(Me.PanelTransporter)
        Me.PanelInput.Controls.Add(Me.date_expiredDate)
        Me.PanelInput.Controls.Add(Me.date_createdDate)
        Me.PanelInput.Controls.Add(Me.checkBox_useTare)
        Me.PanelInput.Controls.Add(Me.comboBox_capacityUnit)
        Me.PanelInput.Controls.Add(Me.tb_capacity)
        Me.PanelInput.Controls.Add(Me.comboBox_transporterCode)
        Me.PanelInput.Controls.Add(Me.comboBox_tareUnit)
        Me.PanelInput.Controls.Add(Me.tb_tare)
        Me.PanelInput.Controls.Add(Me.lbl_capacityUnit)
        Me.PanelInput.Controls.Add(Me.Button1)
        Me.PanelInput.Controls.Add(Me.btn_cancel)
        Me.PanelInput.Controls.Add(Me.lbl_tareUnit)
        Me.PanelInput.Controls.Add(Me.lbl_capacity)
        Me.PanelInput.Controls.Add(Me.btn_save)
        Me.PanelInput.Controls.Add(Me.lbl_tare)
        Me.PanelInput.Controls.Add(Me.lbl_expiredDate)
        Me.PanelInput.Controls.Add(Me.tb_VehicleNumber)
        Me.PanelInput.Controls.Add(Me.lbl_createdDate)
        Me.PanelInput.Controls.Add(Me.lbl_transporterCode)
        Me.PanelInput.Controls.Add(Me.lbl_vehicleNumber)
        Me.PanelInput.Controls.Add(Me.lbl_inputSubTitle)
        Me.PanelInput.Controls.Add(Me.lbl_inputTitle)
        Me.PanelInput.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelInput.Location = New System.Drawing.Point(709, 0)
        Me.PanelInput.Name = "PanelInput"
        Me.PanelInput.Size = New System.Drawing.Size(289, 642)
        Me.PanelInput.TabIndex = 1
        '
        'PanelTransporter
        '
        Me.PanelTransporter.Controls.Add(Me.dataGridTransporter)
        Me.PanelTransporter.Location = New System.Drawing.Point(6, 175)
        Me.PanelTransporter.Name = "PanelTransporter"
        Me.PanelTransporter.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelTransporter.Size = New System.Drawing.Size(280, 157)
        Me.PanelTransporter.TabIndex = 6
        Me.PanelTransporter.Visible = False
        '
        'dataGridTransporter
        '
        Me.dataGridTransporter.AllowUserToAddRows = False
        Me.dataGridTransporter.AllowUserToDeleteRows = False
        Me.dataGridTransporter.AllowUserToResizeColumns = False
        Me.dataGridTransporter.AllowUserToResizeRows = False
        Me.dataGridTransporter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridTransporter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridTransporter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridTransporter.Location = New System.Drawing.Point(5, 5)
        Me.dataGridTransporter.Name = "dataGridTransporter"
        Me.dataGridTransporter.ReadOnly = True
        Me.dataGridTransporter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridTransporter.Size = New System.Drawing.Size(270, 147)
        Me.dataGridTransporter.TabIndex = 0
        '
        'date_expiredDate
        '
        Me.date_expiredDate.CustomFormat = "MM/dd/yyyy"
        Me.date_expiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_expiredDate.Location = New System.Drawing.Point(28, 291)
        Me.date_expiredDate.Name = "date_expiredDate"
        Me.date_expiredDate.Size = New System.Drawing.Size(206, 20)
        Me.date_expiredDate.TabIndex = 0
        '
        'date_createdDate
        '
        Me.date_createdDate.CustomFormat = "MM/dd/yyyy"
        Me.date_createdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_createdDate.Location = New System.Drawing.Point(28, 227)
        Me.date_createdDate.Name = "date_createdDate"
        Me.date_createdDate.Size = New System.Drawing.Size(206, 20)
        Me.date_createdDate.TabIndex = 0
        '
        'checkBox_useTare
        '
        Me.checkBox_useTare.AutoSize = True
        Me.checkBox_useTare.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox_useTare.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkBox_useTare.Location = New System.Drawing.Point(28, 338)
        Me.checkBox_useTare.Name = "checkBox_useTare"
        Me.checkBox_useTare.Size = New System.Drawing.Size(87, 23)
        Me.checkBox_useTare.TabIndex = 5
        Me.checkBox_useTare.Text = "Use Tare"
        Me.checkBox_useTare.UseVisualStyleBackColor = True
        '
        'comboBox_capacityUnit
        '
        Me.comboBox_capacityUnit.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox_capacityUnit.FormattingEnabled = True
        Me.comboBox_capacityUnit.Location = New System.Drawing.Point(161, 461)
        Me.comboBox_capacityUnit.Name = "comboBox_capacityUnit"
        Me.comboBox_capacityUnit.Size = New System.Drawing.Size(73, 27)
        Me.comboBox_capacityUnit.TabIndex = 4
        '
        'tb_capacity
        '
        Me.tb_capacity.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_capacity.Location = New System.Drawing.Point(28, 461)
        Me.tb_capacity.Name = "tb_capacity"
        Me.tb_capacity.Size = New System.Drawing.Size(122, 27)
        Me.tb_capacity.TabIndex = 1
        '
        'comboBox_transporterCode
        '
        Me.comboBox_transporterCode.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox_transporterCode.FormattingEnabled = True
        Me.comboBox_transporterCode.Location = New System.Drawing.Point(28, 164)
        Me.comboBox_transporterCode.Name = "comboBox_transporterCode"
        Me.comboBox_transporterCode.Size = New System.Drawing.Size(138, 27)
        Me.comboBox_transporterCode.TabIndex = 4
        '
        'comboBox_tareUnit
        '
        Me.comboBox_tareUnit.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBox_tareUnit.FormattingEnabled = True
        Me.comboBox_tareUnit.Location = New System.Drawing.Point(161, 400)
        Me.comboBox_tareUnit.Name = "comboBox_tareUnit"
        Me.comboBox_tareUnit.Size = New System.Drawing.Size(73, 27)
        Me.comboBox_tareUnit.TabIndex = 4
        '
        'tb_tare
        '
        Me.tb_tare.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tare.Location = New System.Drawing.Point(28, 400)
        Me.tb_tare.Name = "tb_tare"
        Me.tb_tare.Size = New System.Drawing.Size(122, 27)
        Me.tb_tare.TabIndex = 1
        '
        'lbl_capacityUnit
        '
        Me.lbl_capacityUnit.AutoSize = True
        Me.lbl_capacityUnit.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacityUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_capacityUnit.Location = New System.Drawing.Point(157, 436)
        Me.lbl_capacityUnit.Name = "lbl_capacityUnit"
        Me.lbl_capacityUnit.Size = New System.Drawing.Size(47, 19)
        Me.lbl_capacityUnit.TabIndex = 0
        Me.lbl_capacityUnit.Text = "Unit :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(172, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(28, 542)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 38)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'lbl_tareUnit
        '
        Me.lbl_tareUnit.AutoSize = True
        Me.lbl_tareUnit.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tareUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_tareUnit.Location = New System.Drawing.Point(157, 375)
        Me.lbl_tareUnit.Name = "lbl_tareUnit"
        Me.lbl_tareUnit.Size = New System.Drawing.Size(47, 19)
        Me.lbl_tareUnit.TabIndex = 0
        Me.lbl_tareUnit.Text = "Unit :"
        '
        'lbl_capacity
        '
        Me.lbl_capacity.AutoSize = True
        Me.lbl_capacity.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capacity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_capacity.Location = New System.Drawing.Point(24, 436)
        Me.lbl_capacity.Name = "lbl_capacity"
        Me.lbl_capacity.Size = New System.Drawing.Size(77, 19)
        Me.lbl_capacity.TabIndex = 0
        Me.lbl_capacity.Text = "Capacity :"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(128, 542)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(76, 38)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'lbl_tare
        '
        Me.lbl_tare.AutoSize = True
        Me.lbl_tare.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tare.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_tare.Location = New System.Drawing.Point(24, 375)
        Me.lbl_tare.Name = "lbl_tare"
        Me.lbl_tare.Size = New System.Drawing.Size(45, 19)
        Me.lbl_tare.TabIndex = 0
        Me.lbl_tare.Text = "Tare :"
        '
        'lbl_expiredDate
        '
        Me.lbl_expiredDate.AutoSize = True
        Me.lbl_expiredDate.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_expiredDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_expiredDate.Location = New System.Drawing.Point(24, 264)
        Me.lbl_expiredDate.Name = "lbl_expiredDate"
        Me.lbl_expiredDate.Size = New System.Drawing.Size(106, 19)
        Me.lbl_expiredDate.TabIndex = 0
        Me.lbl_expiredDate.Text = "Expired Date :"
        '
        'tb_VehicleNumber
        '
        Me.tb_VehicleNumber.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_VehicleNumber.Location = New System.Drawing.Point(28, 106)
        Me.tb_VehicleNumber.Name = "tb_VehicleNumber"
        Me.tb_VehicleNumber.Size = New System.Drawing.Size(206, 27)
        Me.tb_VehicleNumber.TabIndex = 1
        '
        'lbl_createdDate
        '
        Me.lbl_createdDate.AutoSize = True
        Me.lbl_createdDate.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_createdDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_createdDate.Location = New System.Drawing.Point(24, 200)
        Me.lbl_createdDate.Name = "lbl_createdDate"
        Me.lbl_createdDate.Size = New System.Drawing.Size(109, 19)
        Me.lbl_createdDate.TabIndex = 0
        Me.lbl_createdDate.Text = "Created Date :"
        '
        'lbl_transporterCode
        '
        Me.lbl_transporterCode.AutoSize = True
        Me.lbl_transporterCode.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transporterCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_transporterCode.Location = New System.Drawing.Point(24, 142)
        Me.lbl_transporterCode.Name = "lbl_transporterCode"
        Me.lbl_transporterCode.Size = New System.Drawing.Size(138, 19)
        Me.lbl_transporterCode.TabIndex = 0
        Me.lbl_transporterCode.Text = "Transporter Code :"
        '
        'lbl_vehicleNumber
        '
        Me.lbl_vehicleNumber.AutoSize = True
        Me.lbl_vehicleNumber.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vehicleNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_vehicleNumber.Location = New System.Drawing.Point(24, 81)
        Me.lbl_vehicleNumber.Name = "lbl_vehicleNumber"
        Me.lbl_vehicleNumber.Size = New System.Drawing.Size(126, 19)
        Me.lbl_vehicleNumber.TabIndex = 0
        Me.lbl_vehicleNumber.Text = "Vehicle Number :"
        '
        'lbl_inputSubTitle
        '
        Me.lbl_inputSubTitle.AutoSize = True
        Me.lbl_inputSubTitle.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_inputSubTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_inputSubTitle.Location = New System.Drawing.Point(24, 46)
        Me.lbl_inputSubTitle.Name = "lbl_inputSubTitle"
        Me.lbl_inputSubTitle.Size = New System.Drawing.Size(74, 19)
        Me.lbl_inputSubTitle.TabIndex = 0
        Me.lbl_inputSubTitle.Text = "VEHICLE"
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
        'TransporterFormBindingSource
        '
        Me.TransporterFormBindingSource.DataSource = GetType(JUSWB.TransporterForm)
        '
        'TransporterFormBindingSource1
        '
        Me.TransporterFormBindingSource1.DataSource = GetType(JUSWB.TransporterForm)
        '
        'VehicleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 642)
        Me.Controls.Add(Me.PanelVehicle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VehicleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vehicle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelVehicle.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelTable.ResumeLayout(False)
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooter.ResumeLayout(False)
        Me.PanelFooter.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelControl.ResumeLayout(False)
        Me.PanelInput.ResumeLayout(False)
        Me.PanelInput.PerformLayout()
        Me.PanelTransporter.ResumeLayout(False)
        CType(Me.dataGridTransporter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransporterFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransporterFormBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelVehicle As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelControl As Panel
    Friend WithEvents PanelInput As Panel
    Friend WithEvents comboBox_tareUnit As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents lbl_tareUnit As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents tb_VehicleNumber As TextBox
    Friend WithEvents lbl_createdDate As Label
    Friend WithEvents lbl_transporterCode As Label
    Friend WithEvents lbl_vehicleNumber As Label
    Friend WithEvents lbl_inputSubTitle As Label
    Friend WithEvents lbl_inputTitle As Label
    Friend WithEvents checkBox_useTare As CheckBox
    Friend WithEvents comboBox_capacityUnit As ComboBox
    Friend WithEvents tb_capacity As TextBox
    Friend WithEvents tb_tare As TextBox
    Friend WithEvents lbl_capacityUnit As Label
    Friend WithEvents lbl_capacity As Label
    Friend WithEvents lbl_tare As Label
    Friend WithEvents lbl_expiredDate As Label
    Friend WithEvents date_expiredDate As DateTimePicker
    Friend WithEvents date_createdDate As DateTimePicker
    Friend WithEvents comboBox_transporterCode As ComboBox
    Friend WithEvents btn_add As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_edit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_delete As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_print As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_pdf As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_import As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_export As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTransporter As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents btn_refresh As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents checkbox_byTransporterCode As CheckBox
    Friend WithEvents checkbox_byVehicleNumber As CheckBox
    Friend WithEvents tb_search As TextBox
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents PanelTable As Panel
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents lbl_totalRecord As Label
    Friend WithEvents lbl_totalRecordValue As Label
    Friend WithEvents TransporterFormBindingSource As BindingSource
    Friend WithEvents TransporterFormBindingSource1 As BindingSource
    Friend WithEvents dataGridTransporter As DataGridView
End Class
