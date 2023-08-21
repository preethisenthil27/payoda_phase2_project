using HolidayPackages.Models;
using HolidayPackages.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace HolidayPackages.Controllers
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
        public async Task<ActionResult<List<BookingTable>>>AddUser(BookingTable book)
            {
            var books = await _book.AddUser(book);
        return Ok(books);
    }


    }
}
