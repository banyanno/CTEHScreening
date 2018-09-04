Public Class FormRefraction
    Public DARefraction As New DataSetScreeningBookTableAdapters.SCREENING_REFRACTION_BOOKTableAdapter
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class