<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIScreening
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIScreening))
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuVertical = New System.Windows.Forms.Panel
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.BtnNewPatientBook = New System.Windows.Forms.Button
        Me.BtnPatientRegistration = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnRequestItem = New System.Windows.Forms.Button
        Me.BtnItemTransaction = New System.Windows.Forms.Button
        Me.BtnOpticalIncome = New System.Windows.Forms.Button
        Me.BtnOpticalShopReport = New System.Windows.Forms.Button
        Me.UiComboBox1 = New Janus.Windows.EditControls.UIComboBox
        Me.DGScreeningBook = New System.Windows.Forms.DataGridView
        Me.IMPORT_STATUS = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SCREEN_BOOKID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SYS_SETTING = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCREAN_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.REFERENCE_PATIENNOTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameEng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCREEN_PLACE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ON_EYE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIAGNOSISScreening = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_RIGHTScreening = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VA_LEFTScreening = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRESENTING_COMPLAIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IS_REFRACTION = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_OPTICALSHOP = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_REFER_PICKUP = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_REFER_BYSELF = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SCREEN_NOTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Province = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.District = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Commune = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Male = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Female = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button13 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.BtnNavigationBar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnOpticalShop = New System.Windows.Forms.Button
        Me.BtnScreeningBook = New System.Windows.Forms.Button
        Me.BtnScreeningSetting = New System.Windows.Forms.Button
        Me.BtnReports = New System.Windows.Forms.Button
        Me.BtnInventory = New System.Windows.Forms.Button
        Me.MenuVertical.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGScreeningBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Screening Dashboard"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(809, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Patient Screening List:"
        Me.Label2.Visible = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Button21)
        Me.MenuVertical.Controls.Add(Me.Button17)
        Me.MenuVertical.Controls.Add(Me.Button20)
        Me.MenuVertical.Controls.Add(Me.Button16)
        Me.MenuVertical.Controls.Add(Me.Button19)
        Me.MenuVertical.Controls.Add(Me.Button15)
        Me.MenuVertical.Controls.Add(Me.Button18)
        Me.MenuVertical.Controls.Add(Me.BtnNewPatientBook)
        Me.MenuVertical.Controls.Add(Me.BtnPatientRegistration)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(242, 922)
        Me.MenuVertical.TabIndex = 14
        Me.MenuVertical.Visible = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button21.Image = CType(resources.GetObject("Button21.Image"), System.Drawing.Image)
        Me.Button21.Location = New System.Drawing.Point(6, 434)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(229, 66)
        Me.Button21.TabIndex = 4
        Me.Button21.Text = "In-Patient"
        Me.Button21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button17.Image = CType(resources.GetObject("Button17.Image"), System.Drawing.Image)
        Me.Button17.Location = New System.Drawing.Point(6, 360)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(229, 66)
        Me.Button17.TabIndex = 4
        Me.Button17.Text = "Patient Referal"
        Me.Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button20.Image = CType(resources.GetObject("Button20.Image"), System.Drawing.Image)
        Me.Button20.Location = New System.Drawing.Point(6, 506)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(229, 66)
        Me.Button20.TabIndex = 3
        Me.Button20.Text = "Old Patient Book"
        Me.Button20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.Location = New System.Drawing.Point(6, 285)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(229, 66)
        Me.Button16.TabIndex = 4
        Me.Button16.Text = "In-Patient"
        Me.Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button19.Image = CType(resources.GetObject("Button19.Image"), System.Drawing.Image)
        Me.Button19.Location = New System.Drawing.Point(6, 578)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(229, 66)
        Me.Button19.TabIndex = 2
        Me.Button19.Text = "New Patient Book"
        Me.Button19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.Location = New System.Drawing.Point(6, 213)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(229, 66)
        Me.Button15.TabIndex = 3
        Me.Button15.Text = "Old Patient Book"
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button18.Image = CType(resources.GetObject("Button18.Image"), System.Drawing.Image)
        Me.Button18.Location = New System.Drawing.Point(6, 652)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(229, 66)
        Me.Button18.TabIndex = 1
        Me.Button18.Text = "Patient Application Form"
        Me.Button18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button18.UseVisualStyleBackColor = False
        '
        'BtnNewPatientBook
        '
        Me.BtnNewPatientBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BtnNewPatientBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewPatientBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnNewPatientBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewPatientBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewPatientBook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNewPatientBook.Image = CType(resources.GetObject("BtnNewPatientBook.Image"), System.Drawing.Image)
        Me.BtnNewPatientBook.Location = New System.Drawing.Point(6, 139)
        Me.BtnNewPatientBook.Name = "BtnNewPatientBook"
        Me.BtnNewPatientBook.Size = New System.Drawing.Size(229, 66)
        Me.BtnNewPatientBook.TabIndex = 2
        Me.BtnNewPatientBook.Text = "New Patient Book"
        Me.BtnNewPatientBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNewPatientBook.UseVisualStyleBackColor = False
        '
        'BtnPatientRegistration
        '
        Me.BtnPatientRegistration.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.BtnPatientRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPatientRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnPatientRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPatientRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPatientRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPatientRegistration.Image = CType(resources.GetObject("BtnPatientRegistration.Image"), System.Drawing.Image)
        Me.BtnPatientRegistration.Location = New System.Drawing.Point(6, 67)
        Me.BtnPatientRegistration.Name = "BtnPatientRegistration"
        Me.BtnPatientRegistration.Size = New System.Drawing.Size(229, 66)
        Me.BtnPatientRegistration.TabIndex = 1
        Me.BtnPatientRegistration.Text = "Patient Application Form"
        Me.BtnPatientRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPatientRegistration.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BtnRequestItem)
        Me.Panel2.Controls.Add(Me.BtnItemTransaction)
        Me.Panel2.Controls.Add(Me.BtnOpticalIncome)
        Me.Panel2.Controls.Add(Me.BtnOpticalShopReport)
        Me.Panel2.Controls.Add(Me.UiComboBox1)
        Me.Panel2.Controls.Add(Me.DGScreeningBook)
        Me.Panel2.Controls.Add(Me.Button13)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtnNavigationBar)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnOpticalShop)
        Me.Panel2.Controls.Add(Me.BtnScreeningBook)
        Me.Panel2.Controls.Add(Me.BtnScreeningSetting)
        Me.Panel2.Controls.Add(Me.BtnReports)
        Me.Panel2.Controls.Add(Me.BtnInventory)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(242, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1283, 922)
        Me.Panel2.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(398, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 470)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Label3"
        '
        'BtnRequestItem
        '
        Me.BtnRequestItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnRequestItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRequestItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRequestItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnRequestItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRequestItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRequestItem.ForeColor = System.Drawing.Color.White
        Me.BtnRequestItem.Image = CType(resources.GetObject("BtnRequestItem.Image"), System.Drawing.Image)
        Me.BtnRequestItem.Location = New System.Drawing.Point(405, 194)
        Me.BtnRequestItem.Name = "BtnRequestItem"
        Me.BtnRequestItem.Size = New System.Drawing.Size(147, 377)
        Me.BtnRequestItem.TabIndex = 29
        Me.BtnRequestItem.Text = "Request Product"
        Me.BtnRequestItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRequestItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnRequestItem.UseVisualStyleBackColor = False
        '
        'BtnItemTransaction
        '
        Me.BtnItemTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnItemTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnItemTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnItemTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnItemTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnItemTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItemTransaction.ForeColor = System.Drawing.Color.White
        Me.BtnItemTransaction.Image = CType(resources.GetObject("BtnItemTransaction.Image"), System.Drawing.Image)
        Me.BtnItemTransaction.Location = New System.Drawing.Point(558, 384)
        Me.BtnItemTransaction.Name = "BtnItemTransaction"
        Me.BtnItemTransaction.Size = New System.Drawing.Size(229, 93)
        Me.BtnItemTransaction.TabIndex = 28
        Me.BtnItemTransaction.Text = "Item Transaction"
        Me.BtnItemTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnItemTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnItemTransaction.UseVisualStyleBackColor = False
        '
        'BtnOpticalIncome
        '
        Me.BtnOpticalIncome.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnOpticalIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOpticalIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOpticalIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnOpticalIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpticalIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpticalIncome.ForeColor = System.Drawing.Color.White
        Me.BtnOpticalIncome.Image = CType(resources.GetObject("BtnOpticalIncome.Image"), System.Drawing.Image)
        Me.BtnOpticalIncome.Location = New System.Drawing.Point(558, 289)
        Me.BtnOpticalIncome.Name = "BtnOpticalIncome"
        Me.BtnOpticalIncome.Size = New System.Drawing.Size(229, 93)
        Me.BtnOpticalIncome.TabIndex = 28
        Me.BtnOpticalIncome.Text = "Optical Income"
        Me.BtnOpticalIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOpticalIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOpticalIncome.UseVisualStyleBackColor = False
        '
        'BtnOpticalShopReport
        '
        Me.BtnOpticalShopReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnOpticalShopReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOpticalShopReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOpticalShopReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnOpticalShopReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpticalShopReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpticalShopReport.ForeColor = System.Drawing.Color.White
        Me.BtnOpticalShopReport.Image = CType(resources.GetObject("BtnOpticalShopReport.Image"), System.Drawing.Image)
        Me.BtnOpticalShopReport.Location = New System.Drawing.Point(558, 478)
        Me.BtnOpticalShopReport.Name = "BtnOpticalShopReport"
        Me.BtnOpticalShopReport.Size = New System.Drawing.Size(229, 93)
        Me.BtnOpticalShopReport.TabIndex = 28
        Me.BtnOpticalShopReport.Text = "Statistic Reports"
        Me.BtnOpticalShopReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOpticalShopReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOpticalShopReport.UseVisualStyleBackColor = False
        '
        'UiComboBox1
        '
        Me.UiComboBox1.BorderStyle = Janus.Windows.UI.BorderStyle.Flat
        Me.UiComboBox1.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.UiComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.IsSeparator = False
        UiComboBoxItem1.Text = "Referent No"
        UiComboBoxItem1.Value = "Referent No"
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.IsSeparator = False
        UiComboBoxItem2.Text = "Patient No"
        UiComboBoxItem2.Value = "Patient No"
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.IsSeparator = False
        UiComboBoxItem3.Text = "Patient Name"
        UiComboBoxItem3.Value = "Patient Name"
        Me.UiComboBox1.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2, UiComboBoxItem3})
        Me.UiComboBox1.Location = New System.Drawing.Point(813, 321)
        Me.UiComboBox1.Name = "UiComboBox1"
        Me.UiComboBox1.Size = New System.Drawing.Size(163, 30)
        Me.UiComboBox1.TabIndex = 27
        Me.UiComboBox1.Text = "Search By:"
        Me.UiComboBox1.Visible = False
        '
        'DGScreeningBook
        '
        Me.DGScreeningBook.AllowUserToAddRows = False
        Me.DGScreeningBook.AllowUserToDeleteRows = False
        Me.DGScreeningBook.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGScreeningBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGScreeningBook.BackgroundColor = System.Drawing.Color.White
        Me.DGScreeningBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGScreeningBook.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DGScreeningBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGScreeningBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGScreeningBook.ColumnHeadersHeight = 40
        Me.DGScreeningBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMPORT_STATUS, Me.SCREEN_BOOKID, Me.SYS_SETTING, Me.SCREAN_DATE, Me.PatientNo, Me.REFERENCE_PATIENNOTE, Me.NameEng, Me.NameKhmer, Me.Age, Me.Sex, Me.Address, Me.SCREEN_PLACE, Me.ON_EYE, Me.DIAGNOSISScreening, Me.VA_RIGHTScreening, Me.VA_LEFTScreening, Me.PRESENTING_COMPLAIN, Me.IS_REFRACTION, Me.IS_OPTICALSHOP, Me.IS_REFER_PICKUP, Me.IS_REFER_BYSELF, Me.SCREEN_NOTE, Me.Province, Me.District, Me.Commune, Me.Male, Me.Female, Me.Occupation, Me.Telephone})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGScreeningBook.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGScreeningBook.EnableHeadersVisualStyles = False
        Me.DGScreeningBook.GridColor = System.Drawing.Color.SteelBlue
        Me.DGScreeningBook.Location = New System.Drawing.Point(813, 405)
        Me.DGScreeningBook.Margin = New System.Windows.Forms.Padding(5)
        Me.DGScreeningBook.Name = "DGScreeningBook"
        Me.DGScreeningBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGScreeningBook.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGScreeningBook.RowHeadersWidth = 50
        Me.DGScreeningBook.RowTemplate.Height = 35
        Me.DGScreeningBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGScreeningBook.Size = New System.Drawing.Size(465, 512)
        Me.DGScreeningBook.TabIndex = 26
        Me.DGScreeningBook.Visible = False
        '
        'IMPORT_STATUS
        '
        Me.IMPORT_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IMPORT_STATUS.DataPropertyName = "IMPORT_STATUS"
        Me.IMPORT_STATUS.FillWeight = 49.81596!
        Me.IMPORT_STATUS.HeaderText = "Import Status"
        Me.IMPORT_STATUS.Name = "IMPORT_STATUS"
        Me.IMPORT_STATUS.ReadOnly = True
        Me.IMPORT_STATUS.Width = 150
        '
        'SCREEN_BOOKID
        '
        Me.SCREEN_BOOKID.DataPropertyName = "SCREEN_BOOKID"
        Me.SCREEN_BOOKID.HeaderText = "SCREEN_BOOKID"
        Me.SCREEN_BOOKID.Name = "SCREEN_BOOKID"
        Me.SCREEN_BOOKID.ReadOnly = True
        Me.SCREEN_BOOKID.Visible = False
        '
        'SYS_SETTING
        '
        Me.SYS_SETTING.DataPropertyName = "SYS_SETTING"
        Me.SYS_SETTING.HeaderText = "SYS_SETTING"
        Me.SYS_SETTING.Name = "SYS_SETTING"
        Me.SYS_SETTING.ReadOnly = True
        Me.SYS_SETTING.Visible = False
        '
        'SCREAN_DATE
        '
        Me.SCREAN_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SCREAN_DATE.DataPropertyName = "SCREAN_DATE"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.SCREAN_DATE.DefaultCellStyle = DataGridViewCellStyle2
        Me.SCREAN_DATE.FillWeight = 1035.533!
        Me.SCREAN_DATE.HeaderText = "Regist-Date"
        Me.SCREAN_DATE.Name = "SCREAN_DATE"
        Me.SCREAN_DATE.ReadOnly = True
        Me.SCREAN_DATE.Width = 150
        '
        'PatientNo
        '
        Me.PatientNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PatientNo.DataPropertyName = "PatientNo"
        Me.PatientNo.FillWeight = 69.60071!
        Me.PatientNo.HeaderText = "Patient No"
        Me.PatientNo.Name = "PatientNo"
        Me.PatientNo.ReadOnly = True
        Me.PatientNo.Width = 150
        '
        'REFERENCE_PATIENNOTE
        '
        Me.REFERENCE_PATIENNOTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.REFERENCE_PATIENNOTE.DataPropertyName = "REFERENCE_PATIENNOTE"
        Me.REFERENCE_PATIENNOTE.FillWeight = 49.81596!
        Me.REFERENCE_PATIENNOTE.HeaderText = "Ref-No"
        Me.REFERENCE_PATIENNOTE.Name = "REFERENCE_PATIENNOTE"
        Me.REFERENCE_PATIENNOTE.ReadOnly = True
        Me.REFERENCE_PATIENNOTE.Width = 150
        '
        'NameEng
        '
        Me.NameEng.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NameEng.DataPropertyName = "NameEng"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameEng.DefaultCellStyle = DataGridViewCellStyle3
        Me.NameEng.FillWeight = 50.72639!
        Me.NameEng.HeaderText = "Name Eng"
        Me.NameEng.Name = "NameEng"
        Me.NameEng.ReadOnly = True
        Me.NameEng.Width = 150
        '
        'NameKhmer
        '
        Me.NameKhmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NameKhmer.DataPropertyName = "NameKhmer"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameKhmer.DefaultCellStyle = DataGridViewCellStyle4
        Me.NameKhmer.FillWeight = 50.72639!
        Me.NameKhmer.HeaderText = "Name Kh"
        Me.NameKhmer.Name = "NameKhmer"
        Me.NameKhmer.ReadOnly = True
        Me.NameKhmer.Width = 150
        '
        'Age
        '
        Me.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Age.DataPropertyName = "Age"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Age.DefaultCellStyle = DataGridViewCellStyle5
        Me.Age.FillWeight = 50.16895!
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        Me.Age.Width = 50
        '
        'Sex
        '
        Me.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Sex.DataPropertyName = "Sex"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Sex.DefaultCellStyle = DataGridViewCellStyle6
        Me.Sex.FillWeight = 39.44817!
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        Me.Sex.ReadOnly = True
        Me.Sex.Width = 50
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Address.DataPropertyName = "Address"
        Me.Address.FillWeight = 50.72639!
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 150
        '
        'SCREEN_PLACE
        '
        Me.SCREEN_PLACE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SCREEN_PLACE.DataPropertyName = "SCREEN_PLACE"
        Me.SCREEN_PLACE.FillWeight = 50.72639!
        Me.SCREEN_PLACE.HeaderText = "Screen Place"
        Me.SCREEN_PLACE.Name = "SCREEN_PLACE"
        Me.SCREEN_PLACE.ReadOnly = True
        Me.SCREEN_PLACE.Width = 150
        '
        'ON_EYE
        '
        Me.ON_EYE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ON_EYE.DataPropertyName = "ON_EYE"
        Me.ON_EYE.FillWeight = 49.81596!
        Me.ON_EYE.HeaderText = "On Eye"
        Me.ON_EYE.Name = "ON_EYE"
        Me.ON_EYE.ReadOnly = True
        Me.ON_EYE.Width = 90
        '
        'DIAGNOSISScreening
        '
        Me.DIAGNOSISScreening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DIAGNOSISScreening.DataPropertyName = "DIAGNOSIS"
        Me.DIAGNOSISScreening.FillWeight = 49.81596!
        Me.DIAGNOSISScreening.HeaderText = "Diagnosis"
        Me.DIAGNOSISScreening.Name = "DIAGNOSISScreening"
        Me.DIAGNOSISScreening.ReadOnly = True
        Me.DIAGNOSISScreening.Width = 150
        '
        'VA_RIGHTScreening
        '
        Me.VA_RIGHTScreening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.VA_RIGHTScreening.DataPropertyName = "VA_RIGHT"
        Me.VA_RIGHTScreening.FillWeight = 49.81596!
        Me.VA_RIGHTScreening.HeaderText = "VA Right"
        Me.VA_RIGHTScreening.Name = "VA_RIGHTScreening"
        Me.VA_RIGHTScreening.ReadOnly = True
        Me.VA_RIGHTScreening.Width = 50
        '
        'VA_LEFTScreening
        '
        Me.VA_LEFTScreening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.VA_LEFTScreening.DataPropertyName = "VA_LEFT"
        Me.VA_LEFTScreening.FillWeight = 49.81596!
        Me.VA_LEFTScreening.HeaderText = "VA Left"
        Me.VA_LEFTScreening.Name = "VA_LEFTScreening"
        Me.VA_LEFTScreening.ReadOnly = True
        Me.VA_LEFTScreening.Width = 50
        '
        'PRESENTING_COMPLAIN
        '
        Me.PRESENTING_COMPLAIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PRESENTING_COMPLAIN.DataPropertyName = "PRESENTING_COMPLAIN"
        Me.PRESENTING_COMPLAIN.FillWeight = 49.81596!
        Me.PRESENTING_COMPLAIN.HeaderText = "Presenting Complain"
        Me.PRESENTING_COMPLAIN.Name = "PRESENTING_COMPLAIN"
        Me.PRESENTING_COMPLAIN.ReadOnly = True
        Me.PRESENTING_COMPLAIN.Width = 150
        '
        'IS_REFRACTION
        '
        Me.IS_REFRACTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IS_REFRACTION.DataPropertyName = "IS_REFRACTION"
        Me.IS_REFRACTION.FillWeight = 50.72639!
        Me.IS_REFRACTION.HeaderText = "Refraction"
        Me.IS_REFRACTION.Name = "IS_REFRACTION"
        Me.IS_REFRACTION.ReadOnly = True
        Me.IS_REFRACTION.Width = 150
        '
        'IS_OPTICALSHOP
        '
        Me.IS_OPTICALSHOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IS_OPTICALSHOP.DataPropertyName = "IS_OPTICALSHOP"
        Me.IS_OPTICALSHOP.FillWeight = 50.72639!
        Me.IS_OPTICALSHOP.HeaderText = "Optical shop"
        Me.IS_OPTICALSHOP.Name = "IS_OPTICALSHOP"
        Me.IS_OPTICALSHOP.ReadOnly = True
        Me.IS_OPTICALSHOP.Width = 150
        '
        'IS_REFER_PICKUP
        '
        Me.IS_REFER_PICKUP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IS_REFER_PICKUP.DataPropertyName = "IS_REFER_PICKUP"
        Me.IS_REFER_PICKUP.FillWeight = 50.72639!
        Me.IS_REFER_PICKUP.HeaderText = "Referral By Pickup"
        Me.IS_REFER_PICKUP.Name = "IS_REFER_PICKUP"
        Me.IS_REFER_PICKUP.ReadOnly = True
        Me.IS_REFER_PICKUP.Width = 150
        '
        'IS_REFER_BYSELF
        '
        Me.IS_REFER_BYSELF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IS_REFER_BYSELF.DataPropertyName = "IS_REFER_BYSELF"
        Me.IS_REFER_BYSELF.FillWeight = 50.72639!
        Me.IS_REFER_BYSELF.HeaderText = "Referral By Selft"
        Me.IS_REFER_BYSELF.Name = "IS_REFER_BYSELF"
        Me.IS_REFER_BYSELF.ReadOnly = True
        Me.IS_REFER_BYSELF.Width = 150
        '
        'SCREEN_NOTE
        '
        Me.SCREEN_NOTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SCREEN_NOTE.DataPropertyName = "SCREEN_NOTE"
        Me.SCREEN_NOTE.FillWeight = 50.72639!
        Me.SCREEN_NOTE.HeaderText = "Note"
        Me.SCREEN_NOTE.Name = "SCREEN_NOTE"
        Me.SCREEN_NOTE.ReadOnly = True
        Me.SCREEN_NOTE.Width = 150
        '
        'Province
        '
        Me.Province.DataPropertyName = "Province"
        Me.Province.HeaderText = "Province"
        Me.Province.Name = "Province"
        Me.Province.Visible = False
        '
        'District
        '
        Me.District.DataPropertyName = "District"
        Me.District.HeaderText = "District"
        Me.District.Name = "District"
        Me.District.Visible = False
        '
        'Commune
        '
        Me.Commune.DataPropertyName = "Commune"
        Me.Commune.HeaderText = "Commune"
        Me.Commune.Name = "Commune"
        Me.Commune.Visible = False
        '
        'Male
        '
        Me.Male.DataPropertyName = "Male"
        Me.Male.HeaderText = "Male"
        Me.Male.Name = "Male"
        Me.Male.Visible = False
        '
        'Female
        '
        Me.Female.DataPropertyName = "Female"
        Me.Female.HeaderText = "Female"
        Me.Female.Name = "Female"
        Me.Female.Visible = False
        '
        'Occupation
        '
        Me.Occupation.DataPropertyName = "Occupation"
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.Name = "Occupation"
        Me.Occupation.Visible = False
        '
        'Telephone
        '
        Me.Telephone.DataPropertyName = "Telephone"
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Visible = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.Location = New System.Drawing.Point(1231, 321)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(36, 30)
        Me.Button13.TabIndex = 19
        Me.Button13.UseVisualStyleBackColor = False
        Me.Button13.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(977, 321)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 30)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Visible = False
        '
        'BtnNavigationBar
        '
        Me.BtnNavigationBar.BackColor = System.Drawing.Color.White
        Me.BtnNavigationBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNavigationBar.FlatAppearance.BorderSize = 0
        Me.BtnNavigationBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnNavigationBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNavigationBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNavigationBar.ForeColor = System.Drawing.Color.White
        Me.BtnNavigationBar.Image = Global.TakeoHospitalInventory.My.Resources.Resources.Switch_On_40px1
        Me.BtnNavigationBar.Location = New System.Drawing.Point(8, 3)
        Me.BtnNavigationBar.Name = "BtnNavigationBar"
        Me.BtnNavigationBar.Size = New System.Drawing.Size(49, 31)
        Me.BtnNavigationBar.TabIndex = 17
        Me.BtnNavigationBar.UseVisualStyleBackColor = False
        Me.BtnNavigationBar.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(8, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 282)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Patient Registration"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnOpticalShop
        '
        Me.BtnOpticalShop.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnOpticalShop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOpticalShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOpticalShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnOpticalShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpticalShop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpticalShop.ForeColor = System.Drawing.Color.White
        Me.BtnOpticalShop.Image = CType(resources.GetObject("BtnOpticalShop.Image"), System.Drawing.Image)
        Me.BtnOpticalShop.Location = New System.Drawing.Point(405, 100)
        Me.BtnOpticalShop.Name = "BtnOpticalShop"
        Me.BtnOpticalShop.Size = New System.Drawing.Size(382, 93)
        Me.BtnOpticalShop.TabIndex = 2
        Me.BtnOpticalShop.Text = "Sale In Optical Shop"
        Me.BtnOpticalShop.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOpticalShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOpticalShop.UseVisualStyleBackColor = False
        '
        'BtnScreeningBook
        '
        Me.BtnScreeningBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnScreeningBook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnScreeningBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnScreeningBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnScreeningBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScreeningBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnScreeningBook.ForeColor = System.Drawing.Color.White
        Me.BtnScreeningBook.Image = CType(resources.GetObject("BtnScreeningBook.Image"), System.Drawing.Image)
        Me.BtnScreeningBook.Location = New System.Drawing.Point(126, 100)
        Me.BtnScreeningBook.Name = "BtnScreeningBook"
        Me.BtnScreeningBook.Size = New System.Drawing.Size(252, 93)
        Me.BtnScreeningBook.TabIndex = 3
        Me.BtnScreeningBook.Text = "Screening Book"
        Me.BtnScreeningBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnScreeningBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnScreeningBook.UseVisualStyleBackColor = False
        '
        'BtnScreeningSetting
        '
        Me.BtnScreeningSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnScreeningSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnScreeningSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnScreeningSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnScreeningSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScreeningSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnScreeningSetting.ForeColor = System.Drawing.Color.White
        Me.BtnScreeningSetting.Image = CType(resources.GetObject("BtnScreeningSetting.Image"), System.Drawing.Image)
        Me.BtnScreeningSetting.Location = New System.Drawing.Point(126, 289)
        Me.BtnScreeningSetting.Name = "BtnScreeningSetting"
        Me.BtnScreeningSetting.Size = New System.Drawing.Size(252, 93)
        Me.BtnScreeningSetting.TabIndex = 4
        Me.BtnScreeningSetting.Text = "Screening Setting"
        Me.BtnScreeningSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnScreeningSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnScreeningSetting.UseVisualStyleBackColor = False
        '
        'BtnReports
        '
        Me.BtnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.ForeColor = System.Drawing.Color.White
        Me.BtnReports.Image = CType(resources.GetObject("BtnReports.Image"), System.Drawing.Image)
        Me.BtnReports.Location = New System.Drawing.Point(126, 194)
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(252, 93)
        Me.BtnReports.TabIndex = 5
        Me.BtnReports.Text = "Screening Reports"
        Me.BtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReports.UseVisualStyleBackColor = False
        '
        'BtnInventory
        '
        Me.BtnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventory.ForeColor = System.Drawing.Color.White
        Me.BtnInventory.Image = CType(resources.GetObject("BtnInventory.Image"), System.Drawing.Image)
        Me.BtnInventory.Location = New System.Drawing.Point(558, 194)
        Me.BtnInventory.Name = "BtnInventory"
        Me.BtnInventory.Size = New System.Drawing.Size(229, 93)
        Me.BtnInventory.TabIndex = 6
        Me.BtnInventory.Text = "Screening Inventory"
        Me.BtnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnInventory.UseVisualStyleBackColor = False
        '
        'UIScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuVertical)
        Me.Name = "UIScreening"
        Me.Size = New System.Drawing.Size(1525, 922)
        Me.MenuVertical.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGScreeningBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnOpticalShop As System.Windows.Forms.Button
    Friend WithEvents BtnScreeningSetting As System.Windows.Forms.Button
    Friend WithEvents BtnScreeningBook As System.Windows.Forms.Button
    Friend WithEvents BtnInventory As System.Windows.Forms.Button
    Friend WithEvents BtnReports As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuVertical As System.Windows.Forms.Panel
    Friend WithEvents BtnPatientRegistration As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents BtnNewPatientBook As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents BtnNavigationBar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents DGScreeningBook As System.Windows.Forms.DataGridView
    Friend WithEvents IMPORT_STATUS As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SCREEN_BOOKID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SYS_SETTING As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCREAN_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REFERENCE_PATIENNOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameEng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCREEN_PLACE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ON_EYE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAGNOSISScreening As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_RIGHTScreening As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VA_LEFTScreening As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRESENTING_COMPLAIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IS_REFRACTION As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_OPTICALSHOP As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_REFER_PICKUP As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_REFER_BYSELF As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SCREEN_NOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Province As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents District As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Commune As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Male As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Female As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Occupation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UiComboBox1 As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents BtnOpticalShopReport As System.Windows.Forms.Button
    Friend WithEvents BtnRequestItem As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnOpticalIncome As System.Windows.Forms.Button
    Friend WithEvents BtnItemTransaction As System.Windows.Forms.Button

End Class
