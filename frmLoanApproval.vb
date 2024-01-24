Imports MaterialSkin
Imports System.Data.SqlClient

Public Class frmLoanApproval
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
    Private Sub frmLoanApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        ' txtTotal.Text = ""
        ' lblmin.Text = ""
        lblAccType.Text = ""
        txtAmount.Text = ""
        txtrepay.Text = ""
        txtinterest.Text = ""
        txtAccountNo.Text = ""
        ' txtAvailableBalance.Text = ""
        txtFirstname.Text = ""
        txtSurname.Text = ""
        cboLoanNo.Items.Clear()
        picCustomer.Image = Nothing
        ' lblStatus.Text = ""
    End Sub

    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' txtTotal.Text = ""
            'lblmin.Text = ""
            lblAccType.Text = ""
            txtAmount.Text = ""
            txtrepay.Text = ""
            txtinterest.Text = ""
            ' txtAccountNo.Text = ""
            ' txtAvailableBalance.Text = ""
            txtFirstname.Text = ""
            txtSurname.Text = ""
            cboLoanNo.Items.Clear()
            picCustomer.Image = Nothing
            Try

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Dim cmdGridsM As String = "SELECT Loan_no from loan where Account_No='" & txtAccountNo.Text.Trim & "' and status='PENDING' order by loan_no ASC"
                Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
                Dim dt As New DataTable
                Adpt.Fill(dt)
                If dt.Rows.Count > 0 Then
                    With cboLoanNo
                        .Items.Clear()
                        For i As Integer = 0 To dt.Rows.Count - 1
                            .Items.Add(dt.Rows(i).Item("loan_no"))
                        Next
                        .SelectedIndex = -1
                        '.SelectedIndex = 0
                    End With
                End If
                conn.Close()
                dt.Dispose()
                dt = Nothing

                cboLoanNo.Focus()
            Catch ex As Exception
                MsgBox("Please the account number is not correct, Please enter the correct account number", vbCritical, "Account Number Error")
                txtAccountNo.Focus()
            End Try


        End If

    End Sub

    Private Sub cboLoanNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanNo.SelectedIndexChanged
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmdID As New SqlCommand("Select * from loan where Loan_No='" & cboLoanNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)
            ' Dim arione() As Byte
            ' Dim aritwo() As Byte

            txtSurname.Text = table.Rows(0)(6).ToString()
            txtFirstname.Text = table.Rows(0)(7).ToString()
            Dim addd As Double = table.Rows(0)(11).ToString()
            txtAmount.Text = Format(addd, "#,##0.00")
            txtrepay.Text = table.Rows(0)(14).ToString()
            Dim sod As Double = table.Rows(0)(19).ToString()
            txtinterest.Text = Format(sod, "#,##0.00")
            ' arione = table.Rows(0)(16)
            ' aritwo = table.Rows(0)(17)

            ' Dim mstreamm As New System.IO.MemoryStream(arione)
            ' Dim mstreammm As New System.IO.MemoryStream(aritwo)
            ' picCustomer.Image = Image.FromStream(mstreamm)
            ' PicSign.Image = Image.FromStream(mstreammm)
            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
            ' BALANCES()
            ' chkBalance()

            findPic()

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub findPic()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim sqlcmdID As New SqlCommand("Select * from customer where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
        ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
        Dim adapter As New SqlDataAdapter(sqlcmdID)
        Dim table As New DataTable
        adapter.Fill(table)
        Dim arione() As Byte
        Dim aritwo() As Byte


        ' txtbranch.Text = table.Rows(0)(18).ToString()
        arione = table.Rows(0)(16)
        aritwo = table.Rows(0)(17)

        Dim mstreamm As New System.IO.MemoryStream(arione)
        Dim mstreammm As New System.IO.MemoryStream(aritwo)
        picCustomer.Image = Image.FromStream(mstreamm)
        ' PicSign.Image = Image.FromStream(mstreammm)
        sqlcmdID.Dispose()
        'myreaderID.Dispose()
        conn.Close()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If MsgBox("Please are you sure you want to decline this loan request? Please note that this action cannot be reversed and would delete this loan request from the system", vbYesNo, "Loan request Confirmation") = vbNo Then
            txtAccountNo.Focus()
            Exit Sub
        Else

        End If
        If cboLoanNo.Text.Trim = "" Then
            MsgBox("Please select the loan number", vbExclamation, "Entry Error")
            cboLoanNo.Focus()
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim sqlcmdDel As New SqlCommand("Delete from loan where Loan_no= '" & cboLoanNo.Text.Trim & "' and  Account_No='" & txtAccountNo.Text.Trim & "'", conn)
        sqlcmdDel.ExecuteNonQuery()
        sqlcmdDel.Dispose()
        conn.Close()
        MsgBox("Loan request Declined successfully", vbInformation, "Loan Declined")
        Call frmLoanApproval_Load(sender, New EventArgs())
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim sqlcmdID As New SqlCommand("Select Account_No from Loan_Balance where Account_no='" & txtAccountNo.Text.Trim & "' and Status='PENDING'", conn)
        Dim myreaderID As SqlDataReader

        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If myreaderID.HasRows Then
            MsgBox("Please this account user has an unfinished loan to pay", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
            sqlcmdID.Dispose()
            myreaderID.Close()
            myreaderID = Nothing
        End If
        sqlcmdID.Dispose()
        myreaderID.Close()
        myreaderID = Nothing
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If cboLoanNo.Text.Trim = "" Then
            MsgBox("Please select the loan number", vbExclamation, "Entry Error")
            cboLoanNo.Focus()
            Exit Sub
        End If
        If MsgBox("Please are you sure you want to approve this loan request? Please note that this action cannot be reversed and would process this loan request to the respective department", vbYesNo, "Loan request Confirmation") = vbNo Then
            txtAccountNo.Focus()
            Exit Sub
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            ' declare and create a sql command object
            Dim cmdStrr As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdStrr.CommandText = "UPDATE loan SET status=@status where Loan_no= '" & cboLoanNo.Text.Trim & "' and  Account_No='" & txtAccountNo.Text.Trim & "'"
            ' add the parameters
            Dim responds As String = "APPROVED BY " & Main.lblofficer.Text.Trim
            cmdStrr.Parameters.AddWithValue("@Status", responds)
            ' cmdStrr.Parameters.AddWithValue("@name", txtname.Text.Trim)

            'execute the sql statement against the connection
            cmdStrr.ExecuteNonQuery()
            ' release the resources
            cmdStrr.Dispose()
            conn.Close()
            MsgBox("Loan request Approved successfully", vbInformation, "Loan Approval")
            Call frmLoanApproval_Load(sender, New EventArgs())
        End If
    End Sub
End Class