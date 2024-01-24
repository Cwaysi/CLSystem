Imports Microsoft.ReportingServices
Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Public Class frmReportApplication
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
    Private Sub frmReportLoanApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub LoadReport()
        Dim rpDS As ReportDataSource
        Dim rpDSS As ReportDataSource
        Dim rpDSSS As ReportDataSource

        Me.ReportViewer1.RefreshReport()
        Try

            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Report\Report3.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DataSet2
            Dim dss As New DataSet5
            Dim dsss As New DataSet4
            Dim da As New SqlDataAdapter
            Dim daa As New SqlDataAdapter
            Dim daaa As New SqlDataAdapter

            conn.Open()
            da.SelectCommand = New SqlCommand("select Name,Address,Telephone,Branch,picture from Bus_Info", conn)
            da.Fill(ds.Tables("dtbus"))
            conn.Close()


            conn.Open()
            daa.SelectCommand = New SqlCommand("Select date, business_name, Business_address, amount, purpose, installment, Period_Repayment, security, interest from loan where Account_no='" & frmLoanRequest.txtAccountNo.Text.Trim & "'
                 and loan_No='" & frmLoanRequest.lblserial3.Text.Trim & "'", conn)
            daa.Fill(dss.Tables("dtloan"))
            conn.Close()

            conn.Open()
            daaa.SelectCommand = New SqlCommand("Select surname,firstname, mobile, branch, picture, address from customer where Account_no='" & frmLoanRequest.txtAccountNo.Text.Trim & "'", conn)
            daaa.Fill(dsss.Tables("dtcus"))
            conn.Close()

            rpDS = New ReportDataSource("DataSet2", ds.Tables("dtbus"))
            rpDSS = New ReportDataSource("DataSet5", dss.Tables("dtloan"))
            rpDSSS = New ReportDataSource("DataSet4", dsss.Tables("dtcus"))


            Dim namee As String = frmLoanRequest.txtAccountNo.Text.Trim
            Dim tParaBusAdd As New ReportParameter("AccNo", namee)
            ReportViewer1.LocalReport.SetParameters(tParaBusAdd)

            Dim acc As Double = Val(frmLoanRequest.txtLoanAmount.Text.Trim)
            Dim nameeee As String = Format(acc, "#,##0.00")
            Dim nameee As String = acc
            Dim tParaBusAddd As New ReportParameter("Amnt", nameee)
            ReportViewer1.LocalReport.SetParameters(tParaBusAddd)

            Dim seta As String = frmLoanRequest.txtInterest.Text.Trim & "%"
            Dim tParaBusnum As New ReportParameter("IntRate", seta)
            ReportViewer1.LocalReport.SetParameters(tParaBusnum)



            ReportViewer1.LocalReport.DataSources.Add(rpDS)
            ReportViewer1.LocalReport.DataSources.Add(rpDSS)
            ReportViewer1.LocalReport.DataSources.Add(rpDSSS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ' Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "load report")
        End Try
    End Sub
End Class