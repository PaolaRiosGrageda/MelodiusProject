using MelodiusModels.Base;

namespace MelodiusModels
{
    public class ArtistSong: BaseEntity
    {
        public virtual Song song { get; set; } = null!;
        public int SongId { get; set; }

        public virtual Artist artist { get; set; } = null!;
        public int ArtistId { get; set; }
    }
}
