using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = bookService.GetAllEntities();
            if (values==null)
                return NotFound();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var data = bookService.GetEntityById(id);
            if(data==null)
                return NotFound();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Add(BookCreatedVM book)
        {
            Book created = new Book()
            {
                Title=book.Title,
                CategoryId=book.CategoryId,
                Author=book.Author,
                Price=book.Price,
            };
            bookService.Add(created);
            return Ok("Book added succesfully!");
        }

        [HttpPut]
        public IActionResult Edit(BookUpdatedVM updatedVM) 
        {
            var data = bookService.GetEntityById(updatedVM.BookId);

            data.Title  = updatedVM.Title;
            data.CategoryId=updatedVM.CategoryId;
            data.Author=updatedVM.Author;
            data.Price=updatedVM.Price;

            bookService.Update(data);
            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var data = bookService.GetEntityById(id);
            if (data == null)
                return NotFound();
            bookService.Remove(data);
            return NoContent();
        }
    }
}
