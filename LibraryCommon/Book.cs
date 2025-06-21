using System;

namespace LibraryCommon
{
    public class Book
    {
       
        public int BookNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Year { get; set; }

        public bool IsBorrowed { get; set; } = false;
        public string BorrowedBy { get; set; } = string.Empty;
        public DateTime? BorrowedDate { get; set; } = null;



        public Book() { }

        public Book(int bookNumber, string title, string author, int year)
        {
            BookNumber = bookNumber;
            Title = title;
            Author = author;
            Year = year;

            IsBorrowed = false;
            BorrowedBy = string.Empty;
            BorrowedDate = null;
        }

        public override string ToString()
        {
            var status = IsBorrowed ? $"[BORROWED by {BorrowedBy} on {BorrowedDate?.ToString("g")}" : "[AVAILABLE]";
            return $"Book No: {BookNumber}, Title: {Title}, Author: {Author}, Year: {Year} {status}";
        }
    }
}
