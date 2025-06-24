using LibraryDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryCommon;

namespace LibraryController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrarySystemController : ControllerBase
    {
        private readonly LibraryDBDataService _dataService = new();

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return _dataService.GetBooks();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _dataService.AddBook(book);
            return Ok(new { message = "Book added successfully." });
        }

        [HttpPatch]
        public IActionResult UpdateBook([FromBody] Book book)
        {
            bool result = _dataService.UpdateBook(book);
            return result ? Ok("Updated") : NotFound("Book not found");
        }

        [HttpDelete("{bookNumber}")]
        public IActionResult DeleteBook(int bookNumber)
        {
            bool result = _dataService.DeleteBook(bookNumber);
            return result ? Ok("Deleted") : NotFound("Book not found");
        }
    }
}
