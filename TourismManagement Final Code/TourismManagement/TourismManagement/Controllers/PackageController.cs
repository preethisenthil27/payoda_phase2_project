using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourismManagement.Models;
using TourismManagement.Services.Interface;

namespace TourismManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        public IPackage _package;

        public PackageController(IPackage package)
        {
            _package = package;
        }

        [HttpGet]
        public async Task<ActionResult<List<PackageDetail>>> GetAllPackages()
        {
            var packages = await _package.GetAllPackages();
            if (packages == null)
            {
                return NotFound("Not Found");
            }
            else
            {
                return Ok(packages);
            }
        }

        [HttpPost]
        public async Task<ActionResult<PackageDetail>> AddStudent(PackageDetail packageDetails)
        {
            var packages = await _package.AddPackages(packageDetails);
            return Ok(packages);
        }


    }
}
