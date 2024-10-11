using Microsoft.AspNetCore.Mvc;
using WFConFin.Models;

namespace WFConFin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private static List<Estado> listaEstados = new List<Estado>();

        [HttpGet("estado")]
        public ActionResult GetEstados()
        {
            return Ok(listaEstados);
        }

        [HttpPost("estado")]
        public ActionResult PostEstados([FromBody] Estado estado)
        {
            listaEstados.Add(estado);
            return Ok("Estado cadastrado");
        }
    }
}
