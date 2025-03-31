using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Data;

namespace RestauranteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PratoController : ControllerBase
    {
        private readonly RestauranteContext _context;

        public PratoController(RestauranteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPratos()
        {
            try
            {
                return Ok(_context.Prato);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
