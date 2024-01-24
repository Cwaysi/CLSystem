Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Public Class frmReportSales
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

    Private Sub frmReportSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
        LoadReport()
        busInfo()
    End Sub
    Sub busInfo()
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmdd As New SqlCommand("select Name,Address,Telephone,Branch from Bus_Info", conn)
            Dim myreaderd As SqlDataReader
            myreaderd = sqlcmdd.ExecuteReader()
            myreaderd.Read()
            If myreaderd.HasRows Then
                Dim bname As String = myreaderd.Item("Name").ToString
                Dim bloc As String = myreaderd.Item("Address").ToString
                Dim badd As String = myreaderd.Item("Telephone").ToString
                'cboBranch.Text = myreaderd.Item("Branch").ToString
                Dim myDate As Date = Date.Today.Date
                Dim rdatee As String = frmTransactionReport.lbldate.Text.Trim
                Dim Roficer As String = Main.lblofficer.Text.Trim
                myreaderd.Dispose()
                myreaderd.Close()
                conn.Close()
                Dim tParaBusname As New ReportParameter("Rbusname", bname)
                ReportViewer1.LocalReport.SetParameters(tParaBusname)
                Dim tParaBusLoc As New ReportParameter("Rbusloacation", bloc)
                ReportViewer1.LocalReport.SetParameters(tParaBusLoc)
                Dim tParaBusAdd As New ReportParameter("RbusNumber", badd)
                ReportViewer1.LocalReport.SetParameters(tParaBusAdd)
                Dim tParadate As New ReportParameter("RDate", Rdatee)
                ReportViewer1.LocalReport.SetParameters(tParadate)
                Dim tParaofficer As New ReportParameter("Rofficer", Roficer)
                ReportViewer1.LocalReport.SetParameters(tParaofficer)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub LoadReport()
        Dim rpDS As ReportDataSource

        Me.ReportViewer1.RefreshReport()
        Try

            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Report\Report1.rdlc"
                .DataSources.Clear()
            End With
            Dim ds As New DataSet1
            Dim da As New SqlDataAdapter

            conn.Open()
            da.SelectCommand = New SqlCommand("select date,time,Account_no,surname,firstname,deposit_by,type,form_no,deposit,widrawal from transactions where date='" & frmTransactionReport.lbldate.Text.Trim & "' and Entry_by='" & Main.lblofficer.Text & "'", conn)
            da.Fill(ds.Tables("dtSales"))
            conn.Close()

            rpDS = New ReportDataSource("DataSet1", ds.Tables("dtSales"))
            busInfo()
            ReportViewer1.LocalReport.DataSources.Add(rpDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ' Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class