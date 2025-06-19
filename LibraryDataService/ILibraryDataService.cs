using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public interface ILibraryDataService
    {
        void AddBook(Book book);
        List<Book> GetBooks();
        bool UpdateBook(Book book);
        bool DeleteBook(int bookNumber);

    }
}
