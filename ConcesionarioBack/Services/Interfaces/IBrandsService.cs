using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface IBrandsService
    {
        public Task<List<Brand>> GetBrandsAsync();
        public Task<Brand> GetBrandByIdAsync(int id);
        public Task<Brand> CreateBrandAsync(CreateBrandDto brand);
        public Task<Brand> UpdateBrandAsync(UpdateBrandDto brand);
        public Task<bool> DeleteBrandAsync(int id);
    }
}
