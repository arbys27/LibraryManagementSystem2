using System.Text.Json;
using LibraryCommon;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDataService
{
    public class JsonFileDataService : ILibraryDataService
    {
        string filePath = "books.json";
        List<Book> books = new List<Book>();

        public JsonFileDataService()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var loadedBooks = JsonSerializer.Deserialize<List<Book>>(json);
                if (loadedBooks != null)
                {
                    books = loadedBooks;
                }
            }
        }

        private void Save()
        {
            var json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Save();
        }

        public List<Book> GetBooks()
        {
            return books;
        }

        public void UpdateBook(Book book)
        {
            var index = books.FindIndex(b => b.BookNumber == book.BookNumber);
            if (index != -1)
            {
                books[index] = book;
                Save();
            }
        }

        public void DeleteBook(int bookNumber)
        {
            books.RemoveAll(b => b.BookNumber == bookNumber);
            Save();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
