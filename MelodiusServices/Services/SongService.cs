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
        public int AddNew(SongDto songDto)
        {
            Song song = SongMapper.DtoToModel(songDto);
            return _songRepository.CreateAsync(song).Id;
        }

        public int Delete(int id)
        {
            return _songRepository.Delete(id).Id;
        }

        public List<SongDto> GetAll()
        {
            var songs = _songRepository.GetAll();
            var songDto = songs.Select(SongMapper.ModelToDto).ToList();  
            return songDto;
        }

        public SongDto GetById(int id)
        {
            var song = _songRepository.GetOne(id);
            return SongMapper.ModelToDto(song);
        }

        public SongDto Update(SongDto songDto)
        {
            var song = SongMapper.DtoToModel(songDto);
            var songModel = _songRepository.Update(song);
            return SongMapper.ModelToDto(songModel);
        }
    }
}
