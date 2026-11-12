
using Microsoft.Data.Sqlite;

namespace OefLes1;

public class Tables
{
    using Microsoft.Data.Sqlite;
    string sql = @"CREATE TABLE IF NOT EXISTS Gebruikers (
    id INTEGER PRIMARY KEY,
    naam TEXT NOT NULL,
    leeftijd INTEGER
)";

        using var connection = new SqliteConnection("Data Source=mijnDatabase.db");
    connection.Open();

    using var command = new SqliteCommand(sql, connection);
    command.ExecuteNonQuery();

    Console.Writeline("Tabel aangemaakt!");
}