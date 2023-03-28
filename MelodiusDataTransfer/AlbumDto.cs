using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTransfer
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
