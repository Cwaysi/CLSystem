<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankSetup
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
        Me.txtBankName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtAddress = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtTel = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cboBranch = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnUpone = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnEdit = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBankName
        '
        Me.txtBankName.AnimateReadOnly = False
        Me.txtBankName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtBankName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBankName.Depth = 0
        Me.txtBankName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBankName.HideSelection = True
        Me.txtBankName.Hint = "Bank Name"
        Me.txtBankName.LeadingIcon = Nothing
        Me.txtBankName.Location = New System.Drawing.Point(18, 88)
        Me.txtBankName.MaxLength = 32767
        Me.txtBankName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBankName.PrefixSuffixText = Nothing
        Me.txtBankName.ReadOnly = False
        Me.txtBankName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBankName.SelectedText = ""
        Me.txtBankName.SelectionLength = 0
        Me.txtBankName.SelectionStart = 0
        Me.txtBankName.ShortcutsEnabled = True
        Me.txtBankName.Size = New System.Drawing.Size(565, 48)
        Me.txtBankName.TabIndex = 0
        Me.txtBankName.TabStop = False
        Me.txtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBankName.TrailingIcon = Nothing
        Me.txtBankName.UseSystemPasswordChar = False
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
        Me.txtAddress.Location = New System.Drawing.Point(18, 142)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PrefixSuffixText = Nothing
        Me.txtAddress.ReadOnly = False
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(565, 48)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.TabStop = False
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddress.TrailingIcon = Nothing
        Me.txtAddress.UseSystemPasswordChar = False
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
        Me.txtTel.Location = New System.Drawing.Point(18, 196)
        Me.txtTel.MaxLength = 32767
        Me.txtTel.MouseState = MaterialSkin.MouseState.OUT
        Me.txtTel.Name = "txtTel"
        Me.txtTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.PrefixSuffixText = Nothing
        Me.txtTel.ReadOnly = False
        Me.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTel.SelectedText = ""
        Me.txtTel.SelectionLength = 0
        Me.txtTel.SelectionStart = 0
        Me.txtTel.ShortcutsEnabled = True
        Me.txtTel.Size = New System.Drawing.Size(565, 48)
        Me.txtTel.TabIndex = 2
        Me.txtTel.TabStop = False
        Me.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTel.TrailingIcon = Nothing
        Me.txtTel.UseSystemPasswordChar = False
        '
        'cboBranch
        '
        Me.cboBranch.AutoResize = False
        Me.cboBranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboBranch.Depth = 0
        Me.cboBranch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboBranch.DropDownHeight = 174
        Me.cboBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBranch.DropDownWidth = 121
        Me.cboBranch.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboBranch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboBranch.FormattingEnabled = True
        Me.cboBranch.Hint = "Branch"
        Me.cboBranch.IntegralHeight = False
        Me.cboBranch.ItemHeight = 43
        Me.cboBranch.Location = New System.Drawing.Point(18, 250)
        Me.cboBranch.MaxDropDownItems = 4
        Me.cboBranch.MouseState = MaterialSkin.MouseState.OUT
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(565, 49)
        Me.cboBranch.StartIndex = 0
        Me.cboBranch.TabIndex = 3
        '
        'btnUpone
        '
        Me.btnUpone.BackColor = System.Drawing.Color.Teal
        Me.btnUpone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpone.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpone.Location = New System.Drawing.Point(603, 316)
        Me.btnUpone.Name = "btnUpone"
        Me.btnUpone.Size = New System.Drawing.Size(188, 38)
        Me.btnUpone.TabIndex = 62
        Me.btnUpone.Text = "UPLOAD BANK LOGO"
        Me.btnUpone.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLogo.Location = New System.Drawing.Point(603, 117)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(188, 199)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 63
        Me.picLogo.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Global.CLSystem.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(438, 337)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(94, 36)
        Me.btnClose.TabIndex = 113
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
        Me.btnclear.Location = New System.Drawing.Point(316, 337)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(112, 36)
        Me.btnclear.TabIndex = 112
        Me.btnclear.Text = "Refresh"
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
        Me.btnEdit.Location = New System.Drawing.Point(151, 337)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnEdit.Size = New System.Drawing.Size(157, 36)
        Me.btnEdit.TabIndex = 111
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
        Me.btnSave.Location = New System.Drawing.Point(57, 337)
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
        'frmBankSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 392)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpone)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.cboBranch)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtBankName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBankSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBankSetup"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBankName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtTel As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboBranch As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnUpone As Button
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
End Class
