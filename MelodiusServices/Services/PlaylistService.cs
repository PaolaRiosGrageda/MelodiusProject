using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer.Mappers;
using MelodiusDataTransfer;
using MelodiusModels;
using MelodiusServices.Interface;

namespace MelodiusServices.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;

        public PlaylistService(IPlaylistRepository playlistRepository)
        {
            _playlistRepository = playlistRepository;
        }
        public int AddNew(PlaylistDto playlistDto)
        {
            Playlist playlist = PlaylistMapper.DtoToModel(playlistDto);
            return _playlistRepository.CreateAsync(playlist).Id;
        }

        public int Delete(int id)
        {
            return _playlistRepository.Delete(id).Id;
        }

        public List<PlaylistDto> GetAll()
        {
            var playlists = _playlistRepository.GetAll();
            var playlistsDto = playlists.Select(PlaylistMapper.ModelToDto).ToList();
            return playlistsDto;
        }

        public PlaylistDto GetById(int id)
        {
            var playlist = _playlistRepository.GetOne(id);
            return PlaylistMapper.ModelToDto(playlist);
        }

        public PlaylistDto Update(PlaylistDto playlistDto)
        {
            var playlist = PlaylistMapper.DtoToModel(playlistDto);
            var playlistModel = _playlistRepository.Update(playlist);
            return PlaylistMapper.ModelToDto(playlistModel);
        }
    }
}
