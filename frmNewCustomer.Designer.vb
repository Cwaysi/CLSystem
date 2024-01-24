<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewCustomer
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
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOcc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDigitalAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboMStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboTitle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNKaddress = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNKmobile = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNKrelationship = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNKfirstname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNKsurname = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtStartBalance = New MaterialSkin.Controls.MaterialTextBox()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.cboAccType = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ChkEdit = New System.Windows.Forms.CheckBox()
        Me.lblserial = New System.Windows.Forms.Label()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.PicSign = New System.Windows.Forms.PictureBox()
        Me.btnUpone = New System.Windows.Forms.Button()
        Me.btnUPtwo = New System.Windows.Forms.Button()
        Me.lblAccNo = New System.Windows.Forms.Label()
        Me.cboBranch = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboIdType = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXTIDCARD = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialSwitch1 = New MaterialSkin.Controls.MaterialSwitch()
        Me.lblAccountCode = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(446, 57)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(413, 26)
        Me.txtAddress.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(337, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Address :"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(122, 57)
        Me.txtMobile.MaxLength = 10
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(200, 26)
        Me.txtMobile.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(49, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Mobile :"
        '
        'txtFirstname
        '
        Me.txtFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(614, 21)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(242, 26)
        Me.txtFirstname.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(538, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Firstname :"
        '
        'txtSurname
        '
        Me.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(312, 21)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(220, 26)
        Me.txtSurname.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(232, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Surname :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtOcc)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtDigitalAddress)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboMStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDOB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMobile)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 202)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BIO DATA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(442, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 19)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "eg: CX-023-7777"
        '
        'txtOcc
        '
        Me.txtOcc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcc.Location = New System.Drawing.Point(122, 155)
        Me.txtOcc.Name = "txtOcc"
        Me.txtOcc.Size = New System.Drawing.Size(200, 26)
        Me.txtOcc.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(22, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 19)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Occupation :"
        '
        'txtDigitalAddress
        '
        Me.txtDigitalAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDigitalAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDigitalAddress.Location = New System.Drawing.Point(446, 100)
        Me.txtDigitalAddress.MaxLength = 13
        Me.txtDigitalAddress.Name = "txtDigitalAddress"
        Me.txtDigitalAddress.Size = New System.Drawing.Size(410, 26)
        Me.txtDigitalAddress.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(337, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Digital Address :"
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtemail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(619, 155)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(240, 26)
        Me.txtemail.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(564, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Email :"
        '
        'cboMStatus
        '
        Me.cboMStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMStatus.FormattingEnabled = True
        Me.cboMStatus.Items.AddRange(New Object() {"SINGLE", "MARRIED", "DIVORCE", "OTHER"})
        Me.cboMStatus.Location = New System.Drawing.Point(446, 155)
        Me.cboMStatus.Name = "cboMStatus"
        Me.cboMStatus.Size = New System.Drawing.Size(112, 27)
        Me.cboMStatus.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(337, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Marital Status :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(118, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 19)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Format : day month year"
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(122, 100)
        Me.txtDOB.Mask = "00/00/0000"
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(200, 26)
        Me.txtDOB.TabIndex = 20
        Me.txtDOB.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date Of Birth :"
        '
        'cboTitle
        '
        Me.cboTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Items.AddRange(New Object() {"Mr", "Mrs", "Miss", "Dr", "Rev"})
        Me.cboTitle.Location = New System.Drawing.Point(122, 21)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(85, 27)
        Me.cboTitle.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(67, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Title :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(621, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(175, 19)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "eg: example@example.com"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNKaddress)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtNKmobile)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtNKrelationship)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtNKfirstname)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtNKsurname)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 382)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 98)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NEXT OF KIN"
        '
        'txtNKaddress
        '
        Me.txtNKaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNKaddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNKaddress.Location = New System.Drawing.Point(392, 55)
        Me.txtNKaddress.Name = "txtNKaddress"
        Me.txtNKaddress.Size = New System.Drawing.Size(472, 26)
        Me.txtNKaddress.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(319, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 19)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Address :"
        '
        'txtNKmobile
        '
        Me.txtNKmobile.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNKmobile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNKmobile.Location = New System.Drawing.Point(89, 55)
        Me.txtNKmobile.MaxLength = 10
        Me.txtNKmobile.Name = "txtNKmobile"
        Me.txtNKmobile.Size = New System.Drawing.Size(220, 26)
        Me.txtNKmobile.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(19, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 19)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Mobile :"
        '
        'txtNKrelationship
        '
        Me.txtNKrelationship.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNKrelationship.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNKrelationship.Location = New System.Drawing.Point(719, 23)
        Me.txtNKrelationship.Name = "txtNKrelationship"
        Me.txtNKrelationship.Size = New System.Drawing.Size(145, 26)
        Me.txtNKrelationship.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(620, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 19)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Relationship :"
        '
        'txtNKfirstname
        '
        Me.txtNKfirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNKfirstname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNKfirstname.Location = New System.Drawing.Point(391, 23)
        Me.txtNKfirstname.Name = "txtNKfirstname"
        Me.txtNKfirstname.Size = New System.Drawing.Size(221, 26)
        Me.txtNKfirstname.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(315, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 19)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Firstname :"
        '
        'txtNKsurname
        '
        Me.txtNKsurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNKsurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNKsurname.Location = New System.Drawing.Point(89, 23)
        Me.txtNKsurname.Name = "txtNKsurname"
        Me.txtNKsurname.Size = New System.Drawing.Size(220, 26)
        Me.txtNKsurname.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(9, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 19)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Surname :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAccountCode)
        Me.GroupBox3.Controls.Add(Me.txtStartBalance)
        Me.GroupBox3.Controls.Add(Me.lblPre)
        Me.GroupBox3.Controls.Add(Me.cboAccType)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 485)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(874, 72)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACCOUNT DETAIL"
        '
        'txtStartBalance
        '
        Me.txtStartBalance.AnimateReadOnly = False
        Me.txtStartBalance.BackColor = System.Drawing.Color.Gold
        Me.txtStartBalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStartBalance.Depth = 0
        Me.txtStartBalance.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtStartBalance.ForeColor = System.Drawing.Color.White
        Me.txtStartBalance.LeadingIcon = Nothing
        Me.txtStartBalance.Location = New System.Drawing.Point(568, 16)
        Me.txtStartBalance.MaxLength = 50
        Me.txtStartBalance.MouseState = MaterialSkin.MouseState.OUT
        Me.txtStartBalance.Multiline = False
        Me.txtStartBalance.Name = "txtStartBalance"
        Me.txtStartBalance.Size = New System.Drawing.Size(291, 50)
        Me.txtStartBalance.TabIndex = 62
        Me.txtStartBalance.Text = ""
        Me.txtStartBalance.TrailingIcon = Nothing
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre.ForeColor = System.Drawing.Color.White
        Me.lblPre.Location = New System.Drawing.Point(66, 49)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(66, 19)
        Me.lblPre.TabIndex = 61
        Me.lblPre.Text = "Acc Pref"
        Me.lblPre.Visible = False
        '
        'cboAccType
        '
        Me.cboAccType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccType.FormattingEnabled = True
        Me.cboAccType.Items.AddRange(New Object() {"SUSU", "SAVINGS", "CURRENT"})
        Me.cboAccType.Location = New System.Drawing.Point(175, 26)
        Me.cboAccType.Name = "cboAccType"
        Me.cboAccType.Size = New System.Drawing.Size(215, 27)
        Me.cboAccType.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(66, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 19)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Account Type :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Navy
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(528, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 17)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "GH₵"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(408, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(114, 19)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Starting Balance :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(6, 81)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 19)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Account No. :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(207, 583)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 56)
        Me.Panel2.TabIndex = 59
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(349, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 38)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Maroon
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Location = New System.Drawing.Point(269, 8)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 38)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Teal
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.Location = New System.Drawing.Point(140, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(123, 38)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "SAVE CHANGES"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.Location = New System.Drawing.Point(12, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 38)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "REGISTER"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ChkEdit
        '
        Me.ChkEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkEdit.AutoSize = True
        Me.ChkEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEdit.ForeColor = System.Drawing.Color.Lime
        Me.ChkEdit.Location = New System.Drawing.Point(325, 565)
        Me.ChkEdit.Name = "ChkEdit"
        Me.ChkEdit.Size = New System.Drawing.Size(257, 21)
        Me.ChkEdit.TabIndex = 58
        Me.ChkEdit.Text = "Please select to edit cutomer's detail"
        Me.ChkEdit.UseVisualStyleBackColor = True
        '
        'lblserial
        '
        Me.lblserial.AutoSize = True
        Me.lblserial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserial.ForeColor = System.Drawing.Color.White
        Me.lblserial.Location = New System.Drawing.Point(361, 84)
        Me.lblserial.Name = "lblserial"
        Me.lblserial.Size = New System.Drawing.Size(46, 19)
        Me.lblserial.TabIndex = 60
        Me.lblserial.Text = "serial"
        Me.lblserial.Visible = False
        '
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(882, 83)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(188, 199)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 61
        Me.picCustomer.TabStop = False
        '
        'PicSign
        '
        Me.PicSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicSign.Location = New System.Drawing.Point(882, 331)
        Me.PicSign.Name = "PicSign"
        Me.PicSign.Size = New System.Drawing.Size(188, 199)
        Me.PicSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSign.TabIndex = 62
        Me.PicSign.TabStop = False
        '
        'btnUpone
        '
        Me.btnUpone.BackColor = System.Drawing.Color.Teal
        Me.btnUpone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpone.Location = New System.Drawing.Point(882, 282)
        Me.btnUpone.Name = "btnUpone"
        Me.btnUpone.Size = New System.Drawing.Size(188, 38)
        Me.btnUpone.TabIndex = 4
        Me.btnUpone.Text = "UPLOAD PICTURE"
        Me.btnUpone.UseVisualStyleBackColor = False
        '
        'btnUPtwo
        '
        Me.btnUPtwo.BackColor = System.Drawing.Color.Teal
        Me.btnUPtwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUPtwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPtwo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUPtwo.Location = New System.Drawing.Point(882, 530)
        Me.btnUPtwo.Name = "btnUPtwo"
        Me.btnUPtwo.Size = New System.Drawing.Size(188, 46)
        Me.btnUPtwo.TabIndex = 63
        Me.btnUPtwo.Text = "UPLOAD SIGNATURE/THUMB PRINT"
        Me.btnUPtwo.UseVisualStyleBackColor = False
        '
        'lblAccNo
        '
        Me.lblAccNo.AutoSize = True
        Me.lblAccNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNo.ForeColor = System.Drawing.Color.White
        Me.lblAccNo.Location = New System.Drawing.Point(444, 84)
        Me.lblAccNo.Name = "lblAccNo"
        Me.lblAccNo.Size = New System.Drawing.Size(45, 19)
        Me.lblAccNo.TabIndex = 64
        Me.lblAccNo.Text = "         "
        Me.lblAccNo.Visible = False
        '
        'cboBranch
        '
        Me.cboBranch.AllowDrop = True
        Me.cboBranch.AutoCompleteCustomSource.AddRange(New String() {"Teller", "Loan Officer", "Admin"})
        Me.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.Location = New System.Drawing.Point(524, 77)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(257, 32)
        Me.cboBranch.TabIndex = 66
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(430, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 24)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Branch :"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode.ForeColor = System.Drawing.Color.White
        Me.lblcode.Location = New System.Drawing.Point(798, 84)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(46, 19)
        Me.lblcode.TabIndex = 67
        Me.lblcode.Text = "serial"
        Me.lblcode.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboIdType)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.TXTIDCARD)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(2, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(865, 48)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ID CARD DETAILS"
        '
        'cboIdType
        '
        Me.cboIdType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIdType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIdType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIdType.FormattingEnabled = True
        Me.cboIdType.Items.AddRange(New Object() {"VOTER ID", "GHANA CARD", "DRIVER LICENSE", "SSNIT", "PASSPORT"})
        Me.cboIdType.Location = New System.Drawing.Point(111, 15)
        Me.cboIdType.Name = "cboIdType"
        Me.cboIdType.Size = New System.Drawing.Size(275, 27)
        Me.cboIdType.TabIndex = 35
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(44, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 19)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "ID Type:"
        '
        'TXTIDCARD
        '
        Me.TXTIDCARD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTIDCARD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIDCARD.Location = New System.Drawing.Point(491, 16)
        Me.TXTIDCARD.Name = "TXTIDCARD"
        Me.TXTIDCARD.Size = New System.Drawing.Size(365, 26)
        Me.TXTIDCARD.TabIndex = 35
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(395, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 19)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "ID Card No. :"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AnimateReadOnly = False
        Me.txtAccountNo.BackColor = System.Drawing.Color.Maroon
        Me.txtAccountNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountNo.Depth = 0
        Me.txtAccountNo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAccountNo.ForeColor = System.Drawing.Color.White
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(109, 67)
        Me.txtAccountNo.MaxLength = 50
        Me.txtAccountNo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAccountNo.Multiline = False
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(246, 50)
        Me.txtAccountNo.TabIndex = 69
        Me.txtAccountNo.Text = ""
        Me.txtAccountNo.TrailingIcon = Nothing
        '
        'MaterialSwitch1
        '
        Me.MaterialSwitch1.AutoSize = True
        Me.MaterialSwitch1.Depth = 0
        Me.MaterialSwitch1.Location = New System.Drawing.Point(899, 593)
        Me.MaterialSwitch1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialSwitch1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialSwitch1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSwitch1.Name = "MaterialSwitch1"
        Me.MaterialSwitch1.Ripple = True
        Me.MaterialSwitch1.Size = New System.Drawing.Size(160, 37)
        Me.MaterialSwitch1.TabIndex = 70
        Me.MaterialSwitch1.Text = "LIGHT THEME"
        Me.MaterialSwitch1.UseVisualStyleBackColor = True
        Me.MaterialSwitch1.Visible = False
        '
        'lblAccountCode
        '
        Me.lblAccountCode.AutoSize = True
        Me.lblAccountCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountCode.ForeColor = System.Drawing.Color.White
        Me.lblAccountCode.Location = New System.Drawing.Point(7, 16)
        Me.lblAccountCode.Name = "lblAccountCode"
        Me.lblAccountCode.Size = New System.Drawing.Size(101, 19)
        Me.lblAccountCode.TabIndex = 63
        Me.lblAccountCode.Text = "Account Type :"
        Me.lblAccountCode.Visible = False
        '
        'frmNewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1080, 642)
        Me.Controls.Add(Me.MaterialSwitch1)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.cboBranch)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblAccNo)
        Me.Controls.Add(Me.btnUPtwo)
        Me.Controls.Add(Me.btnUpone)
        Me.Controls.Add(Me.PicSign)
        Me.Controls.Add(Me.picCustomer)
        Me.Controls.Add(Me.lblserial)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ChkEdit)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register New Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboTitle As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDOB As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboMStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDigitalAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtOcc As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNKrelationship As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNKfirstname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNKsurname As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNKmobile As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNKaddress As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ChkEdit As CheckBox
    Friend WithEvents cboAccType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblPre As Label
    Friend WithEvents lblserial As Label
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents PicSign As PictureBox
    Friend WithEvents btnUpone As Button
    Friend WithEvents btnUPtwo As Button
    Friend WithEvents lblAccNo As Label
    Friend WithEvents cboBranch As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents lblcode As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTIDCARD As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cboIdType As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtStartBalance As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialSwitch1 As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents lblAccountCode As Label
End Class
