<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXCELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExealFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelMinqd = New System.Windows.Forms.Label()
        Me.LabelMaxqd = New System.Windows.Forms.Label()
        Me.LabelTestType = New System.Windows.Forms.Label()
        Me.LabelTestDate = New System.Windows.Forms.Label()
        Me.LabelTestName = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem, Me.DrawingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1191, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTestToolStripMenuItem, Me.OpenTestToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExportToolStripMenuItem, Me.ImportToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewTestToolStripMenuItem
        '
        Me.NewTestToolStripMenuItem.Name = "NewTestToolStripMenuItem"
        Me.NewTestToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.NewTestToolStripMenuItem.Text = "New"
        '
        'OpenTestToolStripMenuItem
        '
        Me.OpenTestToolStripMenuItem.Name = "OpenTestToolStripMenuItem"
        Me.OpenTestToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.OpenTestToolStripMenuItem.Text = "Open "
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(164, 6)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PDFToolStripMenuItem, Me.PNGToolStripMenuItem, Me.EXCELToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ExportToolStripMenuItem.Text = "Export test "
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.PNGToolStripMenuItem.Text = "PNG"
        '
        'EXCELToolStripMenuItem
        '
        Me.EXCELToolStripMenuItem.Name = "EXCELToolStripMenuItem"
        Me.EXCELToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.EXCELToolStripMenuItem.Text = "EXCEL"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ImportToolStripMenuItem.Text = "Import "
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestInfoToolStripMenuItem, Me.DeviceInfoToolStripMenuItem, Me.InputToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'TestInfoToolStripMenuItem
        '
        Me.TestInfoToolStripMenuItem.Name = "TestInfoToolStripMenuItem"
        Me.TestInfoToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.TestInfoToolStripMenuItem.Text = "Test info"
        '
        'DeviceInfoToolStripMenuItem
        '
        Me.DeviceInfoToolStripMenuItem.Name = "DeviceInfoToolStripMenuItem"
        Me.DeviceInfoToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.DeviceInfoToolStripMenuItem.Text = "Device"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectToolStripMenuItem, Me.ExealFileToolStripMenuItem})
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.InputToolStripMenuItem.Text = "Input Data"
        '
        'DirectToolStripMenuItem
        '
        Me.DirectToolStripMenuItem.Name = "DirectToolStripMenuItem"
        Me.DirectToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.DirectToolStripMenuItem.Text = "Direct"
        '
        'ExealFileToolStripMenuItem
        '
        Me.ExealFileToolStripMenuItem.Name = "ExealFileToolStripMenuItem"
        Me.ExealFileToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ExealFileToolStripMenuItem.Text = "Exeal file"
        '
        'DrawingsToolStripMenuItem
        '
        Me.DrawingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LayersToolStripMenuItem})
        Me.DrawingsToolStripMenuItem.Name = "DrawingsToolStripMenuItem"
        Me.DrawingsToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.DrawingsToolStripMenuItem.Text = "Drawings"
        '
        'LayersToolStripMenuItem
        '
        Me.LayersToolStripMenuItem.Name = "LayersToolStripMenuItem"
        Me.LayersToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.LayersToolStripMenuItem.Text = "Layers"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.LabelMinqd)
        Me.GroupBox1.Controls.Add(Me.LabelMaxqd)
        Me.GroupBox1.Controls.Add(Me.LabelTestType)
        Me.GroupBox1.Controls.Add(Me.LabelTestDate)
        Me.GroupBox1.Controls.Add(Me.LabelTestName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 430)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Data"
        '
        'LabelMinqd
        '
        Me.LabelMinqd.AutoSize = True
        Me.LabelMinqd.Location = New System.Drawing.Point(28, 168)
        Me.LabelMinqd.Name = "LabelMinqd"
        Me.LabelMinqd.Size = New System.Drawing.Size(81, 17)
        Me.LabelMinqd.TabIndex = 4
        Me.LabelMinqd.Text = "LabelMinqd"
        '
        'LabelMaxqd
        '
        Me.LabelMaxqd.AutoSize = True
        Me.LabelMaxqd.Location = New System.Drawing.Point(28, 134)
        Me.LabelMaxqd.Name = "LabelMaxqd"
        Me.LabelMaxqd.Size = New System.Drawing.Size(84, 17)
        Me.LabelMaxqd.TabIndex = 3
        Me.LabelMaxqd.Text = "LabelMaxqd"
        '
        'LabelTestType
        '
        Me.LabelTestType.AutoSize = True
        Me.LabelTestType.Location = New System.Drawing.Point(28, 102)
        Me.LabelTestType.Name = "LabelTestType"
        Me.LabelTestType.Size = New System.Drawing.Size(103, 17)
        Me.LabelTestType.TabIndex = 2
        Me.LabelTestType.Text = "LabelTestType"
        '
        'LabelTestDate
        '
        Me.LabelTestDate.AutoSize = True
        Me.LabelTestDate.Location = New System.Drawing.Point(28, 71)
        Me.LabelTestDate.Name = "LabelTestDate"
        Me.LabelTestDate.Size = New System.Drawing.Size(101, 17)
        Me.LabelTestDate.TabIndex = 1
        Me.LabelTestDate.Text = "LabelTestDate"
        '
        'LabelTestName
        '
        Me.LabelTestName.AutoSize = True
        Me.LabelTestName.Location = New System.Drawing.Point(28, 41)
        Me.LabelTestName.Name = "LabelTestName"
        Me.LabelTestName.Size = New System.Drawing.Size(108, 17)
        Me.LabelTestName.TabIndex = 0
        Me.LabelTestName.Text = "LabelTestName"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(212, 218)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.RichTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 476)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 245)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notes"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(939, 71)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(240, 681)
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PictureBox7.Location = New System.Drawing.Point(939, 39)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(240, 34)
        Me.PictureBox7.TabIndex = 11
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PictureBox8.Location = New System.Drawing.Point(939, 693)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(240, 35)
        Me.PictureBox8.TabIndex = 12
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(245, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(677, 681)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(833, 680)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1191, 733)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "DPT"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelTestName As Label
    Friend WithEvents PDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExealFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelMinqd As Label
    Friend WithEvents LabelMaxqd As Label
    Friend WithEvents LabelTestType As Label
    Friend WithEvents LabelTestDate As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DrawingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LayersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXCELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
