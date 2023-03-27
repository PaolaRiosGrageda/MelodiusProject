using MelodiusModels;

namespace MelodiusDataTransfer.Mappers
{
    public static class UserMapper
    {

        public static User DtoToModel(UserDto userDto)
        => new User()
        {
            Id = userDto.Id,
            Name = userDto.Name,
            Password = userDto.Password,
            UserName = userDto.UserName,
            Email = userDto.Email,
        };

        public static UserDto ModelToDto(User user)
        => new UserDto()
        {
            Id = user.Id,
            Name = user.Name,
            Password = user.Password,
            UserName = user.UserName,
            Email = user.Email,
        };

    }
}
