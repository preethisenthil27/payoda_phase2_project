using Microsoft.EntityFrameworkCore;
using TourismManagement.Models;

namespace TourismManagement.Services
{
    public class BookingService : IBook
          {
        private TourismManagementContext _context;
             public BookingService(TourismManagementContext context)
        {
            _context = context;
        }
        public async Task<List<BookingDetail>>AddUser(BookingDetail book)
        {
            await _context.BookingDetails.AddAsync(book);
        await _context.SaveChangesAsync();
        var books = await _context.BookingDetails.ToListAsync();
            return books;

        }
    }
}
