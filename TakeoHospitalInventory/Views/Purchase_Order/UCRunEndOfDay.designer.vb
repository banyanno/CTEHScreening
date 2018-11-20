<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCRunEndOfDay
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
        Me.components = New System.ComponentModel.Container
        Dim gridItemsEndofDayRun_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCRunEndOfDay))
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChBAll = New System.Windows.Forms.CheckBox
        Me.BtnEndofDay = New System.Windows.Forms.Button
        Me.cbDepart = New System.Windows.Forms.ComboBox
        Me.REDCalendar = New System.Windows.Forms.MonthCalendar
        Me.LbReady = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LbNotYet = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Search = New System.Windows.Forms.GroupBox
        Me.ChBAllS = New System.Windows.Forms.CheckBox
        Me.cbDepartS = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.ImageStatusbar = New System.Windows.Forms.ImageList(Me.components)
        Me.dptToDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dptFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnProcessEndOfDay = New System.Windows.Forms.ToolStripButton
        Me.gridItemsEndofDayRun = New Janus.Windows.GridEX.GridEX
        Me.ErrorEOD = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BgLoadingRunEOD = New System.ComponentModel.BackgroundWorker
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Search.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridItemsEndofDayRun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridItemsEndofDayRun)
        Me.SplitContainer1.Size = New System.Drawing.Size(1145, 504)
        Me.SplitContainer1.SplitterDistance = 216
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Search)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1145, 216)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChBAll)
        Me.GroupBox2.Controls.Add(Me.BtnEndofDay)
        Me.GroupBox2.Controls.Add(Me.cbDepart)
        Me.GroupBox2.Controls.Add(Me.REDCalendar)
        Me.GroupBox2.Controls.Add(Me.LbReady)
        Me.GroupBox2.Controls.Add(Me.LbNotYet)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(535, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 194)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Process End of Day"
        '
        'ChBAll
        '
        Me.ChBAll.AutoSize = True
        Me.ChBAll.Checked = True
        Me.ChBAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBAll.Location = New System.Drawing.Point(364, 74)
        Me.ChBAll.Name = "ChBAll"
        Me.ChBAll.Size = New System.Drawing.Size(45, 17)
        Me.ChBAll.TabIndex = 20
        Me.ChBAll.Text = "ALL"
        Me.ChBAll.UseVisualStyleBackColor = True
        Me.ChBAll.Visible = False
        '
        'BtnEndofDay
        '
        Me.BtnEndofDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnEndofDay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEndofDay.FlatAppearance.BorderSize = 0
        Me.BtnEndofDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEndofDay.ForeColor = System.Drawing.Color.White
        Me.BtnEndofDay.Image = CType(resources.GetObject("BtnEndofDay.Image"), System.Drawing.Image)
        Me.BtnEndofDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEndofDay.Location = New System.Drawing.Point(249, 124)
        Me.BtnEndofDay.Name = "BtnEndofDay"
        Me.BtnEndofDay.Size = New System.Drawing.Size(206, 43)
        Me.BtnEndofDay.TabIndex = 19
        Me.BtnEndofDay.Text = "Process End of Day"
        Me.BtnEndofDay.UseVisualStyleBackColor = False
        '
        'cbDepart
        '
        Me.cbDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbDepart.FormattingEnabled = True
        Me.cbDepart.Location = New System.Drawing.Point(249, 97)
        Me.cbDepart.Name = "cbDepart"
        Me.cbDepart.Size = New System.Drawing.Size(166, 21)
        Me.cbDepart.TabIndex = 9
        Me.cbDepart.Visible = False
        '
        'REDCalendar
        '
        Me.REDCalendar.Location = New System.Drawing.Point(10, 18)
        Me.REDCalendar.Margin = New System.Windows.Forms.Padding(7)
        Me.REDCalendar.Name = "REDCalendar"
        Me.REDCalendar.TabIndex = 15
        '
        'LbReady
        '
        Me.LbReady.ImageIndex = 1
        Me.LbReady.ImageList = Me.ImageList1
        Me.LbReady.Location = New System.Drawing.Point(290, 18)
        Me.LbReady.Name = "LbReady"
        Me.LbReady.Size = New System.Drawing.Size(49, 58)
        Me.LbReady.TabIndex = 18
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "circle_red.png")
        Me.ImageList1.Images.SetKeyName(1, "circle_blue.png")
        '
        'LbNotYet
        '
        Me.LbNotYet.ImageIndex = 0
        Me.LbNotYet.ImageList = Me.ImageList1
        Me.LbNotYet.Location = New System.Drawing.Point(289, 18)
        Me.LbNotYet.Name = "LbNotYet"
        Me.LbNotYet.Size = New System.Drawing.Size(51, 57)
        Me.LbNotYet.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Department:"
        Me.Label3.Visible = False
        '
        'Search
        '
        Me.Search.Controls.Add(Me.ChBAllS)
        Me.Search.Controls.Add(Me.cbDepartS)
        Me.Search.Controls.Add(Me.Label4)
        Me.Search.Controls.Add(Me.BtnPrint)
        Me.Search.Controls.Add(Me.BtnSearch)
        Me.Search.Controls.Add(Me.dptToDate)
        Me.Search.Controls.Add(Me.Label1)
        Me.Search.Controls.Add(Me.dptFromDate)
        Me.Search.Controls.Add(Me.Label2)
        Me.Search.Location = New System.Drawing.Point(3, 16)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(526, 194)
        Me.Search.TabIndex = 0
        Me.Search.TabStop = False
        Me.Search.Text = "Search"
        '
        'ChBAllS
        '
        Me.ChBAllS.AutoSize = True
        Me.ChBAllS.Checked = True
        Me.ChBAllS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChBAllS.Location = New System.Drawing.Point(343, 44)
        Me.ChBAllS.Name = "ChBAllS"
        Me.ChBAllS.Size = New System.Drawing.Size(45, 17)
        Me.ChBAllS.TabIndex = 23
        Me.ChBAllS.Text = "ALL"
        Me.ChBAllS.UseVisualStyleBackColor = True
        '
        'cbDepartS
        '
        Me.cbDepartS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDepartS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDepartS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbDepartS.FormattingEnabled = True
        Me.cbDepartS.Location = New System.Drawing.Point(20, 37)
        Me.cbDepartS.Name = "cbDepartS"
        Me.cbDepartS.Size = New System.Drawing.Size(308, 28)
        Me.cbDepartS.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Department:"
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.ForeColor = System.Drawing.Color.White
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(393, 72)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(124, 41)
        Me.BtnPrint.TabIndex = 14
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(393, 29)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(124, 39)
        Me.BtnSearch.TabIndex = 13
        Me.BtnSearch.Text = "View"
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'ImageStatusbar
        '
        Me.ImageStatusbar.ImageStream = CType(resources.GetObject("ImageStatusbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageStatusbar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageStatusbar.Images.SetKeyName(0, "arrow_down.ico")
        '
        'dptToDate
        '
        Me.dptToDate.Checked = False
        Me.dptToDate.CustomFormat = "dd/MM/yyyy"
        Me.dptToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptToDate.Location = New System.Drawing.Point(177, 88)
        Me.dptToDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptToDate.Name = "dptToDate"
        Me.dptToDate.Size = New System.Drawing.Size(151, 26)
        Me.dptToDate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "To Date:"
        '
        'dptFromDate
        '
        Me.dptFromDate.Checked = False
        Me.dptFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dptFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dptFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dptFromDate.Location = New System.Drawing.Point(19, 88)
        Me.dptFromDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dptFromDate.Name = "dptFromDate"
        Me.dptFromDate.Size = New System.Drawing.Size(151, 26)
        Me.dptFromDate.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From Date:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnProcessEndOfDay})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1145, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolStrip1.Visible = False
        '
        'BtnProcessEndOfDay
        '
        Me.BtnProcessEndOfDay.Image = Global.TakeoHospitalInventory.My.Resources.Resources.process
        Me.BtnProcessEndOfDay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnProcessEndOfDay.Name = "BtnProcessEndOfDay"
        Me.BtnProcessEndOfDay.Size = New System.Drawing.Size(145, 36)
        Me.BtnProcessEndOfDay.Text = "Process End Of Day"
        '
        'gridItemsEndofDayRun
        '
        Me.gridItemsEndofDayRun.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        gridItemsEndofDayRun_DesignTimeLayout.LayoutString = resources.GetString("gridItemsEndofDayRun_DesignTimeLayout.LayoutString")
        Me.gridItemsEndofDayRun.DesignTimeLayout = gridItemsEndofDayRun_DesignTimeLayout
        Me.gridItemsEndofDayRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridItemsEndofDayRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridItemsEndofDayRun.GroupByBoxVisible = False
        Me.gridItemsEndofDayRun.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.gridItemsEndofDayRun.Location = New System.Drawing.Point(0, 0)
        Me.gridItemsEndofDayRun.Name = "gridItemsEndofDayRun"
        Me.gridItemsEndofDayRun.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.gridItemsEndofDayRun.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.gridItemsEndofDayRun.RecordNavigator = True
        Me.gridItemsEndofDayRun.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.gridItemsEndofDayRun.Size = New System.Drawing.Size(1145, 284)
        Me.gridItemsEndofDayRun.TabIndex = 9
        Me.gridItemsEndofDayRun.VisualStyleManager = Me.VSForOpticalshop
        '
        'ErrorEOD
        '
        Me.ErrorEOD.ContainerControl = Me
        '
        'BgLoadingRunEOD
        '
        Me.BgLoadingRunEOD.WorkerSupportsCancellation = True
        '
        'VSForOpticalshop
        '
        JanusColorScheme2.ActiveCaptionColor = System.Drawing.Color.Tomato
        JanusColorScheme2.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme2.ControlDarkColor = System.Drawing.SystemColors.Control
        JanusColorScheme2.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        JanusColorScheme2.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        JanusColorScheme2.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(67, Byte), Integer))
        JanusColorScheme2.HighlightTextColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme2.InfoColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme2.InfoTextColor = System.Drawing.Color.FloralWhite
        JanusColorScheme2.MenuColor = System.Drawing.SystemColors.ActiveCaption
        JanusColorScheme2.MenuTextColor = System.Drawing.Color.DimGray
        JanusColorScheme2.Name = "Header"
        JanusColorScheme2.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme2.Office2007CustomColor = System.Drawing.SystemColors.Control
        JanusColorScheme2.UseThemes = False
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme2.WindowColor = System.Drawing.Color.White
        JanusColorScheme2.WindowTextColor = System.Drawing.Color.DarkBlue
        Me.VSForOpticalshop.ColorSchemes.Add(JanusColorScheme2)
        Me.VSForOpticalshop.DefaultColorScheme = "Header"
        '
        'UCRunEndOfDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "UCRunEndOfDay"
        Me.Size = New System.Drawing.Size(1145, 504)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Search.ResumeLayout(False)
        Me.Search.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridItemsEndofDayRun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Search As System.Windows.Forms.GroupBox
    Friend WithEvents dptToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dptFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbDepart As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnProcessEndOfDay As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridItemsEndofDayRun As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents REDCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents LbNotYet As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LbReady As System.Windows.Forms.Label
    Friend WithEvents ImageStatusbar As System.Windows.Forms.ImageList
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents ErrorEOD As System.Windows.Forms.ErrorProvider
    Friend WithEvents BgLoadingRunEOD As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnEndofDay As System.Windows.Forms.Button
    Friend WithEvents ChBAll As System.Windows.Forms.CheckBox
    Friend WithEvents ChBAllS As System.Windows.Forms.CheckBox
    Friend WithEvents cbDepartS As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager

End Class
