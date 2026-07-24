using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class SalesService
    {
        private ConcesionarioDbContext context;
        public SalesService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Sale>> GetSalesAsync()
        {
            return await this.context.Sales.ToListAsync();
        }
    }
}
