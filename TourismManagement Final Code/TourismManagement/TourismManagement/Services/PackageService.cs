using Microsoft.EntityFrameworkCore;
using TourismManagement.Models;
using TourismManagement.Services.Interface;

namespace TourismManagement.Services
{
    public class PackageService : IPackage
    {
        public TourismManagementContext _tourismManagementContext;

        public PackageService(TourismManagementContext tourismManagementContext)
        {
            _tourismManagementContext = tourismManagementContext;
        }
        public async Task<List<PackageDetail>> GetAllPackages()
        {
            var response = await _tourismManagementContext.PackageDetails.ToListAsync();
            return response;
        }

        public async Task<List<PackageDetail>> AddPackages(PackageDetail packageDetails)
        {
            _tourismManagementContext.PackageDetails.Add(packageDetails);
            await _tourismManagementContext.SaveChangesAsync();
            return await _tourismManagementContext.PackageDetails.ToListAsync();

        }
        
       
    }
}
