<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Dashboard))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SideNavbar = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DropPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DropBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.borrowedBtn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Navbar = New System.Windows.Forms.Panel()
        Me.Date_Time_Container = New System.Windows.Forms.Panel()
        Me.Date_Label = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.pageIndicator = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel_Container = New System.Windows.Forms.Panel()
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.totalBooksPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Total_Books_Panel = New System.Windows.Forms.Panel()
        Me.Total_Books_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.returnedBooksPanel = New System.Windows.Forms.Panel()
        Me.Returned_Books_Panel = New System.Windows.Forms.Panel()
        Me.Returned_Books_Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.borrowedBooksPanel = New System.Windows.Forms.Panel()
        Me.Borrowed_Books_Panel = New System.Windows.Forms.Panel()
        Me.Borrowed_Books_Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.booksPanel = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Call_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Publisher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Published = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.borrowedPanel = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowed_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowed_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowed_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.due_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowed_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowed_isbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowed_edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.borrowed_delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.searchBorrowedBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.manageUsers = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_usn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.user_delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SideNavbar.SuspendLayout()
        Me.DropPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Navbar.SuspendLayout()
        Me.Date_Time_Container.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel_Container.SuspendLayout()
        Me.dashboardPanel.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.totalBooksPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Total_Books_Panel.SuspendLayout()
        Me.returnedBooksPanel.SuspendLayout()
        Me.Returned_Books_Panel.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.borrowedBooksPanel.SuspendLayout()
        Me.Borrowed_Books_Panel.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel17.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel15.SuspendLayout()
        Me.Panel21.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.booksPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.borrowedPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.manageUsers.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel20.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideNavbar
        '
        Me.SideNavbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.SideNavbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SideNavbar.Controls.Add(Me.Button4)
        Me.SideNavbar.Controls.Add(Me.Logout)
        Me.SideNavbar.Controls.Add(Me.Panel5)
        Me.SideNavbar.Controls.Add(Me.DropPanel)
        Me.SideNavbar.Controls.Add(Me.Button1)
        Me.SideNavbar.Controls.Add(Me.Panel2)
        Me.SideNavbar.Controls.Add(Me.PictureBox1)
        Me.SideNavbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideNavbar.Location = New System.Drawing.Point(0, 0)
        Me.SideNavbar.Margin = New System.Windows.Forms.Padding(0)
        Me.SideNavbar.Name = "SideNavbar"
        Me.SideNavbar.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.SideNavbar.Size = New System.Drawing.Size(245, 881)
        Me.SideNavbar.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button4.Image = Global.Library_Information_System.My.Resources.Resources.User_Icon
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 447)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button4.Size = New System.Drawing.Size(245, 52)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Users"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
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
        Me.Logout.Location = New System.Drawing.Point(0, 765)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(245, 52)
        Me.Logout.TabIndex = 6
        Me.Logout.Text = "Logout"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 817)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(245, 64)
        Me.Panel5.TabIndex = 5
        '
        'DropPanel
        '
        Me.DropPanel.Controls.Add(Me.Panel3)
        Me.DropPanel.Controls.Add(Me.Panel4)
        Me.DropPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DropPanel.Location = New System.Drawing.Point(0, 281)
        Me.DropPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.DropPanel.MaximumSize = New System.Drawing.Size(245, 166)
        Me.DropPanel.MinimumSize = New System.Drawing.Size(245, 55)
        Me.DropPanel.Name = "DropPanel"
        Me.DropPanel.Size = New System.Drawing.Size(245, 166)
        Me.DropPanel.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DropBtn)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 52)
        Me.Panel3.TabIndex = 0
        '
        'DropBtn
        '
        Me.DropBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DropBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DropBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropBtn.FlatAppearance.BorderSize = 0
        Me.DropBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DropBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DropBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DropBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.DropBtn.Image = CType(resources.GetObject("DropBtn.Image"), System.Drawing.Image)
        Me.DropBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DropBtn.Location = New System.Drawing.Point(39, 0)
        Me.DropBtn.Name = "DropBtn"
        Me.DropBtn.Size = New System.Drawing.Size(200, 52)
        Me.DropBtn.TabIndex = 1
        Me.DropBtn.Text = "Book Tables"
        Me.DropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DropBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Controls.Add(Me.borrowedBtn)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Location = New System.Drawing.Point(3, 61)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(242, 106)
        Me.Panel4.TabIndex = 1
        '
        'borrowedBtn
        '
        Me.borrowedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.borrowedBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.borrowedBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.borrowedBtn.FlatAppearance.BorderSize = 0
        Me.borrowedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.borrowedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.borrowedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrowedBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowedBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.borrowedBtn.Location = New System.Drawing.Point(0, 52)
        Me.borrowedBtn.Name = "borrowedBtn"
        Me.borrowedBtn.Size = New System.Drawing.Size(242, 52)
        Me.borrowedBtn.TabIndex = 5
        Me.borrowedBtn.Text = "Borrowed"
        Me.borrowedBtn.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(242, 52)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Books"
        Me.Button5.UseVisualStyleBackColor = True
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
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button1.Size = New System.Drawing.Size(245, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Dashboard"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 64)
        Me.Panel2.TabIndex = 2
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
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Navbar
        '
        Me.Navbar.Controls.Add(Me.Date_Time_Container)
        Me.Navbar.Controls.Add(Me.Panel7)
        Me.Navbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.Navbar.Location = New System.Drawing.Point(245, 0)
        Me.Navbar.Name = "Navbar"
        Me.Navbar.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Navbar.Size = New System.Drawing.Size(1179, 62)
        Me.Navbar.TabIndex = 1
        '
        'Date_Time_Container
        '
        Me.Date_Time_Container.Controls.Add(Me.Date_Label)
        Me.Date_Time_Container.Controls.Add(Me.Time)
        Me.Date_Time_Container.Dock = System.Windows.Forms.DockStyle.Right
        Me.Date_Time_Container.Location = New System.Drawing.Point(1020, 0)
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
        'Timer2
        '
        '
        'Panel_Container
        '
        Me.Panel_Container.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Container.Controls.Add(Me.dashboardPanel)
        Me.Panel_Container.Controls.Add(Me.booksPanel)
        Me.Panel_Container.Controls.Add(Me.borrowedPanel)
        Me.Panel_Container.Controls.Add(Me.manageUsers)
        Me.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Container.Location = New System.Drawing.Point(245, 62)
        Me.Panel_Container.Name = "Panel_Container"
        Me.Panel_Container.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel_Container.Size = New System.Drawing.Size(1179, 819)
        Me.Panel_Container.TabIndex = 3
        '
        'dashboardPanel
        '
        Me.dashboardPanel.Controls.Add(Me.Chart1)
        Me.dashboardPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardPanel.Location = New System.Drawing.Point(30, 30)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.Size = New System.Drawing.Size(1119, 759)
        Me.dashboardPanel.TabIndex = 0
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(0, 314)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1119, 445)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.totalBooksPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.returnedBooksPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.borrowedBooksPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel13)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel14)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel15)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1119, 314)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'totalBooksPanel
        '
        Me.totalBooksPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.totalBooksPanel.Controls.Add(Me.PictureBox3)
        Me.totalBooksPanel.Controls.Add(Me.Total_Books_Panel)
        Me.totalBooksPanel.Location = New System.Drawing.Point(0, 0)
        Me.totalBooksPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.totalBooksPanel.Name = "totalBooksPanel"
        Me.totalBooksPanel.Size = New System.Drawing.Size(353, 150)
        Me.totalBooksPanel.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(153, 150)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Total_Books_Panel
        '
        Me.Total_Books_Panel.Controls.Add(Me.Total_Books_Label)
        Me.Total_Books_Panel.Controls.Add(Me.Label1)
        Me.Total_Books_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Total_Books_Panel.Location = New System.Drawing.Point(153, 0)
        Me.Total_Books_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Total_Books_Panel.Name = "Total_Books_Panel"
        Me.Total_Books_Panel.Size = New System.Drawing.Size(200, 150)
        Me.Total_Books_Panel.TabIndex = 0
        '
        'Total_Books_Label
        '
        Me.Total_Books_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Total_Books_Label.AutoSize = True
        Me.Total_Books_Label.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Books_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Total_Books_Label.Location = New System.Drawing.Point(-5, 71)
        Me.Total_Books_Label.Name = "Total_Books_Label"
        Me.Total_Books_Label.Size = New System.Drawing.Size(132, 56)
        Me.Total_Books_Label.TabIndex = 1
        Me.Total_Books_Label.Text = "3000"
        Me.Total_Books_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'returnedBooksPanel
        '
        Me.returnedBooksPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.returnedBooksPanel.Controls.Add(Me.Returned_Books_Panel)
        Me.returnedBooksPanel.Controls.Add(Me.PictureBox5)
        Me.returnedBooksPanel.Location = New System.Drawing.Point(383, 0)
        Me.returnedBooksPanel.Margin = New System.Windows.Forms.Padding(30, 0, 30, 10)
        Me.returnedBooksPanel.Name = "returnedBooksPanel"
        Me.returnedBooksPanel.Size = New System.Drawing.Size(353, 150)
        Me.returnedBooksPanel.TabIndex = 1
        '
        'Returned_Books_Panel
        '
        Me.Returned_Books_Panel.Controls.Add(Me.Returned_Books_Label)
        Me.Returned_Books_Panel.Controls.Add(Me.Label3)
        Me.Returned_Books_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Returned_Books_Panel.Location = New System.Drawing.Point(153, 0)
        Me.Returned_Books_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Returned_Books_Panel.Name = "Returned_Books_Panel"
        Me.Returned_Books_Panel.Size = New System.Drawing.Size(200, 150)
        Me.Returned_Books_Panel.TabIndex = 3
        '
        'Returned_Books_Label
        '
        Me.Returned_Books_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Returned_Books_Label.AutoSize = True
        Me.Returned_Books_Label.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Returned_Books_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Returned_Books_Label.Location = New System.Drawing.Point(18, 71)
        Me.Returned_Books_Label.Name = "Returned_Books_Label"
        Me.Returned_Books_Label.Size = New System.Drawing.Size(132, 56)
        Me.Returned_Books_Label.TabIndex = 3
        Me.Returned_Books_Label.Text = "3000"
        Me.Returned_Books_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(47, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Returned"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox5.Image = Global.Library_Information_System.My.Resources.Resources.Returned_Icon
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'borrowedBooksPanel
        '
        Me.borrowedBooksPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.borrowedBooksPanel.Controls.Add(Me.Borrowed_Books_Panel)
        Me.borrowedBooksPanel.Controls.Add(Me.PictureBox7)
        Me.borrowedBooksPanel.Location = New System.Drawing.Point(766, 0)
        Me.borrowedBooksPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.borrowedBooksPanel.Name = "borrowedBooksPanel"
        Me.borrowedBooksPanel.Size = New System.Drawing.Size(353, 150)
        Me.borrowedBooksPanel.TabIndex = 2
        '
        'Borrowed_Books_Panel
        '
        Me.Borrowed_Books_Panel.Controls.Add(Me.Borrowed_Books_Label)
        Me.Borrowed_Books_Panel.Controls.Add(Me.Label5)
        Me.Borrowed_Books_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Borrowed_Books_Panel.Location = New System.Drawing.Point(153, 0)
        Me.Borrowed_Books_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.Borrowed_Books_Panel.Name = "Borrowed_Books_Panel"
        Me.Borrowed_Books_Panel.Size = New System.Drawing.Size(200, 150)
        Me.Borrowed_Books_Panel.TabIndex = 3
        '
        'Borrowed_Books_Label
        '
        Me.Borrowed_Books_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Borrowed_Books_Label.AutoSize = True
        Me.Borrowed_Books_Label.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrowed_Books_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Borrowed_Books_Label.Location = New System.Drawing.Point(18, 71)
        Me.Borrowed_Books_Label.Name = "Borrowed_Books_Label"
        Me.Borrowed_Books_Label.Size = New System.Drawing.Size(132, 56)
        Me.Borrowed_Books_Label.TabIndex = 3
        Me.Borrowed_Books_Label.Text = "3000"
        Me.Borrowed_Books_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(52, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Borrowed"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox7.Image = Global.Library_Information_System.My.Resources.Resources.Borrowed_Icon
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Panel17)
        Me.Panel13.Controls.Add(Me.PictureBox4)
        Me.Panel13.Location = New System.Drawing.Point(0, 160)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(353, 150)
        Me.Panel13.TabIndex = 3
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Label2)
        Me.Panel17.Controls.Add(Me.Label4)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel17.Location = New System.Drawing.Point(153, 0)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(200, 150)
        Me.Panel17.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 56)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "3000"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(39, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Users"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox4.Image = Global.Library_Information_System.My.Resources.Resources.TotalUser_Icon
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Panel19)
        Me.Panel14.Controls.Add(Me.PictureBox6)
        Me.Panel14.Location = New System.Drawing.Point(383, 160)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(353, 150)
        Me.Panel14.TabIndex = 4
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Label6)
        Me.Panel19.Controls.Add(Me.Label7)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel19.Location = New System.Drawing.Point(153, 0)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(200, 150)
        Me.Panel19.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 56)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "3000"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(27, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Not Returned"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox6.Image = Global.Library_Information_System.My.Resources.Resources.Lost_Icon
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Panel21)
        Me.Panel15.Controls.Add(Me.PictureBox8)
        Me.Panel15.Location = New System.Drawing.Point(766, 160)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(353, 150)
        Me.Panel15.TabIndex = 5
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.Label8)
        Me.Panel21.Controls.Add(Me.Label9)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel21.Location = New System.Drawing.Point(153, 0)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(200, 150)
        Me.Panel21.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 56)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "3000"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(24, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Lost/Damaged"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox8.Image = Global.Library_Information_System.My.Resources.Resources.Damaged_Book
        Me.PictureBox8.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'booksPanel
        '
        Me.booksPanel.Controls.Add(Me.DataGridView1)
        Me.booksPanel.Controls.Add(Me.Panel9)
        Me.booksPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.booksPanel.Location = New System.Drawing.Point(30, 30)
        Me.booksPanel.Name = "booksPanel"
        Me.booksPanel.Size = New System.Drawing.Size(1119, 759)
        Me.booksPanel.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.book_id, Me.Call_Number, Me.Title, Me.Category, Me.Author, Me.ISBN, Me.Publisher, Me.Published, Me.quantity, Me.Edit, Me.Delete})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 11.25!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1119, 698)
        Me.DataGridView1.TabIndex = 4
        '
        'Number
        '
        Me.Number.HeaderText = "#"
        Me.Number.Name = "Number"
        Me.Number.Width = 40
        '
        'book_id
        '
        Me.book_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_id.HeaderText = "Book ID"
        Me.book_id.Name = "book_id"
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
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 91
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.Name = "Edit"
        Me.Edit.Width = 5
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.Name = "Delete"
        Me.Delete.Width = 5
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.FlowLayoutPanel3)
        Me.Panel9.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1119, 58)
        Me.Panel9.TabIndex = 5
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Panel10)
        Me.FlowLayoutPanel3.Controls.Add(Me.Panel11)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(649, 0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(470, 58)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TextBox1)
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(313, 52)
        Me.Panel10.TabIndex = 0
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
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.searchBtn)
        Me.Panel11.Location = New System.Drawing.Point(322, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(144, 47)
        Me.Panel11.TabIndex = 2
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchBtn.FlatAppearance.BorderSize = 2
        Me.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.searchBtn.Location = New System.Drawing.Point(0, 0)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(144, 47)
        Me.searchBtn.TabIndex = 0
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(470, 58)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.addBtn)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 47)
        Me.Panel1.TabIndex = 0
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.addBtn.Location = New System.Drawing.Point(0, 0)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(144, 47)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add Book"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.refreshBtn)
        Me.Panel6.Location = New System.Drawing.Point(153, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(144, 47)
        Me.Panel6.TabIndex = 1
        '
        'refreshBtn
        '
        Me.refreshBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.refreshBtn.FlatAppearance.BorderSize = 2
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.refreshBtn.Location = New System.Drawing.Point(0, 0)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(144, 47)
        Me.refreshBtn.TabIndex = 0
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = False
        '
        'borrowedPanel
        '
        Me.borrowedPanel.Controls.Add(Me.DataGridView2)
        Me.borrowedPanel.Controls.Add(Me.Panel8)
        Me.borrowedPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.borrowedPanel.Location = New System.Drawing.Point(30, 30)
        Me.borrowedPanel.Name = "borrowedPanel"
        Me.borrowedPanel.Size = New System.Drawing.Size(1119, 759)
        Me.borrowedPanel.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.borrowed_id, Me.usn, Me.section, Me.borrowed_name, Me.phoneNumber, Me.address, Me.borrowed_date, Me.due_date, Me.borrowed_title, Me.borrowed_isbn, Me.status, Me.borrowed_edit, Me.borrowed_delete})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 11.25!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DataGridView2.Location = New System.Drawing.Point(0, 58)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(1119, 673)
        Me.DataGridView2.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.FillWeight = 39.60405!
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'borrowed_id
        '
        Me.borrowed_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.borrowed_id.HeaderText = "Borrowed ID"
        Me.borrowed_id.Name = "borrowed_id"
        '
        'usn
        '
        Me.usn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.usn.FillWeight = 107.5471!
        Me.usn.HeaderText = "USN"
        Me.usn.Name = "usn"
        '
        'section
        '
        Me.section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.section.FillWeight = 74.05962!
        Me.section.HeaderText = "Section"
        Me.section.Name = "section"
        '
        'borrowed_name
        '
        Me.borrowed_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.borrowed_name.FillWeight = 104.1474!
        Me.borrowed_name.HeaderText = "Name"
        Me.borrowed_name.Name = "borrowed_name"
        '
        'phoneNumber
        '
        Me.phoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phoneNumber.FillWeight = 167.5127!
        Me.phoneNumber.HeaderText = "Phone Number"
        Me.phoneNumber.Name = "phoneNumber"
        '
        'address
        '
        Me.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.address.FillWeight = 74.05962!
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'borrowed_date
        '
        Me.borrowed_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.borrowed_date.FillWeight = 147.5224!
        Me.borrowed_date.HeaderText = "Borrowed Date"
        Me.borrowed_date.Name = "borrowed_date"
        '
        'due_date
        '
        Me.due_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.due_date.FillWeight = 136.3352!
        Me.due_date.HeaderText = "Due Date"
        Me.due_date.Name = "due_date"
        '
        'borrowed_title
        '
        Me.borrowed_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.borrowed_title.FillWeight = 74.05962!
        Me.borrowed_title.HeaderText = "Title"
        Me.borrowed_title.Name = "borrowed_title"
        '
        'borrowed_isbn
        '
        Me.borrowed_isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.borrowed_isbn.FillWeight = 74.05962!
        Me.borrowed_isbn.HeaderText = "ISBN"
        Me.borrowed_isbn.Name = "borrowed_isbn"
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.Width = 77
        '
        'borrowed_edit
        '
        Me.borrowed_edit.HeaderText = ""
        Me.borrowed_edit.Image = Global.Library_Information_System.My.Resources.Resources.Edit
        Me.borrowed_edit.Name = "borrowed_edit"
        Me.borrowed_edit.Width = 5
        '
        'borrowed_delete
        '
        Me.borrowed_delete.HeaderText = ""
        Me.borrowed_delete.Image = Global.Library_Information_System.My.Resources.Resources.Delete
        Me.borrowed_delete.Name = "borrowed_delete"
        Me.borrowed_delete.Width = 5
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.Controls.Add(Me.FlowLayoutPanel5)
        Me.Panel8.Controls.Add(Me.FlowLayoutPanel4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1119, 58)
        Me.Panel8.TabIndex = 0
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel16)
        Me.FlowLayoutPanel5.Controls.Add(Me.Panel18)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(649, 0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(470, 58)
        Me.FlowLayoutPanel5.TabIndex = 4
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.TextBox2)
        Me.Panel16.Location = New System.Drawing.Point(3, 3)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(313, 52)
        Me.Panel16.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Gray
        Me.TextBox2.Location = New System.Drawing.Point(3, 10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(307, 29)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Search..."
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
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.Panel12)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(1119, 58)
        Me.FlowLayoutPanel4.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Button2)
        Me.Panel12.Location = New System.Drawing.Point(3, 3)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(144, 47)
        Me.Panel12.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 47)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'manageUsers
        '
        Me.manageUsers.Controls.Add(Me.DataGridView3)
        Me.manageUsers.Controls.Add(Me.Panel20)
        Me.manageUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.manageUsers.Location = New System.Drawing.Point(30, 30)
        Me.manageUsers.Name = "manageUsers"
        Me.manageUsers.Size = New System.Drawing.Size(1119, 759)
        Me.manageUsers.TabIndex = 6
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView3.ColumnHeadersHeight = 40
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.user_usn, Me.user_password, Me.user_section, Me.user_name, Me.user_edit, Me.user_delete})
        Me.DataGridView3.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 11.25!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.DataGridView3.Location = New System.Drawing.Point(0, 58)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.Size = New System.Drawing.Size(1119, 656)
        Me.DataGridView3.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'user_usn
        '
        Me.user_usn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_usn.HeaderText = "USN"
        Me.user_usn.Name = "user_usn"
        '
        'user_password
        '
        Me.user_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_password.HeaderText = "Password"
        Me.user_password.Name = "user_password"
        '
        'user_section
        '
        Me.user_section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_section.HeaderText = "Section"
        Me.user_section.Name = "user_section"
        '
        'user_name
        '
        Me.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_name.HeaderText = "Name"
        Me.user_name.Name = "user_name"
        '
        'user_edit
        '
        Me.user_edit.HeaderText = ""
        Me.user_edit.Image = Global.Library_Information_System.My.Resources.Resources.Edit
        Me.user_edit.Name = "user_edit"
        Me.user_edit.Width = 5
        '
        'user_delete
        '
        Me.user_delete.HeaderText = ""
        Me.user_delete.Image = Global.Library_Information_System.My.Resources.Resources.Delete
        Me.user_delete.Name = "user_delete"
        Me.user_delete.Width = 5
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.FlowLayoutPanel7)
        Me.Panel20.Controls.Add(Me.FlowLayoutPanel6)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1119, 58)
        Me.Panel20.TabIndex = 0
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.Panel24)
        Me.FlowLayoutPanel7.Controls.Add(Me.Panel25)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(470, 58)
        Me.FlowLayoutPanel7.TabIndex = 3
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.Button7)
        Me.Panel24.Location = New System.Drawing.Point(3, 3)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(144, 47)
        Me.Panel24.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(144, 47)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Add User"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.Button8)
        Me.Panel25.Location = New System.Drawing.Point(153, 3)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(144, 47)
        Me.Panel25.TabIndex = 1
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(144, 47)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Refresh"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.Panel22)
        Me.FlowLayoutPanel6.Controls.Add(Me.Panel23)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(649, 0)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(470, 58)
        Me.FlowLayoutPanel6.TabIndex = 2
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.TextBox3)
        Me.Panel22.Location = New System.Drawing.Point(3, 3)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(313, 52)
        Me.Panel22.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Gray
        Me.TextBox3.Location = New System.Drawing.Point(3, 10)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(307, 29)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "Search..."
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Button6)
        Me.Panel23.Location = New System.Drawing.Point(322, 3)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(144, 47)
        Me.Panel23.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(0, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 47)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 5
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 5
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Width = 5
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = ""
        Me.DataGridViewImageColumn4.Image = CType(resources.GetObject("DataGridViewImageColumn4.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Width = 5
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.HeaderText = ""
        Me.DataGridViewImageColumn5.Image = Global.Library_Information_System.My.Resources.Resources.Edit
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Width = 5
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.HeaderText = ""
        Me.DataGridViewImageColumn6.Image = Global.Library_Information_System.My.Resources.Resources.Delete
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.Width = 5
        '
        'Admin_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1424, 881)
        Me.Controls.Add(Me.Panel_Container)
        Me.Controls.Add(Me.Navbar)
        Me.Controls.Add(Me.SideNavbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Dashboard"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideNavbar.ResumeLayout(False)
        Me.DropPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Navbar.ResumeLayout(False)
        Me.Date_Time_Container.ResumeLayout(False)
        Me.Date_Time_Container.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel_Container.ResumeLayout(False)
        Me.dashboardPanel.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.totalBooksPanel.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Total_Books_Panel.ResumeLayout(False)
        Me.Total_Books_Panel.PerformLayout()
        Me.returnedBooksPanel.ResumeLayout(False)
        Me.Returned_Books_Panel.ResumeLayout(False)
        Me.Returned_Books_Panel.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.borrowedBooksPanel.ResumeLayout(False)
        Me.Borrowed_Books_Panel.ResumeLayout(False)
        Me.Borrowed_Books_Panel.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel15.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.booksPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.borrowedPanel.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.manageUsers.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel20.ResumeLayout(False)
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideNavbar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DropPanel As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DropBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents borrowedBtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Navbar As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Date_Time_Container As Panel
    Friend WithEvents Date_Label As Label
    Friend WithEvents Time As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel_Container As Panel
    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents totalBooksPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Total_Books_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents returnedBooksPanel As Panel
    Friend WithEvents Returned_Books_Panel As Panel
    Friend WithEvents Returned_Books_Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents borrowedBooksPanel As Panel
    Friend WithEvents Borrowed_Books_Panel As Panel
    Friend WithEvents Borrowed_Books_Label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Total_Books_Label As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents borrowedPanel As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pageIndicator As Label
    Friend WithEvents booksPanel As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents book_id As DataGridViewTextBoxColumn
    Friend WithEvents Call_Number As DataGridViewTextBoxColumn
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents Publisher As DataGridViewTextBoxColumn
    Friend WithEvents Published As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents Panel9 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents searchBtn As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents addBtn As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents refreshBtn As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents searchBorrowedBtn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents manageUsers As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents user_usn As DataGridViewTextBoxColumn
    Friend WithEvents user_password As DataGridViewTextBoxColumn
    Friend WithEvents user_section As DataGridViewTextBoxColumn
    Friend WithEvents user_name As DataGridViewTextBoxColumn
    Friend WithEvents user_edit As DataGridViewImageColumn
    Friend WithEvents user_delete As DataGridViewImageColumn
    Friend WithEvents Panel20 As Panel
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents borrowed_id As DataGridViewTextBoxColumn
    Friend WithEvents usn As DataGridViewTextBoxColumn
    Friend WithEvents section As DataGridViewTextBoxColumn
    Friend WithEvents borrowed_name As DataGridViewTextBoxColumn
    Friend WithEvents phoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents borrowed_date As DataGridViewTextBoxColumn
    Friend WithEvents due_date As DataGridViewTextBoxColumn
    Friend WithEvents borrowed_title As DataGridViewTextBoxColumn
    Friend WithEvents borrowed_isbn As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents borrowed_edit As DataGridViewImageColumn
    Friend WithEvents borrowed_delete As DataGridViewImageColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
