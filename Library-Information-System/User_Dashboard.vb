Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class User_Dashboard
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Public getUSN As String
    Private Sub User_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        dashboardContainer.Visible = True
        HistoryPanel.Visible = False
        loadTable()
        pageIndicator.Text = "Books"
        Try
            openCon()
            Dim userCmd As New MySqlCommand("SELECT user_name FROM user_credentials WHERE user_usn = @usn", con)
            userCmd.Parameters.Clear()
            userCmd.Parameters.AddWithValue("@usn", getUSN)
            Dim username As String = CType(userCmd.ExecuteScalar(), String)
            Label1.Text = "Welcome!, " + username
            reader = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' set current time on label
        Time.Text = DateTime.Now.ToString("hh:mm:ss tt")
        ' set current date on label
        Date_Label.Text = DateTime.Now.ToString("MM/dd/yyy")

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        getUSN = ""
        Me.Hide()
        Dim login As New Form1
        login.Show()
    End Sub

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
                DataGridView1.Rows(rowIndex).Cells(1).Value = reader.Item("call_number").ToString()
                DataGridView1.Rows(rowIndex).Cells(2).Value = reader.Item("title").ToString()
                DataGridView1.Rows(rowIndex).Cells(3).Value = reader.Item("category").ToString()
                DataGridView1.Rows(rowIndex).Cells(4).Value = reader.Item("author").ToString()
                DataGridView1.Rows(rowIndex).Cells(5).Value = reader.Item("isbn").ToString()
                DataGridView1.Rows(rowIndex).Cells(6).Value = reader.Item("publisher").ToString()
                DataGridView1.Rows(rowIndex).Cells(7).Value = DateTime.Parse(reader("published_date").ToString()).ToString("yyyy-MM-dd")
                rowIndex += 1
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub historyLoadTable()

        Try
            DataGridView2.Rows.Clear()
            openCon()
            cmd = New MySqlCommand("select *, DATE(borrowed_date) AS borrowed_date, DATE(due_date) AS due_date from borrowed WHERE usn = @userUSN", con)
            cmd.Parameters.AddWithValue("@userUSN", getUSN)
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView2.Rows.Add()
                DataGridView2.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView2.Rows(rowIndex).Cells("history_title").Value = reader.Item("title").ToString()
                DataGridView2.Rows(rowIndex).Cells("history_isbn").Value = reader.Item("isbn").ToString()
                DataGridView2.Rows(rowIndex).Cells("history_borrowed").Value = DateTime.Parse(reader("borrowed_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView2.Rows(rowIndex).Cells("history_due").Value = DateTime.Parse(reader("due_date").ToString()).ToString("yyyy-MM-dd")
                DataGridView2.Rows(rowIndex).Cells("history_status").Value = reader.Item("status").ToString()
                rowIndex += 1
            End While
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub SetGridStyle()
        For Each row As DataGridViewRow In DataGridView2.Rows
            ' Assuming the "Status" is in the 7th column (index 6)
            Dim cell As DataGridViewCell = row.Cells("history_status") ' 7th column (index 6)
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

    Sub openCon()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pageIndicator.Text = "Books"
        dashboardContainer.Visible = True
        HistoryPanel.Visible = False
        loadTable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(e.ColumnIndex).Name = "view" Then
            Dim view As New View
            Dim title, catagory, callnunmber, author, isbn As String
            title = DataGridView1.CurrentRow.Cells("title").Value.ToString
            catagory = DataGridView1.CurrentRow.Cells("category").Value.ToString
            callnunmber = DataGridView1.CurrentRow.Cells("call_number").Value.ToString
            author = DataGridView1.CurrentRow.Cells("author").Value.ToString
            isbn = DataGridView1.CurrentRow.Cells("isbn").Value.ToString
            view.Show()
            view.getData(title, catagory, callnunmber, author, isbn)
            view.getUserUSN = getUSN
        End If
    End Sub

    Private Sub searchBorrowedBtn_Click(sender As Object, e As EventArgs) Handles searchBorrowedBtn.Click
        DataGridView1.Rows.Clear()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT *, DATE(published) AS published_date FROM books WHERE title LIKE @search OR call_number LIKE @search OR author LIKE @search OR category LIKE @search", con)
            cmd.Parameters.AddWithValue("@search", "%" & TextBox1.Text & "%")
            reader = cmd.ExecuteReader
            Dim rowIndex As Integer = 0
            While reader.Read
                DataGridView1.Rows.Add()
                DataGridView1.Rows(rowIndex).Cells(0).Value = (rowIndex + 1).ToString()
                DataGridView1.Rows(rowIndex).Cells("call_number").Value = reader.Item("call_number").ToString()
                DataGridView1.Rows(rowIndex).Cells("title").Value = reader.Item("title").ToString()
                DataGridView1.Rows(rowIndex).Cells("category").Value = reader.Item("category").ToString()
                DataGridView1.Rows(rowIndex).Cells("author").Value = reader.Item("author").ToString()
                DataGridView1.Rows(rowIndex).Cells("isbn").Value = reader.Item("isbn").ToString()
                DataGridView1.Rows(rowIndex).Cells("publisher").Value = reader.Item("publisher").ToString()
                DataGridView1.Rows(rowIndex).Cells("published").Value = DateTime.Parse(reader("published_date").ToString()).ToString("yyyy-MM-dd")
                rowIndex += 1
            End While
            reader.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pageIndicator.Text = "History"
        HistoryPanel.Visible = True
        dashboardContainer.Visible = False
        historyLoadTable()
        SetGridStyle()
    End Sub
End Class