using Microsoft.Data.Sqlite;

namespace OefLes1;

public class sqll
{
using Microsoft.Data.Sqlite;

var sql = "INSERT INTO authors (first_name, last_name) " +
          "VALUES (@first_name, @last_name)";

var firstName = "Jane";
var lastName = "Doe";

try
{
    using var connection = new SqliteConnection(@"Data Source=C:\db\pub.db");
    connection.Open();

    
    using var command = new SqliteCommand(sql, connection);

    command.Parameters.AddWithValue("@first_name", firstName);
    command.Parameters.AddWithValue("@last_name", lastName);

    
    var rowInserted = command.ExecuteNonQuery();

    Console.WriteLine($"The author '{firstName} {lastName}' has been created successfully.");


}
catch (SqliteException ex)
{
    Console.WriteLine(ex.Message);
}
}