using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Repositories
{
    public class BranchesRepository : IBranchesRepository
    {
        private readonly BranchMgmtContext _branchMgmtContext;

        public BranchesRepository(BranchMgmtContext branchMgmtContext)
        {
            _branchMgmtContext = branchMgmtContext;
        }
        public IEnumerable<Branches> GetAll()
        {
            return _branchMgmtContext.Branches.ToList();
        }
    }
}
