using MelodiusDataAccess.Persistence;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(MelodiusContext melodiusContext) : base(melodiusContext)
        {

        }
    }
}
