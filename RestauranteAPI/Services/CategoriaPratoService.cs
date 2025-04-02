using RestauranteAPI.Data.Models;
using RestauranteAPI.Repositories.Interface;
using RestauranteAPI.Services.Interfaces;

namespace RestauranteAPI.Services
{
    public class CategoriaPratoService : ICategoriaPratoService
    {
        private readonly IRepositoryTotalFlexBase<CategoriaPrato> _repository;

        public CategoriaPratoService(IRepositoryTotalFlexBase<CategoriaPrato> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CategoriaPrato>> GetAll()
        {
            var categoriaPratoList = await _repository.GetAllAsync();
            return categoriaPratoList;
        }

        public async Task<CategoriaPrato> GetCategoriaPrato(int idCategoriaPrato)
        {
            var categoriaPrato = await _repository.GetFirstOrDefaultAsync(x => x.IdCategoriaPrato == idCategoriaPrato);
            return categoriaPrato;
        }
        public async Task<CategoriaPrato> CreateCategoriaPrato(CategoriaPrato categoriaPrato)
        {
            _repository.Create(categoriaPrato);
            await _repository.SaveChangesAsync();
            return categoriaPrato;
        }

        public async Task<bool> DeleteCategoriaPrato(int idCategoriaPrato)
        {
            var categoriaPrato = await _repository.GetFirstOrDefaultAsync(x => x.IdCategoriaPrato == idCategoriaPrato);

            if(categoriaPrato is null)
            {
                return false;
            }

            _repository.Delete(categoriaPrato);
            await _repository.SaveChangesAsync();
            return true;
        }

        public async Task UpdateCategoriaPrato(CategoriaPrato categoriaPrato)
        {
            _repository.Update(categoriaPrato);
            await _repository.SaveChangesAsync();
        }
    }
}
