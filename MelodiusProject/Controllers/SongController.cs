using Microsoft.AspNetCore.Mvc;

namespace MelodiusAPI.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
