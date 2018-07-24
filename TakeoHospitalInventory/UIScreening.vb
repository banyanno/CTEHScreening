Public Class UIScreening
    Dim MScreening As MainScreening
    Public PatientRegisAndPayment As New UCPatientPayment
    Sub New(ByVal MScreening As MainScreening)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MScreening = MScreening
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub SetVisibleEnvisibleMenu()
        If MenuVertical.Width = 0 Then
            MenuVertical.Width = 242
            Me.BtnNavigationBar.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Switch_On_40px1
            'BtnNavigationBar .Image =
        Else
            MenuVertical.Width = 0
            Me.BtnNavigationBar.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Switch_Off_40px
        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetVisibleEnvisibleMenu()
    End Sub

    Private Sub BtnNavigationBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNavigationBar.Click
        SetVisibleEnvisibleMenu()
    End Sub


    Private Sub BtnPatientRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientRegistration.Click
        AddUserControl(MScreening.PanelHeader, MScreening.PanelDedail, PatientRegisAndPayment, "", True)
    End Sub
End Class
