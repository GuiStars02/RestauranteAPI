using RestauranteAPI.Data.Models;
using RestauranteAPI.Repositories.Interface;
using RestauranteAPI.Services.Interfaces;

namespace RestauranteAPI.Services
{
    public class BalancoService : IBalancoService
    {
        private readonly IRepositoryTotalFlexBase<Balanco> _repository;

        public BalancoService(IRepositoryTotalFlexBase<Balanco> repository)
        {
            _repository = repository;
        }

        public async Task<Balanco> CreateBalanco(Balanco balanco)
        {
            _repository.Create(balanco);
            await _repository.SaveChangesAsync();
            return balanco;
        }

        public async Task<IEnumerable<Balanco>> GetAll()
        {
            var balancoList = await _repository.GetAllAsync();
            return balancoList;
        }
    }
}
