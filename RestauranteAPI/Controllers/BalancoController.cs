using Microsoft.AspNetCore.Mvc;

namespace RestauranteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BalancoController : ControllerBase
    {

        [HttpPost]
        public IActionResult CriarBalanco(object balanco)
        {
            return Ok();
        }
    }
}
