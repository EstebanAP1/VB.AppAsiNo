Imports System.Data.OleDb
Public Class FrmUsuario
    Private ConnectionString As String

    Sub New()
        InitializeComponent()

        Dim route = Application.StartupPath & "\bdusuarios.accdb"
        ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={route}"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadComboUserStatus()
        Call LoadComboUserType()
    End Sub

    Private Sub LoadComboUserStatus()
        Dim vSql = "SELECT [id],[value] FROM UserStatus"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(command)

        da.Fill(dt)
        connection.Close()

        CmbUserStatus.DataSource = dt
        CmbUserStatus.DisplayMember = "value"
        CmbUserStatus.ValueMember = "id"
        CmbUserStatus.SelectedIndex = -1
    End Sub

    Private Sub LoadComboUserType()
        Dim vSql = "SELECT [id],[value] FROM UserType"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(command)

        da.Fill(dt)
        connection.Close()

        CmbUserType.DataSource = dt
        CmbUserType.DisplayMember = "value"
        CmbUserType.ValueMember = "id"
        CmbUserType.SelectedIndex = -1
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Dim vSql = "INSERT INTO User([username],[password],[name],[status],[type])
                    VALUES (:username,:password,:name,:status,:type)"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add(":username", OleDbType.VarChar).Value = TxtUsername.Text
        command.Parameters.Add(":password", OleDbType.VarChar).Value = TxtPassword.Text
        command.Parameters.Add(":name", OleDbType.VarChar).Value = TxtName.Text
        command.Parameters.Add(":status", OleDbType.Integer).Value = Convert.ToInt32(CmbUserStatus.SelectedValue)
        command.Parameters.Add(":type", OleDbType.Integer).Value = Convert.ToInt32(CmbUserType.SelectedValue)

        Try
            command.ExecuteNonQuery()
            MessageBox.Show($"User {TxtUsername.Text} has been created.")
            Call CleanUserForm()
        Catch ex As OleDbException
            If ex.ErrorCode = -2147467259 Then
                MessageBox.Show($"User {TxtUsername.Text} already exists.")
                Return
            End If
            MessageBox.Show($"OleDb error: {ex.Message}", ex.ErrorCode.ToString())
        Catch ex As Exception
            MessageBox.Show($"Unknown error: {ex.Message}")
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim vSql = "UPDATE Usuario SET [password]=:password,[name]=:name,[status]=:status,[type]=:type WHERE [username]=:username"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add(":password", OleDbType.VarChar).Value = TxtPassword.Text
        command.Parameters.Add(":name", OleDbType.VarChar).Value = TxtName.Text
        command.Parameters.Add(":status", OleDbType.Integer).Value = Convert.ToInt32(CmbUserStatus.SelectedValue)
        command.Parameters.Add(":type", OleDbType.Integer).Value = Convert.ToInt32(CmbUserType.SelectedValue)
        command.Parameters.Add(":username", OleDbType.VarChar).Value = TxtUsername.Text

        Dim result = command.ExecuteNonQuery()

        If result <= 0 Then
            MessageBox.Show("User not fount.")
        Else
            MessageBox.Show($"User {TxtUsername.Text} has been updated.")
        End If

        connection.Close()
    End Sub

    Private Sub BtnSearchDr_Click(sender As Object, e As EventArgs) Handles BtnSearchDr.Click
        Call CleanUserForm(TxtUsername.Text)

        Dim vSql = "SELECT [username],[password],[name],[status],[type] FROM User WHERE [username]=:username"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add(":username", OleDbType.VarChar).Value = TxtUsername.Text
        Dim dr As OleDbDataReader = command.ExecuteReader

        If dr.Read() Then
            TxtUsername.Text = dr("username").ToString
            TxtPassword.Text = dr("password").ToString
            TxtPasswordConfirm.Text = TxtPassword.Text
            TxtName.Text = dr("name").ToString
            CmbUserStatus.SelectedValue = dr("status")
            CmbUserType.SelectedValue = dr("type")
        Else
            MessageBox.Show("User not found.")
        End If

        connection.Close()
    End Sub

    Private Sub BtnSearchDt_Click(sender As Object, e As EventArgs) Handles BtnSearchDt.Click
        Call CleanUserForm(TxtUsername.Text)

        Dim vSql = "SELECT [username],[password],[name],[status],[type] FROM User WHERE [username]=:username"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add(":username", OleDbType.VarChar).Value = TxtUsername.Text

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(command)
        da.Fill(dt)
        connection.Close()

        If dt.Rows.Count < 0 Then
            MessageBox.Show("User not found.")
            Return
        End If

        TxtUsername.Text = dt.Rows(0)("username").ToString
        TxtPassword.Text = dt.Rows(0)("password").ToString
        TxtPasswordConfirm.Text = TxtPassword.Text
        TxtName.Text = dt.Rows(0)("name").ToString
        CmbUserStatus.SelectedValue = dt.Rows(0)("status")
        CmbUserType.SelectedValue = dt.Rows(0)("type")
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim vSql = "DELETE FROM User WHERE [username]=:username"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add(":username", OleDbType.VarChar).Value = TxtUsername.Text

        Dim result = command.ExecuteNonQuery()

        If result <= 0 Then
            MessageBox.Show("User not fount.")
        Else
            MessageBox.Show($"User {TxtUsername.Text} has been deleted.")
            Call CleanUserForm()
        End If

        connection.Close()
    End Sub

    Private Sub CleanUserForm(Optional username As String = "")
        TxtUsername.Text = username
        TxtPassword.Text = ""
        TxtPasswordConfirm.Text = ""
        TxtName.Text = ""
        CmbUserStatus.SelectedIndex = -1
        CmbUserType.SelectedIndex = -1
    End Sub

    Private Sub PasswordValidation(sender As Object, e As EventArgs) Handles TxtPassword.KeyUp, TxtPasswordConfirm.KeyUp
        If TxtPassword.Text <> TxtPasswordConfirm.Text Then
            BtnInsert.Enabled = False
        Else
            BtnInsert.Enabled = True
        End If
    End Sub
End Class
