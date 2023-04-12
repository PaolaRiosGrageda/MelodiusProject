using MelodiusDataAccess.Persistence;
using MelodiusDataAccess.Repository.Base;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusModels;

namespace MelodiusDataAccess.Repository.Implementation
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MelodiusContext melodiusContext) : base(melodiusContext)
        {

        }
    }
}
