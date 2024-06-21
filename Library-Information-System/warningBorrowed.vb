Imports System.Net
Imports MySql.Data.MySqlClient

Public Class warningBorrowed
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public borrowedUSN As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        borrowedUSN = ""
        Me.Hide()

    End Sub

    Sub getData(isbn As String, title As String, name As String, usn As String)
        warningParagraph.Text = "name: " + name + "( " + usn + " ), title: " + title + "( " + isbn + " )."

    End Sub

    Sub deleteRowBorrowed()
        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=library_information_system_database;")
        Dim cmd As New MySqlCommand()
        Try
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DELETE FROM borrowed WHERE borrowed_id = @usnBorrowed"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usnBorrowed", borrowedUSN)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub warningBorrowed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newX As Integer = (Panel1.Width - warningParagraph.Width) / 2

        ' Set the label's Location, keeping the y-coordinate unchanged
        warningParagraph.Location = New Point(newX, warningParagraph.Location.Y)
    End Sub

    Private Sub deteleBtn_Click(sender As Object, e As EventArgs) Handles deteleBtn.Click
        deleteRowBorrowed()
        borrowedUSN = ""
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class