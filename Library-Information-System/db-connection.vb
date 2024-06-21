' ======= START OF DOWNLOADING MYSQL.DATA =========
' In default you it'll be an error sence you don't have the Mysql.Data downloaded.
' [ Step #1: Download ] | To download he "Mysql.Dat" you have to go to this link: https://www.nuget.org/packages/MySql.Data#usedby-body-tab
' [ Step #2] | After you go to that link find and then click the ".NET CLI" and then copy the command line.
' [ Step #3 ] | Now that you copied go to command prompt and go to your project directory and then you paste the line there.
' [ Step #4 ] | Now that you paste you press the Enter key to install to your system
' [ Tip #1 ] | If it doesn't work then the directory is wrong it. To check if you are in the right directory
'              you must have seen the bin folder.
' ========  END OF DOWNLOADING MYSQ.DATA =========


' Importing the Mysql.Data.
Imports MySql.Data.MySqlClient

Public Class db_connection

    ' Assigning Variables to connection and command
    Public con As MySqlConnection
    Public cm As MySqlCommand

    ' Assigning connection substance
    Sub connection()

        ' using the try catch except the error
        Try
            ' Connecting to our database ( XAMPP )
            con = New MySqlConnection("server=localhost; database=library_information_system_database; username=root; password=;")
            ' Opening the database
            con.Open()
            ' Sending Information that the database is succesfully
        Catch ex As Exception
            ' Getting the exception
            MsgBox(" connection failed! ")
        End Try

    End Sub

End Class