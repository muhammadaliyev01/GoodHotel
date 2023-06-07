using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoodHotel.Wep.Controllers
{
    [Route("abouts")]
    [Authorize]
    public class AboutsController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
