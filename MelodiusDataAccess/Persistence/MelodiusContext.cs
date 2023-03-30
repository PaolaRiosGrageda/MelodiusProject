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
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> PlayLists { get; set; }
        
        public DbSet<Artist> Artists { get; set; }
    }
}
