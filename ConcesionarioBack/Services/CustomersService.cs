using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarioBack.Services
{
    public class CustomersService: ICustomersService
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
