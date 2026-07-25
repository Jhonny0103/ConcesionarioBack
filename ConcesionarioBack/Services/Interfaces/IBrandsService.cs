using ConcesionarioBack.Entities;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IBrandsService
    {
        public Task<List<Brand>> GetBrandsAsync();
    }
}
