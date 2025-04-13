using System.Collections.Generic;

namespace LibraryManagementSystem.BusinessLogic
{
    public class LibraryProcess
    {
        public class Book
        {
            public int BookNumber { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

            public Book(int number, string title, string author, int year)
            {
                BookNumber = number;
                Title = title;
                Author = author;
                Year = year;
            }

            public override string ToString()
            {
                return $"Book No: {BookNumber}, Title: {Title}, Author: {Author}, Year: {Year}";
            }
        }

        public static List<Book> books = new List<Book>();

        public static void PerformAction(LibraryAction action, Book book = null)
        {
            switch (action)
            {
                case LibraryAction.Add:
                    if (book != null)
                        books.Add(book);
                    break;
                case LibraryAction.Delete:
                    books.RemoveAll(b => b.BookNumber == book.BookNumber);
                    break;
            }
        }

        public static List<string> GetBooks()
        {
            List<string> list = new List<string>();
            foreach (var b in books)
                list.Add(b.ToString());
            return list;
        }

        public static bool UpdateBook(int bookNumber, string title, string author, int year)
        {
            Book book = books.Find(b => b.BookNumber == bookNumber);
            if (book != null)
            {
                book.Title = title;
                book.Author = author;
                book.Year = year;
                return true;
            }
            return false;
        }

        public static Book CreateBook(int number, string title, string author, int year)
        {
            return new Book(number, title, author, year);
        }
    }
}
//ashley
