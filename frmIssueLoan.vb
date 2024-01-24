Imports System.Data.SqlClient
Imports MaterialSkin

Public Class frmIssueLoan
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
    Private Sub frmIssueLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        txtamount.Text = ""
        cboLoanNo.Items.Clear()
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtAccountNo.Text = ""
        txtinterest.Text = ""
        txtstartmnt.Text = ""
        txtstartyr.Text = ""
        txtendmnt.Text = ""
        txtendyr.Text = ""
        picCustomer.Image = Nothing

    End Sub
    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtamount.Text = ""
            cboLoanNo.Items.Clear()
            txtSurname.Text = ""
            txtFirstname.Text = ""
            ' txtAccountNo.Text = ""
            txtinterest.Text = ""
            txtstartmnt.Text = ""
            txtstartyr.Text = ""
            txtendmnt.Text = ""
            txtendyr.Text = ""
            picCustomer.Image = Nothing
            txtFirstname.Text = ""
            txtSurname.Text = ""
            cboLoanNo.Items.Clear()
            picCustomer.Image = Nothing
            Try

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Dim cmdGridsM As String = "SELECT Loan_no from loan where Account_No='" & txtAccountNo.Text.Trim & "' and status LIKE 'APPROVED BY%' order by loan_no ASC"
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
                MsgBox("Please the account number is not correct or this account holder's loan has not been approved, Please enter the correct account number", vbCritical, "Account Number Error")
                txtAccountNo.Focus()
            End Try


        End If

    End Sub
    Private Sub cboLoanNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanNo.SelectedIndexChanged
        Try
            Dim sqlcmdID As New SqlCommand("Select * from loan where Loan_No='" & cboLoanNo.Text.Trim & "' and Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)
            ' Dim arione() As Byte
            ' Dim aritwo() As Byte

            txtSurname.Text = table.Rows(0)(6).ToString()
            txtFirstname.Text = table.Rows(0)(7).ToString()
            Dim addd As Double = table.Rows(0)(11).ToString()
            txtamount.Text = Format(addd, "#,##0.00")
            ' txtrepay.Text = table.Rows(0)(14).ToString()
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
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtstartyr.Text.Trim = "" Or txtstartmnt.Text.Trim = "" Or txtendyr.Text.Trim = "" Or txtendmnt.Text.Trim = "" Then
            MsgBox("Please Fill the start date and end date", vbCritical, "Entry Error")
            Exit Sub
        End If
        If Val(txtstartyr.Text.Trim) < Val(lblyear) Then
            MsgBox("Please the start year can not be below this year", vbCritical, "Entry Error")
            txtstartyr.Focus()
            Exit Sub
        End If
        If Val(txtendyr.Text.Trim) < Val(txtstartyr.Text.Trim) Then
            MsgBox("Please the end year can not be earlier than the start year, please check and try again", vbCritical, "Entry Error")
            txtendyr.Focus()
            Exit Sub
        End If
        If Val(txtendyr.Text.Trim) = Val(txtstartyr.Text.Trim) And txtstartmnt.Text.Trim = txtendmnt.Text.Trim Then
            If Not MsgBox("please are sure the payment period is the same month and same year?", vbYesNo, "Confirm") = vbYes Then
                txtendyr.Focus()
                Exit Sub
            End If
        End If
        If Not MsgBox("please are sure you want to disburse this loan? Note that this action cannot be reversed?", vbYesNo, "Confirm") = vbYes Then
            txtendyr.Focus()
            Exit Sub
        End If
        Try

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmdorderDet As New SqlCommand("Insert into Loan_Balance ( Account_no, Surname, Firstname, Start_month, Start_Year, End_month, End_Year, Principal, Interest, Status)" &
                       "values(@Account_No, @surname, @firstname, @Start_month, @Start_Year, @End_Month, @End_Year, @Principal, @Interest, @status)", conn)

            Dim mstream As New System.IO.MemoryStream()
            picCustomer.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim filesize As UInt32
            filesize = mstream.Length
            mstream.Close()

            Dim Apv As String = "PENDING"
            cmdorderDet.Parameters.AddWithValue("@Account_no", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Start_Month", txtstartmnt.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@start_year", txtstartyr.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@End_Month", txtendmnt.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@End_year", txtendyr.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Principal", txtamount.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@interest", txtinterest.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@status", Apv)

            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
            StatUpdate()
            MsgBox("Loan disbursed successfully.", vbInformation, "Loan Disbursement")
            Call frmIssueLoan_Load(sender, New EventArgs())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub StatUpdate()
        Dim sqlcmdID As New SqlCommand("Select * from loan where Loan_No='" & cboLoanNo.Text.Trim & "' and Account_No='" & txtAccountNo.Text.Trim & "'", conn)
        Dim adapter As New SqlDataAdapter(sqlcmdID)
        Dim table As New DataTable
        adapter.Fill(table)

        Dim sod As String = table.Rows(0)(21).ToString()

        sqlcmdID.Dispose()
        conn.Close()

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        ' declare and create a sql command object
        Dim cmdStrr As SqlCommand = conn.CreateCommand
        ' set the sql statement to execute at the data source
        cmdStrr.CommandText = "UPDATE loan SET status=@status where Loan_no= '" & cboLoanNo.Text.Trim & "' and  Account_No='" & txtAccountNo.Text.Trim & "'"
        ' add the parameters
        Dim responds As String = "DISBURSED BY " & Main.lblofficer.Text.Trim & " AND WAS " & sod
        cmdStrr.Parameters.AddWithValue("@Status", responds)
        ' cmdStrr.Parameters.AddWithValue("@name", txtname.Text.Trim)

        'execute the sql statement against the connection
        cmdStrr.ExecuteNonQuery()
        ' release the resources
        cmdStrr.Dispose()
        conn.Close()
    End Sub

    Private Sub txtstartyr_TextChanged(sender As Object, e As EventArgs) Handles txtstartyr.TextChanged
        If IsNumeric(txtstartyr.Text.Trim) = False Then
            txtstartyr.Text = ""
        End If
    End Sub

    Private Sub txtendyr_TextChanged(sender As Object, e As EventArgs) Handles txtendyr.TextChanged
        If IsNumeric(txtendyr.Text.Trim) = False Then
            txtendyr.Text = ""
        End If
    End Sub
End Class