<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEWTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPENTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVETool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PASTEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FINDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPLACEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DATETIMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.circle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTool, Me.ViewToolStripMenuItem, Me.InsertToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileTool
        '
        Me.FileTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NEWTool, Me.OPENTool, Me.SAVETool, Me.ToolStripSeparator1, Me.EXITTool})
        Me.FileTool.Name = "FileTool"
        Me.FileTool.Size = New System.Drawing.Size(43, 23)
        Me.FileTool.Text = "File"
        '
        'NEWTool
        '
        Me.NEWTool.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEWTool.Name = "NEWTool"
        Me.NEWTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NEWTool.Size = New System.Drawing.Size(173, 24)
        Me.NEWTool.Text = "NEW"
        '
        'OPENTool
        '
        Me.OPENTool.Name = "OPENTool"
        Me.OPENTool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OPENTool.Size = New System.Drawing.Size(148, 22)
        Me.OPENTool.Text = "OPEN"
        '
        'SAVETool
        '
        Me.SAVETool.Name = "SAVETool"
        Me.SAVETool.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVETool.Size = New System.Drawing.Size(148, 22)
        Me.SAVETool.Text = "SAVE"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'EXITTool
        '
        Me.EXITTool.Name = "EXITTool"
        Me.EXITTool.Size = New System.Drawing.Size(148, 22)
        Me.EXITTool.Text = "EXIT"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUTToolStripMenuItem, Me.PASTEToolStripMenuItem1, Me.DELETEToolStripMenuItem, Me.ToolStripSeparator2, Me.FINDToolStripMenuItem, Me.REPLACEToolStripMenuItem, Me.ToolStripTextBox1, Me.ToolStripSeparator3, Me.DATETIMEToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ViewToolStripMenuItem.Text = "Edit"
        '
        'CUTToolStripMenuItem
        '
        Me.CUTToolStripMenuItem.Name = "CUTToolStripMenuItem"
        Me.CUTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CUTToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CUTToolStripMenuItem.Text = "CUT"
        '
        'PASTEToolStripMenuItem1
        '
        Me.PASTEToolStripMenuItem1.Name = "PASTEToolStripMenuItem1"
        Me.PASTEToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PASTEToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.PASTEToolStripMenuItem1.Text = "PASTE"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'FINDToolStripMenuItem
        '
        Me.FINDToolStripMenuItem.Name = "FINDToolStripMenuItem"
        Me.FINDToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FINDToolStripMenuItem.Text = "FIND"
        '
        'REPLACEToolStripMenuItem
        '
        Me.REPLACEToolStripMenuItem.Name = "REPLACEToolStripMenuItem"
        Me.REPLACEToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.REPLACEToolStripMenuItem.Text = "REPLACE"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "GO TO.."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'DATETIMEToolStripMenuItem
        '
        Me.DATETIMEToolStripMenuItem.Name = "DATETIMEToolStripMenuItem"
        Me.DATETIMEToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DATETIMEToolStripMenuItem.Text = "DATE & TIME"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ImagesToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InsertToolStripMenuItem.Text = "Tools"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.circle})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem1.Text = "Shapes"
        '
        'circle
        '
        Me.circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.circle.Image = CType(resources.GetObject("circle.Image"), System.Drawing.Image)
        Me.circle.Name = "circle"
        Me.circle.Size = New System.Drawing.Size(69, 22)
        Me.circle.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ImagesToolStripMenuItem
        '
        Me.ImagesToolStripMenuItem.Name = "ImagesToolStripMenuItem"
        Me.ImagesToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ImagesToolStripMenuItem.Text = "Images"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.Checked = True
        Me.FormatToolStripMenuItem.CheckOnClick = True
        Me.FormatToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.FormatToolStripMenuItem.Text = "View"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "Status Bar"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(750, 461)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(750, 488)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents circle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NEWTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPENTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAVETool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EXITTool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PASTEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FINDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPLACEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DATETIMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
