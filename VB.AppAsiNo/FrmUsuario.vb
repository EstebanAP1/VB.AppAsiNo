Imports System.Data.OleDb
Public Class FrmUsuario
    Private ConnectionString As String

    Sub New()
        InitializeComponent()

        Dim dataSource = "MJ04EXV5\SQLEXPRESS"
        Dim database = "VB_Users"
        Dim user = "esteban"
        Dim password = "1234"
        ConnectionString = $"Provider=MSOLEDBSQL;Data Source={dataSource};Initial Catalog={database};User Id={user};Password={password}"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo("SELECT [id],[value] FROM UserType", CmbUserStatus)
        LoadCombo("SELECT [id],[value] FROM UserStatus", CmbUserType)
    End Sub

    Private Sub LoadCombo(vSql, cmb)
        Try
            Using connection As New OleDbConnection(ConnectionString)
                connection.Open()

                Dim command As New OleDbCommand(vSql, connection)

                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter(command)

                da.Fill(dt)
                connection.Close()

                cmb.DataSource = dt
                cmb.DisplayMember = "value"
                cmb.ValueMember = "id"
                cmb.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show($"Unknown error: {ex.Message}")
        End Try
    End Sub

    Private Function ExecuteNonQuery(vSql As String, parameters As Dictionary(Of String, Object))
        Try
            Using connection As New OleDbConnection(ConnectionString)
                connection.Open()

                Dim command As New OleDbCommand(vSql, connection)

                For Each parameter In parameters
                    command.Parameters.Add(parameter.Key, OleDbType.VarChar).Value = parameter.Value
                Next

                Dim result = command.ExecuteNonQuery()
                connection.Close()

                Return result
            End Using
        Catch ex As OleDbException
            If ex.ErrorCode = -2147467259 Then
                MessageBox.Show($"User {TxtUsername.Text} already exists.")
            End If
            MessageBox.Show($"SQL error: {ex.Message}", ex.ErrorCode.ToString())
        Catch ex As Exception
            MessageBox.Show($"Unknown error: {ex.Message}")
        End Try

        Return Nothing
    End Function

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        If Not PasswordValidation() Then Return

        Dim vSql = "INSERT INTO User([username],[password],[name],[status],[type])
                    VALUES (@username,@password,@name,@status,@type)"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", TxtUsername.Text},
            {"@password", TxtPassword.Text},
            {"@name", TxtName.Text},
            {"@status", CmbUserStatus.SelectedValue},
            {"@type", CmbUserType.SelectedValue}
        }

        If ExecuteNonQuery(vSql, parameters) Then MessageBox.Show($"User {TxtUsername.Text} has been created.")
        CleanUserForm()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim vSql = "UPDATE Usuario SET [password]=@password,[name]=@name,[status]=@status,[type]=@type WHERE [username]=@username"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", TxtUsername.Text},
            {"@password", TxtPassword.Text},
            {"@name", TxtName.Text},
            {"@status", CmbUserStatus.SelectedValue},
            {"@type", CmbUserType.SelectedValue}
        }

        Dim result = ExecuteNonQuery(vSql, parameters)

        If result <= 0 Then
            MessageBox.Show("User not found.")
        Else
            MessageBox.Show($"User {TxtUsername.Text} has been updated.")
        End If
    End Sub

    Private Sub BtnSearchDr_Click(sender As Object, e As EventArgs) Handles BtnSearchDr.Click
        Call CleanUserForm(TxtUsername.Text)

        Dim vSql = "SELECT [username],[password],[name],[status],[type] FROM User WHERE [username]=@username"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add("@username", OleDbType.VarChar).Value = TxtUsername.Text
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

        Dim vSql = "SELECT [username],[password],[name],[status],[type] FROM User WHERE [username]=@username"
        Dim connection As New OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDbCommand(vSql, connection)
        command.Parameters.Add("@username", OleDbType.VarChar).Value = TxtUsername.Text

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(command)
        da.Fill(dt)
        connection.Close()

        If dt.Rows.Count = 0 Then
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
        Dim vSql = "DELETE FROM User WHERE [username]=@username"
        Dim connection As New OleDbConnection(ConnectionString)

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@username", TxtUsername.Text}
        }

        Dim result = ExecuteNonQuery(vSql, parameters)

        If result <= 0 Then
            MessageBox.Show("User not found.")
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

    Private Function PasswordValidation() As Boolean
        If TxtPassword.Text <> TxtPasswordConfirm.Text Then
            MessageBox.Show("Las contraseñas no coinciden.")
            Return False
        End If

        If TxtPassword.Text.Length < 8 Then
            MessageBox.Show("La contraseña debe tener al menos 8 caracteres.")
            Return False
        End If

        If Not TxtPassword.Text.Any(Function(c) Char.IsUpper(c)) Then
            MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.")
            Return False
        End If

        If Not TxtPassword.Text.Any(Function(c) Char.IsLower(c)) Then
            MessageBox.Show("La contraseña debe contener al menos una letra minúscula.")
            Return False
        End If

        If Not TxtPassword.Text.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("La contraseña debe contener al menos un dígito.")
            Return False
        End If

        Return True
    End Function

    Private Sub PasswordKeyUpValidation(sender As Object, e As EventArgs) Handles TxtPassword.KeyUp, TxtPasswordConfirm.KeyUp
        If TxtPassword.Text <> TxtPasswordConfirm.Text Then
            BtnInsert.Enabled = False
        Else
            BtnInsert.Enabled = True
        End If
    End Sub
End Class
