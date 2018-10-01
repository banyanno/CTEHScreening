Public Class DashboardScreeningRegisBook
    Dim DAScreeningBook As New DataSetScreeningBookTableAdapters.SCREENING_BOOKTableAdapter
    Dim DAScreeningBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Dim DAReferralBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_REFERRAL_DETAILTableAdapter
    Dim DARefractionBookDedail As New DataSetScreeningBookTableAdapters.SCREENIG_REFRACTION_DEDAILTableAdapter
    Dim DAOpticalshopBookDetail As New DataSetScreeningBookTableAdapters.SCREENING_OPTICALSHOP_DETIALTableAdapter

    Private TableScreenBook, TableReferralBook, TableRefractionBook, TableOpticalShop As DataTable
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
    Private Sub CallScreeningBooks()
        UIMainScreening.StatusLoading(True, "Loading")
        BGScreeningBook.RunWorkerAsync()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        CallScreeningBooks()
    End Sub
    Private Sub BGScreeningBook_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGScreeningBook.DoWork
        If TxtPatienNo.Text.Trim <> "" Then
            TableScreenBook = DAScreeningBookDetail.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            TableReferralBook = DAReferralBookDetail.SelectScreenReferralDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            TableRefractionBook = DARefractionBookDedail.SelectScreenRefractionDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
            TableOpticalShop = DAOpticalshopBookDetail.SelectScreenOpticalShopDateToDateWithPatientNO(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(TxtPatienNo.Text))
        Else
            TableScreenBook = DAScreeningBookDetail.SelectScreenBookDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            TableReferralBook = DAReferralBookDetail.SelectScreebReferralDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            TableRefractionBook = DARefractionBookDedail.SelectScreenRefractDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
            TableOpticalShop = DAOpticalshopBookDetail.SelectScreenOpticalShopDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        End If
    End Sub
    Private Sub BGScreeningBook_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGScreeningBook.RunWorkerCompleted
        'If TxtPatienNo.Text.Trim <> "" Then
        ' Load Data Screening book
        DGScreeningBook.DataSource = TableScreenBook
        ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        ' Load data for referral book
        DGReferral.DataSource = TableReferralBook
        ModCommon.NumberAllRowHeaderDataGrid(DGReferral)
        ' Loading data for Refraction Book
        DGRefraction.DataSource = TableRefractionBook
        ModCommon.NumberAllRowHeaderDataGrid(DGRefraction)

        ' Loading Data for Optical shop book
        DGOpticalShop.DataSource = TableOpticalShop
        ModCommon.NumberAllRowHeaderDataGrid(DGOpticalShop)
        'Else

        '    ' Load Data Screening book
        '    DGScreeningBook.DataSource = 
        '    ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        '    ' Load data for referral book
        '    DGReferral.DataSource = 
        '    ModCommon.NumberAllRowHeaderDataGrid(DGReferral)

        '    ' Loading data for Refraction Book
        '    DGRefraction.DataSource =
        '    ModCommon.NumberAllRowHeaderDataGrid(DGRefraction)

        '    ' Loading Data for Optical shop book
        '    DGOpticalShop.DataSource = 
        '    ModCommon.NumberAllRowHeaderDataGrid(DGOpticalShop)
        'End If

        ' Call Total Regis, Refraction, Referral and Optical shop
        DisplayTotalScreening(DateFrom.Value.Date, DateTo.Value.Date)
        CheckBlankDiagnosis(Me.DGScreeningBook)
        UIMainScreening.StatusLoading(False, "Loading")
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
        TxtTotalRegister.Text = DAScreeningBookDetail.TotalScreen(DateFrom, DateTo)
        TxtTotalRefraction.Text = DAScreeningBookDetail.TotalPatientRefraction(DateFrom, DateTo)
        TxtTotalReferralPickup.Text = DAScreeningBookDetail.TotalPatientReferralPickup(DateFrom, DateTo)
        TxtTotalReferralSelf.Text = DAScreeningBookDetail.TotalPatientReferralBySelf(DateFrom, DateTo)
        TxtTotalOpticalShop.Text = DAScreeningBookDetail.TotalPatientOpticalshop(DateFrom, DateTo)
        TxtTotalNotYetImport.Text = DAScreeningBookDetail.TotalNotYetImport(DateFrom, DateTo)
    End Sub
    Private Sub CheckBlankDiagnosis(ByVal DG As DataGridView)
        For Each rows As DataGridViewRow In DG.Rows
            BlankDiagnosis = rows.Cells.Item("DIAGNOSISScreening").Value.ToString.Trim
            'DelOption = rows.Cells.Item("DeleteOption").Value.ToString.Trim
            'VA = rows.Cells.Item("VAStatus").Value.ToString
            'If VA = "False" Then
            '    rows.DefaultCellStyle.BackColor = Color.Bisque
            'End If
            If BlankDiagnosis = "" Then
                rows.DefaultCellStyle.BackColor = Color.FromArgb(222, 182, 174)
            End If
            'If DelOption = "True" Then
            '    rows.DefaultCellStyle.BackColor = Color.DarkKhaki
            'End If
        Next
        NumberAllRowHeaderDataGrid(DG)
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
        If GRows.Cells("IS_REFER_BYSELF").Value = True Then
            UpdateSNBook.ChReferral.Checked = True
            UpdateSNBook.RadReferAndComeBySelf.Checked = GRows.Cells("IS_REFER_BYSELF").Value
        End If
        If GRows.Cells("IS_REFER_PICKUP").Value = True Then
            UpdateSNBook.ChReferral.Checked = True
            UpdateSNBook.RadReferAndPickup.Checked = GRows.Cells("IS_REFER_PICKUP").Value
        End If

        If UpdateSNBook.ShowDialog = DialogResult.OK Then
            DGScreeningBook.DataSource = DAScreeningBookDetail.SelectScreenBookDateToDateWithPatientNo(DateFrom.Value.Date, DateTo.Value.Date, EmptyString(UpdateSNBook.PatientNo.Text))
            DisplayUtiliyBookByScreenID(CDbl(UpdateSNBook.LblSaveOption.Text))
            ModCommon.NumberAllRowHeaderDataGrid(DGScreeningBook)
        End If
    End Sub
    Public Sub RefreshAfterScreenRegis(ByVal DFrom As Date, ByVal DTo As Date, ByVal PatientNo As Double)
        DGScreeningBook.DataSource = DAScreeningBookDetail.SelectScreenBookDateToDateWithPatientNo(DFrom, DTo, EmptyString(PatientNo))
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



    Private Sub BtnNewReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferral.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub

        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        'If (GRows.Cells("IS_REFER_PICKUP").Value) = False AndAlso (GRows.Cells("IS_REFER_BYSELF").Value) = False Then Exit Sub
        Dim FReferral As New FormReferral
        If FReferral.DAReferralBook.CheckExistingBookID(GRows.Cells("SCREEN_BOOKID").Value) <> 0 Then
            MessageBox.Show("The patient already register into referral book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FReferral.Close()
            FReferral.Dispose()
            Exit Sub
        End If
        FReferral.LblSaveOption.Text = "0"
        FReferral.LblScreenBookID.Text = GRows.Cells("SCREEN_BOOKID").Value
        FReferral.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        FReferral.PatientNo.Text = GRows.Cells("PatientNo").Value
        FReferral.PatientName.Text = GRows.Cells("NameEng").Value
        FReferral.PatientSex.Text = GRows.Cells("Sex").Value
        FReferral.PatientAge.Text = GRows.Cells("Age").Value
        FReferral.CboOnEye.Text = GRows.Cells("ON_EYE").Value
        FReferral.cboDiagnosis.Text = GRows.Cells("DIAGNOSISScreening").Value
        FReferral.CboVARight.Text = GRows.Cells("VA_RIGHTScreening").Value
        FReferral.CboVALeft.Text = GRows.Cells("VA_LEFTScreening").Value
        FReferral.ChPickup.Enabled = True
        If FReferral.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnUpdateOpticalshop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateOpticalshop.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GRows.Cells("IS_OPTICALSHOP").Value) = False Then Exit Sub
        Dim FOpticalShop As New FormOpticalShop
        FOpticalShop.LblSaveOption.Text = GRows.Cells("SCREEN_BOOKID").Value
        FOpticalShop.LblScreenBookID.Text = GRows.Cells("SCREEN_BOOKID").Value
        FOpticalShop.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        FOpticalShop.PatientNo.Text = GRows.Cells("PatientNo").Value
        FOpticalShop.PatientName.Text = GRows.Cells("NameEng").Value
        FOpticalShop.PatientSex.Text = GRows.Cells("Sex").Value
        FOpticalShop.PatientAge.Text = GRows.Cells("Age").Value
        If FOpticalShop.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub NewOpticalShopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewOpticalShopToolStripMenuItem.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub
        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GRows.Cells("IS_OPTICALSHOP").Value) = False Then Exit Sub
        Dim FOpticalShop As New FormOpticalShop
        If FOpticalShop.DAOpticalShopBook.CheckExistingOpShop(GRows.Cells("SCREEN_BOOKID").Value) <> 0 Then
            MessageBox.Show("The patient already register into optical shop book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FOpticalShop.Close()
            FOpticalShop.Dispose()
            Exit Sub
        End If
        FOpticalShop.LblSaveOption.Text = "0"
        FOpticalShop.LblScreenBookID.Text = GRows.Cells("SCREEN_BOOKID").Value
        FOpticalShop.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        FOpticalShop.PatientNo.Text = GRows.Cells("PatientNo").Value
        FOpticalShop.PatientName.Text = GRows.Cells("NameEng").Value
        FOpticalShop.PatientSex.Text = GRows.Cells("Sex").Value
        FOpticalShop.PatientAge.Text = GRows.Cells("Age").Value
        If FOpticalShop.ShowDialog() = DialogResult.OK Then

        End If
    End Sub


    Private Sub UpdateRefractionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateRefractionToolStripMenuItem.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub

        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GRows.Cells("IS_REFRACTION").Value) = False Then Exit Sub
        Dim FRefraction As New FormRefraction
        'If FReferral.DAReferralBook.CheckExistingBookID(GRows.Cells("SCREEN_BOOKID").Value) <> 0 Then
        '    MessageBox.Show("The patient already register into referral book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    FReferral.Close()
        '    FReferral.Dispose()
        '    Exit Sub
        'End If
        FRefraction.LblSaveOption.Text = "0"
        FRefraction.LblScreenBookID.Text = GRows.Cells("SCREEN_BOOKID").Value
        FRefraction.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        FRefraction.PatientNo.Text = GRows.Cells("PatientNo").Value
        FRefraction.PatientName.Text = GRows.Cells("NameEng").Value
        FRefraction.PatientSex.Text = GRows.Cells("Sex").Value
        FRefraction.PatientAge.Text = GRows.Cells("Age").Value
        FRefraction.CboOnEye.Text = GRows.Cells("ON_EYE").Value
        FRefraction.cboDiagnosis.Text = GRows.Cells("DIAGNOSISScreening").Value
        FRefraction.CboVARight.Text = GRows.Cells("VA_RIGHTScreening").Value
        FRefraction.CboVALeft.Text = GRows.Cells("VA_LEFTScreening").Value
        If FRefraction.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub NewRefractionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRefractionToolStripMenuItem.Click
        If DGScreeningBook.SelectedCells.Count = 0 Then Exit Sub

        Dim GRows As DataGridViewRow = GetDataRowGridView(DGScreeningBook)
        If (GRows.Cells("IS_REFRACTION").Value) = False Then Exit Sub
        Dim FRefraction As New FormRefraction
        If FRefraction.DARefraction.CheckExistingRefraction(GRows.Cells("SCREEN_BOOKID").Value) <> 0 Then
            MessageBox.Show("The patient already register into referral book. please check again!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FRefraction.Close()
            FRefraction.Dispose()
            Exit Sub
        End If
        FRefraction.LblSaveOption.Text = GRows.Cells("SCREEN_BOOKID").Value
        FRefraction.LblScreenBookID.Text = GRows.Cells("SCREEN_BOOKID").Value
        FRefraction.DateScreening.Value = GRows.Cells("SCREAN_DATE").Value
        FRefraction.PatientNo.Text = GRows.Cells("PatientNo").Value
        FRefraction.PatientName.Text = GRows.Cells("NameEng").Value
        FRefraction.PatientSex.Text = GRows.Cells("Sex").Value
        FRefraction.PatientAge.Text = GRows.Cells("Age").Value
        FRefraction.CboOnEye.Text = GRows.Cells("ON_EYE").Value
        FRefraction.cboDiagnosis.Text = GRows.Cells("DIAGNOSISScreening").Value
        FRefraction.CboVARight.Text = GRows.Cells("VA_RIGHTScreening").Value
        FRefraction.CboVALeft.Text = GRows.Cells("VA_LEFTScreening").Value
        If FRefraction.ShowDialog() = DialogResult.OK Then

        End If
    End Sub
    ' Call Index grid to import user
    Private IndexGrid As Integer = 0
    Private PateintTEHNo As Double = 0
    Dim DAPatientTEH As New DatasetPatientTEHTableAdapters.PATIENT_SCREENING_INFOTableAdapter
    Dim DADateServer As New DatasetPatientTEHTableAdapters.TableGetDateServerTableAdapter
    Private Sub PicStartImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicStartImport.Click
        If MessageBox.Show("Do you want to import patients to TEH sys?", "Screening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            UIMainScreening.StatusLoading(True, "Loading")
            BGImportToTEH.RunWorkerAsync()
        End If
        
    End Sub
    'Declare for patient para:
    Dim PatientScreenNo, PatientSReferNo As Double
    Dim PatientTEHNo As Double
    Dim PatientSEngName, PatientSKhname, PatientSProvince, PatientSDistrict, PatientSCommune, PatientSAddress, PatientSSex, PatientSMale, PatientSFemale, ScreeningPlace As String
    Dim PatientSAge As Integer

    Private Sub ImportPatientScreeningToTEH()
        IndexGrid = 0
        For I As Integer = 0 To DGScreeningBook.Rows.Count - 1 'GRows.Cells.Count - 1
            IndexGrid = I
            PatientTEHNo = 0
            If DAPatientTEH.CheckExistingPatient(GeneratePatientNoForTEH) > 0 Then
                PateintTEHNo = GeneratePatientNoForTEH()
            Else
                PateintTEHNo = GeneratePatientNoForTEH()
            End If
            PatientScreenNo = DGScreeningBook.Rows(IndexGrid).Cells("PatientNo").Value

            PatientSReferNo = DGScreeningBook.Rows(IndexGrid).Cells("REFERENCE_PATIENNOTE").Value
            PatientSEngName = DGScreeningBook.Rows(IndexGrid).Cells("NameEng").Value
            PatientSKhname = DGScreeningBook.Rows(IndexGrid).Cells("NameKhmer").Value
            PatientSProvince = DGScreeningBook.Rows(IndexGrid).Cells("Province").Value
            PatientSDistrict = DGScreeningBook.Rows(IndexGrid).Cells("District").Value
            PatientSCommune = DGScreeningBook.Rows(IndexGrid).Cells("Commune").Value
            PatientSAddress = DGScreeningBook.Rows(IndexGrid).Cells("Address").Value
            'PatientSMale = DGScreeningBook.Rows(IndexGrid).Cells("Male").Value
            'PatientSFemale = DGScreeningBook.Rows(IndexGrid).Cells("Female").Value
            PatientSSex = DGScreeningBook.Rows(IndexGrid).Cells("Sex").Value
            PatientSAge = DGScreeningBook.Rows(IndexGrid).Cells("Age").Value
            ScreeningPlace = DGScreeningBook.Rows(IndexGrid).Cells("SCREEN_PLACE").Value


            If CBool(DAScreeningBook.CheckStatusImport(PatientScreenNo)) = False And DAPatientTEH.CheckExistingScreeningNo(PatientScreenNo) = 0 Then
                Application.DoEvents()
                UIMainScreening.StatusUpdateLabel("Importing Patient:" & PatientScreenNo)
                If DAPatientTEH.ImportPatientScreeningToTEHSys(PateintTEHNo, DADateServer.SelectDateSVR.Value.Date, PatientSProvince, PatientSDistrict, PatientSCommune, PatientSEngName, PatientSKhname, PatientSAge, PatientSMale, PatientSFemale, PatientSSex, PatientSAddress, "", "", DADateServer.SelectDateSVR.Value.Year, ScreeningPlace, Format(DADateServer.SelectDateSVR, "HH:mm:ss"), PatientScreenNo, True, Now.Date, PatientSReferNo) = 1 Then
                    DAScreeningBook.UpateStatusImport(True, PatientScreenNo)
                    DGScreeningBook.Rows(IndexGrid).Cells("IMPORT_STATUS").Value = True
                End If

            Else
                Application.DoEvents()
                UIMainScreening.StatusUpdateLabel(PatientScreenNo & " Imported")
            End If

            Threading.Thread.Sleep(10)
            Application.DoEvents()
            ' MessageBox.Show(DGScreeningBook.Rows(IndexGrid).Cells("PatientNo").Value)
            DGScreeningBook.ClearSelection()
            'DGScreeningBook.CurrentCell = DGScreeningBook.Rows(IndexGrid).Cells(0)
            DGScreeningBook.Rows(IndexGrid).Selected = True
            'DGScreeningBook.BeginEdit(False)
            'DGScreeningBook.CurrentCell = DGScreeningBook.Rows( '.Item(0, IndexGrid)  'DGScreeningBook.Rows(IndexGrid).Cells(0)

            IndexGrid = IndexGrid + I
        Next
    End Sub
    Function GeneratePatientNoForTEH() As String
        Dim DateServerTEH As Date = DADateServer.SelectDateSVR
        Dim Years As Integer = DateServerTEH.Year
        Dim Month As String = DateServerTEH.Month.ToString
        If Month.Length = 1 Then
            Month = "0" & Month
        Else
            Month = Month
        End If
        Dim IDHN As Double
        Try
            'MsgBox("SELECT MAX(" & FieldNo & ") FROM " & Table & " Where Years=" & Years & "")
            IDHN = DAPatientTEH.AutoNoPatient(Years) + 1  'ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar("SELECT COUNT(" & FieldNo & ") FROM " & Table & " WHERE YEARS=" & years) + 1
        Catch ex As Exception
            IDHN = 1
        End Try
        Return Years & Month.ToString & IDHN.ToString
    End Function

    Private Sub BGImportToTEH_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGImportToTEH.DoWork
        ImportPatientScreeningToTEH()
    End Sub

    Private Sub BGImportToTEH_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGImportToTEH.RunWorkerCompleted
        UIMainScreening.StatusLoading(False, "Loading")
        MessageBox.Show("Import patients is done!", "Screening", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
