﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardSetting
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardSetting))
        Me.DGSetting = New System.Windows.Forms.DataGridView
        Me.SETTING_ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SETTING_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HEALTH_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PROVINCE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DISTRICT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COMMUNE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FULL_ADDRESS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IS_DEFOUL = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewSetting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnUpdateSetting = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.DGSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSetting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGSetting.ColumnHeadersHeight = 35
        Me.DGSetting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SETTING_ID, Me.SETTING_DATE, Me.HEALTH_NAME, Me.PROVINCE, Me.DISTRICT, Me.COMMUNE, Me.FULL_ADDRESS, Me.IS_DEFOUL})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSetting.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGSetting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGSetting.EnableHeadersVisualStyles = False
        Me.DGSetting.GridColor = System.Drawing.Color.SteelBlue
        Me.DGSetting.Location = New System.Drawing.Point(0, 58)
        Me.DGSetting.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.DGSetting.Name = "DGSetting"
        Me.DGSetting.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSetting.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGSetting.RowTemplate.Height = 35
        Me.DGSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSetting.Size = New System.Drawing.Size(967, 848)
        Me.DGSetting.TabIndex = 13
        '
        'SETTING_ID
        '
        Me.SETTING_ID.DataPropertyName = "SETTING_ID"
        Me.SETTING_ID.HeaderText = "Setting No"
        Me.SETTING_ID.Name = "SETTING_ID"
        Me.SETTING_ID.Visible = False
        '
        'SETTING_DATE
        '
        Me.SETTING_DATE.DataPropertyName = "SETTING_DATE"
        DataGridViewCellStyle6.Format = "dd-MM-yyyy"
        Me.SETTING_DATE.DefaultCellStyle = DataGridViewCellStyle6
        Me.SETTING_DATE.HeaderText = "Date Setting"
        Me.SETTING_DATE.Name = "SETTING_DATE"
        Me.SETTING_DATE.ReadOnly = True
        '
        'HEALTH_NAME
        '
        Me.HEALTH_NAME.DataPropertyName = "HEALTH_NAME"
        Me.HEALTH_NAME.HeaderText = "Screening Place"
        Me.HEALTH_NAME.Name = "HEALTH_NAME"
        Me.HEALTH_NAME.ReadOnly = True
        '
        'PROVINCE
        '
        Me.PROVINCE.DataPropertyName = "PROVINCE"
        Me.PROVINCE.HeaderText = "Province"
        Me.PROVINCE.Name = "PROVINCE"
        Me.PROVINCE.ReadOnly = True
        '
        'DISTRICT
        '
        Me.DISTRICT.DataPropertyName = "DISTRICT"
        Me.DISTRICT.HeaderText = "District"
        Me.DISTRICT.Name = "DISTRICT"
        Me.DISTRICT.ReadOnly = True
        '
        'COMMUNE
        '
        Me.COMMUNE.DataPropertyName = "COMMUNE"
        Me.COMMUNE.HeaderText = "Commune"
        Me.COMMUNE.Name = "COMMUNE"
        Me.COMMUNE.ReadOnly = True
        '
        'FULL_ADDRESS
        '
        Me.FULL_ADDRESS.DataPropertyName = "FULL_ADDRESS"
        Me.FULL_ADDRESS.HeaderText = "Full Address"
        Me.FULL_ADDRESS.Name = "FULL_ADDRESS"
        Me.FULL_ADDRESS.ReadOnly = True
        Me.FULL_ADDRESS.Visible = False
        '
        'IS_DEFOUL
        '
        Me.IS_DEFOUL.DataPropertyName = "IS_DEFOUL"
        Me.IS_DEFOUL.HeaderText = "Default"
        Me.IS_DEFOUL.Name = "IS_DEFOUL"
        Me.IS_DEFOUL.ReadOnly = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.ToolStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.BtnNewSetting, Me.ToolStripSeparator1, Me.BtnUpdateSetting, Me.ToolStripSeparator2, Me.BtnRefresh, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 58)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewSetting
        '
        Me.BtnNewSetting.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnNewSetting.ForeColor = System.Drawing.Color.White
        Me.BtnNewSetting.Image = CType(resources.GetObject("BtnNewSetting.Image"), System.Drawing.Image)
        Me.BtnNewSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewSetting.Name = "BtnNewSetting"
        Me.BtnNewSetting.Size = New System.Drawing.Size(172, 55)
        Me.BtnNewSetting.Text = "New Screening Setting"
        Me.BtnNewSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'BtnUpdateSetting
        '
        Me.BtnUpdateSetting.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateSetting.Image = CType(resources.GetObject("BtnUpdateSetting.Image"), System.Drawing.Image)
        Me.BtnUpdateSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUpdateSetting.Name = "BtnUpdateSetting"
        Me.BtnUpdateSetting.Size = New System.Drawing.Size(135, 55)
        Me.BtnUpdateSetting.Text = "Update Setting"
        Me.BtnUpdateSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.White
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(110, 55)
        Me.BtnRefresh.Text = "     Refresh     "
        Me.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 58)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 58)
        '
        'DashboardSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGSetting)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "DashboardSetting"
        Me.Size = New System.Drawing.Size(967, 906)
        CType(Me.DGSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents DGSetting As System.Windows.Forms.DataGridView
    Friend WithEvents SETTING_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SETTING_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HEALTH_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVINCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTRICT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COMMUNE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FULL_ADDRESS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IS_DEFOUL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BtnNewSetting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnUpdateSetting As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
