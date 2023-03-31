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
        public async Task<int> AddNew(PlaylistDto playlistDto)
        {
            Playlist playlist = PlaylistMapper.DtoToModel(playlistDto);
            var newPlayList = await _playlistRepository.CreateAsync(playlist);
            return   newPlayList.Id;
        }

        public async Task<int> Delete(int id)
        {
            return _playlistRepository.Delete(id).Id;
        }

        public async Task< List<PlaylistDto>> GetAll()
        {
            var playlists = await _playlistRepository.GetAllAsync();
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
