using Microsoft.EntityFrameworkCore;
using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Repositories
{
    public class ApplicationsRepository : IApplicationsRepository
    {
        private readonly BranchMgmtContext _branchMgmtContext;

        public ApplicationsRepository(BranchMgmtContext branchMgmtContext)
        {
            _branchMgmtContext = branchMgmtContext;
        }

        public IEnumerable<Applications> GetAllApps()
        {
            return _branchMgmtContext.Applications.ToList();
        }
        public Applications GetById(int id)
        {
            return _branchMgmtContext.Applications.Find(id);
        }
        public void Add(Applications applications)
        {
            _branchMgmtContext.Applications.Add(applications);
            _branchMgmtContext.SaveChanges();
        }
        public void Update(Applications applications)
        {
            _branchMgmtContext.Entry(applications).State = EntityState.Modified;
            _branchMgmtContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var application = _branchMgmtContext.Applications.Find(id);
            _branchMgmtContext.Applications.Remove(application);
            _branchMgmtContext.SaveChanges();
        }

        

        

        
    }
}
