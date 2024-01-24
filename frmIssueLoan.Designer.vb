<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssueLoan
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
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.txtendmnt = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtendyr = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtstartmnt = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtstartyr = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtFirstname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSurname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.cboLoanNo = New MaterialSkin.Controls.MaterialComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtinterest = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtamount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AnimateReadOnly = False
        Me.txtAccountNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtAccountNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAccountNo.Depth = 0
        Me.txtAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAccountNo.HideSelection = True
        Me.txtAccountNo.Hint = "Account Number"
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(26, 87)
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
        Me.txtAccountNo.Size = New System.Drawing.Size(471, 48)
        Me.txtAccountNo.TabIndex = 0
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccountNo.TrailingIcon = Nothing
        Me.txtAccountNo.UseSystemPasswordChar = False
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.txtendmnt)
        Me.MaterialCard1.Controls.Add(Me.txtendyr)
        Me.MaterialCard1.Controls.Add(Me.txtstartmnt)
        Me.MaterialCard1.Controls.Add(Me.txtstartyr)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(52, 361)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(418, 123)
        Me.MaterialCard1.TabIndex = 1
        '
        'txtendmnt
        '
        Me.txtendmnt.AutoResize = False
        Me.txtendmnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtendmnt.Depth = 0
        Me.txtendmnt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.txtendmnt.DropDownHeight = 174
        Me.txtendmnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtendmnt.DropDownWidth = 121
        Me.txtendmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtendmnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtendmnt.FormattingEnabled = True
        Me.txtendmnt.Hint = "End Start"
        Me.txtendmnt.IntegralHeight = False
        Me.txtendmnt.ItemHeight = 43
        Me.txtendmnt.Items.AddRange(New Object() {"", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.txtendmnt.Location = New System.Drawing.Point(9, 64)
        Me.txtendmnt.MaxDropDownItems = 4
        Me.txtendmnt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtendmnt.Name = "txtendmnt"
        Me.txtendmnt.Size = New System.Drawing.Size(192, 49)
        Me.txtendmnt.StartIndex = 0
        Me.txtendmnt.TabIndex = 4
        '
        'txtendyr
        '
        Me.txtendyr.AnimateReadOnly = False
        Me.txtendyr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtendyr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtendyr.Depth = 0
        Me.txtendyr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtendyr.HideSelection = True
        Me.txtendyr.Hint = "End Year"
        Me.txtendyr.LeadingIcon = Nothing
        Me.txtendyr.Location = New System.Drawing.Point(207, 64)
        Me.txtendyr.MaxLength = 32767
        Me.txtendyr.MouseState = MaterialSkin.MouseState.OUT
        Me.txtendyr.Name = "txtendyr"
        Me.txtendyr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtendyr.PrefixSuffixText = Nothing
        Me.txtendyr.ReadOnly = False
        Me.txtendyr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtendyr.SelectedText = ""
        Me.txtendyr.SelectionLength = 0
        Me.txtendyr.SelectionStart = 0
        Me.txtendyr.ShortcutsEnabled = True
        Me.txtendyr.Size = New System.Drawing.Size(201, 48)
        Me.txtendyr.TabIndex = 3
        Me.txtendyr.TabStop = False
        Me.txtendyr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtendyr.TrailingIcon = Nothing
        Me.txtendyr.UseSystemPasswordChar = False
        '
        'txtstartmnt
        '
        Me.txtstartmnt.AutoResize = False
        Me.txtstartmnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstartmnt.Depth = 0
        Me.txtstartmnt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.txtstartmnt.DropDownHeight = 174
        Me.txtstartmnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtstartmnt.DropDownWidth = 121
        Me.txtstartmnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtstartmnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtstartmnt.FormattingEnabled = True
        Me.txtstartmnt.Hint = "Start Month"
        Me.txtstartmnt.IntegralHeight = False
        Me.txtstartmnt.ItemHeight = 43
        Me.txtstartmnt.Items.AddRange(New Object() {"", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.txtstartmnt.Location = New System.Drawing.Point(9, 9)
        Me.txtstartmnt.MaxDropDownItems = 4
        Me.txtstartmnt.MouseState = MaterialSkin.MouseState.OUT
        Me.txtstartmnt.Name = "txtstartmnt"
        Me.txtstartmnt.Size = New System.Drawing.Size(192, 49)
        Me.txtstartmnt.StartIndex = 0
        Me.txtstartmnt.TabIndex = 1
        '
        'txtstartyr
        '
        Me.txtstartyr.AnimateReadOnly = False
        Me.txtstartyr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtstartyr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtstartyr.Depth = 0
        Me.txtstartyr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtstartyr.HideSelection = True
        Me.txtstartyr.Hint = "Start Year"
        Me.txtstartyr.LeadingIcon = Nothing
        Me.txtstartyr.Location = New System.Drawing.Point(207, 9)
        Me.txtstartyr.MaxLength = 32767
        Me.txtstartyr.MouseState = MaterialSkin.MouseState.OUT
        Me.txtstartyr.Name = "txtstartyr"
        Me.txtstartyr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstartyr.PrefixSuffixText = Nothing
        Me.txtstartyr.ReadOnly = False
        Me.txtstartyr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtstartyr.SelectedText = ""
        Me.txtstartyr.SelectionLength = 0
        Me.txtstartyr.SelectionStart = 0
        Me.txtstartyr.ShortcutsEnabled = True
        Me.txtstartyr.Size = New System.Drawing.Size(201, 48)
        Me.txtstartyr.TabIndex = 0
        Me.txtstartyr.TabStop = False
        Me.txtstartyr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtstartyr.TrailingIcon = Nothing
        Me.txtstartyr.UseSystemPasswordChar = False
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
        Me.txtFirstname.Location = New System.Drawing.Point(26, 250)
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
        Me.txtFirstname.Size = New System.Drawing.Size(471, 48)
        Me.txtFirstname.TabIndex = 94
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
        Me.txtSurname.Location = New System.Drawing.Point(26, 196)
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
        Me.txtSurname.Size = New System.Drawing.Size(471, 48)
        Me.txtSurname.TabIndex = 93
        Me.txtSurname.TabStop = False
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSurname.TrailingIcon = Nothing
        Me.txtSurname.UseSystemPasswordChar = False
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.Label5)
        Me.MaterialCard2.Controls.Add(Me.picCustomer)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(514, 87)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(285, 331)
        Me.MaterialCard2.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(87, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 19)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Customer's Picture"
        '
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(15, 7)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(254, 278)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 74
        Me.picCustomer.TabStop = False
        '
        'cboLoanNo
        '
        Me.cboLoanNo.AutoResize = False
        Me.cboLoanNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboLoanNo.Depth = 0
        Me.cboLoanNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboLoanNo.DropDownHeight = 174
        Me.cboLoanNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLoanNo.DropDownWidth = 121
        Me.cboLoanNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboLoanNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboLoanNo.FormattingEnabled = True
        Me.cboLoanNo.Hint = "Select Loan Number"
        Me.cboLoanNo.IntegralHeight = False
        Me.cboLoanNo.ItemHeight = 43
        Me.cboLoanNo.Location = New System.Drawing.Point(26, 141)
        Me.cboLoanNo.MaxDropDownItems = 4
        Me.cboLoanNo.MouseState = MaterialSkin.MouseState.OUT
        Me.cboLoanNo.Name = "cboLoanNo"
        Me.cboLoanNo.Size = New System.Drawing.Size(471, 49)
        Me.cboLoanNo.StartIndex = 0
        Me.cboLoanNo.TabIndex = 113
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Navy
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(24, 321)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 17)
        Me.Label30.TabIndex = 114
        Me.Label30.Text = "GH₵"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "GH₵"
        '
        'txtinterest
        '
        Me.txtinterest.AnimateReadOnly = False
        Me.txtinterest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtinterest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtinterest.Depth = 0
        Me.txtinterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtinterest.HideSelection = True
        Me.txtinterest.Hint = "Loan Interest"
        Me.txtinterest.LeadingIcon = Nothing
        Me.txtinterest.Location = New System.Drawing.Point(298, 304)
        Me.txtinterest.MaxLength = 32767
        Me.txtinterest.MouseState = MaterialSkin.MouseState.OUT
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtinterest.PrefixSuffixText = Nothing
        Me.txtinterest.ReadOnly = True
        Me.txtinterest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtinterest.SelectedText = ""
        Me.txtinterest.SelectionLength = 0
        Me.txtinterest.SelectionStart = 0
        Me.txtinterest.ShortcutsEnabled = True
        Me.txtinterest.Size = New System.Drawing.Size(199, 48)
        Me.txtinterest.TabIndex = 119
        Me.txtinterest.TabStop = False
        Me.txtinterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtinterest.TrailingIcon = Nothing
        Me.txtinterest.UseSystemPasswordChar = False
        '
        'txtamount
        '
        Me.txtamount.AnimateReadOnly = False
        Me.txtamount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtamount.Depth = 0
        Me.txtamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtamount.HideSelection = True
        Me.txtamount.Hint = "Loan Amount"
        Me.txtamount.LeadingIcon = Nothing
        Me.txtamount.Location = New System.Drawing.Point(61, 304)
        Me.txtamount.MaxLength = 32767
        Me.txtamount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.PrefixSuffixText = Nothing
        Me.txtamount.ReadOnly = True
        Me.txtamount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtamount.SelectedText = ""
        Me.txtamount.SelectionLength = 0
        Me.txtamount.SelectionStart = 0
        Me.txtamount.ShortcutsEnabled = True
        Me.txtamount.Size = New System.Drawing.Size(197, 48)
        Me.txtamount.TabIndex = 118
        Me.txtamount.TabStop = False
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtamount.TrailingIcon = Nothing
        Me.txtamount.UseSystemPasswordChar = False
        '
        'btnclear
        '
        Me.btnclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnclear.Depth = 0
        Me.btnclear.HighEmphasis = True
        Me.btnclear.Icon = Global.CLSystem.My.Resources.Resources.clear
        Me.btnclear.Location = New System.Drawing.Point(674, 438)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(94, 36)
        Me.btnclear.TabIndex = 121
        Me.btnclear.Text = "Close"
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
        Me.btnSave.Location = New System.Drawing.Point(529, 438)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(131, 36)
        Me.btnSave.TabIndex = 120
        Me.btnSave.Text = "Issue Loan"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmIssueLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 500)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtinterest)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cboLoanNo)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.txtAccountNo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIssueLoan"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue Loan"
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtstartyr As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtstartmnt As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtendmnt As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtendyr As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtFirstname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSurname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label5 As Label
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents cboLoanNo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtinterest As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtamount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
End Class
