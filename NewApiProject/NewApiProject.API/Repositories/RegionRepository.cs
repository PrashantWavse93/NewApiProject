using Microsoft.EntityFrameworkCore;
using NewApiProject.API.Data;
using NewApiProject.API.Models.Domain;

namespace NewApiProject.API.Repositories
{
    public class RegionRepository:IRegionRepository
    {
        private readonly NZWalksDbContext _nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this._nZWalksDbContext = nZWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await _nZWalksDbContext.Region.ToListAsync();
        }
    }
}
