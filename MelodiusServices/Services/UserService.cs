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

        public int AddNew(UserDto userDto)
        {
            User user = UserMapper.DtoToModel(userDto);
            return _userRepository.Create(user).Id;
        }

        public int Delete(int id)
        {
            return _userRepository.Delete(id).Id;
        }

        public List<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();
            var usersDto = users.Select(UserMapper.ModelToDto).ToList();
            return usersDto;
        }

        public UserDto GetById(int id)
        {
            var user = _userRepository.GetOne(id);
            return UserMapper.ModelToDto(user);
        }

        public UserDto Update(UserDto userDto)
        {
            var user = UserMapper.DtoToModel(userDto);
            var userModel = _userRepository.Update(user);
            return UserMapper.ModelToDto(userModel);
        }
    }
}
