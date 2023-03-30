using MelodiusDataTransfer;

namespace MelodiusServices.Interface
{
    public interface IUserService:IBaseService<UserDto>
    {
        public Task<List<UserDto>> GetAll();
        public Task<UserDto> GetById(int id);
        public Task<int> AddNew(UserDto userDto);
        public Task<UserDto> Update(UserDto userDto);
        public Task<int> Delete(int id);
    }
}
