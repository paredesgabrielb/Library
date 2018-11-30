using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Domain;
using Library.EntityFramework;
using Library.Application.Shared;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookAppServices _bookAppServices;

        public BooksController(IBookAppServices context)
        {
            _bookAppServices = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookAppServices.GetAllBooks();
        }

        //// GET: api/Books/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetBook([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var book = await _bookAppServices.Books.FindAsync(id);

        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(book);
        //}

        //// PUT: api/Books/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutBook([FromRoute] int id, [FromBody] Book book)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != book.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _bookAppServices.Entry(book).State = EntityState.Modified;

        //    try
        //    {
        //        await _bookAppServices.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BookExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Books
        //[HttpPost]
        //public async Task<IActionResult> PostBook([FromBody] Book book)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _bookAppServices.Books.Add(book);
        //    await _bookAppServices.SaveChangesAsync();

        //    return CreatedAtAction("GetBook", new { id = book.Id }, book);
        //}

        //// DELETE: api/Books/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteBook([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var book = await _bookAppServices.Books.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    _bookAppServices.Books.Remove(book);
        //    await _bookAppServices.SaveChangesAsync();

        //    return Ok(book);
        //}

        //private bool BookExists(int id)
        //{
        //    return _bookAppServices.Books.Any(e => e.Id == id);
        //}
    }
}