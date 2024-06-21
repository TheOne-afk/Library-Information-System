Imports MySql.Data.MySqlClient

Public Class View
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public getUserUSN As String

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newX As Integer = (Panel2.Width - Label11.Width) / 2

        ' Set the label's Location, keeping the y-coordinate unchanged
        Label11.Location = New Point(newX, Label11.Location.Y)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        getUserUSN = ""
    End Sub

    Public Sub getData(title As String, category As String, callnumber As String, author As String, isbn As String)
        Label5.Text = title
        Label7.Text = category
        Label6.Text = callnumber
        Label8.Text = author
        Label11.Text = isbn
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(Trim(TextBox1.Text)) Or Not IsNumeric(Trim(TextBox1.Text)) Then
            TextBox1.BackColor = Color.LightCoral
        ElseIf String.IsNullOrEmpty(Trim(TextBox2.Text)) Then
            TextBox2.BackColor = Color.LightCoral
        ElseIf Not String.IsNullOrEmpty(TextBox1.Text) And Not String.IsNullOrEmpty(TextBox2.Text) AndAlso IsNumeric(TextBox1.Text) Then
            insertBook()
            getUserUSN = ""
            Me.Hide()
        End If
    End Sub

    Sub insertBook()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()

        Try
            cmd.Connection = con
            ' Get USER USN
            Dim usncmd As New MySqlCommand("SELECT user_usn FROM user_credentials WHERE user_usn = @userUSN", con)
            usncmd.Parameters.Clear()
            usncmd.Parameters.AddWithValue("@userUSN", getUserUSN)
            Dim usn As String = CType(usncmd.ExecuteScalar(), String)

            ' Get USER SECTION
            Dim sectioncmd As New MySqlCommand("SELECT user_section FROM user_credentials WHERE user_usn = @userUSN", con)
            sectioncmd.Parameters.Clear()
            sectioncmd.Parameters.AddWithValue("@userUSN", getUserUSN)
            Dim section As String = CType(sectioncmd.ExecuteScalar(), String)

            ' Get USER NAME
            Dim namecmd As New MySqlCommand("SELECT user_name FROM user_credentials WHERE user_usn = @userUSN", con)
            namecmd.Parameters.Clear()
            namecmd.Parameters.AddWithValue("@userUSN", getUserUSN)
            Dim name As String = CType(namecmd.ExecuteScalar(), String)
            ' Current date
            Dim borrowedDate As DateTime = DateTime.Now
            ' Due date (1 week from now)
            Dim dueDate As DateTime = borrowedDate.AddDays(7)
            cmd.CommandText = "INSERT INTO borrowed (usn,section,name,phonenumber,address,borrowed_date,due_date,title,isbn,status) VALUES (@usn,@section,@name,@phonenumber,@address,@borrowed,@due,@title,@isbn, 'Borrowing')"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usn", usn)
            cmd.Parameters.AddWithValue("@section", section)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@phonenumber", TextBox1.Text)
            cmd.Parameters.AddWithValue("@address", TextBox2.Text)
            cmd.Parameters.AddWithValue("@borrowed", borrowedDate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@due", dueDate.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@title", Label5.Text)
            cmd.Parameters.AddWithValue("@isbn", Label11.Text)

            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


End Class