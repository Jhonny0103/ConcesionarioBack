using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class CustomersService
    {
        private ConcesionarioDbContext context;
        public CustomersService(ConcesionarioDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await this.context.Customers.ToListAsync();
        }
    }
}
