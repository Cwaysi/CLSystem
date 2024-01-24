Imports MaterialSkin
Imports System.Data.SqlClient


Public Class frmChanges
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
    Private Sub frmChanges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)

        radAll.Checked = True
        btnseen.Enabled = False
        rest()
        'Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log ORDER BY date DESC", conn)
        'Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
        'Dim dssM As New DataSet()
        'conn.Open()
        'If (AdptGridsM.Fill(dssM, "Changes_log")) Then
        '    gridChanges.DataSource = dssM.Tables(0)
        '    ' lblNo.Text = dssM.Tables(0).Rows.Count
        'End If

        'cmdGridsM.Dispose()
        'AdptGridsM.Dispose()
        'dssM.Dispose()
        'conn.Close()
    End Sub

    Private Sub MaterialSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialSwitch1.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            btnseen.Enabled = True
            If radAll.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view all changes"
            End If
            If RadToday.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Try
                    Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' and date ='" & seen.Trim & "' ORDER BY date DESC", conn)
                    Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                    Dim dssM As New DataSet()
                    conn.Open()
                    If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                        gridChanges.DataSource = dssM.Tables(0)
                        ' lblNo.Text = dssM.Tables(0).Rows.Count
                    End If

                    cmdGridsM.Dispose()
                    AdptGridsM.Dispose()
                    dssM.Dispose()
                    conn.Close()
                    MaterialSwitch1.Text = "Switch to view all changes"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            If radMonth.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' and month ='" & mnt & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view all changes"
            End If
            If radYear.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' and year ='" & lblyear & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view all changes"
            End If
        End If
        If MaterialSwitch1.Checked = False Then

            btnseen.Enabled = False
            If radAll.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view unseen changes"
            ElseIf RadToday.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where date ='" & seen.Trim & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view unseen changes"
            ElseIf radMonth.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where month ='" & mnt & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view unseen changes"
            ElseIf radYear.Checked = True Then
                rest()
                gridChanges.DataSource = Nothing
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where year ='" & lblyear & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view unseen changes"
            End If
        End If

    End Sub

    Private Sub MaterialRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radAll.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            rest()
            gridChanges.DataSource = Nothing
            Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' ORDER BY date DESC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                gridChanges.DataSource = dssM.Tables(0)
                ' lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
            MaterialSwitch1.Text = "Switch to view all changes"
        End If
        If MaterialSwitch1.Checked = False Then
            rest()
            gridChanges.DataSource = Nothing
            Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log ORDER BY date DESC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                gridChanges.DataSource = dssM.Tables(0)
                ' lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
        End If
    End Sub

    Private Sub RadToday_CheckedChanged(sender As Object, e As EventArgs) Handles RadToday.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            rest()
            gridChanges.DataSource = Nothing
            Try
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' and date ='" & seen.Trim & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view all changes"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If MaterialSwitch1.Checked = False Then
            rest()
            gridChanges.DataSource = Nothing
            Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where date ='" & seen.Trim & "' ORDER BY date DESC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                gridChanges.DataSource = dssM.Tables(0)
                ' lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
            MaterialSwitch1.Text = "Switch to view unseen changes"
        End If
    End Sub

    Private Sub radMonth_CheckedChanged(sender As Object, e As EventArgs) Handles radMonth.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            rest()
            gridChanges.DataSource = Nothing
            Try
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' and month ='" & mnt & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view all changes"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If MaterialSwitch1.Checked = False Then
            rest()
            gridChanges.DataSource = Nothing
            Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where month ='" & mnt & "' ORDER BY date DESC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                gridChanges.DataSource = dssM.Tables(0)
                ' lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
            MaterialSwitch1.Text = "Switch to view unseen changes"
        End If
    End Sub

    Private Sub radYear_CheckedChanged(sender As Object, e As EventArgs) Handles radYear.CheckedChanged
        If MaterialSwitch1.Checked = True Then
            rest()
            gridChanges.DataSource = Nothing
            Try
                Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where Status='UNVERTED' and year ='" & lblyear & "' ORDER BY date DESC", conn)
                Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
                Dim dssM As New DataSet()
                conn.Open()
                If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                    gridChanges.DataSource = dssM.Tables(0)
                    ' lblNo.Text = dssM.Tables(0).Rows.Count
                End If

                cmdGridsM.Dispose()
                AdptGridsM.Dispose()
                dssM.Dispose()
                conn.Close()
                MaterialSwitch1.Text = "Switch to view all changes"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If MaterialSwitch1.Checked = False Then
            rest()
            gridChanges.DataSource = Nothing
            Dim cmdGridsM As New SqlCommand("SELECT year,month,date,time,officer, form, Account_No as Account, description, Amount_change as Changes, status FROM Changes_log where year ='" & lblyear & "' ORDER BY date DESC", conn)
            Dim AdptGridsM As New SqlDataAdapter(cmdGridsM)
            Dim dssM As New DataSet()
            conn.Open()
            If (AdptGridsM.Fill(dssM, "Changes_log")) Then
                gridChanges.DataSource = dssM.Tables(0)
                ' lblNo.Text = dssM.Tables(0).Rows.Count
            End If

            cmdGridsM.Dispose()
            AdptGridsM.Dispose()
            dssM.Dispose()
            conn.Close()
            MaterialSwitch1.Text = "Switch to view unseen changes"
        End If
    End Sub

    Private Sub gridChanges_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridChanges.CellContentClick
        Dim row As DataGridViewRow = gridChanges.CurrentRow
        Me.lblyy.Text = row.Cells(0).Value.ToString()
        Me.lblmt.Text = row.Cells(1).Value.ToString()
        Me.lbldt.Text = row.Cells(2).Value.ToString()
        Me.lbltm.Text = row.Cells(3).Value.ToString()
        Me.lblof.Text = row.Cells(4).Value.ToString()
        Me.lblfo.Text = row.Cells(5).Value.ToString()
        Me.lblac.Text = row.Cells(6).Value.ToString()
        Me.lblDescription.Text = row.Cells(7).Value.ToString()
        Me.lblChanges.Text = row.Cells(8).Value.ToString()
        Me.lblSt.Text = row.Cells(9).Value.ToString()
    End Sub
    Public Sub rest()
        lbldt.Text = "dt"
        lblyy.Text = "yy"
        lblmt.Text = "mt"
        lblSt.Text = "st"
        lblChanges.Text = ""
        lblDescription.Text = ""
    End Sub

    Private Sub btnseen_Click(sender As Object, e As EventArgs) Handles btnseen.Click
        If lblyy.Text.Trim = "yy" And lblmt.Text.Trim = "mt" And lbldt.Text.Trim = "dt" And lblChanges.Text.Trim = "" And lblSt.Text.Trim = "st" Then
            MsgBox("Please make sure you have selected an unverted change from the list before marking as seen", vbInformation, "Verting Error")
            btnseen.Focus()
            Exit Sub
        End If
        If MsgBox("Are you sure you want to mark this as seen?", vbYesNo, "Confirm Process") = vbNo Then
            Exit Sub
        Else
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            ' declare and create a sql command object
            Dim cmdStrr As SqlCommand = conn.CreateCommand
            ' set the sql statement to execute at the data source
            cmdStrr.CommandText = "UPDATE Changes_log SET status=@status where year='" & lblyy.Text.Trim & "' and month='" & lblmt.Text.Trim & "'
                and date='" & lbldt.Text.Trim & "' and time='" & lbltm.Text.Trim & "' and officer='" & lblof.Text.Trim & "' and form='" & lblfo.Text.Trim & "'
                and Account_no='" & lblac.Text.Trim & "' and description='" & lblDescription.Text.Trim & "' and Amount_Change='" & lblChanges.Text.Trim & "'
                and status='" & lblSt.Text.Trim & "'"
            ' add the parameters
            Dim vert As String = "VERTED"
            cmdStrr.Parameters.AddWithValue("@Status", vert)

            'execute the sql statement against the connection
            cmdStrr.ExecuteNonQuery()
            ' release the resources
            cmdStrr.Dispose()
            conn.Close()
            MsgBox("Changes made seen successfully", vbInformation, "Changes")
            Call frmChanges_Load(sender, New EventArgs())
        End If
    End Sub
End Class