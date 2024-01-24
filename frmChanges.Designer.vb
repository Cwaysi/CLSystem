<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChanges
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.gridChanges = New System.Windows.Forms.DataGridView()
        Me.MaterialSwitch1 = New MaterialSkin.Controls.MaterialSwitch()
        Me.RadToday = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radMonth = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radAll = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnseen = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.lblDescription = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.lblChanges = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.lblyy = New MaterialSkin.Controls.MaterialLabel()
        Me.lblmt = New MaterialSkin.Controls.MaterialLabel()
        Me.lbldt = New MaterialSkin.Controls.MaterialLabel()
        Me.lbltm = New MaterialSkin.Controls.MaterialLabel()
        Me.lblof = New MaterialSkin.Controls.MaterialLabel()
        Me.lblfo = New MaterialSkin.Controls.MaterialLabel()
        Me.radYear = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblac = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSt = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialCard1.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.gridChanges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.lblSt)
        Me.MaterialCard1.Controls.Add(Me.lblac)
        Me.MaterialCard1.Controls.Add(Me.lblfo)
        Me.MaterialCard1.Controls.Add(Me.lblof)
        Me.MaterialCard1.Controls.Add(Me.lbltm)
        Me.MaterialCard1.Controls.Add(Me.lbldt)
        Me.MaterialCard1.Controls.Add(Me.lblmt)
        Me.MaterialCard1.Controls.Add(Me.lblyy)
        Me.MaterialCard1.Controls.Add(Me.btnseen)
        Me.MaterialCard1.Controls.Add(Me.radAll)
        Me.MaterialCard1.Controls.Add(Me.radYear)
        Me.MaterialCard1.Controls.Add(Me.radMonth)
        Me.MaterialCard1.Controls.Add(Me.RadToday)
        Me.MaterialCard1.Controls.Add(Me.MaterialSwitch1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(1253, 57)
        Me.MaterialCard1.TabIndex = 0
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialDivider1.Location = New System.Drawing.Point(3, 121)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(1253, 10)
        Me.MaterialDivider1.TabIndex = 1
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.gridChanges)
        Me.MaterialCard2.Controls.Add(Me.MaterialCard3)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(3, 131)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(1253, 640)
        Me.MaterialCard2.TabIndex = 2
        '
        'gridChanges
        '
        Me.gridChanges.AllowUserToAddRows = False
        Me.gridChanges.AllowUserToDeleteRows = False
        Me.gridChanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridChanges.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridChanges.Location = New System.Drawing.Point(14, 14)
        Me.gridChanges.Name = "gridChanges"
        Me.gridChanges.ReadOnly = True
        Me.gridChanges.Size = New System.Drawing.Size(1225, 466)
        Me.gridChanges.TabIndex = 0
        '
        'MaterialSwitch1
        '
        Me.MaterialSwitch1.AutoSize = True
        Me.MaterialSwitch1.Depth = 0
        Me.MaterialSwitch1.Location = New System.Drawing.Point(14, 14)
        Me.MaterialSwitch1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialSwitch1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialSwitch1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSwitch1.Name = "MaterialSwitch1"
        Me.MaterialSwitch1.Ripple = True
        Me.MaterialSwitch1.Size = New System.Drawing.Size(279, 37)
        Me.MaterialSwitch1.TabIndex = 0
        Me.MaterialSwitch1.Text = "Switch to view unseen changes"
        Me.MaterialSwitch1.UseVisualStyleBackColor = True
        '
        'RadToday
        '
        Me.RadToday.AutoSize = True
        Me.RadToday.Depth = 0
        Me.RadToday.Location = New System.Drawing.Point(362, 13)
        Me.RadToday.Margin = New System.Windows.Forms.Padding(0)
        Me.RadToday.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadToday.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadToday.Name = "RadToday"
        Me.RadToday.Ripple = True
        Me.RadToday.Size = New System.Drawing.Size(80, 37)
        Me.RadToday.TabIndex = 1
        Me.RadToday.TabStop = True
        Me.RadToday.Text = "Today"
        Me.RadToday.UseVisualStyleBackColor = True
        '
        'radMonth
        '
        Me.radMonth.AutoSize = True
        Me.radMonth.Depth = 0
        Me.radMonth.Location = New System.Drawing.Point(446, 14)
        Me.radMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.radMonth.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radMonth.MouseState = MaterialSkin.MouseState.HOVER
        Me.radMonth.Name = "radMonth"
        Me.radMonth.Ripple = True
        Me.radMonth.Size = New System.Drawing.Size(116, 37)
        Me.radMonth.TabIndex = 2
        Me.radMonth.TabStop = True
        Me.radMonth.Text = "This Month"
        Me.radMonth.UseVisualStyleBackColor = True
        '
        'radAll
        '
        Me.radAll.AutoSize = True
        Me.radAll.Depth = 0
        Me.radAll.Location = New System.Drawing.Point(308, 13)
        Me.radAll.Margin = New System.Windows.Forms.Padding(0)
        Me.radAll.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radAll.MouseState = MaterialSkin.MouseState.HOVER
        Me.radAll.Name = "radAll"
        Me.radAll.Ripple = True
        Me.radAll.Size = New System.Drawing.Size(53, 37)
        Me.radAll.TabIndex = 4
        Me.radAll.TabStop = True
        Me.radAll.Text = "All"
        Me.radAll.UseVisualStyleBackColor = True
        '
        'btnseen
        '
        Me.btnseen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnseen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnseen.Depth = 0
        Me.btnseen.HighEmphasis = True
        Me.btnseen.Icon = Nothing
        Me.btnseen.Location = New System.Drawing.Point(1111, 11)
        Me.btnseen.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnseen.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnseen.Name = "btnseen"
        Me.btnseen.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnseen.Size = New System.Drawing.Size(124, 36)
        Me.btnseen.TabIndex = 5
        Me.btnseen.Text = "Mark As Seen"
        Me.btnseen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnseen.UseAccentColor = False
        Me.btnseen.UseVisualStyleBackColor = True
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.lblChanges)
        Me.MaterialCard3.Controls.Add(Me.lblDescription)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(14, 480)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(1225, 146)
        Me.MaterialCard3.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.AnimateReadOnly = False
        Me.lblDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.lblDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lblDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDescription.Depth = 0
        Me.lblDescription.HideSelection = True
        Me.lblDescription.Hint = "Description"
        Me.lblDescription.Location = New System.Drawing.Point(0, 0)
        Me.lblDescription.MaxLength = 32767
        Me.lblDescription.MouseState = MaterialSkin.MouseState.OUT
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblDescription.ReadOnly = True
        Me.lblDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lblDescription.SelectedText = ""
        Me.lblDescription.SelectionLength = 0
        Me.lblDescription.SelectionStart = 0
        Me.lblDescription.ShortcutsEnabled = True
        Me.lblDescription.Size = New System.Drawing.Size(609, 146)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.TabStop = False
        Me.lblDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.lblDescription.UseSystemPasswordChar = False
        '
        'lblChanges
        '
        Me.lblChanges.AnimateReadOnly = False
        Me.lblChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.lblChanges.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lblChanges.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblChanges.Depth = 0
        Me.lblChanges.HideSelection = True
        Me.lblChanges.Hint = "Changes"
        Me.lblChanges.Location = New System.Drawing.Point(615, 0)
        Me.lblChanges.MaxLength = 32767
        Me.lblChanges.MouseState = MaterialSkin.MouseState.OUT
        Me.lblChanges.Name = "lblChanges"
        Me.lblChanges.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblChanges.ReadOnly = True
        Me.lblChanges.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lblChanges.SelectedText = ""
        Me.lblChanges.SelectionLength = 0
        Me.lblChanges.SelectionStart = 0
        Me.lblChanges.ShortcutsEnabled = True
        Me.lblChanges.Size = New System.Drawing.Size(610, 146)
        Me.lblChanges.TabIndex = 1
        Me.lblChanges.TabStop = False
        Me.lblChanges.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.lblChanges.UseSystemPasswordChar = False
        '
        'lblyy
        '
        Me.lblyy.AutoSize = True
        Me.lblyy.Depth = 0
        Me.lblyy.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblyy.Location = New System.Drawing.Point(677, 23)
        Me.lblyy.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblyy.Name = "lblyy"
        Me.lblyy.Size = New System.Drawing.Size(17, 19)
        Me.lblyy.TabIndex = 6
        Me.lblyy.Text = "yy"
        Me.lblyy.Visible = False
        '
        'lblmt
        '
        Me.lblmt.AutoSize = True
        Me.lblmt.Depth = 0
        Me.lblmt.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblmt.Location = New System.Drawing.Point(700, 23)
        Me.lblmt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblmt.Name = "lblmt"
        Me.lblmt.Size = New System.Drawing.Size(20, 19)
        Me.lblmt.TabIndex = 7
        Me.lblmt.Text = "mt"
        Me.lblmt.Visible = False
        '
        'lbldt
        '
        Me.lbldt.AutoSize = True
        Me.lbldt.Depth = 0
        Me.lbldt.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbldt.Location = New System.Drawing.Point(723, 24)
        Me.lbldt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbldt.Name = "lbldt"
        Me.lbldt.Size = New System.Drawing.Size(15, 19)
        Me.lbldt.TabIndex = 8
        Me.lbldt.Text = "dt"
        Me.lbldt.Visible = False
        '
        'lbltm
        '
        Me.lbltm.AutoSize = True
        Me.lbltm.Depth = 0
        Me.lbltm.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbltm.Location = New System.Drawing.Point(746, 24)
        Me.lbltm.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltm.Name = "lbltm"
        Me.lbltm.Size = New System.Drawing.Size(20, 19)
        Me.lbltm.TabIndex = 9
        Me.lbltm.Text = "tm"
        Me.lbltm.Visible = False
        '
        'lblof
        '
        Me.lblof.AutoSize = True
        Me.lblof.Depth = 0
        Me.lblof.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblof.Location = New System.Drawing.Point(769, 24)
        Me.lblof.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblof.Name = "lblof"
        Me.lblof.Size = New System.Drawing.Size(16, 19)
        Me.lblof.TabIndex = 10
        Me.lblof.Text = "of"
        Me.lblof.Visible = False
        '
        'lblfo
        '
        Me.lblfo.AutoSize = True
        Me.lblfo.Depth = 0
        Me.lblfo.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblfo.Location = New System.Drawing.Point(792, 23)
        Me.lblfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblfo.Name = "lblfo"
        Me.lblfo.Size = New System.Drawing.Size(16, 19)
        Me.lblfo.TabIndex = 11
        Me.lblfo.Text = "fo"
        Me.lblfo.Visible = False
        '
        'radYear
        '
        Me.radYear.AutoSize = True
        Me.radYear.Depth = 0
        Me.radYear.Location = New System.Drawing.Point(562, 13)
        Me.radYear.Margin = New System.Windows.Forms.Padding(0)
        Me.radYear.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radYear.MouseState = MaterialSkin.MouseState.HOVER
        Me.radYear.Name = "radYear"
        Me.radYear.Ripple = True
        Me.radYear.Size = New System.Drawing.Size(102, 37)
        Me.radYear.TabIndex = 3
        Me.radYear.TabStop = True
        Me.radYear.Text = "This Year"
        Me.radYear.UseVisualStyleBackColor = True
        '
        'lblac
        '
        Me.lblac.AutoSize = True
        Me.lblac.Depth = 0
        Me.lblac.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblac.Location = New System.Drawing.Point(815, 24)
        Me.lblac.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblac.Name = "lblac"
        Me.lblac.Size = New System.Drawing.Size(18, 19)
        Me.lblac.TabIndex = 12
        Me.lblac.Text = "ac"
        Me.lblac.Visible = False
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Depth = 0
        Me.lblSt.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblSt.Location = New System.Drawing.Point(838, 24)
        Me.lblSt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(14, 19)
        Me.lblSt.TabIndex = 13
        Me.lblSt.Text = "st"
        Me.lblSt.Visible = False
        '
        'frmChanges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 774)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MaterialCard1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChanges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changes Log"
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.gridChanges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents gridChanges As DataGridView
    Friend WithEvents MaterialSwitch1 As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents radMonth As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents RadToday As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radAll As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnseen As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblChanges As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents lblDescription As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents lblSt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblac As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblof As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbltm As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbldt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblmt As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblyy As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents radYear As MaterialSkin.Controls.MaterialRadioButton
End Class
