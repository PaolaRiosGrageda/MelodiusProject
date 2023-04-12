using MelodiusModels.Base;


namespace MelodiusModels
{
    public class Song: BaseEntity 
    {
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double Length { get; set; }
        public  string Genre { get; set; }

        #region
        public ICollection<AlbumSong> AlbumSongs { get; set; }
        public ICollection<ArtistSong>? ArtistSong { get; set; }
        public ICollection<PlaylistSongs>? PlaylistSongs { get; set; }
        #endregion

    }
}
