using MelodiusModels.Base;


namespace MelodiusModels
{
    public class PlaylistSongs: BaseEntity
    {
        public virtual Song Song { get; set; }
        public int SongId { get; set; }

        public virtual Playlist PlayList { get; set;}

        public int PlayListId { get; set; }

        public int Position { get; set; }

        public DateTime DateAdded { get; set; }



    }
}
