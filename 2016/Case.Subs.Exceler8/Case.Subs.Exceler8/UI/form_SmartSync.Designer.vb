﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_SmartSync
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_SmartSync))
    Me.GroupBoxFileData = New System.Windows.Forms.GroupBox()
    Me.ComboBoxWorksheets = New System.Windows.Forms.ComboBox()
    Me.LabelExcelTab = New System.Windows.Forms.Label()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.TabControlParameters = New System.Windows.Forms.TabControl()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.DataGridViewInst = New System.Windows.Forms.DataGridView()
    Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.DataGridViewType = New System.Windows.Forms.DataGridView()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ButtonHelp = New System.Windows.Forms.Button()
    Me.ButtonOk = New System.Windows.Forms.Button()
    Me.ButtonCancel = New System.Windows.Forms.Button()
    Me.GroupBoxFileData.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControlParameters.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    CType(Me.DataGridViewInst, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPage2.SuspendLayout()
    CType(Me.DataGridViewType, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBoxFileData
    '
    Me.GroupBoxFileData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBoxFileData.Controls.Add(Me.ComboBoxWorksheets)
    Me.GroupBoxFileData.Controls.Add(Me.LabelExcelTab)
    Me.GroupBoxFileData.Controls.Add(Me.PictureBox1)
    Me.GroupBoxFileData.Location = New System.Drawing.Point(12, 12)
    Me.GroupBoxFileData.Name = "GroupBoxFileData"
    Me.GroupBoxFileData.Size = New System.Drawing.Size(439, 152)
    Me.GroupBoxFileData.TabIndex = 16
    Me.GroupBoxFileData.TabStop = False
    Me.GroupBoxFileData.Text = "Excel Worksheet Selection"
    '
    'ComboBoxWorksheets
    '
    Me.ComboBoxWorksheets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxWorksheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxWorksheets.FormattingEnabled = True
    Me.ComboBoxWorksheets.Location = New System.Drawing.Point(152, 69)
    Me.ComboBoxWorksheets.Name = "ComboBoxWorksheets"
    Me.ComboBoxWorksheets.Size = New System.Drawing.Size(255, 21)
    Me.ComboBoxWorksheets.TabIndex = 4
    '
    'LabelExcelTab
    '
    Me.LabelExcelTab.AutoSize = True
    Me.LabelExcelTab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelExcelTab.Location = New System.Drawing.Point(148, 33)
    Me.LabelExcelTab.Name = "LabelExcelTab"
    Me.LabelExcelTab.Size = New System.Drawing.Size(142, 20)
    Me.LabelExcelTab.TabIndex = 3
    Me.LabelExcelTab.Text = "Worksheet Input"
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = Global.[Case].Subs.Exceler8.My.Resources.Resources.icon_excel
    Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(120, 116)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox1.TabIndex = 2
    Me.PictureBox1.TabStop = False
    '
    'TabControlParameters
    '
    Me.TabControlParameters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TabControlParameters.Controls.Add(Me.TabPage3)
    Me.TabControlParameters.Controls.Add(Me.TabPage1)
    Me.TabControlParameters.Controls.Add(Me.TabPage2)
    Me.TabControlParameters.Location = New System.Drawing.Point(12, 170)
    Me.TabControlParameters.Name = "TabControlParameters"
    Me.TabControlParameters.SelectedIndex = 0
    Me.TabControlParameters.Size = New System.Drawing.Size(439, 286)
    Me.TabControlParameters.TabIndex = 18
    '
    'TabPage3
    '
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Size = New System.Drawing.Size(431, 260)
    Me.TabPage3.TabIndex = 2
    Me.TabPage3.Text = "KEY ID's"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.DataGridViewInst)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(431, 260)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Instance Parameters"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'DataGridViewInst
    '
    Me.DataGridViewInst.AllowUserToAddRows = False
    Me.DataGridViewInst.AllowUserToDeleteRows = False
    Me.DataGridViewInst.AllowUserToResizeRows = False
    Me.DataGridViewInst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridViewInst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewInst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column4})
    Me.DataGridViewInst.Location = New System.Drawing.Point(0, 0)
    Me.DataGridViewInst.Name = "DataGridViewInst"
    Me.DataGridViewInst.RowHeadersVisible = False
    Me.DataGridViewInst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewInst.Size = New System.Drawing.Size(432, 208)
    Me.DataGridViewInst.TabIndex = 13
    '
    'Column2
    '
    Me.Column2.DataPropertyName = "ColumnName"
    Me.Column2.HeaderText = "Name"
    Me.Column2.MinimumWidth = 50
    Me.Column2.Name = "Column2"
    Me.Column2.Width = 175
    '
    'Column4
    '
    Me.Column4.HeaderText = "Group"
    Me.Column4.Name = "Column4"
    Me.Column4.Width = 150
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.DataGridViewType)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(431, 260)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Type Parameters"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'DataGridViewType
    '
    Me.DataGridViewType.AllowUserToAddRows = False
    Me.DataGridViewType.AllowUserToDeleteRows = False
    Me.DataGridViewType.AllowUserToResizeRows = False
    Me.DataGridViewType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridViewType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column5})
    Me.DataGridViewType.Location = New System.Drawing.Point(0, 0)
    Me.DataGridViewType.Name = "DataGridViewType"
    Me.DataGridViewType.RowHeadersVisible = False
    Me.DataGridViewType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.DataGridViewType.Size = New System.Drawing.Size(431, 208)
    Me.DataGridViewType.TabIndex = 16
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "ColumnName"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
    Me.DataGridViewTextBoxColumn1.MinimumWidth = 50
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.Width = 175
    '
    'Column5
    '
    Me.Column5.HeaderText = "Group"
    Me.Column5.Name = "Column5"
    Me.Column5.Width = 150
    '
    'ButtonHelp
    '
    Me.ButtonHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonHelp.Location = New System.Drawing.Point(239, 462)
    Me.ButtonHelp.Name = "ButtonHelp"
    Me.ButtonHelp.Size = New System.Drawing.Size(50, 40)
    Me.ButtonHelp.TabIndex = 21
    Me.ButtonHelp.Text = "?"
    Me.ButtonHelp.UseVisualStyleBackColor = True
    '
    'ButtonOk
    '
    Me.ButtonOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonOk.Location = New System.Drawing.Point(295, 462)
    Me.ButtonOk.Name = "ButtonOk"
    Me.ButtonOk.Size = New System.Drawing.Size(75, 40)
    Me.ButtonOk.TabIndex = 19
    Me.ButtonOk.Text = "Sync"
    Me.ButtonOk.UseVisualStyleBackColor = True
    '
    'ButtonCancel
    '
    Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonCancel.Location = New System.Drawing.Point(376, 462)
    Me.ButtonCancel.Name = "ButtonCancel"
    Me.ButtonCancel.Size = New System.Drawing.Size(75, 40)
    Me.ButtonCancel.TabIndex = 20
    Me.ButtonCancel.Text = "Cancel"
    Me.ButtonCancel.UseVisualStyleBackColor = True
    '
    'form_SmartSync
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(463, 514)
    Me.Controls.Add(Me.ButtonHelp)
    Me.Controls.Add(Me.ButtonOk)
    Me.Controls.Add(Me.ButtonCancel)
    Me.Controls.Add(Me.TabControlParameters)
    Me.Controls.Add(Me.GroupBoxFileData)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "form_SmartSync"
    Me.Text = "Exceler8 Smart Import"
    Me.GroupBoxFileData.ResumeLayout(False)
    Me.GroupBoxFileData.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControlParameters.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    CType(Me.DataGridViewInst, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPage2.ResumeLayout(False)
    CType(Me.DataGridViewType, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBoxFileData As System.Windows.Forms.GroupBox
  Friend WithEvents ComboBoxWorksheets As System.Windows.Forms.ComboBox
  Friend WithEvents LabelExcelTab As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents TabControlParameters As System.Windows.Forms.TabControl
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewInst As System.Windows.Forms.DataGridView
  Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewType As System.Windows.Forms.DataGridView
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ButtonHelp As System.Windows.Forms.Button
  Friend WithEvents ButtonOk As System.Windows.Forms.Button
  Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
