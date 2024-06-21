Imports System.Data.OleDb
Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Admin_Dashboard
    Private db As db_connection
    Private names As Update
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Dim data As New DataSet
    Dim dataAdapt As New OleDbDataAdapter
    Dim table As New DataTable
    Dim insertForm As New Insert
    Dim updateForm As New Update
    Dim warningForm As New warning
    Dim reader As MySqlDataReader
    Dim isCollapsed As Boolean = True
    Dim borrwedEditForm As New borrowed_Edit

    ' ====================== BASE FORM ======================
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = "hello"
        db = New db_connection
        ' method of the "db_connection"
        db.connection()

        ' Since our Dropanel is MaxSize we assign it to MinimumSize
        DropPanel.Size = DropPanel.MinimumSize
        ' Enaible the Timer2: means it starts to count
        Timer2.Enabled = True

        ' [ Load Components ]
        dashboardPanel.Visible = True
        booksPanel.Visible = False
        borrowedPanel.Visible = False
        manageUsers.Visible = False

        loadCount()
        ' [ Center label ]
        CenterLabelHorizontallyInPanel(Total_Books_Label, Total_Books_Panel)
        CenterLabelHorizontallyInPanel(Returned_Books_Label, Returned_Books_Panel)
        CenterLabelHorizontallyInPanel(Borrowed_Books_Label, Borrowed_Books_Panel)
        CenterLabelHorizontallyInPanel(Label2, Panel17)
        CenterLabelHorizontallyInPanel(Label6, Panel19)
        CenterLabelHorizontallyInPanel(Label8, Panel21)

        InitializeChart()
        LoadBorrowedData()
    End Sub

    Sub loadCount()
        Try
            openCon()

            ' Get the current year
            Dim currentYear As Integer = DateTime.Now.Year

            ' Count total books
            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM books", con)
            Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
            Total_Books_Label.Text = String.Format("{0}", count)

            ' Count borrowed books for the current year (based on due_date)
            Dim borrowedCmd As New MySqlCommand("SELECT COUNT(*) FROM borrowed WHERE status = 'borrowing' AND YEAR(due_date) = @year", con)
            borrowedCmd.Parameters.AddWithValue("@year", currentYear)
            Dim borrowedCount As Int32 = CType(borrowedCmd.ExecuteScalar(), Int32)
            Borrowed_Books_Label.Text = String.Format("{0}", borrowedCount)

            ' Count returned books for the current year (based on due_date)
            Dim returnedCmd As New MySqlCommand("SELECT COUNT(*) FROM borrowed WHERE status = 'returned' AND YEAR(due_date) = @year", con)
            returnedCmd.Parameters.AddWithValue("@year", currentYear)
            Dim returnedCount As Int32 = CType(returnedCmd.ExecuteScalar(), Int32)
            Returned_Books_Label.Text = String.Format("{0}", returnedCount)

            ' Count books not returned (lost) for the current year (based on due_date)
            Dim lostCmd As New MySqlCommand("SELECT COUNT(*) FROM borrowed WHERE status = 'not returned' AND YEAR(due_date) = @year", con)
            lostCmd.Parameters.AddWithValue("@year", currentYear)
            Dim lostCount As Int32 = CType(lostCmd.ExecuteScalar(), Int32)
            Label6.Text = String.Format("{0}", lostCount)

            ' Count books damaged for the current year (based on due_date)
            Dim damagedCmd As New MySqlCommand("SELECT COUNT(*) FROM borrowed WHERE status = 'damaged' AND YEAR(due_date) = @year", con)
            damagedCmd.Parameters.AddWithValue("@year", currentYear)
            Dim damagedCount As Int32 = CType(damagedCmd.ExecuteScalar(), Int32)
            Label8.Text = String.Format("{0}", damagedCount)

            ' Count total users
            Dim userCmd As New MySqlCommand("SELECT COUNT(*) FROM user_credentials", con)
            Dim userCount As Int32 = CType(userCmd.ExecuteScalar(), Int32)
            Label2.Text = String.Format("{0}", userCount)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub


    ' ================================ BUTTONS ================================
    ' [ Drop Button ]
    Private Sub DropBtn_Click(sender As Object, e As EventArgs) Handles DropBtn.Click
        ' start the timer when it clicks
        Timer1.Start()
    End Sub

    ' [ Button * Logout ] Logout Button
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim loginForm As New Form1
        Me.Hide()
        loginForm.Show()
    End Sub

    ' ============================== TIMERS ==============================
    ' Timer #1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' if isCollapsed equal to true then do this statement
        If isCollapsed Then
            ' changing the image of arrow_left to arrow_down if is true
            DropBtn.Image = My.Resources.Arrow_Down
            ' incrementing the Height of the Panel by 10(per 10milisecs)
            DropPanel.Height += 10
            ' since we've incrementing the Height of the DropPanel when it reach to MaximumSize
            ' the Timer1 Stop then turning the isCollapsed to false so we can use the other statement
            If DropPanel.Size = DropPanel.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            ' else isCollapsed is false then do this statement
            DropBtn.Image = My.Resources.Arrow_Right
            ' decrementing the Height
            DropPanel.Height -= 10
            ' If DropPanel Size is same as the MinumumSize that we assign then the timer will stop
            If DropPanel.Size = DropPanel.MinimumSize Then
                Timer1.Stop()
                ' turning isCollapsed to True again so that we can use the first statement
                isCollapsed = True
            End If
        End If
    End Sub

    ' [ Date and Time ] Timer #2
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' set current time on label
        Time.Text = DateTime.Now.ToString("hh:mm:ss tt")
        ' set current date on label
        Date_Label.Text = DateTime.Now.ToString("MM/dd/yyy")

    End Sub

    ' =================================== COMPONENTS =================================
    ' [ Book ] | Show the Book Component
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' [ Load Components ]
        dashboardPanel.Visible = False
        booksPanel.Visible = True
        borrowedPanel.Visible = False
        manageUsers.Visible = False
        pageIndicator.Text = "Books"
        loadTable()

    End Sub

    ' [ Dashboard ] | Show the Dahboard Component
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' [ Load Components ]
        dashboardPanel.Visible = True
        booksPanel.Visible = False
        borrowedPanel.Visible = False
        manageUsers.Visible = False
        pageIndicator.Text = "Dashboard"
        loadCount()
        LoadBorrowedData()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        dashboardPanel.Visible = False
        booksPanel.Visible = False
        borrowedPanel.Visible = False
        manageUsers.Visible = True
        pageIndicator.Text = "User"
        userLoadTable()
    End Sub

    ' ================================= FUNCTIONS ===================================

    ' [ Book Table ] | Load the Data in the Table
    Public Sub loadTable()

        Try
            DataGridView1.Rows.Clear()
            openCon()
            cmd = New MySqlCommand("select *, DATE(published) AS published_date from books", con)
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView1.Rows.Add()
                DataGridView1.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView1.Rows(rowIndex).Cells("book_id").Value = reader.Item("book_id").ToString()
                DataGridView1.Rows(rowIndex).Cells("call_number").Value = reader.Item("call_number").ToString()
                DataGridView1.Rows(rowIndex).Cells("title").Value = reader.Item("title").ToString()
                DataGridView1.Rows(rowIndex).Cells("category").Value = reader.Item("category").ToString()
                DataGridView1.Rows(rowIndex).Cells("author").Value = reader.Item("author").ToString()
                DataGridView1.Rows(rowIndex).Cells("isbn").Value = reader.Item("isbn").ToString()
                DataGridView1.Rows(rowIndex).Cells("publisher").Value = reader.Item("publisher").ToString()
                DataGridView1.Rows(rowIndex).Cells("published").Value = DateTime.Parse(reader("published_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView1.Rows(rowIndex).Cells("quantity").Value = reader.Item("quantity").ToString()
                rowIndex += 1
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub borrowedLoadTable()
        Try
            DataGridView2.Rows.Clear()
            openCon()
            cmd = New MySqlCommand("select *, DATE(borrowed_date) AS borrowed_date, DATE(due_date) AS due_date from borrowed", con)
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView2.Rows.Add()
                DataGridView2.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_id").Value = reader.Item("borrowed_id").ToString()
                DataGridView2.Rows(rowIndex).Cells("usn").Value = reader.Item("usn").ToString()
                DataGridView2.Rows(rowIndex).Cells("section").Value = reader.Item("section").ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_name").Value = reader.Item("name").ToString()
                DataGridView2.Rows(rowIndex).Cells("phonenumber").Value = reader.Item("phonenumber").ToString()
                DataGridView2.Rows(rowIndex).Cells("address").Value = reader.Item("address").ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_date").Value = DateTime.Parse(reader("borrowed_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView2.Rows(rowIndex).Cells("due_date").Value = DateTime.Parse(reader("due_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView2.Rows(rowIndex).Cells("borrowed_title").Value = reader.Item("title").ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_isbn").Value = reader.Item("isbn").ToString()
                DataGridView2.Rows(rowIndex).Cells("status").Value = reader.Item("status").ToString()
                rowIndex += 1
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub userLoadTable()
        Try
            DataGridView3.Rows.Clear()
            openCon()
            cmd = New MySqlCommand("SELECT * FROM user_credentials ", con)
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView3.Rows.Add()
                DataGridView3.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView3.Rows(rowIndex).Cells(1).Value = reader.Item("user_usn").ToString()
                DataGridView3.Rows(rowIndex).Cells(2).Value = reader.Item("user_password").ToString()
                DataGridView3.Rows(rowIndex).Cells(3).Value = reader.Item("user_section").ToString()
                DataGridView3.Rows(rowIndex).Cells(4).Value = reader.Item("user_name").ToString()
                rowIndex += 1

            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' [ Insert Book ]

    ' [ Center ] | Central the label inside the panel
    Sub CenterLabelHorizontallyInPanel(label As Label, panel As Panel)
        ' Calculate the new x-coordinate to center the label horizontally
        Dim newX As Integer = (panel.Width - label.Width) / 2

        ' Set the label's Location, keeping the y-coordinate unchanged
        label.Location = New Point(newX, label.Location.Y)
    End Sub

    Sub openCon()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        loadTable()
    End Sub

    Private Sub addBtn_Click_1(sender As Object, e As EventArgs) Handles addBtn.Click
        insertForm.Show()
        insertForm.BringToFront()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
                Dim callNumber, isbn, title, author, publisher, quantity, category, bookId As String
                Dim published As Date
                bookId = DataGridView1.CurrentRow.Cells("book_id").Value.ToString
                callNumber = DataGridView1.CurrentRow.Cells("call_number").Value.ToString
                isbn = DataGridView1.CurrentRow.Cells("isbn").Value.ToString
                category = DataGridView1.CurrentRow.Cells("category").Value.ToString
                title = DataGridView1.CurrentRow.Cells("title").Value.ToString
                author = DataGridView1.CurrentRow.Cells("author").Value.ToString
                publisher = DataGridView1.CurrentRow.Cells("publisher").Value.ToString
                quantity = DataGridView1.CurrentRow.Cells("quantity").Value.ToString
                published = CType(DataGridView1.CurrentRow.Cells("published").Value, Date)
                updateForm.loadString(callNumber, isbn, title, author, publisher, quantity, category, published)
                updateForm.booksId(bookId)
                updateForm.Show()
            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
                Dim bookId, callNumber, title, quantity, isbn As String
                isbn = DataGridView1.CurrentRow.Cells("isbn").Value.ToString
                title = DataGridView1.CurrentRow.Cells("title").Value.ToString
                quantity = DataGridView1.CurrentRow.Cells("quantity").Value.ToString
                callNumber = DataGridView1.CurrentRow.Cells("call_number").Value.ToString
                bookId = DataGridView1.CurrentRow.Cells("book_id").Value.ToString
                warningForm.deleteLoadString(callNumber, title, quantity, isbn)
                warningForm.bookId = bookId
                warningForm.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Search..." Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Search..."
            TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Search..." Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Search..."
            TextBox2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        If TextBox3.Text = "Search..." Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            TextBox3.Text = "Search..."
            TextBox3.ForeColor = Color.Gray
        End If
    End Sub



    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        DataGridView1.Rows.Clear()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT *, DATE(published) AS published_date FROM books WHERE title LIKE @search", con)
            cmd.Parameters.AddWithValue("@search", "%" & TextBox1.Text & "%")
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView1.Rows.Add()
                DataGridView1.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView1.Rows(rowIndex).Cells("book_id").Value = reader.Item("book_id").ToString()
                DataGridView1.Rows(rowIndex).Cells("call_number").Value = reader.Item("call_number").ToString()
                DataGridView1.Rows(rowIndex).Cells("title").Value = reader.Item("title").ToString()
                DataGridView1.Rows(rowIndex).Cells("category").Value = reader.Item("category").ToString()
                DataGridView1.Rows(rowIndex).Cells("author").Value = reader.Item("author").ToString()
                DataGridView1.Rows(rowIndex).Cells("isbn").Value = reader.Item("isbn").ToString()
                DataGridView1.Rows(rowIndex).Cells("publisher").Value = reader.Item("publisher").ToString()
                DataGridView1.Rows(rowIndex).Cells("published").Value = DateTime.Parse(reader("published_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView1.Rows(rowIndex).Cells("quantity").Value = reader.Item("quantity").ToString()
                rowIndex += 1
            End While
            reader.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Total_Books_Label_Click(sender As Object, e As EventArgs) Handles Total_Books_Label.Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles borrowedBtn.Click
        borrowedPanel.Visible = True
        dashboardPanel.Visible = False
        booksPanel.Visible = False
        manageUsers.Visible = False
        pageIndicator.Text = "Borrowed Books"
        borrowedLoadTable()
        setGridStyle()

    End Sub

    Sub SetGridStyle()
        For Each row As DataGridViewRow In DataGridView2.Rows
            ' Assuming the "Status" is in the 7th column (index 6)
            Dim cell As DataGridViewCell = row.Cells("status") ' 7th column (index 6)
            Dim value As String = CStr(cell.Value)

            If value = "Not returned" Then
                cell.Style.BackColor = Color.LightCoral
                cell.Style.ForeColor = Color.Maroon
            ElseIf value = "Lost" Then
                cell.Style.BackColor = Color.LightCoral
                cell.Style.ForeColor = Color.Maroon
            ElseIf value = "Damaged" Then
                cell.Style.BackColor = Color.LightCoral
                cell.Style.ForeColor = Color.Maroon
            ElseIf value = "Returned" Then
                cell.Style.BackColor = Color.LightGreen
                cell.Style.ForeColor = Color.DarkGreen
            ElseIf value = "Borrowing" Then
                cell.Style.BackColor = Color.Khaki
                cell.Style.ForeColor = Color.Olive
            End If
        Next
    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If DataGridView2.Columns(e.ColumnIndex).Name = "borrowed_edit" Then
            Dim name, usn, borrowed_id As String
            borrowed_id = DataGridView2.CurrentRow.Cells("borrowed_id").Value.ToString
            name = DataGridView2.CurrentRow.Cells("borrowed_name").Value.ToString
            usn = DataGridView2.CurrentRow.Cells("usn").Value.ToString
            borrwedEditForm.borrowedUpdate(name, usn, borrowed_id)
            borrwedEditForm.Show()
        ElseIf DataGridView2.Columns(e.ColumnIndex).Name = "borrowed_delete" Then
            Dim name, usn, isbn, title, borrowed_id As String
            borrowed_id = DataGridView2.CurrentRow.Cells("borrowed_id").Value.ToString
            name = DataGridView2.CurrentRow.Cells("borrowed_name").Value.ToString
            usn = DataGridView2.CurrentRow.Cells("usn").Value.ToString
            isbn = DataGridView2.CurrentRow.Cells("borrowed_isbn").Value.ToString
            title = DataGridView2.CurrentRow.Cells("borrowed_title").Value.ToString
            Dim warningDelete As New warningBorrowed
            warningDelete.borrowedUSN = borrowed_id
            warningDelete.getData(isbn, title, name, usn)
            warningDelete.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        borrowedLoadTable()
        SetGridStyle()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles searchBorrowedBtn.Click
        DataGridView2.Rows.Clear()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        Try
            con.Open()
            Dim cmd As New MySqlCommand("select *, DATE(borrowed_date) AS borrowed_date, DATE(due_date) AS due_date from borrowed WHERE name LIKE @nameSearch OR usn LIKE @nameSearch OR section LIKE @nameSearch OR title LIKE @nameSearch OR isbn LIKE @nameSearch", con)
            cmd.Parameters.AddWithValue("@nameSearch", "%" & TextBox2.Text & "%")
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView2.Rows.Add()
                DataGridView2.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_id").Value = reader.Item("borrowed_id").ToString()
                DataGridView2.Rows(rowIndex).Cells("usn").Value = reader.Item("usn").ToString()
                DataGridView2.Rows(rowIndex).Cells("section").Value = reader.Item("section").ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_name").Value = reader.Item("name").ToString()
                DataGridView2.Rows(rowIndex).Cells("phonenumber").Value = reader.Item("phonenumber").ToString()
                DataGridView2.Rows(rowIndex).Cells("address").Value = reader.Item("address").ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_date").Value = DateTime.Parse(reader("borrowed_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView2.Rows(rowIndex).Cells("due_date").Value = DateTime.Parse(reader("due_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView2.Rows(rowIndex).Cells("borrowed_title").Value = reader.Item("title").ToString()
                DataGridView2.Rows(rowIndex).Cells("borrowed_isbn").Value = reader.Item("isbn").ToString()
                DataGridView2.Rows(rowIndex).Cells("status").Value = reader.Item("status").ToString()
                rowIndex += 1
            End While
            SetGridStyle()
            reader.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        userLoadTable()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView3.Rows.Clear()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM user_credentials WHERE user_name LIKE @userName OR user_usn LIKE @userName OR user_section LIKE @userName", con)
            cmd.Parameters.AddWithValue("@userName", "%" & TextBox3.Text & "%")
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView3.Rows.Add()
                DataGridView3.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView3.Rows(rowIndex).Cells(1).Value = reader.Item("user_usn").ToString()
                DataGridView3.Rows(rowIndex).Cells(2).Value = reader.Item("user_password").ToString()
                DataGridView3.Rows(rowIndex).Cells(3).Value = reader.Item("user_section").ToString()
                DataGridView3.Rows(rowIndex).Cells(4).Value = reader.Item("user_name").ToString()
                rowIndex += 1
            End While
            reader.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim addUserForm As New insertUser
        addUserForm.Show()

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim userWarningForm As New warningUser
        Dim userUpdateForm As New updateUser
        If DataGridView3.Columns(e.ColumnIndex).Name = "user_edit" Then
            Dim name, usn, section, password As String
            name = DataGridView3.CurrentRow.Cells("user_name").Value.ToString
            usn = DataGridView3.CurrentRow.Cells("user_usn").Value.ToString
            password = DataGridView3.CurrentRow.Cells("user_password").Value.ToString
            section = DataGridView3.CurrentRow.Cells("user_section").Value.ToString
            userUpdateForm.getData(usn, password, section, name)
            userUpdateForm.getUserUSN = usn
            userUpdateForm.Show()
        ElseIf DataGridView3.Columns(e.ColumnIndex).Name = "user_delete" Then
            Dim name, usn As String
            name = DataGridView3.CurrentRow.Cells("user_name").Value.ToString
            usn = DataGridView3.CurrentRow.Cells("user_usn").Value.ToString
            userWarningForm.loadUserWarningParagraph(name, usn)
            userWarningForm.Show()
            userWarningForm.userUSN = usn
        End If
    End Sub

    Private Sub InitializeChart()
        ' Remove any existing series
        Chart1.Series.Clear()

        ' Create a new ChartArea
        Dim chartArea As New ChartArea()
        chartArea.AxisX.Title = "Month"
        chartArea.AxisY.Title = "Number of Books"
        chartArea.AxisY.Interval = 1 ' Set Y-axis to increment by 1

        ' Set the font of the X-axis labels
        chartArea.AxisX.LabelStyle.Font = New Font("Arial", 12, FontStyle.Regular)

        Chart1.ChartAreas.Add(chartArea)

        ' Create a new Series
        Dim series As New Series()
        series.Name = "BorrowedBooks"
        series.ChartType = SeriesChartType.Column
        Chart1.Series.Add(series)

        ' Set chart title with a larger font size
        Dim title As New Title()
        title.Text = "Books Borrowed Each Month"
        title.Font = New Font("Arial", 16, FontStyle.Bold) ' Set the font size to 16 and bold
        Chart1.Titles.Add(title)
    End Sub

    Private Sub LoadBorrowedData()
        Try
            ' Clear existing data points
            Chart1.Series("BorrowedBooks").Points.Clear()

            ' Get the current year
            Dim currentYear As Integer = DateTime.Now.Year

            ' Establish the database connection
            Dim conString As String = "server=localhost; database=library_information_system_database; username=root; password=;"
            Using con As New MySqlConnection(conString)
                con.Open()

                ' SQL query to get the count of borrowed books for each month of the current year
                Dim query As String = "
                SELECT DATE_FORMAT(borrowed_date, '%Y-%m') AS month, COUNT(*) AS count
                FROM borrowed
                WHERE YEAR(borrowed_date) = @year
                GROUP BY DATE_FORMAT(borrowed_date, '%Y-%m')
                ORDER BY DATE_FORMAT(borrowed_date, '%Y-%m')
            "

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@year", currentYear)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim month As String = reader("month").ToString()
                            Dim count As Integer = Convert.ToInt32(reader("count"))

                            ' Add data points to the chart series
                            Chart1.Series("BorrowedBooks").Points.AddXY(month, count)
                        End While
                    End Using
                End Using

                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Class