using TourismManagement.Models;

namespace TourismManagement.Services.Interface
{
    public interface ISearch
    {
        Task<List<PackageDetail>> SearchByPackages(string packagename);
        Task<List<RegionDetail>> SearchByRegions(string regionname);
        Task<List<SpotDetail>> SearchBySpots(string spotname);

    }
}
