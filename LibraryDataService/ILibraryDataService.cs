using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public interface ILibraryDataService
    {
        public void AddBook(Book book);
        List<Book> GetBooks();
        public bool UpdateBook(Book book);
        public bool DeleteBook(Book book);

    }
}
