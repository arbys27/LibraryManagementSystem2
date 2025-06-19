using LibraryCommon;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryDataService
{
    public class TextFileDataService : ILibraryDataService
    {
        private readonly string filePath = "books.txt";
        private List<Book> books = new List<Book>();


        public TextFileDataService()
        {
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                books = lines.Select(line =>
                {
                    var parts = line.Split('|');
                    return new Book

                    {
                        BookNumber = int.Parse(parts[0]),
                        Title = parts[1],
                        Author = parts[2],
                        Year = int.Parse(parts[3]),
                    };
                }).ToList();
            }
        }

        private void SaveToFile()
        {
            var lines = books.Select(b => $"{b.BookNumber}|{b.Title}|{b.Author}|{b.Year}");
            File.WriteAllLines(filePath, lines);

        }

        public void AddBook(Book book)
        {
            books.Add(book);
            SaveToFile();
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
                SaveToFile();
                return true;
            }
            return false;
        }

        public bool DeleteBook(int bookNumber)
        {
            var removed = books.RemoveAll(b => b.BookNumber == bookNumber) > 0;
            if (removed) SaveToFile();
            
              
            return removed;
        }
    }
}
