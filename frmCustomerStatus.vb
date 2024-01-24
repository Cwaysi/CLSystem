Imports System.Data.SqlClient
Imports MaterialSkin
Public Class frmCustomerStatus
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
    Private Sub frmCustomerStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        txtAccountNo.Text = ""
        txtStatus.Text = ""
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtbranch.Text = ""
        txtDesc.Text = ""
        cboStatus.Text = ""
        picCustomer.Image = Nothing
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
                txtStatus.Text = table.Rows(0)(14).ToString()
                txtbranch.Text = table.Rows(0)(18).ToString()
                arione = table.Rows(0)(16)
                aritwo = table.Rows(0)(17)

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAccountNo.Text.Trim = "" Then
            MsgBox("Please enter customer's account number and press ENTER", vbExclamation, "Entry Error")
            txtAccountNo.Focus()
            Exit Sub
        End If
        If cboStatus.Text.Trim = "" Then
            MsgBox("Please enter customer's status which is being changed to", vbExclamation, "Entry Error")
            cboStatus.Focus()
            Exit Sub
        End If
        If cboStatus.Text.Trim = txtStatus.Text.Trim Then
            MsgBox("Please the status cannot be thesame", vbExclamation, "Entry Error")
            cboStatus.Focus()
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
            cmdorderDet.CommandText = "UPDATE customer SET status=@status where Account_No= '" & txtAccountNo.Text.Trim & "'"
            ' add the parameters


            cmdorderDet.Parameters.AddWithValue("@status", cboStatus.Text.Trim)

            'execute the sql statement against the connection
            cmdorderDet.ExecuteNonQuery()
            ' release the resources
            cmdorderDet.Dispose()
            conn.Close()
            logChange()
            MsgBox("Customer's status changes successfully", vbInformation, "Status Change")
            Call frmCustomerStatus_Load(sender, New EventArgs())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
            Dim dep As String = "STATUS CHANGE"
            Dim dsta As String = "VERTED"
            Dim DelNo As String = "ACTIVE"
            Dim AmtChange As String

            AmtChange = "Customer's Status changed from " & txtStatus.Text.Trim & " to " & cboStatus.Text.Trim

            Dim cmdorderDet As New SqlCommand("Insert into Changes_Log (year, month,date,time,officer,form,Account_No, Description,Amount_Change,Status)" &
                        "values(@year, @month,@date,@time, @officer,@form,@Account_no,@Description, @Amount_Change, @Status)", conn)

            cmdorderDet.Parameters.AddWithValue("@Year", lblyear)
            cmdorderDet.Parameters.AddWithValue("@Month", mnt)
            cmdorderDet.Parameters.AddWithValue("@Date", seen)
            cmdorderDet.Parameters.AddWithValue("@Time", dt)
            cmdorderDet.Parameters.AddWithValue("@officer", Main.lblofficer.Text.Trim)
            cmdorderDet.Parameters.AddWithValue("@form", dep)
            cmdorderDet.Parameters.AddWithValue("@Description", txtDesc.Text.Trim)
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
End Class