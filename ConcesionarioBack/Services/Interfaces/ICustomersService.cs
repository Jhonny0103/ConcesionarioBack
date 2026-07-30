using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;

namespace ConcesionarioBack.Services.Interfaces
{
    public interface ICustomersService
    {
        public Task<List<Customer>> GetCustomersAsync();
        public Task<Customer> GetCustomerByIdAsync(int id);
        public Task<Customer> CreateCustomerAsync(CreateCustomerDto customer);
        public Task<Customer> UpdateCustomerAsync(UpdateCustomerDto customer);
        public Task<bool> DeleteCustomerAsync(int id);
    }
}
