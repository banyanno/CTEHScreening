<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardSetting))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibboStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.SeparatorCommand1 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnRefresh = New Janus.Windows.Ribbon.StatusBarPanel
        Me.BtnNewSetting = New Janus.Windows.Ribbon.StatusBarPanel
        Me.BtnUpdate = New Janus.Windows.Ribbon.StatusBarPanel
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.SettingNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlaceScreening = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsUse = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibboStatusBar
        '
        Me.RibboStatusBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibboStatusBar.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibboStatusBar.ImageSize = New System.Drawing.Size(24, 24)
        Me.RibboStatusBar.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.SeparatorCommand1, Me.BtnNewSetting, Me.BtnUpdate, Me.BtnRefresh})
        Me.RibboStatusBar.Location = New System.Drawing.Point(0, 0)
        Me.RibboStatusBar.Margin = New System.Windows.Forms.Padding(2)
        Me.RibboStatusBar.Name = "RibboStatusBar"
        Me.RibboStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibboStatusBar.Office2007CustomColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.RibboStatusBar.ShowToolTips = False
        Me.RibboStatusBar.Size = New System.Drawing.Size(1084, 32)
        '
        '
        '
        Me.RibboStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.RibboStatusBar.SuperTipComponent.BackColor = System.Drawing.Color.Green
        Me.RibboStatusBar.SuperTipComponent.ImageList = Nothing
        Me.RibboStatusBar.TabIndex = 6
        Me.RibboStatusBar.Text = "RibbonStatusBar1"
        Me.RibboStatusBar.UseCompatibleTextRendering = False
        '
        'SeparatorCommand1
        '
        Me.SeparatorCommand1.Key = "SeparatorCommand1"
        Me.SeparatorCommand1.Name = "SeparatorCommand1"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Key = "StatusBarPanel3"
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNewSetting
        '
        Me.BtnNewSetting.Image = CType(resources.GetObject("BtnNewSetting.Image"), System.Drawing.Image)
        Me.BtnNewSetting.Key = "StatusBarPanel1"
        Me.BtnNewSetting.Name = "BtnNewSetting"
        Me.BtnNewSetting.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.BtnNewSetting.Text = "New Screening Setting  "
        Me.BtnNewSetting.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnNewSetting.Width = 200
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Image = CType(resources.GetObject("BtnUpdate.Image"), System.Drawing.Image)
        Me.BtnUpdate.Key = "StatusBarPanel2"
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.BtnUpdate.Text = "Update Setting"
        Me.BtnUpdate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnUpdate.Width = 150
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SettingNo, Me.ID, Me.PlaceScreening, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.IsUse})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridView2.Location = New System.Drawing.Point(0, 32)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowTemplate.Height = 35
        Me.DataGridView2.Size = New System.Drawing.Size(1084, 529)
        Me.DataGridView2.TabIndex = 13
        '
        'SettingNo
        '
        Me.SettingNo.HeaderText = "Setting No"
        Me.SettingNo.Name = "SettingNo"
        '
        'ID
        '
        Me.ID.HeaderText = "Date Setting"
        Me.ID.Name = "ID"
        '
        'PlaceScreening
        '
        Me.PlaceScreening.HeaderText = "Place Screening"
        Me.PlaceScreening.Name = "PlaceScreening"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Province"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "District"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Commune"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Full Address"
        Me.Column4.Name = "Column4"
        '
        'IsUse
        '
        Me.IsUse.HeaderText = "Default"
        Me.IsUse.Name = "IsUse"
        '
        'DashboardSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.RibboStatusBar)
        Me.Name = "DashboardSetting"
        Me.Size = New System.Drawing.Size(1084, 561)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibboStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents SeparatorCommand1 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents BtnNewSetting As Janus.Windows.Ribbon.StatusBarPanel
    Friend WithEvents BtnUpdate As Janus.Windows.Ribbon.StatusBarPanel
    Friend WithEvents BtnRefresh As Janus.Windows.Ribbon.StatusBarPanel
    Private WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SettingNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceScreening As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsUse As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
