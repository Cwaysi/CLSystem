Imports System.Data.SqlClient
Imports MaterialSkin

Public Class frmDeposite
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
    Dim accounttype As String = "CASH DEPOSIT"
    Private Sub frmDeposite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)


        fraChanges.Hide()
        Radself.Checked = True
        Radother.Checked = False
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtAmount.Enabled = True
        txtChange.Text = ""
        txtFormNo.Text = ""
        lblAvailableBalance.Text = ""
        lblTotalBalance.Text = ""
        txtFormNo.ReadOnly = False
        TXTIDCARD.Text = ""
        lblActCheck.Visible = False
        lblActCheck.ForeColor = Color.Red
        cboIdType.Text = ""
        txtAccountNo.Text = ""
        txtAmount.Text = ""
        txtDesc.Text = ""
        txtTotal.Text = ""
        lblmin.Text = ""
        lblAccType.Text = ""

        picCustomer.Image = Nothing
        PicSign.Image = Nothing
        btnEdit.Enabled = False
        btnSave.Enabled = True

        txtAccountNo.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call frmDeposite_Load(sender, New EventArgs())
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ChkEdit.Checked = True Then
                If txtFormNo.Text.Trim = "" Then
                    MsgBox("Please enter unique form Number", vbExclamation, "Entry Error")
                    txtFormNo.Focus()
                    Exit Sub
                End If
                Try
                    Dim sqlcmdID As New SqlCommand("Select * from Transactions where entry_by='" & Main.lblofficer.Text.Trim & "' and date='" & DateTimePicker1.Text.Trim & "' and Form_No='" & txtFormNo.Text.Trim & "' and type='" & accounttype & "' and Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                    ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                    Dim adapter As New SqlDataAdapter(sqlcmdID)
                    Dim table As New DataTable
                    adapter.Fill(table)


                    txtSurname.Text = table.Rows(0)(5).ToString()
                    cboIdType.Text = table.Rows(0)(8).ToString()
                    TXTIDCARD.Text = table.Rows(0)(9).ToString()
                    txtFirstname.Text = table.Rows(0)(6).ToString()
                    txtDesc.Text = table.Rows(0)(12).ToString()
                    txtDepoName.Text = table.Rows(0)(7).ToString()
                    Dim tamot As Double = table.Rows(0)(13).ToString()
                    txtAmount.Text = Format(tamot, "#,##0.00")
                    Dim tamo As Double = table.Rows(0)(13).ToString()
                    lblTamount.Text = Format(tamo, "#,##0.00")
                    sqlcmdID.Dispose()
                    'myreaderID.Dispose()
                    conn.Close()
                    findPic()
                Catch ex As Exception

                    MsgBox("Please the account number had no deposite record on " & seen & " or, the account number does not exist", vbCritical, "Account Number Error")
                    txtAccountNo.Focus()
                    Exit Sub
                End Try

                txtFormNo.ReadOnly = True
            Else
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
                    txtbranch.Text = table.Rows(0)(18).ToString()
                    lblActive.Text = table.Rows(0)(14).ToString()
                    lblmobile.Text = table.Rows(0)(5).ToString()
                    arione = table.Rows(0)(16)
                    aritwo = table.Rows(0)(17)

                    Dim mstreamm As New System.IO.MemoryStream(arione)
                    Dim mstreammm As New System.IO.MemoryStream(aritwo)
                    picCustomer.Image = Image.FromStream(mstreamm)
                    PicSign.Image = Image.FromStream(mstreammm)
                    sqlcmdID.Dispose()
                    'myreaderID.Dispose()
                    conn.Close()
                    BALANCES()
                    btnSave.Enabled = True
                    txtAmount.Enabled = True
                    If Not lblActive.Text.Trim = "ACTIVE" Then
                        btnSave.Enabled = False
                        txtAmount.Enabled = False
                        lblActCheck.Visible = True
                        lblActCheck.ForeColor = Color.Red
                    End If
                Catch ex As Exception
                    MsgBox("Please the account number is not correct, Please enter the correct account number", vbCritical, "Account Number Error")
                    txtAccountNo.Focus()
                    Exit Sub
                End Try
            End If

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
            Dim sdr As Double = tablde.Rows(0)(4).ToString()
            lblTotalBalance.Text = Format(sdr, "#,##0.00")

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


            Dim agt As Double = Val(txtTotal.Text) - Val(lblmin.Text.Trim)
            lblAvailableBalance.Text = Format(agt, "#,##0.00")

            sqlcmdIDd.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub findPic()
        Try


            Dim sqlcmdIDd As New SqlCommand("Select * from customer where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapterd As New SqlDataAdapter(sqlcmdIDd)
            Dim tablde As New DataTable
            adapterd.Fill(tablde)
            Dim arioned() As Byte
            Dim aritwod() As Byte
            txtbranch.Text = tablde.Rows(0)(18).ToString()
            arioned = tablde.Rows(0)(16)
            aritwod = tablde.Rows(0)(17)

            Dim mstreamm As New System.IO.MemoryStream(arioned)
            Dim mstreammm As New System.IO.MemoryStream(aritwod)
            picCustomer.Image = Image.FromStream(mstreamm)
            PicSign.Image = Image.FromStream(mstreammm)
            sqlcmdIDd.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Radself_CheckedChanged(sender As Object, e As EventArgs) Handles Radself.CheckedChanged
        If Radself.Checked = True Then
            txtDepoName.Text = "SELF"
            TXTIDCARD.Text = ""
            cboIdType.Text = ""
            txtDepoName.Enabled = False
            TXTIDCARD.Enabled = False
            cboIdType.Enabled = False
        End If
    End Sub

    Private Sub Radother_CheckedChanged(sender As Object, e As EventArgs) Handles Radother.CheckedChanged
        If Radother.Checked = True Then
            txtDepoName.Text = ""
            TXTIDCARD.Text = ""
            cboIdType.Text = ""
            txtDepoName.Enabled = True
            TXTIDCARD.Enabled = True
            cboIdType.Enabled = True
        End If
    End Sub

    Private Sub ChkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEdit.CheckedChanged
        If ChkEdit.Checked = True Then
            fraChanges.Show()
            Radself.Checked = False
            Radother.Checked = False
            txtSurname.Text = ""
            txtFirstname.Text = ""
            txtAmount.Text = ""
            txtChange.Text = ""
            TXTIDCARD.Text = ""
            cboIdType.Text = ""
            txtAccountNo.Text = ""
            txtDesc.Text = ""
            picCustomer.Image = Nothing
            PicSign.Image = Nothing
            btnEdit.Enabled = True
            btnSave.Enabled = False
            txtAccountNo.Focus()

        End If
        If ChkEdit.Checked = False Then
            Call frmDeposite_Load(sender, New EventArgs())
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Dim sqlcmdID As New SqlCommand("Select Form_no from Transactions where Form_no='" & txtFormNo.Text.Trim & "' and type='" & accounttype & "' and Account_No='" & txtAccountNo.Text.Trim & "'", conn)
        Dim myreaderID As SqlDataReader
        conn.Open()
        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If txtDepoName.Text.Trim = "" Then
            MsgBox("Please enter the depositer's fullname, or select self if the deposite is by the account owner", vbExclamation, "Entry Error")
            txtDepoName.Focus()
            Exit Sub
        End If
        If txtFormNo.Text.Trim = "" Then
            MsgBox("Please enter unique form Number", vbExclamation, "Entry Error")
            txtFormNo.Focus()
            Exit Sub
        End If
        If Radother.Checked = True Then
            If cboIdType.Text.Trim = "" And TXTIDCARD.Text = "" Then
                MsgBox("Please enter the depositor's ID number and ID type", vbExclamation, "Entry Error")
                TXTIDCARD.Focus()
                Exit Sub
            End If
            If Not cboIdType.Text.Trim = "" And TXTIDCARD.Text = "" Then
                MsgBox("Please enter the depositor's ID number", vbExclamation, "Entry Error")
                TXTIDCARD.Focus()
                Exit Sub
            End If
            If Not TXTIDCARD.Text.Trim = "" And cboIdType.Text = "" Then
                MsgBox("Please select the depositor's ID Type", vbExclamation, "Entry Error")
                cboIdType.Focus()
                Exit Sub
            End If
        End If


        If myreaderID.HasRows Then
            ' Dim FName As String
            ' FName = myreaderID.Item("Full_Name").ToString.Trim
            MsgBox("Please this form number already exist for " & txtSurname.Text.Trim & ", Dupplicate form entry is NOT accepted.", vbInformation, "Dupplicate Form Number Entry Denied")
            sqlcmdID.Dispose()
            myreaderID.Close()
            myreaderID = Nothing
            txtFormNo.Focus()
            Exit Sub
        End If
        sqlcmdID.Dispose()
        myreaderID.Close()
        myreaderID = Nothing

        If MsgBox("Please are you sure " & txtSurname.Text.Trim & " " & txtFirstname.Text.Trim & " is making a cash deposite of " & txtAmount.Text.Trim & " into his/her account?", vbYesNo, "Account Type Confirmation") = vbNo Then
            txtAccountNo.Focus()
            Exit Sub
        Else

        End If

        balCh()

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim yoo As String = "YES"
            Dim apv As String = "SYSTEM"
            Dim DelNo As String = "ACTIVE"
            Dim cmdorderDet As New SqlCommand("Insert into Transactions (year, month,date,time,Account_No, Surname, Firstname,Deposit_by ,ID_Type, ID, Type, form_no,Description,Deposit,Entry_by,Approval, Approved_by)" &
                        "values(@year, @month,@date,@time, @Account_No,@Surname,@Firstname,@Deposit_by, @ID_Type, @ID,@Type,@form_no, @Description,@Deposit, @Entry_By, @Approval, @Approved_by)", conn)

            cmdorderDet.Parameters.AddWithValue("@Year", lblyear)
            cmdorderDet.Parameters.AddWithValue("@Month", mnt)
            cmdorderDet.Parameters.AddWithValue("@Date", seen)
            cmdorderDet.Parameters.AddWithValue("@Time", dt)
            cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@deposit_by", txtDepoName.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID_Type", cboIdType.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID", TXTIDCARD.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Type", accounttype)
            cmdorderDet.Parameters.AddWithValue("@form_no", txtFormNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Description", txtDesc.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Deposit", txtAmount.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Entry_by", Main.lblofficer.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Approval", yoo)
            cmdorderDet.Parameters.AddWithValue("@Approved_By", apv)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
            AccountUpdate()

            MsgBox("Deposit of  " & txtAmount.Text.Trim & " made for Account Number " & txtAccountNo.Text.Trim & " Successfully", vbInformation, "Deposit")
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim apikey As String = "OlZNVUluTFE5SVpaZUVudHY="
            Dim from As String = "EtufuorBank"
            'Dim i, j As Integer
            'i = grdNumbers.CurrentRow.Index
            Dim reciever As String = lblmobile.Text.Trim
            ' Dim reciever As String = "0553852241"

            'Dim msg As String = row.Cells(0).Value


            Dim msg As String = "Your account has been credited with GH₵ " & Format(txtAmount.Text.Trim, "#,##0.00") & " on " & seen &
                ". Your account balance is GH₵ " & Format(lblBalance.Text.Trim, "#,##0.00") & ". Thank you"
            Try
                Dim ob As String = "https://sms.arkesel.com/sms/api?action=send-sms&api_key=" & apikey & "&to=" & reciever & "&from=" & from & "&sms=" & msg & ""
                Dim data As String = client.DownloadString(ob)


            Catch ex As Exception
                MsgBox("Message was not sent", vbCritical, "Loan payment")
            End Try
            Call frmDeposite_Load(sender, New EventArgs())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub AccountUpdate()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If


            conn.Open()
            ' declare and create a sql command object
            Dim cmdorderDet As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdorderDet.CommandText = "UPDATE Account SET balance=@balance where Account_No= '" & txtAccountNo.Text.Trim & "'"
            ' add the parameters


            cmdorderDet.Parameters.AddWithValue("@balance", lblBalance.Text.Trim)

            'execute the sql statement against the connection
            cmdorderDet.ExecuteNonQuery()
            ' release the resources
            cmdorderDet.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub balCh()
        Try
            Dim sqlcmdID As New SqlCommand("Select * from account where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)

            Dim bal As String = table.Rows(0)(4).ToString()
            lblBalance.Text = Val(txtTotal.Text.Trim) + Val(txtAmount.Text.Trim)
            'lblBalance.Text = Format(baldeduct, "#,##0.00")

            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If IsNumeric(txtAmount.Text.Trim) = False Then
            txtAmount.Text = ""
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If txtDepoName.Text.Trim = "" Then
            MsgBox("Please enter the depositer's fullname, or select self if the deposite is by the account owner", vbExclamation, "Entry Error")
            txtDepoName.Focus()
            Exit Sub
        End If
        If txtChange.Text.Trim = "" Then
            MsgBox("Please enter your reasons for the change", vbExclamation, "Entry Error")
            txtChange.Focus()
            Exit Sub
        End If
        If Radother.Checked = True Then
            If cboIdType.Text.Trim = "" And TXTIDCARD.Text = "" Then
                MsgBox("Please enter the depositor's ID number and ID type", vbExclamation, "Entry Error")
                TXTIDCARD.Focus()
                Exit Sub
            End If
            If Not cboIdType.Text.Trim = "" And TXTIDCARD.Text = "" Then
                MsgBox("Please enter the depositor's ID number", vbExclamation, "Entry Error")
                TXTIDCARD.Focus()
                Exit Sub
            End If
            If Not TXTIDCARD.Text.Trim = "" And cboIdType.Text = "" Then
                MsgBox("Please select the depositor's ID Type", vbExclamation, "Entry Error")
                cboIdType.Focus()
                Exit Sub
            End If
        End If
        Dim acc As Double = Val(txtAmount.Text.Trim)
        txtAmount.Text = Format(acc, "#,##0.00")
        If MsgBox("Please are you sure you want to edit this transaction?", vbYesNo, "Account Type Confirmation") = vbNo Then
            txtAccountNo.Focus()
            Exit Sub
        Else

        End If
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If


            conn.Open()
            Dim yoo As String = "YES"
            Dim apv As String = "SYSTEM"
            ' declare and create a sql command object
            Dim cmdorderDet As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdorderDet.CommandText = "UPDATE Transactions SET deposit_by=@deposit_by,ID_type=@ID_Type,ID=@ID,Type=@Type,
                       Description=@Description, Deposit=@Deposit, Entry_by=@Entry_by where Account_No= '" & txtAccountNo.Text.Trim & "' and Form_No='" & txtFormNo.Text.Trim & "' and type='" & accounttype & "'"
            ' add the parameters

            cmdorderDet.Parameters.AddWithValue("@deposit_by", txtDepoName.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID_Type", cboIdType.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID", TXTIDCARD.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Type", accounttype)
            cmdorderDet.Parameters.AddWithValue("@Description", txtDesc.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Deposit", txtAmount.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Entry_by", Main.lblofficer.Text.Trim)
            'execute the sql statement against the connection
            cmdorderDet.ExecuteNonQuery()
            ' release the resources
            cmdorderDet.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        NewB()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' declare and create a sql command object
            Dim cmdorderDet As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdorderDet.CommandText = "UPDATE Account SET balance=@balance where Account_No= '" & txtAccountNo.Text.Trim & "'"
            cmdorderDet.Parameters.AddWithValue("@Balance", lblNewBalance.Text.Trim)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        logChange()
        MsgBox("Update successfully made", vbInformation, "Entry Update")
        Call frmDeposite_Load(sender, New EventArgs())
    End Sub
    Public Sub NewB()
        Try
            Dim sqlcmdID As New SqlCommand("Select * from account where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)

            Dim bal As Double = table.Rows(0)(4).ToString()
            Dim baldeduct As Double = Val(bal) - Val(lblTamount.Text.Trim) + Val(txtAmount.Text.Trim)
            lblNewBalance.Text = Format(baldeduct, "#,##0.00")

            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub logChange()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim yoo As String = "YES"
            Dim apv As String = "SYSTEM"
            Dim dep As String = "DEPOSIT"
            Dim dsta As String = "UNVERTED"
            Dim DelNo As String = "ACTIVE"
            Dim AmtChange As String
            If Not Val(lblTamount.Text.Trim) = Val(txtAmount.Text.Trim) Then
                AmtChange = "Amount changed from GHc" & lblTamount.Text.Trim & " to " & txtAmount.Text.Trim
            Else
                AmtChange = ""
            End If
            Dim cmdorderDet As New SqlCommand("Insert into Changes_Log (year, month,date,time,officer,form,Account_No, Description,Amount_Change,Status)" &
                        "values(@year, @month,@date,@time, @officer,@form,@Account_no,@Description, @Amount_Change, @Status)", conn)

            cmdorderDet.Parameters.AddWithValue("@Year", lblyear)
            cmdorderDet.Parameters.AddWithValue("@Month", mnt)
            cmdorderDet.Parameters.AddWithValue("@Date", seen)
            cmdorderDet.Parameters.AddWithValue("@Time", dt)
            cmdorderDet.Parameters.AddWithValue("@officer", Main.lblofficer.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@form", dep)
            cmdorderDet.Parameters.AddWithValue("@Description", txtChange.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Amount_Change", AmtChange)
            cmdorderDet.Parameters.AddWithValue("@Status", dsta)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtFormNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFormNo.KeyDown
        If ChkEdit.Checked = True Then
            If e.KeyCode = Keys.Enter Then
                If txtFormNo.Text.Trim = "" Then
                    MsgBox("Please enter unique form Number", vbExclamation, "Entry Error")
                    txtFormNo.Focus()
                    Exit Sub
                End If
                If txtAccountNo.Text.Trim = "" Then
                    MsgBox("Please enter customer's Number", vbExclamation, "Entry Error")
                    txtAccountNo.Focus()
                    Exit Sub
                End If
                Try
                    Dim sqlcmdID As New SqlCommand("Select * from Transactions where entry_by='" & Main.lblofficer.Text.Trim & "' and date='" & DateTimePicker1.Text.Trim & "' and Form_No='" & txtFormNo.Text.Trim & "' and type='" & accounttype & "' and Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                    ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                    Dim adapter As New SqlDataAdapter(sqlcmdID)
                    Dim table As New DataTable
                    adapter.Fill(table)


                    txtSurname.Text = table.Rows(0)(5).ToString()
                    cboIdType.Text = table.Rows(0)(8).ToString()
                    TXTIDCARD.Text = table.Rows(0)(9).ToString()
                    txtFirstname.Text = table.Rows(0)(6).ToString()
                    txtDesc.Text = table.Rows(0)(12).ToString()
                    txtDepoName.Text = table.Rows(0)(7).ToString()
                    Dim tamot As Double = table.Rows(0)(13).ToString()
                    txtAmount.Text = Format(tamot, "#,##0.00")
                    Dim tamo As Double = table.Rows(0)(13).ToString()
                    lblTamount.Text = Format(tamo, "#,##0.00")
                    sqlcmdID.Dispose()
                    'myreaderID.Dispose()
                    conn.Close()
                    findPic()
                Catch ex As Exception

                    MsgBox("Please the account number had no deposite record on " & seen & " or, the account number does not exist", vbCritical, "Account Number Error")
                    txtAccountNo.Focus()
                    Exit Sub
                End Try

                txtFormNo.ReadOnly = True
            End If
        End If
    End Sub
End Class