using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public class BookDataService
    {
        ILibraryDataService dataService;

        public BookDataService()
        {

           // dataService = new TextFileDataService();
           dataService = new JsonFileDataService();
            //dataService = new LibraryDBDataService();
        }

        public List<Book> GetAllBooks()
        {
            return dataService.GetBooks();
        }

        public void AddBook(Book book)
        {
            dataService.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            dataService.UpdateBook(book);   
        }

        public void RemoveBook(Book book)
        {
            dataService.DeleteBook(book.BookNumber);
        }

        
    }
}
