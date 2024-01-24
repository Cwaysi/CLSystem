Imports System.Data.SqlClient
Imports MaterialSkin
Public Class frmNewCustomer
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Dim lblyearid As String = Now.ToString("yy")
    Dim lblMonthID As String = Now.ToString("MM")
    Dim TextToPrint As String = ""
    Dim myDate As Date = Date.Today.Date
    Dim seen As String = (myDate.ToString("dd-MMM-yy"))
    Dim arrimage() As Byte
    Dim aarrimage() As Byte
    Dim imgpath As String
    Dim imgpathh As String

    Private Sub frmNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        '  SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        imgpath = Application.StartupPath + "\no image.jpg"
        PicSign.ImageLocation = imgpath
        picCustomer.ImageLocation = imgpath
        Label21.Text = "Starting Balance"
        PicSign.Image = Nothing
        txtAccountNo.ReadOnly = True
        btnEdit.Enabled = False
        btnSave.Enabled = True
        txtAccountNo.Hint = ""
        cboAccType.Enabled = True
        txtStartBalance.ReadOnly = False
        cboBranch.Enabled = True
        cboTitle.Text = ""
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtMobile.Text = ""
        txtAddress.Text = ""
        txtDOB.Text = ""
        txtDigitalAddress.Text = ""
        txtOcc.Text = ""
        cboMStatus.Text = ""
        txtemail.Text = ""
        txtNKsurname.Text = ""
        txtNKfirstname.Text = ""
        txtNKrelationship.Text = ""
        txtNKmobile.Text = ""
        txtNKaddress.Text = ""
        cboAccType.SelectedItem = "SUSU"
        txtStartBalance.Text = ""
        ChkEdit.Checked = False
        cboIdType.Text = ""
        TXTIDCARD.Text = ""
        cboBranch.DroppedDown = True
        Try


            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmdGridsM As String = "SELECT name FROM branches ORDER BY name ASC"
            Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
            Dim dt As New DataTable
            Adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cboBranch
                    .Items.Clear()
                    For i As Integer = 0 To dt.Rows.Count - 1
                        .Items.Add(dt.Rows(i).Item("name"))
                    Next
                    .SelectedIndex = -1
                    '.SelectedIndex = 0
                End With
            End If
            conn.Close()
            dt.Dispose()
            dt = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cboBranch.SelectedIndex = 0

        Try
            Dim sqlcmdID As New SqlCommand("Select * from branches where name ='" & cboBranch.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)

            lblcode.Text = table.Rows(0)(0).ToString()


            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try


            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Dim cmdGridsM As String = "SELECT name FROM account_type ORDER BY name ASC"
            Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
            Dim dt As New DataTable
            Adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cboAccType
                    .Items.Clear()
                    For i As Integer = 0 To dt.Rows.Count - 1
                        .Items.Add(dt.Rows(i).Item("name"))
                    Next
                    .SelectedIndex = -1
                    '.SelectedIndex = 0
                End With
            End If
            conn.Close()
            dt.Dispose()
            dt = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Dim serialno As Double
        ' Dim sen As Integer
        Dim productcodegenerate As String
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim lblyear As String = Now.ToString("yyyy")
        Dim sqlcmd As New SqlCommand("Select max(FID) As FID from Customer order by FID asc", conn)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            If myreader("FID").ToString() <> "" Then
                serialno = Integer.Parse(myreader("FID").ToString()) + 1
                ' sen = Integer.Parse(myreader("FID").ToString()) + 1

            Else
                serialno = 1
            End If

        Else
            serialno = 1
        End If
        myreader.Dispose()
        myreader.Close()
        conn.Close()

        lblserial.Text = serialno
        productcodegenerate = lblPre.Text.Trim & lblcode.Text.Trim & lblyearid & lblserial.Text.Trim
        txtAccountNo.Text = productcodegenerate

    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picCustomer.Image = Nothing
        txtAccountNo.Hint = ""
        PicSign.Image = Nothing
        cboTitle.Text = ""
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtMobile.Text = ""
        txtAddress.Text = ""
        txtDOB.Text = ""
        txtDigitalAddress.Text = ""
        txtOcc.Text = ""
        cboMStatus.Text = ""
        txtemail.Text = ""
        txtNKsurname.Text = ""
        txtNKfirstname.Text = ""
        txtNKrelationship.Text = ""
        txtNKmobile.Text = ""
        txtNKaddress.Text = ""
        txtStartBalance.Text = ""
        cboTitle.Focus()
    End Sub

    Private Sub cboAccType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccType.SelectedIndexChanged

        Try
            Dim sqlcmdID As New SqlCommand("Select * from account_type where name ='" & cboAccType.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)

            lblPre.Text = table.Rows(0)(0).ToString()



            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtAccountNo.Text = lblPre.Text.Trim & lblcode.Text.Trim & lblyearid & lblserial.Text.Trim
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboBranch.Text.Trim = "" Then
            MsgBox("Please select branch", vbExclamation, "Entry Error")
            cboBranch.Focus()
            Exit Sub
        End If
        If txtSurname.Text.Trim = "" Then
            MsgBox("Please enter the customer's surname", vbExclamation, "Entry Error")
            txtSurname.Focus()
            Exit Sub
        End If
        If txtFirstname.Text.Trim = "" Then
            MsgBox("Please enter the customer's firstname", vbExclamation, "Entry Error")
            txtFirstname.Focus()
            Exit Sub
        End If
        If txtMobile.Text.Trim = "" Then
            MsgBox("Please enter the customer's active mobile number", vbExclamation, "Entry Error")
            txtMobile.Focus()
            Exit Sub
        End If
        If txtAddress.Text.Trim = "" Then
            MsgBox("Please enter the customer's address", vbExclamation, "Entry Error")
            txtAddress.Focus()
            Exit Sub
        End If
        If txtDOB.Text.Trim = "" Then
            MsgBox("Please enter the customer's date of birth", vbExclamation, "Entry Error")
            txtDOB.Focus()
            Exit Sub
        End If
        If txtOcc.Text.Trim = "" Then
            MsgBox("Please enter the customer's occupation", vbExclamation, "Entry Error")
            txtOcc.Focus()
            Exit Sub
        End If
        If cboMStatus.Text.Trim = "" Then
            MsgBox("Please enter the customer's marital status", vbExclamation, "Entry Error")
            cboMStatus.Focus()
            Exit Sub
        End If
        If txtNKsurname.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's surname", vbExclamation, "Entry Error")
            txtNKsurname.Focus()
            Exit Sub
        End If
        If txtNKfirstname.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's firstname", vbExclamation, "Entry Error")
            txtNKfirstname.Focus()
            Exit Sub
        End If
        If txtNKrelationship.Text.Trim = "" Then
            MsgBox("Please enter the customer's relationship to the next of kin", vbExclamation, "Entry Error")
            txtNKrelationship.Focus()
            Exit Sub
        End If
        If txtNKmobile.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's mobile number", vbExclamation, "Entry Error")
            txtNKmobile.Focus()
            Exit Sub
        End If
        If txtNKaddress.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's address", vbExclamation, "Entry Error")
            txtNKaddress.Focus()
            Exit Sub
        End If
        If Not cboIdType.Text.Trim = "" And txtidcard.Text = "" Then
            MsgBox("Please enter the customer's ID number", vbExclamation, "Entry Error")
            txtidcard.Focus()
            Exit Sub
        End If
        If Not txtidcard.Text.Trim = "" And cboIdType.Text = "" Then
            MsgBox("Please select the customer's ID Type", vbExclamation, "Entry Error")
            cboIdType.Focus()
            Exit Sub
        End If
        'If picCustomer.Image Is Nothing Then
        '    MsgBox("Please enter upload customer's passportt picture", vbExclamation, "Entry Error")
        '    btnUpone.PerformClick()
        '    Exit Sub
        'End If
        'If PicSign.Image Is Nothing Then
        '    MsgBox("Please enter upload customer's scanned thumbprint or signature", vbExclamation, "Entry Error")
        '    btnUPtwo.PerformClick()
        '    Exit Sub
        'End If
        If txtStartBalance.Text.Trim = "" Then
            txtStartBalance.Text = "#,##0.00"
        Else
            Dim acc As Double = Val(txtStartBalance.Text.Trim)
            txtStartBalance.Text = Format(acc, "#,##0.00")
        End If
        If MsgBox("Please are you sure " & cboTitle.Text.Trim & " " & txtSurname.Text.Trim & " is requesting for " & cboAccType.Text.Trim & " account with a starting balance of " & txtStartBalance.Text.Trim & "? NB: once the account is registered, you can not change the account type", vbYesNo, "Account Type Confirmation") = vbNo Then
            cboAccType.Focus()
            Exit Sub
        Else

        End If
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim DelNo As String = "ACTIVE"
            Dim cmdorderDet As New SqlCommand("Insert into customer (FID, Date, title, Surname, Firstname, Mobile, Address, Digital_Address, DOB, Occupation, Marital_Status, Email, Account_type, Account_NO, status, officer, picture, sign, branch, ID_Card, ID_Type)" &
                        "values(@FID, @date, @title, @surname, @firstname, @mobile, @address, @digital_Address, @DOB, @Occupation, @Marital_status, @email, @account_type, @account_no, @status, @officer, @picture, @sign, @branch, @ID_Card, @id_tYPe)", conn)

            Dim mstream As New System.IO.MemoryStream()
            picCustomer.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim filesize As UInt32
            filesize = mstream.Length
            mstream.Close()

            Dim mstreamm As New System.IO.MemoryStream()
            PicSign.Image.Save(mstreamm, System.Drawing.Imaging.ImageFormat.Jpeg)
            aarrimage = mstreamm.GetBuffer()
            Dim filesizee As UInt32
            filesizee = mstreamm.Length
            mstreamm.Close()

            cmdorderDet.Parameters.AddWithValue("@FID", lblserial.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Date", seen)
            cmdorderDet.Parameters.AddWithValue("@title", cboTitle.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@address", txtAddress.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@digital_Address", txtDigitalAddress.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@DOB", txtDOB.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@occupation", txtOcc.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Marital_Status", cboMStatus.Text)
            cmdorderDet.Parameters.AddWithValue("@email", txtemail.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@account_type", cboAccType.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@status", DelNo)
            cmdorderDet.Parameters.AddWithValue("@Officer", Main.lblofficer.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@picture", arrimage)
            cmdorderDet.Parameters.AddWithValue("@sign", aarrimage)
            cmdorderDet.Parameters.AddWithValue("@branch", cboBranch.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID_Card", TXTIDCARD.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID_tYPE", cboIdType.Text.Trim)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim DelNo As String = "ACTIVE"
            Dim cmdorderDet As New SqlCommand("Insert into Next_of_Kin (Account_No, Surname, Firstname, Relationship, Mobile, Address)" &
                        "values(@Account_No, @Surname, @Firstname, @Relationship, @Mobile, @Address)", conn)
            cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Surname", txtNKsurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Firstname", txtNKfirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Relationship", txtNKrelationship.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Mobile", txtNKmobile.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Address", txtNKaddress.Text.Trim)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim DelNo As String = "ACTIVE"
            Dim cmdorderDet As New SqlCommand("Insert into Account (Account_No, account_type, Surname, Firstname, balance)" &
                        "values(@Account_No, @Account_Type, @Surname, @Firstname, @balance)", conn)
            cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Account_Type", cboAccType.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Balance", txtStartBalance.Text.Trim)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MsgBox("Account " & txtAccountNo.Text.Trim & " registered successfully ", vbInformation, "Account Registration")
        Call frmNewCustomer_Load(sender, New EventArgs())
    End Sub

    Private Sub txtStartBalance_TextChanged(sender As Object, e As EventArgs) Handles txtStartBalance.TextChanged
        If IsNumeric(txtStartBalance.Text.Trim) = False Then
            txtStartBalance.Text = ""
        End If
    End Sub

    Private Sub txtMobile_TextChanged(sender As Object, e As EventArgs) Handles txtMobile.TextChanged
        If IsNumeric(txtMobile.Text.Trim) = False Then
            txtMobile.Text = ""
        End If
    End Sub

    Private Sub ChkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEdit.CheckedChanged
        If ChkEdit.Checked = True Then
            MsgBox("Please to edit an account info, please enter Account Number and press enter", vbInformation, "Account Editting")
            txtAccountNo.Hint = "Enter Customer's Account Number"
            txtAccountNo.ReadOnly = False
            cboAccType.Enabled = False
            txtStartBalance.ReadOnly = True
            cboBranch.Enabled = False
            cboBranch.Text = ""
            btnEdit.Enabled = True
            btnSave.Enabled = False
            picCustomer.Image = Nothing
            PicSign.Image = Nothing
            cboTitle.Text = ""
            txtSurname.Text = ""
            txtFirstname.Text = ""
            txtMobile.Text = ""
            txtAddress.Text = ""
            txtDOB.Text = ""
            txtDigitalAddress.Text = ""
            txtOcc.Text = ""
            cboMStatus.Text = ""
            txtemail.Text = ""
            txtNKsurname.Text = ""
            txtNKfirstname.Text = ""
            txtNKrelationship.Text = ""
            txtNKmobile.Text = ""
            txtNKaddress.Text = ""
            cboAccType.SelectedItem = "SUSU"
            txtStartBalance.Text = ""
            txtAccountNo.Text = ""
            cboIdType.Text = ""
            TXTIDCARD.Text = ""
            txtAccountNo.Focus()
        End If

        If ChkEdit.Checked = False Then
            Call frmNewCustomer_Load(sender, New EventArgs())
        End If
    End Sub

    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ChkEdit.Checked = True Then

                Label21.Text = "Account Balance"
                Try
                    rAc()
                    rNext()
                    Dim sqlcmdID As New SqlCommand("Select * from customer where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                    ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                    Dim adapter As New SqlDataAdapter(sqlcmdID)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    Dim arione() As Byte
                    Dim aritwo() As Byte
                    txtAccountNo.Text = table.Rows(0)(13).ToString()
                    cboTitle.Text = table.Rows(0)(2).ToString()
                    txtSurname.Text = table.Rows(0)(3).ToString()
                    txtFirstname.Text = table.Rows(0)(4).ToString()
                    txtMobile.Text = table.Rows(0)(5).ToString()
                    txtAddress.Text = table.Rows(0)(6).ToString()
                    txtDigitalAddress.Text = table.Rows(0)(7).ToString()
                    txtDOB.Text = table.Rows(0)(8).ToString()
                    txtOcc.Text = table.Rows(0)(9).ToString()
                    cboMStatus.Text = table.Rows(0)(10).ToString()
                    txtemail.Text = table.Rows(0)(11).ToString()
                    cboAccType.Text = table.Rows(0)(12).ToString()
                    lblAccNo.Text = table.Rows(0)(13).ToString()

                    arione = table.Rows(0)(16)
                    aritwo = table.Rows(0)(17)
                    cboBranch.Text = table.Rows(0)(18).ToString()
                    TXTIDCARD.Text = table.Rows(0)(19).ToString()
                    cboIdType.Text = table.Rows(0)(20).ToString()
                    Dim mstreamm As New System.IO.MemoryStream(arione)
                    Dim mstreammm As New System.IO.MemoryStream(aritwo)
                    picCustomer.Image = Image.FromStream(mstreamm)
                    PicSign.Image = Image.FromStream(mstreammm)
                    txtAccountNo.Text = table.Rows(0)(13).ToString()
                    sqlcmdID.Dispose()
                    'adapter.Dispose()
                    conn.Close()
                    txtSurname.Focus()
                Catch ex As Exception
                    MsgBox("Please the account number is not correct, Please enter the correct account number", vbCritical, "Account Number Error")
                    txtAccountNo.Focus()
                    Exit Sub
                End Try

            End If

        End If
    End Sub

    Public Sub rNext()

        Try
                Dim sqlcmdID As New SqlCommand("Select * from Next_Of_kin where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)


                txtNKsurname.Text = table.Rows(0)(1).ToString()
                txtNKfirstname.Text = table.Rows(0)(2).ToString()
                txtNKmobile.Text = table.Rows(0)(4).ToString()
                txtNKaddress.Text = table.Rows(0)(5).ToString()
                txtNKrelationship.Text = table.Rows(0)(3).ToString()

                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

    End Sub

    Public Sub rAc()

        Try
                Dim sqlcmdID As New SqlCommand("Select * from account where Account_No='" & txtAccountNo.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)


                Dim dae As Double = table.Rows(0)(4).ToString()
                txtStartBalance.Text = Format(dae, "#,##0.00")

                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

    End Sub

    Private Sub btnUpone_Click(sender As Object, e As EventArgs) Handles btnUpone.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        OFD.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|WIndows Bitmaps|*.BMP"
        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            picCustomer.ImageLocation = imgpath
        End If
        OFD = Nothing
    End Sub

    Private Sub btnUPtwo_Click(sender As Object, e As EventArgs) Handles btnUPtwo.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        OFD.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|WIndows Bitmaps|*.BMP"
        If OFD.ShowDialog() = DialogResult.OK Then
            imgpathh = OFD.FileName
            PicSign.ImageLocation = imgpathh
        End If
        OFD = Nothing
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtSurname.Text.Trim = "" Then
            MsgBox("Please enter the customer's surname", vbExclamation, "Entry Error")
            txtSurname.Focus()
            Exit Sub
        End If
        If txtFirstname.Text.Trim = "" Then
            MsgBox("Please enter the customer's firstname", vbExclamation, "Entry Error")
            txtFirstname.Focus()
            Exit Sub
        End If
        If txtMobile.Text.Trim = "" Then
            MsgBox("Please enter the customer's active mobile number", vbExclamation, "Entry Error")
            txtMobile.Focus()
            Exit Sub
        End If
        If txtAddress.Text.Trim = "" Then
            MsgBox("Please enter the customer's address", vbExclamation, "Entry Error")
            txtAddress.Focus()
            Exit Sub
        End If
        If txtDOB.Text.Trim = "" Then
            MsgBox("Please enter the customer's date of birth", vbExclamation, "Entry Error")
            txtDOB.Focus()
            Exit Sub
        End If
        If txtOcc.Text.Trim = "" Then
            MsgBox("Please enter the customer's occupation", vbExclamation, "Entry Error")
            txtOcc.Focus()
            Exit Sub
        End If
        If cboMStatus.Text.Trim = "" Then
            MsgBox("Please enter the customer's marital status", vbExclamation, "Entry Error")
            cboMStatus.Focus()
            Exit Sub
        End If
        If txtNKsurname.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's surname", vbExclamation, "Entry Error")
            txtNKsurname.Focus()
            Exit Sub
        End If
        If txtNKfirstname.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's firstname", vbExclamation, "Entry Error")
            txtNKfirstname.Focus()
            Exit Sub
        End If
        If txtNKrelationship.Text.Trim = "" Then
            MsgBox("Please enter the customer's relationship to the next of kin", vbExclamation, "Entry Error")
            txtNKrelationship.Focus()
            Exit Sub
        End If
        If txtNKmobile.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's mobile number", vbExclamation, "Entry Error")
            txtNKmobile.Focus()
            Exit Sub
        End If
        If txtNKaddress.Text.Trim = "" Then
            MsgBox("Please enter the customer's next of kin's address", vbExclamation, "Entry Error")
            txtNKaddress.Focus()
            Exit Sub
        End If
        If Not cboIdType.Text.Trim = "" And txtidcard.Text = "" Then
            MsgBox("Please enter the customer's ID number", vbExclamation, "Entry Error")
            txtidcard.Focus()
            Exit Sub
        End If
        If Not txtidcard.Text.Trim = "" And cboIdType.Text = "" Then
            MsgBox("Please select the customer's ID Type", vbExclamation, "Entry Error")
            cboIdType.Focus()
            Exit Sub
        End If
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If


            conn.Open()
            ' declare and create a sql command object
            Dim cmdorderDet As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdorderDet.CommandText = "UPDATE Customer SET title=@title, surname=@surname, firstname=@firstname, mobile=@mobile, address=@address,digital_Address=@digital_address, DOB=@DOB, occupation=@occupation, Marital_Status=@Marital_Status, email=@email, picture=@picture ,sign=@sign, branch=@branch, ID_Card=@Id_Card, ID_Type=@ID_Type where Account_No= '" & lblAccNo.Text.Trim & "'"
            ' add the parameters
            Dim mstream As New System.IO.MemoryStream()
            picCustomer.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim filesize As UInt32
            filesize = mstream.Length
            mstream.Close()

            Dim mstreamm As New System.IO.MemoryStream()
            PicSign.Image.Save(mstreamm, System.Drawing.Imaging.ImageFormat.Jpeg)
            aarrimage = mstreamm.GetBuffer()
            Dim filesizee As UInt32
            filesizee = mstreamm.Length
            mstreamm.Close()

            cmdorderDet.Parameters.AddWithValue("@title", cboTitle.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@mobile", txtMobile.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@address", txtAddress.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@digital_Address", txtDigitalAddress.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@DOB", txtDOB.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@occupation", txtOcc.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Marital_Status", cboMStatus.Text)
            cmdorderDet.Parameters.AddWithValue("@email", txtemail.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@picture", arrimage)
            cmdorderDet.Parameters.AddWithValue("@sign", aarrimage)
            cmdorderDet.Parameters.AddWithValue("@branch", cboBranch.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID_Card", TXTIDCARD.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID_Type", cboIdType.Text.Trim)
            'execute the sql statement against the connection
            cmdorderDet.ExecuteNonQuery()
            ' release the resources
            cmdorderDet.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            ' declare and create a sql command object
            Dim cmdorderDet As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdorderDet.CommandText = "UPDATE next_of_kin SET surname=@surname, firstname=@firstname, relationship=@relationship, mobile=@mobile, address=@address where Account_No= '" & lblAccNo.Text.Trim & "'"
            cmdorderDet.Parameters.AddWithValue("@Surname", txtNKsurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Firstname", txtNKfirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Relationship", txtNKrelationship.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Mobile", txtNKmobile.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Address", txtNKaddress.Text.Trim)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim cmdorderDet As SqlCommand = conn.CreateCommand
            cmdorderDet.CommandText = "UPDATE account SET surname=@surname, firstname=@firstname where Account_No= '" & lblAccNo.Text.Trim & "'"

            cmdorderDet.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim)
            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MsgBox("Customer's Details updated successfully", vbInformation, "Details Update")
        Call frmNewCustomer_Load(sender, New EventArgs())
    End Sub

    Private Sub cboBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBranch.SelectedIndexChanged
        lblcode.Text = ""
        Try
            Dim sqlcmdID As New SqlCommand("Select * from branches where name ='" & cboBranch.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)

            lblcode.Text = table.Rows(0)(0).ToString()


            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtAccountNo.Text = lblPre.Text.Trim & lblcode.Text.Trim & lblyearid & lblserial.Text.Trim
    End Sub

    Private Sub lblcode_TextChanged(sender As Object, e As EventArgs) Handles lblcode.TextChanged
        txtAccountNo.Text = lblPre.Text.Trim & lblcode.Text.Trim & lblyearid & lblserial.Text.Trim
    End Sub

    Private Sub MaterialSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialSwitch1.CheckedChanged
        'If MaterialSwitch1.Checked = True Then
        '    SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'Else
        '    SkinManager.Theme = MaterialSkinManager.Themes.DARK
        'End If
    End Sub
End Class