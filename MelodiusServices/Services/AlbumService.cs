using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer.Mappers;
using MelodiusDataTransfer;
using MelodiusModels;
using MelodiusServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusServices.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;

        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public async Task<int> AddNew(AlbumDto albumDto)
        {
            Album album = AlbumMapper.DtoToModel(albumDto);
            var newAlbum = await _albumRepository.CreateAsync(album);
            return newAlbum.Id;
        }

        public int Delete(int id)
        {
            return _albumRepository.Delete(id).Id;
        }

        public async Task<List<AlbumDto>> GetAll()
        {
            var albums =  await _albumRepository.GetAllAsync();
            var albumsDto = albums.Select(AlbumMapper.ModelToDto).ToList();
            return albumsDto;
        }

        public async Task<AlbumDto> GetById(int id)
        {
            var album = await _albumRepository.GetOneAsync(id);
            return AlbumMapper.ModelToDto(album);
        }

        public AlbumDto Update(AlbumDto albumDto)
        {
            var album = AlbumMapper.DtoToModel(albumDto);
            var albumModel = _albumRepository.Update(album);
            return AlbumMapper.ModelToDto(albumModel);
        }
    }
}
