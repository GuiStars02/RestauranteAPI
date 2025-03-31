using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Data;

namespace RestauranteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PratosController : ControllerBase
    {
        private readonly RestauranteContext _context;

        public PratosController(RestauranteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPratos()
        {
            try
            {
                return Ok(_context.Pratos);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
