﻿using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer;
using MelodiusDataTransfer.Mappers;
using MelodiusModels;
using MelodiusServices.Interface;


namespace MelodiusServices.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> AddNew(UserDto userDto)
        {
            User user = UserMapper.DtoToModel(userDto);
            var newUser = await _userRepository.CreateAsync(user);
            return newUser.Id;
        }

        public int Delete(int id)
        {
            return _userRepository.Delete(id).Id;
        }

        public async Task<List<UserDto>> GetAll()
        {
            var users = await _userRepository.GetAllAsync();
            var usersDto = users.Select(UserMapper.ModelToDto).ToList();
            return usersDto;
        }

        public UserDto GetById(int id)
        {
            var user = _userRepository.GetOne(id);
            return UserMapper.ModelToDto(user);
        }

        public async Task<UserDto> Update(UserDto userDto)
        {
            var user = UserMapper.DtoToModel(userDto);
            var userModel = await _userRepository.Update(user);
            return UserMapper.ModelToDto(userModel);
        }
    }
}
