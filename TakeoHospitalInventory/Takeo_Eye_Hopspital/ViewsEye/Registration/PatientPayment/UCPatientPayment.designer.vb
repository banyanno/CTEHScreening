<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPatientPayment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridConsult_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPatientPayment))
        Dim GridPatientInformation_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupPatientFee = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnPatientAchive = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GridConsult = New Janus.Windows.GridEX.GridEX
        Me.BtnCashReceipt = New System.Windows.Forms.Button
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
        Me.BtnNewOutPatient = New System.Windows.Forms.Button
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
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GridPatientInformation = New Janus.Windows.GridEX.GridEX
        Me.ContexMenuPatientReciept = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MNewPatientBook = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateNewoutPatientBook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.MPrintPatientNewReceipt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuOldPatientBook = New System.Windows.Forms.ToolStripMenuItem
        Me.MCreateOldPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.MPrintOldPatientReceipt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.MInPateintBook = New System.Windows.Forms.ToolStripMenuItem
        Me.MCreateInpatientBook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.MPrintInpatientReceipt = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuRegistrationForm = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.MFree = New System.Windows.Forms.ToolStripMenuItem
        Me.MFreeOldPatientBook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.MFreeInPatientbook = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.PatientReferToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DSPatient = New TakeoHospitalInventory.DSDashboardPatient
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.InpatientBook = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GridInpatient = New System.Windows.Forms.DataGridView
        Me.InNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telephoneold = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diagnosis1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeOfOperation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HosFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SocialFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DolarSosial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FullFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DolarFull = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Other1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridOldOutPatient = New System.Windows.Forms.DataGridView
        Me.OldNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientDolar1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelephoneIn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label13 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GridNewOutpatient = New System.Windows.Forms.DataGridView
        Me.NewOutPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewPatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OlePatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecieptNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameEng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewAge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewSex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NewAddress = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientFee = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientDolar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diagnosis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Other = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Prescribed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Dispensed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Hearing = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Understand = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Seeing = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Physical = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NewCreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.StatusStripPateint = New System.Windows.Forms.StatusStrip
        Me.ProgrestData = New System.Windows.Forms.ToolStripProgressBar
        Me.lblTimeShowData = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnMoPoTsyo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.MainBtnNewPatientBook = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnPrintNewOutPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MainBtnOldPatientBook = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnPrintOldOutPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MaintBtnPrintInPatient = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnPrintInPatient = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.MainBtnPrintRegistrationForm = New System.Windows.Forms.ToolStripDropDownButton
        Me.BtnPrintRegistrationFormAgain = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintRegisV2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateRegistrationForm = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReferToOtherHospital = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnShowBook = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ImgPatient = New System.Windows.Forms.ImageList(Me.components)
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.bgPatient = New System.ComponentModel.BackgroundWorker
        Me.TimerSearchPatien = New System.Windows.Forms.Timer(Me.components)
        Me.TblPatientsTableAdapter = New TakeoHospitalInventory.DSDashboardPatientTableAdapters.TblPatientsTableAdapter
        Me.V_OldOutpatientTableAdapter = New TakeoHospitalInventory.DSDashboardPatientTableAdapters.V_OldOutpatientTableAdapter
        Me.V_InpatientTableAdapter = New TakeoHospitalInventory.DSDashboardPatientTableAdapters.V_InpatientTableAdapter
        Me.V_NewoutpatientTableAdapter = New TakeoHospitalInventory.DSDashboardPatientTableAdapters.V_NewoutpatientTableAdapter
        Me.RibboStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnNew = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand1 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnOldOutPatientReceipt = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand2 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnInpatientReceipt = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand8 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnShowBookV1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnFindPatient = New Janus.Windows.Ribbon.ButtonCommand
        Me.BtnUpdatePatient = New Janus.Windows.Ribbon.ButtonCommand
        Me.BtnViewSupInvoice = New Janus.Windows.Ribbon.ButtonCommand
        Me.DropDownCommand2 = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnPrintNewOutPatientV1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand3 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnPrintOldOutPatientV1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand4 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnPrintInPatientV1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand5 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.DropDownCommand6 = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnPrintRegistrationFormAgainV1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand6 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnPrintRegisV21 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand7 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnUpdateRegistrationFormv1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnReferToOtherHospitalV1 = New Janus.Windows.Ribbon.ButtonCommand
        Me.ButtonCommand3 = New Janus.Windows.Ribbon.ButtonCommand
        Me.ErrPatient = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupPatientFee.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridConsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContexMenuPatientReciept.SuspendLayout()
        CType(Me.DSPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.InpatientBook.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridInpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridOldOutPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.GridNewOutpatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStripPateint.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.AutoScrollMinSize = New System.Drawing.Size(1980, 0)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupPatientFee)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer1.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1751, 1059)
        Me.SplitContainer1.SplitterDistance = 559
        Me.SplitContainer1.TabIndex = 4
        '
        'GroupPatientFee
        '
        Me.GroupPatientFee.BackColor = System.Drawing.Color.Transparent
        Me.GroupPatientFee.Controls.Add(Me.Label12)
        Me.GroupPatientFee.Controls.Add(Me.BtnPatientAchive)
        Me.GroupPatientFee.Controls.Add(Me.BtnCashReceipt)
        Me.GroupPatientFee.Controls.Add(Me.CboOccupation)
        Me.GroupPatientFee.Controls.Add(Me.DateRegis)
        Me.GroupPatientFee.Controls.Add(Me.TxtAgePatient)
        Me.GroupPatientFee.Controls.Add(Me.GroupBox4)
        Me.GroupPatientFee.Controls.Add(Me.BtnNewOutPatient)
        Me.GroupPatientFee.Controls.Add(Me.TxtTel)
        Me.GroupPatientFee.Controls.Add(Me.CboSexPatien)
        Me.GroupPatientFee.Controls.Add(Me.Label15)
        Me.GroupPatientFee.Controls.Add(Me.Label16)
        Me.GroupPatientFee.Controls.Add(Me.TxtNameKhmer)
        Me.GroupPatientFee.Controls.Add(Me.TxtNameEng)
        Me.GroupPatientFee.Controls.Add(Me.Label3)
        Me.GroupPatientFee.Controls.Add(Me.TxtPatientNo)
        Me.GroupPatientFee.Controls.Add(Me.Label19)
        Me.GroupPatientFee.Controls.Add(Me.Label1)
        Me.GroupPatientFee.Controls.Add(Me.lblSaveOption)
        Me.GroupPatientFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPatientFee.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPatientFee.Location = New System.Drawing.Point(0, 0)
        Me.GroupPatientFee.Name = "GroupPatientFee"
        Me.GroupPatientFee.Size = New System.Drawing.Size(1980, 542)
        Me.GroupPatientFee.TabIndex = 3
        Me.GroupPatientFee.TabStop = False
        Me.GroupPatientFee.Text = "កែប្រែព័ត៌មានអ្នកជំងឺ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 22)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Tel:"
        '
        'BtnPatientAchive
        '
        Me.BtnPatientAchive.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPatientAchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPatientAchive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPatientAchive.Enabled = False
        Me.BtnPatientAchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPatientAchive.Font = New System.Drawing.Font("Khmer OS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPatientAchive.ForeColor = System.Drawing.Color.Blue
        Me.BtnPatientAchive.Location = New System.Drawing.Point(1021, 341)
        Me.BtnPatientAchive.Name = "BtnPatientAchive"
        Me.BtnPatientAchive.Size = New System.Drawing.Size(192, 75)
        Me.BtnPatientAchive.TabIndex = 5
        Me.BtnPatientAchive.Tag = "Old New"
        Me.BtnPatientAchive.Text = "បង្កើតព័ត៌មានអ្នកជំងឺចាស់"
        Me.BtnPatientAchive.UseVisualStyleBackColor = False
        Me.BtnPatientAchive.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.GridConsult)
        Me.GroupBox5.Font = New System.Drawing.Font("Khmer OS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Location = New System.Drawing.Point(1140, 821)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(602, 213)
        Me.GroupBox5.TabIndex = 76
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Conselling Information"
        '
        'GridConsult
        '
        Me.GridConsult.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridConsult_DesignTimeLayout.LayoutString = resources.GetString("GridConsult_DesignTimeLayout.LayoutString")
        Me.GridConsult.DesignTimeLayout = GridConsult_DesignTimeLayout
        Me.GridConsult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridConsult.GroupByBoxVisible = False
        Me.GridConsult.Location = New System.Drawing.Point(3, 30)
        Me.GridConsult.Name = "GridConsult"
        Me.GridConsult.RecordNavigator = True
        Me.GridConsult.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridConsult.Size = New System.Drawing.Size(596, 180)
        Me.GridConsult.TabIndex = 78
        '
        'BtnCashReceipt
        '
        Me.BtnCashReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCashReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCashReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCashReceipt.Font = New System.Drawing.Font("Khmer OS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashReceipt.ForeColor = System.Drawing.Color.Navy
        Me.BtnCashReceipt.Location = New System.Drawing.Point(1286, 281)
        Me.BtnCashReceipt.Name = "BtnCashReceipt"
        Me.BtnCashReceipt.Size = New System.Drawing.Size(100, 102)
        Me.BtnCashReceipt.TabIndex = 0
        Me.BtnCashReceipt.Text = "បង្កាន់ដៃបង់ប្រាក់សំរាប់ CASH PATIENT"
        Me.BtnCashReceipt.UseVisualStyleBackColor = False
        Me.BtnCashReceipt.Visible = False
        '
        'CboOccupation
        '
        Me.CboOccupation.FormattingEnabled = True
        Me.CboOccupation.Location = New System.Drawing.Point(250, 143)
        Me.CboOccupation.Name = "CboOccupation"
        Me.CboOccupation.Size = New System.Drawing.Size(191, 30)
        Me.CboOccupation.TabIndex = 6
        '
        'DateRegis
        '
        Me.DateRegis.CustomFormat = "dd/MM/yyyy"
        Me.DateRegis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateRegis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateRegis.Location = New System.Drawing.Point(76, 22)
        Me.DateRegis.Name = "DateRegis"
        Me.DateRegis.Size = New System.Drawing.Size(111, 26)
        Me.DateRegis.TabIndex = 75
        '
        'TxtAgePatient
        '
        Me.TxtAgePatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAgePatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgePatient.Location = New System.Drawing.Point(76, 147)
        Me.TxtAgePatient.Name = "TxtAgePatient"
        Me.TxtAgePatient.Size = New System.Drawing.Size(52, 26)
        Me.TxtAgePatient.TabIndex = 3
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
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 208)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(460, 208)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Address information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 22)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Commune:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 22)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "District:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 22)
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
        Me.Label22.Size = New System.Drawing.Size(52, 22)
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
        Me.TxtAddress.Size = New System.Drawing.Size(442, 55)
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
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(361, 83)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 39)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "កែប្រែ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'BtnNewOutPatient
        '
        Me.BtnNewOutPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewOutPatient.Font = New System.Drawing.Font("Khmer OS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewOutPatient.ForeColor = System.Drawing.Color.Navy
        Me.BtnNewOutPatient.Location = New System.Drawing.Point(1286, 284)
        Me.BtnNewOutPatient.Name = "BtnNewOutPatient"
        Me.BtnNewOutPatient.Size = New System.Drawing.Size(100, 10)
        Me.BtnNewOutPatient.TabIndex = 0
        Me.BtnNewOutPatient.Text = "បង្កាន់ដៃបង់ប្រាក់សំរាប់ NEW PATIENT"
        Me.BtnNewOutPatient.UseVisualStyleBackColor = True
        Me.BtnNewOutPatient.Visible = False
        '
        'TxtTel
        '
        Me.TxtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTel.Location = New System.Drawing.Point(76, 182)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(156, 26)
        Me.TxtTel.TabIndex = 5
        Me.TxtTel.Tag = "Phone Number"
        '
        'CboSexPatien
        '
        Me.CboSexPatien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSexPatien.FormattingEnabled = True
        Me.CboSexPatien.Items.AddRange(New Object() {"", "F", "M"})
        Me.CboSexPatien.Location = New System.Drawing.Point(180, 145)
        Me.CboSexPatien.MaxLength = 1
        Me.CboSexPatien.Name = "CboSexPatien"
        Me.CboSexPatien.Size = New System.Drawing.Size(52, 28)
        Me.CboSexPatien.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(138, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 22)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Sex:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 22)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Age:"
        '
        'TxtNameKhmer
        '
        Me.TxtNameKhmer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNameKhmer.Font = New System.Drawing.Font("Wat Phnom T3", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameKhmer.Location = New System.Drawing.Point(250, 95)
        Me.TxtNameKhmer.Name = "TxtNameKhmer"
        Me.TxtNameKhmer.Size = New System.Drawing.Size(191, 37)
        Me.TxtNameKhmer.TabIndex = 2
        '
        'TxtNameEng
        '
        Me.TxtNameEng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNameEng.Location = New System.Drawing.Point(76, 97)
        Me.TxtNameEng.Name = "TxtNameEng"
        Me.TxtNameEng.Size = New System.Drawing.Size(156, 35)
        Me.TxtNameEng.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Name Eng:"
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.ForeColor = System.Drawing.Color.Red
        Me.TxtPatientNo.Location = New System.Drawing.Point(76, 57)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.ReadOnly = True
        Me.TxtPatientNo.Size = New System.Drawing.Size(365, 30)
        Me.TxtPatientNo.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 22)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Date Regis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Patient No:"
        '
        'lblSaveOption
        '
        Me.lblSaveOption.AutoSize = True
        Me.lblSaveOption.Location = New System.Drawing.Point(236, 22)
        Me.lblSaveOption.Name = "lblSaveOption"
        Me.lblSaveOption.Size = New System.Drawing.Size(16, 22)
        Me.lblSaveOption.TabIndex = 44
        Me.lblSaveOption.Text = "0"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.SplitContainer2)
        Me.GroupBox10.Controls.Add(Me.StatusStripPateint)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1751, 1059)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Print Registration Form Again"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 19)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridPatientInformation)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(1745, 1037)
        Me.SplitContainer2.SplitterDistance = 599
        Me.SplitContainer2.TabIndex = 3
        '
        'GridPatientInformation
        '
        Me.GridPatientInformation.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.Empty
        Me.GridPatientInformation.BackColor = System.Drawing.SystemColors.Control
        Me.GridPatientInformation.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.Stretch
        Me.GridPatientInformation.ContextMenuStrip = Me.ContexMenuPatientReciept
        Me.GridPatientInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPatientInformation.DataMember = "TblPatients"
        Me.GridPatientInformation.DataSource = Me.DSPatient
        GridPatientInformation_DesignTimeLayout.LayoutString = resources.GetString("GridPatientInformation_DesignTimeLayout.LayoutString")
        Me.GridPatientInformation.DesignTimeLayout = GridPatientInformation_DesignTimeLayout
        Me.GridPatientInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPatientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPatientInformation.GroupByBoxVisible = False
        Me.GridPatientInformation.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GridPatientInformation.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPatientInformation.Hierarchical = True
        Me.GridPatientInformation.Location = New System.Drawing.Point(0, 0)
        Me.GridPatientInformation.Name = "GridPatientInformation"
        Me.GridPatientInformation.RecordNavigator = True
        Me.GridPatientInformation.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridPatientInformation.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
        Me.GridPatientInformation.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.GrayText
        Me.GridPatientInformation.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque
        Me.GridPatientInformation.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.GrayText
        Me.GridPatientInformation.SelectedInactiveFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque
        Me.GridPatientInformation.Size = New System.Drawing.Size(1745, 1037)
        Me.GridPatientInformation.TabIndex = 2
        '
        'ContexMenuPatientReciept
        '
        Me.ContexMenuPatientReciept.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNewPatientBook, Me.ToolStripMenuItem1, Me.MenuOldPatientBook, Me.ToolStripMenuItem2, Me.MInPateintBook, Me.ToolStripMenuItem3, Me.MenuRegistrationForm, Me.ToolStripMenuItem4, Me.MFree, Me.ToolStripMenuItem7, Me.PatientReferToToolStripMenuItem})
        Me.ContexMenuPatientReciept.Name = "ContexMenuPatientReciept"
        Me.ContexMenuPatientReciept.Size = New System.Drawing.Size(193, 166)
        '
        'MNewPatientBook
        '
        Me.MNewPatientBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewoutPatientBook, Me.ToolStripMenuItem5, Me.MPrintPatientNewReceipt})
        Me.MNewPatientBook.ForeColor = System.Drawing.Color.Black
        Me.MNewPatientBook.Name = "MNewPatientBook"
        Me.MNewPatientBook.Size = New System.Drawing.Size(192, 22)
        Me.MNewPatientBook.Text = "NEW PATIENT BOOK..."
        '
        'CreateNewoutPatientBook
        '
        Me.CreateNewoutPatientBook.Name = "CreateNewoutPatientBook"
        Me.CreateNewoutPatientBook.Size = New System.Drawing.Size(228, 22)
        Me.CreateNewoutPatientBook.Text = "Create New-out Patient Book"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(225, 6)
        '
        'MPrintPatientNewReceipt
        '
        Me.MPrintPatientNewReceipt.Name = "MPrintPatientNewReceipt"
        Me.MPrintPatientNewReceipt.Size = New System.Drawing.Size(228, 22)
        Me.MPrintPatientNewReceipt.Text = "Print New Patient Receipt "
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(189, 6)
        '
        'MenuOldPatientBook
        '
        Me.MenuOldPatientBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MCreateOldPatient, Me.ToolStripMenuItem8, Me.MPrintOldPatientReceipt})
        Me.MenuOldPatientBook.ForeColor = System.Drawing.Color.Black
        Me.MenuOldPatientBook.Name = "MenuOldPatientBook"
        Me.MenuOldPatientBook.Size = New System.Drawing.Size(192, 22)
        Me.MenuOldPatientBook.Text = "OLD PATIENT BOOK..."
        '
        'MCreateOldPatient
        '
        Me.MCreateOldPatient.Name = "MCreateOldPatient"
        Me.MCreateOldPatient.Size = New System.Drawing.Size(206, 22)
        Me.MCreateOldPatient.Text = "Create Old Patient Book"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(203, 6)
        '
        'MPrintOldPatientReceipt
        '
        Me.MPrintOldPatientReceipt.Name = "MPrintOldPatientReceipt"
        Me.MPrintOldPatientReceipt.Size = New System.Drawing.Size(206, 22)
        Me.MPrintOldPatientReceipt.Text = "Print Old Patient Receipt "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(189, 6)
        '
        'MInPateintBook
        '
        Me.MInPateintBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MCreateInpatientBook, Me.ToolStripMenuItem9, Me.MPrintInpatientReceipt})
        Me.MInPateintBook.ForeColor = System.Drawing.Color.Black
        Me.MInPateintBook.Name = "MInPateintBook"
        Me.MInPateintBook.Size = New System.Drawing.Size(192, 22)
        Me.MInPateintBook.Text = "IN PATIENT BOOK..."
        '
        'MCreateInpatientBook
        '
        Me.MCreateInpatientBook.Name = "MCreateInpatientBook"
        Me.MCreateInpatientBook.Size = New System.Drawing.Size(194, 22)
        Me.MCreateInpatientBook.Text = "Create In Patient Book"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(191, 6)
        '
        'MPrintInpatientReceipt
        '
        Me.MPrintInpatientReceipt.Name = "MPrintInpatientReceipt"
        Me.MPrintInpatientReceipt.Size = New System.Drawing.Size(194, 22)
        Me.MPrintInpatientReceipt.Text = "Print In Patient Receipt"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(189, 6)
        '
        'MenuRegistrationForm
        '
        Me.MenuRegistrationForm.Name = "MenuRegistrationForm"
        Me.MenuRegistrationForm.Size = New System.Drawing.Size(192, 22)
        Me.MenuRegistrationForm.Text = "REGISTRATION FORM"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(189, 6)
        '
        'MFree
        '
        Me.MFree.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MFreeOldPatientBook, Me.ToolStripMenuItem6, Me.MFreeInPatientbook})
        Me.MFree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MFree.Name = "MFree"
        Me.MFree.Size = New System.Drawing.Size(192, 22)
        Me.MFree.Text = "Free"
        '
        'MFreeOldPatientBook
        '
        Me.MFreeOldPatientBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MFreeOldPatientBook.Name = "MFreeOldPatientBook"
        Me.MFreeOldPatientBook.Size = New System.Drawing.Size(189, 22)
        Me.MFreeOldPatientBook.Text = "OLD PATIENT BOOK..."
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(186, 6)
        '
        'MFreeInPatientbook
        '
        Me.MFreeInPatientbook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MFreeInPatientbook.Name = "MFreeInPatientbook"
        Me.MFreeInPatientbook.Size = New System.Drawing.Size(189, 22)
        Me.MFreeInPatientbook.Text = "IN PATIENT BOOK..."
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(189, 6)
        '
        'PatientReferToToolStripMenuItem
        '
        Me.PatientReferToToolStripMenuItem.Name = "PatientReferToToolStripMenuItem"
        Me.PatientReferToToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PatientReferToToolStripMenuItem.Text = "Patient Refer To..."
        '
        'DSPatient
        '
        Me.DSPatient.DataSetName = "DSDashboardPatient"
        Me.DSPatient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.InpatientBook)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(96, 100)
        Me.TabControl1.TabIndex = 2
        '
        'InpatientBook
        '
        Me.InpatientBook.Controls.Add(Me.Panel3)
        Me.InpatientBook.Controls.Add(Me.Splitter2)
        Me.InpatientBook.Controls.Add(Me.Panel2)
        Me.InpatientBook.Controls.Add(Me.Splitter1)
        Me.InpatientBook.Controls.Add(Me.Panel1)
        Me.InpatientBook.Location = New System.Drawing.Point(4, 25)
        Me.InpatientBook.Name = "InpatientBook"
        Me.InpatientBook.Size = New System.Drawing.Size(88, 71)
        Me.InpatientBook.TabIndex = 2
        Me.InpatientBook.Text = "Patient Book"
        Me.InpatientBook.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridInpatient)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 322)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(88, 0)
        Me.Panel3.TabIndex = 13
        '
        'GridInpatient
        '
        Me.GridInpatient.AllowUserToAddRows = False
        Me.GridInpatient.AllowUserToDeleteRows = False
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridInpatient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.GridInpatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridInpatient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridInpatient.ColumnHeadersHeight = 30
        Me.GridInpatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InNo, Me.Telephoneold, Me.PatientNo1, Me.ReceiptNo1, Me.NameKhmer3, Me.Age1, Me.Sex1, Me.Address1, Me.Diagnosis1, Me.TypeOfOperation, Me.HosFee, Me.SocialFee, Me.DolarSosial, Me.FullFee, Me.DolarFull, Me.Other1, Me.CreateDate1})
        Me.GridInpatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInpatient.Location = New System.Drawing.Point(0, 13)
        Me.GridInpatient.Name = "GridInpatient"
        Me.GridInpatient.ReadOnly = True
        Me.GridInpatient.RowTemplate.Height = 30
        Me.GridInpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridInpatient.Size = New System.Drawing.Size(88, 0)
        Me.GridInpatient.TabIndex = 5
        '
        'InNo
        '
        Me.InNo.DataPropertyName = "InNo"
        Me.InNo.HeaderText = "InNo."
        Me.InNo.Name = "InNo"
        Me.InNo.ReadOnly = True
        Me.InNo.Visible = False
        '
        'Telephoneold
        '
        Me.Telephoneold.DataPropertyName = "Telephone"
        Me.Telephoneold.HeaderText = "Telephone"
        Me.Telephoneold.Name = "Telephoneold"
        Me.Telephoneold.ReadOnly = True
        Me.Telephoneold.Visible = False
        '
        'PatientNo1
        '
        Me.PatientNo1.DataPropertyName = "PatientNo"
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.Red
        Me.PatientNo1.DefaultCellStyle = DataGridViewCellStyle38
        Me.PatientNo1.HeaderText = "Patient No."
        Me.PatientNo1.Name = "PatientNo1"
        Me.PatientNo1.ReadOnly = True
        '
        'ReceiptNo1
        '
        Me.ReceiptNo1.DataPropertyName = "ReceiptNo"
        Me.ReceiptNo1.HeaderText = "Receipt No."
        Me.ReceiptNo1.Name = "ReceiptNo1"
        Me.ReceiptNo1.ReadOnly = True
        '
        'NameKhmer3
        '
        Me.NameKhmer3.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Wat Phnom T3", 10.0!)
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.Blue
        Me.NameKhmer3.DefaultCellStyle = DataGridViewCellStyle39
        Me.NameKhmer3.HeaderText = "Patient Name/Hosp.#"
        Me.NameKhmer3.Name = "NameKhmer3"
        Me.NameKhmer3.ReadOnly = True
        Me.NameKhmer3.Width = 250
        '
        'Age1
        '
        Me.Age1.DataPropertyName = "Age"
        Me.Age1.HeaderText = "Age"
        Me.Age1.Name = "Age1"
        Me.Age1.ReadOnly = True
        Me.Age1.Width = 50
        '
        'Sex1
        '
        Me.Sex1.DataPropertyName = "Sex"
        Me.Sex1.HeaderText = "Sex"
        Me.Sex1.Name = "Sex1"
        Me.Sex1.ReadOnly = True
        Me.Sex1.Width = 50
        '
        'Address1
        '
        Me.Address1.DataPropertyName = "Address"
        Me.Address1.HeaderText = "Address"
        Me.Address1.Name = "Address1"
        Me.Address1.ReadOnly = True
        Me.Address1.Width = 200
        '
        'Diagnosis1
        '
        Me.Diagnosis1.DataPropertyName = "Diagnosis"
        Me.Diagnosis1.HeaderText = "Diagnosis"
        Me.Diagnosis1.Name = "Diagnosis1"
        Me.Diagnosis1.ReadOnly = True
        '
        'TypeOfOperation
        '
        Me.TypeOfOperation.DataPropertyName = "TypeOfOperation"
        Me.TypeOfOperation.HeaderText = "Type of operation"
        Me.TypeOfOperation.Name = "TypeOfOperation"
        Me.TypeOfOperation.ReadOnly = True
        Me.TypeOfOperation.Width = 200
        '
        'HosFee
        '
        Me.HosFee.DataPropertyName = "HosFee"
        Me.HosFee.HeaderText = "Hosp. Fee"
        Me.HosFee.Name = "HosFee"
        Me.HosFee.ReadOnly = True
        '
        'SocialFee
        '
        Me.SocialFee.DataPropertyName = "SosialFee"
        Me.SocialFee.HeaderText = "Social Fee Riel"
        Me.SocialFee.Name = "SocialFee"
        Me.SocialFee.ReadOnly = True
        '
        'DolarSosial
        '
        Me.DolarSosial.DataPropertyName = "DolarSosial"
        Me.DolarSosial.HeaderText = "Sosial Fee Dolar"
        Me.DolarSosial.Name = "DolarSosial"
        Me.DolarSosial.ReadOnly = True
        '
        'FullFee
        '
        Me.FullFee.DataPropertyName = "FullFee"
        Me.FullFee.HeaderText = "Full Fee Riel"
        Me.FullFee.Name = "FullFee"
        Me.FullFee.ReadOnly = True
        '
        'DolarFull
        '
        Me.DolarFull.DataPropertyName = "DolarFull"
        DataGridViewCellStyle40.NullValue = Nothing
        Me.DolarFull.DefaultCellStyle = DataGridViewCellStyle40
        Me.DolarFull.HeaderText = "Full Fee Dolar"
        Me.DolarFull.Name = "DolarFull"
        Me.DolarFull.ReadOnly = True
        '
        'Other1
        '
        Me.Other1.DataPropertyName = "Other"
        Me.Other1.HeaderText = "Other"
        Me.Other1.Name = "Other1"
        Me.Other1.ReadOnly = True
        '
        'CreateDate1
        '
        Me.CreateDate1.DataPropertyName = "CreateDate"
        DataGridViewCellStyle41.Format = "dd/MM/yyyy"
        Me.CreateDate1.DefaultCellStyle = DataGridViewCellStyle41
        Me.CreateDate1.HeaderText = "Date Create"
        Me.CreateDate1.Name = "CreateDate1"
        Me.CreateDate1.ReadOnly = True
        Me.CreateDate1.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "IN PATIENT BOOK"
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter2.Location = New System.Drawing.Point(0, 312)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(88, 10)
        Me.Splitter2.TabIndex = 12
        Me.Splitter2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridOldOutPatient)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(88, 165)
        Me.Panel2.TabIndex = 11
        '
        'GridOldOutPatient
        '
        Me.GridOldOutPatient.AllowUserToAddRows = False
        Me.GridOldOutPatient.AllowUserToDeleteRows = False
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridOldOutPatient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle42
        Me.GridOldOutPatient.BackgroundColor = System.Drawing.Color.White
        Me.GridOldOutPatient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridOldOutPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOldOutPatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OldNo, Me.PatientNo, Me.ReceiptNo, Me.NameKhmer1, Me.Age, Me.Sex, Me.Address, Me.DataGridViewTextBoxColumn1, Me.PatientDolar1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.CreateDate, Me.TelephoneIn})
        Me.GridOldOutPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridOldOutPatient.Location = New System.Drawing.Point(0, 13)
        Me.GridOldOutPatient.Name = "GridOldOutPatient"
        Me.GridOldOutPatient.ReadOnly = True
        Me.GridOldOutPatient.RowHeadersWidth = 50
        Me.GridOldOutPatient.RowTemplate.Height = 35
        Me.GridOldOutPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridOldOutPatient.Size = New System.Drawing.Size(88, 152)
        Me.GridOldOutPatient.TabIndex = 7
        '
        'OldNo
        '
        Me.OldNo.DataPropertyName = "NewOutPatientNo"
        Me.OldNo.HeaderText = "No"
        Me.OldNo.Name = "OldNo"
        Me.OldNo.ReadOnly = True
        Me.OldNo.Visible = False
        '
        'PatientNo
        '
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.HeaderText = "Patient No"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Width = 150
        '
        'ReceiptNo
        '
        Me.ReceiptNo.DataPropertyName = "ReceiptNo"
        Me.ReceiptNo.HeaderText = "Reciept No"
        Me.ReceiptNo.Name = "ReceiptNo"
        Me.ReceiptNo.ReadOnly = True
        Me.ReceiptNo.Width = 150
        '
        'NameKhmer1
        '
        Me.NameKhmer1.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Wat Phnom T3", 10.0!)
        Me.NameKhmer1.DefaultCellStyle = DataGridViewCellStyle43
        Me.NameKhmer1.HeaderText = "Name of Patient/Hosp#"
        Me.NameKhmer1.Name = "NameKhmer1"
        Me.NameKhmer1.ReadOnly = True
        Me.NameKhmer1.Width = 250
        '
        'Age
        '
        Me.Age.DataPropertyName = "Age"
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientFee"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Patient Fee"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'PatientDolar1
        '
        Me.PatientDolar1.DataPropertyName = "PatientDolar"
        Me.PatientDolar1.HeaderText = "PatientDolar"
        Me.PatientDolar1.Name = "PatientDolar1"
        Me.PatientDolar1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Diagnosis"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Diagnosis"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Prescribed"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Prescribed"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Dispensed"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Dispensed"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Hearing"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Hearing"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Understand"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Understand"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        Me.DataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Seeing"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Seeing"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        Me.DataGridViewCheckBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "Physical"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "Physical"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.ReadOnly = True
        Me.DataGridViewCheckBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Other"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Other"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.DataPropertyName = "CreateDate"
        DataGridViewCellStyle44.Format = "dd/MM/yyyy"
        Me.CreateDate.DefaultCellStyle = DataGridViewCellStyle44
        Me.CreateDate.HeaderText = "Date Create"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        Me.CreateDate.Width = 200
        '
        'TelephoneIn
        '
        Me.TelephoneIn.DataPropertyName = "Telephone"
        Me.TelephoneIn.HeaderText = "Telephone"
        Me.TelephoneIn.Name = "TelephoneIn"
        Me.TelephoneIn.ReadOnly = True
        Me.TelephoneIn.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "OLD PATIENT BOOK"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 137)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(88, 10)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridNewOutpatient)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(88, 137)
        Me.Panel1.TabIndex = 9
        '
        'GridNewOutpatient
        '
        Me.GridNewOutpatient.AllowUserToAddRows = False
        Me.GridNewOutpatient.AllowUserToDeleteRows = False
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridNewOutpatient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle45
        Me.GridNewOutpatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridNewOutpatient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridNewOutpatient.ColumnHeadersHeight = 30
        Me.GridNewOutpatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NewOutPatientNo, Me.NewPatientNo, Me.OlePatientNo, Me.RecieptNo, Me.NameEng, Me.NameKhmer2, Me.NewAge, Me.NewSex, Me.NewAddress, Me.PatientFee, Me.PatientDolar, Me.Diagnosis, Me.Other, Me.Prescribed, Me.Dispensed, Me.Hearing, Me.Understand, Me.Seeing, Me.Physical, Me.NewCreateDate, Me.Telephone})
        Me.GridNewOutpatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridNewOutpatient.Location = New System.Drawing.Point(0, 13)
        Me.GridNewOutpatient.Name = "GridNewOutpatient"
        Me.GridNewOutpatient.ReadOnly = True
        Me.GridNewOutpatient.RowHeadersWidth = 50
        Me.GridNewOutpatient.RowTemplate.Height = 30
        Me.GridNewOutpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridNewOutpatient.Size = New System.Drawing.Size(88, 124)
        Me.GridNewOutpatient.TabIndex = 1
        '
        'NewOutPatientNo
        '
        Me.NewOutPatientNo.DataPropertyName = "NewOutPatientNo"
        Me.NewOutPatientNo.HeaderText = "No"
        Me.NewOutPatientNo.Name = "NewOutPatientNo"
        Me.NewOutPatientNo.ReadOnly = True
        Me.NewOutPatientNo.Visible = False
        '
        'NewPatientNo
        '
        Me.NewPatientNo.DataPropertyName = "PatientNo"
        DataGridViewCellStyle46.ForeColor = System.Drawing.Color.Red
        Me.NewPatientNo.DefaultCellStyle = DataGridViewCellStyle46
        Me.NewPatientNo.HeaderText = "Patient No"
        Me.NewPatientNo.Name = "NewPatientNo"
        Me.NewPatientNo.ReadOnly = True
        Me.NewPatientNo.Width = 150
        '
        'OlePatientNo
        '
        Me.OlePatientNo.DataPropertyName = "OlePatientNo"
        Me.OlePatientNo.HeaderText = "Old PatientNo"
        Me.OlePatientNo.Name = "OlePatientNo"
        Me.OlePatientNo.ReadOnly = True
        Me.OlePatientNo.Visible = False
        Me.OlePatientNo.Width = 200
        '
        'RecieptNo
        '
        Me.RecieptNo.DataPropertyName = "ReceiptNo"
        Me.RecieptNo.HeaderText = "Reciept No"
        Me.RecieptNo.Name = "RecieptNo"
        Me.RecieptNo.ReadOnly = True
        Me.RecieptNo.Width = 150
        '
        'NameEng
        '
        Me.NameEng.DataPropertyName = "NameEng"
        Me.NameEng.HeaderText = "NameEng"
        Me.NameEng.Name = "NameEng"
        Me.NameEng.ReadOnly = True
        Me.NameEng.Visible = False
        '
        'NameKhmer2
        '
        Me.NameKhmer2.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Wat Phnom T3", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NameKhmer2.DefaultCellStyle = DataGridViewCellStyle47
        Me.NameKhmer2.HeaderText = "Name of patient/Hosp"
        Me.NameKhmer2.Name = "NameKhmer2"
        Me.NameKhmer2.ReadOnly = True
        Me.NameKhmer2.Width = 200
        '
        'NewAge
        '
        Me.NewAge.DataPropertyName = "Age"
        Me.NewAge.HeaderText = "Age"
        Me.NewAge.Name = "NewAge"
        Me.NewAge.ReadOnly = True
        Me.NewAge.Width = 50
        '
        'NewSex
        '
        Me.NewSex.DataPropertyName = "Sex"
        Me.NewSex.HeaderText = "Sex"
        Me.NewSex.Name = "NewSex"
        Me.NewSex.ReadOnly = True
        Me.NewSex.Width = 50
        '
        'NewAddress
        '
        Me.NewAddress.DataPropertyName = "Address"
        Me.NewAddress.HeaderText = "Address"
        Me.NewAddress.Name = "NewAddress"
        Me.NewAddress.ReadOnly = True
        Me.NewAddress.Width = 200
        '
        'PatientFee
        '
        Me.PatientFee.DataPropertyName = "PatientFee"
        Me.PatientFee.HeaderText = "Patient Fee"
        Me.PatientFee.Name = "PatientFee"
        Me.PatientFee.ReadOnly = True
        '
        'PatientDolar
        '
        Me.PatientDolar.DataPropertyName = "PatientDolar"
        Me.PatientDolar.HeaderText = "PatientDolar"
        Me.PatientDolar.Name = "PatientDolar"
        Me.PatientDolar.ReadOnly = True
        '
        'Diagnosis
        '
        Me.Diagnosis.DataPropertyName = "Diagnosis"
        Me.Diagnosis.HeaderText = "Diagnosis"
        Me.Diagnosis.Name = "Diagnosis"
        Me.Diagnosis.ReadOnly = True
        Me.Diagnosis.Width = 150
        '
        'Other
        '
        Me.Other.DataPropertyName = "Other"
        Me.Other.HeaderText = "Other"
        Me.Other.Name = "Other"
        Me.Other.ReadOnly = True
        '
        'Prescribed
        '
        Me.Prescribed.DataPropertyName = "Prescribed"
        Me.Prescribed.HeaderText = "Prescribed"
        Me.Prescribed.Name = "Prescribed"
        Me.Prescribed.ReadOnly = True
        Me.Prescribed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Prescribed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Dispensed
        '
        Me.Dispensed.DataPropertyName = "Dispensed"
        Me.Dispensed.HeaderText = "Dispensed"
        Me.Dispensed.Name = "Dispensed"
        Me.Dispensed.ReadOnly = True
        Me.Dispensed.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dispensed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Hearing
        '
        Me.Hearing.DataPropertyName = "Hearing"
        Me.Hearing.HeaderText = "Hearing"
        Me.Hearing.Name = "Hearing"
        Me.Hearing.ReadOnly = True
        Me.Hearing.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Hearing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Understand
        '
        Me.Understand.DataPropertyName = "Understand"
        Me.Understand.HeaderText = "Understand"
        Me.Understand.Name = "Understand"
        Me.Understand.ReadOnly = True
        Me.Understand.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Understand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Seeing
        '
        Me.Seeing.DataPropertyName = "Seeing"
        Me.Seeing.HeaderText = "Seeing"
        Me.Seeing.Name = "Seeing"
        Me.Seeing.ReadOnly = True
        Me.Seeing.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Seeing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Physical
        '
        Me.Physical.DataPropertyName = "Physical"
        Me.Physical.HeaderText = "Physical"
        Me.Physical.Name = "Physical"
        Me.Physical.ReadOnly = True
        Me.Physical.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Physical.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'NewCreateDate
        '
        Me.NewCreateDate.DataPropertyName = "CreateDate"
        DataGridViewCellStyle48.Format = "dd/MM/yyyy"
        DataGridViewCellStyle48.NullValue = Nothing
        Me.NewCreateDate.DefaultCellStyle = DataGridViewCellStyle48
        Me.NewCreateDate.HeaderText = "Date create"
        Me.NewCreateDate.Name = "NewCreateDate"
        Me.NewCreateDate.ReadOnly = True
        Me.NewCreateDate.Visible = False
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Telephone"
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        Me.Telephone.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "NEW PATIENT BOOK"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusStripPateint
        '
        Me.StatusStripPateint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrestData, Me.lblTimeShowData})
        Me.StatusStripPateint.Location = New System.Drawing.Point(3, 535)
        Me.StatusStripPateint.Name = "StatusStripPateint"
        Me.StatusStripPateint.Size = New System.Drawing.Size(1381, 25)
        Me.StatusStripPateint.TabIndex = 34
        Me.StatusStripPateint.Text = "StatusStrip1"
        Me.StatusStripPateint.Visible = False
        '
        'ProgrestData
        '
        Me.ProgrestData.Name = "ProgrestData"
        Me.ProgrestData.Size = New System.Drawing.Size(100, 19)
        Me.ProgrestData.Visible = False
        '
        'lblTimeShowData
        '
        Me.lblTimeShowData.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeShowData.Name = "lblTimeShowData"
        Me.lblTimeShowData.Size = New System.Drawing.Size(53, 20)
        Me.lblTimeShowData.Text = "Duration"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.BtnMoPoTsyo, Me.ToolStripSeparator8, Me.MainBtnNewPatientBook, Me.ToolStripSeparator1, Me.MainBtnOldPatientBook, Me.ToolStripSeparator2, Me.MaintBtnPrintInPatient, Me.ToolStripSeparator3, Me.MainBtnPrintRegistrationForm, Me.ToolStripSeparator5, Me.BtnReferToOtherHospital, Me.ToolStripSeparator6, Me.BtnShowBook, Me.ToolStripSeparator7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1751, 37)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'BtnMoPoTsyo
        '
        Me.BtnMoPoTsyo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnMoPoTsyo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnMoPoTsyo.ForeColor = System.Drawing.Color.Blue
        Me.BtnMoPoTsyo.Image = CType(resources.GetObject("BtnMoPoTsyo.Image"), System.Drawing.Image)
        Me.BtnMoPoTsyo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMoPoTsyo.Name = "BtnMoPoTsyo"
        Me.BtnMoPoTsyo.Size = New System.Drawing.Size(154, 34)
        Me.BtnMoPoTsyo.Text = "Mo.Po.Tsyo NGO's Patient"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 37)
        '
        'MainBtnNewPatientBook
        '
        Me.MainBtnNewPatientBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MainBtnNewPatientBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintNewOutPatient})
        Me.MainBtnNewPatientBook.Enabled = False
        Me.MainBtnNewPatientBook.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.MainBtnNewPatientBook.ForeColor = System.Drawing.Color.Blue
        Me.MainBtnNewPatientBook.Image = CType(resources.GetObject("MainBtnNewPatientBook.Image"), System.Drawing.Image)
        Me.MainBtnNewPatientBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MainBtnNewPatientBook.Name = "MainBtnNewPatientBook"
        Me.MainBtnNewPatientBook.Size = New System.Drawing.Size(179, 34)
        Me.MainBtnNewPatientBook.Text = "NEW PATIENT BOOK..."
        '
        'BtnPrintNewOutPatient
        '
        Me.BtnPrintNewOutPatient.Enabled = False
        Me.BtnPrintNewOutPatient.Font = New System.Drawing.Font("Khmer OS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintNewOutPatient.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintNewOutPatient.Name = "BtnPrintNewOutPatient"
        Me.BtnPrintNewOutPatient.Size = New System.Drawing.Size(261, 34)
        Me.BtnPrintNewOutPatient.Text = "បោះពុម្ផ វិក្ក័យប័ត្រ ឡើងវិញ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'MainBtnOldPatientBook
        '
        Me.MainBtnOldPatientBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MainBtnOldPatientBook.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintOldOutPatient})
        Me.MainBtnOldPatientBook.Enabled = False
        Me.MainBtnOldPatientBook.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.MainBtnOldPatientBook.ForeColor = System.Drawing.Color.Blue
        Me.MainBtnOldPatientBook.Image = CType(resources.GetObject("MainBtnOldPatientBook.Image"), System.Drawing.Image)
        Me.MainBtnOldPatientBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MainBtnOldPatientBook.Name = "MainBtnOldPatientBook"
        Me.MainBtnOldPatientBook.Size = New System.Drawing.Size(175, 34)
        Me.MainBtnOldPatientBook.Text = "OLD PATIENT BOOK..."
        '
        'BtnPrintOldOutPatient
        '
        Me.BtnPrintOldOutPatient.Enabled = False
        Me.BtnPrintOldOutPatient.Font = New System.Drawing.Font("Khmer OS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintOldOutPatient.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintOldOutPatient.Name = "BtnPrintOldOutPatient"
        Me.BtnPrintOldOutPatient.Size = New System.Drawing.Size(261, 34)
        Me.BtnPrintOldOutPatient.Text = "បោះពុម្ផ វិក្ក័យប័ត្រ ឡើងវិញ"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'MaintBtnPrintInPatient
        '
        Me.MaintBtnPrintInPatient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MaintBtnPrintInPatient.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintInPatient})
        Me.MaintBtnPrintInPatient.Enabled = False
        Me.MaintBtnPrintInPatient.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.MaintBtnPrintInPatient.ForeColor = System.Drawing.Color.Blue
        Me.MaintBtnPrintInPatient.Image = CType(resources.GetObject("MaintBtnPrintInPatient.Image"), System.Drawing.Image)
        Me.MaintBtnPrintInPatient.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MaintBtnPrintInPatient.Name = "MaintBtnPrintInPatient"
        Me.MaintBtnPrintInPatient.Size = New System.Drawing.Size(163, 34)
        Me.MaintBtnPrintInPatient.Text = "IN PATIENT BOOK..."
        '
        'BtnPrintInPatient
        '
        Me.BtnPrintInPatient.Enabled = False
        Me.BtnPrintInPatient.Font = New System.Drawing.Font("Khmer OS", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintInPatient.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintInPatient.Name = "BtnPrintInPatient"
        Me.BtnPrintInPatient.Size = New System.Drawing.Size(261, 34)
        Me.BtnPrintInPatient.Text = "បោះពុម្ផ វិក្ក័យប័ត្រ ឡើងវិញ"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'MainBtnPrintRegistrationForm
        '
        Me.MainBtnPrintRegistrationForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MainBtnPrintRegistrationForm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnPrintRegistrationFormAgain, Me.ToolStripMenuItem13, Me.BtnPrintRegisV2, Me.ToolStripSeparator9, Me.BtnUpdateRegistrationForm})
        Me.MainBtnPrintRegistrationForm.Enabled = False
        Me.MainBtnPrintRegistrationForm.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.MainBtnPrintRegistrationForm.ForeColor = System.Drawing.Color.Blue
        Me.MainBtnPrintRegistrationForm.Image = CType(resources.GetObject("MainBtnPrintRegistrationForm.Image"), System.Drawing.Image)
        Me.MainBtnPrintRegistrationForm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MainBtnPrintRegistrationForm.Name = "MainBtnPrintRegistrationForm"
        Me.MainBtnPrintRegistrationForm.Size = New System.Drawing.Size(184, 34)
        Me.MainBtnPrintRegistrationForm.Text = "Patient Registration Form"
        '
        'BtnPrintRegistrationFormAgain
        '
        Me.BtnPrintRegistrationFormAgain.Enabled = False
        Me.BtnPrintRegistrationFormAgain.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintRegistrationFormAgain.Name = "BtnPrintRegistrationFormAgain"
        Me.BtnPrintRegistrationFormAgain.Size = New System.Drawing.Size(245, 22)
        Me.BtnPrintRegistrationFormAgain.Text = "Print Registration Form V1"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(242, 6)
        '
        'BtnPrintRegisV2
        '
        Me.BtnPrintRegisV2.Enabled = False
        Me.BtnPrintRegisV2.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintRegisV2.Name = "BtnPrintRegisV2"
        Me.BtnPrintRegisV2.Size = New System.Drawing.Size(245, 22)
        Me.BtnPrintRegisV2.Text = "Print Registration Form V2"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(242, 6)
        '
        'BtnUpdateRegistrationForm
        '
        Me.BtnUpdateRegistrationForm.Enabled = False
        Me.BtnUpdateRegistrationForm.ForeColor = System.Drawing.Color.Blue
        Me.BtnUpdateRegistrationForm.Name = "BtnUpdateRegistrationForm"
        Me.BtnUpdateRegistrationForm.Size = New System.Drawing.Size(245, 22)
        Me.BtnUpdateRegistrationForm.Text = "Update Registration Form"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 37)
        '
        'BtnReferToOtherHospital
        '
        Me.BtnReferToOtherHospital.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnReferToOtherHospital.Enabled = False
        Me.BtnReferToOtherHospital.Font = New System.Drawing.Font("Khmer OS", 11.0!)
        Me.BtnReferToOtherHospital.ForeColor = System.Drawing.Color.Blue
        Me.BtnReferToOtherHospital.Image = CType(resources.GetObject("BtnReferToOtherHospital.Image"), System.Drawing.Image)
        Me.BtnReferToOtherHospital.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReferToOtherHospital.Name = "BtnReferToOtherHospital"
        Me.BtnReferToOtherHospital.Size = New System.Drawing.Size(222, 34)
        Me.BtnReferToOtherHospital.Text = "បញ្ជូន Patient ទៅមន្ទីពេទ្យផ្សេង"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 37)
        '
        'BtnShowBook
        '
        Me.BtnShowBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnShowBook.Enabled = False
        Me.BtnShowBook.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.BtnShowBook.ForeColor = System.Drawing.Color.Blue
        Me.BtnShowBook.Image = CType(resources.GetObject("BtnShowBook.Image"), System.Drawing.Image)
        Me.BtnShowBook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnShowBook.Name = "BtnShowBook"
        Me.BtnShowBook.Size = New System.Drawing.Size(132, 34)
        Me.BtnShowBook.Text = "Show Patient Book"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 37)
        Me.ToolStripSeparator7.Visible = False
        '
        'ImgPatient
        '
        Me.ImgPatient.ImageStream = CType(resources.GetObject("ImgPatient.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgPatient.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgPatient.Images.SetKeyName(0, "BindingNavigatorMoveLastItem.Image.png")
        Me.ImgPatient.Images.SetKeyName(1, "BindingNavigatorMoveFirstItem.Image.png")
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 272
        Me.LineShape1.Y1 = 49
        Me.LineShape1.Y2 = 49
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape1"
        Me.LineShape2.X1 = -1
        Me.LineShape2.X2 = 272
        Me.LineShape2.Y1 = 49
        Me.LineShape2.Y2 = 49
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape1"
        Me.LineShape3.X1 = -1
        Me.LineShape3.X2 = 272
        Me.LineShape3.Y1 = 49
        Me.LineShape3.Y2 = 49
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape1"
        Me.LineShape4.X1 = -1
        Me.LineShape4.X2 = 272
        Me.LineShape4.Y1 = 49
        Me.LineShape4.Y2 = 49
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape1"
        Me.LineShape5.X1 = -1
        Me.LineShape5.X2 = 272
        Me.LineShape5.Y1 = 49
        Me.LineShape5.Y2 = 49
        '
        'bgPatient
        '
        '
        'TimerSearchPatien
        '
        '
        'TblPatientsTableAdapter
        '
        Me.TblPatientsTableAdapter.ClearBeforeFill = True
        '
        'V_OldOutpatientTableAdapter
        '
        Me.V_OldOutpatientTableAdapter.ClearBeforeFill = True
        '
        'V_InpatientTableAdapter
        '
        Me.V_InpatientTableAdapter.ClearBeforeFill = True
        '
        'V_NewoutpatientTableAdapter
        '
        Me.V_NewoutpatientTableAdapter.ClearBeforeFill = True
        '
        'RibboStatusBar
        '
        Me.RibboStatusBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibboStatusBar.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibboStatusBar.ImageSize = New System.Drawing.Size(24, 24)
        Me.RibboStatusBar.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand1, Me.BtnFindPatient, Me.BtnUpdatePatient, Me.BtnViewSupInvoice, Me.DropDownCommand2, Me.DropDownCommand6, Me.BtnReferToOtherHospitalV1, Me.ButtonCommand3})
        Me.RibboStatusBar.Location = New System.Drawing.Point(0, 0)
        Me.RibboStatusBar.Margin = New System.Windows.Forms.Padding(2)
        Me.RibboStatusBar.Name = "RibboStatusBar"
        Me.RibboStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibboStatusBar.Office2007CustomColor = System.Drawing.Color.Green
        Me.RibboStatusBar.ShowToolTips = False
        Me.RibboStatusBar.Size = New System.Drawing.Size(1751, 32)
        '
        '
        '
        Me.RibboStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.RibboStatusBar.SuperTipComponent.BackColor = System.Drawing.Color.Green
        Me.RibboStatusBar.SuperTipComponent.ImageList = Nothing
        Me.RibboStatusBar.TabIndex = 5
        Me.RibboStatusBar.Text = "RibbonStatusBar1"
        Me.RibboStatusBar.UseCompatibleTextRendering = False
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnNew, Me.SeparatorCommand1, Me.BtnOldOutPatientReceipt, Me.SeparatorCommand2, Me.BtnInpatientReceipt, Me.SeparatorCommand8, Me.BtnShowBookV1})
        Me.DropDownCommand1.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DropDownCommand1.Image = CType(resources.GetObject("DropDownCommand1.Image"), System.Drawing.Image)
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.DropDownCommand1.Text = "Registration Form"
        '
        'BtnNew
        '
        Me.BtnNew.Enabled = False
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Key = "New Invoice"
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Text = "New Patient Registration"
        '
        'SeparatorCommand1
        '
        Me.SeparatorCommand1.Key = "SeparatorCommand1"
        Me.SeparatorCommand1.Name = "SeparatorCommand1"
        '
        'BtnOldOutPatientReceipt
        '
        Me.BtnOldOutPatientReceipt.Enabled = False
        Me.BtnOldOutPatientReceipt.Image = CType(resources.GetObject("BtnOldOutPatientReceipt.Image"), System.Drawing.Image)
        Me.BtnOldOutPatientReceipt.Key = "Old Invoice"
        Me.BtnOldOutPatientReceipt.Name = "BtnOldOutPatientReceipt"
        Me.BtnOldOutPatientReceipt.Text = "Old Patient Registration"
        '
        'SeparatorCommand2
        '
        Me.SeparatorCommand2.Key = "SeparatorCommand2"
        Me.SeparatorCommand2.Name = "SeparatorCommand2"
        '
        'BtnInpatientReceipt
        '
        Me.BtnInpatientReceipt.Enabled = False
        Me.BtnInpatientReceipt.Image = CType(resources.GetObject("BtnInpatientReceipt.Image"), System.Drawing.Image)
        Me.BtnInpatientReceipt.Key = "In Invoice"
        Me.BtnInpatientReceipt.Name = "BtnInpatientReceipt"
        Me.BtnInpatientReceipt.Text = "In Patient Registration"
        '
        'SeparatorCommand8
        '
        Me.SeparatorCommand8.Key = "SeparatorCommand8"
        Me.SeparatorCommand8.Name = "SeparatorCommand8"
        '
        'BtnShowBookV1
        '
        Me.BtnShowBookV1.Enabled = False
        Me.BtnShowBookV1.Image = CType(resources.GetObject("BtnShowBookV1.Image"), System.Drawing.Image)
        Me.BtnShowBookV1.Key = "DropDownCommand10"
        Me.BtnShowBookV1.Name = "BtnShowBookV1"
        Me.BtnShowBookV1.Text = "Show Patient Book"
        '
        'BtnFindPatient
        '
        Me.BtnFindPatient.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.BtnFindPatient.Image = CType(resources.GetObject("BtnFindPatient.Image"), System.Drawing.Image)
        Me.BtnFindPatient.Key = "ButtonCommand1"
        Me.BtnFindPatient.Name = "BtnFindPatient"
        Me.BtnFindPatient.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.BtnFindPatient.Text = "Search Patient Info"
        '
        'BtnUpdatePatient
        '
        Me.BtnUpdatePatient.Enabled = False
        Me.BtnUpdatePatient.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.BtnUpdatePatient.Image = CType(resources.GetObject("BtnUpdatePatient.Image"), System.Drawing.Image)
        Me.BtnUpdatePatient.Key = "ButtonCommand2"
        Me.BtnUpdatePatient.Name = "BtnUpdatePatient"
        Me.BtnUpdatePatient.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.BtnUpdatePatient.Text = "Upadate Patient Info"
        '
        'BtnViewSupInvoice
        '
        Me.BtnViewSupInvoice.ForegroundStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnViewSupInvoice.Image = CType(resources.GetObject("BtnViewSupInvoice.Image"), System.Drawing.Image)
        Me.BtnViewSupInvoice.Key = "ButtonCommand1"
        Me.BtnViewSupInvoice.Name = "BtnViewSupInvoice"
        Me.BtnViewSupInvoice.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.BtnViewSupInvoice.Text = "View Sub Invoice"
        '
        'DropDownCommand2
        '
        Me.DropDownCommand2.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnPrintNewOutPatientV1, Me.SeparatorCommand3, Me.BtnPrintOldOutPatientV1, Me.SeparatorCommand4, Me.BtnPrintInPatientV1, Me.SeparatorCommand5})
        Me.DropDownCommand2.ForegroundStyle.ForeColor = System.Drawing.Color.Navy
        Me.DropDownCommand2.Image = CType(resources.GetObject("DropDownCommand2.Image"), System.Drawing.Image)
        Me.DropDownCommand2.Key = "DropDownCommand2"
        Me.DropDownCommand2.Name = "DropDownCommand2"
        Me.DropDownCommand2.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.DropDownCommand2.Text = " Invoice Utility"
        '
        'BtnPrintNewOutPatientV1
        '
        Me.BtnPrintNewOutPatientV1.Enabled = False
        Me.BtnPrintNewOutPatientV1.Image = CType(resources.GetObject("BtnPrintNewOutPatientV1.Image"), System.Drawing.Image)
        Me.BtnPrintNewOutPatientV1.Key = "DropDownCommand3"
        Me.BtnPrintNewOutPatientV1.Name = "BtnPrintNewOutPatientV1"
        Me.BtnPrintNewOutPatientV1.Text = "Re-Print New Invoice"
        '
        'SeparatorCommand3
        '
        Me.SeparatorCommand3.Key = "SeparatorCommand3"
        Me.SeparatorCommand3.Name = "SeparatorCommand3"
        '
        'BtnPrintOldOutPatientV1
        '
        Me.BtnPrintOldOutPatientV1.Enabled = False
        Me.BtnPrintOldOutPatientV1.Image = CType(resources.GetObject("BtnPrintOldOutPatientV1.Image"), System.Drawing.Image)
        Me.BtnPrintOldOutPatientV1.Key = "DropDownCommand4"
        Me.BtnPrintOldOutPatientV1.Name = "BtnPrintOldOutPatientV1"
        Me.BtnPrintOldOutPatientV1.Text = "Re-Print Old Invoice"
        '
        'SeparatorCommand4
        '
        Me.SeparatorCommand4.Key = "SeparatorCommand4"
        Me.SeparatorCommand4.Name = "SeparatorCommand4"
        '
        'BtnPrintInPatientV1
        '
        Me.BtnPrintInPatientV1.Enabled = False
        Me.BtnPrintInPatientV1.Image = CType(resources.GetObject("BtnPrintInPatientV1.Image"), System.Drawing.Image)
        Me.BtnPrintInPatientV1.Key = "DropDownCommand5"
        Me.BtnPrintInPatientV1.Name = "BtnPrintInPatientV1"
        Me.BtnPrintInPatientV1.Text = "Re-Print In-Invoice"
        '
        'SeparatorCommand5
        '
        Me.SeparatorCommand5.Key = "SeparatorCommand5"
        Me.SeparatorCommand5.Name = "SeparatorCommand5"
        '
        'DropDownCommand6
        '
        Me.DropDownCommand6.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnPrintRegistrationFormAgainV1, Me.SeparatorCommand6, Me.BtnPrintRegisV21, Me.SeparatorCommand7, Me.BtnUpdateRegistrationFormv1})
        Me.DropDownCommand6.ForegroundStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DropDownCommand6.Image = CType(resources.GetObject("DropDownCommand6.Image"), System.Drawing.Image)
        Me.DropDownCommand6.Key = "DropDownCommand6"
        Me.DropDownCommand6.Name = "DropDownCommand6"
        Me.DropDownCommand6.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.DropDownCommand6.Text = "Patient Registration Form"
        '
        'BtnPrintRegistrationFormAgainV1
        '
        Me.BtnPrintRegistrationFormAgainV1.Enabled = False
        Me.BtnPrintRegistrationFormAgainV1.Image = CType(resources.GetObject("BtnPrintRegistrationFormAgainV1.Image"), System.Drawing.Image)
        Me.BtnPrintRegistrationFormAgainV1.Key = "DropDownCommand7"
        Me.BtnPrintRegistrationFormAgainV1.Name = "BtnPrintRegistrationFormAgainV1"
        Me.BtnPrintRegistrationFormAgainV1.Text = "Print Registration Form V1"
        '
        'SeparatorCommand6
        '
        Me.SeparatorCommand6.Key = "SeparatorCommand6"
        Me.SeparatorCommand6.Name = "SeparatorCommand6"
        '
        'BtnPrintRegisV21
        '
        Me.BtnPrintRegisV21.Enabled = False
        Me.BtnPrintRegisV21.Image = CType(resources.GetObject("BtnPrintRegisV21.Image"), System.Drawing.Image)
        Me.BtnPrintRegisV21.Key = "DropDownCommand8"
        Me.BtnPrintRegisV21.Name = "BtnPrintRegisV21"
        Me.BtnPrintRegisV21.Text = "Print Registration Form V2"
        '
        'SeparatorCommand7
        '
        Me.SeparatorCommand7.Key = "SeparatorCommand7"
        Me.SeparatorCommand7.Name = "SeparatorCommand7"
        '
        'BtnUpdateRegistrationFormv1
        '
        Me.BtnUpdateRegistrationFormv1.Enabled = False
        Me.BtnUpdateRegistrationFormv1.Image = CType(resources.GetObject("BtnUpdateRegistrationFormv1.Image"), System.Drawing.Image)
        Me.BtnUpdateRegistrationFormv1.Key = "DropDownCommand9"
        Me.BtnUpdateRegistrationFormv1.Name = "BtnUpdateRegistrationFormv1"
        Me.BtnUpdateRegistrationFormv1.Text = "Update Registration Form"
        '
        'BtnReferToOtherHospitalV1
        '
        Me.BtnReferToOtherHospitalV1.Enabled = False
        Me.BtnReferToOtherHospitalV1.ForegroundStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnReferToOtherHospitalV1.Image = CType(resources.GetObject("BtnReferToOtherHospitalV1.Image"), System.Drawing.Image)
        Me.BtnReferToOtherHospitalV1.Key = "ButtonCommand1"
        Me.BtnReferToOtherHospitalV1.Name = "BtnReferToOtherHospitalV1"
        Me.BtnReferToOtherHospitalV1.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.BtnReferToOtherHospitalV1.Text = "បញ្ជូន Patient ទៅមន្ទីពេទ្យផ្សេង"
        '
        'ButtonCommand3
        '
        Me.ButtonCommand3.ForegroundStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCommand3.Image = CType(resources.GetObject("ButtonCommand3.Image"), System.Drawing.Image)
        Me.ButtonCommand3.Key = "ButtonCommand3"
        Me.ButtonCommand3.Name = "ButtonCommand3"
        Me.ButtonCommand3.Text = "Mo.Po.Tsyo NGO's Patient"
        '
        'ErrPatient
        '
        Me.ErrPatient.ContainerControl = Me
        '
        'UCPatientPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibboStatusBar)
        Me.Name = "UCPatientPayment"
        Me.Size = New System.Drawing.Size(1751, 1091)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupPatientFee.ResumeLayout(False)
        Me.GroupPatientFee.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GridConsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridPatientInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContexMenuPatientReciept.ResumeLayout(False)
        CType(Me.DSPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.InpatientBook.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridInpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridOldOutPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridNewOutpatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStripPateint.ResumeLayout(False)
        Me.StatusStripPateint.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPatientFee As System.Windows.Forms.GroupBox

    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents bgPatient As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimerSearchPatien As System.Windows.Forms.Timer
    Friend WithEvents ErrPatient As System.Windows.Forms.ErrorProvider
    Friend WithEvents StatusStripPateint As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgrestData As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblTimeShowData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TxtPatientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNameKhmer As System.Windows.Forms.TextBox
    Friend WithEvents TxtNameEng As System.Windows.Forms.TextBox
    Friend WithEvents CboCommNo As System.Windows.Forms.ComboBox
    Friend WithEvents CboDisNo As System.Windows.Forms.ComboBox
    Friend WithEvents CboProNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents CboSexPatien As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblSaveOption As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ContexMenuPatientReciept As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MNewPatientBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuOldPatientBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MInPateintBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DSPatient As TakeoHospitalInventory.DSDashboardPatient
    Friend WithEvents TblPatientsTableAdapter As TakeoHospitalInventory.DSDashboardPatientTableAdapters.TblPatientsTableAdapter
    Friend WithEvents V_OldOutpatientTableAdapter As TakeoHospitalInventory.DSDashboardPatientTableAdapters.V_OldOutpatientTableAdapter
    Friend WithEvents V_InpatientTableAdapter As TakeoHospitalInventory.DSDashboardPatientTableAdapters.V_InpatientTableAdapter
    Friend WithEvents V_NewoutpatientTableAdapter As TakeoHospitalInventory.DSDashboardPatientTableAdapters.V_NewoutpatientTableAdapter
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuRegistrationForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TxtAgePatient As System.Windows.Forms.TextBox
    Friend WithEvents BtnCashReceipt As System.Windows.Forms.Button
    Friend WithEvents BtnNewOutPatient As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InpatientBook As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridPatientInformation As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GridOldOutPatient As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents MFree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MFreeOldPatientBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MFreeInPatientbook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GridNewOutpatient As System.Windows.Forms.DataGridView
    Friend WithEvents MPrintPatientNewReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MCreateOldPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MPrintOldPatientReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MCreateInpatientBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MPrintInpatientReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnPatientAchive As System.Windows.Forms.Button
    Friend WithEvents GridInpatient As System.Windows.Forms.DataGridView
    Friend WithEvents ImgPatient As System.Windows.Forms.ImageList
    Friend WithEvents CreateNewoutPatientBook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DateRegis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CboOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PatientReferToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MainBtnNewPatientBook As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnPrintNewOutPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainBtnOldPatientBook As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnPrintOldOutPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaintBtnPrintInPatient As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainBtnPrintRegistrationForm As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents BtnPrintRegistrationFormAgain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateRegistrationForm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnReferToOtherHospital As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnShowBook As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrintInPatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnMoPoTsyo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintRegisV2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GridConsult As Janus.Windows.GridEX.GridEX
    Friend WithEvents NewOutPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewPatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OlePatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecieptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameEng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewSex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientDolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Other As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prescribed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Dispensed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Hearing As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Understand As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Seeing As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Physical As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NewCreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephoneold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfOperation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HosFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SocialFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DolarSosial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullFee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DolarFull As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Other1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientDolar1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RibboStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnNew As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand1 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnOldOutPatientReceipt As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand2 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnInpatientReceipt As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnFindPatient As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents BtnUpdatePatient As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents BtnViewSupInvoice As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents DropDownCommand2 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnPrintNewOutPatientV1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand3 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnPrintOldOutPatientV1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand4 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnPrintInPatientV1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand5 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents DropDownCommand6 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnPrintRegistrationFormAgainV1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand6 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnPrintRegisV21 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand7 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnUpdateRegistrationFormv1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnReferToOtherHospitalV1 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents ButtonCommand3 As Janus.Windows.Ribbon.ButtonCommand
    Friend WithEvents SeparatorCommand8 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnShowBookV1 As Janus.Windows.Ribbon.DropDownCommand

End Class
