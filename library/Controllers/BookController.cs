using library_.Dtos;
using library_.Interface;
using library_.Reposatories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace library_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }
        [HttpGet("id")]
        public IActionResult GetBookById(int id)
        {
            var Book = _book.GetBookById(id);
            if (Book == null) { return NotFound(); }
            return Ok(Book);
        }

        [HttpPost]
        public IActionResult AddBookk(BookDtos bookdto)
        {
            _book.AddBooks(bookdto);
            return Ok(bookdto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, BookDtos bookdto) 
        {
            _book.updateBooks(bookdto, id);
            return Ok(bookdto);
        }

        [HttpGet]
        public IActionResult GetAllBooks(BookDtos bookDtos) 
        {
             var books = _book.GetAllBooks();
            return Ok(books);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book  = _book.GetBookById(id);
            if (book == null) 
            {
              return  NotFound(new {Message ="Book Not Found" });
            }
            _book.DeletBook(id);
            return Ok(new { Message = "Book Deleted Sucsesfully" });
            

        }


    }
}
