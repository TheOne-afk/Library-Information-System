
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form1
    ' [ Private ] | This keyword specifies the access level of the variable.
    '               means that the variable is accessible only within the scope of the class where it is declared.
    '               Other classes cannot access.
    Private db As db_connection
    Dim Mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Dim Form3 As New Admin_Dashboard
    Dim userForm As New User_Dashboard
    ' ========= LOGIN FORM ============
    Private Sub Form2(sender As Object, e As EventArgs) Handles MyBase.Load
        ' calls the constructor of the "db_connection"
        db = New db_connection
        ' method of the "db_connection"
        db.connection()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.ExitThread()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Mysqlcon = New MySqlConnection
        Mysqlcon.ConnectionString = "server=localhost; database=library_information_system_database; username=root; password=;"
        Dim reader As MySqlDataReader

        Try
            Mysqlcon.Open()
            Dim loginQuery As String
            loginQuery = "SELECT 'admin' AS userType, admin_username AS username, admin_password AS password FROM admin_credentials WHERE admin_username=@username AND admin_password=@password " &
                     "UNION SELECT 'user' AS userType, user_usn AS username, user_password AS password FROM user_credentials WHERE user_usn=@userUSN AND user_password=@userPassword"

            Dim command As MySqlCommand = New MySqlCommand(loginQuery, Mysqlcon)
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtPassword.Text)
            command.Parameters.AddWithValue("@userUSN", txtUsername.Text)
            command.Parameters.AddWithValue("@userPassword", txtPassword.Text)
            reader = command.ExecuteReader

            Dim userType As String = String.Empty

            If reader.Read() Then
                userType = reader("userType").ToString()
            End If

            If Not String.IsNullOrEmpty(userType) Then
                If userType = "admin" Then
                    Form3.Show() ' Show admin dashboard
                ElseIf userType = "user" Then
                    userForm.getUSN = txtUsername.Text
                    userForm.Show() ' Show user dashboard
                End If
                Me.Hide()
            Else
                txtPassword.ForeColor = Color.FromArgb(&H56, 0, 0)
                txtPassword.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
                txtUsername.ForeColor = Color.FromArgb(&H56, 0, 0)
                txtUsername.BackColor = Color.FromArgb(&HFF, &HE6, &HE6)
                Invalid.Text = "Incorrect credentials"
            End If

            Mysqlcon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlcon.Dispose()
        End Try
    End Sub


    Private Sub txtUsername_Paint(sender As Object, e As PaintEventArgs)
        ' Draw a custom border around the TextBox
        Dim borderRectangle As Rectangle = New Rectangle(0, 0, txtUsername.Width - 1, txtUsername.Height - 1)
        ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "•"
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class