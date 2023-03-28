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

        public ArtistController(IArtistService bookService)
        {
            _artistsService = bookService;
        }


        [HttpGet()]
        public ActionResult<List<ArtistDto>> GetArtists()
        {
            try
            {
                var artists = _artistsService.GetAll();
                return Ok(artists);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }

        }

    }
}
