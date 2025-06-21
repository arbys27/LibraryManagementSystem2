using LibraryCommon;
using LibraryDataService;
using System.Collections.Generic;

namespace LibraryManagementSystem_Service
{
    public static class LibraryProcess
    {

        static BookDataService bookDataService = new BookDataService();

        public static void PerformAction(LibraryAction action, Book book = null)
        {
            switch (action)
            {
                case LibraryAction.Add:
                    if (book != null)
                        bookDataService.AddBook(book);
                    break;

                case LibraryAction.Delete:
                    if (book != null)
                        bookDataService.RemoveBook(book.BookNumber);
                    break;

                case LibraryAction.Update:
                    if (book != null)
                        bookDataService.UpdateBook(book);
                    break;
            }
        }

        public static List<string> GetBooks()
        {
            var books = bookDataService.GetAllBooks();
            List<string> list = new List<string>();
            foreach (var b in books)
                list.Add(b.ToString());
            return list;
        }

        public static bool UpdateBook(int bookNumber, string title, string author, int year)
        {
            var book = new Book 
            {
                BookNumber = bookNumber,
                Title = title,
                Author = author,
                Year = year
            };
            return bookDataService.UpdateBook(book);
        }

        public static bool BorrowBook(int bookNumber, string borrower)
        {
            var book = bookDataService.GetAllBooks().FirstOrDefault(b => b.BookNumber == bookNumber);
            if (book != null && !book.IsBorrowed)
            {
                book.IsBorrowed = true;
                book.BorrowedBy = borrower;
                book.BorrowedDate = DateTime.Now;
                return bookDataService.UpdateBook(book);
            }
            return false;
        }

        public static bool ReturnBook(int bookNumber)
        {
            var book = bookDataService.GetAllBooks().FirstOrDefault(b => b.BookNumber == bookNumber);
            if (book != null && book.IsBorrowed)
            {
                book.IsBorrowed = false;
                book.BorrowedBy = string.Empty;
                book.BorrowedDate = null;
                return bookDataService.UpdateBook(book);
            }
            return false;
        }

        public static Book CreateBook(int number, string title, string author, int year)
        {
            return new Book
            {
                BookNumber = number,
                Title = title,
                Author = author,
                Year = year,
                IsBorrowed = false,
                BorrowedBy = string.Empty,
                BorrowedDate = null
            };
        }
    }


}

