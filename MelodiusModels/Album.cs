using MelodiusModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusModels
{
    public class Album : BaseEntity
    {
        public string Title { get; set; }
        public DateOnly ReleaseDate { get; set; }
    }
}
