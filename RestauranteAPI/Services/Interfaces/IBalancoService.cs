using RestauranteAPI.Data.Models;

namespace RestauranteAPI.Services.Interfaces
{
    public interface IBalancoService
    {
        Task<IEnumerable<Balanco>> GetAll();
        Task<Balanco> CreateBalanco(Balanco balanco);
    }
}
