Public Class MainScreening
    Dim Login As frmLoginInventory
    Dim UIMainMenu As New UIScreening(Me)
    Private Delegate Sub DelShowLoadingPicture(ByVal visible As Boolean)
    Public examinationForm As New UCRegistrationForm
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
    Sub CreateRegisForm()
        AddUserControl(PanelHeader, PanelDedail, examinationForm, "", True)
    End Sub
    Private Sub MainScreening_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBtnSwitchUser.Text = "Log out user: " & UserGlobleVariable.USER_NAME.ToUpper
        BtnDateTimeServer.Text = "Server Date: " & Format(ModGlobleVariable.GeteDateServer, "dd-MM-yyyy") & " Version:20151108"
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

    Private Sub DBtnSwitchUser_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnSwitchUser.Click
        CreateSwitchUser()
    End Sub
    Sub CreateSwitchUser()
        FLogin.txtUserName.Text = ""
        FLogin.txtPassword.Text = ""
        FLogin.txtUserName.Select()
        FLogin.txtUserName.Focus()
        FLogin.Cursor = Cursors.Default
        FLogin.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DBtnChangePassword_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnChangePassword.Click
        CreateChagePasswordForm()
    End Sub
    Sub CreateChagePasswordForm()
        Dim FChangeUserPwd As New FrmChangeUserPWD
        FChangeUserPwd.TxtUserName.Text = USER_NAME
        FChangeUserPwd.LblUserID.Text = USER_ID
        FChangeUserPwd.ShowDialog()
    End Sub

    Private Sub DropDownCommand3_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DropDownCommand3.Click
        CreateLockSystem()
    End Sub
    Sub CreateLockSystem()
        Dim FLockSys As New FRMLockSystem(Me)
        FLockSys.ShowDialog()
    End Sub
End Class