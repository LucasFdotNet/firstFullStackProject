using Microsoft.EntityFrameworkCore;

namespace MoviesInfrastructure
{
    internal class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
