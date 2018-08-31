Public Class DashboardScreeningRegisBook
    Dim DAScreeningBook As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Dim DAReferralBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_REFERRAL_DETAILTableAdapter
    Dim DARefractionBookDedail As New DataSetScreeningBookTableAdapters.SCREENIG_REFRACTION_DEDAILTableAdapter
    Dim DAOpticalshopBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_OPTICALSHOP_DETIALTableAdapter
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
            ' Load Data Screening book
            DGScreeningBook.DataSource = DAScreeningBook.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
            ' Load data for referral book
            DGReferral.DataSource = DAReferralBookDetail.SelectScreenReferralDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGReferral)
            ' Loading data for Refraction Book
            DGRefraction.DataSource = DARefractionBookDedail.SelectScreenRefractionDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGRefraction)

            ' Loading Data for Optical shop book
            DGOpticalShop.DataSource = DAOpticalshopBookDetail.SelectScreenOpticalShopDateToDateWithPatientNO(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGOpticalShop)
        Else

            ' Load Data Screening book
            DGScreeningBook.DataSource = DAScreeningBook.SelectScreenBookDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
            ' Load data for referral book
            DGReferral.DataSource = DAReferralBookDetail.SelectScreebReferralDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            ModCommon.NumberAllRowHeaderDataGrid(DGReferral)

            ' Loading data for Refraction Book
            DGRefraction.DataSource = DARefractionBookDedail.SelectScreenRefractDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            ModCommon.NumberAllRowHeaderDataGrid(DGRefraction)

            ' Loading Data for Optical shop book
            DGOpticalShop.DataSource = DAOpticalshopBookDetail.SelectScreenOpticalShopDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            ModCommon.NumberAllRowHeaderDataGrid(DGOpticalShop)
        End If

        ' Call Total Regis, Refraction, Referral and Optical shop
        DisplayTotalScreening(DateFrom.Value.Date, DateTo.Value.Date)
    End Sub

    Private Sub DashboardScreeningRegisBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGScreeningBook.AutoGenerateColumns = False
        DGReferral.AutoGenerateColumns = False
        DGRefraction.AutoGenerateColumns = False
        DGOpticalShop.AutoGenerateColumns = False
        'For Each items As ToolStripItem In CMScreeningBook.Items
        '    If TypeOf items Is ToolStripMenuItem Then
        '        MsgBox(items.Name)
        '        items.BackColor = Color.Black

        '        items.ForeColor = Color.White

        '    End If

        '    'For Each meh As ToolStripMenuItem In it
        '    '    meh.BackColor = Color.Black
        '    '    meh.ForeColor = Color.White
        '    '    'For Each lolCat As ToolStripMenuItem In meh.DropDownItems
        '    '    '    lolCat.BackColor = Color.Black
        '    '    '    lolCat.ForeColor = Color.White
        '    '    'Next
        '    'Next
        'Next
    End Sub

    Private Sub DGScreeningBook_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGScreeningBook.CellDoubleClick
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
        Dim dgRow As DataGridViewRow = DGScreeningBook.Rows(DGScreeningBook.SelectedCells(0).RowIndex)
        DisplayUtiliyBookByScreenID(dgRow.Cells("SCREEN_BOOKID").Value)
    End Sub
    Private Sub DisplayUtiliyBookByScreenID(ByVal ScreenID As Double)
        DGReferral.DataSource = DAReferralBookDetail.SelectReferralByScreenBookID(ScreenID)
        DGRefraction.DataSource = DARefractionBookDedail.SelectRefractionByScreenBookID(ScreenID)
        DGOpticalShop.DataSource = DAOpticalshopBookDetail.SelectOpticalByScreenBookID(ScreenID)
    End Sub
    Private Sub DisplayTotalScreening(ByVal DateFrom As Date, ByVal DateTo As Date)
        TxtTotalRegister.Text = DAScreeningBook.TotalScreen(DateFrom, DateTo)
        TxtTotalRefraction.Text = DAScreeningBook.TotalPatientRefraction(DateFrom, DateTo)
        TxtTotalReferralPickup.Text = DAScreeningBook.TotalPatientReferralPickup(DateFrom, DateTo)
        TxtTotalReferralSelf.Text = DAScreeningBook.TotalPatientReferralBySelf(DateFrom, DateTo)
        TxtTotalOpticalShop.Text = DAScreeningBook.TotalPatientOpticalshop(DateFrom, DateTo)
    End Sub

    Private Sub BtnUpdateScreening_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateScreening.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
        Dim GRows As DataGridViewRow = DGScreeningBook.Rows(DGScreeningBook.SelectedCells(0).RowIndex)
        Dim UpdateSNBook As New UpdateScreeningBook
        UpdateSNBook.LblSaveOption.Text = GRows.Cells("SCREEN_BOOKID").Value
        UpdateSNBook.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        UpdateSNBook.TxtPlaceScreening.Text = GRows.Cells("SCREEN_PLACE").Value
        UpdateSNBook.PatientNo.Text = GRows.Cells("PatientNo").Value
        UpdateSNBook.PatientName.Text = GRows.Cells("NameEng").Value
        UpdateSNBook.PatientSex.Text = GRows.Cells("Sex").Value
        UpdateSNBook.PatientAge.Text = GRows.Cells("Age").Value
        UpdateSNBook.CboOnEye.Text = GRows.Cells("ON_EYE").Value
        UpdateSNBook.cboDiagnosis.Text = GRows.Cells("DIAGNOSISScreening").Value
        UpdateSNBook.CboVARight.Text = GRows.Cells("VA_RIGHTScreening").Value
        UpdateSNBook.CboVALeft.Text = GRows.Cells("VA_LEFTScreening").Value
        UpdateSNBook.TxtComplain.Text = GRows.Cells("PRESENTING_COMPLAIN").Value
        UpdateSNBook.TxtMoreInfo.Text = GRows.Cells("SCREEN_NOTE").Value
        UpdateSNBook.ChRefraction.Checked = GRows.Cells("IS_REFRACTION").Value
        UpdateSNBook.ChOpticalshop.Checked = GRows.Cells("IS_OPTICALSHOP").Value
        UpdateSNBook.RadReferAndComeBySelf.Checked = GRows.Cells("IS_REFER_BYSELF").Value
        UpdateSNBook.RadReferAndPickup.Checked = GRows.Cells("IS_REFER_PICKUP").Value
        If UpdateSNBook.ShowDialog = DialogResult.OK Then
            DGScreeningBook.DataSource = DAScreeningBook.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(UpdateSNBook.PatientNo.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        End If
    End Sub
    Public Sub RefreshAfterScreenRegis(ByVal DFrom As Date, ByVal DTo As Date, ByVal PatientNo As Double)
        DGScreeningBook.DataSource = DAScreeningBook.SelectScreenBookDateToDateWithPatientNo(DFrom, DTo, EmptyString(PatientNo))
        ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
    End Sub

    Private Sub BtnNewScreeningRegist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewScreeningRegist.Click
        Dim RegistScreening As New FormPatientRegister(Me, True)
        RegistScreening.ShowDialog()
    End Sub

    Private Sub BtnUpdateReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateReferral.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub

        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GRows.Cells("IS_REFER_PICKUP").Value) = False AndAlso (GRows.Cells("IS_REFER_BYSELF").Value) = False Then Exit Sub
        Dim FReferral As New FormReferral
        FReferral.LblSaveOption.Text = GRows.Cells("SCREEN_BOOKID").Value
        FReferral.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        FReferral.PatientNo.Text = GRows.Cells("PatientNo").Value
        FReferral.PatientName.Text = GRows.Cells("NameEng").Value
        FReferral.PatientSex.Text = GRows.Cells("Sex").Value
        FReferral.PatientAge.Text = GRows.Cells("Age").Value
        FReferral.CboOnEye.Text = GRows.Cells("ON_EYE").Value
        FReferral.cboDiagnosis.Text = GRows.Cells("DIAGNOSISScreening").Value
        FReferral.CboVARight.Text = GRows.Cells("VA_RIGHTScreening").Value
        FReferral.CboVALeft.Text = GRows.Cells("VA_LEFTScreening").Value
        If GRows.Cells("IS_REFER_PICKUP").Value = True Then
            FReferral.ChPickup.Checked = True
        Else
            FReferral.ChPickup.Checked = False
        End If
        If FReferral.ShowDialog() = DialogResult.OK Then

        End If
    End Sub
End Class
