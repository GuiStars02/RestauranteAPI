using RestauranteAPI.Data.Models;

namespace RestauranteAPI.Services.Interfaces
{
    public interface ICategoriaPratoService
    {
        Task<IEnumerable<CategoriaPrato>> GetAll();
        Task<CategoriaPrato> GetCategoriaPrato(int idCategoriaPrato);
        Task<CategoriaPrato> CreateCategoriaPrato(CategoriaPrato categoriaPrato);
        Task UpdateCategoriaPrato(CategoriaPrato categoriaPrato);
        Task<bool> DeleteCategoriaPrato(int idCategoriaPrato);

        
    }
}
