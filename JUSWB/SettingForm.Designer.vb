<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.Content = New System.Windows.Forms.Panel()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.btn_security = New System.Windows.Forms.Button()
        Me.btn_application = New System.Windows.Forms.Button()
        Me.btn_general = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_backToMain = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_database = New System.Windows.Forms.Button()
        Me.PanelAdmin.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.PanelAdmin.Controls.Add(Me.Content)
        Me.PanelAdmin.Controls.Add(Me.Sidebar)
        Me.PanelAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAdmin.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(1248, 642)
        Me.PanelAdmin.TabIndex = 4
        '
        'Content
        '
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(250, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(998, 642)
        Me.Content.TabIndex = 6
        '
        'Sidebar
        '
        Me.Sidebar.AutoScroll = True
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.btn_database)
        Me.Sidebar.Controls.Add(Me.btn_security)
        Me.Sidebar.Controls.Add(Me.btn_application)
        Me.Sidebar.Controls.Add(Me.btn_general)
        Me.Sidebar.Controls.Add(Me.Panel4)
        Me.Sidebar.Controls.Add(Me.btn_backToMain)
        Me.Sidebar.Controls.Add(Me.Panel1)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Padding = New System.Windows.Forms.Padding(3)
        Me.Sidebar.Size = New System.Drawing.Size(250, 642)
        Me.Sidebar.TabIndex = 5
        '
        'btn_security
        '
        Me.btn_security.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_security.FlatAppearance.BorderSize = 0
        Me.btn_security.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_security.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_security.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_security.Location = New System.Drawing.Point(3, 273)
        Me.btn_security.Name = "btn_security"
        Me.btn_security.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_security.Size = New System.Drawing.Size(244, 50)
        Me.btn_security.TabIndex = 19
        Me.btn_security.Text = "Security"
        Me.btn_security.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_security.UseVisualStyleBackColor = True
        '
        'btn_application
        '
        Me.btn_application.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_application.FlatAppearance.BorderSize = 0
        Me.btn_application.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_application.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_application.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_application.Location = New System.Drawing.Point(3, 223)
        Me.btn_application.Name = "btn_application"
        Me.btn_application.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_application.Size = New System.Drawing.Size(244, 50)
        Me.btn_application.TabIndex = 18
        Me.btn_application.Text = "Aplication"
        Me.btn_application.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_application.UseVisualStyleBackColor = True
        '
        'btn_general
        '
        Me.btn_general.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_general.FlatAppearance.BorderSize = 0
        Me.btn_general.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_general.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_general.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_general.Location = New System.Drawing.Point(3, 173)
        Me.btn_general.Name = "btn_general"
        Me.btn_general.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_general.Size = New System.Drawing.Size(244, 50)
        Me.btn_general.TabIndex = 17
        Me.btn_general.Text = "General"
        Me.btn_general.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_general.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 125)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(244, 48)
        Me.Panel4.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 29)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Settings"
        '
        'btn_backToMain
        '
        Me.btn_backToMain.BackColor = System.Drawing.Color.DarkRed
        Me.btn_backToMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_backToMain.FlatAppearance.BorderSize = 0
        Me.btn_backToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_backToMain.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backToMain.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_backToMain.Location = New System.Drawing.Point(3, 589)
        Me.btn_backToMain.Name = "btn_backToMain"
        Me.btn_backToMain.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_backToMain.Size = New System.Drawing.Size(244, 50)
        Me.btn_backToMain.TabIndex = 15
        Me.btn_backToMain.Text = "Back To Main"
        Me.btn_backToMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_backToMain.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 122)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(244, 88)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JUSWB.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(44, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_username)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Panel2.Size = New System.Drawing.Size(244, 34)
        Me.Panel2.TabIndex = 0
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_username.Location = New System.Drawing.Point(46, 9)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(67, 16)
        Me.lbl_username.TabIndex = 64
        Me.lbl_username.Text = "Username"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.JUSWB.My.Resources.Resources.i_user
        Me.PictureBox2.Location = New System.Drawing.Point(15, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'btn_database
        '
        Me.btn_database.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_database.FlatAppearance.BorderSize = 0
        Me.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_database.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_database.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_database.Location = New System.Drawing.Point(3, 323)
        Me.btn_database.Name = "btn_database"
        Me.btn_database.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_database.Size = New System.Drawing.Size(244, 50)
        Me.btn_database.TabIndex = 20
        Me.btn_database.Text = "Database"
        Me.btn_database.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_database.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 642)
        Me.Controls.Add(Me.PanelAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SettingForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelAdmin.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents Content As Panel
    Friend WithEvents Sidebar As Panel
    Friend WithEvents btn_security As Button
    Friend WithEvents btn_application As Button
    Friend WithEvents btn_general As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_backToMain As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_username As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_database As Button
End Class
