<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerBalance
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dddd = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtAmount = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.txtAvailableBalance = New MaterialSkin.Controls.MaterialTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.lblAccType = New System.Windows.Forms.Label()
        Me.lblmin = New System.Windows.Forms.Label()
        Me.Exloanpanel = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.txtprincipal = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtinterest = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblloantotal = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialCard1.SuspendLayout()
        Me.Exloanpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(335, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 19)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Customer's Picture"
        '
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(276, 224)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(254, 278)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 74
        Me.picCustomer.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(153, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 17)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Please Enter Customer's Account Number And Press Enter"
        '
        'dddd
        '
        Me.dddd.AutoSize = True
        Me.dddd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dddd.ForeColor = System.Drawing.Color.Navy
        Me.dddd.Location = New System.Drawing.Point(31, 112)
        Me.dddd.Name = "dddd"
        Me.dddd.Size = New System.Drawing.Size(100, 19)
        Me.dddd.TabIndex = 76
        Me.dddd.Text = "Account No. :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Navy
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(182, 545)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 17)
        Me.Label30.TabIndex = 81
        Me.Label30.Text = "GH₵"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(87, 546)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 25)
        Me.Label21.TabIndex = 79
        Me.Label21.Text = "Total Balance :"
        '
        'txtFirstname
        '
        Me.txtFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(134, 187)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(402, 26)
        Me.txtFirstname.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(55, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Surname :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(49, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Firstname :"
        '
        'txtSurname
        '
        Me.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(134, 153)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(402, 26)
        Me.txtSurname.TabIndex = 83
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(36, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 26)
        Me.lblStatus.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(98, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 25)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "STATUS"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AnimateReadOnly = False
        Me.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountNo.Depth = 0
        Me.txtAccountNo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAccountNo.Hint = "Enter Customer's Account Number"
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(134, 97)
        Me.txtAccountNo.MaxLength = 50
        Me.txtAccountNo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAccountNo.Multiline = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(402, 50)
        Me.txtAccountNo.TabIndex = 88
        Me.txtAccountNo.Text = ""
        Me.txtAccountNo.TrailingIcon = Nothing
        '
        'txtAmount
        '
        Me.txtAmount.AnimateReadOnly = False
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmount.Depth = 0
        Me.txtAmount.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAmount.LeadingIcon = Nothing
        Me.txtAmount.Location = New System.Drawing.Point(218, 528)
        Me.txtAmount.MaxLength = 50
        Me.txtAmount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAmount.Multiline = False
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(307, 50)
        Me.txtAmount.TabIndex = 89
        Me.txtAmount.Text = ""
        Me.txtAmount.TrailingIcon = Nothing
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.lblStatus)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(28, 257)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(219, 48)
        Me.MaterialCard1.TabIndex = 90
        '
        'txtAvailableBalance
        '
        Me.txtAvailableBalance.AnimateReadOnly = False
        Me.txtAvailableBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAvailableBalance.Depth = 0
        Me.txtAvailableBalance.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAvailableBalance.LeadingIcon = Nothing
        Me.txtAvailableBalance.Location = New System.Drawing.Point(218, 584)
        Me.txtAvailableBalance.MaxLength = 50
        Me.txtAvailableBalance.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAvailableBalance.Multiline = False
        Me.txtAvailableBalance.Name = "txtAvailableBalance"
        Me.txtAvailableBalance.ReadOnly = True
        Me.txtAvailableBalance.Size = New System.Drawing.Size(307, 50)
        Me.txtAvailableBalance.TabIndex = 93
        Me.txtAvailableBalance.Text = ""
        Me.txtAvailableBalance.TrailingIcon = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(182, 601)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "GH₵"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(59, 602)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 25)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Available Balance :"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.White
        Me.txtTotal.Location = New System.Drawing.Point(181, 219)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(17, 19)
        Me.txtTotal.TabIndex = 96
        Me.txtTotal.Text = "tt"
        Me.txtTotal.Visible = False
        '
        'lblAccType
        '
        Me.lblAccType.AutoSize = True
        Me.lblAccType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccType.ForeColor = System.Drawing.Color.White
        Me.lblAccType.Location = New System.Drawing.Point(60, 131)
        Me.lblAccType.Name = "lblAccType"
        Me.lblAccType.Size = New System.Drawing.Size(39, 19)
        Me.lblAccType.TabIndex = 95
        Me.lblAccType.Text = "Type"
        '
        'lblmin
        '
        Me.lblmin.AutoSize = True
        Me.lblmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmin.ForeColor = System.Drawing.Color.White
        Me.lblmin.Location = New System.Drawing.Point(141, 219)
        Me.lblmin.Name = "lblmin"
        Me.lblmin.Size = New System.Drawing.Size(30, 19)
        Me.lblmin.TabIndex = 94
        Me.lblmin.Text = "min"
        Me.lblmin.Visible = False
        '
        'Exloanpanel
        '
        Me.Exloanpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Exloanpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Exloanpanel.CancelButtonText = ""
        Me.Exloanpanel.Collapse = True
        Me.Exloanpanel.Controls.Add(Me.lblloantotal)
        Me.Exloanpanel.Controls.Add(Me.txtinterest)
        Me.Exloanpanel.Controls.Add(Me.Label9)
        Me.Exloanpanel.Controls.Add(Me.txtprincipal)
        Me.Exloanpanel.Controls.Add(Me.Label8)
        Me.Exloanpanel.Depth = 0
        Me.Exloanpanel.Description = ""
        Me.Exloanpanel.ExpandHeight = 200
        Me.Exloanpanel.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Exloanpanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Exloanpanel.Location = New System.Drawing.Point(5, 308)
        Me.Exloanpanel.Margin = New System.Windows.Forms.Padding(16, 1, 16, 0)
        Me.Exloanpanel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Exloanpanel.Name = "Exloanpanel"
        Me.Exloanpanel.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.Exloanpanel.ShowValidationButtons = False
        Me.Exloanpanel.Size = New System.Drawing.Size(266, 48)
        Me.Exloanpanel.TabIndex = 97
        Me.Exloanpanel.Title = "Loan Balance"
        Me.Exloanpanel.ValidationButtonEnable = True
        Me.Exloanpanel.ValidationButtonText = ""
        '
        'txtprincipal
        '
        Me.txtprincipal.AnimateReadOnly = False
        Me.txtprincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtprincipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtprincipal.Depth = 0
        Me.txtprincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtprincipal.HideSelection = True
        Me.txtprincipal.Hint = "Loan Principal"
        Me.txtprincipal.LeadingIcon = Nothing
        Me.txtprincipal.Location = New System.Drawing.Point(44, 51)
        Me.txtprincipal.MaxLength = 32767
        Me.txtprincipal.MouseState = MaterialSkin.MouseState.OUT
        Me.txtprincipal.Name = "txtprincipal"
        Me.txtprincipal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprincipal.PrefixSuffixText = Nothing
        Me.txtprincipal.ReadOnly = True
        Me.txtprincipal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtprincipal.SelectedText = ""
        Me.txtprincipal.SelectionLength = 0
        Me.txtprincipal.SelectionStart = 0
        Me.txtprincipal.ShortcutsEnabled = True
        Me.txtprincipal.Size = New System.Drawing.Size(197, 48)
        Me.txtprincipal.TabIndex = 129
        Me.txtprincipal.TabStop = False
        Me.txtprincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtprincipal.TrailingIcon = Nothing
        Me.txtprincipal.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "GH₵"
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
        Me.txtinterest.Location = New System.Drawing.Point(42, 105)
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
        Me.txtinterest.TabIndex = 131
        Me.txtinterest.TabStop = False
        Me.txtinterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtinterest.TrailingIcon = Nothing
        Me.txtinterest.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Navy
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "GH₵"
        '
        'lblloantotal
        '
        Me.lblloantotal.AutoSize = True
        Me.lblloantotal.Depth = 0
        Me.lblloantotal.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblloantotal.Location = New System.Drawing.Point(76, 163)
        Me.lblloantotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblloantotal.Name = "lblloantotal"
        Me.lblloantotal.Size = New System.Drawing.Size(107, 19)
        Me.lblloantotal.TabIndex = 132
        Me.lblloantotal.Text = "MaterialLabel1"
        '
        'frmCustomerBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(560, 644)
        Me.Controls.Add(Me.Exloanpanel)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblAccType)
        Me.Controls.Add(Me.lblmin)
        Me.Controls.Add(Me.txtAvailableBalance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dddd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.picCustomer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Balance"
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.Exloanpanel.ResumeLayout(False)
        Me.Exloanpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dddd As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtAmount As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtAvailableBalance As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents lblAccType As Label
    Friend WithEvents lblmin As Label
    Friend WithEvents Exloanpanel As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents txtprincipal As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label8 As Label
    Friend WithEvents txtinterest As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label9 As Label
    Friend WithEvents lblloantotal As MaterialSkin.Controls.MaterialLabel
End Class
