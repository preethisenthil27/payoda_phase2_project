using HolidayPackages.Models;

namespace HolidayPackages.Service
{
    public interface IBook
    {
        Task<List<BookingTable> >AddUser(BookingTable book);
    }
}
