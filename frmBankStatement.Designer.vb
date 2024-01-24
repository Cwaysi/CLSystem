<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBankStatement
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
        Me.txtAccountNo = New MaterialSkin.Controls.MaterialTextBox2()
        Me.cboyear = New MaterialSkin.Controls.MaterialComboBox()
        Me.cbomonth = New MaterialSkin.Controls.MaterialComboBox()
        Me.cboTo = New MaterialSkin.Controls.MaterialComboBox()
        Me.cboFrom = New MaterialSkin.Controls.MaterialComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.picGuarantor1 = New System.Windows.Forms.PictureBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.txtSurname = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.picGuarantor1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtAccountNo.Hint = "Enter Customer's Account Number"
        Me.txtAccountNo.LeadingIcon = Nothing
        Me.txtAccountNo.Location = New System.Drawing.Point(6, 78)
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
        Me.txtAccountNo.TabIndex = 91
        Me.txtAccountNo.TabStop = False
        Me.txtAccountNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccountNo.TrailingIcon = Nothing
        Me.txtAccountNo.UseSystemPasswordChar = False
        '
        'cboyear
        '
        Me.cboyear.AutoResize = False
        Me.cboyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboyear.Depth = 0
        Me.cboyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboyear.DropDownHeight = 174
        Me.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboyear.DropDownWidth = 121
        Me.cboyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboyear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Hint = "Year"
        Me.cboyear.IntegralHeight = False
        Me.cboyear.ItemHeight = 43
        Me.cboyear.Location = New System.Drawing.Point(6, 193)
        Me.cboyear.MaxDropDownItems = 4
        Me.cboyear.MouseState = MaterialSkin.MouseState.OUT
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(181, 49)
        Me.cboyear.StartIndex = 0
        Me.cboyear.TabIndex = 92
        '
        'cbomonth
        '
        Me.cbomonth.AutoResize = False
        Me.cbomonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbomonth.Depth = 0
        Me.cbomonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbomonth.DropDownHeight = 174
        Me.cbomonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomonth.DropDownWidth = 121
        Me.cbomonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cbomonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbomonth.FormattingEnabled = True
        Me.cbomonth.Hint = "Month"
        Me.cbomonth.IntegralHeight = False
        Me.cbomonth.ItemHeight = 43
        Me.cbomonth.Location = New System.Drawing.Point(198, 192)
        Me.cbomonth.MaxDropDownItems = 4
        Me.cbomonth.MouseState = MaterialSkin.MouseState.OUT
        Me.cbomonth.Name = "cbomonth"
        Me.cbomonth.Size = New System.Drawing.Size(181, 49)
        Me.cbomonth.StartIndex = 0
        Me.cbomonth.TabIndex = 93
        '
        'cboTo
        '
        Me.cboTo.AutoResize = False
        Me.cboTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTo.Depth = 0
        Me.cboTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboTo.DropDownHeight = 174
        Me.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTo.DropDownWidth = 121
        Me.cboTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboTo.FormattingEnabled = True
        Me.cboTo.Hint = "To"
        Me.cboTo.IntegralHeight = False
        Me.cboTo.ItemHeight = 43
        Me.cboTo.Location = New System.Drawing.Point(198, 251)
        Me.cboTo.MaxDropDownItems = 4
        Me.cboTo.MouseState = MaterialSkin.MouseState.OUT
        Me.cboTo.Name = "cboTo"
        Me.cboTo.Size = New System.Drawing.Size(181, 49)
        Me.cboTo.StartIndex = 0
        Me.cboTo.TabIndex = 95
        '
        'cboFrom
        '
        Me.cboFrom.AutoResize = False
        Me.cboFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFrom.Depth = 0
        Me.cboFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboFrom.DropDownHeight = 174
        Me.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFrom.DropDownWidth = 121
        Me.cboFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboFrom.FormattingEnabled = True
        Me.cboFrom.Hint = "From"
        Me.cboFrom.IntegralHeight = False
        Me.cboFrom.ItemHeight = 43
        Me.cboFrom.Location = New System.Drawing.Point(6, 252)
        Me.cboFrom.MaxDropDownItems = 4
        Me.cboFrom.MouseState = MaterialSkin.MouseState.OUT
        Me.cboFrom.Name = "cboFrom"
        Me.cboFrom.Size = New System.Drawing.Size(181, 49)
        Me.cboFrom.StartIndex = 0
        Me.cboFrom.TabIndex = 94
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(6, 129)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(376, 19)
        Me.MaterialLabel1.TabIndex = 96
        Me.MaterialLabel1.Text = "Please Enter Customer's Account No. And Press Enter"
        '
        'picGuarantor1
        '
        Me.picGuarantor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picGuarantor1.Location = New System.Drawing.Point(388, 78)
        Me.picGuarantor1.Name = "picGuarantor1"
        Me.picGuarantor1.Size = New System.Drawing.Size(188, 199)
        Me.picGuarantor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGuarantor1.TabIndex = 111
        Me.picGuarantor1.TabStop = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(6, 170)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(51, 19)
        Me.MaterialLabel2.TabIndex = 112
        Me.MaterialLabel2.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Depth = 0
        Me.lblStatus.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblStatus.Location = New System.Drawing.Point(63, 171)
        Me.lblStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(13, 19)
        Me.lblStatus.TabIndex = 113
        Me.lblStatus.Text = "   "
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(420, 279)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(133, 19)
        Me.MaterialLabel3.TabIndex = 114
        Me.MaterialLabel3.Text = "Customer's Picture"
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Global.CLSystem.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(399, 313)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(94, 36)
        Me.btnClose.TabIndex = 116
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
        Me.btnclear.Location = New System.Drawing.Point(277, 313)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(112, 36)
        Me.btnclear.TabIndex = 115
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
        Me.btnSave.Location = New System.Drawing.Point(95, 313)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(174, 36)
        Me.btnSave.TabIndex = 117
        Me.btnSave.Text = "View Statement"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSurname
        '
        Me.txtSurname.AutoSize = True
        Me.txtSurname.Depth = 0
        Me.txtSurname.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSurname.Location = New System.Drawing.Point(6, 151)
        Me.txtSurname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(51, 19)
        Me.txtSurname.TabIndex = 118
        Me.txtSurname.Text = "Status:"
        '
        'frmBankStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 367)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.picGuarantor1)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.cboTo)
        Me.Controls.Add(Me.cboFrom)
        Me.Controls.Add(Me.cbomonth)
        Me.Controls.Add(Me.cboyear)
        Me.Controls.Add(Me.txtAccountNo)
        Me.MaximizeBox = False
        Me.Name = "frmBankStatement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer's Bank Statement"
        CType(Me.picGuarantor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAccountNo As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents cboyear As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cbomonth As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cboTo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cboFrom As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents picGuarantor1 As PictureBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtSurname As MaterialSkin.Controls.MaterialLabel
End Class
