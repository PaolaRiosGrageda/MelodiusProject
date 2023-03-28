using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer;
using MelodiusDataTransfer.Mappers;
using MelodiusModels;
using MelodiusServices.Interface;

namespace MelodiusServices.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        
        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }
        public int AddNew(ArtistDto artistDto)
        {
            Artist artist = ArtistMapper.DtoToModel(artistDto);
            return _artistRepository.Create(artist).Id;
        }

        public int Delete(int id)
        {
            return _artistRepository.Delete(id).Id;
        }

        public List<ArtistDto> GetAll()
        {
            var artists = _artistRepository.GetAll();
            var artistsDto = artists.Select(ArtistMapper.ModelToDto).ToList();
            return artistsDto;
        }

        public ArtistDto GetById(int id)
        {
            var artist = _artistRepository.GetOne(id);
            return ArtistMapper.ModelToDto(artist);
        }

        public ArtistDto Update(ArtistDto artistDto)
        {
            var artist = ArtistMapper.DtoToModel(artistDto);
            var artistModel = _artistRepository.Update(artist);
            return ArtistMapper.ModelToDto(artistModel);
        }
    }
}
