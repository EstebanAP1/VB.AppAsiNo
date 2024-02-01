<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TblContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblPasswordConfirm = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblUserStatus = New System.Windows.Forms.Label()
        Me.LblUserType = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.CmbUserStatus = New System.Windows.Forms.ComboBox()
        Me.CmbUserType = New System.Windows.Forms.ComboBox()
        Me.TblButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnSearchDr = New System.Windows.Forms.Button()
        Me.BtnSearchDt = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TblContainer.SuspendLayout()
        Me.TblButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'TblContainer
        '
        Me.TblContainer.ColumnCount = 2
        Me.TblContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblContainer.Controls.Add(Me.LblUsername, 0, 0)
        Me.TblContainer.Controls.Add(Me.LblPassword, 0, 1)
        Me.TblContainer.Controls.Add(Me.LblPasswordConfirm, 0, 2)
        Me.TblContainer.Controls.Add(Me.LblName, 0, 3)
        Me.TblContainer.Controls.Add(Me.LblUserStatus, 0, 4)
        Me.TblContainer.Controls.Add(Me.LblUserType, 0, 5)
        Me.TblContainer.Controls.Add(Me.TxtUsername, 1, 0)
        Me.TblContainer.Controls.Add(Me.TxtPassword, 1, 1)
        Me.TblContainer.Controls.Add(Me.TxtPasswordConfirm, 1, 2)
        Me.TblContainer.Controls.Add(Me.TxtName, 1, 3)
        Me.TblContainer.Controls.Add(Me.CmbUserStatus, 1, 4)
        Me.TblContainer.Controls.Add(Me.CmbUserType, 1, 5)
        Me.TblContainer.Location = New System.Drawing.Point(124, 25)
        Me.TblContainer.Name = "TblContainer"
        Me.TblContainer.RowCount = 6
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TblContainer.Size = New System.Drawing.Size(481, 203)
        Me.TblContainer.TabIndex = 0
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(3, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(55, 13)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(3, 33)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Password"
        '
        'LblPasswordConfirm
        '
        Me.LblPasswordConfirm.AutoSize = True
        Me.LblPasswordConfirm.Location = New System.Drawing.Point(3, 66)
        Me.LblPasswordConfirm.Name = "LblPasswordConfirm"
        Me.LblPasswordConfirm.Size = New System.Drawing.Size(91, 13)
        Me.LblPasswordConfirm.TabIndex = 2
        Me.LblPasswordConfirm.Text = "Confirm Password"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(3, 99)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(35, 13)
        Me.LblName.TabIndex = 3
        Me.LblName.Text = "Name"
        '
        'LblUserStatus
        '
        Me.LblUserStatus.AutoSize = True
        Me.LblUserStatus.Location = New System.Drawing.Point(3, 132)
        Me.LblUserStatus.Name = "LblUserStatus"
        Me.LblUserStatus.Size = New System.Drawing.Size(62, 13)
        Me.LblUserStatus.TabIndex = 4
        Me.LblUserStatus.Text = "User Status"
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.Location = New System.Drawing.Point(3, 165)
        Me.LblUserType.Name = "LblUserType"
        Me.LblUserType.Size = New System.Drawing.Size(56, 13)
        Me.LblUserType.TabIndex = 5
        Me.LblUserType.Text = "User Type"
        '
        'TxtUsername
        '
        Me.TxtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtUsername.Location = New System.Drawing.Point(243, 3)
        Me.TxtUsername.MaxLength = 30
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(121, 20)
        Me.TxtUsername.TabIndex = 7
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(243, 36)
        Me.TxtPassword.MaxLength = 30
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(121, 20)
        Me.TxtPassword.TabIndex = 8
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(243, 69)
        Me.TxtPasswordConfirm.MaxLength = 30
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(121, 20)
        Me.TxtPasswordConfirm.TabIndex = 9
        Me.TxtPasswordConfirm.UseSystemPasswordChar = True
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.Location = New System.Drawing.Point(243, 102)
        Me.TxtName.MaxLength = 100
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(121, 20)
        Me.TxtName.TabIndex = 10
        '
        'CmbUserStatus
        '
        Me.CmbUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUserStatus.FormattingEnabled = True
        Me.CmbUserStatus.Location = New System.Drawing.Point(243, 135)
        Me.CmbUserStatus.Name = "CmbUserStatus"
        Me.CmbUserStatus.Size = New System.Drawing.Size(121, 21)
        Me.CmbUserStatus.TabIndex = 11
        '
        'CmbUserType
        '
        Me.CmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUserType.FormattingEnabled = True
        Me.CmbUserType.Location = New System.Drawing.Point(243, 168)
        Me.CmbUserType.Name = "CmbUserType"
        Me.CmbUserType.Size = New System.Drawing.Size(121, 21)
        Me.CmbUserType.TabIndex = 12
        '
        'TblButtons
        '
        Me.TblButtons.ColumnCount = 6
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TblButtons.Controls.Add(Me.BtnInsert, 0, 0)
        Me.TblButtons.Controls.Add(Me.BtnDelete, 1, 0)
        Me.TblButtons.Controls.Add(Me.BtnUpdate, 2, 0)
        Me.TblButtons.Controls.Add(Me.BtnSearchDr, 3, 0)
        Me.TblButtons.Controls.Add(Me.BtnSearchDt, 4, 0)
        Me.TblButtons.Controls.Add(Me.BtnClose, 5, 0)
        Me.TblButtons.Location = New System.Drawing.Point(46, 260)
        Me.TblButtons.Name = "TblButtons"
        Me.TblButtons.RowCount = 1
        Me.TblButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblButtons.Size = New System.Drawing.Size(639, 37)
        Me.TblButtons.TabIndex = 1
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(3, 3)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(109, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(215, 3)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 2
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSearchDr
        '
        Me.BtnSearchDr.Location = New System.Drawing.Point(321, 3)
        Me.BtnSearchDr.Name = "BtnSearchDr"
        Me.BtnSearchDr.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchDr.TabIndex = 3
        Me.BtnSearchDr.Text = "Search DR"
        Me.BtnSearchDr.UseVisualStyleBackColor = True
        '
        'BtnSearchDt
        '
        Me.BtnSearchDt.Location = New System.Drawing.Point(427, 3)
        Me.BtnSearchDt.Name = "BtnSearchDt"
        Me.BtnSearchDt.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearchDt.TabIndex = 4
        Me.BtnSearchDt.Text = "Search DT"
        Me.BtnSearchDt.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(533, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 325)
        Me.Controls.Add(Me.TblButtons)
        Me.Controls.Add(Me.TblContainer)
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
        Me.TblContainer.ResumeLayout(False)
        Me.TblContainer.PerformLayout()
        Me.TblButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TblContainer As TableLayoutPanel
    Friend WithEvents TblButtons As TableLayoutPanel
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblPasswordConfirm As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblUserStatus As Label
    Friend WithEvents LblUserType As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtPasswordConfirm As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents CmbUserStatus As ComboBox
    Friend WithEvents CmbUserType As ComboBox
    Friend WithEvents BtnInsert As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnSearchDr As Button
    Friend WithEvents BtnSearchDt As Button
    Friend WithEvents BtnClose As Button
End Class
