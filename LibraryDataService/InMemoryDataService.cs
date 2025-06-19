using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public class InMemoryDataService : ILibraryDataService
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book) => books.Add(book);

        public List<Book> GetBooks() => new List<Book>(books);

        public bool UpdateBook(Book updatedBook)
        {
            var index = books.FindIndex(b => b.BookNumber == updatedBook.BookNumber);
            if (index != -1)
            {
                books[index] = updatedBook;
                return true;
            }
            return false;
                
        }
        public bool DeleteBook(int bookNumber)
        {
            var removed = books.RemoveAll(b => b.BookNumber == bookNumber) > 0;
            return removed;
        }
        
    }
}
