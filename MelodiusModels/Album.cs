using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Album : BaseEntity
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        #region
        public virtual Artist Artist { get; set; }
        public int ArtistId { get; set; }
        public ICollection<AlbumSong> AlbumSongs { get; set; }
        #endregion
    }
}
