using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public interface ILibraryDataService
    {
        public void AddBook(Book book);
        List<Book> GetBooks();
        public void UpdateBook(Book book);
        void DeleteBook(Book book);
        
    }
}
