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
        public async Task <int> AddNew(ArtistDto artistDto)
        {
            Artist artist = ArtistMapper.DtoToModel(artistDto);
            var newArtist = await _artistRepository.CreateAsync(artist);
            return newArtist.Id;
        }

        public int Delete(int id)
        {
            return _artistRepository.Delete(id).Id;
        }

        public async Task<List<ArtistDto>> GetAll()
        {
            var artists = await _artistRepository.GetAllAsync();
            var artistsDto =  artists.Select(ArtistMapper.ModelToDto).ToList();
            return artistsDto;
        }

        public ArtistDto GetById(int id)
        {
            var artist = _artistRepository.GetOne(id);
            return ArtistMapper.ModelToDto(artist);
        }

        public async Task<ArtistDto> Update(ArtistDto artistDto)
        {
            var artist = ArtistMapper.DtoToModel(artistDto);
            var artistModel = await _artistRepository.Update(artist);
            return ArtistMapper.ModelToDto(artistModel);
        }
    }
}
