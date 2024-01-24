Imports MaterialSkin
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms


Public Class frmLoanRequest
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
    Private Sub frmLoanRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)

        imgpath = Application.StartupPath + "\no image.jpg"
        picGuarantor1.ImageLocation = imgpath
        picGuarantor2.ImageLocation = imgpath
        txtAccountNo.Text = ""
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtBusName.Text = ""
        txtBusLoacation.Text = ""
        txtLoanAmount.Text = ""
        txtLoanPurpose.Text = ""
        txtPeriodRepay.Text = ""
        txtProInstal.Text = ""
        txtInterest.Text = ""
        TXTGIDCARD1.Text = ""
        TXTGIDCARD2.Text = ""
        cboGIdType1.Text = ""
        cboGIdType2.Text = ""
        txtSecurity.Text = ""
        txtGFullname1.Text = ""
        txtGFullname2.Text = ""
        txtGAddress1.Text = ""
        txtGAddress2.Text = ""
        txtGTel1.Text = ""
        txtGTel2.Text = ""
        txtGOccupation1.Text = ""
        txtGOccupation2.Text = ""
        RadPerMonth.Checked = True
        txtAccountNo.Focus()
    End Sub

    Private Sub txtAccountNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccountNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtAccountNo.Text.Trim = "" Then
                MsgBox("Please enter unique form Number", vbExclamation, "Entry Error")
                txtAccountNo.Focus()
                Exit Sub
            End If
            Try


                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Dim sqlcmdIDd As New SqlCommand("Select Account_No from Loan_Balance where Account_no='" & txtAccountNo.Text.Trim & "' and Status='PENDING'", conn)
                Dim myreaderIdD As SqlDataReader
                conn.Open()
                myreaderIdD = sqlcmdIDd.ExecuteReader()
                myreaderIdD.Read()
                If myreaderIdD.HasRows Then
                    MsgBox("Please this account user has an unfinished loan to pay", vbExclamation, "Entry Error")
                    txtAccountNo.Focus()
                    Exit Sub
                End If
                sqlcmdIDd.Dispose()
                myreaderIdD.Close()
                myreaderIdD = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
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

                arione = table.Rows(0)(16)
                aritwo = table.Rows(0)(17)
                Dim Status As String = table.Rows(0)(14)
                If Not Status.Trim = "ACTIVE" Then
                    MsgBox("Please this customer is not ACTIVE or eligible for loan, please contact manager", vbCritical, "Customer Eligibility")
                    Call frmLoanRequest_Load(sender, New EventArgs())
                    txtAccountNo.Focus()
                    Exit Sub
                End If

                Dim mstreamm As New System.IO.MemoryStream(arione)
                Dim mstreammm As New System.IO.MemoryStream(aritwo)
                picCustomer.Image = Image.FromStream(mstreamm)
                ' PicSign.Image = Image.FromStream(mstreammm)
                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()

            Catch ex As Exception
                MsgBox("Please the account number is not correct, Please enter the correct account number", vbCritical, "Account Number Error")
                txtAccountNo.Focus()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged
        If IsNumeric(txtLoanAmount.Text.Trim) = False Then
            txtLoanAmount.Text = ""
        End If
    End Sub

    Private Sub txtProInstal_TextChanged(sender As Object, e As EventArgs) Handles txtProInstal.TextChanged
        If IsNumeric(txtProInstal.Text.Trim) = False Then
            txtProInstal.Text = ""
        End If
    End Sub

    Private Sub txtInterest_TextChanged(sender As Object, e As EventArgs) Handles txtInterest.TextChanged
        If IsNumeric(txtInterest.Text.Trim) = False Then
            txtInterest.Text = ""
        End If
    End Sub

    Private Sub txtGTel1_TextChanged(sender As Object, e As EventArgs) Handles txtGTel1.TextChanged
        If IsNumeric(txtGTel1.Text.Trim) = False Then
            txtGTel1.Text = ""
        End If
    End Sub

    Private Sub txtGTel2_TextChanged(sender As Object, e As EventArgs) Handles txtGTel2.TextChanged
        If IsNumeric(txtGTel2.Text.Trim) = False Then
            txtGTel2.Text = ""
        End If
    End Sub
    Private Sub txtPeriodRepay_TextChanged(sender As Object, e As EventArgs) Handles txtPeriodRepay.TextChanged
        If IsNumeric(txtPeriodRepay.Text.Trim) = False Then
            txtPeriodRepay.Text = ""
        End If
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call frmLoanRequest_Load(sender, New EventArgs())
    End Sub
    Public Sub entryCheck()
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If txtBusName.Text.Trim = "" Then
            MsgBox("Please enter customer's business name", vbExclamation, "Entry Error")
            txtBusName.Focus()
            Exit Sub
        End If
        If txtBusLoacation.Text.Trim = "" Then
            MsgBox("Please enter customer's business location", vbExclamation, "Entry Error")
            txtBusLoacation.Focus()
            Exit Sub
        End If
        If txtLoanAmount.Text.Trim = "" Then
            MsgBox("Please enter customer's required amount", vbExclamation, "Entry Error")
            txtLoanAmount.Focus()
            Exit Sub
        End If
        If txtLoanPurpose.Text.Trim = "" Then
            MsgBox("Please enter customer's purpose of loan", vbExclamation, "Entry Error")
            txtLoanPurpose.Focus()
            Exit Sub
        End If
        If txtProInstal.Text.Trim = "" Then
            MsgBox("Please enter customer's proposed monthly installment", vbExclamation, "Entry Error")
            txtProInstal.Focus()
            Exit Sub
        End If
        If txtPeriodRepay.Text.Trim = "" Then
            MsgBox("Please enter customer's period of repayment", vbExclamation, "Entry Error")
            txtPeriodRepay.Focus()
            Exit Sub
        End If
        If txtInterest.Text.Trim = "" Then
            MsgBox("Please enter interest rate per the bank's arrangement", vbExclamation, "Entry Error")
            txtInterest.Focus()
            Exit Sub
        End If
        If txtSecurity.Text.Trim = "" Then
            MsgBox("Please enter customer's security or colatoral", vbExclamation, "Entry Error")
            txtSecurity.Focus()
            Exit Sub
        End If
        If txtGFullname1.Text.Trim = "" Then
            MsgBox("Please enter first quarantor's fullname", vbExclamation, "Entry Error")
            txtGFullname1.Focus()
            Exit Sub
        End If
        If txtGAddress1.Text.Trim = "" Then
            MsgBox("Please enter first quarantor's address", vbExclamation, "Entry Error")
            txtGAddress1.Focus()
            Exit Sub
        End If
        If txtGOccupation1.Text.Trim = "" Then
            MsgBox("Please enter first quarantor's occupation", vbExclamation, "Entry Error")
            txtGOccupation1.Focus()
            Exit Sub
        End If
        If txtGTel1.Text.Trim = "" Then
            MsgBox("Please enter first quarantor's telephone or mobile number", vbExclamation, "Entry Error")
            txtGTel1.Focus()
            Exit Sub
        End If
        If Val(txtInterest.Text.Trim) > 100 Then
            MsgBox("Please interest rate can not be more than 100 %", vbExclamation, "Entry Error")
            txtInterest.Focus()
            Exit Sub
        End If
        If Not txtGFullname2.Text.Trim = "" Then
            If txtGAddress2.Text.Trim = "" Then
                MsgBox("Please enter second quarantor's address", vbExclamation, "Entry Error")
                txtGAddress2.Focus()
                Exit Sub
            End If
            If txtGOccupation2.Text.Trim = "" Then
                MsgBox("Please enter second quarantor's occupation", vbExclamation, "Entry Error")
                txtGOccupation2.Focus()
                Exit Sub
            End If
            If txtGTel2.Text.Trim = "" Then
                MsgBox("Please enter second quarantor's telephone or mobile number", vbExclamation, "Entry Error")
                txtGTel2.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        entryCheck()
        Dim dd As Double = Val(txtInterest.Text.Trim) / 100
        Dim interestrate As Double = dd * Val(txtLoanAmount.Text.Trim)
        ' Dim interestRate As String = Val(txtLoanAmount.Text.Trim)
        Dim acc As Double = Val(txtLoanAmount.Text.Trim)
        'txtLoanAmount.Text = Format(acc, "#,##0.00")
        Dim proIn As Double = Val(txtProInstal.Text.Trim)
        txtProInstal.Text = Format(proIn, "#,##0.00")


        ' Dim PerM As String
        If RadPerMonth.Checked = True Then
            lblser.Text = txtPeriodRepay.Text.Trim & " MONTHS"
        ElseIf RadPerWeek.Checked = True Then
            lblser.Text = txtPeriodRepay.Text.Trim & " WEEKS"
        End If

        If MsgBox("Please are you sure " & txtSurname.Text.Trim & " " & txtFirstname.Text.Trim & " is requesting for loan amount GHc" & txtLoanAmount.Text.Trim & " and also print forms for signing and guarantor's confirmation form(s), NB: When you submit this request, you cannot not edit or change any info", vbYesNo, "Loan request Confirmation") = vbNo Then
            txtAccountNo.Focus()
            Exit Sub
        Else

        End If
        Try
            loanno()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim cmdorderDet As New SqlCommand("Insert into Loan (loan_no,day, month, year, Date, Account_no, Surname, Firstname, Business_Name, Business_address, Description, Amount, Purpose, Installment, Period_Repayment, Security, interest, Status, officer)" &
                       "values(@loan_no,@Day, @month, @year, @date, @Account_No, @surname, @firstname, @Business_name, @Business_Address, @Description, @amount, @purpose, @installment, @period_repayment, @security, @Interest, @status, @officer )", conn)

            Dim mstream As New System.IO.MemoryStream()
            picCustomer.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim filesize As UInt32
            filesize = mstream.Length
            mstream.Close()

            Dim Apv As String = "PENDING"
            cmdorderDet.Parameters.AddWithValue("@loan_no", lblserial3.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@day", Main.lblCurrentDay.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Date", seen)
            cmdorderDet.Parameters.AddWithValue("@month", mnt)
            cmdorderDet.Parameters.AddWithValue("@year", lblyear)
            cmdorderDet.Parameters.AddWithValue("@Account_no", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@surname", txtSurname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@firstname", txtFirstname.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Business_name", txtBusName.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Business_address", txtBusLoacation.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Description", txtBusDesc.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Amount", txtLoanAmount.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@purpose", txtLoanPurpose.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@Installment", txtProInstal.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@period_repayment", lblser.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@security", txtSecurity.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@interest", interestRate)
            cmdorderDet.Parameters.AddWithValue("@status", Apv)
            cmdorderDet.Parameters.AddWithValue("@Officer", Main.lblofficer.Text.Trim)

            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            FindSer()
            Dim mstream As New System.IO.MemoryStream()
            picGuarantor1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim filesize As UInt32
            filesize = mstream.Length
            mstream.Close()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()

            Dim DelNo As String = "G1"
            Dim cmdorderDet As New SqlCommand("Insert into guarantor (Account_No, guarantor_no, Fullname, address, telephone, occupation, picture, ID_Type, ID)" &
                        "values(@Account_No, @guarantor_no, @fullname, @address, @telephone, @occupation, @picture, @ID_Type, @ID)", conn)
            cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@guarantor_No", lblserial.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@fullname", txtGFullname1.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@address", txtGAddress1.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@telephone", txtGTel1.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@occupation", txtGOccupation1.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@picture", arrimage)
            cmdorderDet.Parameters.AddWithValue("@ID_Type", cboGIdType1.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@ID", TXTGIDCARD1.Text.Trim)

            cmdorderDet.ExecuteNonQuery()
            cmdorderDet.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        frmReportApplication.Show()
        frmReportLoan.Show()
        If Not txtGFullname2.Text.Trim = "" Then
            Try
                FindSerr()
                Dim mstream As New System.IO.MemoryStream()
                picGuarantor2.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrimage = mstream.GetBuffer()
                Dim filesize As UInt32
                filesize = mstream.Length
                mstream.Close()
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()

                Dim DelNo As String = "G2"
                Dim cmdorderDet As New SqlCommand("Insert into guarantor (Account_No, guarantor_no, Fullname, address, telephone, occupation, picture, ID_Type, ID)" &
                            "values(@Account_No, @guarantor_no, @fullname, @address, @telephone, @occupation, @picture, @ID_Type, @ID)", conn)
                cmdorderDet.Parameters.AddWithValue("@Account_No", txtAccountNo.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@guarantor_No", lblserial2.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@fullname", txtGFullname2.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@address", txtGAddress2.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@telephone", txtGTel2.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@occupation", txtGOccupation2.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@picture", arrimage)
                cmdorderDet.Parameters.AddWithValue("@ID_Type", cboGIdType2.Text.Trim)
                cmdorderDet.Parameters.AddWithValue("@ID", TXTGIDCARD2.Text.Trim)

                cmdorderDet.ExecuteNonQuery()
                cmdorderDet.Dispose()
                conn.Close()
                frmReportLoan2.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        MsgBox("Loan request processed successfully", vbInformation, "Loan Request")
        Call frmLoanRequest_Load(sender, New EventArgs())
    End Sub

    Public Sub FindSer()
        Dim serialno As Double
        ' Dim sen As Integer
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim lblyear As String = Now.ToString("yyyy")
        Dim sqlcmd As New SqlCommand("Select max(Guarantor_No) As guarantor_no from guarantor order by Guarantor_No asc", conn)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            If myreader("Guarantor_No").ToString() <> "" Then
                serialno = Integer.Parse(myreader("Guarantor_No").ToString()) + 1
                ' sen = Integer.Parse(myreader("FID").ToString()) + 1
                lblserial.Text = serialno
            Else
                serialno = 1
                lblserial.Text = "1"
            End If

        Else
            serialno = 1
            lblserial.Text = "1"
        End If
        myreader.Dispose()
        myreader.Close()
        conn.Close()
        lblserial.Text = serialno
    End Sub
    Public Sub FindSerr()
        Dim serialno As Double
        ' Dim sen As Integer
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim lblyear As String = Now.ToString("yyyy")
        Dim sqlcmd As New SqlCommand("Select max(Guarantor_No) As guarantor_no from guarantor order by Guarantor_No asc", conn)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            If myreader("Guarantor_No").ToString() <> "" Then
                serialno = Integer.Parse(myreader("Guarantor_No").ToString()) + 1
                ' sen = Integer.Parse(myreader("FID").ToString()) + 1
                lblserial2.Text = serialno
            Else
                serialno = 1
                lblserial2.Text = "1"
            End If

        Else
            serialno = 1
            lblserial2.Text = "1"
        End If
        myreader.Dispose()
        myreader.Close()
        conn.Close()
        lblserial2.Text = serialno
    End Sub
    Public Sub loanno()
        Dim serialno As Double
        ' Dim sen As Integer
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim lblyear As String = Now.ToString("yyyy")
        Dim sqlcmd As New SqlCommand("Select max(loan_No) As loan_no from loan order by loan_No asc", conn)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            If myreader("loan_No").ToString() <> "" Then
                serialno = Integer.Parse(myreader("loan_No").ToString()) + 1
                ' sen = Integer.Parse(myreader("FID").ToString()) + 1
                lblserial3.Text = serialno
            Else
                serialno = 1
                lblserial3.Text = "1"
            End If

        Else
            serialno = 1
            lblserial3.Text = "1"
        End If
        myreader.Dispose()
        myreader.Close()
        conn.Close()
        lblserial3.Text = serialno
    End Sub

    Private Sub btnUpone_Click(sender As Object, e As EventArgs) Handles btnUpone.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        OFD.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|WIndows Bitmaps|*.BMP"
        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            picGuarantor1.ImageLocation = imgpath
        End If
        OFD = Nothing
    End Sub

    Private Sub btnUptwo_Click(sender As Object, e As EventArgs) Handles btnUptwo.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        OFD.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|WIndows Bitmaps|*.BMP"
        If OFD.ShowDialog() = DialogResult.OK Then
            imgpathh = OFD.FileName
            picGuarantor2.ImageLocation = imgpathh
        End If
        OFD = Nothing
    End Sub

    Private Sub picCustomer_Click(sender As Object, e As EventArgs) Handles picCustomer.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class