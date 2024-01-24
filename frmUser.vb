Imports System.Data.SqlClient
Imports MaterialSkin
Public Class frmUser
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        '  SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtSurname.Text = ""
        txtAddress.Text = ""
        txtMobile.Text = ""
        txtFirstname.Text = ""
        txtUsername.Text = ""
        lblusername.Text = ""
        txtPassword.Text = ""
        txtRPassword.Text = ""
        cboPrivilege.Text = ""
        cboBranch.Text = ""
        txtSurname.Focus()
        grdUsers.DataSource = Nothing
        txtSurname.Focus()
        Try


            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

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
    End Sub
    Private Sub txtSurname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSurname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtFirstname.Focus()
        End If

    End Sub

    Private Sub txtFirstname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMobile.Focus()
        End If
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRPassword.Focus()
        End If
    End Sub

    Private Sub txtRPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPassword.Text.Trim = txtRPassword.Text.Trim Then
                txtPassword.ForeColor = Color.Blue
                txtRPassword.ForeColor = Color.Blue
                cboPrivilege.Focus()
            Else
                txtPassword.ForeColor = Color.Red
                txtRPassword.ForeColor = Color.Red
                MsgBox("Please the Passwords do not match", vbCritical, "Password Match")
                txtPassword.ForeColor = Color.Black
            End If

        End If
    End Sub

    Private Sub cboPrivilege_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPrivilege.KeyDown
        If txtRPassword.Text.Trim = "" Then
            MsgBox("Please re-enter password to confirm password", vbInformation, "User Requirement")
            txtRPassword.Focus()
        Else
            If e.KeyCode = Keys.Enter Then
                If ChkEdit.Checked = True Then
                    btnEdit.Focus()
                Else
                    btnSave.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtRPassword_TextChanged(sender As Object, e As EventArgs) Handles txtRPassword.TextChanged
        txtRPassword.ForeColor = Color.Black
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSurname.Text = ""
        txtFirstname.Text = ""
        txtAddress.Text = ""
        txtMobile.Text = ""
        txtUsername.Text = ""
        lblusername.Text = ""
        txtPassword.Text = ""
        txtRPassword.Text = ""
        cboPrivilege.Text = ""
        cboBranch.Text = ""
        txtSurname.Focus()
    End Sub

    Private Sub txtMobile_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        End If
    End Sub

    Private Sub txtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtSurname.Text.Trim = "" Then
            MsgBox("Enter your Surname, please.", vbInformation, "User Requirement")
            txtSurname.Focus()
            Exit Sub
        End If
        If txtFirstname.Text.Trim = "" Then
            MsgBox("Enter your Firstname, please.", vbInformation, "User Requirement")
            txtFirstname.Focus()
            Exit Sub
        End If
        If txtUsername.Text.Trim = "" Then
            MsgBox("Enter your Username, please.", vbInformation, "User Requirement")
            txtUsername.Focus()
            Exit Sub
        End If
        If txtMobile.Text.Trim = "" Then
            MsgBox("Enter your Mobile, please.", vbInformation, "User Requirement")
            txtMobile.Focus()
            Exit Sub
        End If
        If txtAddress.Text.Trim = "" Then
            MsgBox("Enter your Address, please.", vbInformation, "User Requirement")
            txtAddress.Focus()
            Exit Sub
        End If
        If cboBranch.Text.Trim = "" Then
            MsgBox("Enter select branch of User.", vbInformation, "User Requirement")
            cboBranch.Focus()
            Exit Sub
        End If
        If txtPassword.Text.Trim = "" Then
            MsgBox("Enter your Password, please.", vbInformation, "User Requirement")
            txtPassword.Focus()
            Exit Sub
        End If
        If cboPrivilege.Text.Trim = "" Then
            MsgBox("Choose a Privilege, please.", vbInformation, "User Requirement")
            cboPrivilege.Focus()
            Exit Sub
        End If
        If txtRPassword.Text.Trim = "" Then
            MsgBox("Please re-enter password to confirm password", vbInformation, "User Requirement")
            txtRPassword.Focus()
            Exit Sub
        End If

        Dim sqlcmdID As New SqlCommand("Select Username from Users where Username='" & txtUsername.Text.Trim & "'", conn)
        Dim myreaderID As SqlDataReader
        conn.Open()
        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If myreaderID.HasRows Then
            ' Dim FName As String
            ' FName = myreaderID.Item("Full_Name").ToString.Trim
            MsgBox("Dear " & txtSurname.Text.Trim & ", this Username, " & txtUsername.Text.Trim & ", you provided has already been assigned to someone, Dupplicate Username entry is NOT accepted.", vbInformation, "Dupplicate Username Entry Denied")
            sqlcmdID.Dispose()
            myreaderID.Close()
            myreaderID = Nothing
            ' FName = Nothing
            conn.Close()
            txtUsername.Focus()
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            ' declare and create a sql command object
            Dim cmd As SqlCommand = conn.CreateCommand
            cmd.CommandText =
            "INSERT INTO Users (Surname,Firstname,Mobile, Address, Username,Password,Privilege,branch) " &
            "VALUES(@Surname,@Firstname, @mobile, @Address, @Username,@Password,@Privilege,@branch)"
            ' add the parameters
            cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim)
            cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim)
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim)
            cmd.Parameters.AddWithValue("@Privilege", cboPrivilege.Text.Trim)
            cmd.Parameters.AddWithValue("@branch", cboBranch.Text.Trim)

            ' execute the sql statement against the connection
            cmd.ExecuteNonQuery()
            ' release the resources
            cmd.Dispose()
            conn.Close()
            MsgBox("Dear " & txtFirstname.Text.Trim & " " & txtSurname.Text.Trim & " Your details has been saved successfully.", vbInformation, "Signup successfully")
            txtFirstname.Text = ""
            txtSurname.Text = ""
            txtUsername.Text = ""
            lblusername.Text = ""
            txtMobile.Text = ""
            txtAddress.Text = ""
            txtPassword.Text = ""
            txtRPassword.Text = ""
            cboPrivilege.Text = ""
            cboBranch.Text = ""
            txtSurname.Focus()
            Exit Sub

        End If
    End Sub

    Private Sub ChkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEdit.CheckedChanged

        If ChkEdit.Checked = False Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
            lblNo.Text = ""
            btnSave.Enabled = True
            txtSurname.Text = ""
            txtFirstname.Text = ""
            txtMobile.Text = ""
            txtAddress.Text = ""
            txtUsername.Text = ""
            lblusername.Text = ""
            txtPassword.Text = ""
            txtRPassword.Text = ""
            cboPrivilege.Text = ""
            cboBranch.Text = ""
            txtSurname.Focus()
            grdUsers.DataSource = Nothing
        Else
            btnEdit.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
            txtSurname.Text = ""
            txtFirstname.Text = ""
            txtMobile.Text = ""
            txtAddress.Text = ""
            txtUsername.Text = ""
            lblusername.Text = ""
            txtPassword.Text = ""
            txtRPassword.Text = ""
            cboPrivilege.Text = ""
            cboBranch.Text = ""
            txtSurname.Focus()

            Dim cmdGridsM As New SqlCommand("SELECT Surname,Firstname,Mobile, Address,Username,Privilege,Branch FROM Users ORDER BY Surname ASC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "users")) Then
                grdUsers.DataSource = dssM.Tables(0)
                lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
        End If
    End Sub
    Private Sub grdUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdUsers.CellContentClick
        Dim row As DataGridViewRow = grdUsers.CurrentRow
        Me.txtSurname.Text = row.Cells(0).Value.ToString()
        Me.txtFirstname.Text = row.Cells(1).Value.ToString()
        Me.txtMobile.Text = row.Cells(2).Value.ToString()
        Me.txtAddress.Text = row.Cells(3).Value.ToString()
        Me.txtUsername.Text = row.Cells(4).Value.ToString()
        Me.lblusername.Text = row.Cells(4).Value.ToString()
        Me.cboPrivilege.Text = row.Cells(5).Value.ToString()
        Me.cboBranch.Text = row.Cells(6).Value.ToString()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtUsername.Text.Trim = "" Then
            MsgBox("Please choose a User from the GridView on your Right ", vbCritical, "Deletion Error")
            txtSurname.Focus()
            Exit Sub
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If MsgBox("Are you sure you want to Delete User " & txtUsername.Text.Trim & ", from the System? NOTE that User " & txtUsername.Text.Trim & " details can't be retrieved", vbYesNo, "Please Confirm") = vbNo Then
                txtSurname.Focus()
                Exit Sub
            Else
                conn.Open()
                Dim sqlcmdDel As New SqlCommand("Delete from users where username= '" & txtUsername.Text.Trim & "'", conn)
                sqlcmdDel.ExecuteNonQuery()
                sqlcmdDel.Dispose()
                conn.Close()
                txtFirstname.Text = ""
                txtAddress.Text = ""
                txtMobile.Text = ""
                txtSurname.Text = ""
                txtUsername.Text = ""
                lblusername.Text = ""
                txtPassword.Text = ""
                txtRPassword.Text = ""
                cboPrivilege.Text = ""
                cboBranch.Text = ""
                txtSurname.Focus()

                Dim cmdGridsM As New SqlCommand("SELECT Surname,Firstname,Username,Privilege FROM Users ORDER BY Surname ASC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "users")) Then
                    grdUsers.DataSource = dssM.Tables(0)
                    lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtUsername.Text.Trim = "" Then
            MsgBox("Please choose a User from the GridView on your Right ", vbCritical, "Modification Error")
            txtSurname.Focus()
        ElseIf txtPassword.Text.Trim = "" Then
            MsgBox("Please enter Password ", vbCritical, "Modification Error")
            txtPassword.Focus()
        ElseIf txtmobile.Text.Trim = "" Then
            MsgBox("Please enter Mobile Number ", vbCritical, "Modification Error")
            txtMobile.Focus()
        ElseIf txtaddress.Text.Trim = "" Then
            MsgBox("Please enter Address ", vbCritical, "Modification Error")
            txtAddress.Focus()
        ElseIf txtRPassword.Text.Trim = "" Then
            MsgBox("Please re-enter password to confirm ", vbCritical, "Modification Error")
            txtRPassword.Focus()
        ElseIf MsgBox("Are you sure you want to Modify User " & lblUsername.Text.Trim & ", from the System? ", vbYesNo, "Please Confirm") = vbNo Then
            txtSurname.Focus()
        Else

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            ' declare and create a sql command object
            Dim cmdStrr As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdStrr.CommandText = "UPDATE Users SET Surname= @Surname,Firstname=@Firstname,Mobile=@Mobile,address=@address,Username=@Username,Password=@password,Privilege=@Privilege, branch=@branch WHERE Username = '" & lblusername.Text.Trim & "'"
            ' add the parameters
            cmdStrr.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@Address", txtAddress.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@Username", txtUsername.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@Password", txtPassword.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@Privilege", cboPrivilege.Text.Trim)
            cmdStrr.Parameters.AddWithValue("@branch", cboBranch.Text.Trim)
            'execute the sql statement against the connection
            cmdStrr.ExecuteNonQuery()
            ' release the resources
            cmdStrr.Dispose()
            conn.Close()

            txtFirstname.Text = ""
            txtSurname.Text = ""
            txtMobile.Text = ""
            txtAddress.Text = ""
            txtUsername.Text = ""
            lblusername.Text = ""
            txtPassword.Text = ""
            txtRPassword.Text = ""
            cboPrivilege.Text = ""
            cboBranch.Text = ""
            txtSurname.Focus()

            Dim cmdGridsM As New SqlCommand("SELECT Surname,Firstname,Mobile,Address,Username,Privilege,branch FROM Users ORDER BY Surname ASC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "users")) Then
                grdUsers.DataSource = dssM.Tables(0)
                lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
        End If
    End Sub


End Class