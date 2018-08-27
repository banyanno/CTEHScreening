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
        LoadNewPatientNo()
        LoadDefaultAddressSetting()
    End Sub
    Sub LoadNewPatientNo()
        PatientNo.Text = ModCommon.GenerateNo("No", "TblPatients")
        'txtHN.Text = TxtPatientNo.Text
    End Sub

    Function SaveProcessForNewPatient() As Boolean
        If ModCommon.CheckDuplicateHN(Me.PatientNo.Text, "TblPatients") = True Then      '------------recall HN after redundency----------
            LoadNewPatientNo()
        End If

        '---------------Renew Receipt ID First time before saving----------------------------------------------------------

        Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim sqlComm As SqlClient.SqlCommand = Con.CreateCommand
        Dim Transaction As SqlClient.SqlTransaction = Nothing
        Transaction = Con.BeginTransaction
        sqlComm.Transaction = Transaction
        Try
            ' ========== Save New patient information =======================
            sqlComm.CommandText = SqlPatientInformation()
            sqlComm.ExecuteNonQuery()


            ' ========== Save new Screening book ================================

            sqlComm.CommandText = ScreeningBook()
            sqlComm.ExecuteNonQuery()
            '=========== Save Patient Referral Detail ======================

            'For i As Int16 = 0 To ChListReferral.Items.Count - 1
            '    If ChListReferral.GetItemChecked(i) = True Then
            '        sqlComm.CommandText = SQLSavePatientReferral(TxtPatientNo.Text, ChListReferral.Items(i))
            '        sqlComm.ExecuteNonQuery()
            '    End If
            'Next

            '' =========== Save New Patient Receipt =========================
            'If Free = False Then
            '    sqlComm.CommandText = SqlNewPatientReceipt()
            '    sqlComm.ExecuteNonQuery()
            'End If

            ' =========== Save patient into patient followup ==================
            'sqlComm.CommandText = SqlRegistrationFormForReferal()
            'sqlComm.ExecuteNonQuery()
            ' =========== Save Patient into Book New Patient         ==================
            'sqlComm.CommandText = SqlNewPatientBook()
            'sqlComm.ExecuteNonQuery()
            'If CheckMoPoGo() = True Then
            '    'Dim FMoPoCode As New FEnterMoPoTsyoCode
            '    'If FMoPoCode.ShowDialog = Windows.Forms.DialogResult.OK Then

            '    sqlComm.CommandText = SavePatientMoPoTyso(TxtPatientNo.Text, FormatDateTime(DateRegistration.Value, DateFormat.ShortDate))
            '    sqlComm.ExecuteNonQuery()
            '    'Else
            '    '    Exit Function

            'End If
            ' =========== End Transaction Patient Registration Form ==============
            Transaction.Commit()
            Transaction.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Transaction.Rollback()
            'EnableFormControl()
            Return False
        Finally
            Con.Close()
            Con.Dispose()
        End Try
    End Function
    ' Registration New Pateint 
    Function SqlPatientInformation() As String
        Return StringPatientInformation(PatientNo.Text, DateRegis.Value.Date, CboProNo.Text, _
                                        CboDisNo.Text, CboCommNo.Text, TxtPatientName.Text, _
                                        TxtPatientName.Text, TxtAge.Text, CboSex.Text, _
                                        TxtFullAddress.Text, "", TxtTel.Text, "", _
                                        DateRegis.Value.Year, ModGlobleVariable.ACHIEVE, False, GetTextReferralV1, Format(GetDateServer, "hh:mm:ss tt").ToString)
    End Function



    Function StringPatientInformation( _
      ByVal PatientNo As String, _
      ByVal CreateDate As String, _
     ByVal province As String, _
     ByVal District As String, _
     ByVal Commune As String, _
     ByVal NameEng As String, _
     ByVal NameKh As String, _
     ByVal Age As String, _
     ByVal Sex As String, _
     ByVal address As String, _
     ByVal Occupation As String, _
     ByVal Tel As String, _
     ByVal neighbor As String, _
     ByVal Years As Integer, _
     ByVal Achieve As Boolean, _
     ByVal Is_MoPoTsyo As Boolean, ByVal ComBindRefferal As String, ByVal TIME_CREATE As String) As String
        Dim Field As String = ""
        If Sex = "M" Then
            Field = "Male"
        Else
            Field = "Female"
        End If
        Dim sql As String = "INSERT INTO TblPatients (" & _
        "PatientNo," & _
        "CreateDate," & _
        "Province," & _
        "District," & _
        "Commune," & _
        "NameEng," & _
        "NameKhmer," & _
        "Age," & Field & " ," & _
        "Sex," & _
        "Address," & _
        "Occupation," & _
        "Telephone," & _
        "Neighborly," & _
        "Years,Achieve,Is_MoPoTsyo,ComBindRefferal,TIME_CREATE) " & _
        " VALUES(" & PatientNo & " ,'" & _
        CreateDate & "','" & _
       province.Replace("'", "''") & "','" & _
        District.Replace("'", "''") & "','" & _
        Commune.Replace("'", "''") & "','" & _
        NameEng.Replace("'", "''") & "','" & _
        NameKh.Replace("'", "''") & "'," & _
        Age & ",'" & _
        Sex & "','" & _
        Sex & "','" & _
        address.Replace("'", "''") & "','" & _
        Occupation.Replace("'", "''") & "','" & _
        Tel.Replace("'", "''") & "','" & _
        neighbor.Replace("'", "''") & "'," & Years & ",'" & Achieve & "','" & Is_MoPoTsyo & "','" & ComBindRefferal & "','" & TIME_CREATE & "')"
        Return sql
    End Function

    Private Function ScreeningBook() As String
        Return InsertScreenBook(DateRegis.Value.Date, TxtHealthNameCenter.Text, LblSettingID.Text, PatientNo.Text, ChRefraction.Checked, ChOpticalshop.Checked, ChReferAndPickup.Checked, ChReferAndComeBySelf.Checked, TxtRegisterNote.Text)
    End Function
    Private Function InsertScreenBook(ByVal SCREAN_DATE As DateTime, ByVal SCREEN_PLACE As String, ByVal SCREEN_ID As Integer, ByVal PATIENT_NO As Double, ByVal IS_REFRACTION As Boolean, ByVal IS_OPTICALSHOP As Boolean, ByVal IS_REFER_PICKUP As Boolean, ByVal IS_REFER_BYSELF As Boolean, ByVal SCREEN_NOTE As String) As String
        Dim sql As String = "INSERT INTO SCREENING_BOOK (SCREAN_DATE,SCREEN_PLACE,SYS_SETTING,PATIENT_NO,IS_REFRACTION,IS_OPTICALSHOP,IS_REFER_PICKUP,IS_REFER_BYSELF,SCREEN_NOTE) VALUES('" & SCREAN_DATE & "','" & SCREEN_PLACE & "'," & SCREEN_ID & "," & PATIENT_NO & ",'" & IS_REFRACTION & "','" & IS_OPTICALSHOP & "','" & IS_REFER_PICKUP & "','" & IS_REFER_BYSELF & "','" & SCREEN_NOTE & "')"
        Return sql
    End Function


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

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(DateRegis, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(PatientNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtHealthNameCenter, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboSex, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtTel, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboProNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboDisNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateCombobox(CboCommNo, "", ErrSaveRegis) = False Then Exit Sub
        If ValidateTextField(TxtFullAddress, "", ErrSaveRegis) = False Then Exit Sub
        If SaveProcessForNewPatient() = True Then

        End If

    End Sub
End Class