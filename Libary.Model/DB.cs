using System.Data;
using Microsoft.Data.Sqlite;
namespace Libary.Model;
public static class DB
{
    private const string connectionstring = "Data Source=books.db;";
    public static List<Book> GetBooks()
    {
        var book = new List<Book>();
        var db = new SqliteConnection(connectionstring);
        db.Open();
        var sql = "SELECT Id,title,Author,genre FROM table_books";
        var command = new SqliteCommand(sql, db);
        var result = command.ExecuteReader();
        if (result.HasRows)
        {
            while (result.Read())
            {
                book.Add(new Book()
                {
                    Id = result.GetInt32("Id"),
                    Title = result.GetString("title"),
                    Author = result.GetString("Author"),
                    Genre = result.GetString("genre")
                });
            }
        }
        db.Close();
        return book;
    }
 
    public static void AddBook(Book book)
    {
        var db = new SqliteConnection(connectionstring);
        db.Open();
        var sql = $"INSERT INTO table_books (title,Author,genre) VALUES ('{book.Title}','{book.Author}','{book.Genre}')";
        var command = new SqliteCommand(sql, db);
        command.ExecuteNonQuery();
        db.Close();
    }
    public static void UpdateBook(Book book)
    {
        var db = new SqliteConnection(connectionstring);
        db.Open();
        var sql = $"UPDATE table_books SET title = '{book.Title}',Autor = '{book.Author}',genre = '{book.Genre}' WHERE id = {book.Id}";
        var command = new SqliteCommand(sql, db);
        command.ExecuteNonQuery();
        db.Close();
    }

    public static void DeleteBook(int Id)
    {
        var db = new SqliteConnection(connectionstring);
        db.Open();
        var sql = $"DELETE FROM table_books WHERE Id = {Id}";
        var command = new SqliteCommand(sql, db);
        command.ExecuteNonQuery();
        db.Close();
    }
}