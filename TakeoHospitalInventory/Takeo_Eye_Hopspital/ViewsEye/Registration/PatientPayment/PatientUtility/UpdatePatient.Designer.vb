<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePatient))
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboOccupation = New System.Windows.Forms.ComboBox
        Me.DateRegis = New System.Windows.Forms.DateTimePicker
        Me.TxtAgePatient = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CboProNo = New System.Windows.Forms.ComboBox
        Me.CboDisNo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.CboCommNo = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.CboSexPatien = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtNameKhmer = New System.Windows.Forms.TextBox
        Me.TxtNameEng = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSaveOption = New System.Windows.Forms.Label
        Me.BntClose = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(15, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Tel:"
        '
        'CboOccupation
        '
        Me.CboOccupation.FormattingEnabled = True
        Me.CboOccupation.Location = New System.Drawing.Point(259, 140)
        Me.CboOccupation.Name = "CboOccupation"
        Me.CboOccupation.Size = New System.Drawing.Size(191, 21)
        Me.CboOccupation.TabIndex = 86
        '
        'DateRegis
        '
        Me.DateRegis.CustomFormat = "dd/MM/yyyy"
        Me.DateRegis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRegis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRegis.Location = New System.Drawing.Point(85, 19)
        Me.DateRegis.Name = "DateRegis"
        Me.DateRegis.Size = New System.Drawing.Size(111, 26)
        Me.DateRegis.TabIndex = 93
        '
        'TxtAgePatient
        '
        Me.TxtAgePatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAgePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgePatient.Location = New System.Drawing.Point(85, 144)
        Me.TxtAgePatient.Name = "TxtAgePatient"
        Me.TxtAgePatient.Size = New System.Drawing.Size(52, 26)
        Me.TxtAgePatient.TabIndex = 82
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.CboProNo)
        Me.GroupBox4.Controls.Add(Me.CboDisNo)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.TxtAddress)
        Me.GroupBox4.Controls.Add(Me.CboCommNo)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(16, 206)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(434, 208)
        Me.GroupBox4.TabIndex = 87
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Address information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Commune:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "District:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Province:"
        '
        'CboProNo
        '
        Me.CboProNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProNo.FormattingEnabled = True
        Me.CboProNo.Location = New System.Drawing.Point(95, 22)
        Me.CboProNo.Name = "CboProNo"
        Me.CboProNo.Size = New System.Drawing.Size(260, 28)
        Me.CboProNo.TabIndex = 0
        '
        'CboDisNo
        '
        Me.CboDisNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDisNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDisNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDisNo.FormattingEnabled = True
        Me.CboDisNo.Location = New System.Drawing.Point(95, 58)
        Me.CboDisNo.Name = "CboDisNo"
        Me.CboDisNo.Size = New System.Drawing.Size(260, 28)
        Me.CboDisNo.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 119)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Address:"
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(9, 142)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(414, 55)
        Me.TxtAddress.TabIndex = 3
        '
        'CboCommNo
        '
        Me.CboCommNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCommNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCommNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCommNo.FormattingEnabled = True
        Me.CboCommNo.Location = New System.Drawing.Point(95, 94)
        Me.CboCommNo.Name = "CboCommNo"
        Me.CboCommNo.Size = New System.Drawing.Size(260, 28)
        Me.CboCommNo.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(317, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(133, 33)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Update"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TxtTel
        '
        Me.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(85, 179)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(156, 26)
        Me.TxtTel.TabIndex = 85
        Me.TxtTel.Tag = "Phone Number"
        '
        'CboSexPatien
        '
        Me.CboSexPatien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSexPatien.FormattingEnabled = True
        Me.CboSexPatien.Items.AddRange(New Object() {"", "F", "M"})
        Me.CboSexPatien.Location = New System.Drawing.Point(189, 142)
        Me.CboSexPatien.MaxLength = 1
        Me.CboSexPatien.Name = "CboSexPatien"
        Me.CboSexPatien.Size = New System.Drawing.Size(52, 28)
        Me.CboSexPatien.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(147, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Sex:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(14, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "Age:"
        '
        'TxtNameKhmer
        '
        Me.TxtNameKhmer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNameKhmer.Font = New System.Drawing.Font("Wat Phnom T3", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameKhmer.Location = New System.Drawing.Point(259, 92)
        Me.TxtNameKhmer.Name = "TxtNameKhmer"
        Me.TxtNameKhmer.Size = New System.Drawing.Size(191, 37)
        Me.TxtNameKhmer.TabIndex = 81
        '
        'TxtNameEng
        '
        Me.TxtNameEng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameEng.Location = New System.Drawing.Point(85, 94)
        Me.TxtNameEng.Name = "TxtNameEng"
        Me.TxtNameEng.Size = New System.Drawing.Size(156, 35)
        Me.TxtNameEng.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Name Eng:"
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.ForeColor = System.Drawing.Color.Red
        Me.TxtPatientNo.Location = New System.Drawing.Point(85, 54)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.ReadOnly = True
        Me.TxtPatientNo.Size = New System.Drawing.Size(365, 30)
        Me.TxtPatientNo.TabIndex = 79
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(12, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Date Regis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Patient No:"
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(245, 19)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.lblSaveOption.TabIndex = 92
        Me.lblSaveOption.Text = "0"
        Me.lblSaveOption.Visible = False
        '
        'BntClose
        '
        Me.BntClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BntClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BntClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BntClose.FlatAppearance.BorderSize = 0
        Me.BntClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BntClose.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BntClose.ForeColor = System.Drawing.Color.Navy
        Me.BntClose.Image = CType(resources.GetObject("BntClose.Image"), System.Drawing.Image)
        Me.BntClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BntClose.Location = New System.Drawing.Point(18, 418)
        Me.BntClose.Name = "BntClose"
        Me.BntClose.Size = New System.Drawing.Size(134, 33)
        Me.BntClose.TabIndex = 95
        Me.BntClose.Text = "Close"
        Me.BntClose.UseVisualStyleBackColor = False
        '
        'UpdatePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 460)
        Me.Controls.Add(Me.BntClose)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CboOccupation)
        Me.Controls.Add(Me.DateRegis)
        Me.Controls.Add(Me.TxtAgePatient)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.CboSexPatien)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtNameKhmer)
        Me.Controls.Add(Me.TxtNameEng)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPatientNo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSaveOption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdatePatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdatePatient"
        Me.TopMost = True
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CboOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents DateRegis As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtAgePatient As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboProNo As System.Windows.Forms.ComboBox
    Friend WithEvents CboDisNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents CboCommNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents CboSexPatien As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtNameKhmer As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameEng As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents BntClose As System.Windows.Forms.Button
End Class
