Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class borrowed_Edit
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand

    Private Sub borrowed_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newX As Integer = (Panel2.Width - Label2.Width) / 2

        ' Set the label's Location, keeping the y-coordinate unchanged
        Label2.Location = New Point(newX, Label2.Location.Y)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Sub borrowedUpdate(name As String, usn As String, borrowed_id As String)
        Label2.Text = "Updating status: name: " + name + " (USN: " + usn + ")"
        Label4.Text = borrowed_id
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Label4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE borrowed SET status = 'Returned' WHERE borrowed_id = @usnReturned"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usnReturned", Label4.Text)
            cmd.ExecuteNonQuery()

            Label4.Text = ""
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE borrowed SET status = 'Not returned' WHERE borrowed_id = @usnNotReturned"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usnNotReturned", Label4.Text)
            cmd.ExecuteNonQuery()

            Label4.Text = ""
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE borrowed SET status = 'Borrowing' WHERE borrowed_id = @usnBorrowing"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usnBorrowing", Label4.Text)
            cmd.ExecuteNonQuery()

            Label4.Text = ""
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE borrowed SET status = 'Lost' WHERE borrowed_id = @usnNotReturned"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usnNotReturned", Label4.Text)
            cmd.ExecuteNonQuery()

            Label4.Text = ""
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con.ConnectionString = ("server=localhost; database=library_information_system_database; username=root; password=;")
        con.Open()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE borrowed SET status = 'Damaged' WHERE borrowed_id = @usnNotReturned"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@usnNotReturned", Label4.Text)
            cmd.ExecuteNonQuery()

            Label4.Text = ""
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub
End Class