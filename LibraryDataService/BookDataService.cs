using LibraryCommon;
using System.Collections.Generic;

namespace LibraryDataService
{
    public class BookDataService
    {
        private readonly ILibraryDataService dataService;

        public BookDataService()
        {

            dataService = new TextFileDataService(); // this is the currently used service
            //dataService = new JSonFileDataService();
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
            dataService.DeleteBook(book);
        }

        
    }
}
