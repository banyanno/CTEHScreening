Public Class UIScreening

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SetVisibleEnvisibleMenu()
    End Sub
    Public Sub SetVisibleEnvisibleMenu()
        If MenuVertical.Width = 0 Then
            MenuVertical.Width = 242
        Else
            MenuVertical.Width = 0
        End If
         

    End Sub
End Class
