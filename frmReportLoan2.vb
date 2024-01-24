Imports Microsoft.ReportingServices
Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Public Class frmReportLoan2
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Dim lblyearid As String = Now.ToString("yy")
    Dim lblMonthID As String = Now.ToString("MM")
    Dim TextToPrint As String = ""
    Dim myDate As Date = Date.Today.Date
    Dim seen As String = (myDate.ToString("dd-MMM-yy"))
    Dim lblyear As String = Now.ToString("yyyy")
    Dim mnt As String = Now.ToString("MMM")
    Dim dt As String = TimeOfDay.ToString("h:mm tt")
    Private Sub frmReportLoan2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub
    Sub LoadReport()
        Dim rpDS As ReportDataSource
        Dim rpDSS As ReportDataSource

        Me.ReportViewer1.RefreshReport()
        Try

            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Report\Report2.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DataSet2
            Dim dss As New DataSet3
            Dim da As New SqlDataAdapter
            Dim daa As New SqlDataAdapter

            conn.Open()
            da.SelectCommand = New SqlCommand("select Name,Address,Telephone,Branch,picture from Bus_Info", conn)
            da.Fill(ds.Tables("dtbus"))
            conn.Close()


            conn.Open()
            daa.SelectCommand = New SqlCommand("Select picture from Guarantor where Account_no='" & frmLoanRequest.txtAccountNo.Text.Trim & "'
                and guarantor_No='" & frmLoanRequest.lblserial2.Text.Trim & "'", conn)
            daa.Fill(dss.Tables("dtImg"))
            conn.Close()

            rpDS = New ReportDataSource("DataSet2", ds.Tables("dtbus"))
            rpDSS = New ReportDataSource("DataSet3", dss.Tables("dtImg"))

            Dim namee As String = frmLoanRequest.txtGFullname2.Text.Trim
            Dim tParaBusAdd As New ReportParameter("Gfullname", namee)
            ReportViewer1.LocalReport.SetParameters(tParaBusAdd)

            Dim seta As String = frmLoanRequest.txtGTel2.Text.Trim
            Dim tParaBusnum As New ReportParameter("Gtelephone", seta)
            ReportViewer1.LocalReport.SetParameters(tParaBusnum)

            Dim loc As String = frmLoanRequest.txtGAddress2.Text.Trim
            Dim tParaBusloc As New ReportParameter("Gaddress", loc)
            ReportViewer1.LocalReport.SetParameters(tParaBusloc)

            Dim occ As String = frmLoanRequest.txtGOccupation2.Text.Trim
            Dim tParaBusocc As New ReportParameter("Goccupation", occ)
            ReportViewer1.LocalReport.SetParameters(tParaBusocc)

            Dim idd As String = frmLoanRequest.cboGIdType2.Text.Trim
            Dim tParaBusidd As New ReportParameter("Gidtype", idd)
            ReportViewer1.LocalReport.SetParameters(tParaBusidd)

            Dim iddt As String = frmLoanRequest.TXTGIDCARD2.Text.Trim
            Dim tParaBusiddt As New ReportParameter("Gidnumber", iddt)
            ReportViewer1.LocalReport.SetParameters(tParaBusiddt)

            Dim iddtf As String = "Guarantor for " & frmLoanRequest.txtAccountNo.Text.Trim & " - " & frmLoanRequest.txtSurname.Text.Trim & " " & frmLoanRequest.txtFirstname.Text.Trim
            Dim tParaBusiddtf As New ReportParameter("Gfor", iddtf)
            ReportViewer1.LocalReport.SetParameters(tParaBusiddtf)

            ReportViewer1.LocalReport.DataSources.Add(rpDS)
            ReportViewer1.LocalReport.DataSources.Add(rpDSS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ' Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "load report")
        End Try
    End Sub
End Class