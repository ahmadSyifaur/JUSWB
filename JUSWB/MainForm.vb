Public Class MainForm
    Private _USERNAME As String
    Private _ACCESS_LEVEL As Integer
    Public Property USERNAME() As String
        Get
            Return _USERNAME
        End Get
        Set(ByVal value As String)
            _USERNAME = value
        End Set
    End Property
    Public Property ACCESS_VALUE() As Integer
        Get
            Return _ACCESS_LEVEL
        End Get
        Set(ByVal value As Integer)
            _ACCESS_LEVEL = value
        End Set
    End Property

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MainMenu.Show()'
        Dim fMainMenu = New MainMenu()
        fMainMenu.TopLevel = False
        fMainMenu.TopMost = True
        MainPanel.Controls.Add(fMainMenu)
        fMainMenu.Show()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class