using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTransfer
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; } = null; 
        public double Length { get; set; }
        public string Genre { get; set; }
    }
}
