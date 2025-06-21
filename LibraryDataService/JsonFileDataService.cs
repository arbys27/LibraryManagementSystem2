using System.Text.Json;
using LibraryCommon;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDataService
{
    public class JsonFileDataService : ILibraryDataService
    {
        private readonly string filePath = "books.json";
        List<Book> books = new List<Book>();

        public JsonFileDataService()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
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
            return new List<Book>(books);
        }

        public bool UpdateBook(Book book)
        {
            var index = books.FindIndex(b => b.BookNumber == book.BookNumber);
            if (index != -1)
            {
                books[index] = book;
                Save();
                return true;
            }
            return false;
        }

        public bool DeleteBook(int bookNumber)
        {
            var removed = books.RemoveAll(b => b.BookNumber == bookNumber) > 0;
            if (removed)
            {
                Save();
                return true;
            }
            return false;
        }

    }
}
