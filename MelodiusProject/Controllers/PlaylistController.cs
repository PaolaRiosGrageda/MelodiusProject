using MelodiusDataTransfer;
using MelodiusDataTransfer.Requests;
using MelodiusDataTransfer.Responses;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistController: ControllerBase
    {
        private readonly IPlaylistService _playlistService;
        public PlaylistController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }
        
        [HttpGet()]
        public async Task<ActionResult<List<PlaylistDto>>> GetPlaylists()
        {
            try
            {
                var playlists = await _playlistService.GetAll();
                return Ok(playlists);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }

        }

        [HttpPost()]
        public async Task<ActionResult> AddNewPlaylist([FromBody] PlaylistDto playlist)
        {
            try
            {
                var newId = await _playlistService.AddNew(playlist);
                var anonymouseResponse = new
                {
                    newId
                };
                return Ok(anonymouseResponse);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPost("CompletePlaylist")]
        public async Task<ActionResult<CompletePlaylistResponse>> AddNewPlaylist(CompletePlaylistRequest playlist)
        {
            try
            {
                var response = await _playlistService.AddCompletePlaylist(playlist);
                return Ok(response);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
