using MelodiusDataTransfer;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistService _playlistsService;

        public PlaylistController(IPlaylistService playlistService)
        {
            _playlistsService = playlistService;
        }


        [HttpGet()]
        public async Task<ActionResult<List<PlaylistDto>>> GetPlaylists()
        {
            try
            {
                var playlists = await _playlistsService.GetAll();
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
                var newId = await _playlistsService.AddNew(playlist);
                var anonymousResponse = new
                {
                    newId
                };
                return Ok(anonymousResponse);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

        [HttpPut()]
        public async Task<ActionResult> UpdatePlaylist([FromBody] PlaylistDto playlist)
        {
            try
            {
                var playlistUdpated = await _playlistsService.Update(playlist);
                return Ok(playlistUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
