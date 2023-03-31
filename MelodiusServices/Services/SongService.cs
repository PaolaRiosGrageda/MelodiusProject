using MelodiusDataAccess.Repository.Implementation;
using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer;
using MelodiusDataTransfer.Mappers;
using MelodiusModels;
using MelodiusServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository= songRepository;
        }
        public async Task<int> AddNew(SongDto songDto)
        {
            Song song = SongMapper.DtoToModel(songDto);
            var newSong = await _songRepository.CreateAsync(song);
            return newSong.Id;
        }

        public async Task<int> Delete(int id)
        {
            return _songRepository.Delete(id).Id;
        }

        public async Task<List<SongDto>> GetAll()
        {
            var songs = await _songRepository.GetAllAsync();
            var songDto = songs.Select(SongMapper.ModelToDto).ToList();  
            return songDto;
        }

        public async Task<SongDto> GetById(int id)
        {
            var song = await _songRepository.GetOneAsync(id);
            return SongMapper.ModelToDto(song);
        }

        public async Task<SongDto> Update(SongDto songDto)
        {
            var song = SongMapper.DtoToModel(songDto);
            var songModel = await _songRepository.Update(song);
            return SongMapper.ModelToDto(songModel);
        }
    }
}
