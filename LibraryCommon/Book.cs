using System;

namespace LibraryCommon
{
    public class Book
    {
       
        public int BookNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Year { get; set; }

        public Book() { }

        public Book(int bookNumber, string title, string author, int year)
        {
            BookNumber = bookNumber;
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"Book No: {BookNumber}, Title: {Title}, Author: {Author}, Year: {Year}";
        }
    }
}
