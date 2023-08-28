using Microsoft.EntityFrameworkCore;
using TourismManagement.Models;
using TourismManagement.Services.Interface;

namespace TourismManagement.Services
{
    public class SearchService : ISearch
    {
        public TourismManagementContext _tourismManagementContext;

        public SearchService(TourismManagementContext tourismManagementContext)
        {
            _tourismManagementContext = tourismManagementContext;
        }
        public Task<List<PackageDetail>> SearchByPackages(string packagename)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegionDetail>> SearchByRegions(string regionname)
        {
            var response = await _tourismManagementContext.RegionDetails.
               Where(p => p.RegionName.Contains(regionname, StringComparison.OrdinalIgnoreCase)).ToList();
            return response;
        }

        public Task<List<SpotDetail>> SearchBySpots(string spotname)
        {
            throw new NotImplementedException();
        }
    }
}
