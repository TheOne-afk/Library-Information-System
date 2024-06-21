Imports MySql.Data.MySqlClient

Public Class warning

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public bookId As String
    Sub deleteRow()
        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=library_information_system_database;")
        Dim cmd As New MySqlCommand()

        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM books WHERE book_id = @bookId"
            cmd.Parameters.AddWithValue("@bookId", bookId)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub deleteLoadString(callNumber As String, title As String, quantity As String, isbn As String)
        warningParagraph.Text = "Call Number: (" + callNumber + "), Title: (" + title + "), Quantity: (" + quantity + "), ISBN: (" + isbn + ")."
    End Sub

    Private Sub warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newX As Integer = (Panel1.Width - warningParagraph.Width) / 2
        warningParagraph.Location = New Point(newX, warningParagraph.Location.Y)
    End Sub

    Private Sub deteleBtn_Click(sender As Object, e As EventArgs) Handles deteleBtn.Click
        deleteRow()
        bookId = ""
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class