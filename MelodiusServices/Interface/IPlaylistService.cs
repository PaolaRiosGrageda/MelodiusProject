using MelodiusDataTransfer;
using MelodiusDataTransfer.Requests;
using MelodiusDataTransfer.Responses;

namespace MelodiusServices.Interface
{
    public interface IPlaylistService : IBaseService<PlaylistDto>
    {
        public Task<CompletePlaylistResponse> AddCompletePlaylist(CompletePlaylistRequest playlist);
    }
}
