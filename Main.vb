Imports System.Data.SqlClient
Imports MaterialSkin

Public Class Main
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)


        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim sqlcmdd As New SqlCommand("select Name,Address,Telephone,Branch,picture from Bus_Info", conn)
        Dim myreaderd As SqlDataReader
        myreaderd = sqlcmdd.ExecuteReader()
        myreaderd.Read()
        If myreaderd.HasRows Then
            txtBankName.Text = myreaderd.Item("Name").ToString
            txtAddress.Text = myreaderd.Item("Address").ToString
            txtTel.Text = myreaderd.Item("Telephone").ToString
            cboBranch.Text = myreaderd.Item("Branch").ToString

            myreaderd.Dispose()
            myreaderd.Close()
            conn.Close()
        End If
        Me.Text = "CRYSTAL BANK SYSTEM - " & txtBankName.Text.Trim & " (" & lblofficer.Text.Trim & ")"
    End Sub
    Private Sub UserSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserSetupToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmUser.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Customer Service" Or lblpriv.Text.Trim = "Developer" Then
            frmNewCustomer.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub BranchSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BranchSetupToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmBranch.ShowDialog()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub DebitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmDeposite.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            lblCurrentTime.Text = TimeString
            lblCurrentTime.Text = Format(Now, "hh:mm:ss tt")
            Dim myDate As Date = Date.Today.Date
            lblCurrentDate.Text = (myDate.ToString("dd-MMM-yyyy")) & ","
            lblCurrentDay.Text = myDate.DayOfWeek.ToString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Current Date & Time Error")
        Finally
            'conn.Close()
        End Try
    End Sub

    Private Sub RetrieveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmCustomerBalance.ShowDialog()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub IndividualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmDeposite.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub MaterialSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialSwitch1.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            MaterialSwitch1.Text = "SWITCH TO DARK THEME"
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            MaterialSwitch1.Text = "SWITCH TO LIGHT THEME"
        End If
    End Sub

    Private Sub IndividualWidrawalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndividualWidrawalToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmWithdrawal.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmDeposite.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmWithdrawal.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmCustomerBalance.ShowDialog()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub

    Private Sub LoanRequestToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoanRequestToolStripMenuItem1.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Loan Officer" Or lblpriv.Text.Trim = "Developer" Then
            frmLoanRequest.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub BankInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankInfoToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmBankSetup.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub TryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TryToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Developer" Then
            Try


                frmChanges.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub

    Private Sub CustomersStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersStatusToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmCustomerStatus.ShowDialog()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub

    Private Sub MinimumBalanceSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimumBalanceSetupToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmMinSetup.ShowDialog()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub AdministrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrationToolStripMenuItem.Click

    End Sub

    Private Sub AccountTypeSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountTypeSetupToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmAccountSetup.ShowDialog()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub



    Private Sub TransactionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionReportToolStripMenuItem.Click
        frmTransactionReport.ShowDialog()

    End Sub

    Private Sub BankStatementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankStatementToolStripMenuItem.Click
        frmBankStatement.ShowDialog()
    End Sub

    Private Sub LoanApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanApprovalToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Developer" Then
            frmLoanApproval.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
    End Sub

    Private Sub IssueLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueLoanToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Loan Officer" Or lblpriv.Text.Trim = "Developer" Then
            frmIssueLoan.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If
        ' frmIssueLoan.Show()
    End Sub

    Private Sub LoanRequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanRequestToolStripMenuItem.Click
        If lblpriv.Text.Trim = "Manager" Or lblpriv.Text.Trim = "Admin" Or lblpriv.Text.Trim = "Loan Officer" Or lblpriv.Text.Trim = "Teller" Or lblpriv.Text.Trim = "Developer" Then
            frmLoanPayment.Show()
        Else
            MsgBox("Please you do not have the priviledge to access this feature, please contact Manager", vbCritical, "Access Denied")
        End If

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LoginForm.Close()
    End Sub
End Class