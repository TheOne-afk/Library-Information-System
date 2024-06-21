Imports MySql.Data.MySqlClient

Public Class insertUser
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Private Sub insertUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        added_Label.Text = ""
    End Sub

    Private Sub update_Btn_Click(sender As Object, e As EventArgs) Handles update_Btn.Click
        If String.IsNullOrEmpty(Trim(usn_Field.Text)) Then
            usn_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            usn_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_usn.Text = "Field cannot be empty."
        ElseIf String.IsNullOrEmpty(Trim(password_Field.Text)) Then
            password_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            password_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            Invalid_pass.Text = "Field cannot be empty."
        ElseIf String.IsNullOrEmpty(Trim(section_Field.Text)) Then
            section_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            section_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_section.Text = "Field cannot be empty."
        ElseIf String.IsNullOrEmpty(Trim(name_Field.Text)) Then
            name_Field.ForeColor = Color.FromArgb(&H56, 0, 0)
            name_Field.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
            invalid_name.Text = "Field cannot be empty."
        Else
            added_Label.Text = "User added"
            insertUser()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        invalid_usn.Text = ""
        Invalid_pass.Text = ""
        invalid_section.Text = ""
        invalid_name.Text = ""
        usn_Field.Clear()
        password_Field.Clear()
        section_Field.Clear()
        name_Field.Clear()
        usn_Field.BackColor = Color.White
        password_Field.BackColor = Color.White
        section_Field.BackColor = Color.White
        name_Field.BackColor = Color.White
        usn_Field.ForeColor = Color.Black
        password_Field.ForeColor = Color.Black
        section_Field.ForeColor = Color.Black
        name_Field.ForeColor = Color.Black
        added_Label.Text = ""
        Me.Hide()

    End Sub

    Sub insertUser()
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()

        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO user_credentials (user_usn, user_password, user_section, user_name) VALUES (@userUSN, @userPassword, @userSection, @userName)"
            cmd.Parameters.AddWithValue("@userUSN", usn_Field.Text)
            cmd.Parameters.AddWithValue("@userPassword", password_Field.Text)
            cmd.Parameters.AddWithValue("@userSection", section_Field.Text)
            cmd.Parameters.AddWithValue("@userName", name_Field.Text)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Panel27_Paint(sender As Object, e As PaintEventArgs) Handles Panel27.Paint

    End Sub
End Class