Public Class DashboardReportUtility
    Dim DAScreening As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Private Sub BtnScreeningBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScreeningBook.Click
        Dim RV As New ReportScreening
        Dim tbl As DataTable = DAScreening.GetData
        RV.SetDataSource(tbl)
        Me.CRVScreeningUtility.ReportSource = RV
    End Sub
End Class
