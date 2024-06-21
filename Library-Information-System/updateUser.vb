Imports MySql.Data.MySqlClient

Public Class updateUser
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public getUserUSN As String
    Private Sub updateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub updateTable()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()

        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE user_credentials SET user_usn = @userUSN, user_password = @userPassword, user_section = @userSection, user_name = @userName WHERE user_usn = @userGetUSN"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@userUSN", usn_Field.Text)
            cmd.Parameters.AddWithValue("@userPassword", password_Field.Text)
            cmd.Parameters.AddWithValue("@userSection", section_Field.Text)
            cmd.Parameters.AddWithValue("@userName", name_Field.Text)
            cmd.Parameters.AddWithValue("@userGetUSN", getUserUSN)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getUserUSN = ""
        Me.Hide()
    End Sub

    Public Sub getData(usn As String, password As String, section As String, name As String)
        usn_Field.Text = usn
        password_Field.Text = password
        section_Field.Text = section
        name_Field.Text = name
    End Sub

    Private Sub update_Btn_Click(sender As Object, e As EventArgs) Handles update_Btn.Click
        updateTable()
        added_Label.Text = "Updated"
    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint

    End Sub
End Class