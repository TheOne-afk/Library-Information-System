Imports MySql.Data.MySqlClient

Public Class Insert
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Private Sub Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub insert_Btn_Click(sender As Object, e As EventArgs) Handles update_Btn.Click
        If Not IsNumeric(isbn_Field.Text) AndAlso
   Not IsNumeric(Quantity_Field.Text) AndAlso
   String.IsNullOrEmpty(Trim(call_Field.Text)) Then

            isbn_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            isbn_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_Call.Text = "Field cannot be empty."
            call_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            call_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Invalid_Isbn.Text = "Please enter a valid number"
            Quantity_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            Quantity_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_quantity.Text = "Please enter a valid number"
        ElseIf Not IsNumeric(Quantity_Field.Text) And Not IsNumeric(isbn_Field.Text) Then
            isbn_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            isbn_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Invalid_Isbn.Text = "Please enter a valid number"
            Quantity_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            Quantity_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_quantity.Text = "Please enter a valid number"
        ElseIf Not IsNumeric(Quantity_Field.Text) And String.IsNullOrEmpty(Trim(call_Field.Text)) Then
            call_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            call_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_Call.Text = "Field cannot be empty."
            Quantity_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            Quantity_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_quantity.Text = "Please enter a valid number"
        ElseIf String.IsNullOrEmpty(Trim(call_Field.Text)) And Not IsNumeric(isbn_Field.Text) Then
            call_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            call_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_Call.Text = "Field cannot be empty."
            isbn_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            isbn_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Invalid_Isbn.Text = "Please enter a valid number"
        ElseIf String.IsNullOrEmpty(Trim(call_Field.Text)) Then
            call_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            call_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_Call.Text = "Field cannot be empty."
        ElseIf Not IsNumeric(isbn_Field.Text) Then
            isbn_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            isbn_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Invalid_Isbn.Text = "Please enter a valid number"
        ElseIf Not IsNumeric(Quantity_Field.Text) Then
            Quantity_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            Quantity_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_quantity.Text = "Please enter a valid number"
        ElseIf IsNumeric(isbn_Field.Text) AndAlso IsNumeric(Quantity_Field.Text) AndAlso Not String.IsNullOrEmpty(Trim(call_Field.Text)) Then
            added_Label.Text = "Added"
            insertBook()

        End If
    End Sub
    Sub insertBook()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO books (`call_number`, `title`, `category`, `author`, `isbn`, `publisher`, `published`, `quantity`) VALUES (@callnumber, @title, @category, @author, @isbn, @publisher, @published, @quantity)"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@callnumber", call_Field.Text)
            cmd.Parameters.AddWithValue("@title", title_Field.Text)
            cmd.Parameters.AddWithValue("@category", category_ComboBox.SelectedItem)
            cmd.Parameters.AddWithValue("@author", author_Field.Text)
            cmd.Parameters.AddWithValue("@isbn", isbn_Field.Text)
            cmd.Parameters.AddWithValue("@publisher", publisher_Field.Text)
            cmd.Parameters.AddWithValue("@published", published_Date.Value.Date)
            cmd.Parameters.AddWithValue("@quantity", Quantity_Field.Text)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        call_Field.Clear()
        call_Field.BackColor = Color.White
        call_Field.ForeColor = Color.Black
        invalid_Call.Text = ""
        title_Field.Clear()
        author_Field.Clear()
        isbn_Field.Clear()
        isbn_Field.BackColor = Color.White
        isbn_Field.ForeColor = Color.Black
        Invalid_Isbn.Text = ""
        publisher_Field.Clear()
        category_ComboBox.SelectedIndex = -1
        published_Date.Value = DateTime.Now
        added_Label.Text = ""
        Quantity_Field.Clear()
        invalid_quantity.Text = ""
        Quantity_Field.BackColor = Color.White
        Quantity_Field.ForeColor = Color.Black

        Me.Hide()

    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint

    End Sub

    Private Sub category_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles category_ComboBox.SelectedIndexChanged

    End Sub
End Class