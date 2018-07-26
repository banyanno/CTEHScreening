Public Class MainScreening
    Dim Login As frmLoginInventory
    Dim UIMainMenu As New UIScreening(Me)
    Private Delegate Sub DelShowLoadingPicture(ByVal visible As Boolean)
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


    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub


    Private Sub BtnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        AddUserControl(PanelHeader, PanelDedail, UIMainMenu, "", True)
    End Sub
    Public Sub StatusLoading(ByVal v As Boolean)
        If Me.Created Then
            RibboStatusBar.Invoke(New DelShowLoadingPicture(AddressOf UpdateVisibleLoading), New Object() {v})
        End If
    End Sub
    Private Sub UpdateVisibleLoading(ByVal v As Boolean)
        ContainerPicloading.Visible = v
    End Sub
End Class