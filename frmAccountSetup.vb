Imports MaterialSkin
Imports System.Data.SqlClient
Public Class frmAccountSetup
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Private Sub frmAccountSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        'SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)

        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        txtAccName.Text = ""
        cboAccCode.Items.Clear()
        cboAccCode.Text = ""
        ChkEdit.Checked = False
        cboAccCode.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAccName.Text = ""
        cboAccCode.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboAccCode.Text.Trim = "" Then
            MsgBox("Please enter a unique code for the account type", vbExclamation, "Account Code")
            cboAccCode.Focus()
            Exit Sub
        End If
        If txtAccName.Text.Trim = "" Then
            MsgBox("Please enter account type name", vbExclamation, "Account Entry Requirement")
            txtAccName.Focus()
            Exit Sub
        End If
        Dim sqlcmdID As New SqlCommand("Select code from Account_type where code='" & cboAccCode.Text.Trim & "'", conn)
        Dim myreaderID As SqlDataReader
        conn.Open()
        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If myreaderID.HasRows Then
            ' Dim FName As String
            ' FName = myreaderID.Item("Full_Name").ToString.Trim
            MsgBox("Please this code " & cboAccCode.Text.Trim & ", you provided has already been assigned to an account type, Dupplicate Account Codes entry is NOT accepted.", vbExclamation, "Dupplicate Account Code Entry Denied")
            sqlcmdID.Dispose()
            myreaderID.Close()
            myreaderID = Nothing
            ' FName = Nothing
            conn.Close()

            cboAccCode.Focus()
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            ' declare and create a sql command object
            Dim cmd As SqlCommand = conn.CreateCommand
            cmd.CommandText =
            "INSERT INTO Account_Type (code,name) " &
            "VALUES(@code, @name)"
            ' add the parameters
            cmd.Parameters.AddWithValue("@code", cboAccCode.Text.Trim)
            cmd.Parameters.AddWithValue("@Name", txtAccName.Text.Trim)


            ' execute the sql statement against the connection
            cmd.ExecuteNonQuery()
            ' release the resources
            cmd.Dispose()
            conn.Close()
            MsgBox("Branch details has been saved successfully.", vbInformation, "Account Type Setup successfully")
            txtAccName.Text = ""
            cboAccCode.Text = ""
            cboAccCode.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ChkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEdit.CheckedChanged
        If ChkEdit.Checked = True Then
            btnDelete.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            txtAccName.Text = ""
            cboAccCode.Text = ""
            cboAccCode.Focus()

            Try


                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Dim cmdGridsM As String = "SELECT code FROM Account_Type ORDER BY code ASC"
                Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
                Dim dt As New DataTable
                Adpt.Fill(dt)
                If dt.Rows.Count > 0 Then
                    With cboAccCode
                        .Items.Clear()
                        For i As Integer = 0 To dt.Rows.Count - 1
                            .Items.Add(dt.Rows(i).Item("code"))
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

        End If
        If ChkEdit.Checked = False Then
            Call frmAccountSetup_Load(sender, New EventArgs())
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cboAccCode.Text.Trim = "" Then
            MsgBox("Please enter a unique code for the branch", vbExclamation, "Account Code")
            cboAccCode.Focus()
            Exit Sub
        End If
        If txtAccName.Text.Trim = "" Then
            MsgBox("Please branch name", vbExclamation, "Account Entry Requirement")
            txtAccName.Focus()
            Exit Sub
        End If
        Dim sqlcmdID As New SqlCommand("Select code from Account_type where code='" & cboAccCode.Text.Trim & "' and code NOT in (Select code from Account_type where code='" & lblcode.Text.Trim & "')", conn)
        Dim myreaderID As SqlDataReader
        conn.Open()
        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If myreaderID.HasRows Then
            ' Dim FName As String
            ' FName = myreaderID.Item("Full_Name").ToString.Trim
            MsgBox("Please this code " & cboAccCode.Text.Trim & ", you provided has already been assigned to an account, Dupplicate account Codes entry is NOT accepted.", vbExclamation, "Dupplicate Account Type Code Entry Denied")
            sqlcmdID.Dispose()
            myreaderID.Close()
            myreaderID = Nothing
            ' FName = Nothing
            conn.Close()
            cboAccCode.Focus()
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        ' declare and create a sql command object
        Dim cmdStrr As SqlCommand = conn.CreateCommand
        ' set the sql statement to execute at the data source
        cmdStrr.CommandText = "UPDATE account_type SET code=@code, name=@name WHERE code = '" & lblcode.Text.Trim & "'"
        ' add the parameters
        cmdStrr.Parameters.AddWithValue("@code", cboAccCode.Text.Trim)
        cmdStrr.Parameters.AddWithValue("@name", txtAccName.Text.Trim)

        'execute the sql statement against the connection
        cmdStrr.ExecuteNonQuery()
        ' release the resources
        cmdStrr.Dispose()
        conn.Close()

        txtAccName.Text = ""
        cboAccCode.Text = ""
        cboAccCode.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAccName.Text.Trim = "" Then
            MsgBox("Please choose an account Code from the list ", vbCritical, "Deletion Error")
            txtAccName.Focus()
            Exit Sub
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If MsgBox("Are you sure you want to Delete Account type " & cboAccCode.Text.Trim & ", from the System?", vbYesNo, "Please Confirm") = vbNo Then
                cboAccCode.Focus()
                Exit Sub
            Else
                conn.Open()
                Dim sqlcmdDel As New SqlCommand("Delete from Account_Type where code= '" & lblcode.Text.Trim & "'", conn)
                sqlcmdDel.ExecuteNonQuery()
                sqlcmdDel.Dispose()
                conn.Close()
                Call frmAccountSetup_Load(sender, New EventArgs())
            End If
        End If
    End Sub

    Private Sub cboAccCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cboAccCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sqlcmdID As New SqlCommand("Select * from Account_Type where code ='" & cboAccCode.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)

                txtAccName.Text = table.Rows(0)(1).ToString()
                lblcode.Text = table.Rows(0)(0).ToString()


                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Please the code you entered does not exit in the system, please contact the Admin", vbExclamation, "Account Type Access Error")
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class