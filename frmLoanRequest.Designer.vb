<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoanRequest
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
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.txtbranch = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtFirstname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSurname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblser = New MaterialSkin.Controls.MaterialLabel()
        Me.lblserial3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblserial2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblserial = New MaterialSkin.Controls.MaterialLabel()
        Me.txtPerm = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtBusDesc = New System.Windows.Forms.TextBox()
        Me.txtBusLoacation = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtBusName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RadPerMonth = New MaterialSkin.Controls.MaterialRadioButton()
        Me.RadPerWeek = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtSecurity = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtInterest = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtPeriodRepay = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtProInstal = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtLoanPurpose = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtLoanAmount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpone = New System.Windows.Forms.Button()
        Me.picGuarantor1 = New System.Windows.Forms.PictureBox()
        Me.TXTGIDCARD1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cboGIdType1 = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtGOccupation1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtGAddress1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtGTel1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtGFullname1 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUptwo = New System.Windows.Forms.Button()
        Me.picGuarantor2 = New System.Windows.Forms.PictureBox()
        Me.TXTGIDCARD2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cboGIdType2 = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtGOccupation2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtGAddress2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtGTel2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtGFullname2 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.MaterialCard2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picGuarantor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picGuarantor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MaterialCard2.Controls.Add(Me.txtbranch)
        Me.MaterialCard2.Controls.Add(Me.txtFirstname)
        Me.MaterialCard2.Controls.Add(Me.txtSurname)
        Me.MaterialCard2.Controls.Add(Me.txtAccountNo)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(17, 78)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(393, 227)
        Me.MaterialCard2.TabIndex = 71
        '
        'txtbranch
        '
        Me.txtbranch.AnimateReadOnly = False
        Me.txtbranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtbranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtbranch.Depth = 0
        Me.txtbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtbranch.HideSelection = True
        Me.txtbranch.Hint = "Branch"
        Me.txtbranch.LeadingIcon = Nothing
        Me.txtbranch.Location = New System.Drawing.Point(3, 168)
        Me.txtbranch.MaxLength = 32767
        Me.txtbranch.MouseState = MaterialSkin.MouseState.OUT
        Me.txtbranch.Name = "txtbranch"
        Me.txtbranch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbranch.PrefixSuffixText = Nothing
        Me.txtbranch.ReadOnly = True
        Me.txtbranch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbranch.SelectedText = ""
        Me.txtbranch.SelectionLength = 0
        Me.txtbranch.SelectionStart = 0
        Me.txtbranch.ShortcutsEnabled = True
        Me.txtbranch.Size = New System.Drawing.Size(373, 48)
        Me.txtbranch.TabIndex = 93
        Me.txtbranch.TabStop = False
        Me.txtbranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtbranch.TrailingIcon = Nothing
        Me.txtbranch.UseSystemPasswordChar = False
        '
        'txtFirstname
        '
        Me.txtFirstname.AnimateReadOnly = False
        Me.txtFirstname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFirstname.Depth = 0
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFirstname.HideSelection = True
        Me.txtFirstname.Hint = "Firstname"
        Me.txtFirstname.LeadingIcon = Nothing
        Me.txtFirstname.Location = New System.Drawing.Point(3, 114)
        Me.txtFirstname.MaxLength = 32767
        Me.txtFirstname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PrefixSuffixText = Nothing
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.SelectionLength = 0
        Me.txtFirstname.SelectionStart = 0
        Me.txtFirstname.ShortcutsEnabled = True
        Me.txtFirstname.Size = New System.Drawing.Size(373, 48)
        Me.txtFirstname.TabIndex = 92
        Me.txtFirstname.TabStop = False
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFirstname.TrailingIcon = Nothing
        Me.txtFirstname.UseSystemPasswordChar = False
        '
        'txtSurname
        '
        Me.txtSurname.AnimateReadOnly = False
        Me.txtSurname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSurname.Depth = 0
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSurname.HideSelection = True
        Me.txtSurname.Hint = "Surname"
        Me.txtSurname.LeadingIcon = Nothing
        Me.txtSurname.Location = New System.Drawing.Point(3, 60)
        Me.txtSurname.MaxLength = 32767
        Me.txtSurname.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.PrefixSuffixText = Nothing
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.SelectionLength = 0
        Me.txtSurname.SelectionStart = 0
        Me.txtSurname.ShortcutsEnabled = True
        Me.txtSurname.Size = New System.Drawing.Size(373, 48)
        Me.txtSurname.TabIndex = 91
        Me.txtSurname.TabStop = False
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSurname.TrailingIcon = Nothing
        Me.txtSurname.UseSystemPasswordChar = False
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AnimateReadOnly = False
        Me.txtAccountNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtAccountNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAccountNo.Depth = 0
        Me.txtAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAccountNo.HideSelection = True
        Me.txtAccountNo.Hint = "Enter Customer's Account Number"
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(3, 6)
        Me.txtAccountNo.MaxLength = 32767
        Me.txtAccountNo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccountNo.PrefixSuffixText = Nothing
        Me.txtAccountNo.ReadOnly = False
        Me.txtAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAccountNo.SelectedText = ""
        Me.txtAccountNo.SelectionLength = 0
        Me.txtAccountNo.SelectionStart = 0
        Me.txtAccountNo.ShortcutsEnabled = True
        Me.txtAccountNo.Size = New System.Drawing.Size(373, 48)
        Me.txtAccountNo.TabIndex = 90
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccountNo.TrailingIcon = Nothing
        Me.txtAccountNo.UseSystemPasswordChar = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(17, 302)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(618, 380)
        Me.TabControl1.TabIndex = 72
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblser)
        Me.TabPage1.Controls.Add(Me.lblserial3)
        Me.TabPage1.Controls.Add(Me.lblserial2)
        Me.TabPage1.Controls.Add(Me.lblserial)
        Me.TabPage1.Controls.Add(Me.txtPerm)
        Me.TabPage1.Controls.Add(Me.MaterialLabel3)
        Me.TabPage1.Controls.Add(Me.txtBusDesc)
        Me.TabPage1.Controls.Add(Me.txtBusLoacation)
        Me.TabPage1.Controls.Add(Me.txtBusName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(610, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "BUSINESS INFO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblser
        '
        Me.lblser.AutoSize = True
        Me.lblser.Depth = 0
        Me.lblser.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblser.Location = New System.Drawing.Point(481, 155)
        Me.lblser.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblser.Name = "lblser"
        Me.lblser.Size = New System.Drawing.Size(26, 19)
        Me.lblser.TabIndex = 109
        Me.lblser.Text = "seri"
        Me.lblser.Visible = False
        '
        'lblserial3
        '
        Me.lblserial3.AutoSize = True
        Me.lblserial3.Depth = 0
        Me.lblserial3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblserial3.Location = New System.Drawing.Point(449, 155)
        Me.lblserial3.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblserial3.Name = "lblserial3"
        Me.lblserial3.Size = New System.Drawing.Size(26, 19)
        Me.lblserial3.TabIndex = 108
        Me.lblserial3.Text = "seri"
        Me.lblserial3.Visible = False
        '
        'lblserial2
        '
        Me.lblserial2.AutoSize = True
        Me.lblserial2.Depth = 0
        Me.lblserial2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblserial2.Location = New System.Drawing.Point(403, 155)
        Me.lblserial2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblserial2.Name = "lblserial2"
        Me.lblserial2.Size = New System.Drawing.Size(26, 19)
        Me.lblserial2.TabIndex = 107
        Me.lblserial2.Text = "seri"
        Me.lblserial2.Visible = False
        '
        'lblserial
        '
        Me.lblserial.AutoSize = True
        Me.lblserial.Depth = 0
        Me.lblserial.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblserial.Location = New System.Drawing.Point(345, 155)
        Me.lblserial.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblserial.Name = "lblserial"
        Me.lblserial.Size = New System.Drawing.Size(26, 19)
        Me.lblserial.TabIndex = 106
        Me.lblserial.Text = "seri"
        Me.lblserial.Visible = False
        '
        'txtPerm
        '
        Me.txtPerm.AutoSize = True
        Me.txtPerm.Depth = 0
        Me.txtPerm.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPerm.Location = New System.Drawing.Point(275, 155)
        Me.txtPerm.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPerm.Name = "txtPerm"
        Me.txtPerm.Size = New System.Drawing.Size(1, 0)
        Me.txtPerm.TabIndex = 105
        Me.txtPerm.Visible = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(18, 155)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(239, 19)
        Me.MaterialLabel3.TabIndex = 104
        Me.MaterialLabel3.Text = "Description and other information"
        '
        'txtBusDesc
        '
        Me.txtBusDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusDesc.Location = New System.Drawing.Point(16, 177)
        Me.txtBusDesc.Multiline = True
        Me.txtBusDesc.Name = "txtBusDesc"
        Me.txtBusDesc.Size = New System.Drawing.Size(568, 168)
        Me.txtBusDesc.TabIndex = 103
        '
        'txtBusLoacation
        '
        Me.txtBusLoacation.AnimateReadOnly = False
        Me.txtBusLoacation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBusLoacation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusLoacation.Depth = 0
        Me.txtBusLoacation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBusLoacation.HideSelection = True
        Me.txtBusLoacation.Hint = "Enter Customer's Business Location"
        Me.txtBusLoacation.LeadingIcon = Nothing
        Me.txtBusLoacation.Location = New System.Drawing.Point(16, 95)
        Me.txtBusLoacation.MaxLength = 32767
        Me.txtBusLoacation.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBusLoacation.Name = "txtBusLoacation"
        Me.txtBusLoacation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusLoacation.PrefixSuffixText = Nothing
        Me.txtBusLoacation.ReadOnly = False
        Me.txtBusLoacation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBusLoacation.SelectedText = ""
        Me.txtBusLoacation.SelectionLength = 0
        Me.txtBusLoacation.SelectionStart = 0
        Me.txtBusLoacation.ShortcutsEnabled = True
        Me.txtBusLoacation.Size = New System.Drawing.Size(568, 48)
        Me.txtBusLoacation.TabIndex = 92
        Me.txtBusLoacation.TabStop = False
        Me.txtBusLoacation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBusLoacation.TrailingIcon = Nothing
        Me.txtBusLoacation.UseSystemPasswordChar = False
        '
        'txtBusName
        '
        Me.txtBusName.AnimateReadOnly = False
        Me.txtBusName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBusName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusName.Depth = 0
        Me.txtBusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBusName.HideSelection = True
        Me.txtBusName.Hint = "Enter Customer's Business Name"
        Me.txtBusName.LeadingIcon = Nothing
        Me.txtBusName.Location = New System.Drawing.Point(16, 25)
        Me.txtBusName.MaxLength = 32767
        Me.txtBusName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBusName.Name = "txtBusName"
        Me.txtBusName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusName.PrefixSuffixText = Nothing
        Me.txtBusName.ReadOnly = False
        Me.txtBusName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBusName.SelectedText = ""
        Me.txtBusName.SelectionLength = 0
        Me.txtBusName.SelectionStart = 0
        Me.txtBusName.ShortcutsEnabled = True
        Me.txtBusName.Size = New System.Drawing.Size(568, 48)
        Me.txtBusName.TabIndex = 91
        Me.txtBusName.TabStop = False
        Me.txtBusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBusName.TrailingIcon = Nothing
        Me.txtBusName.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RadPerMonth)
        Me.TabPage2.Controls.Add(Me.RadPerWeek)
        Me.TabPage2.Controls.Add(Me.MaterialLabel1)
        Me.TabPage2.Controls.Add(Me.txtSecurity)
        Me.TabPage2.Controls.Add(Me.txtInterest)
        Me.TabPage2.Controls.Add(Me.txtPeriodRepay)
        Me.TabPage2.Controls.Add(Me.txtProInstal)
        Me.TabPage2.Controls.Add(Me.txtLoanPurpose)
        Me.TabPage2.Controls.Add(Me.txtLoanAmount)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(610, 354)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LOAN DETAILS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RadPerMonth
        '
        Me.RadPerMonth.AutoSize = True
        Me.RadPerMonth.Depth = 0
        Me.RadPerMonth.Location = New System.Drawing.Point(479, 193)
        Me.RadPerMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.RadPerMonth.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadPerMonth.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadPerMonth.Name = "RadPerMonth"
        Me.RadPerMonth.Ripple = True
        Me.RadPerMonth.Size = New System.Drawing.Size(89, 37)
        Me.RadPerMonth.TabIndex = 106
        Me.RadPerMonth.TabStop = True
        Me.RadPerMonth.Text = "Months"
        Me.RadPerMonth.UseVisualStyleBackColor = True
        '
        'RadPerWeek
        '
        Me.RadPerWeek.AutoSize = True
        Me.RadPerWeek.Checked = True
        Me.RadPerWeek.Depth = 0
        Me.RadPerWeek.Location = New System.Drawing.Point(381, 193)
        Me.RadPerWeek.Margin = New System.Windows.Forms.Padding(0)
        Me.RadPerWeek.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadPerWeek.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadPerWeek.Name = "RadPerWeek"
        Me.RadPerWeek.Ripple = True
        Me.RadPerWeek.Size = New System.Drawing.Size(81, 37)
        Me.RadPerWeek.TabIndex = 105
        Me.RadPerWeek.TabStop = True
        Me.RadPerWeek.Text = "Weeks"
        Me.RadPerWeek.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(442, 255)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(17, 19)
        Me.MaterialLabel1.TabIndex = 99
        Me.MaterialLabel1.Text = "% "
        '
        'txtSecurity
        '
        Me.txtSecurity.AnimateReadOnly = False
        Me.txtSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtSecurity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSecurity.Depth = 0
        Me.txtSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSecurity.HideSelection = True
        Me.txtSecurity.Hint = "Security/Colataral"
        Me.txtSecurity.LeadingIcon = Nothing
        Me.txtSecurity.Location = New System.Drawing.Point(21, 296)
        Me.txtSecurity.MaxLength = 32767
        Me.txtSecurity.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecurity.PrefixSuffixText = Nothing
        Me.txtSecurity.ReadOnly = False
        Me.txtSecurity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSecurity.SelectedText = ""
        Me.txtSecurity.SelectionLength = 0
        Me.txtSecurity.SelectionStart = 0
        Me.txtSecurity.ShortcutsEnabled = True
        Me.txtSecurity.Size = New System.Drawing.Size(568, 48)
        Me.txtSecurity.TabIndex = 98
        Me.txtSecurity.TabStop = False
        Me.txtSecurity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSecurity.TrailingIcon = Nothing
        Me.txtSecurity.UseSystemPasswordChar = False
        '
        'txtInterest
        '
        Me.txtInterest.AnimateReadOnly = False
        Me.txtInterest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtInterest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtInterest.Depth = 0
        Me.txtInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtInterest.HideSelection = True
        Me.txtInterest.Hint = "Interest Rate"
        Me.txtInterest.LeadingIcon = Nothing
        Me.txtInterest.Location = New System.Drawing.Point(21, 240)
        Me.txtInterest.MaxLength = 32767
        Me.txtInterest.MouseState = MaterialSkin.MouseState.OUT
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInterest.PrefixSuffixText = Nothing
        Me.txtInterest.ReadOnly = False
        Me.txtInterest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInterest.SelectedText = ""
        Me.txtInterest.SelectionLength = 0
        Me.txtInterest.SelectionStart = 0
        Me.txtInterest.ShortcutsEnabled = True
        Me.txtInterest.Size = New System.Drawing.Size(415, 48)
        Me.txtInterest.TabIndex = 97
        Me.txtInterest.TabStop = False
        Me.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtInterest.TrailingIcon = Nothing
        Me.txtInterest.UseSystemPasswordChar = False
        '
        'txtPeriodRepay
        '
        Me.txtPeriodRepay.AnimateReadOnly = False
        Me.txtPeriodRepay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtPeriodRepay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPeriodRepay.Depth = 0
        Me.txtPeriodRepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPeriodRepay.HideSelection = True
        Me.txtPeriodRepay.Hint = "Period Of Repayment"
        Me.txtPeriodRepay.LeadingIcon = Nothing
        Me.txtPeriodRepay.Location = New System.Drawing.Point(21, 186)
        Me.txtPeriodRepay.MaxLength = 32767
        Me.txtPeriodRepay.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPeriodRepay.Name = "txtPeriodRepay"
        Me.txtPeriodRepay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPeriodRepay.PrefixSuffixText = Nothing
        Me.txtPeriodRepay.ReadOnly = False
        Me.txtPeriodRepay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeriodRepay.SelectedText = ""
        Me.txtPeriodRepay.SelectionLength = 0
        Me.txtPeriodRepay.SelectionStart = 0
        Me.txtPeriodRepay.ShortcutsEnabled = True
        Me.txtPeriodRepay.Size = New System.Drawing.Size(332, 48)
        Me.txtPeriodRepay.TabIndex = 96
        Me.txtPeriodRepay.TabStop = False
        Me.txtPeriodRepay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPeriodRepay.TrailingIcon = Nothing
        Me.txtPeriodRepay.UseSystemPasswordChar = False
        '
        'txtProInstal
        '
        Me.txtProInstal.AnimateReadOnly = False
        Me.txtProInstal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtProInstal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtProInstal.Depth = 0
        Me.txtProInstal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtProInstal.HideSelection = True
        Me.txtProInstal.Hint = "Proposed Monthly Installment"
        Me.txtProInstal.LeadingIcon = Nothing
        Me.txtProInstal.Location = New System.Drawing.Point(21, 130)
        Me.txtProInstal.MaxLength = 32767
        Me.txtProInstal.MouseState = MaterialSkin.MouseState.OUT
        Me.txtProInstal.Name = "txtProInstal"
        Me.txtProInstal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProInstal.PrefixSuffixText = Nothing
        Me.txtProInstal.ReadOnly = False
        Me.txtProInstal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProInstal.SelectedText = ""
        Me.txtProInstal.SelectionLength = 0
        Me.txtProInstal.SelectionStart = 0
        Me.txtProInstal.ShortcutsEnabled = True
        Me.txtProInstal.Size = New System.Drawing.Size(568, 48)
        Me.txtProInstal.TabIndex = 95
        Me.txtProInstal.TabStop = False
        Me.txtProInstal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtProInstal.TrailingIcon = Nothing
        Me.txtProInstal.UseSystemPasswordChar = False
        '
        'txtLoanPurpose
        '
        Me.txtLoanPurpose.AnimateReadOnly = False
        Me.txtLoanPurpose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtLoanPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLoanPurpose.Depth = 0
        Me.txtLoanPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLoanPurpose.HideSelection = True
        Me.txtLoanPurpose.Hint = "Purpose Of Loan"
        Me.txtLoanPurpose.LeadingIcon = Nothing
        Me.txtLoanPurpose.Location = New System.Drawing.Point(17, 75)
        Me.txtLoanPurpose.MaxLength = 32767
        Me.txtLoanPurpose.MouseState = MaterialSkin.MouseState.OUT
        Me.txtLoanPurpose.Name = "txtLoanPurpose"
        Me.txtLoanPurpose.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLoanPurpose.PrefixSuffixText = Nothing
        Me.txtLoanPurpose.ReadOnly = False
        Me.txtLoanPurpose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoanPurpose.SelectedText = ""
        Me.txtLoanPurpose.SelectionLength = 0
        Me.txtLoanPurpose.SelectionStart = 0
        Me.txtLoanPurpose.ShortcutsEnabled = True
        Me.txtLoanPurpose.Size = New System.Drawing.Size(568, 48)
        Me.txtLoanPurpose.TabIndex = 94
        Me.txtLoanPurpose.TabStop = False
        Me.txtLoanPurpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLoanPurpose.TrailingIcon = Nothing
        Me.txtLoanPurpose.UseSystemPasswordChar = False
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.AnimateReadOnly = False
        Me.txtLoanAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtLoanAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLoanAmount.Depth = 0
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLoanAmount.HideSelection = True
        Me.txtLoanAmount.Hint = "Loan Amount"
        Me.txtLoanAmount.LeadingIcon = Nothing
        Me.txtLoanAmount.Location = New System.Drawing.Point(17, 19)
        Me.txtLoanAmount.MaxLength = 32767
        Me.txtLoanAmount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLoanAmount.PrefixSuffixText = Nothing
        Me.txtLoanAmount.ReadOnly = False
        Me.txtLoanAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoanAmount.SelectedText = ""
        Me.txtLoanAmount.SelectionLength = 0
        Me.txtLoanAmount.SelectionStart = 0
        Me.txtLoanAmount.ShortcutsEnabled = True
        Me.txtLoanAmount.Size = New System.Drawing.Size(568, 48)
        Me.txtLoanAmount.TabIndex = 93
        Me.txtLoanAmount.TabStop = False
        Me.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLoanAmount.TrailingIcon = Nothing
        Me.txtLoanAmount.UseSystemPasswordChar = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpone)
        Me.GroupBox1.Controls.Add(Me.picGuarantor1)
        Me.GroupBox1.Controls.Add(Me.TXTGIDCARD1)
        Me.GroupBox1.Controls.Add(Me.cboGIdType1)
        Me.GroupBox1.Controls.Add(Me.txtGOccupation1)
        Me.GroupBox1.Controls.Add(Me.txtGAddress1)
        Me.GroupBox1.Controls.Add(Me.txtGTel1)
        Me.GroupBox1.Controls.Add(Me.txtGFullname1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(661, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 282)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guarantor One"
        '
        'btnUpone
        '
        Me.btnUpone.BackColor = System.Drawing.Color.Teal
        Me.btnUpone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpone.Location = New System.Drawing.Point(406, 227)
        Me.btnUpone.Name = "btnUpone"
        Me.btnUpone.Size = New System.Drawing.Size(188, 38)
        Me.btnUpone.TabIndex = 109
        Me.btnUpone.Text = "UPLOAD PICTURE"
        Me.btnUpone.UseVisualStyleBackColor = False
        '
        'picGuarantor1
        '
        Me.picGuarantor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGuarantor1.Location = New System.Drawing.Point(406, 28)
        Me.picGuarantor1.Name = "picGuarantor1"
        Me.picGuarantor1.Size = New System.Drawing.Size(188, 199)
        Me.picGuarantor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGuarantor1.TabIndex = 110
        Me.picGuarantor1.TabStop = False
        '
        'TXTGIDCARD1
        '
        Me.TXTGIDCARD1.AnimateReadOnly = False
        Me.TXTGIDCARD1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXTGIDCARD1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTGIDCARD1.Depth = 0
        Me.TXTGIDCARD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXTGIDCARD1.HideSelection = True
        Me.TXTGIDCARD1.Hint = "ID Number"
        Me.TXTGIDCARD1.LeadingIcon = Nothing
        Me.TXTGIDCARD1.Location = New System.Drawing.Point(199, 218)
        Me.TXTGIDCARD1.MaxLength = 32767
        Me.TXTGIDCARD1.MouseState = MaterialSkin.MouseState.OUT
        Me.TXTGIDCARD1.Name = "TXTGIDCARD1"
        Me.TXTGIDCARD1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTGIDCARD1.PrefixSuffixText = Nothing
        Me.TXTGIDCARD1.ReadOnly = False
        Me.TXTGIDCARD1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXTGIDCARD1.SelectedText = ""
        Me.TXTGIDCARD1.SelectionLength = 0
        Me.TXTGIDCARD1.SelectionStart = 0
        Me.TXTGIDCARD1.ShortcutsEnabled = True
        Me.TXTGIDCARD1.Size = New System.Drawing.Size(201, 48)
        Me.TXTGIDCARD1.TabIndex = 108
        Me.TXTGIDCARD1.TabStop = False
        Me.TXTGIDCARD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTGIDCARD1.TrailingIcon = Nothing
        Me.TXTGIDCARD1.UseSystemPasswordChar = False
        '
        'cboGIdType1
        '
        Me.cboGIdType1.AutoResize = False
        Me.cboGIdType1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGIdType1.Depth = 0
        Me.cboGIdType1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboGIdType1.DropDownHeight = 174
        Me.cboGIdType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGIdType1.DropDownWidth = 121
        Me.cboGIdType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboGIdType1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboGIdType1.FormattingEnabled = True
        Me.cboGIdType1.Hint = "ID Type"
        Me.cboGIdType1.IntegralHeight = False
        Me.cboGIdType1.ItemHeight = 43
        Me.cboGIdType1.Items.AddRange(New Object() {"", "VOTER ID", "GHANA CARD", "DRIVER LICENSE", "SSNIT", "PASSPORT"})
        Me.cboGIdType1.Location = New System.Drawing.Point(6, 217)
        Me.cboGIdType1.MaxDropDownItems = 4
        Me.cboGIdType1.MouseState = MaterialSkin.MouseState.OUT
        Me.cboGIdType1.Name = "cboGIdType1"
        Me.cboGIdType1.Size = New System.Drawing.Size(187, 49)
        Me.cboGIdType1.StartIndex = 0
        Me.cboGIdType1.TabIndex = 107
        '
        'txtGOccupation1
        '
        Me.txtGOccupation1.AnimateReadOnly = False
        Me.txtGOccupation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGOccupation1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGOccupation1.Depth = 0
        Me.txtGOccupation1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGOccupation1.HideSelection = True
        Me.txtGOccupation1.Hint = "Occupation"
        Me.txtGOccupation1.LeadingIcon = Nothing
        Me.txtGOccupation1.Location = New System.Drawing.Point(6, 167)
        Me.txtGOccupation1.MaxLength = 32767
        Me.txtGOccupation1.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGOccupation1.Name = "txtGOccupation1"
        Me.txtGOccupation1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGOccupation1.PrefixSuffixText = Nothing
        Me.txtGOccupation1.ReadOnly = False
        Me.txtGOccupation1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGOccupation1.SelectedText = ""
        Me.txtGOccupation1.SelectionLength = 0
        Me.txtGOccupation1.SelectionStart = 0
        Me.txtGOccupation1.ShortcutsEnabled = True
        Me.txtGOccupation1.Size = New System.Drawing.Size(394, 48)
        Me.txtGOccupation1.TabIndex = 106
        Me.txtGOccupation1.TabStop = False
        Me.txtGOccupation1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGOccupation1.TrailingIcon = Nothing
        Me.txtGOccupation1.UseSystemPasswordChar = False
        '
        'txtGAddress1
        '
        Me.txtGAddress1.AnimateReadOnly = False
        Me.txtGAddress1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGAddress1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGAddress1.Depth = 0
        Me.txtGAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGAddress1.HideSelection = True
        Me.txtGAddress1.Hint = "Address"
        Me.txtGAddress1.LeadingIcon = Nothing
        Me.txtGAddress1.Location = New System.Drawing.Point(6, 117)
        Me.txtGAddress1.MaxLength = 32767
        Me.txtGAddress1.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGAddress1.Name = "txtGAddress1"
        Me.txtGAddress1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGAddress1.PrefixSuffixText = Nothing
        Me.txtGAddress1.ReadOnly = False
        Me.txtGAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGAddress1.SelectedText = ""
        Me.txtGAddress1.SelectionLength = 0
        Me.txtGAddress1.SelectionStart = 0
        Me.txtGAddress1.ShortcutsEnabled = True
        Me.txtGAddress1.Size = New System.Drawing.Size(394, 48)
        Me.txtGAddress1.TabIndex = 105
        Me.txtGAddress1.TabStop = False
        Me.txtGAddress1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGAddress1.TrailingIcon = Nothing
        Me.txtGAddress1.UseSystemPasswordChar = False
        '
        'txtGTel1
        '
        Me.txtGTel1.AnimateReadOnly = False
        Me.txtGTel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGTel1.Depth = 0
        Me.txtGTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGTel1.HideSelection = True
        Me.txtGTel1.Hint = "Telephone"
        Me.txtGTel1.LeadingIcon = Nothing
        Me.txtGTel1.Location = New System.Drawing.Point(6, 67)
        Me.txtGTel1.MaxLength = 32767
        Me.txtGTel1.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGTel1.Name = "txtGTel1"
        Me.txtGTel1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGTel1.PrefixSuffixText = Nothing
        Me.txtGTel1.ReadOnly = False
        Me.txtGTel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGTel1.SelectedText = ""
        Me.txtGTel1.SelectionLength = 0
        Me.txtGTel1.SelectionStart = 0
        Me.txtGTel1.ShortcutsEnabled = True
        Me.txtGTel1.Size = New System.Drawing.Size(394, 48)
        Me.txtGTel1.TabIndex = 104
        Me.txtGTel1.TabStop = False
        Me.txtGTel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGTel1.TrailingIcon = Nothing
        Me.txtGTel1.UseSystemPasswordChar = False
        '
        'txtGFullname1
        '
        Me.txtGFullname1.AnimateReadOnly = False
        Me.txtGFullname1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGFullname1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGFullname1.Depth = 0
        Me.txtGFullname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGFullname1.HideSelection = True
        Me.txtGFullname1.Hint = "Fullname"
        Me.txtGFullname1.LeadingIcon = Nothing
        Me.txtGFullname1.Location = New System.Drawing.Point(6, 17)
        Me.txtGFullname1.MaxLength = 32767
        Me.txtGFullname1.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGFullname1.Name = "txtGFullname1"
        Me.txtGFullname1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGFullname1.PrefixSuffixText = Nothing
        Me.txtGFullname1.ReadOnly = False
        Me.txtGFullname1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGFullname1.SelectedText = ""
        Me.txtGFullname1.SelectionLength = 0
        Me.txtGFullname1.SelectionStart = 0
        Me.txtGFullname1.ShortcutsEnabled = True
        Me.txtGFullname1.Size = New System.Drawing.Size(394, 48)
        Me.txtGFullname1.TabIndex = 103
        Me.txtGFullname1.TabStop = False
        Me.txtGFullname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGFullname1.TrailingIcon = Nothing
        Me.txtGFullname1.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUptwo)
        Me.GroupBox2.Controls.Add(Me.picGuarantor2)
        Me.GroupBox2.Controls.Add(Me.TXTGIDCARD2)
        Me.GroupBox2.Controls.Add(Me.cboGIdType2)
        Me.GroupBox2.Controls.Add(Me.txtGOccupation2)
        Me.GroupBox2.Controls.Add(Me.txtGAddress2)
        Me.GroupBox2.Controls.Add(Me.txtGTel2)
        Me.GroupBox2.Controls.Add(Me.txtGFullname2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(661, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(601, 282)
        Me.GroupBox2.TabIndex = 105
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guarantor Two"
        '
        'btnUptwo
        '
        Me.btnUptwo.BackColor = System.Drawing.Color.Teal
        Me.btnUptwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUptwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUptwo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUptwo.Location = New System.Drawing.Point(406, 227)
        Me.btnUptwo.Name = "btnUptwo"
        Me.btnUptwo.Size = New System.Drawing.Size(188, 38)
        Me.btnUptwo.TabIndex = 109
        Me.btnUptwo.Text = "UPLOAD PICTURE"
        Me.btnUptwo.UseVisualStyleBackColor = False
        '
        'picGuarantor2
        '
        Me.picGuarantor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGuarantor2.Location = New System.Drawing.Point(406, 28)
        Me.picGuarantor2.Name = "picGuarantor2"
        Me.picGuarantor2.Size = New System.Drawing.Size(188, 199)
        Me.picGuarantor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGuarantor2.TabIndex = 110
        Me.picGuarantor2.TabStop = False
        '
        'TXTGIDCARD2
        '
        Me.TXTGIDCARD2.AnimateReadOnly = False
        Me.TXTGIDCARD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXTGIDCARD2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTGIDCARD2.Depth = 0
        Me.TXTGIDCARD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXTGIDCARD2.HideSelection = True
        Me.TXTGIDCARD2.Hint = "ID Number"
        Me.TXTGIDCARD2.LeadingIcon = Nothing
        Me.TXTGIDCARD2.Location = New System.Drawing.Point(199, 218)
        Me.TXTGIDCARD2.MaxLength = 32767
        Me.TXTGIDCARD2.MouseState = MaterialSkin.MouseState.OUT
        Me.TXTGIDCARD2.Name = "TXTGIDCARD2"
        Me.TXTGIDCARD2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTGIDCARD2.PrefixSuffixText = Nothing
        Me.TXTGIDCARD2.ReadOnly = False
        Me.TXTGIDCARD2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXTGIDCARD2.SelectedText = ""
        Me.TXTGIDCARD2.SelectionLength = 0
        Me.TXTGIDCARD2.SelectionStart = 0
        Me.TXTGIDCARD2.ShortcutsEnabled = True
        Me.TXTGIDCARD2.Size = New System.Drawing.Size(201, 48)
        Me.TXTGIDCARD2.TabIndex = 108
        Me.TXTGIDCARD2.TabStop = False
        Me.TXTGIDCARD2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTGIDCARD2.TrailingIcon = Nothing
        Me.TXTGIDCARD2.UseSystemPasswordChar = False
        '
        'cboGIdType2
        '
        Me.cboGIdType2.AutoResize = False
        Me.cboGIdType2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboGIdType2.Depth = 0
        Me.cboGIdType2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboGIdType2.DropDownHeight = 174
        Me.cboGIdType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGIdType2.DropDownWidth = 121
        Me.cboGIdType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboGIdType2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboGIdType2.FormattingEnabled = True
        Me.cboGIdType2.Hint = "ID Type"
        Me.cboGIdType2.IntegralHeight = False
        Me.cboGIdType2.ItemHeight = 43
        Me.cboGIdType2.Items.AddRange(New Object() {"", "VOTER ID", "GHANA CARD", "DRIVER LICENSE", "SSNIT", "PASSPORT"})
        Me.cboGIdType2.Location = New System.Drawing.Point(6, 217)
        Me.cboGIdType2.MaxDropDownItems = 4
        Me.cboGIdType2.MouseState = MaterialSkin.MouseState.OUT
        Me.cboGIdType2.Name = "cboGIdType2"
        Me.cboGIdType2.Size = New System.Drawing.Size(187, 49)
        Me.cboGIdType2.StartIndex = 0
        Me.cboGIdType2.TabIndex = 107
        '
        'txtGOccupation2
        '
        Me.txtGOccupation2.AnimateReadOnly = False
        Me.txtGOccupation2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGOccupation2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGOccupation2.Depth = 0
        Me.txtGOccupation2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGOccupation2.HideSelection = True
        Me.txtGOccupation2.Hint = "Occupation"
        Me.txtGOccupation2.LeadingIcon = Nothing
        Me.txtGOccupation2.Location = New System.Drawing.Point(6, 167)
        Me.txtGOccupation2.MaxLength = 32767
        Me.txtGOccupation2.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGOccupation2.Name = "txtGOccupation2"
        Me.txtGOccupation2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGOccupation2.PrefixSuffixText = Nothing
        Me.txtGOccupation2.ReadOnly = False
        Me.txtGOccupation2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGOccupation2.SelectedText = ""
        Me.txtGOccupation2.SelectionLength = 0
        Me.txtGOccupation2.SelectionStart = 0
        Me.txtGOccupation2.ShortcutsEnabled = True
        Me.txtGOccupation2.Size = New System.Drawing.Size(394, 48)
        Me.txtGOccupation2.TabIndex = 106
        Me.txtGOccupation2.TabStop = False
        Me.txtGOccupation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGOccupation2.TrailingIcon = Nothing
        Me.txtGOccupation2.UseSystemPasswordChar = False
        '
        'txtGAddress2
        '
        Me.txtGAddress2.AnimateReadOnly = False
        Me.txtGAddress2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGAddress2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGAddress2.Depth = 0
        Me.txtGAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGAddress2.HideSelection = True
        Me.txtGAddress2.Hint = "Address"
        Me.txtGAddress2.LeadingIcon = Nothing
        Me.txtGAddress2.Location = New System.Drawing.Point(6, 117)
        Me.txtGAddress2.MaxLength = 32767
        Me.txtGAddress2.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGAddress2.Name = "txtGAddress2"
        Me.txtGAddress2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGAddress2.PrefixSuffixText = Nothing
        Me.txtGAddress2.ReadOnly = False
        Me.txtGAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGAddress2.SelectedText = ""
        Me.txtGAddress2.SelectionLength = 0
        Me.txtGAddress2.SelectionStart = 0
        Me.txtGAddress2.ShortcutsEnabled = True
        Me.txtGAddress2.Size = New System.Drawing.Size(394, 48)
        Me.txtGAddress2.TabIndex = 105
        Me.txtGAddress2.TabStop = False
        Me.txtGAddress2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGAddress2.TrailingIcon = Nothing
        Me.txtGAddress2.UseSystemPasswordChar = False
        '
        'txtGTel2
        '
        Me.txtGTel2.AnimateReadOnly = False
        Me.txtGTel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGTel2.Depth = 0
        Me.txtGTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGTel2.HideSelection = True
        Me.txtGTel2.Hint = "Telephone"
        Me.txtGTel2.LeadingIcon = Nothing
        Me.txtGTel2.Location = New System.Drawing.Point(6, 67)
        Me.txtGTel2.MaxLength = 32767
        Me.txtGTel2.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGTel2.Name = "txtGTel2"
        Me.txtGTel2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGTel2.PrefixSuffixText = Nothing
        Me.txtGTel2.ReadOnly = False
        Me.txtGTel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGTel2.SelectedText = ""
        Me.txtGTel2.SelectionLength = 0
        Me.txtGTel2.SelectionStart = 0
        Me.txtGTel2.ShortcutsEnabled = True
        Me.txtGTel2.Size = New System.Drawing.Size(394, 48)
        Me.txtGTel2.TabIndex = 104
        Me.txtGTel2.TabStop = False
        Me.txtGTel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGTel2.TrailingIcon = Nothing
        Me.txtGTel2.UseSystemPasswordChar = False
        '
        'txtGFullname2
        '
        Me.txtGFullname2.AnimateReadOnly = False
        Me.txtGFullname2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtGFullname2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtGFullname2.Depth = 0
        Me.txtGFullname2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtGFullname2.HideSelection = True
        Me.txtGFullname2.Hint = "Fullname"
        Me.txtGFullname2.LeadingIcon = Nothing
        Me.txtGFullname2.Location = New System.Drawing.Point(6, 17)
        Me.txtGFullname2.MaxLength = 32767
        Me.txtGFullname2.MouseState = MaterialSkin.MouseState.OUT
        Me.txtGFullname2.Name = "txtGFullname2"
        Me.txtGFullname2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGFullname2.PrefixSuffixText = Nothing
        Me.txtGFullname2.ReadOnly = False
        Me.txtGFullname2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGFullname2.SelectedText = ""
        Me.txtGFullname2.SelectionLength = 0
        Me.txtGFullname2.SelectionStart = 0
        Me.txtGFullname2.ShortcutsEnabled = True
        Me.txtGFullname2.Size = New System.Drawing.Size(394, 48)
        Me.txtGFullname2.TabIndex = 103
        Me.txtGFullname2.TabStop = False
        Me.txtGFullname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGFullname2.TrailingIcon = Nothing
        Me.txtGFullname2.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(660, 652)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(280, 19)
        Me.MaterialLabel2.TabIndex = 110
        Me.MaterialLabel2.Text = "NB: Submitted request cannot be edited"
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Global.CLSystem.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(1169, 642)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(94, 36)
        Me.btnClose.TabIndex = 109
        Me.btnClose.Text = "Close"
        Me.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnClose.UseAccentColor = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnclear.Depth = 0
        Me.btnclear.HighEmphasis = True
        Me.btnclear.Icon = Global.CLSystem.My.Resources.Resources.clear
        Me.btnclear.Location = New System.Drawing.Point(1047, 642)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(112, 36)
        Me.btnclear.TabIndex = 108
        Me.btnclear.Text = "Refresh"
        Me.btnclear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnclear.UseAccentColor = False
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Global.CLSystem.My.Resources.Resources.save1
        Me.btnSave.Location = New System.Drawing.Point(954, 642)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 106
        Me.btnSave.Text = "Save"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(416, 67)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(219, 238)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 63
        Me.picCustomer.TabStop = False
        '
        'frmLoanRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 688)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.picCustomer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Request"
        Me.MaterialCard2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picGuarantor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picGuarantor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtbranch As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtFirstname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSurname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtBusLoacation As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBusName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtPeriodRepay As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtProInstal As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtLoanPurpose As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtLoanAmount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtSecurity As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtInterest As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBusDesc As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents RadPerMonth As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents RadPerWeek As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUpone As Button
    Friend WithEvents picGuarantor1 As PictureBox
    Friend WithEvents TXTGIDCARD1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboGIdType1 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtGOccupation1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtGAddress1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtGTel1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtGFullname1 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUptwo As Button
    Friend WithEvents picGuarantor2 As PictureBox
    Friend WithEvents TXTGIDCARD2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboGIdType2 As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtGOccupation2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtGAddress2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtGTel2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtGFullname2 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtPerm As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblserial As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblserial2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblserial3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblser As MaterialSkin.Controls.MaterialLabel
End Class
