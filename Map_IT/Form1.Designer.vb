<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle120 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle121 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle122 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle123 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle124 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle125 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle126 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.serverPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.serverPassword = New System.Windows.Forms.TextBox()
        Me.serverUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mapList = New System.Windows.Forms.DataGridView()
        Me.Map = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Server = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shortcut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersistentBoolean = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.button = New System.Windows.Forms.Button()
        Me.persistent = New System.Windows.Forms.CheckBox()
        Me.shortcutName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.driveLetter = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.iconFilePath = New System.Windows.Forms.Label()
        Me.iconBox = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.mapList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 218)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 15, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(548, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(144, 17)
        Me.ToolStripStatusLabel1.Text = "Developed by: Christian Villablanca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server path :"
        '
        'serverPath
        '
        Me.serverPath.Location = New System.Drawing.Point(104, 16)
        Me.serverPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.serverPath.Name = "serverPath"
        Me.serverPath.Size = New System.Drawing.Size(234, 23)
        Me.serverPath.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Shortcut name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password :"
        '
        'serverPassword
        '
        Me.serverPassword.Location = New System.Drawing.Point(309, 75)
        Me.serverPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.serverPassword.Name = "serverPassword"
        Me.serverPassword.Size = New System.Drawing.Size(116, 23)
        Me.serverPassword.TabIndex = 7
        '
        'serverUsername
        '
        Me.serverUsername.Location = New System.Drawing.Point(104, 75)
        Me.serverUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.serverUsername.Name = "serverUsername"
        Me.serverUsername.Size = New System.Drawing.Size(116, 23)
        Me.serverUsername.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.serverPassword)
        Me.GroupBox2.Controls.Add(Me.button)
        Me.GroupBox2.Controls.Add(Me.persistent)
        Me.GroupBox2.Controls.Add(Me.serverUsername)
        Me.GroupBox2.Controls.Add(Me.shortcutName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.driveLetter)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.serverPath)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(521, 139)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'mapList
        '
        Me.mapList.AllowUserToAddRows = False
        Me.mapList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.mapList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mapList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Map, Me.Server, Me.Drive, Me.Shortcut, Me.Username, Me.Password, Me.PersistentBoolean})
        Me.mapList.Location = New System.Drawing.Point(13, 30)
        Me.mapList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mapList.Name = "mapList"
        Me.mapList.ShowEditingIcon = False
        Me.mapList.Size = New System.Drawing.Size(521, 154)
        Me.mapList.TabIndex = 13
        Me.mapList.Visible = False
        '
        'Map
        '
        Me.Map.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle120.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Map.DefaultCellStyle = DataGridViewCellStyle120
        Me.Map.HeaderText = "Map"
        Me.Map.Name = "Map"
        Me.Map.Width = 57
        '
        'Server
        '
        Me.Server.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle121.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Server.DefaultCellStyle = DataGridViewCellStyle121
        Me.Server.HeaderText = "Server Path"
        Me.Server.Name = "Server"
        Me.Server.Width = 92
        '
        'Drive
        '
        Me.Drive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle122.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Drive.DefaultCellStyle = DataGridViewCellStyle122
        Me.Drive.HeaderText = "Drive Letter"
        Me.Drive.Name = "Drive"
        Me.Drive.Width = 93
        '
        'Shortcut
        '
        Me.Shortcut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle123.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Shortcut.DefaultCellStyle = DataGridViewCellStyle123
        Me.Shortcut.HeaderText = "Shortcut Name"
        Me.Shortcut.Name = "Shortcut"
        Me.Shortcut.Width = 113
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle124.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Username.DefaultCellStyle = DataGridViewCellStyle124
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.Width = 86
        '
        'Password
        '
        Me.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle125.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Password.DefaultCellStyle = DataGridViewCellStyle125
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.Width = 83
        '
        'PersistentBoolean
        '
        Me.PersistentBoolean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle126.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PersistentBoolean.DefaultCellStyle = DataGridViewCellStyle126
        Me.PersistentBoolean.HeaderText = "Persistent"
        Me.PersistentBoolean.Name = "PersistentBoolean"
        Me.PersistentBoolean.Width = 84
        '
        'button
        '
        Me.button.Font = New System.Drawing.Font("Microsoft Tai Le", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.Location = New System.Drawing.Point(188, 107)
        Me.button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(151, 23)
        Me.button.TabIndex = 11
        Me.button.Text = "ADD"
        Me.button.UseVisualStyleBackColor = True
        '
        'persistent
        '
        Me.persistent.AutoSize = True
        Me.persistent.Location = New System.Drawing.Point(347, 49)
        Me.persistent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.persistent.Name = "persistent"
        Me.persistent.Size = New System.Drawing.Size(78, 20)
        Me.persistent.TabIndex = 7
        Me.persistent.Text = "Persistent"
        Me.persistent.UseVisualStyleBackColor = True
        '
        'shortcutName
        '
        Me.shortcutName.Location = New System.Drawing.Point(104, 47)
        Me.shortcutName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.shortcutName.Name = "shortcutName"
        Me.shortcutName.Size = New System.Drawing.Size(234, 23)
        Me.shortcutName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Drive letter :"
        '
        'driveLetter
        '
        Me.driveLetter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.driveLetter.FormattingEnabled = True
        Me.driveLetter.Items.AddRange(New Object() {"A:", "B:", "C:", "D:", "E:", "F:", "G:", "H:", "I:", "J:", "K:", "L:", "M:", "N:", "O:", "P:", "Q:", "R:", "S:", "T:", "U:", "V:", "W:", "X:", "Y:", "Z:"})
        Me.driveLetter.Location = New System.Drawing.Point(442, 16)
        Me.driveLetter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.driveLetter.Name = "driveLetter"
        Me.driveLetter.Size = New System.Drawing.Size(59, 24)
        Me.driveLetter.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(456, 188)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 26)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Create exe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripLabel2.Text = "Bat Converter"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripLabel1.Text = "Mappings"
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.clearButton.Location = New System.Drawing.Point(13, 186)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(76, 23)
        Me.clearButton.TabIndex = 15
        Me.clearButton.Text = "Clear list"
        Me.clearButton.UseVisualStyleBackColor = False
        Me.clearButton.Visible = False
        '
        'iconFilePath
        '
        Me.iconFilePath.AutoSize = True
        Me.iconFilePath.ForeColor = System.Drawing.SystemColors.Highlight
        Me.iconFilePath.Location = New System.Drawing.Point(66, 169)
        Me.iconFilePath.Name = "iconFilePath"
        Me.iconFilePath.Size = New System.Drawing.Size(37, 16)
        Me.iconFilePath.TabIndex = 17
        Me.iconFilePath.Text = "None"
        Me.iconFilePath.Visible = False
        '
        'iconBox
        '
        Me.iconBox.AutoSize = True
        Me.iconBox.Location = New System.Drawing.Point(13, 168)
        Me.iconBox.Name = "iconBox"
        Me.iconBox.Size = New System.Drawing.Size(56, 20)
        Me.iconBox.TabIndex = 19
        Me.iconBox.Text = "Icon :"
        Me.iconBox.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.ToolStripLabel6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(548, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel5.Text = "Bat Converter"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel6.Text = "Mappings"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel3.Text = "ToolStripLabel3"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel4.Text = "ToolStripLabel4"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(132, 17)
        Me.ToolStripStatusLabel2.Text = "Developed by: Christian Villablanca"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(134, 17)
        Me.ToolStripStatusLabel3.Text = "Developed by : Christian Villablanca"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(548, 240)
        Me.Controls.Add(Me.mapList)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.iconBox)
        Me.Controls.Add(Me.iconFilePath)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAP_IT"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.mapList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents serverPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents serverPassword As TextBox
    Friend WithEvents serverUsername As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents driveLetter As ComboBox
    Friend WithEvents shortcutName As TextBox
    Friend WithEvents persistent As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents button As Button
    Friend WithEvents mapList As DataGridView
    Friend WithEvents Map As DataGridViewTextBoxColumn
    Friend WithEvents Server As DataGridViewTextBoxColumn
    Friend WithEvents Drive As DataGridViewTextBoxColumn
    Friend WithEvents Shortcut As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents PersistentBoolean As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents clearButton As Button
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents iconFilePath As Label
    Friend WithEvents iconBox As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripLabel6 As ToolStripLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
End Class
