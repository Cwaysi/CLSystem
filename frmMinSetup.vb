Imports MaterialSkin
Imports System.Data.SqlClient
Public Class frmMinSetup
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Private Sub frmMinSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        'SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)

        Try


            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            Dim cmdGridsM As String = "SELECT name FROM account_type ORDER BY name ASC"
            Dim Adpt As New SqlDataAdapter(cmdGridsM, conn)
            Dim dt As New DataTable
            Adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cboAccounts
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

        cboAccounts.Text = ""
        txtMinAmount.Text = ""
        txtNewAmount.Text = ""
        txtNewAmount.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call frmMinSetup_Load(sender, New EventArgs())
    End Sub

    Private Sub cboAccounts_KeyDown(sender As Object, e As KeyEventArgs) Handles cboAccounts.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sqlcmdID As New SqlCommand("Select * from Min_balance where Account ='" & cboAccounts.Text.Trim & "'", conn)
                ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
                Dim adapter As New SqlDataAdapter(sqlcmdID)
                Dim table As New DataTable
                adapter.Fill(table)

                Dim sdr As Double = table.Rows(0)(1).ToString()
                txtMinAmount.Text = Format(sdr, "#,##0.00").Trim
                ' lblcode.Text = table.Rows(0)(0).ToString()


                sqlcmdID.Dispose()
                'myreaderID.Dispose()
                conn.Close()
            Catch ex As Exception
                MsgBox("Please there is no minimum balance set for theis account type in the system, please contact the Admin", vbExclamation, "Account Type Access Error")
                txtMinAmount.Text = ""
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboAccounts.Text.Trim = "" Then
            MsgBox("Please select an account type from the list", vbExclamation, "Entry Error")
            cboAccounts.Focus()
            cboAccounts.DroppedDown = True
            Exit Sub
        End If
        If txtNewAmount.Text.Trim = "" Then
            MsgBox("Please enter the minimum balance", vbExclamation, "Entry Error")
            txtNewAmount.Focus()
            Exit Sub
        End If


        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmdd As New SqlCommand("select Account, amount from Min_Balance where account='" & cboAccounts.Text.Trim & "'", conn)
            Dim myreaderd As SqlDataReader
            myreaderd = sqlcmdd.ExecuteReader()
            myreaderd.Read()
            If myreaderd.HasRows Then
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                ' declare and create a sql command object
                Dim cmdStrr As SqlCommand = conn.CreateCommand
                ' set the sql statement to execute at the data source
                cmdStrr.CommandText = "UPDATE min_balance SET  amount=@amount where account='" & cboAccounts.Text.Trim & "'"
                ' add the parameters

                cmdStrr.Parameters.AddWithValue("@amount", txtNewAmount.Text.Trim)


                'execute the sql statement against the connection
                cmdStrr.ExecuteNonQuery()
                ' release the resources
                cmdStrr.Dispose()
                conn.Close()
                myreaderd.Dispose()
                myreaderd.Close()
                conn.Close()
                MsgBox("Minimum balance for Account type " & cboAccounts.Text.Trim & " has been set successfully.", vbInformation, "Minimum Balance Setup successfull")

            Else

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                ' declare and create a sql command object
                Dim cmd As SqlCommand = conn.CreateCommand
                cmd.CommandText =
                "INSERT INTO Min_balance (account, amount) " &
                "VALUES(@account, @amount)"
                ' add the parameters
                cmd.Parameters.AddWithValue("@account", cboAccounts.Text.Trim)
                cmd.Parameters.AddWithValue("@amount", txtNewAmount.Text.Trim)



                ' execute the sql statement against the connection
                cmd.ExecuteNonQuery()
                ' release the resources
                cmd.Dispose()
                conn.Close()
                MsgBox("Minimum balance for Account type " & cboAccounts.Text.Trim & " has been set successfully.", vbInformation, "Minimum Balance Setup successfull")
                Call frmMinSetup_Load(sender, New EventArgs())
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtNewAmount_TextChanged(sender As Object, e As EventArgs) Handles txtNewAmount.TextChanged
        If IsNumeric(txtNewAmount.Text.Trim) = False Then
            txtNewAmount.Text = ""
        End If
    End Sub

    Private Sub cboAccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccounts.SelectedIndexChanged
        Try
            Dim sqlcmdID As New SqlCommand("Select * from Min_balance where Account ='" & cboAccounts.Text.Trim & "'", conn)
            ' sqlcmdID.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtproductname.Text.Trim
            Dim adapter As New SqlDataAdapter(sqlcmdID)
            Dim table As New DataTable
            adapter.Fill(table)

            Dim sdr As Double = table.Rows(0)(1).ToString()
            txtMinAmount.Text = Format(sdr, "#,##0.00").Trim
            ' lblcode.Text = table.Rows(0)(0).ToString()


            sqlcmdID.Dispose()
            'myreaderID.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox("Please there is no minimum balance set for theis account type in the system, please contact the Admin", vbExclamation, "Account Type Access Error")
            txtMinAmount.Text = ""
        End Try
    End Sub
End Class