using Net6_EF_Repository.Models;

namespace Net6_EF_Repository.Services
{
    public interface IBranchesService
    {
        IEnumerable<Branches> GetAll();
    }
}
