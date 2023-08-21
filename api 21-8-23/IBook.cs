using TourismManagement.Models;

namespace TourismManagement.Services
{
    public interface IBook
    {
        Task<List<BookingDetail>> AddUser(BookingDetail book);
    }
}
