using RestauranteAPI.Data.Models;

namespace RestauranteAPI.Services.Interfaces
{
    public interface IPratoService
    {
        Task<IEnumerable<Prato>> GetAll();
        Task<Prato> GetPratoById(int id);
        Task<Prato> CreatePrato(Prato prato);
        Task UpdatePrato(Prato prato);
        Task DeletePrato(Prato prato);
    }
}
