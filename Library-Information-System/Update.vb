
Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class Update
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Public Sub loadString(callNumber As String, isbn As String, title As String, author As String, publisher As String, quantity As String, category As String, published As Date)
        update_call_field.Text = callNumber
        update_isbn_field.Text = isbn
        update_title_field.Text = title
        update_author_field.Text = author
        update_publisher_field.Text = publisher
        update_quantity_field.Text = quantity
        update_category_combobox.SelectedItem = category
        update_date_field.Value = published
    End Sub

    Public Sub booksId(id As String)
        Label1.Text = id
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        update_call_field.Clear()
        update_call_field.BackColor = Color.White
        update_call_field.ForeColor = Color.Black
        update_invalid_callNumber.Text = ""
        update_title_field.Clear()
        update_author_field.Clear()
        update_isbn_field.Clear()
        Label18.BackColor = Color.White
        Label18.ForeColor = Color.Black
        Label18.Text = ""
        update_publisher_field.Clear()
        update_category_combobox.SelectedIndex = -1
        update_date_field.Value = DateTime.Now
        Update_Label.Text = ""
        update_quantity_field.Clear()
        invalid_quantity.Text = ""
        invalid_quantity.BackColor = Color.White
        invalid_quantity.ForeColor = Color.Black
        updated.Text = ""
        Label1.Text = ""

        Me.Hide()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        If Not IsNumeric(update_isbn_field.Text) AndAlso
   Not IsNumeric(update_quantity_field.Text) AndAlso
   String.IsNullOrEmpty(Trim(update_call_field.Text)) Then

            update_isbn_field.ForeColor = Color.FromArgb(&H56, 0, 0)
            update_isbn_field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Label18.Text = "Field cannot be empty."
            update_call_field.ForeColor = Color.FromArgb(&H56, 0, 0)
            update_call_field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            update_invalid_callNumber.Text = "Please enter a valid number"
            update_quantity_field.ForeColor = Color.FromArgb(&H56, 0, 0)
            update_quantity_field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_quantity.Text = "Please enter a valid number"
        ElseIf String.IsNullOrEmpty(Trim(update_call_field.Text)) Then
            update_call_field.ForeColor = Color.FromArgb(&H56, 0, 0)
            update_call_field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            update_invalid_callNumber.Text = "Field cannot be empty."
        ElseIf Not IsNumeric(update_isbn_field.Text) Then
            update_isbn_field.ForeColor = Color.FromArgb(&H56, 0, 0)
            update_isbn_field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Label18.Text = "Please enter a valid number"
        ElseIf Not IsNumeric(update_quantity_field.Text) Then
            update_quantity_field.ForeColor = Color.FromArgb(&H56, 0, 0)
            update_quantity_field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_quantity.Text = "Please enter a valid number"
        ElseIf IsNumeric(update_isbn_field.Text) AndAlso IsNumeric(update_quantity_field.Text) AndAlso Not String.IsNullOrEmpty(Trim(update_call_field.Text)) Then
            updated.Text = "Updated"
            updateTable()


        End If
    End Sub
    Sub updateTable()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()

        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE books SET call_number = @callnumber, title = @title, category = @category, author = @author, isbn = @isbn, publisher = @publisher, published = @published, quantity = @quantity WHERE book_id = @booksId"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@callnumber", update_call_field.Text)
            cmd.Parameters.AddWithValue("@title", update_title_field.Text)
            cmd.Parameters.AddWithValue("@category", update_category_combobox.SelectedItem)
            cmd.Parameters.AddWithValue("@author", update_author_field.Text)
            cmd.Parameters.AddWithValue("@isbn", update_isbn_field.Text)
            cmd.Parameters.AddWithValue("@publisher", update_publisher_field.Text)
            cmd.Parameters.AddWithValue("@published", update_date_field.Value.Date)
            cmd.Parameters.AddWithValue("@quantity", update_quantity_field.Text)
            cmd.Parameters.AddWithValue("@booksId", Label1.Text)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
