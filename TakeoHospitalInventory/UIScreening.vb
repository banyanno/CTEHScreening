Public Class UIScreening
    Dim MScreening As MainScreening
    Dim Login As frmLoginInventory


    Public Department As UCDepartment
    Public LabourFac As UCLabourFactory
    Public Chemical As UCChemical
    Public UContainer As UCContainer
    Public UItemUnit As UCItemUnit
    Public UVendor As UCVendor
    Public UCate As UCCategories
    Public UFixAsset As UFixInventory
    Public UCabinet As UCCabinet
    Public UNewReceipt As MainOpticalShop

    Public UIncomeStatementOpticalShop As UCOpticalshopIncomStatement
    Public URequestOrderDep As New UCRequestOrder_V1
    Public UReciepReques As UCReceivedRequest
    Dim UDepToDep As UCDepartReceivedRequest
    Dim UDepartmentCurrenstock As UCDepartCurrentStock

    Dim DashboardWaitingPayment As UCDashboardWaitingPayment
    Dim DashBoardPatientConsult As MainConsuling
    Dim DashBordMedicalCertificate As MainMedicalCertificate
    Dim UVendor_V1 As UCVendor_V1
    Dim UDashboardAdjustStock As UCDashboardAdjustStock
    Dim UPrescriptionList As UCPrescriptionList
    Dim UMedicineOutsideHospital As UCMedicineOutsideHospital
    Dim UAppointment As UCAppointment
    Dim UCaritasRequestOrder As UCCaritasRequestOrder
    Dim UCountry As UCCountry

    Dim UOPStatisticReport As UCOpticalShopStatistic
    ' Dim UDasboardNil As UCDashBoardNil
    Dim UItemExpiredDate As UCItemExpiredDate

    'User Control for Takeo Eye hospital
    'Public UIScreen As New UIScreening
    Public ReceivePayemtn As DashbordReceiveReceipt

    Public examinationForm As UCRegistrationForm
    Public bed As UCBed
    Public newInPatient As UCNewInPatient
    Public CashReceipDashboad As UCDashbordCashReceipt
    Public CashCollection As UCashCollection
    Public WeeklySummary As UWeeklyCashCollection
    Public NewOldPatientBook As UCMainNew_Outpatient

    Public OldOutpatient As UCMainOld_Outpatient
    Public Inpatient As UCMainInpatient
    Public ConsultEachProvince As UCEachProvinceAndDistrict
    Public patientReferal As UCPatientReportUtility
    Public patientAchieve As UCAchievePatient
    Public AccountPayAble As UCMainAcountPayable
    Public patientVA As UCMainVA
    Public patientRefraction As MainRefraction
    Public PatientRefer As CUReferMain
    Public ReportOutPatient As UCOutPatientReport
    Public ReportInpatient As UCInpatientReport
    Public ReportOperation As UCOperationReport
    Public OT_AND_IOLlist As UCOT_AND_IOLList
    Public PostponeOT As New DashbardPostoneCancelOT
    Public Doctor As UCDoctor
    Public Diagnosis As UCDiagnosisAndSurgeries
    Dim UserManagement As UCMainUserManagement
    Public ProvinceAndOccupation As UCProvinceAndOccupation
    Dim URunEOD As UCRunEndOfDay
    Dim UShowAllItemBalacne As UIShowAllItemBalanceInDeppartment
    Dim UInhouseUsedITem As UCInhouseUsedItem
    Dim UBarcode As UIBarcodeGenerator
    Dim UReportItemTransaction As UCReportItemTransaction
    Dim URefferral As UCRefferralOfTEH

    Sub New(ByVal MScreening As MainScreening, ByVal LoginForm As frmLoginInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MScreening = MScreening
        Me.Login = LoginForm
        InitUserControle()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public PatientPayment As UCPatientPayment
    Public ScreenDashboard As DashboardScreeningRegisBook
    Public ScreenSetting As DashboardSetting
    Sub InitUserControle()
        Me.Login.UpdateLabelStatus("Checking Permission", True)
        Application.DoEvents()
        ReceivePayemtn = New DashbordReceiveReceipt(Me.MScreening)
        Login.UpdateLabelStatus("Creating user interface 1.", True)
        Application.DoEvents()
        PatientPayment = New UCPatientPayment(Me.MScreening)
        Login.UpdateLabelStatus("Creating user interface 2.", True)
        Application.DoEvents()
        examinationForm = New UCRegistrationForm
        Login.UpdateLabelStatus("Creating user interface 3.", True)
        Application.DoEvents()
        bed = New UCBed
        Login.UpdateLabelStatus("Creating user interface 4.", True)
        Application.DoEvents()
        'newInPatient = New UCNewInPatient(Me.MScreening)
        Login.UpdateLabelStatus("Creating user interface 5.", True)
        Application.DoEvents()
        CashReceipDashboad = New UCDashbordCashReceipt
        Login.UpdateLabelStatus("Creating user interface 6.", True)
        Application.DoEvents()
        CashCollection = New UCashCollection
        Login.UpdateLabelStatus("Creating user interface 7.", True)
        Application.DoEvents()
        WeeklySummary = New UWeeklyCashCollection
        Login.UpdateLabelStatus("Creating user interface 8.", True)
        Application.DoEvents()
        NewOldPatientBook = New UCMainNew_Outpatient(Me.MScreening)
        Login.UpdateLabelStatus("Creating user interface 9.", True)
        Application.DoEvents()
        ' OldOutpatient = New UCMainOld_Outpatient(Me)
        Login.UpdateLabelStatus("Creating user interface 10.", True)
        Application.DoEvents()
        Inpatient = New UCMainInpatient
        Login.UpdateLabelStatus("Creating user interface 11.", True)
        Application.DoEvents()
        'ConsultEachProvince = New UCEachProvinceAndDistrict(Me)
        Login.UpdateLabelStatus("Creating user interface 12.", True)
        Application.DoEvents()
        patientReferal = New UCPatientReportUtility()
        Login.UpdateLabelStatus("Creating user interface 13.", True)
        Application.DoEvents()
        patientAchieve = New UCAchievePatient
        Login.UpdateLabelStatus("Creating user interface 14.", True)
        Application.DoEvents()
        patientVA = New UCMainVA
        Login.UpdateLabelStatus("Creating user interface 15.", True)
        Application.DoEvents()
        patientRefraction = New MainRefraction
        Login.UpdateLabelStatus("Creating user interface refraction.", True)
        Application.DoEvents()
        PatientRefer = New CUReferMain
        Login.UpdateLabelStatus("Creating user interface 16.", True)
        Application.DoEvents()
        'ReportOutPatient = New UCOutPatientReport(Me)
        Login.UpdateLabelStatus("Creating user interface 17.", True)
        Application.DoEvents()
        'ReportInpatient = New UCInpatientReport(Me)
        Login.UpdateLabelStatus("Creating user interface 18.", True)
        Application.DoEvents()
        ' ReportOperation = New UCOperationReport(Me)
        Login.UpdateLabelStatus("Creating user interface 19.", True)
        Application.DoEvents()
        OT_AND_IOLlist = New UCOT_AND_IOLList
        Login.UpdateLabelStatus("Creating user interface 20.", True)
        Application.DoEvents()
        Doctor = New UCDoctor
        Login.UpdateLabelStatus("Creating user interface 21.", True)
        Application.DoEvents()
        Diagnosis = New UCDiagnosisAndSurgeries
        Login.UpdateLabelStatus("Creating user interface 22.", True)
        Application.DoEvents()
        UserManagement = New UCMainUserManagement
        Login.UpdateLabelStatus("Creating user interface 23.", True)
        Application.DoEvents()
        ProvinceAndOccupation = New UCProvinceAndOccupation
        Login.UpdateLabelStatus("Creating user interface 24.", True)
        Application.DoEvents()
        ' URunEOD = New UCRunEndOfDay(Me)
        Login.UpdateLabelStatus("Creating user interface 25.", True)
        Application.DoEvents()
        ' UShowAllItemBalacne = New UIShowAllItemBalanceInDeppartment(Me)
        Login.UpdateLabelStatus("Creating user interface 26.", True)
        Application.DoEvents()
        UInhouseUsedITem = New UCInhouseUsedItem
        Login.UpdateLabelStatus("Creating user interface 27.", True)
        Application.DoEvents()
        UBarcode = New UIBarcodeGenerator
        Login.UpdateLabelStatus("Creating user interface 28.", True)
        Application.DoEvents()
        'UReportItemTransaction = New UCReportItemTransaction(Me)
        Login.UpdateLabelStatus("Creating user interface 29.", True)
        Application.DoEvents()
        URefferral = New UCRefferralOfTEH

        '=========== Checking user interface
        Department = New UCDepartment
        Login.UpdateLabelStatus("Creating user interface 30.", True)
        Application.DoEvents()
        LabourFac = New UCLabourFactory
        Login.UpdateLabelStatus("Creating user interface 31.", True)
        Application.DoEvents()
        Chemical = New UCChemical
        Login.UpdateLabelStatus("Creating user interface 32.", True)
        Application.DoEvents()
        UContainer = New UCContainer
        Login.UpdateLabelStatus("Creating user interface 33.", True)
        Application.DoEvents()
        UItemUnit = New UCItemUnit
        Login.UpdateLabelStatus("Creating user interface 34.", True)
        Application.DoEvents()
        UVendor = New UCVendor
        Login.UpdateLabelStatus("Creating user interface 35.", True)
        Application.DoEvents()
        'UCate = New UCCategories(Me)
        Login.UpdateLabelStatus("Create interface Fix asset", True)
        UFixAsset = New UFixInventory
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 36.", True)
        Application.DoEvents()
        UCabinet = New UCCabinet
        Login.UpdateLabelStatus("Creating user interface 37.", True)
        Application.DoEvents()
        'UNewReceipt = New MainOpticalShop(Me)
        Login.UpdateLabelStatus("Creating user interface 38.", True)
        Application.DoEvents()

        Login.UpdateLabelStatus("Creating user interface 39.", True)
        Application.DoEvents()
        ' UIncomeStatementOpticalShop = New UCOpticalshopIncomStatement(Me)
        Login.UpdateLabelStatus("Creating user interface 40.", True)
        Application.DoEvents()
        UReciepReques = New UCReceivedRequest
        Login.UpdateLabelStatus("Creating user interface 41.", True)
        Application.DoEvents()
        UDepToDep = New UCDepartReceivedRequest
        Login.UpdateLabelStatus("Creating user interface 42.", True)
        Application.DoEvents()
        ' UDepartmentCurrenstock = New UCDepartCurrentStock(Me)
        Login.UpdateLabelStatus("Creating user interface 43.", True)
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 44.", True)
        Application.DoEvents()
        DashboardWaitingPayment = New UCDashboardWaitingPayment
        Login.UpdateLabelStatus("Creating user interface 45.", True)
        ' DashBoardPatientConsult = New MainConsuling(Me)
        Application.DoEvents()
        ' DashBordMedicalCertificate = New MainMedicalCertificate(Me)
        UVendor_V1 = New UCVendor_V1
        UDashboardAdjustStock = New UCDashboardAdjustStock
        Login.UpdateLabelStatus("Creating user interface 46.", True)
        Application.DoEvents()
        'UPrescriptionList = New UCPrescriptionList(Me)
        Application.DoEvents()
        UMedicineOutsideHospital = New UCMedicineOutsideHospital
        Login.UpdateLabelStatus("Creating user interface 47.", True)
        Application.DoEvents()
        UAppointment = New UCAppointment()
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 47", True)
        UCaritasRequestOrder = New UCCaritasRequestOrder
        Login.UpdateLabelStatus("Creating user interface 48.", True)
        Application.DoEvents()
        UCountry = New UCCountry
        Login.UpdateLabelStatus("Creating user interface 49.", True)
        Application.DoEvents()

        Login.UpdateLabelStatus("Creating user interface 50.", True)
        Application.DoEvents()
        ' UOPStatisticReport = New UCOpticalShopStatistic(Me)
        Login.UpdateLabelStatus("It is done creatint user interface.", True)
        Application.DoEvents()
        'UDasboardNil = New UCDashBoardNil(Me)
        ' AccountPayAble = New UCMainAcountPayable(Me)
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()

        'UItemExpiredDate = New UCItemExpiredDate(Me)
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        DEP_EOD = URunEOD


        '=============== Start Screening Interface ======================================
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        ScreenDashboard = New DashboardScreeningRegisBook

        Login.UpdateLabelStatus("Create user interface.", True)
        Application.DoEvents()
        ScreenSetting = New DashboardSetting
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
        'SetVisibleEnvisibleMenu()
        AddUserControl(MScreening.PanelHeader, MScreening.PanelDedail, PatientPayment, "", True)
    End Sub

    Private Sub BtnNavigationBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNavigationBar.Click
        SetVisibleEnvisibleMenu()
    End Sub


    Private Sub BtnPatientRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPatientRegistration.Click
        AddUserControl(MScreening.PanelHeader, MScreening.PanelDedail, PatientPayment, "", True)
    End Sub

    Private Sub BtnNewPatientBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPatientBook.Click
        AddUserControl(MScreening.PanelHeader, MScreening.PanelDedail, NewOldPatientBook, "", True)
    End Sub

    Private Sub BtnScreeningBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScreeningBook.Click
        AddUserControl(MScreening.PanelHeader, MScreening.PanelDedail, ScreenDashboard, "", True)
    End Sub

    Private Sub BtnScreeningSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScreeningSetting.Click
        AddUserControl(MScreening.PanelHeader, MScreening.PanelDedail, ScreenSetting, "", True)
    End Sub
End Class
