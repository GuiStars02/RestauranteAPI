using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Data.Models;
using RestauranteAPI.Services.Interfaces;
using System.Threading.Tasks;

namespace RestauranteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BalancoController : ControllerBase
    {
        private readonly IBalancoService _service;

        public BalancoController(IBalancoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBalanco()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBalanco(Balanco balanco)
        {
            try
            {
                if(balanco is null)
                {
                    return BadRequest("O balanço não pode ser nulo");
                }

                await _service.CreateBalanco(balanco);
                return Ok(balanco);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
