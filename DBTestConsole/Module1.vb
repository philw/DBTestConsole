Imports System.Data.SQLite

Module Module1

    Public Sub Main()

        Dim dbConn As SQLiteConnection
        Dim dbCmd As SQLiteCommand
        Dim dbReader As SQLiteDataReader
        Dim SQL As String
        Dim PlaylistID As Integer
        Dim Name As String

        ' create a new database connection:
        ' the database is a file called chinook.db
        ' and it is in the bin\debug directory
        dbConn = New SQLiteConnection("Data Source=chinook.db;Version=3;")
        dbConn.Open()

        ' define our SQL statement
        SQL = "SELECT * from playlists"
        Console.WriteLine(SQL)
        Console.WriteLine()


        ' create a command
        dbCmd = dbConn.CreateCommand
        dbCmd.CommandText = SQL

        ' execute the SQL command
        dbReader = dbCmd.ExecuteReader

        While dbReader.Read
            PlaylistID = dbReader("Playlistid")
            Name = dbReader("Name")
            Console.WriteLine("id:{0} name: {1}", PlaylistID, Name)
        End While

        Console.ReadLine()

    End Sub
End Module
