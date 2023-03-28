using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Song: BaseEntity 
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Length { get; set; }
        public  string Genre { get; set; }
    }
}
