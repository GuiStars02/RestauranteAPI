using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Data.Models;
using RestauranteAPI.Services.Interfaces;

namespace RestauranteAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaPratoController : ControllerBase
    {
        private readonly ICategoriaPratoService _service;

        public CategoriaPratoController(ICategoriaPratoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoriaPrato()
        {
            try
            {
                return Ok(await _service.GetAll());
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("{idCategoriaPrato:int}", Name = "GetCategoriaPratoById")]
        public async Task<IActionResult> GetCategoriaPrato(int idCategoriaPrato)
        {
            try
            {
                var categoriaPrato = await _service.GetCategoriaPrato(idCategoriaPrato);
                if(categoriaPrato is null)
                {
                    return NotFound($"Categoria de Id: {idCategoriaPrato} não encontrada");
                }

                return Ok(await _service.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoriaPrato(CategoriaPrato categoriaPrato)
        {
            try
            {
                if(categoriaPrato is null)
                {
                    return BadRequest("Dados inválidos");
                }

                var categoriaPratoCreated = await _service.CreateCategoriaPrato(categoriaPrato);
                return new CreatedAtRouteResult("GetCategoriaPratoById", categoriaPratoCreated.IdCategoriaPrato, categoriaPratoCreated);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut("{idCategoriaPrato:int}")]
        public async Task<IActionResult> UpdateCategoriaPrato(int idCategoriaPrato, CategoriaPrato categoriaPrato)
        {
            try
            {
                if (categoriaPrato.IdCategoriaPrato != idCategoriaPrato)
                {
                    return BadRequest("Dados inválidos");
                }

                await _service.UpdateCategoriaPrato(categoriaPrato);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("{idCategoriaPrato:int}")]
        public async Task<IActionResult> DeletePrato(int idCategoriaPrato)
        {
            try
            {
                var result = await _service.DeleteCategoriaPrato(idCategoriaPrato);
                if (result)
                {
                    return Ok("Categoria excluída com sucesso");
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao excluir a categoria de id: {idCategoriaPrato}");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
