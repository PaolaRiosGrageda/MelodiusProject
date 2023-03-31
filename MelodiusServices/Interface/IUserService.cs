using MelodiusDataTransfer;

namespace MelodiusServices.Interface
{
    public interface IUserService
    {
        public List<UserDto> GetAll();
        public UserDto GetById(int id);
        public int AddNew(UserDto userDto);
        public UserDto Update(UserDto userDto);
        public int Delete(int id);
    }
}
