﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tb_formatString = New System.Windows.Forms.TextBox()
        Me.tb_result = New System.Windows.Forms.TextBox()
        Me.lbl_String = New System.Windows.Forms.Label()
        Me.tb_ID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_formatString
        '
        Me.tb_formatString.Location = New System.Drawing.Point(66, 91)
        Me.tb_formatString.Name = "tb_formatString"
        Me.tb_formatString.Size = New System.Drawing.Size(137, 20)
        Me.tb_formatString.TabIndex = 0
        '
        'tb_result
        '
        Me.tb_result.Location = New System.Drawing.Point(66, 169)
        Me.tb_result.Name = "tb_result"
        Me.tb_result.Size = New System.Drawing.Size(137, 20)
        Me.tb_result.TabIndex = 0
        '
        'lbl_String
        '
        Me.lbl_String.AutoSize = True
        Me.lbl_String.Location = New System.Drawing.Point(282, 97)
        Me.lbl_String.Name = "lbl_String"
        Me.lbl_String.Size = New System.Drawing.Size(39, 13)
        Me.lbl_String.TabIndex = 1
        Me.lbl_String.Text = "Label1"
        '
        'tb_ID
        '
        Me.tb_ID.Location = New System.Drawing.Point(66, 53)
        Me.tb_ID.Name = "tb_ID"
        Me.tb_ID.Size = New System.Drawing.Size(137, 20)
        Me.tb_ID.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 304)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_String)
        Me.Controls.Add(Me.tb_result)
        Me.Controls.Add(Me.tb_ID)
        Me.Controls.Add(Me.tb_formatString)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_formatString As TextBox
    Friend WithEvents tb_result As TextBox
    Friend WithEvents lbl_String As Label
    Friend WithEvents tb_ID As TextBox
    Friend WithEvents Button1 As Button
End Class
