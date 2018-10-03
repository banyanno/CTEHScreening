Public Class DashboardReportUtility
    Dim DAScreening As New DataSetScreeningBookTableAdapters.SCREENING_BOOK_VIEWTableAdapter
    Dim DAScreeningSetting As New DataSetSceenSettingTableAdapters.SCREEN_SYSTEMSETTINGTableAdapter
    Dim TableReport As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboScreeningPlace
            .DataSource = DAScreeningSetting.GetData
            .ValueMember = "SETTING_ID"
            .DisplayMember = "HEALTH_NAME"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnScreeningBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScreeningBook.Click
        UIMainScreening.StatusLoading(True, "Loading")
        BGloadingReport.RunWorkerAsync()
        
    End Sub

    Private Sub ChScreeningPlace_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChScreeningPlace.CheckedChanged
        CboScreeningPlace.Enabled = ChScreeningPlace.Checked
    End Sub
    Private Sub PrintReportUtiliy()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf PrintReportUtiliy))
        Else
            If RadAllScreening.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TableReport = DAScreening.SelectTotalRefractionWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                Else
                    TableReport = DAScreening.SelectTotalScreening(DateFrom.Value.Date, DateTo.Value.Date)
                End If

            ElseIf RadRefraction.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TableReport = DAScreening.SelectTotalRefractionWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                Else
                    TableReport = DAScreening.SelectTotalRefraction(DateFrom.Value.Date, DateTo.Value.Date)
                End If
            ElseIf RadReferalBySelf.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TableReport = DAScreening.SelectTotalReferbySelfWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                Else
                    TableReport = DAScreening.SelectTotalReferBySelf(DateFrom.Value.Date, DateTo.Value.Date)
                End If
            ElseIf RadReferPickup.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TableReport = DAScreening.SelectTotalReferPickupWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                Else
                    TableReport = DAScreening.SelectTotalReferPickup(DateFrom.Value.Date, DateTo.Value.Date)
                End If
            ElseIf RadOpticalShop.Checked = True Then
                If ChScreeningPlace.Checked = True Then
                    TableReport = DAScreening.SelectTotalOpticalShopWithPlace(DateFrom.Value.Date, DateTo.Value.Date, CboScreeningPlace.SelectedValue)
                Else
                    TableReport = DAScreening.SelectTotalOpticalShop(DateFrom.Value.Date, DateTo.Value.Date)
                End If
            End If
        End If

        
    End Sub

    Private Sub BGloadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGloadingReport.RunWorkerCompleted
        Dim RV As New ReportScreening
        Dim TitlePara As String
        Dim FuntionPara As String
        RV.SetDataSource(TableReport)
        Me.CRVScreeningUtility.ReportSource = RV
        
        If RadAllScreening.Checked = True Then
            If ChScreeningPlace.Checked = True Then
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                FuntionPara = "Screening"
            Else
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                FuntionPara = "Screening"
            End If

        ElseIf RadRefraction.Checked = True Then
            If ChScreeningPlace.Checked = True Then
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                FuntionPara = "Prescribtion For Refraction"
            Else
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                FuntionPara = "Prescribtion For Refraction"
            End If
        ElseIf RadReferalBySelf.Checked = True Then
            If ChScreeningPlace.Checked = True Then
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                FuntionPara = "Referred By self"
            Else
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                FuntionPara = "Referred By self"
            End If
        ElseIf RadReferPickup.Checked = True Then
            If ChScreeningPlace.Checked = True Then
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                FuntionPara = "Refered by Pickup"
            Else
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                FuntionPara = "Refered by Pickup"
            End If
        ElseIf RadOpticalShop.Checked = True Then
            If ChScreeningPlace.Checked = True Then
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy") & " at " & CboScreeningPlace.Text
                FuntionPara = "Optical Shop"
            Else
                TitlePara = "From:" & Format(DateFrom.Value.Date, "dd-MM-yyyy") & " To:" & Format(DateTo.Value.Date, "dd-MM-yyyy")
                FuntionPara = "Optical Shop"
            End If
        End If
        RV.SetParameterValue("Title", TitlePara)
        RV.SetParameterValue("Function", FuntionPara)
        UIMainScreening.StatusLoading(False, "Loading")
    End Sub

    Private Sub BGloadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGloadingReport.DoWork
        PrintReportUtiliy()
    End Sub
End Class
