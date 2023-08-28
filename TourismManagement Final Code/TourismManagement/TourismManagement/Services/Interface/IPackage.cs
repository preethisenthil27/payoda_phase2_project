using TourismManagement.Models;

namespace TourismManagement.Services.Interface
{
    public interface IPackage
    {
        Task<List<PackageDetail>> GetAllPackages();
        Task<List<PackageDetail>> AddPackages(PackageDetail packageDetails);
       
        
       
    }
}
