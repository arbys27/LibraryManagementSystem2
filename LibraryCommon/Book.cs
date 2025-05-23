using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCommon
{
    
        public class Book
        {
            

            public Book(int Book, string title, string author, int year)
            {
                BookNumber = Book;
                Title = title;
                Author = author;
                Year = year;
            }

            public override string ToString()
            {
                return $"Book No: {BookNumber}, Title: {Title}, Author: {Author}, Year: {Year}";
            }
            public int BookNumber { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }


    }

}

