using LibraryCommon;
using LibraryDataService;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace LibraryManagementSystem_Service
    {
        public static class LibraryProcess
        {
            private static readonly BookDataService bookDataService;
            private static readonly EmailService emailService;
        
        static LibraryProcess()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            bookDataService = new BookDataService();
            emailService = new EmailService(configuration);
        }

        public static List<Book> GetBooks()
            {
                return bookDataService.GetAllBooks();
            }
            public static bool PerformAction(LibraryAction action, Book book = null)
            {
                switch (action)
                {
                    case LibraryAction.Add:
                        if (book != null)
                        {
                            bookDataService.AddBook(book);
                            return true;
                        }
                        
                        break;

                    case LibraryAction.Delete:
                        if (book != null)
                        {
                            bookDataService.RemoveBook(book.BookNumber);
                        }
                        
                        break;

                    case LibraryAction.Update:
                        if (book != null)
                        {
                            bool updated = bookDataService.UpdateBook(book);
                        if (updated) 
                        {
                            emailService.SendEmail(book.BookNumber.ToString(), book.Title, "user@example.com");
                        }
                        return updated;
                    }
                    break;
                }
                return false;
            }

            public static List<string> GetAllBooks()
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
                bool updated = bookDataService.UpdateBook(book);

            if (updated) 
            {
                emailService.SendEmail(book.BookNumber.ToString(), book.Title, "user@example.com");
            }
            return updated;
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

