using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer;
using MelodiusDataTransfer.Mappers;
using MelodiusModels;
using MelodiusServices.Interface;


namespace MelodiusServices.Services
{
    internal class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> AddNew(UserDto userDto)
        {
            User user = UserMapper.DtoToModel(userDto);
            return _userRepository.CreateAsync(user).Id;
        }

        public async Task<int> Delete(int id)
        {
            return _userRepository.Delete(id).Id;
        }

        public async Task<List<UserDto>> GetAll()
        {
            var users = _userRepository.GetAll();
            var usersDto = users.Select(UserMapper.ModelToDto).ToList();
            return usersDto;
        }

        public async Task<UserDto> GetById(int id)
        {
            var user = _userRepository.GetOne(id);
            return UserMapper.ModelToDto(user);
        }

        public async Task<UserDto> Update(UserDto userDto)
        {
            var user = UserMapper.DtoToModel(userDto);
            var userModel = _userRepository.Update(user);
            return UserMapper.ModelToDto(userModel);

        }
        // preguntar a los chicos
        int IBaseService<UserDto>.AddNew(UserDto baseDto)
        {
            throw new NotImplementedException();
        }

        int IBaseService<UserDto>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<UserDto> IBaseService<UserDto>.GetAll()
        {
            throw new NotImplementedException();
        }

        UserDto IBaseService<UserDto>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        UserDto IBaseService<UserDto>.Update(UserDto baseDto)
        {
            throw new NotImplementedException();
        }
    }
}
