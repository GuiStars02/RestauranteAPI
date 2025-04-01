using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Data.Models;
using RestauranteAPI.Services.Interfaces;

namespace RestauranteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PratoController : ControllerBase
    {
        private readonly IPratoService _service;

        public PratoController(IPratoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetPratos()
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

        [HttpGet("{id}", Name = "ObterPrato")]
        public async Task<IActionResult> GetPratoById(int id)
        {
            try
            {
                var prato = await _service.GetPratoById(id);
                if(prato is null)
                {
                    return NotFound($"Prato com o id: {id} não encontrado");
                }

                return Ok(prato);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrato(Prato prato)
        {
            try
            {
                if(prato is null)
                {
                    return BadRequest("Dados inválidos");
                }

                var pratoCreated = await _service.CreatePrato(prato);
                return new CreatedAtRouteResult("ObterPrato", new { id = prato.IdPrato}, prato);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
