﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPatientRegister
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPatientRegister))
        Me.PanelMain = New System.Windows.Forms.Panel
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PatientNo = New System.Windows.Forms.TextBox
        Me.DateRegis = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtHealthNameCenter = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtReferencePatientNote = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ChReferral = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ChRefraction = New System.Windows.Forms.CheckBox
        Me.ChOpticalshop = New System.Windows.Forms.CheckBox
        Me.GBReferral = New System.Windows.Forms.GroupBox
        Me.RadReferAndComeBySelf = New System.Windows.Forms.RadioButton
        Me.RadReferAndPickup = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtRegisterNote = New System.Windows.Forms.TextBox
        Me.LblSettingID = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboSex = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboCommNo = New System.Windows.Forms.ComboBox
        Me.CboDisNo = New System.Windows.Forms.ComboBox
        Me.CboProNo = New System.Windows.Forms.ComboBox
        Me.TxtFullAddress = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.ErrSaveRegis = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBReferral.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrSaveRegis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMain.Controls.Add(Me.BtnClose)
        Me.PanelMain.Controls.Add(Me.BtnSave)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.Label3)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Controls.Add(Me.Panel3)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(947, 630)
        Me.PanelMain.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(839, 585)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(733, 585)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 37)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(375, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Registration for Eye Screening"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(390, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TAKEO EYE  HOSPITAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(374, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "មន្ទីរពេទ្យ ភ្នែក តាកែវ"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.TxtTel)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PatientNo)
        Me.Panel3.Controls.Add(Me.DateRegis)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TxtHealthNameCenter)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.TxtPatientName)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.CboSex)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.TxtAge)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(5, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(933, 488)
        Me.Panel3.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(9, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 25)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Telephone:"
        '
        'TxtTel
        '
        Me.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel.Font = New System.Drawing.Font("Khmer OS Battambang", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(9, 293)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(344, 40)
        Me.TxtTel.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(608, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "កាលបរិច្ឆេទ(Date):"
        '
        'PatientNo
        '
        Me.PatientNo.BackColor = System.Drawing.Color.White
        Me.PatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientNo.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientNo.ForeColor = System.Drawing.Color.Brown
        Me.PatientNo.Location = New System.Drawing.Point(176, 32)
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Size = New System.Drawing.Size(177, 32)
        Me.PatientNo.TabIndex = 1
        Me.PatientNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateRegis
        '
        Me.DateRegis.CustomFormat = "dd/MM/yyyy"
        Me.DateRegis.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateRegis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRegis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateRegis.Location = New System.Drawing.Point(9, 32)
        Me.DateRegis.Name = "DateRegis"
        Me.DateRegis.Size = New System.Drawing.Size(143, 32)
        Me.DateRegis.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ឈ្មោះមណ្ឌលសុខភាព(Name of Health Center):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(171, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 25)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "លេខសំគាល់(Patient No):"
        '
        'TxtHealthNameCenter
        '
        Me.TxtHealthNameCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHealthNameCenter.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHealthNameCenter.Location = New System.Drawing.Point(9, 99)
        Me.TxtHealthNameCenter.Name = "TxtHealthNameCenter"
        Me.TxtHealthNameCenter.Size = New System.Drawing.Size(344, 37)
        Me.TxtHealthNameCenter.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ឈ្មោះអ្នកជំងឺ(Name Of Patient):"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtReferencePatientNote)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.ChReferral)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GBReferral)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.TxtRegisterNote)
        Me.Panel2.Controls.Add(Me.LblSettingID)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Location = New System.Drawing.Point(376, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(549, 382)
        Me.Panel2.TabIndex = 8
        '
        'TxtReferencePatientNote
        '
        Me.TxtReferencePatientNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReferencePatientNote.Font = New System.Drawing.Font("Khmer OS Battambang", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencePatientNote.Location = New System.Drawing.Point(121, 43)
        Me.TxtReferencePatientNote.Name = "TxtReferencePatientNote"
        Me.TxtReferencePatientNote.Size = New System.Drawing.Size(418, 40)
        Me.TxtReferencePatientNote.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(7, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 25)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Reference Note:"
        '
        'ChReferral
        '
        Me.ChReferral.AutoSize = True
        Me.ChReferral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChReferral.Location = New System.Drawing.Point(23, 90)
        Me.ChReferral.Name = "ChReferral"
        Me.ChReferral.Size = New System.Drawing.Size(82, 29)
        Me.ChReferral.TabIndex = 1
        Me.ChReferral.Text = "Referral"
        Me.ChReferral.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChRefraction)
        Me.GroupBox3.Controls.Add(Me.ChOpticalshop)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(271, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 111)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'ChRefraction
        '
        Me.ChRefraction.AutoSize = True
        Me.ChRefraction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChRefraction.Location = New System.Drawing.Point(15, 33)
        Me.ChRefraction.Name = "ChRefraction"
        Me.ChRefraction.Size = New System.Drawing.Size(96, 29)
        Me.ChRefraction.TabIndex = 0
        Me.ChRefraction.Text = "Refraction"
        Me.ChRefraction.UseVisualStyleBackColor = True
        '
        'ChOpticalshop
        '
        Me.ChOpticalshop.AutoSize = True
        Me.ChOpticalshop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ChOpticalshop.Location = New System.Drawing.Point(15, 71)
        Me.ChOpticalshop.Name = "ChOpticalshop"
        Me.ChOpticalshop.Size = New System.Drawing.Size(112, 29)
        Me.ChOpticalshop.TabIndex = 1
        Me.ChOpticalshop.Text = "Optical Shop"
        Me.ChOpticalshop.UseVisualStyleBackColor = True
        '
        'GBReferral
        '
        Me.GBReferral.Controls.Add(Me.RadReferAndComeBySelf)
        Me.GBReferral.Controls.Add(Me.RadReferAndPickup)
        Me.GBReferral.Enabled = False
        Me.GBReferral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GBReferral.Location = New System.Drawing.Point(10, 93)
        Me.GBReferral.Name = "GBReferral"
        Me.GBReferral.Size = New System.Drawing.Size(255, 112)
        Me.GBReferral.TabIndex = 2
        Me.GBReferral.TabStop = False
        '
        'RadReferAndComeBySelf
        '
        Me.RadReferAndComeBySelf.AutoSize = True
        Me.RadReferAndComeBySelf.Location = New System.Drawing.Point(14, 71)
        Me.RadReferAndComeBySelf.Name = "RadReferAndComeBySelf"
        Me.RadReferAndComeBySelf.Size = New System.Drawing.Size(170, 29)
        Me.RadReferAndComeBySelf.TabIndex = 1
        Me.RadReferAndComeBySelf.TabStop = True
        Me.RadReferAndComeBySelf.Text = "Referral Come By Self"
        Me.RadReferAndComeBySelf.UseVisualStyleBackColor = True
        '
        'RadReferAndPickup
        '
        Me.RadReferAndPickup.AutoSize = True
        Me.RadReferAndPickup.Location = New System.Drawing.Point(14, 33)
        Me.RadReferAndPickup.Name = "RadReferAndPickup"
        Me.RadReferAndPickup.Size = New System.Drawing.Size(147, 29)
        Me.RadReferAndPickup.TabIndex = 0
        Me.RadReferAndPickup.TabStop = True
        Me.RadReferAndPickup.Text = "Referral By Pickup"
        Me.RadReferAndPickup.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(5, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 25)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Register Note:"
        '
        'TxtRegisterNote
        '
        Me.TxtRegisterNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRegisterNote.Font = New System.Drawing.Font("Khmer OS Battambang", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegisterNote.Location = New System.Drawing.Point(5, 246)
        Me.TxtRegisterNote.Multiline = True
        Me.TxtRegisterNote.Name = "TxtRegisterNote"
        Me.TxtRegisterNote.Size = New System.Drawing.Size(534, 128)
        Me.TxtRegisterNote.TabIndex = 4
        '
        'LblSettingID
        '
        Me.LblSettingID.AutoSize = True
        Me.LblSettingID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.LblSettingID.Location = New System.Drawing.Point(451, 7)
        Me.LblSettingID.Name = "LblSettingID"
        Me.LblSettingID.Size = New System.Drawing.Size(20, 25)
        Me.LblSettingID.TabIndex = 8
        Me.LblSettingID.Text = "0"
        Me.LblSettingID.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(0, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(564, 1)
        Me.Label14.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(3, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 25)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Patient Utility:"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientName.Font = New System.Drawing.Font("Khmer OS Battambang", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(9, 164)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(344, 40)
        Me.TxtPatientName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(54, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sex:"
        '
        'CboSex
        '
        Me.CboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSex.FormattingEnabled = True
        Me.CboSex.Items.AddRange(New Object() {"", "F", "M"})
        Me.CboSex.Location = New System.Drawing.Point(9, 230)
        Me.CboSex.Name = "CboSex"
        Me.CboSex.Size = New System.Drawing.Size(143, 32)
        Me.CboSex.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(266, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Age:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboCommNo)
        Me.GroupBox1.Controls.Add(Me.CboDisNo)
        Me.GroupBox1.Controls.Add(Me.CboProNo)
        Me.GroupBox1.Controls.Add(Me.TxtFullAddress)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 335)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 144)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address"
        '
        'CboCommNo
        '
        Me.CboCommNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboCommNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboCommNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCommNo.FormattingEnabled = True
        Me.CboCommNo.Location = New System.Drawing.Point(91, 100)
        Me.CboCommNo.Name = "CboCommNo"
        Me.CboCommNo.Size = New System.Drawing.Size(242, 28)
        Me.CboCommNo.TabIndex = 2
        '
        'CboDisNo
        '
        Me.CboDisNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDisNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDisNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDisNo.FormattingEnabled = True
        Me.CboDisNo.Location = New System.Drawing.Point(91, 65)
        Me.CboDisNo.Name = "CboDisNo"
        Me.CboDisNo.Size = New System.Drawing.Size(242, 28)
        Me.CboDisNo.TabIndex = 1
        '
        'CboProNo
        '
        Me.CboProNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProNo.FormattingEnabled = True
        Me.CboProNo.Location = New System.Drawing.Point(91, 31)
        Me.CboProNo.Name = "CboProNo"
        Me.CboProNo.Size = New System.Drawing.Size(242, 28)
        Me.CboProNo.TabIndex = 0
        '
        'TxtFullAddress
        '
        Me.TxtFullAddress.BackColor = System.Drawing.Color.White
        Me.TxtFullAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFullAddress.Location = New System.Drawing.Point(7, 166)
        Me.TxtFullAddress.Multiline = True
        Me.TxtFullAddress.Name = "TxtFullAddress"
        Me.TxtFullAddress.ReadOnly = True
        Me.TxtFullAddress.Size = New System.Drawing.Size(326, 88)
        Me.TxtFullAddress.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(73, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 25)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Full Address:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(5, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 25)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Commune:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "District:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(6, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Province:"
        '
        'TxtAge
        '
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAge.Location = New System.Drawing.Point(205, 231)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(148, 32)
        Me.TxtAge.TabIndex = 5
        Me.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrSaveRegis
        '
        Me.ErrSaveRegis.ContainerControl = Me
        '
        'FormPatientRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 630)
        Me.Controls.Add(Me.PanelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPatientRegister"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Register"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBReferral.ResumeLayout(False)
        Me.GBReferral.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrSaveRegis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateRegis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtHealthNameCenter As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtFullAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents CboSex As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ChRefraction As System.Windows.Forms.CheckBox
    Friend WithEvents ChOpticalshop As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CboCommNo As System.Windows.Forms.ComboBox
    Friend WithEvents CboDisNo As System.Windows.Forms.ComboBox
    Friend WithEvents CboProNo As System.Windows.Forms.ComboBox
    Friend WithEvents LblSettingID As System.Windows.Forms.Label
    Friend WithEvents ErrSaveRegis As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtRegisterNote As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GBReferral As System.Windows.Forms.GroupBox
    Friend WithEvents RadReferAndComeBySelf As System.Windows.Forms.RadioButton
    Friend WithEvents RadReferAndPickup As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChReferral As System.Windows.Forms.CheckBox
    Friend WithEvents TxtReferencePatientNote As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
