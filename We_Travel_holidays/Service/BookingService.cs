using HolidayPackages.Models;
using Microsoft.EntityFrameworkCore;

namespace HolidayPackages.Service
{
    public class BookingService : IBook
    {
        private HolidayPackagesContext _context;

        public BookingService(HolidayPackagesContext context)
        {
            _context = context;
        }
        public async Task<List<BookingTable>> AddUser(BookingTable book)
        {
            await _context.BookingTables.AddAsync(book);
                await _context.SaveChangesAsync();
            var books= await _context.BookingTables.ToListAsync();
            return books;

        }
    }
}