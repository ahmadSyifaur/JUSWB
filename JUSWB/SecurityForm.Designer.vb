<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityForm
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
        Me.PanelSecurity = New System.Windows.Forms.Panel()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_refresh = New FontAwesome.Sharp.IconButton()
        Me.btn_save = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelSecurity.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSecurity
        '
        Me.PanelSecurity.Controls.Add(Me.PanelContent)
        Me.PanelSecurity.Controls.Add(Me.PanelHeader)
        Me.PanelSecurity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSecurity.Location = New System.Drawing.Point(0, 0)
        Me.PanelSecurity.Name = "PanelSecurity"
        Me.PanelSecurity.Size = New System.Drawing.Size(982, 603)
        Me.PanelSecurity.TabIndex = 0
        '
        'PanelContent
        '
        Me.PanelContent.AutoScroll = True
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 143)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(982, 460)
        Me.PanelContent.TabIndex = 1
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.Panel2)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(982, 143)
        Me.PanelHeader.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_refresh)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 71)
        Me.Panel2.TabIndex = 1
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.Silver
        Me.btn_refresh.IconChar = FontAwesome.Sharp.IconChar.Sync
        Me.btn_refresh.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_refresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_refresh.IconSize = 32
        Me.btn_refresh.Location = New System.Drawing.Point(10, 4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(118, 60)
        Me.btn_refresh.TabIndex = 10
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Silver
        Me.btn_save.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btn_save.IconColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_save.IconSize = 32
        Me.btn_save.Location = New System.Drawing.Point(146, 6)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(92, 60)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(481, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Select access for each action in order to set required user permissions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set access level for predefined operations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SecurityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 603)
        Me.Controls.Add(Me.PanelSecurity)
        Me.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SecurityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SecurityForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelSecurity.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSecurity As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_refresh As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelContent As Panel
End Class
