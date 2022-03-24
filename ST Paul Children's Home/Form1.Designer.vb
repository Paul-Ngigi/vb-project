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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pssTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usrnameTxt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.exitBtn = New FontAwesome.Sharp.IconButton()
        Me.staffBtn = New FontAwesome.Sharp.IconButton()
        Me.childBtn = New FontAwesome.Sharp.IconButton()
        Me.homeBtn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.AuthenticationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AuthenticationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AuthenticationDataGridView = New System.Windows.Forms.DataGridView()
        Me.AuthenticationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.St_Paul_LoginDataSet = New ST_Paul_Children_s_Home.St_Paul_LoginDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AuthenticationTableAdapter = New ST_Paul_Children_s_Home.St_Paul_LoginDataSetTableAdapters.AuthenticationTableAdapter()
        Me.TableAdapterManager = New ST_Paul_Children_s_Home.St_Paul_LoginDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.AuthenticationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AuthenticationBindingNavigator.SuspendLayout()
        CType(Me.AuthenticationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthenticationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.St_Paul_LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelLogin.Controls.Add(Me.AuthenticationDataGridView)
        Me.PanelLogin.Controls.Add(Me.clearBtn)
        Me.PanelLogin.Controls.Add(Me.loginBtn)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.pssTxt)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.usrnameTxt)
        Me.PanelLogin.Controls.Add(Me.Panel2)
        Me.PanelLogin.Controls.Add(Me.Panel1)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogin.Location = New System.Drawing.Point(220, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(876, 596)
        Me.PanelLogin.TabIndex = 5
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.DarkKhaki
        Me.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Location = New System.Drawing.Point(494, 381)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(113, 31)
        Me.clearBtn.TabIndex = 27
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Location = New System.Drawing.Point(259, 381)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(113, 36)
        Me.loginBtn.TabIndex = 6
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'pssTxt
        '
        Me.pssTxt.Location = New System.Drawing.Point(379, 288)
        Me.pssTxt.Multiline = True
        Me.pssTxt.Name = "pssTxt"
        Me.pssTxt.Size = New System.Drawing.Size(228, 31)
        Me.pssTxt.TabIndex = 4
        Me.pssTxt.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'usrnameTxt
        '
        Me.usrnameTxt.Location = New System.Drawing.Point(379, 220)
        Me.usrnameTxt.Multiline = True
        Me.usrnameTxt.Name = "usrnameTxt"
        Me.usrnameTxt.Size = New System.Drawing.Size(228, 31)
        Me.usrnameTxt.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaShell
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 514)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 82)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Staff Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.PanelMenu.Size = New System.Drawing.Size(220, 596)
        Me.PanelMenu.TabIndex = 4
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
        'AuthenticationBindingNavigator
        '
        Me.AuthenticationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AuthenticationBindingNavigator.BindingSource = Me.AuthenticationBindingSource
        Me.AuthenticationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AuthenticationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AuthenticationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AuthenticationBindingNavigatorSaveItem})
        Me.AuthenticationBindingNavigator.Location = New System.Drawing.Point(220, 0)
        Me.AuthenticationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AuthenticationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AuthenticationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AuthenticationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AuthenticationBindingNavigator.Name = "AuthenticationBindingNavigator"
        Me.AuthenticationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AuthenticationBindingNavigator.Size = New System.Drawing.Size(876, 25)
        Me.AuthenticationBindingNavigator.TabIndex = 6
        Me.AuthenticationBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AuthenticationBindingNavigatorSaveItem
        '
        Me.AuthenticationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AuthenticationBindingNavigatorSaveItem.Image = CType(resources.GetObject("AuthenticationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AuthenticationBindingNavigatorSaveItem.Name = "AuthenticationBindingNavigatorSaveItem"
        Me.AuthenticationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AuthenticationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AuthenticationDataGridView
        '
        Me.AuthenticationDataGridView.AutoGenerateColumns = False
        Me.AuthenticationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuthenticationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1})
        Me.AuthenticationDataGridView.DataSource = Me.AuthenticationBindingSource
        Me.AuthenticationDataGridView.Location = New System.Drawing.Point(24, 106)
        Me.AuthenticationDataGridView.Name = "AuthenticationDataGridView"
        Me.AuthenticationDataGridView.Size = New System.Drawing.Size(300, 81)
        Me.AuthenticationDataGridView.TabIndex = 27
        Me.AuthenticationDataGridView.Visible = False
        '
        'AuthenticationBindingSource
        '
        Me.AuthenticationBindingSource.DataMember = "Authentication"
        Me.AuthenticationBindingSource.DataSource = Me.St_Paul_LoginDataSet
        '
        'St_Paul_LoginDataSet
        '
        Me.St_Paul_LoginDataSet.DataSetName = "St_Paul_LoginDataSet"
        Me.St_Paul_LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Admin"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Admin"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'AuthenticationTableAdapter
        '
        Me.AuthenticationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthenticationTableAdapter = Me.AuthenticationTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ST_Paul_Children_s_Home.St_Paul_LoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 596)
        Me.Controls.Add(Me.AuthenticationBindingNavigator)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.AuthenticationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AuthenticationBindingNavigator.ResumeLayout(False)
        Me.AuthenticationBindingNavigator.PerformLayout()
        CType(Me.AuthenticationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthenticationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.St_Paul_LoginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents exitBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents staffBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents childBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents homeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pssTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usrnameTxt As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents St_Paul_LoginDataSet As St_Paul_LoginDataSet
    Friend WithEvents AuthenticationBindingSource As BindingSource
    Friend WithEvents AuthenticationTableAdapter As St_Paul_LoginDataSetTableAdapters.AuthenticationTableAdapter
    Friend WithEvents TableAdapterManager As St_Paul_LoginDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuthenticationBindingNavigator As BindingNavigator
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
    Friend WithEvents AuthenticationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AuthenticationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
