using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Repositories
{
    public interface IBranchesRepository
    {
        IEnumerable<Branches> GetAll();
    }
}
