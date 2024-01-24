<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanApproval
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
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.lblAccType = New System.Windows.Forms.Label()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dddd = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.txtAmount = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboLoanNo = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtrepay = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtinterest = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(113, 288)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(17, 19)
        Me.txtTotal.TabIndex = 110
        Me.txtTotal.Text = "tt"
        Me.txtTotal.Visible = False
        '
        'lblAccType
        '
        Me.lblAccType.AutoSize = True
        Me.lblAccType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccType.ForeColor = System.Drawing.Color.White
        Me.lblAccType.Location = New System.Drawing.Point(32, 130)
        Me.lblAccType.Name = "lblAccType"
        Me.lblAccType.Size = New System.Drawing.Size(39, 19)
        Me.lblAccType.TabIndex = 109
        Me.lblAccType.Text = "Type"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AnimateReadOnly = False
        Me.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountNo.Depth = 0
        Me.txtAccountNo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAccountNo.Hint = "Enter Customer's Account Number"
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(106, 96)
        Me.txtAccountNo.MaxLength = 50
        Me.txtAccountNo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAccountNo.Multiline = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(402, 50)
        Me.txtAccountNo.TabIndex = 106
        Me.txtAccountNo.Text = ""
        Me.txtAccountNo.TrailingIcon = Nothing
        '
        'txtFirstname
        '
        Me.txtFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(106, 234)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(402, 26)
        Me.txtFirstname.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(27, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Surname :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(21, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Firstname :"
        '
        'txtSurname
        '
        Me.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(106, 200)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(402, 26)
        Me.txtSurname.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(125, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 17)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Please Enter Customer's Account Number And Press Enter"
        '
        'dddd
        '
        Me.dddd.AutoSize = True
        Me.dddd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dddd.ForeColor = System.Drawing.Color.Navy
        Me.dddd.Location = New System.Drawing.Point(3, 111)
        Me.dddd.Name = "dddd"
        Me.dddd.Size = New System.Drawing.Size(100, 19)
        Me.dddd.TabIndex = 99
        Me.dddd.Text = "Account No. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(309, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 19)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Customer's Picture"
        '
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(250, 270)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(254, 278)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 97
        Me.picCustomer.TabStop = False
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.btnclear)
        Me.MaterialCard1.Controls.Add(Me.btnSave)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(7, 574)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(540, 93)
        Me.MaterialCard1.TabIndex = 111
        '
        'btnclear
        '
        Me.btnclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnclear.Depth = 0
        Me.btnclear.HighEmphasis = True
        Me.btnclear.Icon = Global.CLSystem.My.Resources.Resources.clear
        Me.btnclear.Location = New System.Drawing.Point(399, 37)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(108, 36)
        Me.btnclear.TabIndex = 110
        Me.btnclear.Text = "Decline"
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
        Me.btnSave.Location = New System.Drawing.Point(274, 37)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(115, 36)
        Me.btnSave.TabIndex = 109
        Me.btnSave.Text = "Approve"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.AnimateReadOnly = False
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmount.Depth = 0
        Me.txtAmount.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAmount.LeadingIcon = Nothing
        Me.txtAmount.Location = New System.Drawing.Point(51, 611)
        Me.txtAmount.MaxLength = 50
        Me.txtAmount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAmount.Multiline = False
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(198, 50)
        Me.txtAmount.TabIndex = 92
        Me.txtAmount.Text = ""
        Me.txtAmount.TrailingIcon = Nothing
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Navy
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(15, 628)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 17)
        Me.Label30.TabIndex = 91
        Me.Label30.Text = "GH₵"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(81, 592)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(142, 25)
        Me.Label21.TabIndex = 90
        Me.Label21.Text = "Loan Amount :"
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
        Me.cboLoanNo.Location = New System.Drawing.Point(106, 148)
        Me.cboLoanNo.MaxDropDownItems = 4
        Me.cboLoanNo.MouseState = MaterialSkin.MouseState.OUT
        Me.cboLoanNo.Name = "cboLoanNo"
        Me.cboLoanNo.Size = New System.Drawing.Size(402, 49)
        Me.cboLoanNo.StartIndex = 0
        Me.cboLoanNo.TabIndex = 112
        '
        'txtrepay
        '
        Me.txtrepay.AnimateReadOnly = False
        Me.txtrepay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtrepay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtrepay.Depth = 0
        Me.txtrepay.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtrepay.HideSelection = True
        Me.txtrepay.Hint = "Duration"
        Me.txtrepay.LeadingIcon = Nothing
        Me.txtrepay.Location = New System.Drawing.Point(18, 370)
        Me.txtrepay.MaxLength = 32767
        Me.txtrepay.MouseState = MaterialSkin.MouseState.OUT
        Me.txtrepay.Name = "txtrepay"
        Me.txtrepay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrepay.PrefixSuffixText = Nothing
        Me.txtrepay.ReadOnly = True
        Me.txtrepay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtrepay.SelectedText = ""
        Me.txtrepay.SelectionLength = 0
        Me.txtrepay.SelectionStart = 0
        Me.txtrepay.ShortcutsEnabled = True
        Me.txtrepay.Size = New System.Drawing.Size(227, 48)
        Me.txtrepay.TabIndex = 115
        Me.txtrepay.TabStop = False
        Me.txtrepay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtrepay.TrailingIcon = Nothing
        Me.txtrepay.UseSystemPasswordChar = False
        '
        'txtinterest
        '
        Me.txtinterest.AnimateReadOnly = False
        Me.txtinterest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtinterest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtinterest.Depth = 0
        Me.txtinterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtinterest.HideSelection = True
        Me.txtinterest.Hint = "Interest"
        Me.txtinterest.LeadingIcon = Nothing
        Me.txtinterest.Location = New System.Drawing.Point(51, 424)
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
        Me.txtinterest.Size = New System.Drawing.Size(193, 48)
        Me.txtinterest.TabIndex = 116
        Me.txtinterest.TabStop = False
        Me.txtinterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtinterest.TrailingIcon = Nothing
        Me.txtinterest.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "GH₵"
        '
        'frmLoanApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 674)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtinterest)
        Me.Controls.Add(Me.txtrepay)
        Me.Controls.Add(Me.cboLoanNo)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblAccType)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dddd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picCustomer)
        Me.Controls.Add(Me.MaterialCard1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoanApproval"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Approval"
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotal As Label
    Friend WithEvents lblAccType As Label
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dddd As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtAmount As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cboLoanNo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtrepay As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtinterest As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label1 As Label
End Class
