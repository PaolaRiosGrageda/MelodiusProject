﻿using MelodiusModels;
using Microsoft.EntityFrameworkCore;

namespace MelodiusDataAccess.Persistence
{
    public class MelodiusContext : DbContext
    {
        public MelodiusContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> PlayLists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<PlaylistSongs> PlaylistSongs { get; set; }     
        public DbSet<UserPlayList> UserPlayLists { get; set; }
        public DbSet<ArtistSong> ArtistSongs { get; set; }

    }
}
