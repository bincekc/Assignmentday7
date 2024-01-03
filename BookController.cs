using AssignmentApiBook.Models;
using AssignmentApiBook.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentApiBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        //AddBook()
        [HttpPost]
        [Route("AddBook")]
        public IActionResult AddBook(Book book)
        {
            try
            {
                _bookRepository.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception)
            {

                throw;
            }
        }
        // GetAllBooks()
        [HttpGet]
        [Route("GetAllBooks")]
        public IActionResult GetAllBooks()
        {
            try
            {
                return StatusCode(200, _bookRepository.GetAllBooks());

            }
            catch (Exception)
            {

                throw;
            }
        }
        //GetBooksByAuthor(string Author)
        [HttpGet]
        [Route("GetBooksByAuthor/{Author}")]
        public IActionResult GetBooksByAuthor(string Author)
        {
            try
            {
                return StatusCode(200, _bookRepository.BookByAuthor(Author));

            }
            catch (Exception)
            {

                throw;
            }
        }
        //GetBooksByLang(string lang)
        [HttpGet]
        [Route("GetBooksByLang/{lang}")]
        public IActionResult GetBooksByLang(string lang)
        {
            try
            {
                return StatusCode(200, _bookRepository.GetBookByLang(lang));

            }
            catch (Exception)
            {

                throw;
            }
        }
        //GetBooksByYear(int year)
        [HttpGet]
        [Route("GetBooksByYear/{year}")]
        public IActionResult GetBooksByYear(int year)
        {
            try
            {
                return StatusCode(200, _bookRepository.GetBookByyear(year));

            }
            catch (Exception)
            {

                throw;
            }
        }
        //EditBook()
        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                _bookRepository.UpdateBook(book);
                return StatusCode(200, "Updated Succesfully");

            }
            catch (Exception)
            {

                throw;
            }
        }
        //DeleteBook(int bookId)
        [HttpDelete]
        [Route("DeleteBook")]
        public IActionResult DeleteBook(int bookId)
        {
            try
            {
                _bookRepository.DeleteBook(bookId);
                return StatusCode(200, "Deleted Succesfully");

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
   

