Imports MySql.Data.MySqlClient

Public Class warningUser
    Public userUSN As String
    Private Sub warningUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub loadUserWarningParagraph(name As String, usn As String)
        warningParagraph.Text = "name:" + name + "(USN:" + usn + ")"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userUSN = ""
        Me.Hide()
    End Sub

    Private Sub deteleBtn_Click(sender As Object, e As EventArgs) Handles deteleBtn.Click
        deleteRowUser()
        userUSN = ""
        Me.Hide()
    End Sub

    Sub deleteRowUser()
        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=library_information_system_database;")
        Dim cmd As New MySqlCommand()
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM user_credentials WHERE user_usn = @userUSN"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@userUSN", userUSN)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub
End Class