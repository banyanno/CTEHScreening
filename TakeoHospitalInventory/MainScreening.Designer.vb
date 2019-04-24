<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainScreening))
        Me.PanelHeader = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnHome = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelDedail = New System.Windows.Forms.Panel
        Me.RibboStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.DBtnSwitchUser = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand1 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.DropDownCommand3 = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand2 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.DBtnChangePassword = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnDateTimeServer = New Janus.Windows.Ribbon.LabelCommand
        Me.ContainerPicloading = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.LabelDepartment = New Janus.Windows.Ribbon.LabelCommand
        Me.PanelHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.White
        Me.PanelHeader.Controls.Add(Me.Panel1)
        Me.PanelHeader.Controls.Add(Me.BtnHome)
        Me.PanelHeader.Controls.Add(Me.BtnExit)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.PictureBox1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1300, 143)
        Me.PanelHeader.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(982, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 109)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(311, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.Green
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.Location = New System.Drawing.Point(439, 92)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(56, 50)
        Me.BtnHome.TabIndex = 16
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Green
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(1262, 107)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(41, 35)
        Me.BtnExit.TabIndex = 15
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(439, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(861, 34)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Screening System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(439, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelDedail
        '
        Me.PanelDedail.BackColor = System.Drawing.Color.White
        Me.PanelDedail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDedail.Location = New System.Drawing.Point(0, 143)
        Me.PanelDedail.Name = "PanelDedail"
        Me.PanelDedail.Size = New System.Drawing.Size(1300, 554)
        Me.PanelDedail.TabIndex = 1
        '
        'RibboStatusBar
        '
        Me.RibboStatusBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibboStatusBar.ImageSize = New System.Drawing.Size(24, 24)
        Me.RibboStatusBar.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand1, Me.BtnDateTimeServer})
        Me.RibboStatusBar.Location = New System.Drawing.Point(0, 697)
        Me.RibboStatusBar.Margin = New System.Windows.Forms.Padding(2)
        Me.RibboStatusBar.Name = "RibboStatusBar"
        Me.RibboStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibboStatusBar.Office2007CustomColor = System.Drawing.Color.Green
        Me.RibboStatusBar.RightPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.ContainerPicloading, Me.LabelDepartment})
        Me.RibboStatusBar.ShowToolTips = False
        Me.RibboStatusBar.Size = New System.Drawing.Size(1300, 27)
        '
        '
        '
        Me.RibboStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.RibboStatusBar.SuperTipComponent.BackColor = System.Drawing.Color.Green
        Me.RibboStatusBar.SuperTipComponent.ImageList = Nothing
        Me.RibboStatusBar.TabIndex = 2
        Me.RibboStatusBar.Text = "RibbonStatusBar1"
        Me.RibboStatusBar.UseCompatibleTextRendering = False
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DBtnSwitchUser, Me.SeparatorCommand1, Me.DropDownCommand3, Me.SeparatorCommand2, Me.DBtnChangePassword})
        Me.DropDownCommand1.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DropDownCommand1.Image = CType(resources.GetObject("DropDownCommand1.Image"), System.Drawing.Image)
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.DropDownCommand1.Text = " User Utility   "
        '
        'DBtnSwitchUser
        '
        Me.DBtnSwitchUser.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DBtnSwitchUser.Image = CType(resources.GetObject("DBtnSwitchUser.Image"), System.Drawing.Image)
        Me.DBtnSwitchUser.Key = "DropDownCommand2"
        Me.DBtnSwitchUser.Name = "DBtnSwitchUser"
        Me.DBtnSwitchUser.Text = "Switch User:"
        '
        'SeparatorCommand1
        '
        Me.SeparatorCommand1.Key = "SeparatorCommand1"
        Me.SeparatorCommand1.Name = "SeparatorCommand1"
        '
        'DropDownCommand3
        '
        Me.DropDownCommand3.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DropDownCommand3.Image = CType(resources.GetObject("DropDownCommand3.Image"), System.Drawing.Image)
        Me.DropDownCommand3.Key = "DropDownCommand3"
        Me.DropDownCommand3.Name = "DropDownCommand3"
        Me.DropDownCommand3.Text = "Lock System"
        '
        'SeparatorCommand2
        '
        Me.SeparatorCommand2.Key = "SeparatorCommand2"
        Me.SeparatorCommand2.Name = "SeparatorCommand2"
        '
        'DBtnChangePassword
        '
        Me.DBtnChangePassword.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.DBtnChangePassword.Image = CType(resources.GetObject("DBtnChangePassword.Image"), System.Drawing.Image)
        Me.DBtnChangePassword.Key = "DropDownCommand4"
        Me.DBtnChangePassword.Name = "DBtnChangePassword"
        Me.DBtnChangePassword.Text = "Change Password"
        '
        'BtnDateTimeServer
        '
        Me.BtnDateTimeServer.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.BtnDateTimeServer.Image = CType(resources.GetObject("BtnDateTimeServer.Image"), System.Drawing.Image)
        Me.BtnDateTimeServer.Key = "LabelCommand1"
        Me.BtnDateTimeServer.Name = "BtnDateTimeServer"
        Me.BtnDateTimeServer.Text = " Date Server:   "
        '
        'ContainerPicloading
        '
        Me.ContainerPicloading.Control = Me.PictureBox3
        Me.ContainerPicloading.ControlWidth = 180
        Me.ContainerPicloading.ForegroundStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ContainerPicloading.Key = "ContainerControlCommand1"
        Me.ContainerPicloading.Name = "ContainerPicloading"
        Me.ContainerPicloading.Text = "Loading"
        Me.ContainerPicloading.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TakeoHospitalInventory.My.Resources.Resources.loadingNew3
        Me.PictureBox3.Location = New System.Drawing.Point(1120, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(180, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'LabelDepartment
        '
        Me.LabelDepartment.Key = "LabelDepartment"
        Me.LabelDepartment.Name = "LabelDepartment"
        Me.LabelDepartment.Text = ""
        '
        'MainScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 724)
        Me.Controls.Add(Me.PanelDedail)
        Me.Controls.Add(Me.RibboStatusBar)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainScreening"
        Me.Text = "MainScreening"
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents PanelDedail As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RibboStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents DBtnSwitchUser As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand1 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents DropDownCommand3 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand2 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents DBtnChangePassword As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnDateTimeServer As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ContainerPicloading As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents LabelDepartment As Janus.Windows.Ribbon.LabelCommand
End Class
