<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewReceipt
    Inherits System.Windows.Forms.Form


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewReceipt))
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim GridListOfItem_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.DateCreateReceipt = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSerchPatient = New System.Windows.Forms.Button
        Me.TxtSearchPNo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblCombindReferal = New System.Windows.Forms.Label
        Me.LblReceiptID = New System.Windows.Forms.Label
        Me.CheOldPatient = New System.Windows.Forms.CheckBox
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.BtnRemoveItem = New System.Windows.Forms.Button
        Me.TxtCusNameEng = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.TextBox
        Me.TxtSex = New System.Windows.Forms.TextBox
        Me.TxtCusOccupation = New System.Windows.Forms.TextBox
        Me.TxtCustomerName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnSelectPatient = New Janus.Windows.EditControls.UIButton
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.BtnCleanCustomer = New Janus.Windows.EditControls.UIButton
        Me.BtnAddCustomer = New Janus.Windows.EditControls.UIButton
        Me.TxtCustomerID = New System.Windows.Forms.TextBox
        Me.GridItemDetail = New System.Windows.Forms.DataGridView
        Me.ColumnItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnPrice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColumnQTY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalDolar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Picture = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemCost = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXCHANGE_RATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtAmountInWord = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GPIncomeType = New System.Windows.Forms.GroupBox
        Me.lblIspaid = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.DateConsult = New System.Windows.Forms.DateTimePicker
        Me.LblConsultID = New System.Windows.Forms.Label
        Me.LblSendBy = New System.Windows.Forms.Label
        Me.lblConsultFor = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.LblConsultDate = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.LblConsultType = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.RadLV = New System.Windows.Forms.RadioButton
        Me.RadCustomerMadeSpectacle = New System.Windows.Forms.RadioButton
        Me.RadReadyMadeSpectacle = New System.Windows.Forms.RadioButton
        Me.RadSunGlasses = New System.Windows.Forms.RadioButton
        Me.LblSaveStatus = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.RadOther = New System.Windows.Forms.RadioButton
        Me.ChDonation = New System.Windows.Forms.CheckBox
        Me.RadFundRaising = New System.Windows.Forms.RadioButton
        Me.RadMedicine = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtDonateAmount = New System.Windows.Forms.TextBox
        Me.CboDonation = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GBoxCustomerMade = New System.Windows.Forms.GroupBox
        Me.RadDistance1 = New System.Windows.Forms.RadioButton
        Me.RadRedding1 = New System.Windows.Forms.RadioButton
        Me.RadBifocal = New System.Windows.Forms.RadioButton
        Me.GBoxReadyMade = New System.Windows.Forms.GroupBox
        Me.RadDistance2 = New System.Windows.Forms.RadioButton
        Me.RadRedding2 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtTotalAsReal = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.TxtTotalAsDolar = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cmdAddRate = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnSaveReceipt = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.LblTotalConsult = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ChIsPrintFull = New System.Windows.Forms.CheckBox
        Me.GBPaymentType = New System.Windows.Forms.GroupBox
        Me.GroupPayCorrency = New System.Windows.Forms.GroupBox
        Me.RadKHR = New System.Windows.Forms.RadioButton
        Me.RadUSD = New System.Windows.Forms.RadioButton
        Me.TxtSocialAmount = New System.Windows.Forms.TextBox
        Me.TxtNilAmount = New System.Windows.Forms.TextBox
        Me.TxtFullAmount = New System.Windows.Forms.TextBox
        Me.RadNil = New System.Windows.Forms.RadioButton
        Me.RadSocial = New System.Windows.Forms.RadioButton
        Me.RadFull = New System.Windows.Forms.RadioButton
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TxtNumGlasses = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ChbNewGlasses = New System.Windows.Forms.CheckBox
        Me.TxtReceiptNo = New System.Windows.Forms.Label
        Me.ChPrintPreview = New System.Windows.Forms.CheckBox
        Me.TxtGetBarcode = New System.Windows.Forms.TextBox
        Me.ErrReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgSaveAndPrinting = New System.ComponentModel.BackgroundWorker
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtItemNameSearch = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridListOfItem = New Janus.Windows.GridEX.GridEX
        Me.BtnRemoveV1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridItemDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GPIncomeType.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBoxCustomerMade.SuspendLayout()
        Me.GBoxReadyMade.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBPaymentType.SuspendLayout()
        Me.GroupPayCorrency.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridListOfItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateCreateReceipt
        '
        Me.DateCreateReceipt.CustomFormat = "dd/MM/yyyy"
        Me.DateCreateReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreateReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCreateReceipt.Location = New System.Drawing.Point(95, 61)
        Me.DateCreateReceipt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateCreateReceipt.Name = "DateCreateReceipt"
        Me.DateCreateReceipt.ShowCheckBox = True
        Me.DateCreateReceipt.Size = New System.Drawing.Size(130, 26)
        Me.DateCreateReceipt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Invoice Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Invoice No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnSerchPatient)
        Me.GroupBox1.Controls.Add(Me.TxtSearchPNo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.LblCombindReferal)
        Me.GroupBox1.Controls.Add(Me.LblReceiptID)
        Me.GroupBox1.Controls.Add(Me.CheOldPatient)
        Me.GroupBox1.Controls.Add(Me.BtnAddItem)
        Me.GroupBox1.Controls.Add(Me.BtnRemoveItem)
        Me.GroupBox1.Controls.Add(Me.TxtCusNameEng)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.TxtCusOccupation)
        Me.GroupBox1.Controls.Add(Me.TxtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(852, 156)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Informatrion"
        '
        'BtnSerchPatient
        '
        Me.BtnSerchPatient.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSerchPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSerchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSerchPatient.Image = CType(resources.GetObject("BtnSerchPatient.Image"), System.Drawing.Image)
        Me.BtnSerchPatient.Location = New System.Drawing.Point(305, 30)
        Me.BtnSerchPatient.Name = "BtnSerchPatient"
        Me.BtnSerchPatient.Size = New System.Drawing.Size(44, 33)
        Me.BtnSerchPatient.TabIndex = 21
        Me.BtnSerchPatient.UseVisualStyleBackColor = False
        '
        'TxtSearchPNo
        '
        Me.TxtSearchPNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSearchPNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.TxtSearchPNo.Location = New System.Drawing.Point(76, 30)
        Me.TxtSearchPNo.Name = "TxtSearchPNo"
        Me.TxtSearchPNo.Size = New System.Drawing.Size(230, 33)
        Me.TxtSearchPNo.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "P-No:"
        '
        'LblCombindReferal
        '
        Me.LblCombindReferal.AutoSize = True
        Me.LblCombindReferal.Location = New System.Drawing.Point(688, 135)
        Me.LblCombindReferal.Name = "LblCombindReferal"
        Me.LblCombindReferal.Size = New System.Drawing.Size(82, 13)
        Me.LblCombindReferal.TabIndex = 11
        Me.LblCombindReferal.Text = "CombindReferal"
        Me.LblCombindReferal.Visible = False
        '
        'LblReceiptID
        '
        Me.LblReceiptID.AutoSize = True
        Me.LblReceiptID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblReceiptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblReceiptID.ForeColor = System.Drawing.Color.Red
        Me.LblReceiptID.Location = New System.Drawing.Point(546, 101)
        Me.LblReceiptID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblReceiptID.Name = "LblReceiptID"
        Me.LblReceiptID.Size = New System.Drawing.Size(21, 22)
        Me.LblReceiptID.TabIndex = 12
        Me.LblReceiptID.Text = "0"
        Me.LblReceiptID.Visible = False
        '
        'CheOldPatient
        '
        Me.CheOldPatient.AutoSize = True
        Me.CheOldPatient.BackColor = System.Drawing.SystemColors.Control
        Me.CheOldPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheOldPatient.ForeColor = System.Drawing.Color.Red
        Me.CheOldPatient.Location = New System.Drawing.Point(735, 30)
        Me.CheOldPatient.Name = "CheOldPatient"
        Me.CheOldPatient.Size = New System.Drawing.Size(117, 24)
        Me.CheOldPatient.TabIndex = 10
        Me.CheOldPatient.Text = "Old Patient"
        Me.CheOldPatient.UseVisualStyleBackColor = False
        Me.CheOldPatient.Visible = False
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources._new
        Me.BtnAddItem.Location = New System.Drawing.Point(670, 60)
        Me.BtnAddItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(38, 31)
        Me.BtnAddItem.TabIndex = 4
        Me.BtnAddItem.UseVisualStyleBackColor = True
        Me.BtnAddItem.Visible = False
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveItem.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cross_circle
        Me.BtnRemoveItem.Location = New System.Drawing.Point(723, 61)
        Me.BtnRemoveItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(38, 31)
        Me.BtnRemoveItem.TabIndex = 5
        Me.BtnRemoveItem.UseVisualStyleBackColor = True
        Me.BtnRemoveItem.Visible = False
        '
        'TxtCusNameEng
        '
        Me.TxtCusNameEng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCusNameEng.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.TxtCusNameEng.Location = New System.Drawing.Point(351, 30)
        Me.TxtCusNameEng.Name = "TxtCusNameEng"
        Me.TxtCusNameEng.ReadOnly = True
        Me.TxtCusNameEng.Size = New System.Drawing.Size(179, 33)
        Me.TxtCusNameEng.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name:"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(76, 109)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(456, 37)
        Me.txtAddress.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(585, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Occupation:"
        Me.Label6.Visible = False
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.Control
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(451, 76)
        Me.TxtAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(79, 26)
        Me.TxtAge.TabIndex = 4
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(351, 76)
        Me.TxtSex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(48, 26)
        Me.TxtSex.TabIndex = 3
        '
        'TxtCusOccupation
        '
        Me.TxtCusOccupation.BackColor = System.Drawing.Color.White
        Me.TxtCusOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCusOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCusOccupation.Location = New System.Drawing.Point(653, 92)
        Me.TxtCusOccupation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCusOccupation.Name = "TxtCusOccupation"
        Me.TxtCusOccupation.ReadOnly = True
        Me.TxtCusOccupation.Size = New System.Drawing.Size(230, 26)
        Me.TxtCusOccupation.TabIndex = 2
        Me.TxtCusOccupation.Visible = False
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BackColor = System.Drawing.SystemColors.Control
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerName.Font = New System.Drawing.Font("Limon S1", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(76, 69)
        Me.TxtCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(230, 33)
        Me.TxtCustomerName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(416, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Age:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sex:"
        '
        'BtnSelectPatient
        '
        Me.BtnSelectPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelectPatient.Location = New System.Drawing.Point(734, 131)
        Me.BtnSelectPatient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSelectPatient.Name = "BtnSelectPatient"
        Me.BtnSelectPatient.Size = New System.Drawing.Size(119, 34)
        Me.BtnSelectPatient.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSelectPatient.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.BtnSelectPatient.TabIndex = 6
        Me.BtnSelectPatient.Text = "Select New Patient"
        Me.BtnSelectPatient.Visible = False
        Me.BtnSelectPatient.VisualStyleManager = Me.VisualStyleManager1
        '
        'VisualStyleManager1
        '
        JanusColorScheme2.ActiveCaptionColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme2.ControlColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme2.ControlDarkColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme2.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme2.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme2.InfoColor = System.Drawing.Color.White
        JanusColorScheme2.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme2.MenuColor = System.Drawing.Color.White
        JanusColorScheme2.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme2.Name = "Scheme0"
        JanusColorScheme2.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.UseThemes = False
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme2.WindowColor = System.Drawing.Color.White
        JanusColorScheme2.WindowTextColor = System.Drawing.Color.Black
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme2)
        '
        'BtnCleanCustomer
        '
        Me.BtnCleanCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCleanCustomer.Location = New System.Drawing.Point(660, 118)
        Me.BtnCleanCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCleanCustomer.Name = "BtnCleanCustomer"
        Me.BtnCleanCustomer.Size = New System.Drawing.Size(109, 35)
        Me.BtnCleanCustomer.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnCleanCustomer.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.BtnCleanCustomer.TabIndex = 8
        Me.BtnCleanCustomer.Text = "Clean Cus-info"
        Me.BtnCleanCustomer.Visible = False
        Me.BtnCleanCustomer.VisualStyleManager = Me.VisualStyleManager1
        '
        'BtnAddCustomer
        '
        Me.BtnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCustomer.Location = New System.Drawing.Point(624, 157)
        Me.BtnAddCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddCustomer.Name = "BtnAddCustomer"
        Me.BtnAddCustomer.Size = New System.Drawing.Size(161, 35)
        Me.BtnAddCustomer.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnAddCustomer.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.BtnAddCustomer.TabIndex = 7
        Me.BtnAddCustomer.Text = "Select New Customer And Old Patient"
        Me.BtnAddCustomer.Visible = False
        Me.BtnAddCustomer.VisualStyleManager = Me.VisualStyleManager1
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.BackColor = System.Drawing.Color.White
        Me.TxtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerID.Location = New System.Drawing.Point(609, 137)
        Me.TxtCustomerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.ReadOnly = True
        Me.TxtCustomerID.Size = New System.Drawing.Size(73, 26)
        Me.TxtCustomerID.TabIndex = 1
        Me.TxtCustomerID.Visible = False
        '
        'GridItemDetail
        '
        Me.GridItemDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.GridItemDetail.AllowUserToAddRows = False
        Me.GridItemDetail.AllowUserToDeleteRows = False
        Me.GridItemDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridItemDetail.BackgroundColor = System.Drawing.SystemColors.Window
        Me.GridItemDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridItemDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridItemDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnItemID, Me.ColumnBarcode, Me.ColumnName, Me.ColumnPrice, Me.ColumnQTY, Me.SubTotal, Me.SubTotalDolar, Me.Picture, Me.ItemCost, Me.EXCHANGE_RATE})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridItemDetail.DefaultCellStyle = DataGridViewCellStyle12
        Me.GridItemDetail.EnableHeadersVisualStyles = False
        Me.GridItemDetail.Location = New System.Drawing.Point(5, 371)
        Me.GridItemDetail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridItemDetail.Name = "GridItemDetail"
        Me.GridItemDetail.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridItemDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.GridItemDetail.RowTemplate.Height = 30
        Me.GridItemDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridItemDetail.Size = New System.Drawing.Size(536, 393)
        Me.GridItemDetail.TabIndex = 3
        '
        'ColumnItemID
        '
        Me.ColumnItemID.DataPropertyName = "ColumnItemID"
        Me.ColumnItemID.HeaderText = "ColumnItemID"
        Me.ColumnItemID.Name = "ColumnItemID"
        Me.ColumnItemID.ReadOnly = True
        Me.ColumnItemID.Visible = False
        Me.ColumnItemID.Width = 50
        '
        'ColumnBarcode
        '
        Me.ColumnBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnBarcode.DataPropertyName = "ColumnBarcode"
        Me.ColumnBarcode.HeaderText = "Barcode"
        Me.ColumnBarcode.Name = "ColumnBarcode"
        Me.ColumnBarcode.ReadOnly = True
        Me.ColumnBarcode.Visible = False
        '
        'ColumnName
        '
        Me.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnName.DataPropertyName = "ColumnName"
        Me.ColumnName.HeaderText = "Name"
        Me.ColumnName.Name = "ColumnName"
        Me.ColumnName.ReadOnly = True
        Me.ColumnName.Width = 150
        '
        'ColumnPrice
        '
        Me.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnPrice.DataPropertyName = "ColumnPrice"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColumnPrice.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColumnPrice.HeaderText = "Price"
        Me.ColumnPrice.Name = "ColumnPrice"
        Me.ColumnPrice.ReadOnly = True
        Me.ColumnPrice.Width = 50
        '
        'ColumnQTY
        '
        Me.ColumnQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColumnQTY.DataPropertyName = "ColumnQTY"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColumnQTY.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColumnQTY.HeaderText = "Qty"
        Me.ColumnQTY.Name = "ColumnQTY"
        Me.ColumnQTY.ReadOnly = True
        Me.ColumnQTY.Width = 50
        '
        'SubTotal
        '
        Me.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubTotal.DataPropertyName = "SubTotalReal"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "R"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle10
        Me.SubTotal.HeaderText = "Total R"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.Width = 120
        '
        'SubTotalDolar
        '
        Me.SubTotalDolar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SubTotalDolar.DataPropertyName = "SubTotalDolar"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SubTotalDolar.DefaultCellStyle = DataGridViewCellStyle11
        Me.SubTotalDolar.HeaderText = "Total $"
        Me.SubTotalDolar.Name = "SubTotalDolar"
        Me.SubTotalDolar.ReadOnly = True
        Me.SubTotalDolar.Width = 120
        '
        'Picture
        '
        Me.Picture.DataPropertyName = "Picture"
        Me.Picture.HeaderText = "Picture"
        Me.Picture.Name = "Picture"
        Me.Picture.ReadOnly = True
        Me.Picture.Visible = False
        '
        'ItemCost
        '
        Me.ItemCost.DataPropertyName = "ItemCost"
        Me.ItemCost.HeaderText = "ItemCost"
        Me.ItemCost.Name = "ItemCost"
        Me.ItemCost.ReadOnly = True
        Me.ItemCost.Visible = False
        '
        'EXCHANGE_RATE
        '
        Me.EXCHANGE_RATE.DataPropertyName = "EXCHANGE_RATE"
        Me.EXCHANGE_RATE.HeaderText = "EXCHANGE_RATE"
        Me.EXCHANGE_RATE.Name = "EXCHANGE_RATE"
        Me.EXCHANGE_RATE.ReadOnly = True
        Me.EXCHANGE_RATE.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TxtAmountInWord)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.GPIncomeType)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 373)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(851, 331)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "In payment for"
        '
        'TxtAmountInWord
        '
        Me.TxtAmountInWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAmountInWord.BackColor = System.Drawing.Color.White
        Me.TxtAmountInWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmountInWord.Location = New System.Drawing.Point(6, 47)
        Me.TxtAmountInWord.Name = "TxtAmountInWord"
        Me.TxtAmountInWord.ReadOnly = True
        Me.TxtAmountInWord.Size = New System.Drawing.Size(836, 30)
        Me.TxtAmountInWord.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Amount In Words :"
        '
        'GPIncomeType
        '
        Me.GPIncomeType.Controls.Add(Me.lblIspaid)
        Me.GPIncomeType.Controls.Add(Me.GroupBox10)
        Me.GPIncomeType.Controls.Add(Me.RadLV)
        Me.GPIncomeType.Controls.Add(Me.RadCustomerMadeSpectacle)
        Me.GPIncomeType.Controls.Add(Me.RadReadyMadeSpectacle)
        Me.GPIncomeType.Controls.Add(Me.RadSunGlasses)
        Me.GPIncomeType.Controls.Add(Me.LblSaveStatus)
        Me.GPIncomeType.Controls.Add(Me.Label7)
        Me.GPIncomeType.Controls.Add(Me.RadOther)
        Me.GPIncomeType.Controls.Add(Me.TxtCustomerID)
        Me.GPIncomeType.Controls.Add(Me.ChDonation)
        Me.GPIncomeType.Controls.Add(Me.RadFundRaising)
        Me.GPIncomeType.Controls.Add(Me.RadMedicine)
        Me.GPIncomeType.Controls.Add(Me.GroupBox5)
        Me.GPIncomeType.Controls.Add(Me.GBoxCustomerMade)
        Me.GPIncomeType.Controls.Add(Me.GBoxReadyMade)
        Me.GPIncomeType.Location = New System.Drawing.Point(6, 91)
        Me.GPIncomeType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPIncomeType.Name = "GPIncomeType"
        Me.GPIncomeType.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GPIncomeType.Size = New System.Drawing.Size(836, 233)
        Me.GPIncomeType.TabIndex = 2
        Me.GPIncomeType.TabStop = False
        Me.GPIncomeType.Text = "Select In payment for"
        '
        'lblIspaid
        '
        Me.lblIspaid.AutoSize = True
        Me.lblIspaid.Location = New System.Drawing.Point(26, 93)
        Me.lblIspaid.Name = "lblIspaid"
        Me.lblIspaid.Size = New System.Drawing.Size(16, 17)
        Me.lblIspaid.TabIndex = 212
        Me.lblIspaid.Text = "0"
        Me.lblIspaid.Visible = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.DateConsult)
        Me.GroupBox10.Controls.Add(Me.LblConsultID)
        Me.GroupBox10.Controls.Add(Me.LblSendBy)
        Me.GroupBox10.Controls.Add(Me.lblConsultFor)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Controls.Add(Me.LblConsultDate)
        Me.GroupBox10.Controls.Add(Me.Label25)
        Me.GroupBox10.Controls.Add(Me.Label26)
        Me.GroupBox10.Controls.Add(Me.LblConsultType)
        Me.GroupBox10.Controls.Add(Me.Label27)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Red
        Me.GroupBox10.Location = New System.Drawing.Point(752, 13)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(90, 136)
        Me.GroupBox10.TabIndex = 211
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Information From Consult"
        Me.GroupBox10.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(194, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Date Consult:"
        '
        'DateConsult
        '
        Me.DateConsult.CustomFormat = "dd/MM/yyyy"
        Me.DateConsult.Enabled = False
        Me.DateConsult.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateConsult.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateConsult.Location = New System.Drawing.Point(197, 47)
        Me.DateConsult.Name = "DateConsult"
        Me.DateConsult.Size = New System.Drawing.Size(123, 26)
        Me.DateConsult.TabIndex = 10
        '
        'LblConsultID
        '
        Me.LblConsultID.AutoSize = True
        Me.LblConsultID.Location = New System.Drawing.Point(179, 23)
        Me.LblConsultID.Name = "LblConsultID"
        Me.LblConsultID.Size = New System.Drawing.Size(17, 17)
        Me.LblConsultID.TabIndex = 8
        Me.LblConsultID.Text = "0"
        Me.LblConsultID.Visible = False
        '
        'LblSendBy
        '
        Me.LblSendBy.AutoSize = True
        Me.LblSendBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSendBy.ForeColor = System.Drawing.Color.Red
        Me.LblSendBy.Location = New System.Drawing.Point(100, 108)
        Me.LblSendBy.Name = "LblSendBy"
        Me.LblSendBy.Size = New System.Drawing.Size(77, 17)
        Me.LblSendBy.TabIndex = 7
        Me.LblSendBy.Text = "No Consult"
        '
        'lblConsultFor
        '
        Me.lblConsultFor.AutoSize = True
        Me.lblConsultFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultFor.ForeColor = System.Drawing.Color.Red
        Me.lblConsultFor.Location = New System.Drawing.Point(100, 80)
        Me.lblConsultFor.Name = "lblConsultFor"
        Me.lblConsultFor.Size = New System.Drawing.Size(77, 17)
        Me.lblConsultFor.TabIndex = 6
        Me.lblConsultFor.Text = "No Consult"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(6, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 17)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Consult For:"
        '
        'LblConsultDate
        '
        Me.LblConsultDate.AutoSize = True
        Me.LblConsultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultDate.ForeColor = System.Drawing.Color.Red
        Me.LblConsultDate.Location = New System.Drawing.Point(100, 26)
        Me.LblConsultDate.Name = "LblConsultDate"
        Me.LblConsultDate.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultDate.TabIndex = 4
        Me.LblConsultDate.Text = "No Consult"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(6, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 17)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Date Consult:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(6, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 17)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Consult By:"
        '
        'LblConsultType
        '
        Me.LblConsultType.AutoSize = True
        Me.LblConsultType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultType.ForeColor = System.Drawing.Color.Red
        Me.LblConsultType.Location = New System.Drawing.Point(100, 53)
        Me.LblConsultType.Name = "LblConsultType"
        Me.LblConsultType.Size = New System.Drawing.Size(77, 17)
        Me.LblConsultType.TabIndex = 1
        Me.LblConsultType.Text = "No Consult"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(6, 53)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 17)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Consult Type:"
        '
        'RadLV
        '
        Me.RadLV.AutoSize = True
        Me.RadLV.Location = New System.Drawing.Point(224, 172)
        Me.RadLV.Name = "RadLV"
        Me.RadLV.Size = New System.Drawing.Size(90, 21)
        Me.RadLV.TabIndex = 6
        Me.RadLV.TabStop = True
        Me.RadLV.Tag = "7"
        Me.RadLV.Text = "LV Device"
        Me.RadLV.UseVisualStyleBackColor = True
        '
        'RadCustomerMadeSpectacle
        '
        Me.RadCustomerMadeSpectacle.AutoSize = True
        Me.RadCustomerMadeSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadCustomerMadeSpectacle.Location = New System.Drawing.Point(16, 52)
        Me.RadCustomerMadeSpectacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadCustomerMadeSpectacle.Name = "RadCustomerMadeSpectacle"
        Me.RadCustomerMadeSpectacle.Size = New System.Drawing.Size(191, 21)
        Me.RadCustomerMadeSpectacle.TabIndex = 0
        Me.RadCustomerMadeSpectacle.TabStop = True
        Me.RadCustomerMadeSpectacle.Tag = "4"
        Me.RadCustomerMadeSpectacle.Text = "Customer Made Spectacle"
        Me.RadCustomerMadeSpectacle.UseVisualStyleBackColor = False
        '
        'RadReadyMadeSpectacle
        '
        Me.RadReadyMadeSpectacle.AutoSize = True
        Me.RadReadyMadeSpectacle.BackColor = System.Drawing.Color.Transparent
        Me.RadReadyMadeSpectacle.Location = New System.Drawing.Point(16, 156)
        Me.RadReadyMadeSpectacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadReadyMadeSpectacle.Name = "RadReadyMadeSpectacle"
        Me.RadReadyMadeSpectacle.Size = New System.Drawing.Size(172, 21)
        Me.RadReadyMadeSpectacle.TabIndex = 2
        Me.RadReadyMadeSpectacle.TabStop = True
        Me.RadReadyMadeSpectacle.Tag = "3"
        Me.RadReadyMadeSpectacle.Text = "Ready Made Spectacle"
        Me.RadReadyMadeSpectacle.UseVisualStyleBackColor = False
        '
        'RadSunGlasses
        '
        Me.RadSunGlasses.AutoSize = True
        Me.RadSunGlasses.BackColor = System.Drawing.Color.Transparent
        Me.RadSunGlasses.Location = New System.Drawing.Point(217, 68)
        Me.RadSunGlasses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadSunGlasses.Name = "RadSunGlasses"
        Me.RadSunGlasses.Size = New System.Drawing.Size(106, 21)
        Me.RadSunGlasses.TabIndex = 4
        Me.RadSunGlasses.TabStop = True
        Me.RadSunGlasses.Tag = "2"
        Me.RadSunGlasses.Text = "Sun Glasses"
        Me.RadSunGlasses.UseVisualStyleBackColor = False
        '
        'LblSaveStatus
        '
        Me.LblSaveStatus.AutoSize = True
        Me.LblSaveStatus.Location = New System.Drawing.Point(327, 16)
        Me.LblSaveStatus.Name = "LblSaveStatus"
        Me.LblSaveStatus.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveStatus.TabIndex = 19
        Me.LblSaveStatus.Text = "0"
        Me.LblSaveStatus.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(12, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Eye Glasses"
        '
        'RadOther
        '
        Me.RadOther.AutoSize = True
        Me.RadOther.BackColor = System.Drawing.Color.Transparent
        Me.RadOther.Location = New System.Drawing.Point(344, 196)
        Me.RadOther.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadOther.Name = "RadOther"
        Me.RadOther.Size = New System.Drawing.Size(62, 21)
        Me.RadOther.TabIndex = 8
        Me.RadOther.TabStop = True
        Me.RadOther.Tag = "6"
        Me.RadOther.Text = "Other"
        Me.RadOther.UseVisualStyleBackColor = False
        '
        'ChDonation
        '
        Me.ChDonation.AutoSize = True
        Me.ChDonation.Enabled = False
        Me.ChDonation.Location = New System.Drawing.Point(673, 51)
        Me.ChDonation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChDonation.Name = "ChDonation"
        Me.ChDonation.Size = New System.Drawing.Size(128, 21)
        Me.ChDonation.TabIndex = 11
        Me.ChDonation.Text = "Source of Fund:"
        Me.ChDonation.UseVisualStyleBackColor = True
        Me.ChDonation.Visible = False
        '
        'RadFundRaising
        '
        Me.RadFundRaising.AutoSize = True
        Me.RadFundRaising.BackColor = System.Drawing.Color.Transparent
        Me.RadFundRaising.Location = New System.Drawing.Point(224, 196)
        Me.RadFundRaising.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadFundRaising.Name = "RadFundRaising"
        Me.RadFundRaising.Size = New System.Drawing.Size(109, 21)
        Me.RadFundRaising.TabIndex = 7
        Me.RadFundRaising.TabStop = True
        Me.RadFundRaising.Tag = "5"
        Me.RadFundRaising.Text = "Fund Raising"
        Me.RadFundRaising.UseVisualStyleBackColor = False
        '
        'RadMedicine
        '
        Me.RadMedicine.AutoSize = True
        Me.RadMedicine.BackColor = System.Drawing.Color.Transparent
        Me.RadMedicine.Location = New System.Drawing.Point(217, 95)
        Me.RadMedicine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadMedicine.Name = "RadMedicine"
        Me.RadMedicine.Size = New System.Drawing.Size(82, 21)
        Me.RadMedicine.TabIndex = 5
        Me.RadMedicine.TabStop = True
        Me.RadMedicine.Tag = "1"
        Me.RadMedicine.Text = "Medicine"
        Me.RadMedicine.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtDonateAmount)
        Me.GroupBox5.Controls.Add(Me.CboDonation)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Location = New System.Drawing.Point(666, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(51, 74)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'TxtDonateAmount
        '
        Me.TxtDonateAmount.Enabled = False
        Me.TxtDonateAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDonateAmount.Location = New System.Drawing.Point(92, 45)
        Me.TxtDonateAmount.Name = "TxtDonateAmount"
        Me.TxtDonateAmount.Size = New System.Drawing.Size(170, 23)
        Me.TxtDonateAmount.TabIndex = 1
        Me.TxtDonateAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboDonation
        '
        Me.CboDonation.Enabled = False
        Me.CboDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDonation.FormattingEnabled = True
        Me.CboDonation.Location = New System.Drawing.Point(92, 16)
        Me.CboDonation.Name = "CboDonation"
        Me.CboDonation.Size = New System.Drawing.Size(170, 24)
        Me.CboDonation.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Donate :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Donate Name :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(261, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 15)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "$"
        '
        'GBoxCustomerMade
        '
        Me.GBoxCustomerMade.Controls.Add(Me.RadDistance1)
        Me.GBoxCustomerMade.Controls.Add(Me.RadRedding1)
        Me.GBoxCustomerMade.Controls.Add(Me.RadBifocal)
        Me.GBoxCustomerMade.Enabled = False
        Me.GBoxCustomerMade.Location = New System.Drawing.Point(11, 55)
        Me.GBoxCustomerMade.Name = "GBoxCustomerMade"
        Me.GBoxCustomerMade.Size = New System.Drawing.Size(200, 97)
        Me.GBoxCustomerMade.TabIndex = 1
        Me.GBoxCustomerMade.TabStop = False
        '
        'RadDistance1
        '
        Me.RadDistance1.AutoSize = True
        Me.RadDistance1.Location = New System.Drawing.Point(13, 35)
        Me.RadDistance1.Name = "RadDistance1"
        Me.RadDistance1.Size = New System.Drawing.Size(81, 21)
        Me.RadDistance1.TabIndex = 0
        Me.RadDistance1.TabStop = True
        Me.RadDistance1.Text = "Distance"
        Me.RadDistance1.UseVisualStyleBackColor = True
        '
        'RadRedding1
        '
        Me.RadRedding1.AutoSize = True
        Me.RadRedding1.Location = New System.Drawing.Point(101, 35)
        Me.RadRedding1.Name = "RadRedding1"
        Me.RadRedding1.Size = New System.Drawing.Size(79, 21)
        Me.RadRedding1.TabIndex = 1
        Me.RadRedding1.TabStop = True
        Me.RadRedding1.Text = "Reading"
        Me.RadRedding1.UseVisualStyleBackColor = True
        '
        'RadBifocal
        '
        Me.RadBifocal.AutoSize = True
        Me.RadBifocal.Location = New System.Drawing.Point(13, 65)
        Me.RadBifocal.Name = "RadBifocal"
        Me.RadBifocal.Size = New System.Drawing.Size(68, 21)
        Me.RadBifocal.TabIndex = 2
        Me.RadBifocal.TabStop = True
        Me.RadBifocal.Text = "Bifocal"
        Me.RadBifocal.UseVisualStyleBackColor = True
        '
        'GBoxReadyMade
        '
        Me.GBoxReadyMade.Controls.Add(Me.RadDistance2)
        Me.GBoxReadyMade.Controls.Add(Me.RadRedding2)
        Me.GBoxReadyMade.Enabled = False
        Me.GBoxReadyMade.Location = New System.Drawing.Point(11, 158)
        Me.GBoxReadyMade.Name = "GBoxReadyMade"
        Me.GBoxReadyMade.Size = New System.Drawing.Size(200, 67)
        Me.GBoxReadyMade.TabIndex = 3
        Me.GBoxReadyMade.TabStop = False
        '
        'RadDistance2
        '
        Me.RadDistance2.AutoSize = True
        Me.RadDistance2.Location = New System.Drawing.Point(13, 36)
        Me.RadDistance2.Name = "RadDistance2"
        Me.RadDistance2.Size = New System.Drawing.Size(81, 21)
        Me.RadDistance2.TabIndex = 0
        Me.RadDistance2.TabStop = True
        Me.RadDistance2.Text = "Distance"
        Me.RadDistance2.UseVisualStyleBackColor = True
        '
        'RadRedding2
        '
        Me.RadRedding2.AutoSize = True
        Me.RadRedding2.Location = New System.Drawing.Point(101, 36)
        Me.RadRedding2.Name = "RadRedding2"
        Me.RadRedding2.Size = New System.Drawing.Size(79, 21)
        Me.RadRedding2.TabIndex = 1
        Me.RadRedding2.TabStop = True
        Me.RadRedding2.Text = "Reading"
        Me.RadRedding2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtTotalAsReal)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 768)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(250, 57)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Riel"
        '
        'TxtTotalAsReal
        '
        Me.TxtTotalAsReal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAsReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtTotalAsReal.Location = New System.Drawing.Point(5, 19)
        Me.TxtTotalAsReal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAsReal.Name = "TxtTotalAsReal"
        Me.TxtTotalAsReal.Size = New System.Drawing.Size(226, 30)
        Me.TxtTotalAsReal.TabIndex = 0
        Me.TxtTotalAsReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(234, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "R"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.TxtTotalAsDolar)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(271, 770)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(270, 57)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Total Dolar"
        '
        'TxtTotalAsDolar
        '
        Me.TxtTotalAsDolar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotalAsDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TxtTotalAsDolar.Location = New System.Drawing.Point(16, 19)
        Me.TxtTotalAsDolar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTotalAsDolar.Name = "TxtTotalAsDolar"
        Me.TxtTotalAsDolar.ReadOnly = True
        Me.TxtTotalAsDolar.Size = New System.Drawing.Size(226, 30)
        Me.TxtTotalAsDolar.TabIndex = 0
        Me.TxtTotalAsDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "$"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.cmdAddRate)
        Me.GroupBox8.Controls.Add(Me.txtRate)
        Me.GroupBox8.Font = New System.Drawing.Font("Kh Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(597, 54)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(164, 52)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "អត្រាប្តូប្រាក់"
        '
        'cmdAddRate
        '
        Me.cmdAddRate.Enabled = False
        Me.cmdAddRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRate.Image = Global.TakeoHospitalInventory.My.Resources.Resources.plus_circle
        Me.cmdAddRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddRate.Location = New System.Drawing.Point(169, 29)
        Me.cmdAddRate.Name = "cmdAddRate"
        Me.cmdAddRate.Size = New System.Drawing.Size(19, 10)
        Me.cmdAddRate.TabIndex = 1
        Me.cmdAddRate.Text = "..."
        Me.cmdAddRate.UseVisualStyleBackColor = True
        Me.cmdAddRate.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.Navy
        Me.txtRate.Location = New System.Drawing.Point(7, 21)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(151, 23)
        Me.txtRate.TabIndex = 0
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSaveReceipt, Me.ToolStripSeparator1, Me.BtnCancel, Me.ToolStripSeparator2, Me.LblTotalConsult})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1424, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'BtnSaveReceipt
        '
        Me.BtnSaveReceipt.Image = Global.TakeoHospitalInventory.My.Resources.Resources.save
        Me.BtnSaveReceipt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSaveReceipt.Name = "BtnSaveReceipt"
        Me.BtnSaveReceipt.Size = New System.Drawing.Size(96, 24)
        Me.BtnSaveReceipt.Text = "Save Invoice"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.TakeoHospitalInventory.My.Resources.Resources.cancel
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(60, 24)
        Me.BtnCancel.Text = "Close"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'LblTotalConsult
        '
        Me.LblTotalConsult.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalConsult.ForeColor = System.Drawing.Color.Red
        Me.LblTotalConsult.Name = "LblTotalConsult"
        Me.LblTotalConsult.Size = New System.Drawing.Size(127, 24)
        Me.LblTotalConsult.Text = "Total Consult: 0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.ChIsPrintFull)
        Me.GroupBox4.Controls.Add(Me.GBPaymentType)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox4.Controls.Add(Me.ChPrintPreview)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxtGetBarcode)
        Me.GroupBox4.Controls.Add(Me.DateCreateReceipt)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.BtnSelectPatient)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.BtnAddCustomer)
        Me.GroupBox4.Controls.Add(Me.BtnCleanCustomer)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(852, 201)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Invoice Info"
        '
        'ChIsPrintFull
        '
        Me.ChIsPrintFull.AutoSize = True
        Me.ChIsPrintFull.Checked = True
        Me.ChIsPrintFull.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChIsPrintFull.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChIsPrintFull.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChIsPrintFull.Location = New System.Drawing.Point(399, 172)
        Me.ChIsPrintFull.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChIsPrintFull.Name = "ChIsPrintFull"
        Me.ChIsPrintFull.Size = New System.Drawing.Size(125, 21)
        Me.ChIsPrintFull.TabIndex = 13
        Me.ChIsPrintFull.Text = "Print full receipt"
        Me.ChIsPrintFull.UseVisualStyleBackColor = True
        '
        'GBPaymentType
        '
        Me.GBPaymentType.Controls.Add(Me.GroupPayCorrency)
        Me.GBPaymentType.Controls.Add(Me.TxtSocialAmount)
        Me.GBPaymentType.Controls.Add(Me.TxtNilAmount)
        Me.GBPaymentType.Controls.Add(Me.TxtFullAmount)
        Me.GBPaymentType.Controls.Add(Me.RadNil)
        Me.GBPaymentType.Controls.Add(Me.RadSocial)
        Me.GBPaymentType.Controls.Add(Me.RadFull)
        Me.GBPaymentType.Location = New System.Drawing.Point(231, 47)
        Me.GBPaymentType.Name = "GBPaymentType"
        Me.GBPaymentType.Size = New System.Drawing.Size(360, 117)
        Me.GBPaymentType.TabIndex = 4
        Me.GBPaymentType.TabStop = False
        Me.GBPaymentType.Text = "Payment Type"
        '
        'GroupPayCorrency
        '
        Me.GroupPayCorrency.Controls.Add(Me.RadKHR)
        Me.GroupPayCorrency.Controls.Add(Me.RadUSD)
        Me.GroupPayCorrency.Location = New System.Drawing.Point(265, 14)
        Me.GroupPayCorrency.Name = "GroupPayCorrency"
        Me.GroupPayCorrency.Size = New System.Drawing.Size(80, 64)
        Me.GroupPayCorrency.TabIndex = 3
        Me.GroupPayCorrency.TabStop = False
        Me.GroupPayCorrency.Text = "Currency"
        '
        'RadKHR
        '
        Me.RadKHR.AutoSize = True
        Me.RadKHR.Checked = True
        Me.RadKHR.Location = New System.Drawing.Point(6, 18)
        Me.RadKHR.Name = "RadKHR"
        Me.RadKHR.Size = New System.Drawing.Size(48, 17)
        Me.RadKHR.TabIndex = 1
        Me.RadKHR.TabStop = True
        Me.RadKHR.Text = "KHR"
        Me.RadKHR.UseVisualStyleBackColor = True
        '
        'RadUSD
        '
        Me.RadUSD.AutoSize = True
        Me.RadUSD.Location = New System.Drawing.Point(6, 41)
        Me.RadUSD.Name = "RadUSD"
        Me.RadUSD.Size = New System.Drawing.Size(48, 17)
        Me.RadUSD.TabIndex = 0
        Me.RadUSD.Text = "USD"
        Me.RadUSD.UseVisualStyleBackColor = True
        '
        'TxtSocialAmount
        '
        Me.TxtSocialAmount.BackColor = System.Drawing.Color.White
        Me.TxtSocialAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSocialAmount.Enabled = False
        Me.TxtSocialAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSocialAmount.Location = New System.Drawing.Point(69, 52)
        Me.TxtSocialAmount.Name = "TxtSocialAmount"
        Me.TxtSocialAmount.Size = New System.Drawing.Size(174, 26)
        Me.TxtSocialAmount.TabIndex = 1
        Me.TxtSocialAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNilAmount
        '
        Me.TxtNilAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNilAmount.Location = New System.Drawing.Point(143, 84)
        Me.TxtNilAmount.Name = "TxtNilAmount"
        Me.TxtNilAmount.Size = New System.Drawing.Size(36, 26)
        Me.TxtNilAmount.TabIndex = 4
        Me.TxtNilAmount.Visible = False
        '
        'TxtFullAmount
        '
        Me.TxtFullAmount.BackColor = System.Drawing.Color.White
        Me.TxtFullAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFullAmount.Enabled = False
        Me.TxtFullAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtFullAmount.Location = New System.Drawing.Point(69, 21)
        Me.TxtFullAmount.Name = "TxtFullAmount"
        Me.TxtFullAmount.Size = New System.Drawing.Size(174, 26)
        Me.TxtFullAmount.TabIndex = 0
        Me.TxtFullAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadNil
        '
        Me.RadNil.AutoSize = True
        Me.RadNil.Enabled = False
        Me.RadNil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadNil.ForeColor = System.Drawing.Color.Blue
        Me.RadNil.Location = New System.Drawing.Point(17, 88)
        Me.RadNil.Name = "RadNil"
        Me.RadNil.Size = New System.Drawing.Size(114, 24)
        Me.RadNil.TabIndex = 2
        Me.RadNil.TabStop = True
        Me.RadNil.Text = "Nil Receipt"
        Me.RadNil.UseVisualStyleBackColor = True
        '
        'RadSocial
        '
        Me.RadSocial.AutoSize = True
        Me.RadSocial.Enabled = False
        Me.RadSocial.Location = New System.Drawing.Point(17, 61)
        Me.RadSocial.Name = "RadSocial"
        Me.RadSocial.Size = New System.Drawing.Size(54, 17)
        Me.RadSocial.TabIndex = 2
        Me.RadSocial.TabStop = True
        Me.RadSocial.Text = "Social"
        Me.RadSocial.UseVisualStyleBackColor = True
        '
        'RadFull
        '
        Me.RadFull.AutoSize = True
        Me.RadFull.Checked = True
        Me.RadFull.Enabled = False
        Me.RadFull.Location = New System.Drawing.Point(17, 30)
        Me.RadFull.Name = "RadFull"
        Me.RadFull.Size = New System.Drawing.Size(41, 17)
        Me.RadFull.TabIndex = 0
        Me.RadFull.TabStop = True
        Me.RadFull.Text = "Full"
        Me.RadFull.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TxtNumGlasses)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.ChbNewGlasses)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 112)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(216, 49)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'TxtNumGlasses
        '
        Me.TxtNumGlasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNumGlasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumGlasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNumGlasses.Location = New System.Drawing.Point(81, 16)
        Me.TxtNumGlasses.Name = "TxtNumGlasses"
        Me.TxtNumGlasses.Size = New System.Drawing.Size(100, 26)
        Me.TxtNumGlasses.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Quantity :"
        '
        'ChbNewGlasses
        '
        Me.ChbNewGlasses.AutoSize = True
        Me.ChbNewGlasses.Location = New System.Drawing.Point(6, -1)
        Me.ChbNewGlasses.Name = "ChbNewGlasses"
        Me.ChbNewGlasses.Size = New System.Drawing.Size(88, 17)
        Me.ChbNewGlasses.TabIndex = 0
        Me.ChbNewGlasses.Text = "New Glasses"
        Me.ChbNewGlasses.UseVisualStyleBackColor = True
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.Color.White
        Me.TxtReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtReceiptNo.ForeColor = System.Drawing.Color.Red
        Me.TxtReceiptNo.Location = New System.Drawing.Point(94, 24)
        Me.TxtReceiptNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(129, 22)
        Me.TxtReceiptNo.TabIndex = 2
        Me.TxtReceiptNo.Text = "Label9"
        '
        'ChPrintPreview
        '
        Me.ChPrintPreview.AutoSize = True
        Me.ChPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPrintPreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChPrintPreview.Location = New System.Drawing.Point(233, 172)
        Me.ChPrintPreview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChPrintPreview.Name = "ChPrintPreview"
        Me.ChPrintPreview.Size = New System.Drawing.Size(157, 21)
        Me.ChPrintPreview.TabIndex = 3
        Me.ChPrintPreview.Text = "Invoice Print Preview"
        Me.ChPrintPreview.UseVisualStyleBackColor = True
        '
        'TxtGetBarcode
        '
        Me.TxtGetBarcode.Location = New System.Drawing.Point(767, 86)
        Me.TxtGetBarcode.Name = "TxtGetBarcode"
        Me.TxtGetBarcode.Size = New System.Drawing.Size(53, 20)
        Me.TxtGetBarcode.TabIndex = 16
        Me.TxtGetBarcode.Visible = False
        '
        'ErrReceipt
        '
        Me.ErrReceipt.ContainerControl = Me
        '
        'BgSaveAndPrinting
        '
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1292, 9)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(127, 37)
        Me.BtnClose.TabIndex = 18
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
        Me.BtnSave.Location = New System.Drawing.Point(558, 9)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(127, 37)
        Me.BtnSave.TabIndex = 17
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'TxtItemNameSearch
        '
        Me.TxtItemNameSearch.BackColor = System.Drawing.Color.White
        Me.TxtItemNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtItemNameSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemNameSearch.Location = New System.Drawing.Point(85, 16)
        Me.TxtItemNameSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtItemNameSearch.Name = "TxtItemNameSearch"
        Me.TxtItemNameSearch.Size = New System.Drawing.Size(421, 27)
        Me.TxtItemNameSearch.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 26)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Search Name:"
        '
        'UiTab1
        '
        Me.UiTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UiTab1.Location = New System.Drawing.Point(0, 0)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.Size = New System.Drawing.Size(1424, 920)
        Me.UiTab1.TabIndex = 20
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage2})
        Me.UiTab1.VisualStyleManager = Me.VisualStyleManager1
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.Panel2)
        Me.UiTabPage2.Controls.Add(Me.Panel1)
        Me.UiTabPage2.Controls.Add(Me.BtnClose)
        Me.UiTabPage2.Controls.Add(Me.BtnSearch)
        Me.UiTabPage2.Controls.Add(Me.Label19)
        Me.UiTabPage2.Controls.Add(Me.TxtItemNameSearch)
        Me.UiTabPage2.Controls.Add(Me.BtnSave)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 28)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(1422, 891)
        Me.UiTabPage2.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UiTabPage2.StateStyles.FormatStyle.FontSize = 12.0!
        Me.UiTabPage2.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White
        Me.UiTabPage2.TabStop = True
        Me.UiTabPage2.Text = "Optical Shop in Screening"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GridListOfItem)
        Me.Panel2.Controls.Add(Me.BtnRemoveV1)
        Me.Panel2.Controls.Add(Me.GridItemDetail)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(3, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 832)
        Me.Panel2.TabIndex = 24
        '
        'GridListOfItem
        '
        Me.GridListOfItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridListOfItem.BackColor = System.Drawing.Color.White
        Me.GridListOfItem.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridListOfItem_DesignTimeLayout.LayoutString = resources.GetString("GridListOfItem_DesignTimeLayout.LayoutString")
        Me.GridListOfItem.DesignTimeLayout = GridListOfItem_DesignTimeLayout
        Me.GridListOfItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridListOfItem.GridLines = Janus.Windows.GridEX.GridLines.Horizontal
        Me.GridListOfItem.GroupByBoxVisible = False
        Me.GridListOfItem.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridListOfItem.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GridListOfItem.HeaderFormatStyle.FontSize = 12.0!
        Me.GridListOfItem.HeaderFormatStyle.ForeColor = System.Drawing.Color.White
        Me.GridListOfItem.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridListOfItem.Location = New System.Drawing.Point(5, 5)
        Me.GridListOfItem.Name = "GridListOfItem"
        Me.GridListOfItem.Size = New System.Drawing.Size(533, 320)
        Me.GridListOfItem.TabIndex = 21
        Me.GridListOfItem.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridListOfItem.VisualStyleManager = Me.VisualStyleManager1
        '
        'BtnRemoveV1
        '
        Me.BtnRemoveV1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemoveV1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnRemoveV1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRemoveV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveV1.Image = CType(resources.GetObject("BtnRemoveV1.Image"), System.Drawing.Image)
        Me.BtnRemoveV1.Location = New System.Drawing.Point(244, 329)
        Me.BtnRemoveV1.Name = "BtnRemoveV1"
        Me.BtnRemoveV1.Size = New System.Drawing.Size(43, 37)
        Me.BtnRemoveV1.TabIndex = 22
        Me.BtnRemoveV1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Location = New System.Drawing.Point(555, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 832)
        Me.Panel1.TabIndex = 23
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(506, 16)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(44, 27)
        Me.BtnSearch.TabIndex = 20
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'FrmNewReceipt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1424, 920)
        Me.Controls.Add(Me.UiTab1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmNewReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Optical Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridItemDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GPIncomeType.ResumeLayout(False)
        Me.GPIncomeType.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBoxCustomerMade.ResumeLayout(False)
        Me.GBoxCustomerMade.PerformLayout()
        Me.GBoxReadyMade.ResumeLayout(False)
        Me.GBoxReadyMade.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GBPaymentType.ResumeLayout(False)
        Me.GBPaymentType.PerformLayout()
        Me.GroupPayCorrency.ResumeLayout(False)
        Me.GroupPayCorrency.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        Me.UiTabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridListOfItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateCreateReceipt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCleanCustomer As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAddCustomer As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TxtAge As System.Windows.Forms.TextBox
    Friend WithEvents TxtSex As System.Windows.Forms.TextBox
    Friend WithEvents TxtCusOccupation As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridItemDetail As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChDonation As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTotalAsDolar As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAsReal As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents BtnRemoveItem As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnSaveReceipt As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ErrReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents ChPrintPreview As System.Windows.Forms.CheckBox
    Friend WithEvents GPIncomeType As System.Windows.Forms.GroupBox
    Friend WithEvents RadOther As System.Windows.Forms.RadioButton
    Friend WithEvents RadReadyMadeSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadFundRaising As System.Windows.Forms.RadioButton
    Friend WithEvents RadSunGlasses As System.Windows.Forms.RadioButton
    Friend WithEvents RadCustomerMadeSpectacle As System.Windows.Forms.RadioButton
    Friend WithEvents RadMedicine As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.Label
    Friend WithEvents TxtGetBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSelectPatient As Janus.Windows.EditControls.UIButton
    Friend WithEvents BgSaveAndPrinting As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtCusNameEng As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNumGlasses As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChbNewGlasses As System.Windows.Forms.CheckBox
    Friend WithEvents GBPaymentType As System.Windows.Forms.GroupBox
    Friend WithEvents RadSocial As System.Windows.Forms.RadioButton
    Friend WithEvents RadNil As System.Windows.Forms.RadioButton
    Friend WithEvents RadFull As System.Windows.Forms.RadioButton
    Friend WithEvents GroupPayCorrency As System.Windows.Forms.GroupBox
    Friend WithEvents RadKHR As System.Windows.Forms.RadioButton
    Friend WithEvents RadUSD As System.Windows.Forms.RadioButton
    Friend WithEvents TxtSocialAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtFullAmount As System.Windows.Forms.TextBox
    Friend WithEvents CheOldPatient As System.Windows.Forms.CheckBox
    Friend WithEvents LblSaveStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddRate As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents LblCombindReferal As System.Windows.Forms.Label
    Friend WithEvents RadLV As System.Windows.Forms.RadioButton
    Friend WithEvents GBoxReadyMade As System.Windows.Forms.GroupBox
    Friend WithEvents RadDistance2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadRedding2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadBifocal As System.Windows.Forms.RadioButton
    Friend WithEvents GBoxCustomerMade As System.Windows.Forms.GroupBox
    Friend WithEvents RadDistance1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadRedding1 As System.Windows.Forms.RadioButton
    Friend WithEvents CboDonation As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDonateAmount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents LblConsultID As System.Windows.Forms.Label
    Friend WithEvents LblSendBy As System.Windows.Forms.Label
    Friend WithEvents lblConsultFor As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblConsultDate As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LblConsultType As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblTotalConsult As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblReceiptID As System.Windows.Forms.Label
    Friend WithEvents DateConsult As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChIsPrintFull As System.Windows.Forms.CheckBox
    Friend WithEvents lblIspaid As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtItemNameSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents GridListOfItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents ColumnItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnBarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColumnQTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Picture As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXCHANGE_RATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnRemoveV1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtAmountInWord As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnSerchPatient As System.Windows.Forms.Button
    Friend WithEvents TxtSearchPNo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
