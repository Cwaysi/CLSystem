Imports System.Data.SqlClient
Imports MaterialSkin

Public Class frmLoanPayment
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
    Private Sub frmLoanPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)

        picCustomer.Image = Nothing
        txtAccountNo.Text = ""
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtamount.Text = ""
        txtinterest.Text = ""
        txtInterestDDD.Text = ""
        txtPrincipalDD.Text = ""
        txtamountpaying.Text = ""
        lblrate.Text = ""

        txtAccountNo.Focus()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Close()
    End Sub
    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtAccountNo.Text.Trim = "" Then
                MsgBox("Please enter account number", vbExclamation, "Entry Error")
                txtAccountNo.Focus()
                Exit Sub
            End If
            Try
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

                txtSurname.Text = table.Rows(0)(3).ToString()
                txtFirstname.Text = table.Rows(0)(4).ToString()
                lblmobile.Text = table.Rows(0)(5).ToString()

                arione = table.Rows(0)(16)
                aritwo = table.Rows(0)(17)
                ' lblStatus.Text = table.Rows(0)(14)


                Dim mstreamm As New System.IO.MemoryStream(arione)
                Dim mstreammm As New System.IO.MemoryStream(aritwo)
                picCustomer.Image = Image.FromStream(mstreamm)
                ' PicSign.Image = Image.FromStream(mstreammm)
                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
                amot()
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
            txtamount.Text = Format(proin, "#,##0.00")
            lbltt.Text = table.Rows(0)(7).ToString()
            Dim proinn As Double = table.Rows(0)(8).ToString()
            lblII.Text = table.Rows(0)(8).ToString()
            txtinterest.Text = Format(proInn, "#,##0.00")


            Dim interestt As Integer = 100 * Val(lblII.Text.Trim)
            lblrate.Text = interestt / Val(lbltt.Text.Trim)

            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtamountpaying_TextChanged(sender As Object, e As EventArgs) Handles txtamountpaying.TextChanged
        If IsNumeric(txtamountpaying.Text.Trim) = False Then
            txtamountpaying.Text = ""
            Exit Sub
        End If
        Dim er As Double = Val(lblrate.Text.Trim) / 100
        txtInterestDDD.Text = er * Val(txtamountpaying.Text.Trim)

        txtPrincipalDD.Text = Val(txtamountpaying.Text.Trim) - Val(txtInterestDDD.Text.Trim)
    End Sub
    Public Sub algo()
        Dim princiapalbalance As Double = Val(lbltt.Text.Trim) - Val(txtPrincipalDD.Text.Trim)
        Dim interestbalance As Double = Val(lblII.Text.Trim) - Val(txtInterestDDD.Text.Trim)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmdStrr As SqlCommand = conn.CreateCommand
        cmdStrr.CommandText = "UPDATE loan_balance SET principal=@principal, interest=@interest where Account_No='" & txtAccountNo.Text.Trim & "'"

        cmdStrr.Parameters.AddWithValue("@principal", princiapalbalance)
        cmdStrr.Parameters.AddWithValue("@interest", interestbalance)

        cmdStrr.ExecuteNonQuery()
        cmdStrr.Dispose()
        conn.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If txtamountpaying.Text.Trim = "" Or Val(txtamountpaying.Text.Trim) < 1 Then
            MsgBox("Please customer cannot less than GH₵ 1.00", vbExclamation, "Entry Error")
            txtamountpaying.Focus()
            Exit Sub
        End If
        Dim sss As Double = Val(lbltt.Text.Trim) + Val(lblII.Text.Trim)
        If Val(txtamountpaying.Text.Trim) > sss Then
            Dim ss As Double = Val(lbltt.Text.Trim) + Val(lblII.Text.Trim)
            Dim ff As String = " GH₵ " & Format(ss, "#,##0.00")
            MsgBox("Please customer cannot pay more than s/he total loan amount of" & ff, vbExclamation, "Entry Error")
            txtamountpaying.Focus()
            Exit Sub
        End If
        If MsgBox("Please are you sure you want to save this loan payment? please note that this action or command cannot be reversed or editted", vbYesNo, "Confirmation") = vbNo Then
            txtAccountNo.Focus()
            Exit Sub
        End If
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmdorderDet As New SqlCommand("Insert into Loan_payment (day, month, year, Date, Account_no, Surname, Firstname, principal, interest, Payment,  officer)" &
                       "values(@Day, @month, @year, @date, @Account_No, @surname, @firstname, @principal, @Interest, @payment, @officer )", conn)

            Dim mstream As New System.IO.MemoryStream()
            picCustomer.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim filesize As UInt32
            filesize = mstream.Length
            mstream.Close()

            Dim Apv As Double = Val(txtInterestDDD.Text.Trim) + Val(txtPrincipalDD.Text.Trim)
            'cmdorderDet.Parameters.AddWithValue("@loan_no", lblserial3.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@day", Main.lblCurrentDay.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Date", seen)
            cmdorderDet.Parameters.AddWithValue("@month", mnt)
            cmdorderDet.Parameters.AddWithValue("@year", lblyear)
            cmdorderDet.Parameters.AddWithValue("@Account_no", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@principal", txtPrincipalDD.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@interest", txtInterestDDD.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@payment", Apv)
            cmdorderDet.Parameters.AddWithValue("@Officer", Main.lblofficer.Text.Trim)

            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
            algo()

            MsgBox("Loan payment successful", vbInformation, "Loan payment")
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim apikey As String = "OlZNVUluTFE5SVpaZUVudHY="
            Dim from As String = "EtufuorBank"
            'Dim i, j As Integer
            'i = grdNumbers.CurrentRow.Index
            Dim reciever As String = lblmobile.Text.Trim
            ' Dim reciever As String = "0553852241"

            'Dim msg As String = row.Cells(0).Value
            Dim princiapalbalance As Double = Val(lbltt.Text.Trim) - Val(txtPrincipalDD.Text.Trim)
            Dim interestbalance As Double = Val(lblII.Text.Trim) - Val(txtInterestDDD.Text.Trim)
            Dim balance As Double = princiapalbalance + interestbalance

            Dim msg As String = "A loan payment of GH₵ " & Format(txtamountpaying.Text.Trim, "#,##0.00") & " has been made on " & seen &
                ". Your loan balance is GH₵ " & Format(balance, "#,##0.00") & ". Please make payments before due date to avoid penalty. Thank you"
            Try
                Dim ob As String = "https://sms.arkesel.com/sms/api?action=send-sms&api_key=" & apikey & "&to=" & reciever & "&from=" & from & "&sms=" & msg & ""
                Dim data As String = client.DownloadString(ob)


            Catch ex As Exception
                MsgBox("Message was not sent", vbCritical, "Loan payment")
            End Try
            Call frmLoanPayment_Load(sender, New EventArgs())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class