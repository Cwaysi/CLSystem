<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCurrentTime = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCurrentDay = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCurrentDate = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblofficer = New MaterialSkin.Controls.MaterialLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialExpansionPanel1 = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.cbobranch = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialSwitch1 = New MaterialSkin.Controls.MaterialSwitch()
        Me.txtTel = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtAddress = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBankName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialExpansionPanel2 = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.lblpriv = New MaterialSkin.Controls.MaterialLabel()
        Me.lblpass = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.EntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndividualWidrawalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanRequestToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoanApprovalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimumBalanceSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountTypeSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BankInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MaterialExpansionPanel1.SuspendLayout()
        Me.MaterialExpansionPanel2.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EntryToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.AdministrationToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 64)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1177, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblpass)
        Me.Panel2.Controls.Add(Me.lblpriv)
        Me.Panel2.Controls.Add(Me.lblCurrentTime)
        Me.Panel2.Controls.Add(Me.MaterialLabel4)
        Me.Panel2.Controls.Add(Me.lblCurrentDay)
        Me.Panel2.Controls.Add(Me.MaterialLabel3)
        Me.Panel2.Controls.Add(Me.lblCurrentDate)
        Me.Panel2.Controls.Add(Me.MaterialLabel2)
        Me.Panel2.Controls.Add(Me.MaterialLabel1)
        Me.Panel2.Controls.Add(Me.lblofficer)
        Me.Panel2.Location = New System.Drawing.Point(21, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 180)
        Me.Panel2.TabIndex = 8
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.AutoSize = True
        Me.lblCurrentTime.Depth = 0
        Me.lblCurrentTime.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCurrentTime.Location = New System.Drawing.Point(69, 134)
        Me.lblCurrentTime.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(45, 19)
        Me.lblCurrentTime.TabIndex = 15
        Me.lblCurrentTime.Text = "Time :"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(18, 135)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(45, 19)
        Me.MaterialLabel4.TabIndex = 14
        Me.MaterialLabel4.Text = "Time :"
        '
        'lblCurrentDay
        '
        Me.lblCurrentDay.AutoSize = True
        Me.lblCurrentDay.Depth = 0
        Me.lblCurrentDay.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCurrentDay.Location = New System.Drawing.Point(70, 101)
        Me.lblCurrentDay.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCurrentDay.Name = "lblCurrentDay"
        Me.lblCurrentDay.Size = New System.Drawing.Size(37, 19)
        Me.lblCurrentDay.TabIndex = 13
        Me.lblCurrentDay.Text = "Day :"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(26, 101)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(37, 19)
        Me.MaterialLabel3.TabIndex = 12
        Me.MaterialLabel3.Text = "Day :"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Depth = 0
        Me.lblCurrentDate.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblCurrentDate.Location = New System.Drawing.Point(70, 67)
        Me.lblCurrentDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(42, 19)
        Me.lblCurrentDate.TabIndex = 11
        Me.lblCurrentDate.Text = "Date :"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(21, 67)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(42, 19)
        Me.MaterialLabel2.TabIndex = 10
        Me.MaterialLabel2.Text = "Date :"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(13, 28)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(74, 19)
        Me.MaterialLabel1.TabIndex = 9
        Me.MaterialLabel1.Text = "Welcome :"
        '
        'lblofficer
        '
        Me.lblofficer.AutoSize = True
        Me.lblofficer.Depth = 0
        Me.lblofficer.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblofficer.Location = New System.Drawing.Point(93, 28)
        Me.lblofficer.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblofficer.Name = "lblofficer"
        Me.lblofficer.Size = New System.Drawing.Size(47, 19)
        Me.lblofficer.TabIndex = 8
        Me.lblofficer.Text = "officer"
        '
        'Timer1
        '
        '
        'MaterialExpansionPanel1
        '
        Me.MaterialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialExpansionPanel1.CancelButtonText = ""
        Me.MaterialExpansionPanel1.Controls.Add(Me.cbobranch)
        Me.MaterialExpansionPanel1.Controls.Add(Me.MaterialSwitch1)
        Me.MaterialExpansionPanel1.Controls.Add(Me.txtTel)
        Me.MaterialExpansionPanel1.Controls.Add(Me.txtAddress)
        Me.MaterialExpansionPanel1.Controls.Add(Me.txtBankName)
        Me.MaterialExpansionPanel1.Controls.Add(Me.Panel2)
        Me.MaterialExpansionPanel1.Depth = 0
        Me.MaterialExpansionPanel1.Description = "View Date, Time and Theme"
        Me.MaterialExpansionPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialExpansionPanel1.ExpandHeight = 555
        Me.MaterialExpansionPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialExpansionPanel1.Location = New System.Drawing.Point(802, 97)
        Me.MaterialExpansionPanel1.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.MaterialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialExpansionPanel1.Name = "MaterialExpansionPanel1"
        Me.MaterialExpansionPanel1.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.MaterialExpansionPanel1.ShowValidationButtons = False
        Me.MaterialExpansionPanel1.Size = New System.Drawing.Size(378, 555)
        Me.MaterialExpansionPanel1.TabIndex = 3
        Me.MaterialExpansionPanel1.Title = "Settings"
        '
        'cbobranch
        '
        Me.cbobranch.AnimateReadOnly = False
        Me.cbobranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cbobranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbobranch.Depth = 0
        Me.cbobranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cbobranch.HideSelection = True
        Me.cbobranch.Hint = "Branch"
        Me.cbobranch.LeadingIcon = Nothing
        Me.cbobranch.Location = New System.Drawing.Point(21, 415)
        Me.cbobranch.MaxLength = 32767
        Me.cbobranch.MouseState = MaterialSkin.MouseState.OUT
        Me.cbobranch.Name = "cbobranch"
        Me.cbobranch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cbobranch.PrefixSuffixText = Nothing
        Me.cbobranch.ReadOnly = True
        Me.cbobranch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbobranch.SelectedText = ""
        Me.cbobranch.SelectionLength = 0
        Me.cbobranch.SelectionStart = 0
        Me.cbobranch.ShortcutsEnabled = True
        Me.cbobranch.Size = New System.Drawing.Size(330, 48)
        Me.cbobranch.TabIndex = 10
        Me.cbobranch.TabStop = False
        Me.cbobranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cbobranch.TrailingIcon = Nothing
        Me.cbobranch.UseSystemPasswordChar = False
        '
        'MaterialSwitch1
        '
        Me.MaterialSwitch1.AutoSize = True
        Me.MaterialSwitch1.Depth = 0
        Me.MaterialSwitch1.Location = New System.Drawing.Point(76, 483)
        Me.MaterialSwitch1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialSwitch1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialSwitch1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSwitch1.Name = "MaterialSwitch1"
        Me.MaterialSwitch1.Ripple = True
        Me.MaterialSwitch1.Size = New System.Drawing.Size(248, 37)
        Me.MaterialSwitch1.TabIndex = 9
        Me.MaterialSwitch1.Text = "SWITCH TO LIGHT THEME"
        Me.MaterialSwitch1.UseVisualStyleBackColor = True
        '
        'txtTel
        '
        Me.txtTel.AnimateReadOnly = False
        Me.txtTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTel.Depth = 0
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtTel.HideSelection = True
        Me.txtTel.Hint = "Telephone"
        Me.txtTel.LeadingIcon = Nothing
        Me.txtTel.Location = New System.Drawing.Point(21, 361)
        Me.txtTel.MaxLength = 32767
        Me.txtTel.MouseState = MaterialSkin.MouseState.OUT
        Me.txtTel.Name = "txtTel"
        Me.txtTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.PrefixSuffixText = Nothing
        Me.txtTel.ReadOnly = True
        Me.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTel.SelectedText = ""
        Me.txtTel.SelectionLength = 0
        Me.txtTel.SelectionStart = 0
        Me.txtTel.ShortcutsEnabled = True
        Me.txtTel.Size = New System.Drawing.Size(330, 48)
        Me.txtTel.TabIndex = 6
        Me.txtTel.TabStop = False
        Me.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTel.TrailingIcon = Nothing
        Me.txtTel.UseSystemPasswordChar = False
        '
        'txtAddress
        '
        Me.txtAddress.AnimateReadOnly = False
        Me.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAddress.Depth = 0
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAddress.HideSelection = True
        Me.txtAddress.Hint = "Address"
        Me.txtAddress.LeadingIcon = Nothing
        Me.txtAddress.Location = New System.Drawing.Point(21, 307)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PrefixSuffixText = Nothing
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(330, 48)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.TabStop = False
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddress.TrailingIcon = Nothing
        Me.txtAddress.UseSystemPasswordChar = False
        '
        'txtBankName
        '
        Me.txtBankName.AnimateReadOnly = False
        Me.txtBankName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBankName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBankName.Depth = 0
        Me.txtBankName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBankName.HideSelection = True
        Me.txtBankName.Hint = "Bank Name"
        Me.txtBankName.LeadingIcon = Nothing
        Me.txtBankName.Location = New System.Drawing.Point(21, 253)
        Me.txtBankName.MaxLength = 32767
        Me.txtBankName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBankName.PrefixSuffixText = Nothing
        Me.txtBankName.ReadOnly = True
        Me.txtBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBankName.SelectedText = ""
        Me.txtBankName.SelectionLength = 0
        Me.txtBankName.SelectionStart = 0
        Me.txtBankName.ShortcutsEnabled = True
        Me.txtBankName.Size = New System.Drawing.Size(330, 48)
        Me.txtBankName.TabIndex = 4
        Me.txtBankName.TabStop = False
        Me.txtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBankName.TrailingIcon = Nothing
        Me.txtBankName.UseSystemPasswordChar = False
        '
        'MaterialExpansionPanel2
        '
        Me.MaterialExpansionPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialExpansionPanel2.Controls.Add(Me.MaterialButton3)
        Me.MaterialExpansionPanel2.Controls.Add(Me.MaterialButton2)
        Me.MaterialExpansionPanel2.Controls.Add(Me.MaterialButton1)
        Me.MaterialExpansionPanel2.Depth = 0
        Me.MaterialExpansionPanel2.Description = "Access Quick Buttons"
        Me.MaterialExpansionPanel2.ExpandHeight = 213
        Me.MaterialExpansionPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialExpansionPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialExpansionPanel2.Location = New System.Drawing.Point(-2, 88)
        Me.MaterialExpansionPanel2.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.MaterialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialExpansionPanel2.Name = "MaterialExpansionPanel2"
        Me.MaterialExpansionPanel2.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.MaterialExpansionPanel2.ShowValidationButtons = False
        Me.MaterialExpansionPanel2.Size = New System.Drawing.Size(173, 213)
        Me.MaterialExpansionPanel2.TabIndex = 5
        Me.MaterialExpansionPanel2.Title = "Quick Buttons"
        Me.MaterialExpansionPanel2.ValidationButtonEnable = True
        '
        'lblpriv
        '
        Me.lblpriv.AutoSize = True
        Me.lblpriv.Depth = 0
        Me.lblpriv.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblpriv.Location = New System.Drawing.Point(93, 3)
        Me.lblpriv.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblpriv.Name = "lblpriv"
        Me.lblpriv.Size = New System.Drawing.Size(27, 19)
        Me.lblpriv.TabIndex = 16
        Me.lblpriv.Text = "priv"
        Me.lblpriv.Visible = False
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Depth = 0
        Me.lblpass.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblpass.Location = New System.Drawing.Point(138, 3)
        Me.lblpass.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(35, 19)
        Me.lblpass.TabIndex = 17
        Me.lblpass.Text = "pass"
        Me.lblpass.Visible = False
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = Global.CLSystem.My.Resources.Resources.balance
        Me.MaterialButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialButton3.Location = New System.Drawing.Point(31, 154)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(115, 36)
        Me.MaterialButton3.TabIndex = 4
        Me.MaterialButton3.Text = "Balance"
        Me.MaterialButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Global.CLSystem.My.Resources.Resources.withdraw
        Me.MaterialButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialButton2.Location = New System.Drawing.Point(13, 109)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(145, 36)
        Me.MaterialButton2.TabIndex = 3
        Me.MaterialButton2.Text = "Withdrawal"
        Me.MaterialButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Global.CLSystem.My.Resources.Resources.deposit
        Me.MaterialButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaterialButton1.Location = New System.Drawing.Point(31, 64)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(109, 36)
        Me.MaterialButton1.TabIndex = 2
        Me.MaterialButton1.Text = "Deposit"
        Me.MaterialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'EntryToolStripMenuItem
        '
        Me.EntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DailyCollectionToolStripMenuItem, Me.IndividualToolStripMenuItem, Me.IndividualWidrawalToolStripMenuItem, Me.LoanRequestToolStripMenuItem, Me.TransactionReportToolStripMenuItem})
        Me.EntryToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.entry
        Me.EntryToolStripMenuItem.Name = "EntryToolStripMenuItem"
        Me.EntryToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.EntryToolStripMenuItem.Text = "Entry"
        '
        'DailyCollectionToolStripMenuItem
        '
        Me.DailyCollectionToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.daily_collection
        Me.DailyCollectionToolStripMenuItem.Name = "DailyCollectionToolStripMenuItem"
        Me.DailyCollectionToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.DailyCollectionToolStripMenuItem.Text = "Daily Collection"
        '
        'IndividualToolStripMenuItem
        '
        Me.IndividualToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.deposit
        Me.IndividualToolStripMenuItem.Name = "IndividualToolStripMenuItem"
        Me.IndividualToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.IndividualToolStripMenuItem.Text = "Individual Deposit"
        '
        'IndividualWidrawalToolStripMenuItem
        '
        Me.IndividualWidrawalToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.withdraw
        Me.IndividualWidrawalToolStripMenuItem.Name = "IndividualWidrawalToolStripMenuItem"
        Me.IndividualWidrawalToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.IndividualWidrawalToolStripMenuItem.Text = "Individual Widrawal"
        '
        'LoanRequestToolStripMenuItem
        '
        Me.LoanRequestToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.loan
        Me.LoanRequestToolStripMenuItem.Name = "LoanRequestToolStripMenuItem"
        Me.LoanRequestToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.LoanRequestToolStripMenuItem.Text = "Loan Payment"
        '
        'TransactionReportToolStripMenuItem
        '
        Me.TransactionReportToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.repot
        Me.TransactionReportToolStripMenuItem.Name = "TransactionReportToolStripMenuItem"
        Me.TransactionReportToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.TransactionReportToolStripMenuItem.Text = "Transaction Report"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.RetrieveToolStripMenuItem, Me.LoanRequestToolStripMenuItem1, Me.IssueLoanToolStripMenuItem, Me.BankStatementToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.customer
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(125, 29)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.customer_register
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(320, 30)
        Me.NewToolStripMenuItem.Text = "Register New Customer"
        '
        'RetrieveToolStripMenuItem
        '
        Me.RetrieveToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.balance
        Me.RetrieveToolStripMenuItem.Name = "RetrieveToolStripMenuItem"
        Me.RetrieveToolStripMenuItem.Size = New System.Drawing.Size(320, 30)
        Me.RetrieveToolStripMenuItem.Text = "Check Customer's Balance"
        '
        'LoanRequestToolStripMenuItem1
        '
        Me.LoanRequestToolStripMenuItem1.Image = Global.CLSystem.My.Resources.Resources.loan
        Me.LoanRequestToolStripMenuItem1.Name = "LoanRequestToolStripMenuItem1"
        Me.LoanRequestToolStripMenuItem1.Size = New System.Drawing.Size(320, 30)
        Me.LoanRequestToolStripMenuItem1.Text = "Loan Request"
        '
        'IssueLoanToolStripMenuItem
        '
        Me.IssueLoanToolStripMenuItem.Name = "IssueLoanToolStripMenuItem"
        Me.IssueLoanToolStripMenuItem.Size = New System.Drawing.Size(320, 30)
        Me.IssueLoanToolStripMenuItem.Text = "Disburse loan"
        '
        'BankStatementToolStripMenuItem
        '
        Me.BankStatementToolStripMenuItem.Name = "BankStatementToolStripMenuItem"
        Me.BankStatementToolStripMenuItem.Size = New System.Drawing.Size(320, 30)
        Me.BankStatementToolStripMenuItem.Text = "Bank Statement"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoanApprovalToolStripMenuItem, Me.CustomersStatusToolStripMenuItem, Me.MinimumBalanceSetupToolStripMenuItem, Me.BranchSetupToolStripMenuItem, Me.AccountTypeSetupToolStripMenuItem, Me.BankInfoToolStripMenuItem, Me.UserSetupToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.admin
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(170, 29)
        Me.AdministrationToolStripMenuItem.Text = "Administration"
        '
        'LoanApprovalToolStripMenuItem
        '
        Me.LoanApprovalToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.loan
        Me.LoanApprovalToolStripMenuItem.Name = "LoanApprovalToolStripMenuItem"
        Me.LoanApprovalToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.LoanApprovalToolStripMenuItem.Text = "Loan Approval"
        '
        'CustomersStatusToolStripMenuItem
        '
        Me.CustomersStatusToolStripMenuItem.Name = "CustomersStatusToolStripMenuItem"
        Me.CustomersStatusToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.CustomersStatusToolStripMenuItem.Text = "Customer's Status"
        '
        'MinimumBalanceSetupToolStripMenuItem
        '
        Me.MinimumBalanceSetupToolStripMenuItem.Name = "MinimumBalanceSetupToolStripMenuItem"
        Me.MinimumBalanceSetupToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.MinimumBalanceSetupToolStripMenuItem.Text = "Minimum Balance Setup"
        '
        'BranchSetupToolStripMenuItem
        '
        Me.BranchSetupToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.branch
        Me.BranchSetupToolStripMenuItem.Name = "BranchSetupToolStripMenuItem"
        Me.BranchSetupToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.BranchSetupToolStripMenuItem.Text = "Branch Setup"
        '
        'AccountTypeSetupToolStripMenuItem
        '
        Me.AccountTypeSetupToolStripMenuItem.Name = "AccountTypeSetupToolStripMenuItem"
        Me.AccountTypeSetupToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.AccountTypeSetupToolStripMenuItem.Text = "Account Type Setup"
        '
        'BankInfoToolStripMenuItem
        '
        Me.BankInfoToolStripMenuItem.Name = "BankInfoToolStripMenuItem"
        Me.BankInfoToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.BankInfoToolStripMenuItem.Text = "Bank Info"
        '
        'UserSetupToolStripMenuItem
        '
        Me.UserSetupToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.user
        Me.UserSetupToolStripMenuItem.Name = "UserSetupToolStripMenuItem"
        Me.UserSetupToolStripMenuItem.Size = New System.Drawing.Size(300, 30)
        Me.UserSetupToolStripMenuItem.Text = "User Setup"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TryToolStripMenuItem})
        Me.ReportToolStripMenuItem.Image = Global.CLSystem.My.Resources.Resources.repot
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(99, 29)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'TryToolStripMenuItem
        '
        Me.TryToolStripMenuItem.Name = "TryToolStripMenuItem"
        Me.TryToolStripMenuItem.Size = New System.Drawing.Size(197, 30)
        Me.TryToolStripMenuItem.Text = "Changes Log"
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.BackgroundImage = Global.CLSystem.My.Resources.Resources.bg
        Me.MaterialCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MaterialCard1.Controls.Add(Me.Panel1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(1177, 588)
        Me.MaterialCard1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CLSystem.My.Resources.Resources.bg
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1149, 560)
        Me.Panel1.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 655)
        Me.Controls.Add(Me.MaterialExpansionPanel1)
        Me.Controls.Add(Me.MaterialExpansionPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRYSTAL BANK SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MaterialExpansionPanel1.ResumeLayout(False)
        Me.MaterialExpansionPanel1.PerformLayout()
        Me.MaterialExpansionPanel2.ResumeLayout(False)
        Me.MaterialExpansionPanel2.PerformLayout()
        Me.MaterialCard1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndividualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanRequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetrieveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanApprovalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BranchSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IndividualWidrawalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialExpansionPanel1 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents MaterialSwitch1 As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialExpansionPanel2 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents LoanRequestToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblofficer As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCurrentTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCurrentDay As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCurrentDate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BankInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimumBalanceSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountTypeSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTel As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBankName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cbobranch As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TransactionReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BankStatementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssueLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblpass As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblpriv As MaterialSkin.Controls.MaterialLabel
End Class
