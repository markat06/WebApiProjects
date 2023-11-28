using Microsoft.AspNetCore.Mvc;
using WebAPIBase.Models;

namespace WebAPIBase.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]

    public class BoatController : Controller
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult MindegyHogyHivjak()
        {
            HajosContext context = new HajosContext();
            var kérdések = from x in context.Questions select x.Question1;

            return Ok(kérdések);
        }
    }
}
