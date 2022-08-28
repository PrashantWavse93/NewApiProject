using NewApiProject.API.Models.Domain;

namespace NewApiProject.API.Repositories
{
    public interface IRegionRepository
    {
      Task<IEnumerable<Region>> GetAllAsync();
    }
}
