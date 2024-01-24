Imports MaterialSkin
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmBankStatement
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
    Dim arrimage() As Byte
    Dim aarrimage() As Byte
    Dim imgpath As String
    Dim imgpathh As String
    Private Sub frmBankStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)


        picGuarantor1.Image = Nothing
        txtAccountNo.Text = ""
        txtSurname.Text = ""
        lblStatus.Text = ""
        cboyear.Items.Clear()
        cbomonth.Items.Clear()
        cboFrom.Items.Clear()
        cboTo.Items.Clear()
        txtAccountNo.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call frmBankStatement_Load(sender, New EventArgs())
    End Sub

    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtAccountNo.Text.Trim = "" Then
                MsgBox("Please enter account number", vbExclamation, "Entry Error")
                txtAccountNo.Focus()
                Exit Sub
            End If
            Try
                Dim sqlcmdID As New SqlCommand("Select * from customer where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)
                Dim arione() As Byte
                Dim aritwo() As Byte

                txtSurname.Text = "Customer's Name: " & table.Rows(0)(3).ToString() & " " & table.Rows(0)(4).ToString()
                ' txtbranch.Text = table.Rows(0)(18).ToString()

                arione = table.Rows(0)(16)
                aritwo = table.Rows(0)(17)
                lblStatus.Text = table.Rows(0)(14)


                Dim mstreamm As New System.IO.MemoryStream(arione)
                Dim mstreammm As New System.IO.MemoryStream(aritwo)
                picGuarantor1.Image = Image.FromStream(mstreamm)
                ' PicSign.Image = Image.FromStream(mstreammm)
                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
                cboyear.Focus()
                If Not lblStatus.Text = "" Then
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                    conn.Open()
                    Dim cmdGridsM As String = "SELECT distinct year FROM transactions where account_no ='" & txtAccountNo.Text.Trim & "' ORDER BY year DESC"
                    Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
                    Dim dt As New DataTable
                    Adpt.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        With cboyear
                            .Items.Clear()
                            For i As Integer = 0 To dt.Rows.Count - 1
                                .Items.Add(dt.Rows(i).Item("year"))
                            Next
                            .SelectedIndex = -1
                            '.SelectedIndex = 0
                        End With
                    End If
                End If
            Catch ex As Exception
                MsgBox("Please the account number is not correct, Please enter the correct account number", vbCritical, "Account Number Error")
                txtAccountNo.Focus()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cboyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboyear.SelectedIndexChanged
        If Not lblStatus.Text = "" Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmdGridsM As String = "SELECT distinct month FROM transactions where year='" & cboyear.Text.Trim & "' and account_no ='" & txtAccountNo.Text.Trim & "' ORDER BY month ASC"
            Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
            Dim dt As New DataTable
            Adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cbomonth
                    .Items.Clear()
                    For i As Integer = 0 To dt.Rows.Count - 1
                        .Items.Add(dt.Rows(i).Item("month"))
                    Next
                    .SelectedIndex = -1
                    '.SelectedIndex = 0
                End With
            End If
        End If
    End Sub

    Private Sub cbomonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomonth.SelectedIndexChanged
        If Not lblStatus.Text = "" Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmdGridsM As String = "SELECT distinct date FROM transactions where  month='" & cbomonth.Text.Trim & "' and year='" & cboyear.Text.Trim & "' and account_no ='" & txtAccountNo.Text.Trim & "' ORDER BY date ASC"
            Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
            Dim dt As New DataTable
            Adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cboFrom
                    .Items.Clear()
                    For i As Integer = 0 To dt.Rows.Count - 1
                        .Items.Add(dt.Rows(i).Item("date"))
                    Next
                    .SelectedIndex = -1
                    '.SelectedIndex = 0
                End With
                With cboTo
                    .Items.Clear()
                    For i As Integer = 0 To dt.Rows.Count - 1
                        .Items.Add(dt.Rows(i).Item("date"))
                    Next
                    .SelectedIndex = -1
                    '.SelectedIndex = 0
                End With
            End If
        End If
    End Sub
End Class