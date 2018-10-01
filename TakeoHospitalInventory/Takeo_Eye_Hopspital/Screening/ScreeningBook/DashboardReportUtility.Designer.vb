<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardReportUtility
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardReportUtility))
        Me.BtnScreeningBook = New System.Windows.Forms.Button
        Me.BtnPrescribtion = New System.Windows.Forms.Button
        Me.BtnReferredTEH = New System.Windows.Forms.Button
        Me.BtnPickUP = New System.Windows.Forms.Button
        Me.BtnPatientOperation = New System.Windows.Forms.Button
        Me.DateTo = New System.Windows.Forms.DateTimePicker
        Me.DateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BtnScreeningBook.Location = New System.Drawing.Point(7, 118)
        Me.BtnScreeningBook.Name = "BtnScreeningBook"
        Me.BtnScreeningBook.Size = New System.Drawing.Size(227, 74)
        Me.BtnScreeningBook.TabIndex = 4
        Me.BtnScreeningBook.Text = "Screening Book"
        Me.BtnScreeningBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnScreeningBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnScreeningBook.UseVisualStyleBackColor = False
        '
        'BtnPrescribtion
        '
        Me.BtnPrescribtion.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPrescribtion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrescribtion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPrescribtion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnPrescribtion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrescribtion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrescribtion.ForeColor = System.Drawing.Color.White
        Me.BtnPrescribtion.Image = CType(resources.GetObject("BtnPrescribtion.Image"), System.Drawing.Image)
        Me.BtnPrescribtion.Location = New System.Drawing.Point(7, 198)
        Me.BtnPrescribtion.Name = "BtnPrescribtion"
        Me.BtnPrescribtion.Size = New System.Drawing.Size(227, 74)
        Me.BtnPrescribtion.TabIndex = 5
        Me.BtnPrescribtion.Text = "Prescribtion For Refraction"
        Me.BtnPrescribtion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrescribtion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPrescribtion.UseVisualStyleBackColor = False
        '
        'BtnReferredTEH
        '
        Me.BtnReferredTEH.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnReferredTEH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReferredTEH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReferredTEH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnReferredTEH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReferredTEH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReferredTEH.ForeColor = System.Drawing.Color.White
        Me.BtnReferredTEH.Image = CType(resources.GetObject("BtnReferredTEH.Image"), System.Drawing.Image)
        Me.BtnReferredTEH.Location = New System.Drawing.Point(7, 278)
        Me.BtnReferredTEH.Name = "BtnReferredTEH"
        Me.BtnReferredTEH.Size = New System.Drawing.Size(227, 74)
        Me.BtnReferredTEH.TabIndex = 6
        Me.BtnReferredTEH.Text = "Referred patient to TEH"
        Me.BtnReferredTEH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnReferredTEH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnReferredTEH.UseVisualStyleBackColor = False
        '
        'BtnPickUP
        '
        Me.BtnPickUP.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPickUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPickUP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPickUP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnPickUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPickUP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPickUP.ForeColor = System.Drawing.Color.White
        Me.BtnPickUP.Image = CType(resources.GetObject("BtnPickUP.Image"), System.Drawing.Image)
        Me.BtnPickUP.Location = New System.Drawing.Point(7, 358)
        Me.BtnPickUP.Name = "BtnPickUP"
        Me.BtnPickUP.Size = New System.Drawing.Size(227, 74)
        Me.BtnPickUP.TabIndex = 6
        Me.BtnPickUP.Text = "Pick up To TEH"
        Me.BtnPickUP.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPickUP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPickUP.UseVisualStyleBackColor = False
        '
        'BtnPatientOperation
        '
        Me.BtnPatientOperation.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BtnPatientOperation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPatientOperation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPatientOperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnPatientOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPatientOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPatientOperation.ForeColor = System.Drawing.Color.White
        Me.BtnPatientOperation.Image = CType(resources.GetObject("BtnPatientOperation.Image"), System.Drawing.Image)
        Me.BtnPatientOperation.Location = New System.Drawing.Point(7, 438)
        Me.BtnPatientOperation.Name = "BtnPatientOperation"
        Me.BtnPatientOperation.Size = New System.Drawing.Size(227, 74)
        Me.BtnPatientOperation.TabIndex = 6
        Me.BtnPatientOperation.Text = "Patient Operation"
        Me.BtnPatientOperation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPatientOperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPatientOperation.UseVisualStyleBackColor = False
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "dd-MM-yyyy"
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(61, 53)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(173, 27)
        Me.DateTo.TabIndex = 31
        '
        'DateFrom
        '
        Me.DateFrom.CustomFormat = "dd-MM-yyyy"
        Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFrom.Location = New System.Drawing.Point(61, 21)
        Me.DateFrom.Name = "DateFrom"
        Me.DateFrom.Size = New System.Drawing.Size(173, 27)
        Me.DateFrom.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(3, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 21)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "To:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(3, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "From:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Report Utility:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnScreeningBook)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPrescribtion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnReferredTEH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPickUP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnPatientOperation)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1498, 938)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 33
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1248, 938)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DashboardReportUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardReportUtility"
        Me.Size = New System.Drawing.Size(1498, 938)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnScreeningBook As System.Windows.Forms.Button
    Friend WithEvents BtnPrescribtion As System.Windows.Forms.Button
    Friend WithEvents BtnReferredTEH As System.Windows.Forms.Button
    Friend WithEvents BtnPickUP As System.Windows.Forms.Button
    Friend WithEvents BtnPatientOperation As System.Windows.Forms.Button
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
