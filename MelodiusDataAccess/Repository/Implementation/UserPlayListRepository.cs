using MelodiusDataAccess.Persistence;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class UserPlayListRepository : BaseRepository<UserPlayList>, IUserPlaylistRepository
    {
        public UserPlayListRepository(MelodiusContext melodiusContext) : base(melodiusContext)
        {

        }
    }
}
