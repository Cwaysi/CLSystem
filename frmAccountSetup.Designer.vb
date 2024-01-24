<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountSetup
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
        Me.ChkEdit = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAccName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.cboAccCode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkEdit
        '
        Me.ChkEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkEdit.AutoSize = True
        Me.ChkEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkEdit.Location = New System.Drawing.Point(163, 186)
        Me.ChkEdit.Name = "ChkEdit"
        Me.ChkEdit.Size = New System.Drawing.Size(191, 17)
        Me.ChkEdit.TabIndex = 31
        Me.ChkEdit.Text = "Please select to edit Account Type"
        Me.ChkEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(18, 209)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 56)
        Me.Panel2.TabIndex = 32
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(306, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 38)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(387, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 38)
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
        Me.btnClear.Location = New System.Drawing.Point(225, 8)
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
        Me.btnEdit.Location = New System.Drawing.Point(96, 8)
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
        Me.btnSave.Location = New System.Drawing.Point(15, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtAccName
        '
        Me.txtAccName.AnimateReadOnly = False
        Me.txtAccName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtAccName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAccName.Depth = 0
        Me.txtAccName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtAccName.HideSelection = True
        Me.txtAccName.Hint = "Account Type Name"
        Me.txtAccName.LeadingIcon = Nothing
        Me.txtAccName.Location = New System.Drawing.Point(63, 132)
        Me.txtAccName.MaxLength = 32767
        Me.txtAccName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccName.PrefixSuffixText = Nothing
        Me.txtAccName.ReadOnly = False
        Me.txtAccName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAccName.SelectedText = ""
        Me.txtAccName.SelectionLength = 0
        Me.txtAccName.SelectionStart = 0
        Me.txtAccName.ShortcutsEnabled = True
        Me.txtAccName.Size = New System.Drawing.Size(391, 48)
        Me.txtAccName.TabIndex = 116
        Me.txtAccName.TabStop = False
        Me.txtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAccName.TrailingIcon = Nothing
        Me.txtAccName.UseSystemPasswordChar = False
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode.Location = New System.Drawing.Point(379, 50)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(131, 24)
        Me.lblcode.TabIndex = 117
        Me.lblcode.Text = "Branch Code :"
        Me.lblcode.Visible = False
        '
        'cboAccCode
        '
        Me.cboAccCode.AllowDrop = True
        Me.cboAccCode.AutoCompleteCustomSource.AddRange(New String() {"Teller", "Loan Officer", "Admin"})
        Me.cboAccCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAccCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccCode.FormattingEnabled = True
        Me.cboAccCode.Location = New System.Drawing.Point(167, 94)
        Me.cboAccCode.Name = "cboAccCode"
        Me.cboAccCode.Size = New System.Drawing.Size(287, 32)
        Me.cboAccCode.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Account Code :"
        '
        'frmAccountSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 280)
        Me.Controls.Add(Me.cboAccCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.txtAccName)
        Me.Controls.Add(Me.ChkEdit)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccountSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Type Setup"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChkEdit As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAccName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents lblcode As Label
    Friend WithEvents cboAccCode As ComboBox
    Friend WithEvents Label2 As Label
End Class
