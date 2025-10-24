using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public class BookDataService
    {
        private ILibraryDataService dataService;

        public BookDataService()
        {

           // dataService = new TextFileDataService();
           //dataService = new JsonFileDataService();
             dataService = new LibraryDBDataService();
        }

        public List<Book> GetAllBooks()
        {
            return dataService.GetBooks();
        }

        public void AddBook(Book book)
        {
            dataService.AddBook(book);
        }

        public bool UpdateBook(Book book)
        {
            return dataService.UpdateBook(book);   
        }

        public bool RemoveBook(int bookNumber)
        {
            return dataService.DeleteBook(bookNumber);
        }

        
    }
}
