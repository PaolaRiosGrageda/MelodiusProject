using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class AlbumSong : BaseEntity
    {
        public virtual Album Album { get; set; }
        public int AlbumId { get; set; }
        public virtual Song Song { get; set; }
        public int SongId { get; set; }
    }
}
