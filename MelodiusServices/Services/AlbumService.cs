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
        public int AddNew(AlbumDto albumDto)
        {
            Album album = AlbumMapper.DtoToModel(albumDto);
            return _albumRepository.Create(album).Id;
        }

        public int Delete(int id)
        {
            return _albumRepository.Delete(id).Id;
        }

        public List<AlbumDto> GetAll()
        {
            var albums = _albumRepository.GetAll();
            var albumsDto = albums.Select(AlbumMapper.ModelToDto).ToList();
            return albumsDto;
        }

        public AlbumDto GetById(int id)
        {
            var album = _albumRepository.GetOne(id);
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
