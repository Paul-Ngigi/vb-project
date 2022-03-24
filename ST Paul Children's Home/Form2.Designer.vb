<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DobLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim JoinedLabel As System.Windows.Forms.Label
        Dim RoomLabel As System.Windows.Forms.Label
        Dim SchoolLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ChildrenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._St_Paul_Children_s_HomeDataSet = New ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSet()
        Me.RoomTextBox = New System.Windows.Forms.TextBox()
        Me.SchoolTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ChildrenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.childImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.exitBtn = New FontAwesome.Sharp.IconButton()
        Me.staffBtn = New FontAwesome.Sharp.IconButton()
        Me.childBtn = New FontAwesome.Sharp.IconButton()
        Me.homeBtn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ChildrenTableAdapter = New ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.ChildrenTableAdapter()
        Me.TableAdapterManager = New ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager()
        Me.ChildrenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChildrenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        JoinedLabel = New System.Windows.Forms.Label()
        RoomLabel = New System.Windows.Forms.Label()
        SchoolLabel = New System.Windows.Forms.Label()
        Me.PanelLogin.SuspendLayout()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChildrenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ChildrenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChildrenBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(49, 171)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 39
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(49, 215)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 41
        NameLabel.Text = "Name:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DobLabel.Location = New System.Drawing.Point(49, 265)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(47, 20)
        DobLabel.TabIndex = 43
        DobLabel.Text = "Dob:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(49, 314)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(74, 20)
        GenderLabel.TabIndex = 45
        GenderLabel.Text = "Gender:"
        '
        'JoinedLabel
        '
        JoinedLabel.AutoSize = True
        JoinedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JoinedLabel.Location = New System.Drawing.Point(466, 177)
        JoinedLabel.Name = "JoinedLabel"
        JoinedLabel.Size = New System.Drawing.Size(67, 20)
        JoinedLabel.TabIndex = 53
        JoinedLabel.Text = "Joined:"
        '
        'RoomLabel
        '
        RoomLabel.AutoSize = True
        RoomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoomLabel.Location = New System.Drawing.Point(466, 216)
        RoomLabel.Name = "RoomLabel"
        RoomLabel.Size = New System.Drawing.Size(61, 20)
        RoomLabel.TabIndex = 55
        RoomLabel.Text = "Room:"
        '
        'SchoolLabel
        '
        SchoolLabel.AutoSize = True
        SchoolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchoolLabel.Location = New System.Drawing.Point(466, 265)
        SchoolLabel.Name = "SchoolLabel"
        SchoolLabel.Size = New System.Drawing.Size(69, 20)
        SchoolLabel.TabIndex = 57
        SchoolLabel.Text = "School:"
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.White
        Me.PanelLogin.Controls.Add(Me.searchBtn)
        Me.PanelLogin.Controls.Add(Me.searchTxt)
        Me.PanelLogin.Controls.Add(JoinedLabel)
        Me.PanelLogin.Controls.Add(Me.JoinedDateTimePicker)
        Me.PanelLogin.Controls.Add(RoomLabel)
        Me.PanelLogin.Controls.Add(Me.RoomTextBox)
        Me.PanelLogin.Controls.Add(SchoolLabel)
        Me.PanelLogin.Controls.Add(Me.SchoolTextBox)
        Me.PanelLogin.Controls.Add(IDLabel)
        Me.PanelLogin.Controls.Add(Me.IDTextBox)
        Me.PanelLogin.Controls.Add(NameLabel)
        Me.PanelLogin.Controls.Add(Me.NameTextBox)
        Me.PanelLogin.Controls.Add(DobLabel)
        Me.PanelLogin.Controls.Add(Me.DobDateTimePicker)
        Me.PanelLogin.Controls.Add(GenderLabel)
        Me.PanelLogin.Controls.Add(Me.GenderTextBox)
        Me.PanelLogin.Controls.Add(Me.ChildrenDataGridView)
        Me.PanelLogin.Controls.Add(Me.deleteBtn)
        Me.PanelLogin.Controls.Add(Me.saveBtn)
        Me.PanelLogin.Controls.Add(Me.uploadBtn)
        Me.PanelLogin.Controls.Add(Me.childImage)
        Me.PanelLogin.Controls.Add(Me.Panel1)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogin.Location = New System.Drawing.Point(220, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(999, 821)
        Me.PanelLogin.TabIndex = 7
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.Lime
        Me.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.Location = New System.Drawing.Point(818, 407)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(113, 31)
        Me.searchBtn.TabIndex = 60
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'searchTxt
        '
        Me.searchTxt.Location = New System.Drawing.Point(593, 407)
        Me.searchTxt.Multiline = True
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(228, 31)
        Me.searchTxt.TabIndex = 59
        '
        'JoinedDateTimePicker
        '
        Me.JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChildrenBindingSource, "Joined", True))
        Me.JoinedDateTimePicker.Location = New System.Drawing.Point(550, 177)
        Me.JoinedDateTimePicker.Name = "JoinedDateTimePicker"
        Me.JoinedDateTimePicker.Size = New System.Drawing.Size(228, 20)
        Me.JoinedDateTimePicker.TabIndex = 54
        '
        'ChildrenBindingSource
        '
        Me.ChildrenBindingSource.DataMember = "Children"
        Me.ChildrenBindingSource.DataSource = Me._St_Paul_Children_s_HomeDataSet
        '
        '_St_Paul_Children_s_HomeDataSet
        '
        Me._St_Paul_Children_s_HomeDataSet.DataSetName = "_St_Paul_Children_s_HomeDataSet"
        Me._St_Paul_Children_s_HomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTextBox
        '
        Me.RoomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Room", True))
        Me.RoomTextBox.Location = New System.Drawing.Point(550, 216)
        Me.RoomTextBox.Multiline = True
        Me.RoomTextBox.Name = "RoomTextBox"
        Me.RoomTextBox.Size = New System.Drawing.Size(228, 31)
        Me.RoomTextBox.TabIndex = 56
        '
        'SchoolTextBox
        '
        Me.SchoolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "School", True))
        Me.SchoolTextBox.Location = New System.Drawing.Point(550, 262)
        Me.SchoolTextBox.Multiline = True
        Me.SchoolTextBox.Name = "SchoolTextBox"
        Me.SchoolTextBox.Size = New System.Drawing.Size(228, 31)
        Me.SchoolTextBox.TabIndex = 58
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(147, 162)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(228, 31)
        Me.IDTextBox.TabIndex = 40
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(147, 212)
        Me.NameTextBox.Multiline = True
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(228, 31)
        Me.NameTextBox.TabIndex = 42
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChildrenBindingSource, "Dob", True))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(147, 265)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(228, 20)
        Me.DobDateTimePicker.TabIndex = 44
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildrenBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(147, 311)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(228, 31)
        Me.GenderTextBox.TabIndex = 46
        '
        'ChildrenDataGridView
        '
        Me.ChildrenDataGridView.AutoGenerateColumns = False
        Me.ChildrenDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ChildrenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChildrenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChildrenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ChildrenDataGridView.DataSource = Me.ChildrenBindingSource
        Me.ChildrenDataGridView.Location = New System.Drawing.Point(22, 566)
        Me.ChildrenDataGridView.Name = "ChildrenDataGridView"
        Me.ChildrenDataGridView.Size = New System.Drawing.Size(957, 220)
        Me.ChildrenDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dob"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dob"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Joined"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Joined"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Room"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "School"
        Me.DataGridViewTextBoxColumn7.HeaderText = "School"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Red
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Location = New System.Drawing.Point(334, 407)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(113, 31)
        Me.deleteBtn.TabIndex = 25
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.Lime
        Me.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Location = New System.Drawing.Point(73, 407)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(113, 31)
        Me.saveBtn.TabIndex = 23
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'uploadBtn
        '
        Me.uploadBtn.BackColor = System.Drawing.Color.Gold
        Me.uploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadBtn.Location = New System.Drawing.Point(844, 305)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(113, 31)
        Me.uploadBtn.TabIndex = 22
        Me.uploadBtn.Text = "Upload Image"
        Me.uploadBtn.UseVisualStyleBackColor = False
        '
        'childImage
        '
        Me.childImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.childImage.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ChildrenBindingSource, "Headshot", True))
        Me.childImage.Location = New System.Drawing.Point(818, 169)
        Me.childImage.Name = "childImage"
        Me.childImage.Size = New System.Drawing.Size(161, 124)
        Me.childImage.TabIndex = 21
        Me.childImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(999, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(350, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Children Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SeaShell
        Me.PanelMenu.Controls.Add(Me.exitBtn)
        Me.PanelMenu.Controls.Add(Me.staffBtn)
        Me.PanelMenu.Controls.Add(Me.childBtn)
        Me.PanelMenu.Controls.Add(Me.homeBtn)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 821)
        Me.PanelMenu.TabIndex = 6
        '
        'exitBtn
        '
        Me.exitBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.exitBtn.FlatAppearance.BorderSize = 0
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitBtn.ForeColor = System.Drawing.Color.Red
        Me.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Eject
        Me.exitBtn.IconColor = System.Drawing.Color.Red
        Me.exitBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.exitBtn.Location = New System.Drawing.Point(0, 334)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.exitBtn.Size = New System.Drawing.Size(220, 49)
        Me.exitBtn.TabIndex = 8
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'staffBtn
        '
        Me.staffBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.staffBtn.FlatAppearance.BorderSize = 0
        Me.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.staffBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffBtn.ForeColor = System.Drawing.Color.Gold
        Me.staffBtn.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.staffBtn.IconColor = System.Drawing.Color.Gold
        Me.staffBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.staffBtn.Location = New System.Drawing.Point(0, 285)
        Me.staffBtn.Name = "staffBtn"
        Me.staffBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.staffBtn.Size = New System.Drawing.Size(220, 49)
        Me.staffBtn.TabIndex = 7
        Me.staffBtn.Text = "Staff"
        Me.staffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.staffBtn.UseVisualStyleBackColor = True
        '
        'childBtn
        '
        Me.childBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.childBtn.FlatAppearance.BorderSize = 0
        Me.childBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.childBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.childBtn.ForeColor = System.Drawing.Color.Gold
        Me.childBtn.IconChar = FontAwesome.Sharp.IconChar.Child
        Me.childBtn.IconColor = System.Drawing.Color.Gold
        Me.childBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.childBtn.Location = New System.Drawing.Point(0, 236)
        Me.childBtn.Name = "childBtn"
        Me.childBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.childBtn.Size = New System.Drawing.Size(220, 49)
        Me.childBtn.TabIndex = 6
        Me.childBtn.Text = "Children"
        Me.childBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.childBtn.UseVisualStyleBackColor = True
        '
        'homeBtn
        '
        Me.homeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.homeBtn.FlatAppearance.BorderSize = 0
        Me.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeBtn.ForeColor = System.Drawing.Color.Gold
        Me.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.homeBtn.IconColor = System.Drawing.Color.Gold
        Me.homeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.homeBtn.Location = New System.Drawing.Point(0, 187)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.homeBtn.Size = New System.Drawing.Size(220, 49)
        Me.homeBtn.TabIndex = 5
        Me.homeBtn.Text = "Home"
        Me.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.homeBtn.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 187)
        Me.PanelLogo.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ChildrenTableAdapter
        '
        Me.ChildrenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChildrenTableAdapter = Me.ChildrenTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ChildrenBindingNavigator
        '
        Me.ChildrenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ChildrenBindingNavigator.BindingSource = Me.ChildrenBindingSource
        Me.ChildrenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ChildrenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ChildrenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ChildrenBindingNavigatorSaveItem})
        Me.ChildrenBindingNavigator.Location = New System.Drawing.Point(220, 0)
        Me.ChildrenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ChildrenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ChildrenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ChildrenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ChildrenBindingNavigator.Name = "ChildrenBindingNavigator"
        Me.ChildrenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ChildrenBindingNavigator.Size = New System.Drawing.Size(999, 25)
        Me.ChildrenBindingNavigator.TabIndex = 8
        Me.ChildrenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ChildrenBindingNavigatorSaveItem
        '
        Me.ChildrenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChildrenBindingNavigatorSaveItem.Image = CType(resources.GetObject("ChildrenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ChildrenBindingNavigatorSaveItem.Name = "ChildrenBindingNavigatorSaveItem"
        Me.ChildrenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ChildrenBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 821)
        Me.Controls.Add(Me.ChildrenBindingNavigator)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Children"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChildrenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ChildrenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChildrenBindingNavigator.ResumeLayout(False)
        Me.ChildrenBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents exitBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents staffBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents childBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents homeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents deleteBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents uploadBtn As Button
    Friend WithEvents childImage As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents _St_Paul_Children_s_HomeDataSet As _St_Paul_Children_s_HomeDataSet
    Friend WithEvents ChildrenBindingSource As BindingSource
    Friend WithEvents ChildrenTableAdapter As _St_Paul_Children_s_HomeDataSetTableAdapters.ChildrenTableAdapter
    Friend WithEvents TableAdapterManager As _St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChildrenBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ChildrenBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ChildrenDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents JoinedDateTimePicker As DateTimePicker
    Friend WithEvents RoomTextBox As TextBox
    Friend WithEvents SchoolTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DobDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents searchTxt As TextBox
End Class
