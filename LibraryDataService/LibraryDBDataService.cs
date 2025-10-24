using LibraryCommon;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace LibraryDataService
{
    public class LibraryDBDataService : ILibraryDataService
    {
        private static readonly string connectionString =
            "Data Source=DESKTOP-FF0FJBD\\SQLEXPRESS; Initial Catalog=librarydb; Integrated Security=True; TrustServerCertificate=True;";

        private static SqlConnection sqlConnection;

        public LibraryDBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        
        public void AddBook(Book book)
        {
            var insertStatement = @"INSERT INTO Books (BookNumber, Title, Author, Year, IsBorrowed, BorrowedBy, BorrowedDate)
                                     VALUES (@BookNumber, @Title, @Author, @Year, @IsBorrowed, @BorrowedBy, @BorrowedDate)";

            SqlCommand command = new SqlCommand(insertStatement, sqlConnection);
            command.Parameters.AddWithValue("@BookNumber", book.BookNumber);
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@Year", book.Year);
            command.Parameters.AddWithValue("@IsBorrowed", book.IsBorrowed);
            command.Parameters.AddWithValue("@BorrowedBy", book.BorrowedBy ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@BorrowedDate", book.BorrowedDate ?? (object)DBNull.Value);

            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public List<Book> GetBooks()
        {
            var books = new List<Book>();
            var query = "SELECT * FROM Books";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var book = new Book
                {
                    BookNumber = Convert.ToInt32(reader["BookNumber"]),
                    Title = reader["Title"].ToString(),
                    Author = reader["Author"].ToString(),
                    Year = Convert.ToInt32(reader["Year"]),
                    IsBorrowed = Convert.ToBoolean(reader["IsBorrowed"]),
                    BorrowedBy = reader["BorrowedBy"]?.ToString(),
                    BorrowedDate = reader["BorrowedDate"] == DBNull.Value ? null : Convert.ToDateTime(reader["BorrowedDate"])
                };
                books.Add(book);
            }

            sqlConnection.Close();
            return books;
        }

        public bool UpdateBook(Book book)
        {
            var updateStatement = @"UPDATE Books SET Title=@Title, Author=@Author, Year=@Year,
                                    IsBorrowed=@IsBorrowed, BorrowedBy=@BorrowedBy, BorrowedDate=@BorrowedDate
                                    WHERE BookNumber=@BookNumber";

            SqlCommand command = new SqlCommand(updateStatement, sqlConnection);
            command.Parameters.AddWithValue("@Title", book.Title);
            command.Parameters.AddWithValue("@Author", book.Author);
            command.Parameters.AddWithValue("@Year", book.Year);
            command.Parameters.AddWithValue("@IsBorrowed", book.IsBorrowed);
            command.Parameters.AddWithValue("@BorrowedBy", book.BorrowedBy ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@BorrowedDate", book.BorrowedDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@BookNumber", book.BookNumber);

            sqlConnection.Open();
            int rows = command.ExecuteNonQuery();
            sqlConnection.Close();
            return rows > 0;
        }

        public bool DeleteBook(int bookNumber)
        {
            var deleteStatement = "DELETE FROM Books WHERE BookNumber = @BookNumber";
            SqlCommand command = new SqlCommand(deleteStatement, sqlConnection);
            command.Parameters.AddWithValue("@BookNumber", bookNumber);

            sqlConnection.Open();
            int rows = command.ExecuteNonQuery();
            sqlConnection.Close();
            return rows > 0;
        }
    }
}