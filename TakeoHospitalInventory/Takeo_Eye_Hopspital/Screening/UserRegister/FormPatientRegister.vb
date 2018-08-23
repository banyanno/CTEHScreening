Public Class FormPatientRegister
    Dim DA_DefaultSetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboProNo
            .DataSource = ModProvince.SelectProvice()
            .DisplayMember = "Province"
            .ValueMember = "IDProvCode"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FormPatientRegister_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        MoveFormOnMouseDown(e)
    End Sub

    Private Sub FormPatientRegister_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        MoveFormOnMouseMove(e, Me)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Public Sub LoadDefaultAddressSetting()
        Dim TblSetting As DataTable = DA_DefaultSetting.SelectDefaultSetting
        For Each rows As DataRow In TblSetting.Rows
            LblSettingID.Text = rows("SETTING_ID").ToString()
            TxtHealthNameCenter.Text = rows("HEALTH_NAME").ToString
            CboProNo.Text = rows("PROVINCE").ToString
            CboDisNo.Text = rows("DISTRICT").ToString
            CboCommNo.Text = rows("COMMUNE").ToString
            TxtFullAddress.Text = rows("FULL_ADDRESS").ToString
        Next
    End Sub

    Private Sub FormPatientRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefaultAddressSetting()
    End Sub

    Private Sub CboDisNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDisNo.DropDown
        If ValidateCombobox(CboProNo, "", ErrSaveRegis) = False Then Exit Sub
        With CboDisNo
            .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
            .DisplayMember = "DISTRICT"
            .ValueMember = "SrokCode"
        End With
    End Sub

    Private Sub CboCommNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.DropDown
        If ValidateCombobox(CboDisNo, "", ErrSaveRegis) = False Then Exit Sub
        With CboCommNo
            .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
            .DisplayMember = "Commune"
            .ValueMember = "KhumCode"
        End With
    End Sub

    Private Sub CboProNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProNo.DropDown
        CboDisNo.Text = ""
        CboCommNo.Text = ""
        TxtFullAddress.Text = ""
    End Sub
End Class