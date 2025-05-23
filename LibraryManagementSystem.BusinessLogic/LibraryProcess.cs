using LibraryDataService;
using System.Collections.Generic;

namespace LibraryManagementSystem_Service
{
    public static class LibraryProcess
    {

        static BookDataService bookDataService = new BookDataService();

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

