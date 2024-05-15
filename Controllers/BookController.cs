using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private static readonly string[] Titles = new[]
        {
            "Book1", "Book2", "Book3", "Book4", "Book5"
        };

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = Enumerable.Range(0, Titles.Length).Select(index => new Book
            {
                Id = index + 1,
                Title = Titles[index],
                Author = "Author" + (index + 1),
                Reviews = new List<Review>()
            }).ToList();

            return View(books);
        }
    }
}
