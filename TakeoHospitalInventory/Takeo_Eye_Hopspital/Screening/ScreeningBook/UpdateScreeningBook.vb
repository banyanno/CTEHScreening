Public Class UpdateScreeningBook
    Dim DADiagnosis As New DataSetScreeningBookTableAdapters.TblSurgeryTableAdapter
    Dim DAVA As New DataSetScreeningBookTableAdapters.REFRACTION_VATableAdapter
    Dim DAScreeningBook As New DataSetScreeningBookTableAdapters.SCREENING_BOOKTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With cboDiagnosis
            .DataSource = DADiagnosis.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
        End With
        With CboVARight
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
        With CboVALeft
            .DataSource = DAVA.GetData
            .DisplayMember = "REFRA_VA"
            .ValueMember = "RFRA_VA_ID"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        ' Call when we mouse move on Panel
        ModCommon.ReleaseCapture()
        ModCommon.SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblSaveOption.Text <> "0" Then
            If MessageBox.Show("Do you want to update screening book?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DAScreeningBook.UpdateScreeningBook(DateScreening.Value.Date, ChRefraction.Checked, ChOpticalshop.Checked, RadReferAndPickup.Checked, RadReferAndPickup.Checked, TxtMoreInfo.Text, CboOnEye.Text, TxtComplain.Text, cboDiagnosis.Text, CboVARight.Text, CboVALeft.Text, TxtPlaceScreening.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub ChReferral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChReferral.CheckedChanged
        GBReferral.Enabled = ChReferral.Checked
        If ChReferral.Checked = False Then
            RadReferAndComeBySelf.Checked = False
            RadReferAndPickup.Checked = False
        End If
    End Sub
End Class