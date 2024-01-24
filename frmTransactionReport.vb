Imports MaterialSkin
Public Class frmTransactionReport
    Dim lblyearid As String = Now.ToString("yy")
    Dim lblMonthID As String = Now.ToString("MM")
    Dim TextToPrint As String = ""
    Dim myDate As Date = Date.Today.Date
    Dim seen As String = (myDate.ToString("dd-MMM-yy"))
    Dim lblyear As String = Now.ToString("yyyy")
    Dim mnt As String = Now.ToString("MMM")
    Dim dt As String = TimeOfDay.ToString("h:mm tt")
    Private Sub frmTransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        'SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        MaterialSwitch1.Checked = False
        DateTimePicker1.Enabled = False
        lbldate.Text = seen
        MaterialLabel1.Text = "View Today"
    End Sub

    Private Sub MaterialSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialSwitch1.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            DateTimePicker1.Enabled = True
            MaterialLabel1.Text = ""
        End If
        If MaterialSwitch1.Checked = False Then
            DateTimePicker1.Enabled = False
            lbldate.Text = seen
            MaterialLabel1.Text = "View Today"
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmReportSales.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        lbldate.Text = DateTimePicker1.Text.Trim
        MaterialLabel1.Text = ""
    End Sub

    Private Sub lbldate_TextChanged(sender As Object, e As EventArgs) Handles lbldate.TextChanged
        If lbldate.Text.Trim = seen Then
            MaterialLabel1.Text = "View Today"
        Else
            MaterialLabel1.Text = ""
        End If
    End Sub
End Class