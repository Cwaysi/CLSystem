Imports System.Data.SqlClient
Imports MaterialSkin

Public Class frmCustomerBalance
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
    Private Sub frmCustomerBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        txtTotal.Text = ""
        Exloanpanel.Visible = False
        lblmin.Text = ""
        lblAccType.Text = ""
        txtAmount.Text = ""
        txtAccountNo.Text = ""
        txtAvailableBalance.Text = ""
        txtFirstname.Text = ""
        txtSurname.Text = ""
        picCustomer.Image = Nothing
        lblStatus.Text = ""
    End Sub

    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                Dim sqlcmdID As New SqlCommand("Select * from customer where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)
                Dim arione() As Byte
                Dim aritwo() As Byte

                txtSurname.Text = table.Rows(0)(3).ToString()
                txtFirstname.Text = table.Rows(0)(4).ToString()
                lblStatus.Text = table.Rows(0)(14).ToString()
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
                BALANCES()
                chkBalance()
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim sqlcmdIDd As New SqlCommand("Select Account_No from Loan_Balance where Account_no='" & txtAccountNo.Text.Trim & "' and Status='PENDING'", conn)
                Dim myreaderID As SqlDataReader

                myreaderID = sqlcmdIDd.ExecuteReader()
                myreaderID.Read()
                If myreaderID.HasRows Then
                    Exloanpanel.Visible = True
                    amot()
                    sqlcmdIDd.Dispose()
                    myreaderID.Close()
                    myreaderID = Nothing
                End If
            Catch ex As Exception
                MsgBox("Please the account number is not correct, Please enter the correct account number", vbCritical, "Account Number Error")
                txtAccountNo.Focus()
                Exit Sub
            End Try


        End If



    End Sub
    Public Sub amot()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmdID As New SqlCommand("Select * from loan_balance where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)


            Dim proin As Double = table.Rows(0)(7).ToString()
            txtprincipal.Text = Format(proin, "#,##0.00")
            Dim proinn As Double = table.Rows(0)(8).ToString()
            txtinterest.Text = Format(proinn, "#,##0.00")
            Dim frt As Double = proin + proinn
            lblloantotal.Text = "Total: GH₵ " & Format(frt, "#,##0.00")

            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub chkBalance()
        Try
            Dim sqlcmdID As New SqlCommand("Select * from account where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)


            Dim AD As Double = table.Rows(0)(4).ToString()
            txtAmount.Text = Format(AD, "#,##0.00")
            lblAccType.Text = table.Rows(0)(1).ToString()

            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblStatus_TextChanged(sender As Object, e As EventArgs) Handles lblStatus.TextChanged
        If Me.lblStatus.Text = "ACTIVE" Then
            lblStatus.ForeColor = Color.DarkGreen
            txtAccountNo.BackColor = Color.DarkGreen
            txtAmount.BackColor = Color.DarkGreen
        Else
            lblStatus.ForeColor = Color.Maroon
            txtAccountNo.BackColor = Color.Maroon
            txtAmount.BackColor = Color.Maroon
        End If
    End Sub
    Public Sub BALANCES()
        Try


            Dim sqlcmdIDd As New SqlCommand("Select * from account where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapterd As New SqlDataAdapter(sqlcmdIDd)
            Dim tablde As New DataTable
            adapterd.Fill(tablde)

            lblAccType.Text = tablde.Rows(0)(1).ToString()
            txtTotal.Text = tablde.Rows(0)(4).ToString()


            sqlcmdIDd.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try


            Dim sqlcmdIDd As New SqlCommand("Select * from min_balance where Account='" & lblAccType.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapterd As New SqlDataAdapter(sqlcmdIDd)
            Dim tablde As New DataTable
            adapterd.Fill(tablde)

            lblmin.Text = tablde.Rows(0)(1).ToString()
            'lblmin.Text = Format(swe, "#,##0.00")


            '  Dim agt As Double = Val(txtTotal.Text) - Val(lblmin.Text.Trim)
            Dim agt As Double = Val(txtTotal.Text.Trim) - Val(lblmin.Text.Trim)
            txtAvailableBalance.Text = Format(agt, "#,##0.00")

            sqlcmdIDd.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lblmin_TextChanged(sender As Object, e As EventArgs) Handles lblmin.TextChanged
        Dim agt As Double = Val(txtTotal.Text.Trim) - Val(lblmin.Text.Trim)
        txtAvailableBalance.Text = Format(agt, "#,##0.00")
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        Dim agt As Double = Val(txtTotal.Text.Trim) - Val(lblmin.Text.Trim)
        txtAvailableBalance.Text = Format(agt, "#,##0.00")
    End Sub
End Class