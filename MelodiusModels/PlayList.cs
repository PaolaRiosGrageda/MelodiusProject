using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Playlist : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<PlaylistSongs> PlaylistSongs { get; set;}
        public ICollection<UserPlayList>? UserPlayList { get; set; }

    }
}
