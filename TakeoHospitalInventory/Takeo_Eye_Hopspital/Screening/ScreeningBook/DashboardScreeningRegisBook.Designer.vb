<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardScreeningRegisBook
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardScreeningRegisBook))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DGSetting = New System.Windows.Forms.DataGridView
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelSend = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Refraction = New System.Windows.Forms.TabPage
        Me.ReferralPickup = New System.Windows.Forms.TabPage
        Me.ReferralBySelf = New System.Windows.Forms.TabPage
        Me.OpticalShop = New System.Windows.Forms.TabPage
        Me.SCREEN_BOOKID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameEng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameKhmer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HEALTH_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SETTING_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IS_REFRACTION = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_OPTICALSHOP = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_REFER_PICKUP = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IS_REFER_BYSELF = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.BOOK_NOTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.DGSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelSend.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelSend)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 852)
        Me.Panel1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(1001, 50)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(247, 27)
        Me.DateTimePicker2.TabIndex = 27
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1001, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(247, 27)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DGSetting
        '
        Me.DGSetting.AllowUserToAddRows = False
        Me.DGSetting.AllowUserToDeleteRows = False
        Me.DGSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGSetting.BackgroundColor = System.Drawing.Color.White
        Me.DGSetting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGSetting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSetting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGSetting.ColumnHeadersHeight = 35
        Me.DGSetting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCREEN_BOOKID, Me.PatientNo, Me.NameEng, Me.NameKhmer, Me.Age, Me.Sex, Me.HEALTH_NAME, Me.SETTING_DATE, Me.Address, Me.IS_REFRACTION, Me.IS_OPTICALSHOP, Me.IS_REFER_PICKUP, Me.IS_REFER_BYSELF, Me.BOOK_NOTE})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSetting.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGSetting.EnableHeadersVisualStyles = False
        Me.DGSetting.GridColor = System.Drawing.Color.SteelBlue
        Me.DGSetting.Location = New System.Drawing.Point(0, 0)
        Me.DGSetting.Margin = New System.Windows.Forms.Padding(5)
        Me.DGSetting.Name = "DGSetting"
        Me.DGSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSetting.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGSetting.RowTemplate.Height = 35
        Me.DGSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSetting.Size = New System.Drawing.Size(1246, 389)
        Me.DGSetting.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(949, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "To:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(949, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "From:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1206, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 27)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(1001, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 27)
        Me.TextBox1.TabIndex = 18
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(688, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(680, 24)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 82)
        Me.Panel4.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(42, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "5000"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(40, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Optical Shop:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(443, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(230, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(435, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 82)
        Me.Panel3.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(123, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 21)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "5000"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 21)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total By Self:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Pickup:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(123, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "5000"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(71, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Referall"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Location = New System.Drawing.Point(222, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 82)
        Me.Panel2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "5000"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Refraction"
        '
        'PanelSend
        '
        Me.PanelSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.PanelSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSend.Controls.Add(Me.Label2)
        Me.PanelSend.Controls.Add(Me.Label1)
        Me.PanelSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelSend.Location = New System.Drawing.Point(9, 25)
        Me.PanelSend.Name = "PanelSend"
        Me.PanelSend.Size = New System.Drawing.Size(200, 82)
        Me.PanelSend.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "5000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Registration"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 114)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGSetting)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1248, 733)
        Me.SplitContainer1.SplitterDistance = 391
        Me.SplitContainer1.TabIndex = 28
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.Refraction)
        Me.TabControl1.Controls.Add(Me.ReferralPickup)
        Me.TabControl1.Controls.Add(Me.ReferralBySelf)
        Me.TabControl1.Controls.Add(Me.OpticalShop)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.ItemSize = New System.Drawing.Size(250, 29)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1246, 336)
        Me.TabControl1.TabIndex = 0
        '
        'Refraction
        '
        Me.Refraction.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Refraction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Refraction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Refraction.ForeColor = System.Drawing.Color.Cornsilk
        Me.Refraction.Location = New System.Drawing.Point(4, 33)
        Me.Refraction.Name = "Refraction"
        Me.Refraction.Padding = New System.Windows.Forms.Padding(5)
        Me.Refraction.Size = New System.Drawing.Size(1238, 299)
        Me.Refraction.TabIndex = 0
        Me.Refraction.Text = "     Refraction     "
        Me.Refraction.UseVisualStyleBackColor = True
        '
        'ReferralPickup
        '
        Me.ReferralPickup.AutoScroll = True
        Me.ReferralPickup.BackColor = System.Drawing.SystemColors.Window
        Me.ReferralPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReferralPickup.Location = New System.Drawing.Point(4, 33)
        Me.ReferralPickup.Name = "ReferralPickup"
        Me.ReferralPickup.Padding = New System.Windows.Forms.Padding(3)
        Me.ReferralPickup.Size = New System.Drawing.Size(1238, 299)
        Me.ReferralPickup.TabIndex = 1
        Me.ReferralPickup.Text = "     Referal and Pickup   "
        Me.ReferralPickup.UseVisualStyleBackColor = True
        '
        'ReferralBySelf
        '
        Me.ReferralBySelf.AutoScroll = True
        Me.ReferralBySelf.Location = New System.Drawing.Point(4, 33)
        Me.ReferralBySelf.Name = "ReferralBySelf"
        Me.ReferralBySelf.Size = New System.Drawing.Size(1238, 299)
        Me.ReferralBySelf.TabIndex = 2
        Me.ReferralBySelf.Text = "    Referral By Selft     "
        Me.ReferralBySelf.UseVisualStyleBackColor = True
        '
        'OpticalShop
        '
        Me.OpticalShop.AutoScroll = True
        Me.OpticalShop.Location = New System.Drawing.Point(4, 33)
        Me.OpticalShop.Name = "OpticalShop"
        Me.OpticalShop.Size = New System.Drawing.Size(1238, 299)
        Me.OpticalShop.TabIndex = 3
        Me.OpticalShop.Text = "    Optical Shop    "
        Me.OpticalShop.UseVisualStyleBackColor = True
        '
        'SCREEN_BOOKID
        '
        Me.SCREEN_BOOKID.HeaderText = "SCREEN_BOOKID"
        Me.SCREEN_BOOKID.Name = "SCREEN_BOOKID"
        Me.SCREEN_BOOKID.Visible = False
        '
        'PatientNo
        '
        Me.PatientNo.HeaderText = "PatientNo"
        Me.PatientNo.Name = "PatientNo"
        '
        'NameEng
        '
        Me.NameEng.HeaderText = "Name English"
        Me.NameEng.Name = "NameEng"
        '
        'NameKhmer
        '
        Me.NameKhmer.HeaderText = "Name Khmer"
        Me.NameKhmer.Name = "NameKhmer"
        Me.NameKhmer.Visible = False
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        '
        'HEALTH_NAME
        '
        Me.HEALTH_NAME.HeaderText = "Screening Place"
        Me.HEALTH_NAME.Name = "HEALTH_NAME"
        '
        'SETTING_DATE
        '
        Me.SETTING_DATE.HeaderText = "Screening Date"
        Me.SETTING_DATE.Name = "SETTING_DATE"
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'IS_REFRACTION
        '
        Me.IS_REFRACTION.HeaderText = "Refraction"
        Me.IS_REFRACTION.Name = "IS_REFRACTION"
        Me.IS_REFRACTION.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IS_REFRACTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IS_OPTICALSHOP
        '
        Me.IS_OPTICALSHOP.HeaderText = "Optical Shop"
        Me.IS_OPTICALSHOP.Name = "IS_OPTICALSHOP"
        Me.IS_OPTICALSHOP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IS_OPTICALSHOP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IS_REFER_PICKUP
        '
        Me.IS_REFER_PICKUP.HeaderText = "Referral Pickup"
        Me.IS_REFER_PICKUP.Name = "IS_REFER_PICKUP"
        Me.IS_REFER_PICKUP.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IS_REFER_PICKUP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IS_REFER_BYSELF
        '
        Me.IS_REFER_BYSELF.HeaderText = "Referral By Selft"
        Me.IS_REFER_BYSELF.Name = "IS_REFER_BYSELF"
        Me.IS_REFER_BYSELF.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IS_REFER_BYSELF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'BOOK_NOTE
        '
        Me.BOOK_NOTE.HeaderText = "Note"
        Me.BOOK_NOTE.Name = "BOOK_NOTE"
        '
        'DashboardScreeningRegisBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DashboardScreeningRegisBook"
        Me.Size = New System.Drawing.Size(1271, 863)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelSend.ResumeLayout(False)
        Me.PanelSend.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelSend As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents DGSetting As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Refraction As System.Windows.Forms.TabPage
    Friend WithEvents ReferralPickup As System.Windows.Forms.TabPage
    Friend WithEvents ReferralBySelf As System.Windows.Forms.TabPage
    Friend WithEvents OpticalShop As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SCREEN_BOOKID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameEng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameKhmer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HEALTH_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SETTING_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IS_REFRACTION As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_OPTICALSHOP As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_REFER_PICKUP As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IS_REFER_BYSELF As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BOOK_NOTE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
