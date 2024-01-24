<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMinSetup
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
        Me.txtMinAmount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnClose = New MaterialSkin.Controls.MaterialButton()
        Me.btnclear = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.cboAccounts = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtNewAmount = New MaterialSkin.Controls.MaterialTextBox2()
        Me.SuspendLayout()
        '
        'txtMinAmount
        '
        Me.txtMinAmount.AnimateReadOnly = False
        Me.txtMinAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtMinAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMinAmount.Depth = 0
        Me.txtMinAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMinAmount.HideSelection = True
        Me.txtMinAmount.Hint = "Minimum Amount"
        Me.txtMinAmount.LeadingIcon = Nothing
        Me.txtMinAmount.Location = New System.Drawing.Point(6, 133)
        Me.txtMinAmount.MaxLength = 32767
        Me.txtMinAmount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtMinAmount.Name = "txtMinAmount"
        Me.txtMinAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMinAmount.PrefixSuffixText = Nothing
        Me.txtMinAmount.ReadOnly = True
        Me.txtMinAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMinAmount.SelectedText = ""
        Me.txtMinAmount.SelectionLength = 0
        Me.txtMinAmount.SelectionStart = 0
        Me.txtMinAmount.ShortcutsEnabled = True
        Me.txtMinAmount.Size = New System.Drawing.Size(391, 48)
        Me.txtMinAmount.TabIndex = 0
        Me.txtMinAmount.TabStop = False
        Me.txtMinAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMinAmount.TrailingIcon = Nothing
        Me.txtMinAmount.UseSystemPasswordChar = False
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClose.Depth = 0
        Me.btnClose.HighEmphasis = True
        Me.btnClose.Icon = Global.CLSystem.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(270, 241)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClose.Size = New System.Drawing.Size(94, 36)
        Me.btnClose.TabIndex = 112
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
        Me.btnclear.Location = New System.Drawing.Point(148, 241)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnclear.Size = New System.Drawing.Size(112, 36)
        Me.btnclear.TabIndex = 111
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
        Me.btnSave.Location = New System.Drawing.Point(55, 241)
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
        'cboAccounts
        '
        Me.cboAccounts.AutoResize = False
        Me.cboAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAccounts.Depth = 0
        Me.cboAccounts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cboAccounts.DropDownHeight = 174
        Me.cboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccounts.DropDownWidth = 121
        Me.cboAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cboAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cboAccounts.FormattingEnabled = True
        Me.cboAccounts.IntegralHeight = False
        Me.cboAccounts.ItemHeight = 43
        Me.cboAccounts.Location = New System.Drawing.Point(6, 78)
        Me.cboAccounts.MaxDropDownItems = 4
        Me.cboAccounts.MouseState = MaterialSkin.MouseState.OUT
        Me.cboAccounts.Name = "cboAccounts"
        Me.cboAccounts.Size = New System.Drawing.Size(391, 49)
        Me.cboAccounts.StartIndex = 0
        Me.cboAccounts.TabIndex = 113
        '
        'txtNewAmount
        '
        Me.txtNewAmount.AnimateReadOnly = False
        Me.txtNewAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtNewAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNewAmount.Depth = 0
        Me.txtNewAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtNewAmount.HideSelection = True
        Me.txtNewAmount.Hint = "New Minimum Amount"
        Me.txtNewAmount.LeadingIcon = Nothing
        Me.txtNewAmount.Location = New System.Drawing.Point(6, 184)
        Me.txtNewAmount.MaxLength = 32767
        Me.txtNewAmount.MouseState = MaterialSkin.MouseState.OUT
        Me.txtNewAmount.Name = "txtNewAmount"
        Me.txtNewAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewAmount.PrefixSuffixText = Nothing
        Me.txtNewAmount.ReadOnly = False
        Me.txtNewAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNewAmount.SelectedText = ""
        Me.txtNewAmount.SelectionLength = 0
        Me.txtNewAmount.SelectionStart = 0
        Me.txtNewAmount.ShortcutsEnabled = True
        Me.txtNewAmount.Size = New System.Drawing.Size(391, 48)
        Me.txtNewAmount.TabIndex = 114
        Me.txtNewAmount.TabStop = False
        Me.txtNewAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtNewAmount.TrailingIcon = Nothing
        Me.txtNewAmount.UseSystemPasswordChar = False
        '
        'frmMinSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 287)
        Me.Controls.Add(Me.txtNewAmount)
        Me.Controls.Add(Me.cboAccounts)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMinAmount)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMinSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minimum Balance Setup"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMinAmount As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cboAccounts As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtNewAmount As MaterialSkin.Controls.MaterialTextBox2
End Class
