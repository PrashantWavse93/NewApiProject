using Microsoft.EntityFrameworkCore;
using NewApiProject.API.Models.Domain;

namespace NewApiProject.API.Data
{
    public class NZWalksDbContext:DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext>options):base(options)    
        {

        }
        public DbSet<Region> Region { get; set; }
        public DbSet<Walk> Walk { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
