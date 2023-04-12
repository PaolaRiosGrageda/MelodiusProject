using MelodiusModels.Base;

namespace MelodiusModels
{
    public class UserPlayList:BaseEntity
    {
        public virtual User user { get; set; } = null!;
        public int UserId { get; set; }

        public virtual Playlist playlist { get; set; } = null!;
        public int PlaylistId { get; set; }

        public DateTime? CreatedDate { get; set; }


    }
}
