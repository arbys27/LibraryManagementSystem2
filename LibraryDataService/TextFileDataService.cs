using LibraryCommon;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryDataService
{
    public class TextFileDataService : ILibraryDataService
    {
        private readonly string filePath = "books.txt";
        private List<Book> books = new();

        public TextFileDataService()
        {
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split('|');

                    books.Add(new Book
                    {
                        BookNumber = int.Parse(parts[0]),
                        Title = parts[1],
                        Author = parts[2],
                        Year = int.Parse(parts[3]),
                    });
                }
            }
        }

        private void Save()
        {
            var lines = books.Select(b => $"{b.BookNumber}|{b.Title}|{b.Author}|{b.Year}");
            File.WriteAllLines(filePath, lines);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Save();
        }

        public List<Book> GetBooks() => books;

        public void UpdateBook(Book book)
        {
            var index = books.FindIndex(b => b.BookNumber == book.BookNumber);
            if (index != -1)
            {
                books[index] = book;
                Save();
            }
        }

        public void DeleteBook(Book book)
        {
            books.RemoveAll(b => b.BookNumber == book.BookNumber);
            Save();
        }
    }
}
