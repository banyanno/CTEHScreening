<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainOpticalShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainOpticalShop))
        Dim GridReceipt_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim GridListWaitingPay_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ImageAddItem = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageStatusbar = New System.Windows.Forms.ImageList(Me.components)
        Me.ErrReceipt = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridReceipt = New Janus.Windows.GridEX.GridEX
        Me.VSForOpticalshop = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnEditDonateOptical = New System.Windows.Forms.Button
        Me.BtnEditeDateReceipt = New System.Windows.Forms.Button
        Me.BtnPrintInvoice = New System.Windows.Forms.Button
        Me.BtnEditInvoice = New System.Windows.Forms.Button
        Me.RadReceiptCancel = New System.Windows.Forms.RadioButton
        Me.RadWaitAndPaid = New System.Windows.Forms.RadioButton
        Me.BtnNewReceipt1 = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.BGLoadOpticalShop = New System.ComponentModel.BackgroundWorker
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GridListWaitingPay = New Janus.Windows.GridEX.GridEX
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridListWaitingPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageAddItem
        '
        Me.ImageAddItem.ImageStream = CType(resources.GetObject("ImageAddItem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageAddItem.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageAddItem.Images.SetKeyName(0, "Vista (199).png")
        Me.ImageAddItem.Images.SetKeyName(1, "Vista (198).png")
        Me.ImageAddItem.Images.SetKeyName(2, "delete.ico")
        Me.ImageAddItem.Images.SetKeyName(3, "app_48.ico")
        '
        'ImageStatusbar
        '
        Me.ImageStatusbar.ImageStream = CType(resources.GetObject("ImageStatusbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageStatusbar.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageStatusbar.Images.SetKeyName(0, "check.ico")
        Me.ImageStatusbar.Images.SetKeyName(1, "document-print.ico")
        Me.ImageStatusbar.Images.SetKeyName(2, "arrow_down.ico")
        Me.ImageStatusbar.Images.SetKeyName(3, "blue_new.png")
        Me.ImageStatusbar.Images.SetKeyName(4, "edit.png")
        Me.ImageStatusbar.Images.SetKeyName(5, "document-print.png")
        Me.ImageStatusbar.Images.SetKeyName(6, "CashReceipt.png")
        '
        'ErrReceipt
        '
        Me.ErrReceipt.ContainerControl = Me
        '
        'GridReceipt
        '
        Me.GridReceipt.BackColor = System.Drawing.Color.White
        GridReceipt_DesignTimeLayout.LayoutString = resources.GetString("GridReceipt_DesignTimeLayout.LayoutString")
        Me.GridReceipt.DesignTimeLayout = GridReceipt_DesignTimeLayout
        Me.GridReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.GridReceipt.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridReceipt.GroupByBoxVisible = False
        Me.GridReceipt.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridReceipt.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GridReceipt.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Red
        Me.GridReceipt.HeaderFormatStyle.FontSize = 12.0!
        Me.GridReceipt.HeaderFormatStyle.ForeColor = System.Drawing.Color.White
        Me.GridReceipt.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridReceipt.Hierarchical = True
        Me.GridReceipt.Location = New System.Drawing.Point(0, 0)
        Me.GridReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.GridReceipt.Name = "GridReceipt"
        Me.GridReceipt.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridReceipt.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.GridReceipt.RecordNavigator = True
        Me.GridReceipt.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition
        Me.GridReceipt.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridReceipt.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.GridReceipt.Size = New System.Drawing.Size(863, 501)
        Me.GridReceipt.TabIndex = 3
        Me.GridReceipt.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None
        Me.GridReceipt.VisualStyleManager = Me.VSForOpticalshop
        '
        'VSForOpticalshop
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.Tomato
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.Color.White
        JanusColorScheme1.ControlDarkColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.Black
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(102, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(67, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoColor = System.Drawing.Color.WhiteSmoke
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.FloralWhite
        JanusColorScheme1.MenuColor = System.Drawing.SystemColors.ActiveCaption
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.DimGray
        JanusColorScheme1.Name = "Header"
        JanusColorScheme1.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver
        JanusColorScheme1.Office2007CustomColor = System.Drawing.SystemColors.Control
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Standard
        JanusColorScheme1.WindowColor = System.Drawing.Color.White
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.DarkBlue
        Me.VSForOpticalshop.ColorSchemes.Add(JanusColorScheme1)
        Me.VSForOpticalshop.DefaultColorScheme = "Header"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnEditDonateOptical)
        Me.Panel1.Controls.Add(Me.BtnEditeDateReceipt)
        Me.Panel1.Controls.Add(Me.BtnPrintInvoice)
        Me.Panel1.Controls.Add(Me.BtnEditInvoice)
        Me.Panel1.Controls.Add(Me.RadReceiptCancel)
        Me.Panel1.Controls.Add(Me.RadWaitAndPaid)
        Me.Panel1.Controls.Add(Me.BtnNewReceipt1)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrom)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1368, 58)
        Me.Panel1.TabIndex = 5
        '
        'BtnEditDonateOptical
        '
        Me.BtnEditDonateOptical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditDonateOptical.Enabled = False
        Me.BtnEditDonateOptical.Location = New System.Drawing.Point(292, 8)
        Me.BtnEditDonateOptical.Name = "BtnEditDonateOptical"
        Me.BtnEditDonateOptical.Size = New System.Drawing.Size(101, 34)
        Me.BtnEditDonateOptical.TabIndex = 15
        Me.BtnEditDonateOptical.Tag = "Edit Donate In Optical"
        Me.BtnEditDonateOptical.Text = "Edit Donate In Optical"
        Me.BtnEditDonateOptical.UseVisualStyleBackColor = True
        '
        'BtnEditeDateReceipt
        '
        Me.BtnEditeDateReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditeDateReceipt.Enabled = False
        Me.BtnEditeDateReceipt.ImageIndex = 4
        Me.BtnEditeDateReceipt.ImageList = Me.ImageStatusbar
        Me.BtnEditeDateReceipt.Location = New System.Drawing.Point(188, 8)
        Me.BtnEditeDateReceipt.Name = "BtnEditeDateReceipt"
        Me.BtnEditeDateReceipt.Size = New System.Drawing.Size(98, 34)
        Me.BtnEditeDateReceipt.TabIndex = 14
        Me.BtnEditeDateReceipt.Tag = "Edit Date Receipt"
        Me.BtnEditeDateReceipt.Text = "Edit Date Receipt"
        Me.BtnEditeDateReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditeDateReceipt.UseVisualStyleBackColor = True
        '
        'BtnPrintInvoice
        '
        Me.BtnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintInvoice.ImageIndex = 5
        Me.BtnPrintInvoice.ImageList = Me.ImageStatusbar
        Me.BtnPrintInvoice.Location = New System.Drawing.Point(399, 8)
        Me.BtnPrintInvoice.Name = "BtnPrintInvoice"
        Me.BtnPrintInvoice.Size = New System.Drawing.Size(89, 34)
        Me.BtnPrintInvoice.TabIndex = 13
        Me.BtnPrintInvoice.Text = "Print Invoice"
        Me.BtnPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintInvoice.UseVisualStyleBackColor = True
        '
        'BtnEditInvoice
        '
        Me.BtnEditInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditInvoice.Enabled = False
        Me.BtnEditInvoice.ImageIndex = 4
        Me.BtnEditInvoice.ImageList = Me.ImageStatusbar
        Me.BtnEditInvoice.Location = New System.Drawing.Point(97, 8)
        Me.BtnEditInvoice.Name = "BtnEditInvoice"
        Me.BtnEditInvoice.Size = New System.Drawing.Size(86, 34)
        Me.BtnEditInvoice.TabIndex = 12
        Me.BtnEditInvoice.Tag = "Edit Invoice"
        Me.BtnEditInvoice.Text = "Edit Invoice"
        Me.BtnEditInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditInvoice.UseVisualStyleBackColor = True
        '
        'RadReceiptCancel
        '
        Me.RadReceiptCancel.AutoSize = True
        Me.RadReceiptCancel.Location = New System.Drawing.Point(877, 27)
        Me.RadReceiptCancel.Name = "RadReceiptCancel"
        Me.RadReceiptCancel.Size = New System.Drawing.Size(96, 17)
        Me.RadReceiptCancel.TabIndex = 11
        Me.RadReceiptCancel.Text = "Invoice Cancel"
        Me.RadReceiptCancel.UseVisualStyleBackColor = True
        '
        'RadWaitAndPaid
        '
        Me.RadWaitAndPaid.AutoSize = True
        Me.RadWaitAndPaid.Checked = True
        Me.RadWaitAndPaid.Location = New System.Drawing.Point(877, 6)
        Me.RadWaitAndPaid.Name = "RadWaitAndPaid"
        Me.RadWaitAndPaid.Size = New System.Drawing.Size(144, 17)
        Me.RadWaitAndPaid.TabIndex = 11
        Me.RadWaitAndPaid.TabStop = True
        Me.RadWaitAndPaid.Text = "Waiting and Paid Invoice"
        Me.RadWaitAndPaid.UseVisualStyleBackColor = True
        '
        'BtnNewReceipt1
        '
        Me.BtnNewReceipt1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewReceipt1.ImageIndex = 3
        Me.BtnNewReceipt1.ImageList = Me.ImageStatusbar
        Me.BtnNewReceipt1.Location = New System.Drawing.Point(2, 8)
        Me.BtnNewReceipt1.Name = "BtnNewReceipt1"
        Me.BtnNewReceipt1.Size = New System.Drawing.Size(90, 34)
        Me.BtnNewReceipt1.TabIndex = 10
        Me.BtnNewReceipt1.Tag = "New Invoice"
        Me.BtnNewReceipt1.Text = "New Invoice"
        Me.BtnNewReceipt1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNewReceipt1.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnView.ImageIndex = 2
        Me.BtnView.ImageList = Me.ImageStatusbar
        Me.BtnView.Location = New System.Drawing.Point(791, 7)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(82, 29)
        Me.BtnView.TabIndex = 8
        Me.BtnView.Text = "View"
        Me.BtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(694, 12)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(92, 23)
        Me.DateTo.TabIndex = 6
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(571, 12)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(91, 23)
        Me.DateFrom.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(667, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From:"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 58)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1368, 3)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'BGLoadOpticalShop
        '
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 61)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridListWaitingPay)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridReceipt)
        Me.SplitContainer1.Size = New System.Drawing.Size(1368, 501)
        Me.SplitContainer1.SplitterDistance = 501
        Me.SplitContainer1.TabIndex = 8
        '
        'GridListWaitingPay
        '
        Me.GridListWaitingPay.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridListWaitingPay.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridListWaitingPay_DesignTimeLayout.LayoutString = resources.GetString("GridListWaitingPay_DesignTimeLayout.LayoutString")
        Me.GridListWaitingPay.DesignTimeLayout = GridListWaitingPay_DesignTimeLayout
        Me.GridListWaitingPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridListWaitingPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridListWaitingPay.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridListWaitingPay.GroupByBoxVisible = False
        Me.GridListWaitingPay.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridListWaitingPay.HeaderFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.GridListWaitingPay.HeaderFormatStyle.FontSize = 12.0!
        Me.GridListWaitingPay.HeaderFormatStyle.ForeColor = System.Drawing.Color.White
        Me.GridListWaitingPay.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridListWaitingPay.Location = New System.Drawing.Point(0, 0)
        Me.GridListWaitingPay.Margin = New System.Windows.Forms.Padding(1)
        Me.GridListWaitingPay.Name = "GridListWaitingPay"
        Me.GridListWaitingPay.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Silver
        Me.GridListWaitingPay.Office2007CustomColor = System.Drawing.SystemColors.Control
        Me.GridListWaitingPay.RecordNavigator = True
        Me.GridListWaitingPay.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex
        Me.GridListWaitingPay.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridListWaitingPay.Size = New System.Drawing.Size(501, 501)
        Me.GridListWaitingPay.TabIndex = 4
        Me.GridListWaitingPay.VisualStyleManager = Me.VSForOpticalshop
        '
        'MainOpticalShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainOpticalShop"
        Me.Size = New System.Drawing.Size(1368, 562)
        CType(Me.ErrReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridListWaitingPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageAddItem As System.Windows.Forms.ImageList
    Friend WithEvents ImageStatusbar As System.Windows.Forms.ImageList
    Friend WithEvents ErrReceipt As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridReceipt As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnNewReceipt1 As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents RadReceiptCancel As System.Windows.Forms.RadioButton
    Friend WithEvents RadWaitAndPaid As System.Windows.Forms.RadioButton
    Friend WithEvents BtnEditInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnPrintInvoice As System.Windows.Forms.Button
    Friend WithEvents BGLoadOpticalShop As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnEditeDateReceipt As System.Windows.Forms.Button
    Friend WithEvents BtnEditDonateOptical As System.Windows.Forms.Button
    Friend WithEvents VSForOpticalshop As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridListWaitingPay As Janus.Windows.GridEX.GridEX

End Class
