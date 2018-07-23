Public Class MainScreening
    Dim Login As frmLoginInventory
    Dim UIMainMenu As New UIScreening
    Sub New(ByVal login As frmLoginInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ModGlobleVariable.UIMainScreening = Me
        ModGlobleVariable.FLogin = login
        Me.Login = login
        ' InitUserControle()
        Application.DoEvents()
        'CheckPermistionOnForm()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub MainScreening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddUserControl(PanelHeader, PanelDedail, UIMainMenu, "", True)
    End Sub

    Private Sub PanelHeader_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelHeader.MouseMove

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class