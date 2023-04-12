using MelodiusDataTransfer;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumsService;

        public AlbumController(IAlbumService albumService)
        {
            _albumsService = albumService;
        }

        [HttpGet()]
        public async Task<ActionResult<List<AlbumDto>>> GetAlbums()
        {
            try
            {
                var albums = await _albumsService.GetAll();
                return Ok(albums);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }

        }

        [HttpPost()]
        public async Task<ActionResult> AddNewAlbum([FromBody] AlbumDto album)
        {
            try
            {
                var newId = await _albumsService.AddNew(album);
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
        public async Task<ActionResult> UpdateAlbum([FromBody] AlbumDto album)
        {
            try
            {
                var albumUdpated = await _albumsService.Update(album);
                return Ok(albumUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
