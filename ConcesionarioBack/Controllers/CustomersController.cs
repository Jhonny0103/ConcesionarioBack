using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomersService service;
        public CustomersController(CustomersService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Customer>>> GetCustomersAsync()
        {
            var customers = await service.GetCustomersAsync();
            return Ok(customers);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Customer>> GetCustomerByIdAsync(int id)
        {
            try
            {
                var customer = await service.GetCustomerByIdAsync(id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Customer>> CreateCustomerAsync(CreateCustomerDto customer)
        {
            try
            {
                var createdCustomer = await service.CreateCustomerAsync(customer);
                return Ok(createdCustomer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<ActionResult<Customer>> UpdateCustomerAsync(UpdateCustomerDto customer)
        {
            try
            {
                var updatedCustomer = await service.UpdateCustomerAsync(customer);
                return Ok(updatedCustomer);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult<bool>> DeleteCustomerAsync(int id)
        {
            try
            {
                var deleted = await service.DeleteCustomerAsync(id);
                return Ok(deleted);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }    
    }
}
