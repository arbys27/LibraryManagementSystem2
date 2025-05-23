using LibraryCommon;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDataService
{
    public class InMemoryDataService : ILibraryDataService
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);
        public List<Book> GetBooks() => books;
        public void UpdateBook(Book updatedBook)
        {
            var index = books.FindIndex(b => b.BookNumber == updatedBook.BookNumber);
            if (index != -1) books[index] = updatedBook;
        }
        public void DeleteBook(Book book)
        {
            books.RemoveAll(b => b.BookNumber == book.BookNumber);
        }
        
    }
}
