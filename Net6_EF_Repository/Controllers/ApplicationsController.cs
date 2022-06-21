using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net6_EF_Repository.Models;
using Net6_EF_Repository.Services;

namespace Net6_EF_Repository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly IApplicationsService _applicationsService;

        public ApplicationsController(IApplicationsService applicationsService)
        {
            _applicationsService = applicationsService;
        }
        [HttpGet]
        public IEnumerable<Applications> GetAllApps()
        {
            return _applicationsService.GetAllApps();
        }
        [HttpGet("{id}")]
        public Applications GetById(int id)
        {
            return _applicationsService.GetById(id);
        }

        [HttpPost]
        public void Add(Applications applications)
        {
            _applicationsService.Add(applications);
        }

        [HttpPut("{id}")]
        public void Update(int id, Applications applications)
        {
            _applicationsService.Update(applications);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _applicationsService.Delete(id);
        }
    }
}
