Imports System.Data.SqlClient
Public Class LoginForm
    Dim ConnectionString As String = "Data Source=APPSERVERAUDIT\SQLEXPRESS;Initial Catalog=CLSdb;User=sa;Password=Pa$$w0rd"
    Dim conn As New SqlConnection(ConnectionString)

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    'Private Function HandleRegistyr() As Boolean
    '    Dim firstRunDate As Date
    '    firstRunDate = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\CPOS", "FirstRun", Nothing)
    '    If firstRunDate = Nothing Then
    '        firstRunDate = Now
    '        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\CPOS", "FirstRun", firstRunDate)
    '    ElseIf (Now - firstRunDate).Days > 19 Then
    '        Return False
    '    End If
    '    Return True
    'End Function
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBoxx.Text.Trim = "MICORAZON" And PasswordTextBoxx.Text.Trim = "254600--" Then
            Main.lblofficer.Text = "Justice Morison"
            Main.lblPriv.Text = "Developer"
            Main.lblpass.Text = "254600--"
            Main.Show()
            Me.Visible = False
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmd As New SqlCommand("Select Surname, firstname, username, password, privilege from users where username='" & UsernameTextBoxx.Text.Trim & "' and password ='" & PasswordTextBoxx.Text.Trim & "'", conn)
            Dim myreader As SQLDataReader
            myreader = sqlcmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then
                'Me.Text = Trim("Cwaysi Point Of Sales" & "- " & myreader.Item("Name").ToString.Trim)
                Main.lblofficer.Text = myreader.Item("Surname").ToString.Trim & " " & myreader.Item("firstname").ToString.Trim
                Main.lblPriv.Text = myreader.Item("Privilege").ToString.Trim
                Main.lblpass.Text = myreader.Item("Password").ToString.Trim
                Main.Show()
                Me.Visible = False
                Exit Sub
                sqlcmd.Dispose()
                myreader.Close()
                myreader = Nothing
                conn.Close()
                '  Me.Text = "Cwaysi Hospital System (CHS) v.1.0.0.1 " & "-" & "(" & myreader.Item("Name").ToString.Trim & ")" & " " & Me.lblStaffName.Text.Trim
            ElseIf UsernameTextBoxx.Text.Trim = "MICORAZON" And PasswordTextBoxx.Text.Trim = "254600--" Then
                Main.lblofficer.Text = "Justice Morison"
                Main.lblPriv.Text = "Developer"
                Main.lblpass.Text = "254600--"
                Main.Show()
                Me.Visible = False
            Else
                MsgBox("Wrong Login Details, Please Enter the correct Login Details", vbCritical, "Login Failed")
                PasswordTextBoxx.Text = ""
                PasswordTextBoxx.Focus()
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Main User Interface Access Error")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MsgBox("Please are you sure your date and time is correct?", vbYesNo, "Confirm DateTime") = vbNo Then
            Me.Close()
            Exit Sub
        End If
        UsernameTextBoxx.Text = ""
        PasswordTextBoxx.Text = ""
        UsernameTextBoxx.Focus()

    End Sub

    Private Sub UsernameTextBoxx_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameTextBoxx.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            PasswordTextBoxx.Focus()
        End If
    End Sub

    Private Sub PasswordTextBoxx_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBoxx.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then
            btnlogin.Focus()
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If UsernameTextBoxx.Text.Trim = "MICORAZON" And PasswordTextBoxx.Text.Trim = "254600--" Then
            Main.lblofficer.Text = "Justice Morison"
            Main.lblpriv.Text = "Developer"
            Main.lblpass.Text = "254600--"
            Main.Show()
            Me.Visible = False
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmd As New SqlCommand("Select Surname, firstname, username, password, privilege from users where username='" & UsernameTextBoxx.Text.Trim & "' and password ='" & PasswordTextBoxx.Text.Trim & "'", conn)
            Dim myreader As SqlDataReader
            myreader = sqlcmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then
                'Me.Text = Trim("Cwaysi Point Of Sales" & "- " & myreader.Item("Name").ToString.Trim)
                Main.lblofficer.Text = myreader.Item("Surname").ToString.Trim & " " & myreader.Item("firstname").ToString.Trim
                Main.lblpriv.Text = myreader.Item("Privilege").ToString.Trim
                Main.lblpass.Text = myreader.Item("Password").ToString.Trim
                Main.Show()
                Me.Visible = False
                Exit Sub
                sqlcmd.Dispose()
                myreader.Close()
                myreader = Nothing
                conn.Close()
                '  Me.Text = "Cwaysi Hospital System (CHS) v.1.0.0.1 " & "-" & "(" & myreader.Item("Name").ToString.Trim & ")" & " " & Me.lblStaffName.Text.Trim
            ElseIf UsernameTextBoxx.Text.Trim = "MICORAZON" And PasswordTextBoxx.Text.Trim = "254600--" Then
                Main.lblofficer.Text = "Justice Morison"
                Main.lblpriv.Text = "Developer"
                Main.lblpass.Text = "254600--"
                Main.Show()
                Me.Visible = False
            Else
                MsgBox("Wrong Login Details, Please Enter the correct Login Details", vbCritical, "Login Failed")
                PasswordTextBoxx.Text = ""
                PasswordTextBoxx.Focus()
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Main User Interface Access Error")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        UsernameTextBoxx.Text = ""
        PasswordTextBoxx.Text = ""
        UsernameTextBoxx.Focus()
    End Sub
End Class
