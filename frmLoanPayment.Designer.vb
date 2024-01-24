<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanPayment
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
        Me.txtinterest = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtamount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.txtFirstname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSurname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.txtamountpaying = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInterestDDD = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtPrincipalDD = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.lblrate = New System.Windows.Forms.Label()
        Me.lbltt = New System.Windows.Forms.Label()
        Me.lblII = New System.Windows.Forms.Label()
        Me.lblmobile = New System.Windows.Forms.Label()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtinterest.Location = New System.Drawing.Point(585, 238)
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
        Me.txtinterest.TabIndex = 128
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
        Me.txtamount.Location = New System.Drawing.Point(348, 238)
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
        Me.txtamount.TabIndex = 127
        Me.txtamount.TabStop = False
        Me.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtamount.TrailingIcon = Nothing
        Me.txtamount.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(551, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "GH₵"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Navy
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(315, 255)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 17)
        Me.Label30.TabIndex = 125
        Me.Label30.Text = "GH₵"
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.Label5)
        Me.MaterialCard2.Controls.Add(Me.picCustomer)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(17, 85)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(285, 334)
        Me.MaterialCard2.TabIndex = 123
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(83, 296)
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
        Me.txtFirstname.Location = New System.Drawing.Point(313, 184)
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
        Me.txtFirstname.TabIndex = 122
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
        Me.txtSurname.Location = New System.Drawing.Point(313, 130)
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
        Me.txtSurname.TabIndex = 121
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
        Me.txtAccountNo.Hint = "Account Number"
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(313, 78)
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
        Me.txtAccountNo.TabIndex = 120
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccountNo.TrailingIcon = Nothing
        Me.txtAccountNo.UseSystemPasswordChar = False
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.txtamountpaying)
        Me.MaterialCard1.Controls.Add(Me.Label4)
        Me.MaterialCard1.Controls.Add(Me.txtInterestDDD)
        Me.MaterialCard1.Controls.Add(Me.txtPrincipalDD)
        Me.MaterialCard1.Controls.Add(Me.Label2)
        Me.MaterialCard1.Controls.Add(Me.Label3)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(313, 290)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(470, 129)
        Me.MaterialCard1.TabIndex = 129
        '
        'txtamountpaying
        '
        Me.txtamountpaying.AnimateReadOnly = False
        Me.txtamountpaying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtamountpaying.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtamountpaying.Depth = 0
        Me.txtamountpaying.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtamountpaying.HideSelection = True
        Me.txtamountpaying.Hint = "Amount Paying"
        Me.txtamountpaying.LeadingIcon = Nothing
        Me.txtamountpaying.Location = New System.Drawing.Point(41, 12)
        Me.txtamountpaying.MaxLength = 32767
        Me.txtamountpaying.MouseState = MaterialSkin.MouseState.OUT
        Me.txtamountpaying.Name = "txtamountpaying"
        Me.txtamountpaying.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamountpaying.PrefixSuffixText = Nothing
        Me.txtamountpaying.ReadOnly = False
        Me.txtamountpaying.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtamountpaying.SelectedText = ""
        Me.txtamountpaying.SelectionLength = 0
        Me.txtamountpaying.SelectionStart = 0
        Me.txtamountpaying.ShortcutsEnabled = True
        Me.txtamountpaying.Size = New System.Drawing.Size(412, 48)
        Me.txtamountpaying.TabIndex = 134
        Me.txtamountpaying.TabStop = False
        Me.txtamountpaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtamountpaying.TrailingIcon = Nothing
        Me.txtamountpaying.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "GH₵"
        '
        'txtInterestDDD
        '
        Me.txtInterestDDD.AnimateReadOnly = False
        Me.txtInterestDDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtInterestDDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtInterestDDD.Depth = 0
        Me.txtInterestDDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtInterestDDD.HideSelection = True
        Me.txtInterestDDD.Hint = "Loan Interest"
        Me.txtInterestDDD.LeadingIcon = Nothing
        Me.txtInterestDDD.Location = New System.Drawing.Point(269, 71)
        Me.txtInterestDDD.MaxLength = 32767
        Me.txtInterestDDD.MouseState = MaterialSkin.MouseState.OUT
        Me.txtInterestDDD.Name = "txtInterestDDD"
        Me.txtInterestDDD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInterestDDD.PrefixSuffixText = Nothing
        Me.txtInterestDDD.ReadOnly = True
        Me.txtInterestDDD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInterestDDD.SelectedText = ""
        Me.txtInterestDDD.SelectionLength = 0
        Me.txtInterestDDD.SelectionStart = 0
        Me.txtInterestDDD.ShortcutsEnabled = True
        Me.txtInterestDDD.Size = New System.Drawing.Size(184, 48)
        Me.txtInterestDDD.TabIndex = 132
        Me.txtInterestDDD.TabStop = False
        Me.txtInterestDDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtInterestDDD.TrailingIcon = Nothing
        Me.txtInterestDDD.UseSystemPasswordChar = False
        '
        'txtPrincipalDD
        '
        Me.txtPrincipalDD.AnimateReadOnly = False
        Me.txtPrincipalDD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtPrincipalDD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrincipalDD.Depth = 0
        Me.txtPrincipalDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPrincipalDD.HideSelection = True
        Me.txtPrincipalDD.Hint = "Loan Amount"
        Me.txtPrincipalDD.LeadingIcon = Nothing
        Me.txtPrincipalDD.Location = New System.Drawing.Point(39, 71)
        Me.txtPrincipalDD.MaxLength = 32767
        Me.txtPrincipalDD.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPrincipalDD.Name = "txtPrincipalDD"
        Me.txtPrincipalDD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrincipalDD.PrefixSuffixText = Nothing
        Me.txtPrincipalDD.ReadOnly = True
        Me.txtPrincipalDD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrincipalDD.SelectedText = ""
        Me.txtPrincipalDD.SelectionLength = 0
        Me.txtPrincipalDD.SelectionStart = 0
        Me.txtPrincipalDD.ShortcutsEnabled = True
        Me.txtPrincipalDD.Size = New System.Drawing.Size(191, 48)
        Me.txtPrincipalDD.TabIndex = 131
        Me.txtPrincipalDD.TabStop = False
        Me.txtPrincipalDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPrincipalDD.TrailingIcon = Nothing
        Me.txtPrincipalDD.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(235, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "GH₵"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "GH₵"
        '
        'btnclear
        '
        Me.btnclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnclear.Depth = 0
        Me.btnclear.HighEmphasis = True
        Me.btnclear.Icon = Global.CLSystem.My.Resources.Resources.clear
        Me.btnclear.Location = New System.Drawing.Point(687, 429)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(94, 36)
        Me.btnclear.TabIndex = 131
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
        Me.btnSave.Location = New System.Drawing.Point(562, 429)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(119, 36)
        Me.btnSave.TabIndex = 130
        Me.btnSave.Text = "Pay Loan"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.ForeColor = System.Drawing.Color.White
        Me.lblrate.Location = New System.Drawing.Point(268, 437)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(136, 19)
        Me.lblrate.TabIndex = 76
        Me.lblrate.Text = "Customer's Picture"
        Me.lblrate.Visible = False
        '
        'lbltt
        '
        Me.lbltt.AutoSize = True
        Me.lbltt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltt.ForeColor = System.Drawing.Color.White
        Me.lbltt.Location = New System.Drawing.Point(100, 446)
        Me.lbltt.Name = "lbltt"
        Me.lbltt.Size = New System.Drawing.Size(136, 19)
        Me.lbltt.TabIndex = 132
        Me.lbltt.Text = "Customer's Picture"
        Me.lbltt.Visible = False
        '
        'lblII
        '
        Me.lblII.AutoSize = True
        Me.lblII.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblII.ForeColor = System.Drawing.Color.Black
        Me.lblII.Location = New System.Drawing.Point(100, 427)
        Me.lblII.Name = "lblII"
        Me.lblII.Size = New System.Drawing.Size(136, 19)
        Me.lblII.TabIndex = 133
        Me.lblII.Text = "Customer's Picture"
        Me.lblII.Visible = False
        '
        'lblmobile
        '
        Me.lblmobile.AutoSize = True
        Me.lblmobile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobile.ForeColor = System.Drawing.Color.Black
        Me.lblmobile.Location = New System.Drawing.Point(13, 429)
        Me.lblmobile.Name = "lblmobile"
        Me.lblmobile.Size = New System.Drawing.Size(53, 19)
        Me.lblmobile.TabIndex = 134
        Me.lblmobile.Text = "mobile"
        Me.lblmobile.Visible = False
        '
        'frmLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 475)
        Me.Controls.Add(Me.lblmobile)
        Me.Controls.Add(Me.lblII)
        Me.Controls.Add(Me.lbltt)
        Me.Controls.Add(Me.lblrate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.txtinterest)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtAccountNo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanPayment"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Payment"
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtinterest As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtamount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Label5 As Label
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents txtFirstname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSurname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtamountpaying As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInterestDDD As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtPrincipalDD As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lblrate As Label
    Friend WithEvents lbltt As Label
    Friend WithEvents lblII As Label
    Friend WithEvents lblmobile As Label
End Class
