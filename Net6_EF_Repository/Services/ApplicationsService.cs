using Net6_EF_Repository.Models;
using Net6_EF_Repository.Repositories;

namespace Net6_EF_Repository.Services
{
    public class ApplicationsService : IApplicationsService
    {
        private readonly IApplicationsRepository _applicationsRepository;

        public ApplicationsService(IApplicationsRepository applicationsRepository)
        {
            _applicationsRepository = applicationsRepository;
        }
        public IEnumerable<Applications> GetAllApps()
        {
            var applications = _applicationsRepository.GetAllApps();
            var resp = applications.OrderByDescending(m => m.Name);
            return resp;
        }
        public Applications GetById(int id)
        {
            return _applicationsRepository.GetById(id);
        }

        public void Add(Applications applications)
        {
            _applicationsRepository.Add(applications);
        }
        public void Update(Applications applications)
        {
            _applicationsRepository.Update(applications);
        }

        public void Delete(int id)
        {
            _applicationsRepository.Delete(id);
        }

        

        

        
    }
}
