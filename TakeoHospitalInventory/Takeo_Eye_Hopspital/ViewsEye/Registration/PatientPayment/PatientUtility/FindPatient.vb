Public Class FindPatient
    Dim DashboarPatient As UCPatientPayment
    Sub New(ByVal DashboarPatient As UCPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DashboarPatient = DashboarPatient
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Me.DashboarPatient.ActionFindPatien(EmptyString(TxtPatientSearchNo.Text.Trim), EmptyString(TxtOldPatientNo.Text.Trim), DateRFrom.Value, DateRTo.Value, _
            txtEngName.Text.Trim, _
            txtKhmerName.Text.Trim, _
            cboSex.Text.Trim, _
            cboProvince.Text.Trim, _
            cboDistrict.Text.Trim, _
            cboCommune.Text.Trim)
    End Sub
End Class