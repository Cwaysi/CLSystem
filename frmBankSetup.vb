Imports System.Data.SqlClient
Imports MaterialSkin
Public Class frmBankSetup
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
    Private Sub frmBankSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        ' SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE)


        Dim arione() As Byte
        Try
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
                arione = myreaderd.Item("picture")
                Dim mstreamm As New System.IO.MemoryStream(arione)
                picLogo.Image = Image.FromStream(mstreamm)
                myreaderd.Dispose()
                myreaderd.Close()
                conn.Close()
            Else
                imgpath = Application.StartupPath + "\no image.jpg"
                picLogo.ImageLocation = imgpath
                Try


                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If

                    Dim cmdGridsM As String = "SELECT name FROM branches ORDER BY code ASC"
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpone_Click(sender As Object, e As EventArgs) Handles btnUpone.Click
        Dim OFD As FileDialog = New OpenFileDialog()
        OFD.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|WIndows Bitmaps|*.BMP"
        If OFD.ShowDialog() = DialogResult.OK Then
            imgpath = OFD.FileName
            picLogo.ImageLocation = imgpath
        End If
        OFD = Nothing
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call frmBankSetup_Load(sender, New EventArgs())
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtBankName.Text.Trim = "" Then
            MsgBox("Please enter the bank's name", vbExclamation, "Entry Error")
            txtBankName.Focus()
            Exit Sub
        End If
        If txtAddress.Text.Trim = "" Then
            MsgBox("Please enter the bank's Address", vbExclamation, "Entry Error")
            txtAddress.Focus()
            Exit Sub
        End If
        If txtTel.Text.Trim = "" Then
            MsgBox("Please enter the bank's active mobile/telephone number", vbExclamation, "Entry Error")
            txtTel.Focus()
            Exit Sub
        End If
        If cboBranch.Text.Trim = "" Then
            MsgBox("Please select branch", vbExclamation, "Entry Error")
            cboBranch.Focus()
            Exit Sub
        End If

        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            Dim sqlcmdd As New SqlCommand("select Name,Address,Telephone,Branch,picture from Bus_Info", conn)
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
                cmdStrr.CommandText = "UPDATE Bus_Info SET  name=@name, address=@address, Telephone=@telephone, branch=@branch, picture=@picture "
                ' add the parameters
                Dim mstream As New System.IO.MemoryStream()
                picLogo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrimage = mstream.GetBuffer()
                Dim filesize As UInt32
                filesize = mstream.Length
                mstream.Close()
                cmdStrr.Parameters.AddWithValue("@name", txtBankName.Text.Trim)
                cmdStrr.Parameters.AddWithValue("@address", txtAddress.Text.Trim)
                cmdStrr.Parameters.AddWithValue("@telephone", txtTel.Text.Trim)
                cmdStrr.Parameters.AddWithValue("@branch", cboBranch.Text.Trim)
                cmdStrr.Parameters.AddWithValue("@picture", arrimage)

                'execute the sql statement against the connection
                cmdStrr.ExecuteNonQuery()
                ' release the resources
                cmdStrr.Dispose()
                conn.Close()
                myreaderd.Dispose()
                myreaderd.Close()
                conn.Close()
            Else
                Dim mstream As New System.IO.MemoryStream()
                picLogo.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrimage = mstream.GetBuffer()
                Dim filesize As UInt32
                filesize = mstream.Length
                mstream.Close()
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
                conn.Open()
                ' declare and create a sql command object
                Dim cmd As SqlCommand = conn.CreateCommand
                cmd.CommandText =
                "INSERT INTO Bus_info (name, address, telephone, branch, picture) " &
                "VALUES(@name, @address, @Telephone, @branch, @picture)"
                ' add the parameters
                cmd.Parameters.AddWithValue("@Name", txtBankName.Text.Trim)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim)
                cmd.Parameters.AddWithValue("@Telephone", txtTel.Text.Trim)
                cmd.Parameters.AddWithValue("@branch", cboBranch.Text.Trim)
                cmd.Parameters.AddWithValue("@picture", arrimage)


                ' execute the sql statement against the connection
                cmd.ExecuteNonQuery()
                ' release the resources
                cmd.Dispose()
                conn.Close()
                MsgBox("Bank details has been saved successfully.", vbInformation, "Bank Setup successfully")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class