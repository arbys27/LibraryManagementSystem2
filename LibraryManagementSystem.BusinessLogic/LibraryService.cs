using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.BusinessLogic
{
    public class LibraryService
    {

        //sadadwa
        private class Book
        {
            public int BookNumber { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

            public Book(int bookNumber, string title, string author, int year)
            {
                BookNumber = bookNumber;
                Title = title;
                Author = author;
                Year = year;
            }
        }

        private List<Book> books = new List<Book>();

        public void AddBook(int bookNumber, string title, string author, int year)
        {
            books.Add(new Book(bookNumber, title, author, year));
        }

        public List<string> GetBooks()
        {
            List<string> bookList = new List<string>();
            foreach (var book in books)
            {
                bookList.Add($"Book No: {book.BookNumber}, Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
            return bookList;
        }

        public bool UpdateBook(int bookNumber, string newTitle, string newAuthor, int newYear)
        {
            Book book = books.Find(b => b.BookNumber == bookNumber);
            if (book != null)
            {
                book.Title = newTitle;
                book.Author = newAuthor;
                book.Year = newYear;
                return true;
            }
            return false;
        }

        public bool DeleteBook(int bookNumber)
        {
            Book book = books.Find(b => b.BookNumber == bookNumber);
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            return false;
        }
    }
}

//ssad