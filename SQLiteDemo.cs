using Microsoft.Data.Sqlite;

namespace OefLes1;

public class SQLiteDemo
{
    public class open
    {
         SqliteConnection _connection;
         SqliteConnection connection = new SqliteConnection("Data Source=\"C:\\Users\\arthu\\Documents\\SQLITE\\chinook.db\"");
         connection.Open();
         connection.Close();
         
         SqliteConnection connection = new SqliteConnection("Data Source=databaseFile");
         connection.Open();
         connection.Close();
         
         using SqliteConnection connection = new SqliteConnection("Data Source=databaseFile");
         connection.Open();
         
         
    }
   
}

internal class connection
{
    public class Open
    {
    }

    public class Close
    {
    }
}