using ConcesionarioBack.Data;
using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
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

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            var customer = await this.context.Customers.FindAsync(id);
            if (customer != null)
            {
                return customer;
            }
            else
            {
                throw new Exception($"Customer not found");
            }
        }

        public async Task<Customer> CreateCustomerAsync(CreateCustomerDto customer)
        {
            Customer newCustomer = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            this.context.Customers.Add(newCustomer);
            await this.context.SaveChangesAsync();
            return newCustomer;
        }

        public async Task<Customer> UpdateCustomerAsync(UpdateCustomerDto customer)
        {
            var existingCustomer = await this.context.Customers.FindAsync(customer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.IsActive = customer.IsActive;
                await this.context.SaveChangesAsync();
                return existingCustomer;
            }
            else
            {
                throw new Exception($"Customer not found");
            }
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            var existingCustomer = await this.context.Customers.FindAsync(id);
            if (existingCustomer != null)
            {
                this.context.Customers.Remove(existingCustomer);
                await this.context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new Exception($"Customer not found");
            }
        }
        
    }
}
