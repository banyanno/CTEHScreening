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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnHome = New System.Windows.Forms.Button
        Me.BtnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelDedail = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.LockSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SwichUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.RibboStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.PanelHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDedail.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(811, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 109)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(297, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Your Vision, Our Mission."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(273, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TAKEO EYE  HOSPITAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer Mool1", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(269, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "មន្ទីរពេទ្យ ភ្នែក តាកែវ"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(110, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(259, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "គំហើញរបស់អ្នក ជាបេសកម្មរបស់យើង"
        '
        'BtnHome
        '
        Me.BtnHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHome.BackColor = System.Drawing.Color.Green
        Me.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.Location = New System.Drawing.Point(1213, 107)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(38, 35)
        Me.BtnHome.TabIndex = 16
        Me.BtnHome.UseVisualStyleBackColor = False
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
        Me.BtnExit.Location = New System.Drawing.Point(1255, 107)
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
        Me.PanelDedail.Controls.Add(Me.RibboStatusBar)
        Me.PanelDedail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDedail.Location = New System.Drawing.Point(0, 143)
        Me.PanelDedail.Name = "PanelDedail"
        Me.PanelDedail.Size = New System.Drawing.Size(1300, 554)
        Me.PanelDedail.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 697)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1300, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownButtonWidth = 15
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ChangePasswordToolStripMenuItem, Me.ToolStripMenuItem2, Me.LockSystemToolStripMenuItem, Me.ToolStripMenuItem1, Me.SwichUserToolStripMenuItem})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripSplitButton1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(121, 24)
        Me.ToolStripSplitButton1.Text = "User Utility"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(190, 6)
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(190, 6)
        '
        'LockSystemToolStripMenuItem
        '
        Me.LockSystemToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.LockSystemToolStripMenuItem.Image = CType(resources.GetObject("LockSystemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LockSystemToolStripMenuItem.Name = "LockSystemToolStripMenuItem"
        Me.LockSystemToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.LockSystemToolStripMenuItem.Text = "Lock System"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 6)
        '
        'SwichUserToolStripMenuItem
        '
        Me.SwichUserToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.SwichUserToolStripMenuItem.Image = CType(resources.GetObject("SwichUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SwichUserToolStripMenuItem.Name = "SwichUserToolStripMenuItem"
        Me.SwichUserToolStripMenuItem.Size = New System.Drawing.Size(193, 24)
        Me.SwichUserToolStripMenuItem.Text = "Swtich User"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 24)
        Me.ToolStripLabel1.Text = "Date Server"
        '
        'RibboStatusBar
        '
        Me.RibboStatusBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibboStatusBar.ImageSize = New System.Drawing.Size(24, 24)
        Me.RibboStatusBar.Location = New System.Drawing.Point(0, 530)
        Me.RibboStatusBar.Margin = New System.Windows.Forms.Padding(2)
        Me.RibboStatusBar.Name = "RibboStatusBar"
        Me.RibboStatusBar.Office2007ColorScheme = Janus.Windows.Ribbon.Office2007ColorScheme.Custom
        Me.RibboStatusBar.Office2007CustomColor = System.Drawing.Color.Gray
        Me.RibboStatusBar.ShowToolTips = False
        Me.RibboStatusBar.Size = New System.Drawing.Size(1300, 24)
        '
        '
        '
        Me.RibboStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.RibboStatusBar.SuperTipComponent.ImageList = Nothing
        Me.RibboStatusBar.TabIndex = 2
        Me.RibboStatusBar.Text = "RibbonStatusBar1"
        Me.RibboStatusBar.UseCompatibleTextRendering = False
        '
        'MainScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 724)
        Me.Controls.Add(Me.PanelDedail)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainScreening"
        Me.Text = "MainScreening"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelHeader.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDedail.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents PanelDedail As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SwichUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LockSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RibboStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
End Class
