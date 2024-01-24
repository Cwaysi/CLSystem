<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameTextBoxx = New MaterialSkin.Controls.MaterialTextBox2()
        Me.PasswordTextBoxx = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnlogin = New MaterialSkin.Controls.MaterialButton()
        Me.btnClear = New MaterialSkin.Controls.MaterialButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameTextBoxx
        '
        Me.UsernameTextBoxx.AnimateReadOnly = False
        Me.UsernameTextBoxx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UsernameTextBoxx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UsernameTextBoxx.Depth = 0
        Me.UsernameTextBoxx.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UsernameTextBoxx.HideSelection = True
        Me.UsernameTextBoxx.Hint = "Enter Username"
        Me.UsernameTextBoxx.LeadingIcon = Nothing
        Me.UsernameTextBoxx.Location = New System.Drawing.Point(12, 144)
        Me.UsernameTextBoxx.MaxLength = 32767
        Me.UsernameTextBoxx.MouseState = MaterialSkin.MouseState.OUT
        Me.UsernameTextBoxx.Name = "UsernameTextBoxx"
        Me.UsernameTextBoxx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBoxx.PrefixSuffixText = Nothing
        Me.UsernameTextBoxx.ReadOnly = False
        Me.UsernameTextBoxx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UsernameTextBoxx.SelectedText = ""
        Me.UsernameTextBoxx.SelectionLength = 0
        Me.UsernameTextBoxx.SelectionStart = 0
        Me.UsernameTextBoxx.ShortcutsEnabled = True
        Me.UsernameTextBoxx.Size = New System.Drawing.Size(444, 48)
        Me.UsernameTextBoxx.TabIndex = 0
        Me.UsernameTextBoxx.TabStop = False
        Me.UsernameTextBoxx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UsernameTextBoxx.TrailingIcon = Nothing
        Me.UsernameTextBoxx.UseSystemPasswordChar = False
        '
        'PasswordTextBoxx
        '
        Me.PasswordTextBoxx.AnimateReadOnly = False
        Me.PasswordTextBoxx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PasswordTextBoxx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PasswordTextBoxx.Depth = 0
        Me.PasswordTextBoxx.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PasswordTextBoxx.HideSelection = True
        Me.PasswordTextBoxx.Hint = "Enter Password"
        Me.PasswordTextBoxx.LeadingIcon = Nothing
        Me.PasswordTextBoxx.Location = New System.Drawing.Point(12, 198)
        Me.PasswordTextBoxx.MaxLength = 32767
        Me.PasswordTextBoxx.MouseState = MaterialSkin.MouseState.OUT
        Me.PasswordTextBoxx.Name = "PasswordTextBoxx"
        Me.PasswordTextBoxx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBoxx.PrefixSuffixText = Nothing
        Me.PasswordTextBoxx.ReadOnly = False
        Me.PasswordTextBoxx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PasswordTextBoxx.SelectedText = ""
        Me.PasswordTextBoxx.SelectionLength = 0
        Me.PasswordTextBoxx.SelectionStart = 0
        Me.PasswordTextBoxx.ShortcutsEnabled = True
        Me.PasswordTextBoxx.Size = New System.Drawing.Size(444, 48)
        Me.PasswordTextBoxx.TabIndex = 1
        Me.PasswordTextBoxx.TabStop = False
        Me.PasswordTextBoxx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PasswordTextBoxx.TrailingIcon = Nothing
        Me.PasswordTextBoxx.UseSystemPasswordChar = False
        '
        'btnlogin
        '
        Me.btnlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnlogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnlogin.Depth = 0
        Me.btnlogin.HighEmphasis = True
        Me.btnlogin.Icon = Nothing
        Me.btnlogin.Location = New System.Drawing.Point(380, 255)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnlogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnlogin.Size = New System.Drawing.Size(64, 36)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.Text = "Login"
        Me.btnlogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnlogin.UseAccentColor = False
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnClear.Depth = 0
        Me.btnClear.HighEmphasis = True
        Me.btnClear.Icon = Nothing
        Me.btnClear.Location = New System.Drawing.Point(306, 255)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClear.Name = "btnClear"
        Me.btnClear.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnClear.Size = New System.Drawing.Size(66, 36)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnClear.UseAccentColor = False
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CLSystem.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(172, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.ClientSize = New System.Drawing.Size(469, 311)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.PasswordTextBoxx)
        Me.Controls.Add(Me.UsernameTextBoxx)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crystal Bank System - Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLx As Label
    Friend WithEvents UsernameTextBoxx As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents PasswordTextBoxx As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnlogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnClear As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
