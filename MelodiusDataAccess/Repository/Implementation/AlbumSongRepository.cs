using MelodiusDataAccess.Persistence;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class AlbumSongRepository : BaseRepository<AlbumSong>, IAlbumSongRepository
    {
        public AlbumSongRepository(MelodiusContext melodiusContext) : base(melodiusContext)
        {
        }
    }
}
