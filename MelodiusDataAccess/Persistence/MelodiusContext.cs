using MelodiusModels;
using Microsoft.EntityFrameworkCore;

namespace MelodiusDataAccess.Persistence
{
    public class MelodiusContext : DbContext
    {
        public MelodiusContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
