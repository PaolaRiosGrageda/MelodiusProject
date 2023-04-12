using MelodiusDataAccess.Repository.Interfaces;
using MelodiusDataTransfer.Mappers;
using MelodiusDataTransfer;
using MelodiusModels;
using MelodiusServices.Interface;
using MelodiusDataTransfer.Responses;
using MelodiusDataTransfer.Requests;

namespace MelodiusServices.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playlistRepository;
        private readonly IPlaylistSongsRepository _playlistSongsRepository;
        private readonly ISongRepository _songRepository;
        private readonly IUserPlaylistRepository _userPlaylistRepository;
        private readonly IUserRepository _userRepository;

        public PlaylistService(IPlaylistRepository playlistRepository,
        IPlaylistSongsRepository playlistSongsRepository,
        ISongRepository songRepository,
        IUserPlaylistRepository userPlaylistRepository,
        IUserRepository userRepository)
        {
            _playlistRepository = playlistRepository;
            _playlistSongsRepository = playlistSongsRepository;
            _songRepository = songRepository;
            _userPlaylistRepository = userPlaylistRepository;
            _userRepository = userRepository;
        }



        public async Task<CompletePlaylistResponse> AddCompletePlaylist(CompletePlaylistRequest completePlaylist)
        {
            // -- creates the playlist
            PlaylistDto playlistDto = completePlaylist.Playlist;
            Playlist playlist = PlaylistMapper.DtoToModel(playlistDto);
            Playlist newPlaylist = await _playlistRepository.CreateAsync(playlist);

            // -- gets the user
            User user = await _userRepository.GetOneAsync(completePlaylist.UserId);

            // -- saves the relation
            UserPlayList userPlayList = new UserPlayList();
            userPlayList.PlaylistId = newPlaylist.Id;
            userPlayList.playlist = newPlaylist;
            userPlayList.UserId = user.Id;
            userPlayList.CreatedDate = DateTime.UtcNow;
            UserPlayList userPlaylistSaved = await _userPlaylistRepository.CreateAsync(userPlayList);

            foreach (var item in completePlaylist.SongsIds)
            {
                var song = await _songRepository.GetOneAsync(item);

                PlaylistSongs playlistSongs = new PlaylistSongs();
                playlistSongs.SongId = song.Id;
                playlistSongs.PlayListId = newPlaylist.Id;
                await _playlistSongsRepository.CreateAsync(playlistSongs);
            }

            CompletePlaylistResponse response = new CompletePlaylistResponse();
            response.PlaylistId = userPlaylistSaved.PlaylistId;
            response.PlaylistName = userPlaylistSaved.playlist.Title;
            response.UserName = userPlaylistSaved.user.UserName;

            return response;
        }

        public async Task<int> AddNew(PlaylistDto playlistDto)
        {
            Playlist playlist = PlaylistMapper.DtoToModel(playlistDto);
            var newPlayList = await _playlistRepository.CreateAsync(playlist);
            return newPlayList.Id;
        }

        public async Task<int> Delete(int id)
        {
            return _playlistRepository.Delete(id).Id;
        }

        public async Task<List<PlaylistDto>> GetAll()
        {
            var playlists = await _playlistRepository.GetAllAsync();
            var playlistsDto = playlists.Select(PlaylistMapper.ModelToDto).ToList();
            return playlistsDto;
        }

        public async Task<PlaylistDto> GetById(int id)
        {
            var playlist = await _playlistRepository.GetOneAsync(id);
            return PlaylistMapper.ModelToDto(playlist);
        }

        public async Task<PlaylistDto> Update(PlaylistDto playlistDto)
        {
            var playlist = PlaylistMapper.DtoToModel(playlistDto);
            var playlistModel = await _playlistRepository.Update(playlist);
            return PlaylistMapper.ModelToDto(playlistModel);
        }
    }
}
