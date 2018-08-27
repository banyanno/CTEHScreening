Public Class DashboardScreeningRegisBook
    Dim DAScreeningBook As New DataSetSceenSettingTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Private Sub TabControl1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem
        'Select Case e.Index
        '    Case 0
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(125, 0, 34)), e.Bounds)
        '    Case 1
        '        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(6766336)), e.Bounds)
        'End Select

        Dim paddedBounds As Rectangle = e.Bounds
        paddedBounds.Inflate(-1, -1)
        e.Graphics.DrawString(TabControl1.TabPages(e.Index).Text, Me.Font, SystemBrushes.HighlightText, paddedBounds)
    End Sub

    Private Sub TxtFind_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatienNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If TxtPatienNo.Text.Trim <> "" Then
            DGScreeningBook.DataSource = DAScreeningBook.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        Else
            DGScreeningBook.DataSource = DAScreeningBook.SelectScreenBookDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        End If
    End Sub

    Private Sub DashboardScreeningRegisBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGScreeningBook.AutoGenerateColumns = False
    End Sub
End Class
