<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionReport
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
        Me.MaterialSwitch1 = New MaterialSkin.Controls.MaterialSwitch()
        Me.btnView = New MaterialSkin.Controls.MaterialButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbldate = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'MaterialSwitch1
        '
        Me.MaterialSwitch1.AutoSize = True
        Me.MaterialSwitch1.Depth = 0
        Me.MaterialSwitch1.Location = New System.Drawing.Point(13, 92)
        Me.MaterialSwitch1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialSwitch1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialSwitch1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSwitch1.Name = "MaterialSwitch1"
        Me.MaterialSwitch1.Ripple = True
        Me.MaterialSwitch1.Size = New System.Drawing.Size(111, 37)
        Me.MaterialSwitch1.TabIndex = 0
        Me.MaterialSwitch1.Text = "Specify"
        Me.MaterialSwitch1.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnView.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnView.Depth = 0
        Me.btnView.HighEmphasis = True
        Me.btnView.Icon = Nothing
        Me.btnView.Location = New System.Drawing.Point(314, 93)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnView.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnView.Name = "btnView"
        Me.btnView.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnView.Size = New System.Drawing.Size(119, 36)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View  Report"
        Me.btnView.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnView.UseAccentColor = False
        Me.btnView.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Depth = 0
        Me.lbldate.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbldate.Location = New System.Drawing.Point(138, 78)
        Me.lbldate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(17, 19)
        Me.lbldate.TabIndex = 3
        Me.lbldate.Text = "    "
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(20, 78)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(84, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "View Today"
        '
        'frmTransactionReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 140)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.MaterialSwitch1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransactionReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialSwitch1 As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents btnView As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbldate As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
