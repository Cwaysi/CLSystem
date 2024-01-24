Imports System.Data.SqlClient
Imports MaterialSkin

Public Class frmBranch
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Private Sub frmBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        'SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)

        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        txtname.Text = ""
        cboCode.Text = ""
        cboCode.Items.Clear()
        ChkEdit.Checked = False
        cboCode.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtname.Text = ""
        cboCode.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboCode.Text.Trim = "" Then
            MsgBox("Please enter a unique code for the branch", vbInformation, "Branch Code")
            cboCode.Focus()
            Exit Sub
        End If
        If txtname.Text.Trim = "" Then
            MsgBox("Please branch name", vbInformation, "Branch Entry Requirement")
            txtname.Focus()
            Exit Sub
        End If
        Dim sqlcmdID As New SqlCommand("Select code from branches where code='" & cboCode.Text.Trim & "'", conn)
        Dim myreaderID As SqlDataReader
        conn.Open()
        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If myreaderID.HasRows Then
            ' Dim FName As String
            ' FName = myreaderID.Item("Full_Name").ToString.Trim
            MsgBox("Please this code " & cboCode.Text.Trim & ", you provided has already been assigned to a branch, Dupplicate Branch Codes entry is NOT accepted.", vbInformation, "Dupplicate Branch Code Entry Denied")
            sqlcmdID.Dispose()
            myreaderID.Close()
            myreaderID = Nothing
            ' FName = Nothing
            conn.Close()
            cboCode.Focus()
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            ' declare and create a sql command object
            Dim cmd As SqlCommand = conn.CreateCommand
            cmd.CommandText =
            "INSERT INTO branches (code,name) " &
            "VALUES(@code, @name)"
            ' add the parameters
            cmd.Parameters.AddWithValue("@code", cboCode.Text.Trim)
            cmd.Parameters.AddWithValue("@Name", txtname.Text.Trim)


            ' execute the sql statement against the connection
            cmd.ExecuteNonQuery()
            ' release the resources
            cmd.Dispose()
            conn.Close()
            MsgBox("Branch details has been saved successfully.", vbInformation, "Branch Setup successfully")
            txtname.Text = ""
            cboCode.Text = ""
            cboCode.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub ChkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEdit.CheckedChanged
        If ChkEdit.Checked = True Then
            btnDelete.Enabled = True
            btnEdit.Enabled = True
            btnSave.Enabled = False
            txtname.Text = ""
            cboCode.Text = ""
            cboCode.Focus()

            Try


                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                Dim cmdGridsM As String = "SELECT code FROM branches ORDER BY code ASC"
                Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
                Dim dt As New DataTable
                Adpt.Fill(dt)
                If dt.Rows.Count > 0 Then
                    With cboCode
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
            Call frmBranch_Load(sender, New EventArgs())
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cboCode.Text.Trim = "" Then
            MsgBox("Please enter a unique code for the branch", vbInformation, "Branch Code")
            cboCode.Focus()
            Exit Sub
        End If
        If txtname.Text.Trim = "" Then
            MsgBox("Please branch name", vbInformation, "Branch Entry Requirement")
            txtname.Focus()
            Exit Sub
        End If
        Dim sqlcmdID As New SqlCommand("Select code from branches where code='" & cboCode.Text.Trim & "' and code NOT in (Select code from branches where code='" & lblcode.Text.Trim & "')", conn)
        Dim myreaderID As SqlDataReader
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        myreaderID = sqlcmdID.ExecuteReader()
        myreaderID.Read()
        If myreaderID.HasRows Then
            ' Dim FName As String
            ' FName = myreaderID.Item("Full_Name").ToString.Trim
            If Not cboCode.Text.Trim = lblcode.Text.Trim Then
                MsgBox("Please this code " & cboCode.Text.Trim & ", you provided has already been assigned to a branch, Dupplicate Branch Codes entry is NOT accepted.", vbInformation, "Dupplicate Branch Code Entry Denied")
                sqlcmdID.Dispose()
                myreaderID.Close()
                myreaderID = Nothing
                ' FName = Nothing
                conn.Close()
                cboCode.Focus()
                Exit Sub
            End If
        End If
            If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        ' declare and create a sql command object
        Dim cmdStrr As SqlCommand = conn.CreateCommand
        ' set the sql statement to execute at the data source
        cmdStrr.CommandText = "UPDATE branches SET code=@code, name=@name WHERE code = '" & lblcode.Text.Trim & "'"
        ' add the parameters
        cmdStrr.Parameters.AddWithValue("@code", cboCode.Text.Trim)
        cmdStrr.Parameters.AddWithValue("@name", txtname.Text.Trim)

        'execute the sql statement against the connection
        cmdStrr.ExecuteNonQuery()
        ' release the resources
        cmdStrr.Dispose()
        conn.Close()

        txtname.Text = ""
        cboCode.Text = ""
        cboCode.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtname.Text.Trim = "" Then
            MsgBox("Please choose a branch code from the list ", vbCritical, "Deletion Error")
            txtname.Focus()
            Exit Sub
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            If MsgBox("Are you sure you want to Delete Branch " & cboCode.Text.Trim & ", from the System?", vbYesNo, "Please Confirm") = vbNo Then
                cboCode.Focus()
                Exit Sub
            Else
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                Dim sqlcmdDel As New SqlCommand("Delete from branches where code= '" & lblcode.Text.Trim & "'", conn)
                sqlcmdDel.ExecuteNonQuery()
                sqlcmdDel.Dispose()
                conn.Close()
                Call frmBranch_Load(sender, New EventArgs())
            End If
        End If
    End Sub

    Private Sub cboCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sqlcmdID As New SqlCommand("Select * from branches where code ='" & cboCode.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)

                txtname.Text = table.Rows(0)(1).ToString()
                lblcode.Text = table.Rows(0)(0).ToString()


                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Please the code you entered does not exit in the system, please contact the Admin", vbExclamation, "Branch Access Error")
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class