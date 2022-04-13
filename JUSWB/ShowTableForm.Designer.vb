<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowTableForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.tb_Search = New System.Windows.Forms.TextBox()
        Me.ComboBox_field = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewTable)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel1.Size = New System.Drawing.Size(656, 341)
        Me.Panel1.TabIndex = 0
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.AllowUserToAddRows = False
        Me.DataGridViewTable.AllowUserToDeleteRows = False
        Me.DataGridViewTable.AllowUserToResizeColumns = False
        Me.DataGridViewTable.AllowUserToResizeRows = False
        Me.DataGridViewTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridViewTable.EnableHeadersVisualStyles = False
        Me.DataGridViewTable.Location = New System.Drawing.Point(10, 69)
        Me.DataGridViewTable.MultiSelect = False
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.ReadOnly = True
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.ShowCellToolTips = False
        Me.DataGridViewTable.ShowEditingIcon = False
        Me.DataGridViewTable.Size = New System.Drawing.Size(636, 206)
        Me.DataGridViewTable.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_select)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(10, 275)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 61)
        Me.Panel2.TabIndex = 1
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_select.FlatAppearance.BorderSize = 0
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_select.Location = New System.Drawing.Point(326, 17)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(75, 26)
        Me.btn_select.TabIndex = 1
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_close.Location = New System.Drawing.Point(218, 17)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 26)
        Me.btn_close.TabIndex = 1
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.tb_Search)
        Me.GroupBox1.Controls.Add(Me.ComboBox_field)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Field && Search"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_search.Location = New System.Drawing.Point(542, 22)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 26)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'tb_Search
        '
        Me.tb_Search.Font = New System.Drawing.Font("Lato", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Search.Location = New System.Drawing.Point(148, 23)
        Me.tb_Search.Name = "tb_Search"
        Me.tb_Search.Size = New System.Drawing.Size(377, 25)
        Me.tb_Search.TabIndex = 1
        '
        'ComboBox_field
        '
        Me.ComboBox_field.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_field.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_field.FormattingEnabled = True
        Me.ComboBox_field.Location = New System.Drawing.Point(13, 23)
        Me.ComboBox_field.Name = "ComboBox_field"
        Me.ComboBox_field.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_field.TabIndex = 0
        '
        'ShowTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 341)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ShowTableForm"
        Me.Text = "ShowTableForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_search As Button
    Friend WithEvents tb_Search As TextBox
    Friend WithEvents ComboBox_field As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_close As Button
    Public WithEvents btn_select As Button
    Public WithEvents DataGridViewTable As DataGridView
End Class
