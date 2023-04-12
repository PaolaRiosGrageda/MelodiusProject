using MelodiusDataTransfer;
using MelodiusModels;
using MelodiusServices.Interface;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;
        public SongController(ISongService songService)
        {
            _songService = songService;
        }
        [HttpGet()]
        public async Task<ActionResult<List<SongDto>>> GetSongs()
        {
            try
            {
                var songs = await _songService.GetAll();
                return Ok(songs);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }

        }
        [HttpPost()]
        public async Task<ActionResult> AddNewSong([FromBody] SongDto song)
        {
            try
            {
                var newId = await _songService.AddNew(song);
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
        //[HttpGet("SongNameQuery")]
        //public async Task<ActionResult<Song>> GetSongName([FromQuery] string songName)
        //{
        //    var song= _songService.GetByname(songName);
        //    return Ok(song);
        //}

        [HttpPut()]
        public async Task<ActionResult> UpdateSong([FromBody] SongDto song)
        {
            try
            {
                var songUdpated = await _songService.Update(song);
                return Ok(songUdpated);
            }
            catch (Exception e)
            {
                var badResponse = new { error = e.Message };
                return BadRequest(badResponse);
            }
        }

    }
}
