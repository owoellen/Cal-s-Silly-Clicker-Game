<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clicky = New System.Windows.Forms.Button()
        Me.click_count = New System.Windows.Forms.ListBox()
        Me.easter_egg = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InspectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.options = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterSecretCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetClicksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetClicksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoubleClick100ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadrupleClickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OctupleClick1000ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HexadecupleClick5000ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuyToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuotredecupleClick10000ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuyToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.easter_egg.SuspendLayout()
        Me.options.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLICKS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clicky
        '
        Me.clicky.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clicky.Location = New System.Drawing.Point(12, 221)
        Me.clicky.Name = "clicky"
        Me.clicky.Size = New System.Drawing.Size(493, 248)
        Me.clicky.TabIndex = 2
        Me.clicky.Text = "click me!"
        Me.clicky.UseVisualStyleBackColor = True
        '
        'click_count
        '
        Me.click_count.ContextMenuStrip = Me.easter_egg
        Me.click_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.click_count.FormattingEnabled = True
        Me.click_count.ItemHeight = 25
        Me.click_count.Location = New System.Drawing.Point(12, 61)
        Me.click_count.Name = "click_count"
        Me.click_count.Size = New System.Drawing.Size(493, 154)
        Me.click_count.TabIndex = 3
        '
        'easter_egg
        '
        Me.easter_egg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InspectToolStripMenuItem})
        Me.easter_egg.Name = "ContextMenuStrip1"
        Me.easter_egg.Size = New System.Drawing.Size(159, 26)
        '
        'InspectToolStripMenuItem
        '
        Me.InspectToolStripMenuItem.Name = "InspectToolStripMenuItem"
        Me.InspectToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.InspectToolStripMenuItem.Text = "Inspect Element"
        '
        'options
        '
        Me.options.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.UpgradesToolStripMenuItem})
        Me.options.Location = New System.Drawing.Point(0, 0)
        Me.options.Name = "options"
        Me.options.Size = New System.Drawing.Size(517, 24)
        Me.options.TabIndex = 5
        Me.options.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitToolStripMenuItem, Me.EnterSecretCodeToolStripMenuItem, Me.DebugOptionsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Options"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'EnterSecretCodeToolStripMenuItem
        '
        Me.EnterSecretCodeToolStripMenuItem.Name = "EnterSecretCodeToolStripMenuItem"
        Me.EnterSecretCodeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EnterSecretCodeToolStripMenuItem.Text = "Enter Secret Code"
        '
        'DebugOptionsToolStripMenuItem
        '
        Me.DebugOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetClicksToolStripMenuItem, Me.ResetClicksToolStripMenuItem})
        Me.DebugOptionsToolStripMenuItem.Name = "DebugOptionsToolStripMenuItem"
        Me.DebugOptionsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DebugOptionsToolStripMenuItem.Text = "Debug Options"
        Me.DebugOptionsToolStripMenuItem.Visible = False
        '
        'SetClicksToolStripMenuItem
        '
        Me.SetClicksToolStripMenuItem.Name = "SetClicksToolStripMenuItem"
        Me.SetClicksToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SetClicksToolStripMenuItem.Text = "Set Clicks"
        '
        'ResetClicksToolStripMenuItem
        '
        Me.ResetClicksToolStripMenuItem.Name = "ResetClicksToolStripMenuItem"
        Me.ResetClicksToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ResetClicksToolStripMenuItem.Text = "Reset Clicks"
        '
        'UpgradesToolStripMenuItem
        '
        Me.UpgradesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoubleClick100ToolStripMenuItem, Me.QuadrupleClickToolStripMenuItem, Me.OctupleClick1000ToolStripMenuItem, Me.HexadecupleClick5000ToolStripMenuItem, Me.DuotredecupleClick10000ToolStripMenuItem})
        Me.UpgradesToolStripMenuItem.Name = "UpgradesToolStripMenuItem"
        Me.UpgradesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.UpgradesToolStripMenuItem.Text = "Upgrades"
        '
        'DoubleClick100ToolStripMenuItem
        '
        Me.DoubleClick100ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuyToolStripMenuItem})
        Me.DoubleClick100ToolStripMenuItem.Name = "DoubleClick100ToolStripMenuItem"
        Me.DoubleClick100ToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.DoubleClick100ToolStripMenuItem.Text = "Double Click (100)"
        '
        'BuyToolStripMenuItem
        '
        Me.BuyToolStripMenuItem.Name = "BuyToolStripMenuItem"
        Me.BuyToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.BuyToolStripMenuItem.Text = "Buy"
        '
        'QuadrupleClickToolStripMenuItem
        '
        Me.QuadrupleClickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuyToolStripMenuItem1})
        Me.QuadrupleClickToolStripMenuItem.Name = "QuadrupleClickToolStripMenuItem"
        Me.QuadrupleClickToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.QuadrupleClickToolStripMenuItem.Text = "Quadruple Click (500)"
        '
        'BuyToolStripMenuItem1
        '
        Me.BuyToolStripMenuItem1.Name = "BuyToolStripMenuItem1"
        Me.BuyToolStripMenuItem1.Size = New System.Drawing.Size(94, 22)
        Me.BuyToolStripMenuItem1.Text = "Buy"
        '
        'OctupleClick1000ToolStripMenuItem
        '
        Me.OctupleClick1000ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuyToolStripMenuItem2})
        Me.OctupleClick1000ToolStripMenuItem.Name = "OctupleClick1000ToolStripMenuItem"
        Me.OctupleClick1000ToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.OctupleClick1000ToolStripMenuItem.Text = "Octuple Click (1000)"
        '
        'BuyToolStripMenuItem2
        '
        Me.BuyToolStripMenuItem2.Name = "BuyToolStripMenuItem2"
        Me.BuyToolStripMenuItem2.Size = New System.Drawing.Size(94, 22)
        Me.BuyToolStripMenuItem2.Text = "Buy"
        '
        'HexadecupleClick5000ToolStripMenuItem
        '
        Me.HexadecupleClick5000ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuyToolStripMenuItem3})
        Me.HexadecupleClick5000ToolStripMenuItem.Name = "HexadecupleClick5000ToolStripMenuItem"
        Me.HexadecupleClick5000ToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.HexadecupleClick5000ToolStripMenuItem.Text = "Hexadecuple Click (5000)"
        '
        'BuyToolStripMenuItem3
        '
        Me.BuyToolStripMenuItem3.Name = "BuyToolStripMenuItem3"
        Me.BuyToolStripMenuItem3.Size = New System.Drawing.Size(94, 22)
        Me.BuyToolStripMenuItem3.Text = "Buy"
        '
        'DuotredecupleClick10000ToolStripMenuItem
        '
        Me.DuotredecupleClick10000ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuyToolStripMenuItem4})
        Me.DuotredecupleClick10000ToolStripMenuItem.Name = "DuotredecupleClick10000ToolStripMenuItem"
        Me.DuotredecupleClick10000ToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.DuotredecupleClick10000ToolStripMenuItem.Text = "Duotredecuple Click (10000)"
        '
        'BuyToolStripMenuItem4
        '
        Me.BuyToolStripMenuItem4.Name = "BuyToolStripMenuItem4"
        Me.BuyToolStripMenuItem4.Size = New System.Drawing.Size(94, 22)
        Me.BuyToolStripMenuItem4.Text = "Buy"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(517, 481)
        Me.Controls.Add(Me.click_count)
        Me.Controls.Add(Me.clicky)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.options
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Clicker Game"
        Me.easter_egg.ResumeLayout(False)
        Me.options.ResumeLayout(False)
        Me.options.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents clicky As Button
    Friend WithEvents click_count As ListBox
    Friend WithEvents options As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoubleClick100ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadrupleClickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OctupleClick1000ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuyToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HexadecupleClick5000ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuyToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents DuotredecupleClick10000ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuyToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents easter_egg As ContextMenuStrip
    Friend WithEvents InspectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetClicksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetClicksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterSecretCodeToolStripMenuItem As ToolStripMenuItem
End Class
