Public Class DashboardSetting

    Private Sub BtnNewSetting_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnNewSetting.Click
        Dim SSetting As New ScreeningSetting
        SSetting.ShowDialog()
    End Sub
End Class
