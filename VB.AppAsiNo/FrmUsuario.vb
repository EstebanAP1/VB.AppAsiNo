Public Class FrmUsuario
    Private ConnectionString As String

    Sub New()
        InitializeComponent()

        ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=bdusuarios.accdb"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadComboUserStatus()
        Call LoadComboUserType()
    End Sub

    Private Sub LoadComboUserStatus()
        Dim vSql = "SELECT [Id], [Nombre], FROM UserStatus"
        Dim connection As New OleDb.OleDbConnection(ConnectionString)
        connection.Open()

        Dim command As New OleDb.OleDbCommand(vSql, connection)

        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(command)

        da.Fill(dt)
        connection.Close()

        CmbUserStatus.DataSource = dt
        CmbUserStatus.DisplayMember = "Nombre"
        CmbUserStatus.ValueMember = "Id"
    End Sub

    Private Sub LoadComboUserType()
        Dim vSql = "SELECT [Id], [Nombre], FROM UserType"
        Dim connection As New OleDb.OleDbConnection(ConnectionString)

        Dim command As New OleDb.OleDbCommand(vSql, connection)

        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(command)

        da.Fill(dt)
        connection.Close()

        CmbUserType.DataSource = dt
        CmbUserType.DisplayMember = "Nombre"
        CmbUserType.ValueMember = "Id"
    End Sub

End Class