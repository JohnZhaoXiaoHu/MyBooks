using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBooks.Models;
using WebApiBooks.RepopsitoryContracts;

namespace WebApiBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository<Book> _bookRepository;

        public BookController(IBookRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Book> books = _bookRepository.GetAll();
            return Ok(books);
        }
        [HttpGet("{id}",Name="Get")]
        public IActionResult Get(int id)
        {
            Book book = _bookRepository.Get(id);
            
            if(book==null)
            {
                return NotFound("The book record couldn't be found.");
            }
            return Ok(book);            
        }
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            if(book==null)
            {
                return BadRequest("Book is null");
            }

            _bookRepository.Add(book);
            return CreatedAtRoute(
                "Get",
                new { Id = book.BookId },
                book);
        }
        [HttpPut("{Id}")]
        public IActionResult Put(int id, [FromBody] Book book)
        {
            if(book==null)
            {
                return BadRequest("Book is null.");
            }
            Book bookToUpdate = _bookRepository.Get(id);
            if(bookToUpdate == null)
            {
                return NotFound("The book record couldn't be found.");
            }

            _bookRepository.Update(bookToUpdate, book);
            return NoContent();
        }

        public IActionResult Delete(int id)
        {
            Book book = _bookRepository.Get(id);
            if(book==null)
            {
                return NotFound("The Book recordn't be found.");
            }
            _bookRepository.Delete(book);
            return NoContent();
        }
    }
}