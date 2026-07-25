using ConcesionarioBack.Entities;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface ICustomersService
    {
        public Task<List<Customer>> GetCustomersAsync();
    }
}
