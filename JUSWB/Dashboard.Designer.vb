<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PanelRangeDate = New System.Windows.Forms.Panel()
        Me.MonthCalendar_From = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar_Until = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDateUntil = New System.Windows.Forms.Label()
        Me.lbl_DateFrom = New System.Windows.Forms.Label()
        Me.btn_DateCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_DateOK = New System.Windows.Forms.Button()
        Me.PanelDashboard.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelRangeDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDashboard
        '
        Me.PanelDashboard.Controls.Add(Me.Panel2)
        Me.PanelDashboard.Controls.Add(Me.Panel1)
        Me.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDashboard.Location = New System.Drawing.Point(0, 0)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PanelDashboard.Size = New System.Drawing.Size(998, 642)
        Me.PanelDashboard.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 233)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(6, 239)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 60)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periodic Reports"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(320, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "-"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(355, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 22)
        Me.DateTimePicker1.TabIndex = 2
        '
        'PanelRangeDate
        '
        Me.PanelRangeDate.Controls.Add(Me.btn_DateOK)
        Me.PanelRangeDate.Controls.Add(Me.btn_DateCancel)
        Me.PanelRangeDate.Controls.Add(Me.MonthCalendar_Until)
        Me.PanelRangeDate.Controls.Add(Me.MonthCalendar_From)
        Me.PanelRangeDate.Controls.Add(Me.lbl_DateFrom)
        Me.PanelRangeDate.Controls.Add(Me.lblDateUntil)
        Me.PanelRangeDate.Controls.Add(Me.Label7)
        Me.PanelRangeDate.Controls.Add(Me.Label4)
        Me.PanelRangeDate.Controls.Add(Me.Label3)
        Me.PanelRangeDate.Location = New System.Drawing.Point(135, 187)
        Me.PanelRangeDate.Name = "PanelRangeDate"
        Me.PanelRangeDate.Size = New System.Drawing.Size(728, 269)
        Me.PanelRangeDate.TabIndex = 0
        '
        'MonthCalendar_From
        '
        Me.MonthCalendar_From.BackColor = System.Drawing.Color.White
        Me.MonthCalendar_From.Location = New System.Drawing.Point(28, 80)
        Me.MonthCalendar_From.Name = "MonthCalendar_From"
        Me.MonthCalendar_From.ShowTodayCircle = False
        Me.MonthCalendar_From.TabIndex = 3
        '
        'MonthCalendar_Until
        '
        Me.MonthCalendar_Until.BackColor = System.Drawing.Color.White
        Me.MonthCalendar_Until.Location = New System.Drawing.Point(273, 80)
        Me.MonthCalendar_Until.Name = "MonthCalendar_Until"
        Me.MonthCalendar_Until.ShowTodayCircle = False
        Me.MonthCalendar_Until.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(23, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "From"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(268, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Until"
        '
        'lblDateUntil
        '
        Me.lblDateUntil.AutoSize = True
        Me.lblDateUntil.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateUntil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateUntil.Location = New System.Drawing.Point(581, 55)
        Me.lblDateUntil.Name = "lblDateUntil"
        Me.lblDateUntil.Size = New System.Drawing.Size(70, 25)
        Me.lblDateUntil.TabIndex = 0
        Me.lblDateUntil.Text = "Date1"
        '
        'lbl_DateFrom
        '
        Me.lbl_DateFrom.AutoSize = True
        Me.lbl_DateFrom.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DateFrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_DateFrom.Location = New System.Drawing.Point(581, 125)
        Me.lbl_DateFrom.Name = "lbl_DateFrom"
        Me.lbl_DateFrom.Size = New System.Drawing.Size(70, 25)
        Me.lbl_DateFrom.TabIndex = 0
        Me.lbl_DateFrom.Text = "Date2"
        '
        'btn_DateCancel
        '
        Me.btn_DateCancel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_DateCancel.FlatAppearance.BorderSize = 0
        Me.btn_DateCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DateCancel.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateCancel.Location = New System.Drawing.Point(532, 182)
        Me.btn_DateCancel.Name = "btn_DateCancel"
        Me.btn_DateCancel.Size = New System.Drawing.Size(75, 35)
        Me.btn_DateCancel.TabIndex = 4
        Me.btn_DateCancel.Text = "Cancel"
        Me.btn_DateCancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(599, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Until"
        '
        'btn_DateOK
        '
        Me.btn_DateOK.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_DateOK.FlatAppearance.BorderSize = 0
        Me.btn_DateOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DateOK.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_DateOK.Location = New System.Drawing.Point(626, 182)
        Me.btn_DateOK.Name = "btn_DateOK"
        Me.btn_DateOK.Size = New System.Drawing.Size(75, 35)
        Me.btn_DateOK.TabIndex = 4
        Me.btn_DateOK.Text = "OK"
        Me.btn_DateOK.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 642)
        Me.Controls.Add(Me.PanelRangeDate)
        Me.Controls.Add(Me.PanelDashboard)
        Me.Font = New System.Drawing.Font("Lato", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelDashboard.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelRangeDate.ResumeLayout(False)
        Me.PanelRangeDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PanelRangeDate As Panel
    Friend WithEvents btn_DateOK As Button
    Friend WithEvents btn_DateCancel As Button
    Friend WithEvents MonthCalendar_Until As MonthCalendar
    Friend WithEvents MonthCalendar_From As MonthCalendar
    Friend WithEvents lbl_DateFrom As Label
    Friend WithEvents lblDateUntil As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
