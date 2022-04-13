<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministrationForm
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
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.Content = New System.Windows.Forms.Panel()
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.btn_backToMain = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_operator = New System.Windows.Forms.Button()
        Me.btn_vehicle = New System.Windows.Forms.Button()
        Me.btn_product = New System.Windows.Forms.Button()
        Me.btn_transporter = New System.Windows.Forms.Button()
        Me.btn_transactionList = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelAdmin.SuspendLayout()
        Me.Sidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelAdmin.Size = New System.Drawing.Size(1264, 681)
        Me.PanelAdmin.TabIndex = 3
        '
        'Content
        '
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(250, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(1014, 681)
        Me.Content.TabIndex = 6
        '
        'Sidebar
        '
        Me.Sidebar.AutoScroll = True
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.btn_backToMain)
        Me.Sidebar.Controls.Add(Me.btn_customer)
        Me.Sidebar.Controls.Add(Me.btn_operator)
        Me.Sidebar.Controls.Add(Me.btn_vehicle)
        Me.Sidebar.Controls.Add(Me.btn_product)
        Me.Sidebar.Controls.Add(Me.btn_transporter)
        Me.Sidebar.Controls.Add(Me.btn_transactionList)
        Me.Sidebar.Controls.Add(Me.btn_dashboard)
        Me.Sidebar.Controls.Add(Me.Panel1)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Padding = New System.Windows.Forms.Padding(3)
        Me.Sidebar.Size = New System.Drawing.Size(250, 681)
        Me.Sidebar.TabIndex = 5
        '
        'btn_backToMain
        '
        Me.btn_backToMain.BackColor = System.Drawing.Color.DarkRed
        Me.btn_backToMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_backToMain.FlatAppearance.BorderSize = 0
        Me.btn_backToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_backToMain.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backToMain.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_backToMain.Location = New System.Drawing.Point(3, 628)
        Me.btn_backToMain.Name = "btn_backToMain"
        Me.btn_backToMain.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_backToMain.Size = New System.Drawing.Size(244, 50)
        Me.btn_backToMain.TabIndex = 15
        Me.btn_backToMain.Text = "Back To Main"
        Me.btn_backToMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_backToMain.UseVisualStyleBackColor = False
        '
        'btn_customer
        '
        Me.btn_customer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_customer.FlatAppearance.BorderSize = 0
        Me.btn_customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customer.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_customer.Location = New System.Drawing.Point(3, 425)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_customer.Size = New System.Drawing.Size(244, 50)
        Me.btn_customer.TabIndex = 14
        Me.btn_customer.Text = "Customer"
        Me.btn_customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_operator
        '
        Me.btn_operator.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_operator.FlatAppearance.BorderSize = 0
        Me.btn_operator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_operator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_operator.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_operator.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_operator.Location = New System.Drawing.Point(3, 375)
        Me.btn_operator.Name = "btn_operator"
        Me.btn_operator.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_operator.Size = New System.Drawing.Size(244, 50)
        Me.btn_operator.TabIndex = 13
        Me.btn_operator.Text = "Operator"
        Me.btn_operator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_operator.UseVisualStyleBackColor = True
        '
        'btn_vehicle
        '
        Me.btn_vehicle.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_vehicle.FlatAppearance.BorderSize = 0
        Me.btn_vehicle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_vehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vehicle.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vehicle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_vehicle.Location = New System.Drawing.Point(3, 325)
        Me.btn_vehicle.Name = "btn_vehicle"
        Me.btn_vehicle.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_vehicle.Size = New System.Drawing.Size(244, 50)
        Me.btn_vehicle.TabIndex = 12
        Me.btn_vehicle.Text = "Vehicle"
        Me.btn_vehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_vehicle.UseVisualStyleBackColor = True
        '
        'btn_product
        '
        Me.btn_product.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_product.FlatAppearance.BorderSize = 0
        Me.btn_product.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_product.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_product.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_product.Location = New System.Drawing.Point(3, 275)
        Me.btn_product.Name = "btn_product"
        Me.btn_product.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_product.Size = New System.Drawing.Size(244, 50)
        Me.btn_product.TabIndex = 11
        Me.btn_product.Text = "Product"
        Me.btn_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_product.UseVisualStyleBackColor = True
        '
        'btn_transporter
        '
        Me.btn_transporter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_transporter.FlatAppearance.BorderSize = 0
        Me.btn_transporter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_transporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transporter.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transporter.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_transporter.Location = New System.Drawing.Point(3, 225)
        Me.btn_transporter.Name = "btn_transporter"
        Me.btn_transporter.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_transporter.Size = New System.Drawing.Size(244, 50)
        Me.btn_transporter.TabIndex = 10
        Me.btn_transporter.Text = "Transporter"
        Me.btn_transporter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_transporter.UseVisualStyleBackColor = True
        '
        'btn_transactionList
        '
        Me.btn_transactionList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_transactionList.FlatAppearance.BorderSize = 0
        Me.btn_transactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_transactionList.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transactionList.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_transactionList.Location = New System.Drawing.Point(3, 175)
        Me.btn_transactionList.Name = "btn_transactionList"
        Me.btn_transactionList.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_transactionList.Size = New System.Drawing.Size(244, 50)
        Me.btn_transactionList.TabIndex = 9
        Me.btn_transactionList.Text = "Transaction List"
        Me.btn_transactionList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_transactionList.UseVisualStyleBackColor = True
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_dashboard.FlatAppearance.BorderSize = 0
        Me.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dashboard.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_dashboard.Location = New System.Drawing.Point(3, 125)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_dashboard.Size = New System.Drawing.Size(244, 50)
        Me.btn_dashboard.TabIndex = 8
        Me.btn_dashboard.Text = "Dashboard"
        Me.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.UseVisualStyleBackColor = True
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
        'AdministrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PanelAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdministrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AdministrationForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelAdmin.ResumeLayout(False)
        Me.Sidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAdmin As Panel
    Friend WithEvents Sidebar As Panel
    Friend WithEvents btn_backToMain As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_operator As Button
    Friend WithEvents btn_vehicle As Button
    Friend WithEvents btn_product As Button
    Friend WithEvents btn_transporter As Button
    Friend WithEvents btn_transactionList As Button
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Content As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_username As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
