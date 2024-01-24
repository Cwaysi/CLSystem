<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerStatus
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
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.txtStatus = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtbranch = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtFirstname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSurname = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.picCustomer = New System.Windows.Forms.PictureBox()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.cboStatus = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtDesc = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialCard2.SuspendLayout()
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MaterialCard2.Controls.Add(Me.txtStatus)
        Me.MaterialCard2.Controls.Add(Me.txtbranch)
        Me.MaterialCard2.Controls.Add(Me.txtFirstname)
        Me.MaterialCard2.Controls.Add(Me.txtSurname)
        Me.MaterialCard2.Controls.Add(Me.txtAccountNo)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(4, 67)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(393, 279)
        Me.MaterialCard2.TabIndex = 72
        '
        'txtStatus
        '
        Me.txtStatus.AnimateReadOnly = False
        Me.txtStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtStatus.Depth = 0
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtStatus.HideSelection = True
        Me.txtStatus.Hint = "Status"
        Me.txtStatus.LeadingIcon = Nothing
        Me.txtStatus.Location = New System.Drawing.Point(3, 222)
        Me.txtStatus.MaxLength = 32767
        Me.txtStatus.MouseState = MaterialSkin.MouseState.OUT
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PrefixSuffixText = Nothing
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.SelectionLength = 0
        Me.txtStatus.SelectionStart = 0
        Me.txtStatus.ShortcutsEnabled = True
        Me.txtStatus.Size = New System.Drawing.Size(373, 48)
        Me.txtStatus.TabIndex = 94
        Me.txtStatus.TabStop = False
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtStatus.TrailingIcon = Nothing
        Me.txtStatus.UseSystemPasswordChar = False
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
        'picCustomer
        '
        Me.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picCustomer.Location = New System.Drawing.Point(400, 67)
        Me.picCustomer.Name = "picCustomer"
        Me.picCustomer.Size = New System.Drawing.Size(249, 279)
        Me.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCustomer.TabIndex = 73
        Me.picCustomer.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Global.CLSystem.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(555, 413)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(94, 36)
        Me.btnClose.TabIndex = 111
        Me.btnClose.Text = "Close"
        Me.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnClose.UseAccentColor = False
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Global.CLSystem.My.Resources.Resources.save1
        Me.btnSave.Location = New System.Drawing.Point(559, 367)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 110
        Me.btnSave.Text = "Save"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.AutoResize = False
        Me.cboStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboStatus.Depth = 0
        Me.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboStatus.DropDownHeight = 174
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.DropDownWidth = 121
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Hint = "Change Status To"
        Me.cboStatus.IntegralHeight = False
        Me.cboStatus.ItemHeight = 43
        Me.cboStatus.Items.AddRange(New Object() {"", "ACTIVE", "FREEZED", "DORMANT", "BLOCKED", "INVESTIGATING", "WANTED"})
        Me.cboStatus.Location = New System.Drawing.Point(4, 356)
        Me.cboStatus.MaxDropDownItems = 4
        Me.cboStatus.MouseState = MaterialSkin.MouseState.OUT
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(544, 49)
        Me.cboStatus.StartIndex = 0
        Me.cboStatus.TabIndex = 112
        '
        'txtDesc
        '
        Me.txtDesc.AnimateReadOnly = False
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.Depth = 0
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtDesc.Hint = "Description"
        Me.txtDesc.LeadingIcon = Nothing
        Me.txtDesc.Location = New System.Drawing.Point(4, 411)
        Me.txtDesc.MaxLength = 32767
        Me.txtDesc.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDesc.Multiline = False
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(544, 50)
        Me.txtDesc.TabIndex = 113
        Me.txtDesc.Text = ""
        Me.txtDesc.TrailingIcon = Nothing
        Me.txtDesc.WordWrap = False
        '
        'frmCustomerStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 472)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.picCustomer)
        Me.Controls.Add(Me.MaterialCard2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Status"
        Me.MaterialCard2.ResumeLayout(False)
        CType(Me.picCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents txtbranch As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtFirstname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSurname As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents picCustomer As PictureBox
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtStatus As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboStatus As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtDesc As MaterialSkin.Controls.MaterialTextBox
End Class
