using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Services
{
    public interface IApplicationsService
    {
        IEnumerable<Applications> GetAllApps();
        Applications GetById(int id);
        void Add(Applications applications);
        void Update(Applications applications);
        void Delete(int id);
    }
}
