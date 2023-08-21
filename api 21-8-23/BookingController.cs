using Microsoft.AspNetCore.Mvc;
using TourismManagement.Models;
using TourismManagement.Services;

namespace TourismManagement.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IBook _book;
        public BookingController(IBook book)
        {
            _book = book;
        }

        [HttpPost]
        public async Task<ActionResult<List<BookingDetail>>> AddUser(BookingDetail book)
        {
            var books = await _book.AddUser(book);
            return Ok(books);
        }
    }
}
