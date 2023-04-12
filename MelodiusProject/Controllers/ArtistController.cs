using MelodiusDataTransfer;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistsService;

        public ArtistController(IArtistService artistService)
        {
            _artistsService = artistService;
        }


        [HttpGet()]
        public async Task<ActionResult<List<ArtistDto>>> GetArtists()
        {
            try
            {
                var artists = await _artistsService.GetAll();
                return Ok(artists);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }

        }

        [HttpPost()]
        public async Task<ActionResult> AddNewArtist([FromBody] ArtistDto artist)
        {
            try
            {
                var newId = await _artistsService.AddNew(artist);
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
        public async Task<ActionResult> UpdateArtist([FromBody] ArtistDto artist)
        {
            try
            {
                var artistUdpated = await _artistsService.Update(artist);
                return Ok(artistUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }
    }
}
