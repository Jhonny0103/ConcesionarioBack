using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class BrandsService
    {
        private ConcesionarioDbContext context;
        public BrandsService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Brand>> GetBrandsAsync()
        {
            return await this.context.Brands.ToListAsync();
        }
    }
}
