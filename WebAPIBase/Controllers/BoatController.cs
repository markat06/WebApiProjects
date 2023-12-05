using Microsoft.AspNetCore.Mvc;
using WebAPIBase.Models;

namespace WebAPIBase.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]

    public class BoatController : Controller
    {
        //[HttpGet]
        //[Route("questions/all")]
        //public IActionResult MindegyHogyHivjak()
        //{
        //    HajosContext context = new HajosContext();
        //    var kérdések = from x in context.Questions select x.Question1;

        //    return Ok(kérdések);
        //}

        [HttpGet]
        [Route("questions/{sorszám}")]
        public ActionResult M2(int sorszám)
        {
            HajosContext context = new HajosContext();
            var kérdés = (from x in context.Questions
                          where x.QuestionId == sorszám
                          select x).FirstOrDefault();

            if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

            return new JsonResult(kérdés);
        }
    }
}
