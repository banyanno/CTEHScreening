﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindPatient))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtOldPatientNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateRTo = New System.Windows.Forms.DateTimePicker
        Me.DateRFrom = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboSex = New System.Windows.Forms.ComboBox
        Me.cboCommune = New System.Windows.Forms.ComboBox
        Me.cboDistrict = New System.Windows.Forms.ComboBox
        Me.cboProvince = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblDistric = New System.Windows.Forms.Label
        Me.txtProvice = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtKhmerName = New System.Windows.Forms.TextBox
        Me.txtEngName = New System.Windows.Forms.TextBox
        Me.TxtPatientSearchNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Labeltest = New System.Windows.Forms.Label
        Me.txtEnglishNameddd = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtOldPatientNo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.cboSex)
        Me.GroupBox3.Controls.Add(Me.cboCommune)
        Me.GroupBox3.Controls.Add(Me.cboDistrict)
        Me.GroupBox3.Controls.Add(Me.cboProvince)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblDistric)
        Me.GroupBox3.Controls.Add(Me.txtProvice)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtKhmerName)
        Me.GroupBox3.Controls.Add(Me.txtEngName)
        Me.GroupBox3.Controls.Add(Me.TxtPatientSearchNo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Labeltest)
        Me.GroupBox3.Controls.Add(Me.txtEnglishNameddd)
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(7, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 373)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ស្វែងរកព័ត៌អ្នកជំងឺដោយ"
        '
        'TxtOldPatientNo
        '
        Me.TxtOldPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOldPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOldPatientNo.Location = New System.Drawing.Point(99, 118)
        Me.TxtOldPatientNo.Name = "TxtOldPatientNo"
        Me.TxtOldPatientNo.Size = New System.Drawing.Size(242, 26)
        Me.TxtOldPatientNo.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(3, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Old Patient No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateRTo)
        Me.GroupBox2.Controls.Add(Me.DateRFrom)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(7, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 81)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ថ្ងៃចុះឈ្មោះអ្នកជំងឺ"
        '
        'DateRTo
        '
        Me.DateRTo.CustomFormat = "dd/MM/yyyy"
        Me.DateRTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRTo.Location = New System.Drawing.Point(209, 42)
        Me.DateRTo.Name = "DateRTo"
        Me.DateRTo.Size = New System.Drawing.Size(119, 26)
        Me.DateRTo.TabIndex = 1
        '
        'DateRFrom
        '
        Me.DateRFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateRFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRFrom.Location = New System.Drawing.Point(10, 42)
        Me.DateRFrom.Name = "DateRFrom"
        Me.DateRFrom.Size = New System.Drawing.Size(115, 26)
        Me.DateRFrom.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(209, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 22)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(18, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "From:"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"", "F", "M"})
        Me.cboSex.Location = New System.Drawing.Point(268, 184)
        Me.cboSex.MaxLength = 1
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(43, 28)
        Me.cboSex.TabIndex = 3
        '
        'cboCommune
        '
        Me.cboCommune.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCommune.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCommune.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCommune.FormattingEnabled = True
        Me.cboCommune.Location = New System.Drawing.Point(99, 330)
        Me.cboCommune.Name = "cboCommune"
        Me.cboCommune.Size = New System.Drawing.Size(242, 28)
        Me.cboCommune.TabIndex = 6
        '
        'cboDistrict
        '
        Me.cboDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDistrict.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDistrict.FormattingEnabled = True
        Me.cboDistrict.Location = New System.Drawing.Point(99, 296)
        Me.cboDistrict.Name = "cboDistrict"
        Me.cboDistrict.Size = New System.Drawing.Size(242, 28)
        Me.cboDistrict.TabIndex = 5
        '
        'cboProvince
        '
        Me.cboProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(99, 262)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(242, 28)
        Me.cboProvince.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(3, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Commune:"
        '
        'lblDistric
        '
        Me.lblDistric.AutoSize = True
        Me.lblDistric.ForeColor = System.Drawing.Color.Navy
        Me.lblDistric.Location = New System.Drawing.Point(3, 308)
        Me.lblDistric.Name = "lblDistric"
        Me.lblDistric.Size = New System.Drawing.Size(48, 22)
        Me.lblDistric.TabIndex = 16
        Me.lblDistric.Text = "District:"
        '
        'txtProvice
        '
        Me.txtProvice.AutoSize = True
        Me.txtProvice.ForeColor = System.Drawing.Color.Navy
        Me.txtProvice.Location = New System.Drawing.Point(3, 270)
        Me.txtProvice.Name = "txtProvice"
        Me.txtProvice.Size = New System.Drawing.Size(58, 22)
        Me.txtProvice.TabIndex = 15
        Me.txtProvice.Text = "Province:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(234, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Sex:"
        '
        'txtKhmerName
        '
        Me.txtKhmerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKhmerName.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhmerName.Location = New System.Drawing.Point(99, 216)
        Me.txtKhmerName.Name = "txtKhmerName"
        Me.txtKhmerName.Size = New System.Drawing.Size(242, 39)
        Me.txtKhmerName.TabIndex = 2
        '
        'txtEngName
        '
        Me.txtEngName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEngName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEngName.Location = New System.Drawing.Point(99, 184)
        Me.txtEngName.Name = "txtEngName"
        Me.txtEngName.Size = New System.Drawing.Size(124, 26)
        Me.txtEngName.TabIndex = 1
        '
        'TxtPatientSearchNo
        '
        Me.TxtPatientSearchNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientSearchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientSearchNo.Location = New System.Drawing.Point(99, 152)
        Me.TxtPatientSearchNo.Name = "TxtPatientSearchNo"
        Me.TxtPatientSearchNo.Size = New System.Drawing.Size(242, 26)
        Me.TxtPatientSearchNo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(3, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Patient No:"
        '
        'Labeltest
        '
        Me.Labeltest.AutoSize = True
        Me.Labeltest.ForeColor = System.Drawing.Color.Navy
        Me.Labeltest.Location = New System.Drawing.Point(3, 233)
        Me.Labeltest.Name = "Labeltest"
        Me.Labeltest.Size = New System.Drawing.Size(86, 22)
        Me.Labeltest.TabIndex = 2
        Me.Labeltest.Text = "Khmer Name:"
        '
        'txtEnglishNameddd
        '
        Me.txtEnglishNameddd.AutoSize = True
        Me.txtEnglishNameddd.ForeColor = System.Drawing.Color.Navy
        Me.txtEnglishNameddd.Location = New System.Drawing.Point(3, 191)
        Me.txtEnglishNameddd.Name = "txtEnglishNameddd"
        Me.txtEnglishNameddd.Size = New System.Drawing.Size(88, 22)
        Me.txtEnglishNameddd.TabIndex = 1
        Me.txtEnglishNameddd.Text = "English Name:"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFind.FlatAppearance.BorderSize = 0
        Me.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.Navy
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.Location = New System.Drawing.Point(256, 382)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(104, 37)
        Me.btnFind.TabIndex = 7
        Me.btnFind.Text = "Find"
        Me.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Navy
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(7, 382)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 37)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FindPatient
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(369, 429)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindPatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Patient"
        Me.TopMost = True
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtOldPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateRTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateRFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents cboCommune As System.Windows.Forms.ComboBox
    Friend WithEvents cboDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDistric As System.Windows.Forms.Label
    Friend WithEvents txtProvice As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKhmerName As System.Windows.Forms.TextBox
    Friend WithEvents txtEngName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientSearchNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Labeltest As System.Windows.Forms.Label
    Friend WithEvents txtEnglishNameddd As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
