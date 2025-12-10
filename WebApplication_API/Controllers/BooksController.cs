using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_API.Data;
using WebApplication_API.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApplication_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //static private List<Book> books = new List<Book>
        //    {
        //        new Book
        //        {
        //            Id = 1,
        //            Title = "The Great Gatsby",
        //            Author = "F. Scott Fitzgerald",
        //            YearPublished = 1925
        //        },

        //        new Book
        //        {
        //            Id = 2,
        //            Title = "To Kill a Mockingbird",
        //            Author = "Harper Lee",
        //            YearPublished = 1960
        //        },

        //        new Book
        //        {
        //            Id = 3,
        //            Title = "1984",
        //            Author = "George Orwell",
        //            YearPublished = 1949
        //        },

        //        new Book
        //        {
        //            Id = 4,
        //            Title = "Pride and Prejudice",
        //            Author = "Jane Austen",
        //            YearPublished = 1813
        //        },

        //        new Book
        //        {
        //            Id = 5,
        //            Title = "The Hobbit",
        //            Author = "J.R.R. Tolkien",
        //            YearPublished = 1937
        //        },

        //        new Book
        //        {
        //            Id = 6,
        //            Title = "Moby-Dick",
        //            Author = "Herman Melville",
        //            YearPublished = 1851
        //        },

        //        new Book
        //        {
        //            Id = 7,
        //            Title = "Brave New World",
        //            Author = "Aldous Huxley",
        //            YearPublished = 1932
        //        },

        //        new Book
        //        {
        //            Id = 8,
        //            Title = "The Catcher in the Rye",
        //            Author = "J.D. Salinger",
        //            YearPublished = 1951
        //        },

        //        new Book
        //        {
        //            Id = 9,
        //            Title = "War and Peace",
        //            Author = "Leo Tolstoy",
        //            YearPublished = 1869
        //        },

        //        new Book
        //        {
        //            Id = 10,
        //            Title = "Crime and Punishment",
        //            Author = "Fyodor Dostoevsky",
        //            YearPublished = 1866
        //        }

        //    };

        private readonly FirstapiContext _context;
        public BooksController(FirstapiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return Ok(await _context.Books.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book newbook)
        {
            if (newbook == null)
            {
                return BadRequest();
            }
            _context.Books.Add(newbook);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBookById), new { id = newbook.Id }, newbook);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBook(int id, Book updatebook)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            book.Id = updatebook.Id;
            book.Title = updatebook.Title;
            book.Author = updatebook.Author;
            book.YearPublished = updatebook.YearPublished;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

