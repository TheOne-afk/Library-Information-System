<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Dashboard))
        Me.SideNavbar = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Navbar = New System.Windows.Forms.Panel()
        Me.Date_Time_Container = New System.Windows.Forms.Panel()
        Me.Date_Label = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageIndicator = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Container = New System.Windows.Forms.Panel()
        Me.dashboardContainer = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Call_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Publisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Published = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.searchBorrowedBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.HistoryPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.history_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.history_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.history_isbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.history_borrowed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.history_due = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.history_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.view = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SideNavbar.SuspendLayout()
        Me.Navbar.SuspendLayout()
        Me.Date_Time_Container.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Container.SuspendLayout()
        Me.dashboardContainer.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.HistoryPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SideNavbar
        '
        Me.SideNavbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SideNavbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SideNavbar.Controls.Add(Me.Button2)
        Me.SideNavbar.Controls.Add(Me.Button1)
        Me.SideNavbar.Controls.Add(Me.Logout)
        Me.SideNavbar.Controls.Add(Me.Panel5)
        Me.SideNavbar.Controls.Add(Me.Panel2)
        Me.SideNavbar.Controls.Add(Me.PictureBox1)
        Me.SideNavbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideNavbar.Location = New System.Drawing.Point(0, 0)
        Me.SideNavbar.Margin = New System.Windows.Forms.Padding(0)
        Me.SideNavbar.Name = "SideNavbar"
        Me.SideNavbar.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.SideNavbar.Size = New System.Drawing.Size(245, 842)
        Me.SideNavbar.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 778)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(245, 64)
        Me.Panel5.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 64)
        Me.Panel2.TabIndex = 2
        '
        'Navbar
        '
        Me.Navbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Navbar.Controls.Add(Me.Date_Time_Container)
        Me.Navbar.Controls.Add(Me.Panel7)
        Me.Navbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Navbar.Location = New System.Drawing.Point(245, 0)
        Me.Navbar.Name = "Navbar"
        Me.Navbar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Navbar.Size = New System.Drawing.Size(1163, 62)
        Me.Navbar.TabIndex = 2
        '
        'Date_Time_Container
        '
        Me.Date_Time_Container.Controls.Add(Me.Date_Label)
        Me.Date_Time_Container.Controls.Add(Me.Time)
        Me.Date_Time_Container.Dock = System.Windows.Forms.DockStyle.Right
        Me.Date_Time_Container.Location = New System.Drawing.Point(1004, 0)
        Me.Date_Time_Container.Name = "Date_Time_Container"
        Me.Date_Time_Container.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Date_Time_Container.Size = New System.Drawing.Size(149, 62)
        Me.Date_Time_Container.TabIndex = 1
        '
        'Date_Label
        '
        Me.Date_Label.AutoSize = True
        Me.Date_Label.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Date_Label.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Date_Label.Location = New System.Drawing.Point(0, 38)
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(111, 24)
        Me.Date_Label.TabIndex = 1
        Me.Date_Label.Text = "MM/dd/yyy"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Dock = System.Windows.Forms.DockStyle.Top
        Me.Time.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Time.Location = New System.Drawing.Point(0, 10)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(94, 24)
        Me.Time.TabIndex = 0
        Me.Time.Text = "00:00:00"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.pageIndicator)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(10, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel7.Size = New System.Drawing.Size(406, 62)
        Me.Panel7.TabIndex = 0
        '
        'pageIndicator
        '
        Me.pageIndicator.AutoSize = True
        Me.pageIndicator.Dock = System.Windows.Forms.DockStyle.Left
        Me.pageIndicator.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pageIndicator.Location = New System.Drawing.Point(0, 10)
        Me.pageIndicator.Name = "pageIndicator"
        Me.pageIndicator.Size = New System.Drawing.Size(167, 34)
        Me.pageIndicator.TabIndex = 1
        Me.pageIndicator.Text = "Dashboard"
        '
        'Timer1
        '
        '
        'Container
        '
        Me.Container.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Container.Controls.Add(Me.dashboardContainer)
        Me.Container.Controls.Add(Me.HistoryPanel)
        Me.Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Container.Location = New System.Drawing.Point(245, 62)
        Me.Container.Name = "Container"
        Me.Container.Padding = New System.Windows.Forms.Padding(30)
        Me.Container.Size = New System.Drawing.Size(1163, 780)
        Me.Container.TabIndex = 3
        '
        'dashboardContainer
        '
        Me.dashboardContainer.Controls.Add(Me.DataGridView1)
        Me.dashboardContainer.Controls.Add(Me.Panel1)
        Me.dashboardContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardContainer.Location = New System.Drawing.Point(30, 30)
        Me.dashboardContainer.Name = "dashboardContainer"
        Me.dashboardContainer.Size = New System.Drawing.Size(1103, 720)
        Me.dashboardContainer.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.Call_Number, Me.Title, Me.Category, Me.Author, Me.ISBN, Me.Publisher, Me.Published, Me.view})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1103, 644)
        Me.DataGridView1.TabIndex = 5
        '
        'Number
        '
        Me.Number.HeaderText = "#"
        Me.Number.Name = "Number"
        Me.Number.Width = 40
        '
        'Call_Number
        '
        Me.Call_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Call_Number.FillWeight = 177.2151!
        Me.Call_Number.HeaderText = "Call Number"
        Me.Call_Number.Name = "Call_Number"
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Title.FillWeight = 88.9692!
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'Category
        '
        Me.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Category.FillWeight = 88.9692!
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'Author
        '
        Me.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Author.FillWeight = 88.9692!
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        '
        'ISBN
        '
        Me.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ISBN.FillWeight = 88.9692!
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.Name = "ISBN"
        '
        'Publisher
        '
        Me.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Publisher.FillWeight = 88.9692!
        Me.Publisher.HeaderText = "Publisher"
        Me.Publisher.Name = "Publisher"
        '
        'Published
        '
        Me.Published.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Published.FillWeight = 88.9692!
        Me.Published.HeaderText = "Published"
        Me.Published.Name = "Published"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1103, 61)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel16)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel18)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(633, 0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(470, 61)
        Me.FlowLayoutPanel5.TabIndex = 5
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.TextBox1)
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(313, 52)
        Me.Panel16.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Gray
        Me.TextBox1.Location = New System.Drawing.Point(3, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(307, 29)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Search..."
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.searchBorrowedBtn)
        Me.Panel18.Location = New System.Drawing.Point(322, 3)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(144, 47)
        Me.Panel18.TabIndex = 2
        '
        'searchBorrowedBtn
        '
        Me.searchBorrowedBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.searchBorrowedBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchBorrowedBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchBorrowedBtn.FlatAppearance.BorderSize = 2
        Me.searchBorrowedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBorrowedBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowedBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.searchBorrowedBtn.Location = New System.Drawing.Point(0, 0)
        Me.searchBorrowedBtn.Name = "searchBorrowedBtn"
        Me.searchBorrowedBtn.Size = New System.Drawing.Size(144, 47)
        Me.searchBorrowedBtn.TabIndex = 0
        Me.searchBorrowedBtn.Text = "Search"
        Me.searchBorrowedBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 34)
        Me.Label1.TabIndex = 2
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 5
        '
        'HistoryPanel
        '
        Me.HistoryPanel.Controls.Add(Me.DataGridView2)
        Me.HistoryPanel.Controls.Add(Me.Panel3)
        Me.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryPanel.Location = New System.Drawing.Point(30, 30)
        Me.HistoryPanel.Name = "HistoryPanel"
        Me.HistoryPanel.Size = New System.Drawing.Size(1103, 720)
        Me.HistoryPanel.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1103, 82)
        Me.Panel3.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.history_count, Me.history_title, Me.history_isbn, Me.history_borrowed, Me.history_due, Me.history_status})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(0, 82)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(1103, 635)
        Me.DataGridView2.TabIndex = 6
        '
        'history_count
        '
        Me.history_count.HeaderText = "#"
        Me.history_count.Name = "history_count"
        Me.history_count.Width = 40
        '
        'history_title
        '
        Me.history_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.history_title.FillWeight = 88.9692!
        Me.history_title.HeaderText = "Title"
        Me.history_title.Name = "history_title"
        '
        'history_isbn
        '
        Me.history_isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.history_isbn.FillWeight = 88.9692!
        Me.history_isbn.HeaderText = "ISBN"
        Me.history_isbn.Name = "history_isbn"
        '
        'history_borrowed
        '
        Me.history_borrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.history_borrowed.HeaderText = "Borrowed Date"
        Me.history_borrowed.Name = "history_borrowed"
        '
        'history_due
        '
        Me.history_due.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.history_due.HeaderText = "Due Date"
        Me.history_due.Name = "history_due"
        '
        'history_status
        '
        Me.history_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.history_status.HeaderText = "Status"
        Me.history_status.Name = "history_status"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.Library_Information_System.My.Resources.Resources.View_Icon
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 5
        '
        'view
        '
        Me.view.HeaderText = ""
        Me.view.Image = Global.Library_Information_System.My.Resources.Resources.View_Icon
        Me.view.Name = "view"
        Me.view.Width = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button2.Image = Global.Library_Information_System.My.Resources.Resources.History_Icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button2.Size = New System.Drawing.Size(245, 52)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "History"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button1.Image = Global.Library_Information_System.My.Resources.Resources.Book_Icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button1.Size = New System.Drawing.Size(245, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Books"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Logout.FlatAppearance.BorderSize = 0
        Me.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Logout.Image = CType(resources.GetObject("Logout.Image"), System.Drawing.Image)
        Me.Logout.Location = New System.Drawing.Point(0, 726)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(245, 52)
        Me.Logout.TabIndex = 6
        Me.Logout.Text = "Logout"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logout.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'User_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 842)
        Me.Controls.Add(Me.Container)
        Me.Controls.Add(Me.Navbar)
        Me.Controls.Add(Me.SideNavbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User_Dashboard"
        Me.Text = "User_Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideNavbar.ResumeLayout(False)
        Me.Navbar.ResumeLayout(False)
        Me.Date_Time_Container.ResumeLayout(False)
        Me.Date_Time_Container.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Container.ResumeLayout(False)
        Me.dashboardContainer.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.HistoryPanel.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideNavbar As Panel
    Friend WithEvents Logout As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Navbar As Panel
    Friend WithEvents Date_Time_Container As Panel
    Friend WithEvents Date_Label As Label
    Friend WithEvents Time As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pageIndicator As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Container As Panel
    Friend WithEvents dashboardContainer As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents searchBorrowedBtn As Button
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents Call_Number As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Publisher As DataGridViewTextBoxColumn
    Friend WithEvents Published As DataGridViewTextBoxColumn
    Friend WithEvents view As DataGridViewImageColumn
    Friend WithEvents HistoryPanel As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents history_count As DataGridViewTextBoxColumn
    Friend WithEvents history_title As DataGridViewTextBoxColumn
    Friend WithEvents history_isbn As DataGridViewTextBoxColumn
    Friend WithEvents history_borrowed As DataGridViewTextBoxColumn
    Friend WithEvents history_due As DataGridViewTextBoxColumn
    Friend WithEvents history_status As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
