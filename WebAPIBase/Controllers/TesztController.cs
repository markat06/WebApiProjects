using Microsoft.AspNetCore.Mvc;

namespace WebAPIBase.Controllers
{
    public class TesztController : Controller
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();

            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                Content = pontosIdő
            };
        }

        //Egyszerűbben
        //[HttpGet]
        //[Route("corvinus/szerverido")]
        //public IActionResult M1()
        //{
        //    string pontosIdő = DateTime.Now.ToShortTimeString();

        //    return Ok(pontosIdő);
        //}

        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                Content = szoveg.ToUpper()
            };
            return BadRequest("Nem jó a bemenő adat");
        }

        //Egyszerűbben
        //[HttpGet]
        //[Route("corvinus/nagybetus/{szoveg}")]
        //public IActionResult M2(string szoveg)
        //{
        //    return Ok(szoveg.ToUpper());
        //}
    }
}
