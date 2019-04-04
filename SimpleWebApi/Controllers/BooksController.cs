using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Data;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookContext context;

        public BooksController(BookContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var books = context.Books;
            return Ok(books);
        }
    }
}