<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim EmployedLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.exitBtn = New FontAwesome.Sharp.IconButton()
        Me.staffBtn = New FontAwesome.Sharp.IconButton()
        Me.childBtn = New FontAwesome.Sharp.IconButton()
        Me.homeBtn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._St_Paul_Children_s_HomeDataSet = New ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSet()
        Me.EmployedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DobDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.uploadBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StaffTableAdapter = New ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager()
        Me.StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DobLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        EmployedLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogin.SuspendLayout()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(42, 118)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 42
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(42, 174)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 44
        NameLabel.Text = "Name:"
        '
        'DobLabel
        '
        DobLabel.AutoSize = True
        DobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DobLabel.Location = New System.Drawing.Point(42, 218)
        DobLabel.Name = "DobLabel"
        DobLabel.Size = New System.Drawing.Size(47, 20)
        DobLabel.TabIndex = 46
        DobLabel.Text = "Dob:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(42, 270)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(74, 20)
        GenderLabel.TabIndex = 48
        GenderLabel.Text = "Gender:"
        '
        'EmployedLabel
        '
        EmployedLabel.AutoSize = True
        EmployedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployedLabel.Location = New System.Drawing.Point(454, 118)
        EmployedLabel.Name = "EmployedLabel"
        EmployedLabel.Size = New System.Drawing.Size(92, 20)
        EmployedLabel.TabIndex = 58
        EmployedLabel.Text = "Employed:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(454, 167)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(58, 20)
        EmailLabel.TabIndex = 60
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(454, 218)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(80, 20)
        AddressLabel.TabIndex = 62
        AddressLabel.Text = "Address:"
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
        Me.PanelMenu.Size = New System.Drawing.Size(220, 777)
        Me.PanelMenu.TabIndex = 7
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
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.White
        Me.PanelLogin.Controls.Add(Me.StaffDataGridView)
        Me.PanelLogin.Controls.Add(EmployedLabel)
        Me.PanelLogin.Controls.Add(Me.EmployedDateTimePicker)
        Me.PanelLogin.Controls.Add(EmailLabel)
        Me.PanelLogin.Controls.Add(Me.EmailTextBox)
        Me.PanelLogin.Controls.Add(AddressLabel)
        Me.PanelLogin.Controls.Add(Me.AddressTextBox)
        Me.PanelLogin.Controls.Add(IDLabel)
        Me.PanelLogin.Controls.Add(Me.IDTextBox)
        Me.PanelLogin.Controls.Add(NameLabel)
        Me.PanelLogin.Controls.Add(Me.NameTextBox)
        Me.PanelLogin.Controls.Add(DobLabel)
        Me.PanelLogin.Controls.Add(Me.DobDateTimePicker)
        Me.PanelLogin.Controls.Add(GenderLabel)
        Me.PanelLogin.Controls.Add(Me.GenderTextBox)
        Me.PanelLogin.Controls.Add(Me.Button1)
        Me.PanelLogin.Controls.Add(Me.TextBox1)
        Me.PanelLogin.Controls.Add(Me.deleteBtn)
        Me.PanelLogin.Controls.Add(Me.saveBtn)
        Me.PanelLogin.Controls.Add(Me.uploadBtn)
        Me.PanelLogin.Controls.Add(Me.PictureBox2)
        Me.PanelLogin.Controls.Add(Me.Panel1)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelLogin.Location = New System.Drawing.Point(220, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(1007, 777)
        Me.PanelLogin.TabIndex = 8
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AutoGenerateColumns = False
        Me.StaffDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StaffDataGridView.DataSource = Me.StaffBindingSource
        Me.StaffDataGridView.Location = New System.Drawing.Point(46, 462)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.Size = New System.Drawing.Size(929, 220)
        Me.StaffDataGridView.TabIndex = 63
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
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Employed"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Employed"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me._St_Paul_Children_s_HomeDataSet
        '
        '_St_Paul_Children_s_HomeDataSet
        '
        Me._St_Paul_Children_s_HomeDataSet.DataSetName = "_St_Paul_Children_s_HomeDataSet"
        Me._St_Paul_Children_s_HomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployedDateTimePicker
        '
        Me.EmployedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Employed", True))
        Me.EmployedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployedDateTimePicker.Location = New System.Drawing.Point(563, 116)
        Me.EmployedDateTimePicker.Name = "EmployedDateTimePicker"
        Me.EmployedDateTimePicker.Size = New System.Drawing.Size(228, 22)
        Me.EmployedDateTimePicker.TabIndex = 59
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(563, 164)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(228, 31)
        Me.EmailTextBox.TabIndex = 61
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(563, 215)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(228, 31)
        Me.AddressTextBox.TabIndex = 63
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(138, 118)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(228, 31)
        Me.IDTextBox.TabIndex = 43
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(138, 171)
        Me.NameTextBox.Multiline = True
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(228, 31)
        Me.NameTextBox.TabIndex = 45
        '
        'DobDateTimePicker
        '
        Me.DobDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Dob", True))
        Me.DobDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DobDateTimePicker.Location = New System.Drawing.Point(138, 220)
        Me.DobDateTimePicker.Name = "DobDateTimePicker"
        Me.DobDateTimePicker.Size = New System.Drawing.Size(228, 22)
        Me.DobDateTimePicker.TabIndex = 47
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(138, 267)
        Me.GenderTextBox.Multiline = True
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(228, 31)
        Me.GenderTextBox.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(771, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 31)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(546, 334)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 31)
        Me.TextBox1.TabIndex = 41
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Red
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Location = New System.Drawing.Point(348, 334)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(113, 31)
        Me.deleteBtn.TabIndex = 40
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.Lime
        Me.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Location = New System.Drawing.Point(119, 334)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(113, 31)
        Me.saveBtn.TabIndex = 38
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'uploadBtn
        '
        Me.uploadBtn.BackColor = System.Drawing.Color.Gold
        Me.uploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.uploadBtn.Location = New System.Drawing.Point(852, 254)
        Me.uploadBtn.Name = "uploadBtn"
        Me.uploadBtn.Size = New System.Drawing.Size(113, 31)
        Me.uploadBtn.TabIndex = 22
        Me.uploadBtn.Text = "Upload Image"
        Me.uploadBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffBindingSource, "Headshot", True))
        Me.PictureBox2.Location = New System.Drawing.Point(826, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(161, 124)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1007, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label3.Location = New System.Drawing.Point(350, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Staff Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChildrenTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = ST_Paul_Children_s_Home._St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(220, 0)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(1007, 25)
        Me.StaffBindingNavigator.TabIndex = 9
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
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
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 777)
        Me.Controls.Add(Me.StaffBindingNavigator)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._St_Paul_Children_s_HomeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents exitBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents staffBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents childBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents homeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents uploadBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents deleteBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents _St_Paul_Children_s_HomeDataSet As _St_Paul_Children_s_HomeDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As _St_Paul_Children_s_HomeDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As _St_Paul_Children_s_HomeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents EmployedDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DobDateTimePicker As DateTimePicker
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
