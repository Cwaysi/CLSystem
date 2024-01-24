<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWithdrawal
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PicSign = New System.Windows.Forms.PictureBox()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.expReason = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.ChkEdit = New MaterialSkin.Controls.MaterialCheckbox()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.txtbranch = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtFirstname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSurname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cboType = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtFormNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TXTIDCARD = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cboIdType = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtWitdName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnEdit = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.txtAmount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.RadSelf = New MaterialSkin.Controls.MaterialRadioButton()
        Me.RadOther = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblActCheck = New System.Windows.Forms.Label()
        Me.lblNewBalance = New System.Windows.Forms.Label()
        Me.lblTamount = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblChBalance = New System.Windows.Forms.Label()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.lblAvailableBalance = New MaterialSkin.Controls.MaterialTextBox2()
        Me.lblTotalBalance = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.lblAccType = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.lblmobile = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicSign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        Me.expReason.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PicSign)
        Me.GroupBox2.Controls.Add(Me.picCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 624)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(82, 600)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 19)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Customer's Signature"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(97, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 19)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Customer's Picture"
        '
        'PicSign
        '
        Me.PicSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicSign.Location = New System.Drawing.Point(25, 315)
        Me.PicSign.Name = "PicSign"
        Me.PicSign.Size = New System.Drawing.Size(254, 278)
        Me.PicSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSign.TabIndex = 63
        Me.PicSign.TabStop = False
        '
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(25, 12)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(254, 278)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 62
        Me.picCustomer.TabStop = False
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.GroupBox2)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(863, 64)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(314, 699)
        Me.MaterialCard1.TabIndex = 67
        '
        'expReason
        '
        Me.expReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expReason.CancelButtonText = ""
        Me.expReason.Controls.Add(Me.MaterialLabel2)
        Me.expReason.Controls.Add(Me.MaterialLabel1)
        Me.expReason.Controls.Add(Me.DateTimePicker1)
        Me.expReason.Controls.Add(Me.txtChange)
        Me.expReason.Depth = 0
        Me.expReason.Description = ""
        Me.expReason.ExpandHeight = 229
        Me.expReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.expReason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expReason.Location = New System.Drawing.Point(433, 68)
        Me.expReason.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.expReason.MouseState = MaterialSkin.MouseState.HOVER
        Me.expReason.Name = "expReason"
        Me.expReason.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.expReason.ShowValidationButtons = False
        Me.expReason.Size = New System.Drawing.Size(378, 229)
        Me.expReason.TabIndex = 68
        Me.expReason.Title = "Reasons For Changes"
        Me.expReason.ValidationButtonEnable = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(7, 58)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(165, 19)
        Me.MaterialLabel2.TabIndex = 85
        Me.MaterialLabel2.Text = "Select withdrawal date:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(7, 93)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(58, 19)
        Me.MaterialLabel1.TabIndex = 84
        Me.MaterialLabel1.Text = "Reason:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(188, 27)
        Me.DateTimePicker1.TabIndex = 83
        '
        'txtChange
        '
        Me.txtChange.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChange.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(65, 93)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(301, 130)
        Me.txtChange.TabIndex = 82
        '
        'ChkEdit
        '
        Me.ChkEdit.AutoSize = True
        Me.ChkEdit.Depth = 0
        Me.ChkEdit.Location = New System.Drawing.Point(22, 80)
        Me.ChkEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.ChkEdit.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.ChkEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.ChkEdit.Name = "ChkEdit"
        Me.ChkEdit.ReadOnly = False
        Me.ChkEdit.Ripple = True
        Me.ChkEdit.Size = New System.Drawing.Size(358, 37)
        Me.ChkEdit.TabIndex = 69
        Me.ChkEdit.Text = "Please select to edit today's customer Deposit"
        Me.ChkEdit.UseVisualStyleBackColor = True
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
        Me.MaterialCard2.Location = New System.Drawing.Point(17, 118)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(538, 235)
        Me.MaterialCard2.TabIndex = 70
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
        Me.txtbranch.Size = New System.Drawing.Size(523, 48)
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
        Me.txtFirstname.Size = New System.Drawing.Size(523, 48)
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
        Me.txtSurname.Size = New System.Drawing.Size(523, 48)
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
        Me.txtAccountNo.Size = New System.Drawing.Size(523, 48)
        Me.txtAccountNo.TabIndex = 90
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccountNo.TrailingIcon = Nothing
        Me.txtAccountNo.UseSystemPasswordChar = False
        '
        'cboType
        '
        Me.cboType.AutoResize = False
        Me.cboType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboType.Depth = 0
        Me.cboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboType.DropDownHeight = 174
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.DropDownWidth = 121
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Hint = "Withdrawal Form Type"
        Me.cboType.IntegralHeight = False
        Me.cboType.ItemHeight = 43
        Me.cboType.Items.AddRange(New Object() {"", "DEBIT FORM", "CHEQUE FORM"})
        Me.cboType.Location = New System.Drawing.Point(6, 361)
        Me.cboType.MaxDropDownItems = 4
        Me.cboType.MouseState = MaterialSkin.MouseState.OUT
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(244, 49)
        Me.cboType.StartIndex = 0
        Me.cboType.TabIndex = 71
        '
        'txtFormNo
        '
        Me.txtFormNo.AnimateReadOnly = False
        Me.txtFormNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtFormNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFormNo.Depth = 0
        Me.txtFormNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFormNo.HideSelection = True
        Me.txtFormNo.Hint = "Enter Form Number"
        Me.txtFormNo.LeadingIcon = Nothing
        Me.txtFormNo.Location = New System.Drawing.Point(256, 362)
        Me.txtFormNo.MaxLength = 32767
        Me.txtFormNo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFormNo.Name = "txtFormNo"
        Me.txtFormNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFormNo.PrefixSuffixText = Nothing
        Me.txtFormNo.ReadOnly = False
        Me.txtFormNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFormNo.SelectedText = ""
        Me.txtFormNo.SelectionLength = 0
        Me.txtFormNo.SelectionStart = 0
        Me.txtFormNo.ShortcutsEnabled = True
        Me.txtFormNo.Size = New System.Drawing.Size(319, 48)
        Me.txtFormNo.TabIndex = 94
        Me.txtFormNo.TabStop = False
        Me.txtFormNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFormNo.TrailingIcon = Nothing
        Me.txtFormNo.UseSystemPasswordChar = False
        '
        'TXTIDCARD
        '
        Me.TXTIDCARD.AnimateReadOnly = False
        Me.TXTIDCARD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TXTIDCARD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTIDCARD.Depth = 0
        Me.TXTIDCARD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TXTIDCARD.HideSelection = True
        Me.TXTIDCARD.Hint = "ID Number"
        Me.TXTIDCARD.LeadingIcon = Nothing
        Me.TXTIDCARD.Location = New System.Drawing.Point(535, 417)
        Me.TXTIDCARD.MaxLength = 32767
        Me.TXTIDCARD.MouseState = MaterialSkin.MouseState.OUT
        Me.TXTIDCARD.Name = "TXTIDCARD"
        Me.TXTIDCARD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTIDCARD.PrefixSuffixText = Nothing
        Me.TXTIDCARD.ReadOnly = False
        Me.TXTIDCARD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXTIDCARD.SelectedText = ""
        Me.TXTIDCARD.SelectionLength = 0
        Me.TXTIDCARD.SelectionStart = 0
        Me.TXTIDCARD.ShortcutsEnabled = True
        Me.TXTIDCARD.Size = New System.Drawing.Size(276, 48)
        Me.TXTIDCARD.TabIndex = 98
        Me.TXTIDCARD.TabStop = False
        Me.TXTIDCARD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTIDCARD.TrailingIcon = Nothing
        Me.TXTIDCARD.UseSystemPasswordChar = False
        '
        'cboIdType
        '
        Me.cboIdType.AutoResize = False
        Me.cboIdType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboIdType.Depth = 0
        Me.cboIdType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboIdType.DropDownHeight = 174
        Me.cboIdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdType.DropDownWidth = 121
        Me.cboIdType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboIdType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboIdType.FormattingEnabled = True
        Me.cboIdType.Hint = "ID Type"
        Me.cboIdType.IntegralHeight = False
        Me.cboIdType.ItemHeight = 43
        Me.cboIdType.Items.AddRange(New Object() {"", "VOTER ID", "GHANA CARD", "DRIVER LICENSE", "SSNIT", "PASSPORT"})
        Me.cboIdType.Location = New System.Drawing.Point(331, 416)
        Me.cboIdType.MaxDropDownItems = 4
        Me.cboIdType.MouseState = MaterialSkin.MouseState.OUT
        Me.cboIdType.Name = "cboIdType"
        Me.cboIdType.Size = New System.Drawing.Size(199, 49)
        Me.cboIdType.StartIndex = 0
        Me.cboIdType.TabIndex = 97
        '
        'txtWitdName
        '
        Me.txtWitdName.AnimateReadOnly = False
        Me.txtWitdName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtWitdName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWitdName.Depth = 0
        Me.txtWitdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtWitdName.HideSelection = True
        Me.txtWitdName.Hint = "Withdrawer Fullname"
        Me.txtWitdName.LeadingIcon = Nothing
        Me.txtWitdName.Location = New System.Drawing.Point(6, 416)
        Me.txtWitdName.MaxLength = 32767
        Me.txtWitdName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtWitdName.Name = "txtWitdName"
        Me.txtWitdName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWitdName.PrefixSuffixText = Nothing
        Me.txtWitdName.ReadOnly = False
        Me.txtWitdName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWitdName.SelectedText = ""
        Me.txtWitdName.SelectionLength = 0
        Me.txtWitdName.SelectionStart = 0
        Me.txtWitdName.ShortcutsEnabled = True
        Me.txtWitdName.Size = New System.Drawing.Size(319, 48)
        Me.txtWitdName.TabIndex = 99
        Me.txtWitdName.TabStop = False
        Me.txtWitdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtWitdName.TrailingIcon = Nothing
        Me.txtWitdName.UseSystemPasswordChar = False
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.btnClose)
        Me.MaterialCard3.Controls.Add(Me.btnclear)
        Me.MaterialCard3.Controls.Add(Me.btnEdit)
        Me.MaterialCard3.Controls.Add(Me.btnSave)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(535, 540)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(276, 152)
        Me.MaterialCard3.TabIndex = 100
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Global.CLSystem.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(141, 106)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(94, 36)
        Me.btnClose.TabIndex = 3
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
        Me.btnclear.Location = New System.Drawing.Point(39, 106)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(94, 36)
        Me.btnclear.TabIndex = 2
        Me.btnclear.Text = "Clear"
        Me.btnclear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnclear.UseAccentColor = False
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnEdit.Depth = 0
        Me.btnEdit.HighEmphasis = True
        Me.btnEdit.Icon = Global.CLSystem.My.Resources.Resources.update
        Me.btnEdit.Location = New System.Drawing.Point(62, 58)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnEdit.Size = New System.Drawing.Size(157, 36)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Save Changes"
        Me.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEdit.UseAccentColor = False
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Global.CLSystem.My.Resources.Resources.save1
        Me.btnSave.Location = New System.Drawing.Point(97, 10)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.AnimateReadOnly = False
        Me.txtAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAmount.Depth = 0
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAmount.HideSelection = True
        Me.txtAmount.Hint = "Amount"
        Me.txtAmount.LeadingIcon = Nothing
        Me.txtAmount.Location = New System.Drawing.Point(535, 473)
        Me.txtAmount.MaxLength = 32767
        Me.txtAmount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.PrefixSuffixText = Nothing
        Me.txtAmount.ReadOnly = False
        Me.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.SelectionLength = 0
        Me.txtAmount.SelectionStart = 0
        Me.txtAmount.ShortcutsEnabled = True
        Me.txtAmount.Size = New System.Drawing.Size(276, 48)
        Me.txtAmount.TabIndex = 101
        Me.txtAmount.TabStop = False
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAmount.TrailingIcon = Nothing
        Me.txtAmount.UseSystemPasswordChar = False
        '
        'txtDesc
        '
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(17, 496)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(501, 196)
        Me.txtDesc.TabIndex = 102
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(19, 471)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(239, 19)
        Me.MaterialLabel3.TabIndex = 86
        Me.MaterialLabel3.Text = "Description and other information"
        '
        'RadSelf
        '
        Me.RadSelf.AutoSize = True
        Me.RadSelf.Depth = 0
        Me.RadSelf.Location = New System.Drawing.Point(590, 367)
        Me.RadSelf.Margin = New System.Windows.Forms.Padding(0)
        Me.RadSelf.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadSelf.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadSelf.Name = "RadSelf"
        Me.RadSelf.Ripple = True
        Me.RadSelf.Size = New System.Drawing.Size(85, 37)
        Me.RadSelf.TabIndex = 103
        Me.RadSelf.TabStop = True
        Me.RadSelf.Text = "By Self"
        Me.RadSelf.UseVisualStyleBackColor = True
        '
        'RadOther
        '
        Me.RadOther.AutoSize = True
        Me.RadOther.Depth = 0
        Me.RadOther.Location = New System.Drawing.Point(682, 367)
        Me.RadOther.Margin = New System.Windows.Forms.Padding(0)
        Me.RadOther.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RadOther.MouseState = MaterialSkin.MouseState.HOVER
        Me.RadOther.Name = "RadOther"
        Me.RadOther.Ripple = True
        Me.RadOther.Size = New System.Drawing.Size(95, 37)
        Me.RadOther.TabIndex = 104
        Me.RadOther.TabStop = True
        Me.RadOther.Text = "By Other"
        Me.RadOther.UseVisualStyleBackColor = True
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.ForeColor = System.Drawing.Color.Black
        Me.lblActive.Location = New System.Drawing.Point(460, 469)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(38, 25)
        Me.lblActive.TabIndex = 86
        Me.lblActive.Text = "act"
        Me.lblActive.Visible = False
        '
        'lblActCheck
        '
        Me.lblActCheck.AutoSize = True
        Me.lblActCheck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActCheck.ForeColor = System.Drawing.Color.Orange
        Me.lblActCheck.Location = New System.Drawing.Point(55, 68)
        Me.lblActCheck.Name = "lblActCheck"
        Me.lblActCheck.Size = New System.Drawing.Size(337, 19)
        Me.lblActCheck.TabIndex = 105
        Me.lblActCheck.Text = "This Customer is not ACTIVE please contact manager"
        '
        'lblNewBalance
        '
        Me.lblNewBalance.AutoSize = True
        Me.lblNewBalance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewBalance.ForeColor = System.Drawing.Color.Black
        Me.lblNewBalance.Location = New System.Drawing.Point(266, 627)
        Me.lblNewBalance.Name = "lblNewBalance"
        Me.lblNewBalance.Size = New System.Drawing.Size(94, 25)
        Me.lblNewBalance.TabIndex = 109
        Me.lblNewBalance.Text = "Amount :"
        Me.lblNewBalance.Visible = False
        '
        'lblTamount
        '
        Me.lblTamount.AutoSize = True
        Me.lblTamount.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTamount.ForeColor = System.Drawing.Color.Black
        Me.lblTamount.Location = New System.Drawing.Point(259, 547)
        Me.lblTamount.Name = "lblTamount"
        Me.lblTamount.Size = New System.Drawing.Size(111, 25)
        Me.lblTamount.TabIndex = 108
        Me.lblTamount.Text = "lblTamount"
        Me.lblTamount.Visible = False
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Black
        Me.lblBalance.Location = New System.Drawing.Point(266, 510)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(112, 25)
        Me.lblBalance.TabIndex = 107
        Me.lblBalance.Text = "lblbalannce"
        Me.lblBalance.Visible = False
        '
        'lblChBalance
        '
        Me.lblChBalance.AutoSize = True
        Me.lblChBalance.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChBalance.ForeColor = System.Drawing.Color.Black
        Me.lblChBalance.Location = New System.Drawing.Point(341, 534)
        Me.lblChBalance.Name = "lblChBalance"
        Me.lblChBalance.Size = New System.Drawing.Size(130, 25)
        Me.lblChBalance.TabIndex = 106
        Me.lblChBalance.Text = "lblChBalance"
        Me.lblChBalance.Visible = False
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.lblAvailableBalance)
        Me.MaterialCard4.Controls.Add(Me.lblTotalBalance)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(561, 153)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(264, 135)
        Me.MaterialCard4.TabIndex = 101
        '
        'lblAvailableBalance
        '
        Me.lblAvailableBalance.AnimateReadOnly = False
        Me.lblAvailableBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.lblAvailableBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lblAvailableBalance.Depth = 0
        Me.lblAvailableBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblAvailableBalance.HideSelection = True
        Me.lblAvailableBalance.Hint = "Available Balance"
        Me.lblAvailableBalance.LeadingIcon = Nothing
        Me.lblAvailableBalance.Location = New System.Drawing.Point(7, 73)
        Me.lblAvailableBalance.MaxLength = 32767
        Me.lblAvailableBalance.MouseState = MaterialSkin.MouseState.OUT
        Me.lblAvailableBalance.Name = "lblAvailableBalance"
        Me.lblAvailableBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblAvailableBalance.PrefixSuffixText = Nothing
        Me.lblAvailableBalance.ReadOnly = True
        Me.lblAvailableBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAvailableBalance.SelectedText = ""
        Me.lblAvailableBalance.SelectionLength = 0
        Me.lblAvailableBalance.SelectionStart = 0
        Me.lblAvailableBalance.ShortcutsEnabled = True
        Me.lblAvailableBalance.Size = New System.Drawing.Size(251, 48)
        Me.lblAvailableBalance.TabIndex = 95
        Me.lblAvailableBalance.TabStop = False
        Me.lblAvailableBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.lblAvailableBalance.TrailingIcon = Nothing
        Me.lblAvailableBalance.UseSystemPasswordChar = False
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.AnimateReadOnly = False
        Me.lblTotalBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.lblTotalBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lblTotalBalance.Depth = 0
        Me.lblTotalBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotalBalance.HideSelection = True
        Me.lblTotalBalance.Hint = "Total Balance"
        Me.lblTotalBalance.LeadingIcon = Nothing
        Me.lblTotalBalance.Location = New System.Drawing.Point(7, 9)
        Me.lblTotalBalance.MaxLength = 32767
        Me.lblTotalBalance.MouseState = MaterialSkin.MouseState.OUT
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblTotalBalance.PrefixSuffixText = Nothing
        Me.lblTotalBalance.ReadOnly = True
        Me.lblTotalBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalBalance.SelectedText = ""
        Me.lblTotalBalance.SelectionLength = 0
        Me.lblTotalBalance.SelectionStart = 0
        Me.lblTotalBalance.ShortcutsEnabled = True
        Me.lblTotalBalance.Size = New System.Drawing.Size(251, 48)
        Me.lblTotalBalance.TabIndex = 94
        Me.lblTotalBalance.TabStop = False
        Me.lblTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.lblTotalBalance.TrailingIcon = Nothing
        Me.lblTotalBalance.UseSystemPasswordChar = False
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(804, 371)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(17, 19)
        Me.txtTotal.TabIndex = 112
        Me.txtTotal.Text = "tt"
        Me.txtTotal.Visible = False
        '
        'lblAccType
        '
        Me.lblAccType.AutoSize = True
        Me.lblAccType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccType.ForeColor = System.Drawing.Color.White
        Me.lblAccType.Location = New System.Drawing.Point(572, 294)
        Me.lblAccType.Name = "lblAccType"
        Me.lblAccType.Size = New System.Drawing.Size(39, 19)
        Me.lblAccType.TabIndex = 111
        Me.lblAccType.Text = "Type"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.ForeColor = System.Drawing.Color.White
        Me.lblmin.Location = New System.Drawing.Point(808, 409)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(30, 19)
        Me.lblmin.TabIndex = 110
        Me.lblmin.Text = "min"
        Me.lblmin.Visible = False
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobile.ForeColor = System.Drawing.Color.Black
        Me.lblmobile.Location = New System.Drawing.Point(154, 598)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(53, 19)
        Me.lblmobile.TabIndex = 136
        Me.lblmobile.Text = "mobile"
        Me.lblmobile.Visible = False
        '
        'frmWithdrawal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 766)
        Me.Controls.Add(Me.lblmobile)
        Me.Controls.Add(Me.expReason)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblAccType)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.lblNewBalance)
        Me.Controls.Add(Me.lblTamount)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblChBalance)
        Me.Controls.Add(Me.lblActCheck)
        Me.Controls.Add(Me.lblActive)
        Me.Controls.Add(Me.RadOther)
        Me.Controls.Add(Me.RadSelf)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.MaterialCard3)
        Me.Controls.Add(Me.txtWitdName)
        Me.Controls.Add(Me.TXTIDCARD)
        Me.Controls.Add(Me.cboIdType)
        Me.Controls.Add(Me.txtFormNo)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.ChkEdit)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.MaterialCard2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmWithdrawal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Individual Withdrawal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicSign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.expReason.ResumeLayout(False)
        Me.expReason.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PicSign As PictureBox
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents expReason As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents ChkEdit As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtChange As TextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtbranch As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtFirstname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSurname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtFormNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents TXTIDCARD As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboIdType As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtWitdName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtAmount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents RadSelf As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents RadOther As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblActive As Label
    Friend WithEvents lblActCheck As Label
    Friend WithEvents lblNewBalance As Label
    Friend WithEvents lblTamount As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblChBalance As Label
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lblAvailableBalance As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lblTotalBalance As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtTotal As Label
    Friend WithEvents lblAccType As Label
    Friend WithEvents lblmin As Label
    Friend WithEvents lblmobile As Label
End Class
